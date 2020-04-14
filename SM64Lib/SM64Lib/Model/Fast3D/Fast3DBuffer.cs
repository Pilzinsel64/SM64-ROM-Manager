using System;
using global::System.IO;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;
using global::SM64Lib.Data;
using global::SM64Lib.Geolayout;

namespace SM64Lib.Model.Fast3D
{
    public class Fast3DBuffer : MemoryStream
    {
        public Conversion.Fast3DWriting.Fast3DWriter.ConvertResult ConvertResult { get; set; } = null;
        public int Fast3DBankStart { get; set; } = 0xE000000;
        public Geopointer[] DLPointers { get; set; } = Array.Empty<Geopointer>();

        /// <summary>
        /// Creates a Fast3D Model from a Obj File
        /// </summary>
        public void FromModel(ObjectInputSettings ObjSettings, Object3D model, TextureFormatSettings texFormatSettings = null)
        {
            // Setup Settings
            var conSettings = new Conversion.Fast3DWriting.Fast3DWriter.ConvertSettings()
            {
                CenterModel = ObjSettings.CenterModel,
                Scale = ObjSettings.Scaling,
                ResizeTextures = ObjSettings.ResizeTextures,
                ReduceVertLevel = (Conversion.Fast3DWriting.Fast3DWriter.ReduceVericesLevel)ObjSettings.ReduceDupVertLevel,
                SegmentedAddress = (uint?)0xE000000,
                ForceDisplaylist = ObjSettings.ForceDisplaylist,
                Fog = ObjSettings.Fog,
                OptimizeTransparencyChecks = ObjSettings.OptimizeTransparencyChecks,
                TextureFormatSettings = texFormatSettings
            };
            model.Shading = ObjSettings.Shading;

            // Convert Model
            var con = new Conversion.Fast3DWriting.Fast3DWriter();
            ConvertResult = con.ConvertModel(this, conSettings, model);

            // Fit to align
            base.SetLength(General.HexRoundUp1(base.Length));

            // Copy Geopointer etc.
            DLPointers = ConvertResult.PtrGeometry.ToArray();
            Fast3DBankStart = 0xE000000;
        }

        public void FromStream(Stream s, int BankRomStart, int BankRamStart, int Fast3DStart, int Fast3DLength, Geopointer[] DisplayListpointer)
        {
            FromBinaryData(new BinaryStreamData(s), BankRomStart, BankRamStart, Fast3DStart, Fast3DLength, DisplayListpointer);
        }

        public void FromBinaryData(BinaryData data, int BankRomStart, int BankRamStart, int Fast3DStart, int Fast3DLength, Geopointer[] DisplayListpointer)
        {
            DLPointers = DisplayListpointer;
            Fast3DBankStart = Fast3DStart - BankRomStart + BankRamStart;
            data.Position = Fast3DStart;
            base.SetLength(Fast3DLength);
            base.Position = 0;
            for (int i = 1, loopTo = Fast3DLength; i <= loopTo; i++)
                base.WriteByte(data.ReadByte());
        }

        public Task FromModelAsync(ObjectInputSettings ObjSettings, Object3D model, TextureFormatSettings texFormatSettings = null)
        {
            var t = new Task(() => FromModel(ObjSettings, model, texFormatSettings));
            t.Start();
            return t;
        }

        public Task FromStreamAsync(Stream s, int BankRomStart, int BankRamStart, int Fast3DStart, int Fast3DLength, Geopointer[] DisplayListpointer)
        {
            var t = new Task(() => FromStream(s, BankRomStart, BankRamStart, Fast3DStart, Fast3DLength, DisplayListpointer));
            t.Start();
            return t;
        }

        public void ToStream(Stream s, int RomPos, int BankRomStart, int BankRamStart)
        {
            ToBinaryData(new BinaryStreamData(s), RomPos, BankRomStart, BankRamStart);
        }

        public void ToBinaryData(BinaryData data, int dataPos, int BankRomStart, int BankRamStart)
        {
            data.Position = dataPos;

            // Update all Pointers
            int newBankStart = dataPos - BankRomStart + BankRamStart;
            int tdif = newBankStart - Fast3DBankStart;
            foreach (Geopointer geop in DLPointers)
            {
                if (geop.SegPointer >> 24 == BankRamStart >> 24)
                {
                    Position = geop.SegPointer - Fast3DBankStart;
                    do
                    {
                        var switchExpr = ReadByte();
                        switch (switchExpr)
                        {
                            case 0xB8:
                                {
                                    break;
                                }

                            case 0x3:
                            case 0x4:
                            case 0x6:
                            case 0xFD:
                                {
                                    base.Position += 3;
                                    var sd = new BinaryStreamData(this);
                                    int p = sd.ReadInt32();
                                    p += tdif;
                                    base.Position -= 4;
                                    sd.Write(p);
                                    break;
                                }

                            default:
                                {
                                    base.Position += 7;
                                    break;
                                }
                        }
                    }
                    while (base.Position < base.Length);
                    geop.SegPointer += tdif;
                }
            }

            // Write Fast3D
            foreach (byte b in base.ToArray())
                data.Write(b);
            Fast3DBankStart = newBankStart;
        }
    }
}