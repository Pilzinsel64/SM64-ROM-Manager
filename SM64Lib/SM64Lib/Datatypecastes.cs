using global::System.Runtime.InteropServices;

namespace SM64Lib
{
    static class Datatypecastes
    {
        public static short LongToInt16(long value)
        {
            var cast = default(CasterLongInt16);
            cast.LongValue = value;
            return cast.Int16Value;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct CasterLongInt16
        {
            [FieldOffset(0)]
            public long LongValue;
            [FieldOffset(0)]
            public short Int16Value;
        }

        public static byte LongToByte(long value)
        {
            var cast = default(CasterLongByte);
            cast.LongValue = value;
            return cast.ByteValue;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct CasterLongByte
        {
            [FieldOffset(0)]
            public long LongValue;
            [FieldOffset(0)]
            public byte ByteValue;
        }
    }
}