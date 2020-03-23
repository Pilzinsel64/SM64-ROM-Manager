using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.Script
{
    [Serializable]
    public abstract class BaseCommand<eTypes> : Data.BinaryStreamData, ICommand
    {
        private int dirtyHash = 0;

        public int RomAddress { get; set; } = 0;
        public int BankAddress { get; set; } = 0;
        public abstract eTypes CommandType { get; set; }

        public BaseCommand(string bytes, bool enabledHex = true) : this()
        {
            var bts = new List<byte>();
            foreach (string b in bytes.Split(' '))
            {
                string bb = b;
                if (enabledHex)
                    bb = Conversions.ToString(Convert.ToInt32(bb, 16));
                bts.Add(Conversions.ToByte(bb));
            }

            NewBytes(bts.ToArray());
        }

        public BaseCommand() : base(new MemoryStream())
        {
        }

        public BaseCommand(byte[] bytes) : this()
        {
            NewBytes(bytes);
        }

        private void NewBytes(byte[] bytes)
        {
            SetLength(bytes.Count());
            foreach (byte b in bytes)
                WriteByte(b);
            Position = 0;
        }

        public byte[] ToArray()
        {
            return ((MemoryStream)BaseStream).ToArray();
        }

        public override string ToString()
        {
            return $"{RomAddress.ToString("X")} ({BankAddress.ToString("X")}): {General.CommandByteArrayToString(ToArray())}";
        }

        public static bool operator ==(BaseCommand<eTypes> cmd1, BaseCommand<eTypes> cmd2)
        {
            if (cmd1.Length != cmd2.Length)
            {
                return false;
            }

            var buf1 = ((MemoryStream)cmd1.BaseStream).GetBuffer();
            var buf2 = ((MemoryStream)cmd2.BaseStream).GetBuffer();
            for (int i = 0, loopTo = (int)(cmd1.Length - 1); i <= loopTo; i++)
            {
                if (buf1[i] != buf2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(BaseCommand<eTypes> cmd1, BaseCommand<eTypes> cmd2)
        {
            return !(cmd1 == cmd2);
        }

        public void RefreshDirty()
        {
            dirtyHash = ((MemoryStream)BaseStream).GetHashCode();
        }

        public bool IsDirty
        {
            get
            {
                return ((MemoryStream)BaseStream).GetHashCode() != dirtyHash;
            }
        }
    }
}