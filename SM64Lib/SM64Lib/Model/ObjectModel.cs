using System.Collections.Generic;
using global::System.IO;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;
using global::SM64Lib.Geolayout;

namespace SM64Lib.Model
{
    public class ObjectModel
    {

        // Public DisplayLists As New DisplayListCollection
        public Collision.CollisionMap Collision { get; set; } = null;
        public Fast3D.Fast3DBuffer Fast3DBuffer { get; set; } = null;

        public void FromROM(string Romfile, int BankRomStart, int BankRamStart, int Fast3DStart, int Fast3DLength, Geopointer[] DisplayListpointer, int Collisionpointer = -1)
        {
            var fs = new FileStream(Romfile, FileMode.Open, FileAccess.Read);
            Stream args = fs;
            FromStream(ref args, BankRomStart, BankRamStart, Fast3DStart, Fast3DLength, DisplayListpointer, Collisionpointer);
            fs.Close();
        }

        public void FromBinaryData(BinaryData data, int BankRomStart, int BankRamStart, int Fast3DStart, int Fast3DLength, Geopointer[] DisplayListpointer, int Collisionpointer = -1)
        {
            // Load Collision
            if (Collisionpointer > -1)
            {
                Collision = new Collision.CollisionMap();
                int cRomStart = Collisionpointer - BankRamStart + BankRomStart;
                Collision.FromBinaryData(data, cRomStart);
            }
            else
            {
                Collision = null;
            }

            // Read Fast3D Buffer
            if (Fast3DBuffer is object)
                Fast3DBuffer.Close();
            Fast3DBuffer = new Fast3D.Fast3DBuffer();
            Fast3DBuffer.FromBinaryData(data, BankRomStart, BankRamStart, Fast3DStart, Fast3DLength, DisplayListpointer);
        }

        public void FromStream(ref Stream s, int BankRomStart, int BankRamStart, int Fast3DStart, int Fast3DLength, Geopointer[] DisplayListpointer, int Collisionpointer = -1)
        {
            FromBinaryData(new BinaryStreamData(s), BankRomStart, BankRamStart, Fast3DStart, Fast3DLength, DisplayListpointer, Collisionpointer);
        }

        public void FromModel(ObjectInputSettings ObjSettings, Pilz.S3DFileParser.Object3D vmap, Pilz.S3DFileParser.Object3D colmap, Fast3D.TextureFormatSettings texFormatSettings, Collision.CollisionSettings colSettings = null)
        {
            // Add Collision
            Collision = new Collision.CollisionMap();
            Collision.FromObject3D(ObjSettings, colmap, colSettings);

            // Add Fast3DBuffer (replacement for 'Add Displaylists')
            if (Fast3DBuffer is object)
                Fast3DBuffer.Close();
            Fast3DBuffer = new Fast3D.Fast3DBuffer();
            Fast3DBuffer.FromModel(ObjSettings, vmap, texFormatSettings);
        }

        public Task FromModelAsync(ObjectInputSettings ObjSettings, Pilz.S3DFileParser.Object3D vmap, Pilz.S3DFileParser.Object3D colmap, Fast3D.TextureFormatSettings texFormatSettings = null, Collision.CollisionSettings colSettings = null)
        {
            var t = new Task(() => FromModel(ObjSettings, vmap, colmap, texFormatSettings, colSettings));
            t.Start();
            return t;
        }

        public SaveResult ToRom(string Romfile, int RomPos, int BankRomStart, int BankRamStart)
        {
            var fs = new FileStream(Romfile, FileMode.Open, FileAccess.ReadWrite);
            var treturn = ToStream(fs, RomPos, BankRomStart, BankRamStart);
            fs.Close();
            return treturn;
        }

        public SaveResult ToStream(Stream s, int RomPos, int BankRomStart, int BankRamStart)
        {
            return ToBinaryData(new BinaryStreamData(s), RomPos, BankRomStart, BankRamStart);
        }

        public SaveResult ToBinaryData(BinaryData data, int dataPos, int BankRomStart, int BankRamStart)
        {
            var tresult = new SaveResult();
            data.Position = dataPos;

            // Write Fast3D
            if (Fast3DBuffer is object)
            {
                Fast3DBuffer.ToBinaryData(data, Conversions.ToInteger(data.Position), BankRomStart, BankRamStart);
                tresult.GeoPointers.AddRange(Fast3DBuffer.DLPointers);
                tresult.Length += Fast3DBuffer.Length;
            }
            else
            {
                tresult.GeoPointers.Clear();
            }

            // Write Collision
            if (Collision is object)
            {
                int colStart = (int)General.HexRoundUp1(data.Position);
                tresult.CollisionPointer = colStart - BankRomStart + BankRamStart;
                Collision.ToBinaryData(data, colStart);
                Collision.Length = data.Position - colStart;
                tresult.Length += Collision.Length;
            }
            else
            {
                tresult.CollisionPointer = -1;
            }

            return tresult;
        }

        public int Length
        {
            get
            {
                return (int)(
                    (Fast3DBuffer is object ? General.HexRoundUp1(Fast3DBuffer.Length) : 0) +
                    (Collision is object ? General.HexRoundUp1(Collision.Length) : 0));
            }
        }

        public class SaveResult
        {
            public int CollisionPointer { get; set; } = -1;
            public List<Geopointer> GeoPointers { get; set; } = new List<Geopointer>();
            public long Length { get; set; } = 0;
        }
    }
}