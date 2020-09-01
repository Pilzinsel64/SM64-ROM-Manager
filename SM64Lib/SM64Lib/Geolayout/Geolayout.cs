using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Geolayout.Script;
using global::SM64Lib.Geolayout.Script.Commands;
using Newtonsoft.Json;

namespace SM64Lib.Geolayout
{
    public class Geolayout
    {
        [JsonProperty]
        private int IndexForGeopointers = -1;

        public Geolayoutscript Geolayoutscript { get; set; } = new Geolayoutscript();
        public CameraPresets CameraPreset { get; set; } = CameraPresets.OpenCamera;
        public EnvironmentEffects EnvironmentEffect { get; set; } = default;
        public List<int> GeopointerOffsets { get; set; } = new List<int>();
        public List<Geopointer> Geopointers { get; set; } = new List<Geopointer>();
        public int NewGeoOffset { get; set; } = 0;
        public bool Closed { get; set; } = false;
        public ObjectShadow ObjectShadow { get; set; } = new ObjectShadow();
        public CameraFrustrum CameraFrustrum { get; set; } = new CameraFrustrum();

        public int Length
        {
            get
            {
                int tLength = Geopointers.Count * 8;
                foreach (var c in Geolayoutscript)
                    tLength += (int)c.Length;
                return tLength;
            }
        }

        private void RemoveOldGeopointerCommands()
        {
            var ToRemove = new List<GeolayoutCommand>();
            foreach (GeolayoutCommand c in Geolayoutscript)
            {
                if (c.CommandType == GeolayoutCommandTypes.LoadDisplaylist)
                {
                    ToRemove.Add(c);
                }
            }

            foreach (GeolayoutCommand cmd in ToRemove)
            {
                Geolayoutscript.Remove(cmd);
                cmd.Close();
            }
        }

        public Geolayout(NewScriptCreationMode mode)
        {
            switch (mode)
            {
                case NewScriptCreationMode.Level:
                    {
                        {
                            var withBlock = Geolayoutscript;
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x8, 0x0, 0x0, 0xA, 0x0, 0xA0, 0x0, 0x78, 0x0, 0xA0, 0x0, 0x78 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x4, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0xC, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x4, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x9, 0x0, 0x0, 0x64 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x4, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x19, 0x0, 0x0, 0x0, 0x80, 0x27, 0x63, 0xD4 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x5, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x5, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0xC, 0x1, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x4, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0xA, 0x1, 0x0, 0x2D, 0x0, 0x64, 0x75, 0x30, 0x80, 0x29, 0xAA, 0x3C }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x4, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0xF, 0x0, 0x0, 0x1, 0x0, 0x0, 0x7, 0xD0, 0x17, 0x70, 0xC, 0x0, 0x0, 0x0, 0xEE, 0x0, 0x80, 0x28, 0x7D, 0x30 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x4, 0x0, 0x0, 0x0 }));
                            IndexForGeopointers = 15;
                            // .Add(New GeolayoutCommand({&H15, &H1, &H0, &H0, &H0, &H0, &H0, &H0}))
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x17, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x18, 0x0, 0x0, 0x0, 0x80, 0x27, 0x61, 0xD0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x18, 0x0, 0x50, 0x0, 0x80, 0x2D, 0x10, 0x4C })); // Water
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x18, 0x0, 0x50, 0x1, 0x80, 0x2D, 0x10, 0x4C })); // Toxic Haze
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x18, 0x0, 0x50, 0x2, 0x80, 0x2D, 0x10, 0x4C })); // Mist
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x5, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x5, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x5, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0xC, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x4, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x18, 0x0, 0x0, 0x0, 0x80, 0x2C, 0xD1, 0xE8 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x5, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x5, 0x0, 0x0, 0x0 }));
                            withBlock.Add(new GeolayoutCommand(new byte[] { 0x1, 0x0, 0x0, 0x0 }));
                        }

                        break;
                    }

                case NewScriptCreationMode.Object:
                    {
                        {
                            var withBlock1 = Geolayoutscript;
                            withBlock1.Add(new GeolayoutCommand("20 00 0F A0"));
                            withBlock1.Add(new GeolayoutCommand("04 00 00 00"));
                            IndexForGeopointers = 2;
                            withBlock1.Add(new GeolayoutCommand("05 00 00 00"));
                            withBlock1.Add(new GeolayoutCommand("01 00 00 00"));
                        }

                        break;
                    }
            }
        }

        public void Read(byte[] data, byte bankID)
        {
            RenewGeolayout();
            Geolayoutscript.Read(data, bankID);
            ParseGeolayout();
        }

        public void Read(RomManager rommgr, int segAddress)
        {
            RenewGeolayout();
            Geolayoutscript.Read(rommgr, segAddress);
            ParseGeolayout();
        }

        private void RenewGeolayout()
        {
            if (!Closed) Close();
            Closed = false;
            Geolayoutscript.Clear();
            Geopointers.Clear();
            GeopointerOffsets.Clear();
            Geolayoutscript = new Geolayoutscript();
            ObjectShadow = new ObjectShadow();
            CameraFrustrum = new CameraFrustrum();
        }

        public void ParseGeolayout()
        {
            var ToRemove = new List<GeolayoutCommand>();
            int cIndex = 0;
            var curMdlScale = System.Numerics.Vector3.One;
            var curMdlOffset = System.Numerics.Vector3.Zero;

            foreach (GeolayoutCommand fec in Geolayoutscript)
            {
                var c = fec;
                var switchExpr = c.CommandType;

                switch (switchExpr)
                {
                    case GeolayoutCommandTypes.CameraPreset:
                        CameraPreset = (CameraPresets)cgCameraPreset.GetCameraPreset(ref c);
                        break;
                    case GeolayoutCommandTypes.x18:
                        var switchExpr1 = (uint)cgx18.GetAsmPointer(ref c);
                        switch (switchExpr1)
                        {
                            case 0x802761D0:
                                EnvironmentEffect = (EnvironmentEffects)cgx18.GetParam1(ref c);
                                break;
                        }
                        break;
                    case GeolayoutCommandTypes.LoadDisplaylist:
                        if (Geopointers.Count == 0)
                            IndexForGeopointers = cIndex;
                        Geopointers.Add(new Geopointer(cgLoadDisplayList.GetDrawingLayer(ref c), cgLoadDisplayList.GetSegGeopointer(ref c), curMdlScale, curMdlOffset));
                        break;
                    case GeolayoutCommandTypes.ObjectShadown:
                        cgObjectShadow.GetShadow(c, ObjectShadow);
                        ObjectShadow.Enabled = true;
                        break;
                    case GeolayoutCommandTypes.DrawingDistance:
                        ObjectShadow.Enabled = false;
                        break;
                    case GeolayoutCommandTypes.CameraFrustrum:
                        cgCameraFrustrum.GetCameraFrustrum(c, CameraFrustrum);
                        break;
                }

                cIndex += 1;
            }

            // Remove Geopointercommands
            RemoveOldGeopointerCommands();
        }

        public void Write(Stream s, int StartOffset)
        {
            NewGeoOffset = StartOffset;
            var commandsToRemove = new List<GeolayoutCommand>();
            GeolayoutCommand cmdObjectShadow = null;
            GeolayoutCommand cmdDrawingDistance = null;
            int tIndexForGeoPointer = IndexForGeopointers;
            var isForLevel = false;

            // Einstellungen übernehmen
            int currentPosition = 0;
            foreach (GeolayoutCommand fec in Geolayoutscript)
            {
                var c = fec;
                var switchExpr = c.CommandType;

                switch (switchExpr)
                {
                    case GeolayoutCommandTypes.CameraPreset:
                        cgCameraPreset.SetCameraPreset(ref c, Conversions.ToByte(CameraPreset));
                        break;
                    case GeolayoutCommandTypes.x18:
                        var switchExpr1 = cgx18.GetAsmPointer(ref c);
                        switch ((GeoAsmPointer)switchExpr1)
                        {
                            case GeoAsmPointer.EnvironmentEffect:
                                cgx18.SetParam1(ref c, (ushort)EnvironmentEffect);
                                break;
                        }
                        break;
                    case GeolayoutCommandTypes.ObjectShadown:
                        if (ObjectShadow.Enabled)
                            cmdObjectShadow = c;
                        else
                            commandsToRemove.Add(c);
                        break;
                    case GeolayoutCommandTypes.DrawingDistance:
                        if (ObjectShadow.Enabled)
                            commandsToRemove.Add(c);
                        else
                            cmdDrawingDistance = c;
                        break;
                    case GeolayoutCommandTypes.CameraFrustrum:
                        cgCameraFrustrum.SetCameraFrustrum(c, CameraFrustrum);
                        isForLevel = true;
                        break;
                    case GeolayoutCommandTypes.SetScreenRenderArea:
                        isForLevel = true;
                        break;
                }

                currentPosition += (int)c.Length;
            }

            // Insert Geopointers
            foreach (Geopointer g in Geopointers)
            {
                var tcommand = new GeolayoutCommand(new byte[] { 0x15, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 });
                cgLoadDisplayList.SetDrawingLayer(ref tcommand, g.Layer);
                cgLoadDisplayList.SetSegGeopointer(ref tcommand, g.SegPointer);
                Geolayoutscript.Insert(tIndexForGeoPointer, tcommand);
                tIndexForGeoPointer += 1;
            }

            // Remove all other commands to remove
            foreach (var cmd in commandsToRemove)
            {
                Geolayoutscript.Remove(cmd);
                cmd.Close();
            }

            // Add Geolayout Start command for non-level geolayouts
            if (!isForLevel)
            {
                if (ObjectShadow.Enabled)
                {
                    // Add Object Shadow
                    if (cmdObjectShadow is null)
                    {
                        cmdObjectShadow = new GeolayoutCommand("16 00 00 00 00 00 00 00");
                        Geolayoutscript.Insert(0, cmdObjectShadow);
                    }
                    cgObjectShadow.SetShadow(cmdObjectShadow, ObjectShadow);
                }
                else
                {
                    if (cmdDrawingDistance == null)
                        Geolayoutscript.Insert(0, new GeolayoutCommand("20 00 0F A0"));
                }
            }

            // Write Geolayout to ROM
            Geolayoutscript.Write(s, StartOffset);

            // Remove Geopointercommands again
            RemoveOldGeopointerCommands();
        }

        public void Close()
        {
            foreach (var c in Geolayoutscript)
                c.Close();
        }

        public override string ToString()
        {
            string output = "";
            foreach (var cmd in Geolayoutscript)
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

        public string ToString(GeolayoutCommandCollection Geolayoutscript)
        {
            string output = "";
            foreach (var cmd in Geolayoutscript)
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

        public enum NewScriptCreationMode
        {
            None,
            Level,
            Object
        }
    }
}