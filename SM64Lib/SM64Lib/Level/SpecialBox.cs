using global::System.IO;
using SM64Lib.Data.System;

namespace SM64Lib.Levels
{
    public class SpecialBox
    {
        public SpecialBoxType Type { get; set; } = SpecialBoxType.Water;
        public short X1 { get; set; } = 8192;
        public short Z1 { get; set; } = 8192;
        public short X2 { get; set; } = -8192;
        public short Z2 { get; set; } = -8192;
        public short Y { get; set; } = 0;
        public short Scale { get; set; } = 16;
        public bool InvisibleWater { get; set; } = false;
        public WaterType WaterType { get; set; } = WaterType.Default;
        public byte Alpha { get; set; } = 78;

        public byte[] ToArrayBoxData()
        {
            var ms = new MemoryStream(0x20);
            var bw = new BinaryWriter(ms);
            ms.Position = 0;

            // Stand: SM64 Editor v2.0.7

            bw.Write(SwapInts.SwapInt32(InvisibleWater ? 0x0 : 0x10000)); // Type = SpecialBoxType.ToxicHaze OrElse
            bw.Write(SwapInts.SwapInt16(0xF));
            bw.Write(SwapInts.SwapInt16(Scale));
            bw.Write(SwapInts.SwapInt16(X1));
            bw.Write(SwapInts.SwapInt16(Z1));
            bw.Write(SwapInts.SwapInt16(X2));
            bw.Write(SwapInts.SwapInt16(Z1));
            bw.Write(SwapInts.SwapInt16(X2));
            bw.Write(SwapInts.SwapInt16(Z2));
            bw.Write(SwapInts.SwapInt16(X1));
            bw.Write(SwapInts.SwapInt16(Z2));
            if (Type == SpecialBoxType.ToxicHaze)
            {
                bw.Write(SwapInts.SwapInt32(Alpha)); // &HB4
                bw.Write(SwapInts.SwapInt32(0x10000));
            }
            else
            {
                bw.Write(SwapInts.SwapInt32(0x10000 | Alpha));
                bw.Write(SwapInts.SwapInt32((int)WaterType));
            }

            ms.Close();
            return ms.GetBuffer();
        }
    }
}