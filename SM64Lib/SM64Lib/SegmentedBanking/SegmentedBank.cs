using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;

namespace SM64Lib.SegmentedBanking
{
    public class SegmentedBank
    {

        // F i e l d s

        private int _RomEnd = 0;

        // A u t o   P r o p e r t i e s

        public int RomStart { get; set; } = 0;
        public byte BankID { get; set; } = 0;
        public bool IsMIO0 { get; private set; } = false;
        public MemoryStream Data { get; set; } = null;

        // O t h e r   P r o p e r t i e s

        public int RomEnd
        {
            get
            {
                if (Data is null)
                {
                    return _RomEnd;
                }
                else
                {
                    return (int)(RomStart + Data.Length);
                }
            }

            set
            {
                if (Data is null)
                {
                    _RomEnd = value;
                }
                else
                {
                    long newLength = value - RomStart;
                    if (Data.Length != newLength)
                    {
                        Data.SetLength(newLength);
                    }
                }
            }
        }

        public int BankAddress
        {
            get
            {
                return Conversions.ToInteger(Conversions.ToUInteger(BankID) << 24);
            }

            set
            {
                BankID = Conversions.ToByte(value >> 24 & 0xFF);
            }
        }

        public int Length
        {
            get
            {
                if (Data is null)
                {
                    return RomEnd - RomStart;
                }
                else
                {
                    return Conversions.ToInteger(Data.Length);
                }
            }

            set
            {
                if (Data is null)
                {
                    RomEnd = RomStart + value;
                }
                else
                {
                    Data.SetLength(value);
                }
            }
        }

        // C o n s t r u c t o r s

        public SegmentedBank()
        {
        }

        public SegmentedBank(byte bankID)
        {
            BankID = bankID;
        }

        public SegmentedBank(byte bankID, uint length)
        {
            BankID = bankID;
            Length = Conversions.ToInteger(length);
        }

        public SegmentedBank(byte bankID, MemoryStream data)
        {
            BankID = bankID;
            Data = data;
        }

        public SegmentedBank(MemoryStream data)
        {
            Data = data;
        }

        // M e t h o d s

        public int SegToRomAddr(int SegmentedAddress)
        {
            return SegmentedAddress - BankAddress + RomStart;
        }

        public int RomToSegAddr(int RomAddress)
        {
            return RomAddress - RomStart + BankAddress;
        }

        public int BankOffsetFromSegAddr(int segPointer)
        {
            return segPointer - BankAddress;
        }

        public int BankOffsetFromRomAddr(int RomAddr)
        {
            return RomAddr - RomStart;
        }

        public MemoryStream ReadData(RomManager rommgr)
        {
            var fs = new FileStream(rommgr.RomFile, FileMode.Open, FileAccess.Read);
            MemoryStream ms;
            ms = ReadDataIfNull(fs);
            fs.Close();
            Data = ms;
            return ms;
        }

        public MemoryStream ReadDataIfNull(Stream s)
        {
            if (Data is null)
            {
                ReadData(s);
            }

            return Data;
        }

        public MemoryStream ReadDataIfNull(string fileName)
        {
            if (Data is null)
            {
                var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                ReadData(fs);
                fs.Close();
            }

            return Data;
        }

        public MemoryStream ReadDataIfNull(RomManager rommgr)
        {
            return ReadDataIfNull(rommgr.RomFile);
        }

        public MemoryStream ReadData(Stream s)
        {
            var ms = new MemoryStream();
            if (RomStart > 0 && Length > 0 && s.Length >= RomEnd)
            {
                var data = new byte[Length];
                s.Position = RomStart;
                s.Read(data, 0, data.Length);
                if (IsDataMIO0(data))
                {
                    data = LIBMIO0.MIO0.mio0_decode(data);
                }

                ms.Write(data, 0, data.Length);
                ms.Position = 0;
            }

            if (Data is object)
                Data.Close();
            Data = ms;
            return ms;
        }

        private bool IsDataMIO0(byte[] arr)
        {
            int check = Conversions.ToInteger(arr[0]) << 24 | Conversions.ToInteger(arr[1]) << 16 | Conversions.ToInteger(arr[2]) << 8 | arr[3];
            return check == 0x4D494F30;
        }

        public void WriteData(RomManager rommgr)
        {
            if (Data is object)
            {
                var fs = new FileStream(rommgr.RomFile, FileMode.Open, FileAccess.ReadWrite);
                WriteData(fs);
                fs.Close();
            }
        }

        public void WriteData(BinaryData data)
        {
            WriteData(data.BaseStream);
        }

        public void WriteData(Stream s)
        {
            if (Data is object)
            {
                Data.Position = 0;
                s.Position = RomStart;
                for (int i = 1, loopTo = (int)Data.Length; i <= loopTo; i++)
                    s.WriteByte(Conversions.ToByte(Data.ReadByte()));
            }
        }

        public void MakeAsMIO0()
        {
            IsMIO0 = true;
        }
    }
}