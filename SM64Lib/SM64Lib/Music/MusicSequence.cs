using System;
using global::SM64Lib.Data;

namespace SM64Lib.Music
{
    public class MusicSequence
    {
        private InstrumentSetList _InstrumentSets = new InstrumentSetList();

        public byte[] BinaryData { get; set; } = Array.Empty<byte>();
        public string Name { get; set; } = "";

        public InstrumentSetList InstrumentSets
        {
            get
            {
                return _InstrumentSets;
            }

            internal set
            {
                _InstrumentSets = value;
            }
        }

        public int Lenght
        {
            get
            {
                return (int)BinaryData?.Length;
            }
        }

        public void ReadData(BinaryData s, int RomAddress, int Length)
        {
            BinaryData = new byte[Length];
            s.Position = RomAddress;
            s.Read(BinaryData, 0, Length);
        }

        public void WriteData(BinaryData s, int RomAddress)
        {
            s.Position = RomAddress;
            s.Write(BinaryData, 0, BinaryData.Length);
            while (s.Position % 0x10 != 0)
                s.WriteByte(0xFF);
        }
    }
}