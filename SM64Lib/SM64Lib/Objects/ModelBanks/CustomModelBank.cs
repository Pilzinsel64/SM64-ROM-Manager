﻿using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Configuration;
using global::SM64Lib.Data;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using global::SM64Lib.SegmentedBanking;
using Newtonsoft.Json;

namespace SM64Lib.Objects.ModelBanks
{
    public class CustomModelBank
    {
        public ObjectModelConfig Config { get; private set; } = new ObjectModelConfig();
        public List<CustomModel> Models { get; private set; } = new List<CustomModel>();
        public SegmentedBank CurSeg { get; private set; } = null;
        public bool NeedToSave { get; set; } = false;
        public Levelscript Levelscript { get; private set; } = new Levelscript();

        [JsonIgnore]
        public int Length
        {
            get
            {
                var length = General.HexRoundUp1(CalcLevelscriptLength());

                foreach (var mdl in Models)
                    length += General.HexRoundUp1(mdl.Model.Length) + General.HexRoundUp1(mdl.Geolayout.Length + 0x40);

                return length;
            }
        }

        private int CalcLevelscriptLength()
        {
            return General.HexRoundUp1(Models.Count * 8 + 4);
        }

        public SegmentedBank WriteToSeg(byte bankID, CollisionBasicConfig collisionConfig)
        {
            var segStream = new MemoryStream();
            var seg = new SegmentedBank(bankID, segStream);
            int lastPos = WriteToSeg(seg, 0, collisionConfig);
            seg.Length = lastPos;
            return seg;
        }

        public int WriteToSeg(SegmentedBank seg, int offset, CollisionBasicConfig collisionConfig)
        {
            var data = new BinaryStreamData(seg.Data);
            int lastPos = WriteToSeg(data, offset, seg.BankID, collisionConfig);
            CurSeg = seg;
            return lastPos;
        }

        public int WriteToSeg(BinaryData data, int offset, byte bankID, CollisionBasicConfig collisionConfig)
        {
            uint lvlScriptLength;
            int bankAddr = Conversions.ToInteger(Conversions.ToUInteger(bankID) << 24);

            // Clear the old levelscript
            Levelscript.Clear();

            // Clear Configuration
            Config.CustomObjectConfigs.Clear();

            // Calculate space of Levelscript
            lvlScriptLength = (uint)CalcLevelscriptLength();

            // Start Custom Objects
            data.Position = offset + lvlScriptLength;
            for (int i = 0, loopTo = Models.Count - 1; i <= loopTo; i++)
            {
                var obj = Models[i];

                // Write Object Model
                obj.ModelBankOffset = Conversions.ToInteger(data.Position - offset);
                var sr = obj.Model.ToBinaryData(data, Conversions.ToInteger(data.Position), offset, bankAddr, collisionConfig);
                data.RoundUpPosition();

                // Write Model Offset & Length & Collision Offset
                data.Write(obj.ModelBankOffset);
                data.Write(Conversions.ToInteger(obj.Model.Fast3DBuffer.Length));
                data.Write(sr.CollisionPointer == -1 ? -1 : sr.CollisionPointer & 0xFFFFFF);
                obj.CollisionPointer = sr.CollisionPointer;
                data.RoundUpPosition();

                // Copy new Geopointer(s)
                obj.Geolayout.Geopointers.Clear();
                obj.Geolayout.Geopointers.AddRange(sr.GeoPointers.ToArray());

                // Write Geolayout
                obj.GeolayoutBankOffset = Conversions.ToInteger(data.Position - offset);
                obj.Geolayout.Write(data.BaseStream, Conversions.ToInteger(data.Position));
                data.RoundUpPosition(0x30);

                // Add object config to object bank config
                Config.CustomObjectConfigs.Add(i, obj.Config);
            }

            // Set length of segmented
            data.RoundUpPosition();
            int lastPosition = Conversions.ToInteger(data.Position);

            // Create Levelscript
            foreach (CustomModel obj in Models)
                Levelscript.Add(new LevelscriptCommand($"22 08 00 {obj.ModelID.ToString("X")} {bankID.ToString("X")} {Conversion.Hex(obj.GeolayoutBankOffset >> 16 & 0xFF)} {Conversion.Hex(obj.GeolayoutBankOffset >> 8 & 0xFF)} {Conversion.Hex(obj.GeolayoutBankOffset & 0xFF)}"));
            Levelscript.Add(new LevelscriptCommand("07 04 00 00"));
            Levelscript.Write(data, offset);
            NeedToSave = false;
            return lastPosition - offset;
        }
        
        public void WriteCollisionPointers(RomManager rommgr)
        {
            BinaryData data = rommgr.GetBinaryRom(FileAccess.ReadWrite);
            WriteCollisionPointers(data);
            data.Close();
        }

        public void WriteCollisionPointers(BinaryData data)
        {
            long posBefore = data.Position;

            foreach (CustomModel obj in Models)
            {
                foreach (int dest in obj.Config.CollisionPointerDestinations)
                {
                    data.Position = dest;
                    data.Write(obj.CollisionPointer);
                }
            }

            data.Position = posBefore;
        }

        public void ReadFromSeg(RomManager rommgr, byte bankID, ObjectModelConfig config)
        {
            ReadFromSeg(rommgr, rommgr.GetSegBank(bankID), config);
        }

        public void ReadFromSeg(RomManager rommgr, SegmentedBank seg, ObjectModelConfig config)
        {
            Stream s;
            BinaryData data;
            Levelscript.Clear();
            CurSeg = seg;
            s = seg.ReadDataIfNull(rommgr);
            data = new BinaryStreamData(s);

            // Get configuration
            Config = config;

            // Read Levelscript
            Levelscript.Read(rommgr, seg.BankAddress, LevelscriptCommandTypes.JumpBack, new Dictionary<byte, SegmentedBank>() { { seg.BankID, seg } });

            // Parse Levelscript & Load Models
            for (int i = 0, loopTo = Levelscript.Count - 1; i <= loopTo; i++)
            {
                LevelscriptCommand cmd = (LevelscriptCommand)Levelscript[i];

                switch (cmd.CommandType)
                {
                    case LevelscriptCommandTypes.LoadPolygonWithGeo:
                        var obj = new CustomModel() { Config = config.GetCustomObjectConfig(i) };

                        // Load Model ID & Geolayout Offset
                        obj.ModelID = clLoadPolygonWithGeo.GetModelID(cmd);
                        int geoAddr = clLoadPolygonWithGeo.GetSegAddress(cmd);
                        obj.GeolayoutBankOffset = geoAddr & 0xFFFFFF;

                        if (geoAddr >> 24 == seg.BankID)
                        {
                            // Load Model Offset & Length
                            data.Position = obj.GeolayoutBankOffset - 0x10;
                            obj.ModelBankOffset = data.ReadInt32();
                            int f3d_length = data.ReadInt32();
                            int colOffset = data.ReadInt32();
                            int colPointer = colOffset | seg.BankAddress;
                            obj.CollisionPointer = colPointer;

                            // Load Geolayout
                            obj.Geolayout = new Geolayout.Geolayout(Geolayout.Geolayout.NewScriptCreationMode.None);
                            obj.Geolayout.Read(rommgr, geoAddr);

                            // Load Model
                            obj.Model = new Model.ObjectModel();
                            obj.Model.FromBinaryData(data, 0, seg.BankAddress, obj.ModelBankOffset, f3d_length, obj.Geolayout.Geopointers.ToArray(), colPointer, rommgr.RomConfig.CollisionBaseConfig);

                            // Add Object to list
                            Models.Add(obj);
                        }

                        break;
                }
            }
        }
    }
}