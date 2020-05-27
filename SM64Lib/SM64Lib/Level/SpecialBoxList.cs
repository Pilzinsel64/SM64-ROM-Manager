using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using SM64Lib.Data.System;

namespace SM64Lib.Levels
{
    public class SpecialBoxList : List<SpecialBox>
    {
        public void SortByHeight()
        {
            var boxes = this.OrderByDescending(n => n.Y).ToArray();
            Clear();
            base.AddRange(boxes);
        }

        public static SpecialBox[] ReadTable(string Romfile, SpecialBoxType Type, int Levelscriptstart, int TabelStart)
        {
            var fs = new FileStream(Romfile, FileMode.Open, FileAccess.Read);
            var temp = ReadTable(fs, Type, Levelscriptstart, TabelStart);
            fs.Close();
            return temp;
        }

        public static SpecialBox[] ReadTable(Stream s, SpecialBoxType Type, int Levelscriptstart, int TabelStart)
        {
            var br = new BinaryReader(s);
            var boxlist = new List<SpecialBox>();
            s.Position = TabelStart;

            if (SwapInts.SwapInt32(br.ReadInt32()) == 0x1010101)
                return Array.Empty<SpecialBox>();
            else
                s.Position -= 0x4;

            while (SwapInts.SwapUInt16(br.ReadUInt16()) != 0xFFFF)
            {
                s.Position += 0x2;
                var tbox = new SpecialBox();
                tbox.Type = Type;
                int lastpos = (int)(s.Position + 0x4);
                s.Position = SwapInts.SwapInt32(br.ReadInt32()) - 0x19000000 + Levelscriptstart;

                if (Type == SpecialBoxType.Water)
                    tbox.InvisibleWater = SwapInts.SwapInt32(br.ReadInt32()) == 0x0;
                else
                    s.Position += 0x4;

                s.Position += 0x2;
                tbox.Scale = SwapInts.SwapInt16(br.ReadInt16());
                tbox.X1 = SwapInts.SwapInt16(br.ReadInt16());
                tbox.Z1 = SwapInts.SwapInt16(br.ReadInt16());
                tbox.X2 = SwapInts.SwapInt16(br.ReadInt16());
                s.Position += 0x4;
                tbox.Z2 = SwapInts.SwapInt16(br.ReadInt16());
                s.Position += 0x7;
                tbox.Alpha = br.ReadByte();
                tbox.WaterType = (WaterType)SwapInts.SwapInt32(br.ReadInt32());
                s.Position = lastpos;
                boxlist.Add(tbox);
            }

            return boxlist.ToArray();
        }
    }
}