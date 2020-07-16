using System.Collections.Generic;
using System.Data;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using global::SM64Lib.Objects.ObjectBanks.Data;
using global::SM64Lib.SegmentedBanking;
using SM64Lib.Objects.ModelBanks;
using Newtonsoft.Json;

namespace SM64Lib.Levels
{
    public abstract class Level
    {

        // S h a r e d   M e m b e r s

        internal static readonly byte[] LevelscriptStart = new byte[] { 0x80, 0x8, 0x0, 0x0, 0x19, 0x0, 0x0, 0x1C, 0x8, 0x0, 0x0, 0xA, 0x0, 0xA0, 0x0, 0x78, 0x0, 0xA0, 0x0, 0x78, 0x4, 0x0, 0x0, 0x0, 0xC, 0x0, 0x0, 0x0 };

        // F i e l d s

        protected SegmentedBank _Bank0x19 = null;

        // A u t o   P r o p e r t i e s

        internal LevelscriptCommand LastGobCmdSegLoad { get; set; } = null;
        internal LevelscriptCommand LastLobCmdSegLoad { get; set; } = null;
        [JsonIgnore]
        internal Dictionary<byte, ObjectBankData> MyObjectBanks { get; private set; } = new Dictionary<byte, ObjectBankData>();
        public Levelscript Levelscript { get; set; } = new Levelscript();
        public List<LevelArea> Areas { get; private set; } = new List<LevelArea>();
        public ushort LevelID { get; set; } = 0;
        public LevelBG Background { get; private set; } = new LevelBG();
        public bool ActSelector { get; set; } = false;
        public bool HardcodedCameraSettings { get; set; } = false;
        public bool Closed { get; set; } = false;
        public int LastRomOffset { get; set; } = -1;
        public bool NeedToSaveLevelscript { get; set; } = false;
        public bool NeedToSaveBanks0E { get; set; } = false;
        public bool OneBank0xESystemEnabled { get; set; } = true;
        public bool EnableGlobalObjectBank { get; set; } = false;
        public bool EnableLocalObjectBank { get; set; } = false;
        public CustomModelBank LocalObjectBank { get; private set; } = new CustomModelBank();
        [JsonIgnore]
        public RomManager RomManager { get; set; }

        // O t h e r   P r o p e r t i e s

        [JsonIgnore]
        public IReadOnlyDictionary<byte, ObjectBankData> LoadedObjectBanks
        {
            get
            {
                return MyObjectBanks;
            }
        }

        [JsonIgnore]
        public SegmentedBank Bank0x19
        {
            get
            {
                return _Bank0x19;
            }

            internal set
            {
                _Bank0x19 = value;
            }
        }

        [JsonIgnore]
        public int ObjectsCount
        {
            get
            {
                int tcount = 0;
                foreach (var a in Areas)
                    tcount += a.Objects.Count;
                return tcount;
            }
        }

        [JsonIgnore]
        public int WarpsCount
        {
            get
            {
                int tcount = 0;
                foreach (var a in Areas)
                    tcount += a.Warps.Count;
                return tcount;
            }
        }      

        [JsonIgnore]
        public long Length
        {
            get
            {
                long length = 0;

                if (Bank0x19 is object)
                    length += Bank0x19.Length;
                else
                    length += RomManagerSettings.DefaultLevelscriptSize;

                if (LocalObjectBank is object)
                    length += LocalObjectBank.Length;

                foreach (var area in Areas)
                {
                    length += area.AreaModel.Length;
                    if (OneBank0xESystemEnabled)
                        length += area.Levelscript.Length;
                }

                return length;
            }
        }

        // C o n s t r u c t o r s

        [JsonConstructor]
        protected Level(JsonConstructorAttribute attr)
        {
        }

        protected Level(ushort LevelID, int LevelIndex, RomManager rommgr) : this(rommgr)
        {
            this.LevelID = LevelID;
            CreateNewLevelscript();
            HardcodedCameraSettings = false;
            ActSelector = General.ActSelectorDefaultValues[LevelIndex];
        }

        protected Level(RomManager rommgr)
        {
            RomManager = rommgr;
        }

        // M e t h o d s

        public void CreateNewLevelscript()
        {
            {
                var withBlock = Levelscript;
                withBlock.Close();
                withBlock.Clear();

                // Start Loading Commands
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x1B, 0x4, 0x0, 0x0 }));

                // Loading Commands
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x17, 0xC, 0x1, 0xE, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }));

                // Start Model Commands
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x1D, 0x4, 0x0, 0x0 }));

                // Load Marios Model
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x25, 0xC, 0x0, 0x1, 0x0, 0x0, 0x0, 0x1, 0x13, 0x0, 0x2E, 0xC0 }));

                // Start End-Of-Level Commands
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x1E, 0x4, 0x0, 0x0 }));

                // End-Of-Level Commands
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x2B, 0xC, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x11, 0x8, 0x0, 0x0, 0x80, 0x24, 0xBC, 0xD8 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x12, 0x8, 0x0, 0x1, 0x80, 0x24, 0xBC, 0xD8 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x1C, 0x4, 0x0, 0x0 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x4, 0x4, 0x0, 0x1 }));
                withBlock.Add(new LevelscriptCommand(new byte[] { 0x2, 0x4, 0x0, 0x0 }));

                // Add the general object bank
                ChangeObjectBank(null, RomManager.RomConfig.ObjectBankInfoData[Conversions.ToByte(0xB)]?.FirstOrDefault());
            }

            foreach (LevelscriptCommand c in Levelscript)
            {
                if (c.CommandType != LevelscriptCommandTypes.LoadRomToRam)
                    continue;
                if (clLoadRomToRam.GetSegmentedID(c) != 0xE)
                    continue;
            }
        }

        public void SetSegmentedBanks(RomManager rommgr)
        {
            foreach (LevelscriptCommand cmd in Levelscript)
            {
                var switchExpr = cmd.CommandType;
                switch (switchExpr)
                {
                    case LevelscriptCommandTypes.LoadRomToRam:
                    case LevelscriptCommandTypes.x1A:
                    case LevelscriptCommandTypes.x18:
                        {
                            cmd.Position = 0;
                            byte bankID = clLoadRomToRam.GetSegmentedID(cmd);
                            int startAddr = clLoadRomToRam.GetRomStart(cmd);
                            int endAddr = clLoadRomToRam.GetRomEnd(cmd);
                            var seg = rommgr.SetSegBank(bankID, startAddr, endAddr);
                            if (cmd.CommandType == LevelscriptCommandTypes.x1A)
                                seg.MakeAsMIO0();
                            break;
                        }
                }
            }

            if (Bank0x19 is object)
            {
                rommgr.SetSegBank(Bank0x19);
            }
        }

        public LevelscriptCommand GetDefaultPositionCmd()
        {
            return (LevelscriptCommand)Levelscript.FirstOrDefault(n => n.CommandType == LevelscriptCommandTypes.DefaultPosition);
        }

        public void ChangeObjectBankData(byte bankID, ObjectBankData newObd)
        {
            ChangeObjectBank(GetObjectBankData(bankID), newObd);
            MyObjectBanks[bankID] = newObd;
        }

        public ObjectBankData GetObjectBankData(byte bankID)
        {
            if (MyObjectBanks.ContainsKey(bankID))
            {
                return MyObjectBanks[bankID];
            }
            else
            {
                var obd = FindObjectBankData(bankID);
                MyObjectBanks.Add(bankID, obd);
                return obd;
            }
        }

        protected void ChangeObjectBank(ObjectBankData oldObd, ObjectBankData newObd)
        {
            // Remove old commands
            if (oldObd is object)
            {
                foreach (ObjectBankDataCommand obdCmd in oldObd.Commands)
                {
                    foreach (var cmd in Levelscript.Where(n => General.CompareTwoByteArrays(n.ToArray(), obdCmd.Command)).ToArray())
                    {
                        cmd.Close();
                        Levelscript.Remove(cmd);
                    }
                }
            }

            // Add new commands
            if (newObd is object)
            {
                foreach (ObjectBankDataCommand obdCmd in newObd.Commands)
                {
                    int startIndex = Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D);
                    if (!(obdCmd.CommandType == 0x1A || obdCmd.CommandType == 0x17))
                    {
                        startIndex += 1;
                    }

                    var cmd = new LevelscriptCommand(obdCmd.Command);
                    Levelscript.Insert(startIndex, cmd);
                    startIndex += 1;
                }
            }
        }

        protected ObjectBankData FindObjectBankData(byte bankID)
        {
            var list = RomManager.RomConfig.ObjectBankInfoData[bankID];
            var Found = new List<bool>();
            foreach (ObjectBankData obd in list)
            {
                foreach (ObjectBankDataCommand obdCmd in obd.Commands)
                    Found.Add(Levelscript.Where(n => General.CompareTwoByteArrays(n.ToArray(), obdCmd.Command)).Any());
                if (!Found.Contains(false))
                {
                    return obd;
                }

                Found.Clear();
            }

            return null;
        }

        public void Close()
        {
            foreach (var c in Levelscript)
                c.Close();
            Levelscript.Clear();
            foreach (var a in Areas)
                a.Close();
            Areas.Clear();
            Closed = true;
        }

        public override string ToString()
        {
            string output = "";
            foreach (var cmd in Levelscript)
            {
                string tbytelist = "";
                foreach (byte b in cmd.ToArray())
                {
                    if (tbytelist != string.Empty)
                        tbytelist += " ";
                    tbytelist += Conversion.Hex(b);
                }

                if (output != string.Empty)
                    output += Constants.vbNewLine;
                output += tbytelist;
            }

            return output;
        }
    }
}