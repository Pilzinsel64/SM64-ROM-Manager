using System;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using global::SM64Lib.Script;

namespace SM64Lib.Model.Fast3D.DisplayLists.Script
{
    public class DisplayListCommand : Data.BinaryStreamData, ICommand
    {
        public CommandTypes CommandType { get; set; } = CommandTypes.EndDisplaylist;
        public int RomAddress { get; set; } = 0;
        public int BankAddress { get; set; } = 0;

        public bool IsDirty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private DisplayListCommand() : base(new MemoryStream())
        {
        }

        public DisplayListCommand(byte CommandType) : this()
        {
            this.CommandType = (CommandTypes)CommandType;
            SetLength(0x8);
            Position = 0;
            WriteByte(CommandType);
            Position = 0;
        }

        public DisplayListCommand(string CommandType) : this(Convert.ToByte(CommandType, 16))
        {
        }

        public DisplayListCommand(byte[] bytes) : this()
        {
            CommandType = (CommandTypes)bytes[0];
            SetLength(bytes.Count());
            foreach (var b in bytes)
                WriteByte(b);
            Position = 0;
        }

        public override string ToString()
        {
            return $"{RomAddress.ToString("X")} ({BankAddress.ToString("X")}): {General.CommandByteArrayToString(ToArray())}";
        }

        public byte[] ToArray()
        {
            return ((MemoryStream)BaseStream).ToArray();
        }
    }
}