using System;
using System.Collections.Generic;
using global::SM64Lib.Data;
using global::SM64Lib.Text.Profiles;

namespace SM64Lib.Text
{
    public class TextArrayGroup : TextGroup
    {
        public new TextArrayItem this[int index]
        {
            get
            {
                return (TextArrayItem)base[index];
            }
        }

        public new TextArrayGroupInfo TextGroupInfo
        {
            get
            {
                return (TextArrayGroupInfo)base.TextGroupInfo;
            }
        }

        public TextArrayGroup(TextArrayGroupInfo groupInfo) : base(groupInfo)
        {
        }

        public override void Read(BinaryData data)
        {
            foreach (TextArrayItemInfo info in TextGroupInfo.Texts)
                Add(GetTextItem(data, info));
        }

        private TextArrayItem GetTextItem(BinaryData data, TextArrayItemInfo info)
        {
            byte tempByte = 0;
            var byteBuffer = new List<byte>();
            bool ende = false;
            data.Position = info.RomAddress;
            while (!ende)
            {
                tempByte = data.ReadByte();
                byteBuffer.Add(tempByte);
                if (byteBuffer.Count >= info.MaxLength || TextGroupInfo.Encoding == M64TextEncoding.M64Text && tempByte == 0xFF)
                {
                    ende = true;
                }
            }

            var newItem = new TextArrayItem(byteBuffer.ToArray(), TextGroupInfo, info);
            byteBuffer.Clear();
            return newItem;
        }

        public override void Save(BinaryData data)
        {
            foreach (TextArrayItem item in this)
            {
                data.Position = item.ItemInfo.RomAddress;
                WriteTextItem(data, item);
            }
        }

        private void WriteTextItem(BinaryData data, TextArrayItem item)
        {
            data.Position = item.ItemInfo.RomAddress;
            for (int i = 0, loopTo = Math.Min(item.Data.Length, item.ItemInfo.MaxLength) - 1; i <= loopTo; i++)
            {
                byte b = item.Data[i];
                data.WriteByte(b);
            }

            if (item.TextGroupInfo.Encoding == System.Text.Encoding.ASCII)
            {
                for (int i = (int)data.Position, loopTo1 = item.ItemInfo.RomAddress + item.ItemInfo.MaxLength; i <= loopTo1; i++)
                    data.WriteByte(20);
            }
        }
    }
}