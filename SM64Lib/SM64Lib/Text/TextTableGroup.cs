using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;
using global::SM64Lib.Text.Profiles;

namespace SM64Lib.Text
{
    public class TextTableGroup : TextGroup
    {
        public new TextTableItem this[int index]
        {
            get
            {
                return (TextTableItem)base[index];
            }
        }

        public new TextTableGroupInfo TextGroupInfo
        {
            get
            {
                return (TextTableGroupInfo)base.TextGroupInfo;
            }
        }

        public TextTableGroup(TextTableGroupInfo groupInfo) : base(groupInfo)
        {
        }

        public override void Read(BinaryData data)
        {
            uint BankRamStart, BankRomStart;
            BankRamStart = TextGroupInfo.Segmented.BankAddress;
            BankRomStart = Conversions.ToUInteger(TextGroupInfo.Segmented.BankStartRom);
            if (TextGroupInfo.TableType == TextTableType.Dialogs)
            {
                data.Position = TextGroupInfo.Data.TableRomOffset;
                for (int i = 0; i < TextGroupInfo.Data.TableMaxItems; i++)
                {
                    int entryPointer = (int)(data.ReadInt32() - BankRamStart + BankRomStart);
                    int lastPos = Conversions.ToInteger(data.Position);

                    data.Position = entryPointer;
                    data.Position = entryPointer + 12;

                    int addr = data.ReadInt32();
                    if (addr != 0)
                    {
                        var bytes = GetTextData(data, (int)(addr - BankRamStart + BankRomStart), true);
                        var newItem = new TextTableDialogItem(bytes, TextGroupInfo);
                        data.Position = entryPointer + 0x3;

                        // The unknown value
                        newItem.UnknownValue = data.ReadByte();

                        // Lines per Site
                        newItem.LinesPerSite = data.ReadByte();

                        data.Position += 1;

                        // Position
                        newItem.VerticalPosition = (DialogVerticalPosition)data.ReadInt16();
                        newItem.HorizontalPosition = (DialogHorizontalPosition)data.ReadInt16();

                        data.Position += 6;

                        // Sound effect
                        if (TextGroupInfo.DialogData.HasSoundEffects && TextGroupInfo.DialogData.SoundEffectTable != -1)
                        {
                            data.Position = TextGroupInfo.DialogData.SoundEffectTable + i;
                            newItem.SoundEffect = (DialogSoundEffect)data.ReadByte();
                        }

                        // Add item
                        Add(newItem);

                        data.Position = lastPos;
                    }
                }
            }
            else
            {
                data.Position = TextGroupInfo.Data.TableRomOffset;
                for (int i = 1, loopTo1 = TextGroupInfo.Data.TableMaxItems; i <= loopTo1; i++)
                {
                    uint addrInROM = data.ReadUInt32();
                    if (addrInROM != (long)0)
                    {
                        var bytes = GetTextData(data, (int)(addrInROM - BankRamStart + BankRomStart));
                        Add(new TextTableItem(bytes, TextGroupInfo));
                    }
                }
            }
        }

        private byte[] GetTextData(BinaryData data, int RomAddress, bool EnableDialogParameters = false)
        {
            int lastPos = 0;
            byte tempByte = 0;
            var byteBuffer = new List<byte>();
            lastPos = Conversions.ToInteger(data.Position);
            data.Position = RomAddress;
            do
            {
                tempByte = data.ReadByte();
                byteBuffer.Add(tempByte);
                if (tempByte == 0xFF)
                    break;
            }
            while (true);
            data.Position = lastPos;
            return byteBuffer.ToArray();
        }

        public override void Save(BinaryData data)
        {
            int DataRomOffset, lastTableOffset, lastTable2Offset;
            uint BankRomStart, BankRamStart;

            lastTableOffset = TextGroupInfo.Data.TableRomOffset;
            DataRomOffset = TextGroupInfo.Data.DataRomOffset;
            BankRamStart = TextGroupInfo.Segmented.BankAddress;
            BankRomStart = Conversions.ToUInteger(TextGroupInfo.Segmented.BankStartRom);

            if (TextGroupInfo.TableType == TextTableType.Dialogs)
            {
                lastTable2Offset = (int)TextGroupInfo.DialogData?.TableRomOffset;
                for (int i = 0; i < Count; i++)
                {
                    TextTableDialogItem textitem = (TextTableDialogItem)this.ElementAtOrDefault(i);

                    // Table 1
                    data.Position = lastTableOffset;
                    data.Write(textitem is null ? 0 : Conversions.ToInteger(lastTable2Offset - BankRomStart + BankRamStart));
                    lastTableOffset += 4;

                    // Table 2 (including Dialog Params)
                    data.Position = lastTable2Offset;
                    if (textitem is object)
                    {
                        data.Write(Conversions.ToShort(0));
                        data.WriteByte(0);
                        data.WriteByte(textitem.UnknownValue);
                        data.WriteByte(Conversions.ToByte(textitem.LinesPerSite));
                        data.WriteByte(0);
                        data.Write(Conversions.ToShort(textitem.VerticalPosition));
                        data.Write(Conversions.ToShort(textitem.HorizontalPosition));
                        data.Write(Conversions.ToShort(0));
                        data.Write(Conversions.ToUInteger(DataRomOffset - BankRomStart + BankRamStart));
                    }
                    else
                    {
                        data.Write(Conversions.ToShort(0));
                        data.WriteByte(0);
                        data.WriteByte(0);
                        data.WriteByte(0);
                        data.WriteByte(0);
                        data.Write(Conversions.ToShort(0));
                        data.Write(Conversions.ToShort(0));
                        data.Write(Conversions.ToShort(0));
                        data.Write(Conversions.ToUInteger(0));
                    }

                    lastTable2Offset += 0x10;

                    // Text Data
                    data.Position = DataRomOffset;
                    if (textitem is object)
                        WriteTextItem(data, DataRomOffset, textitem);
                    DataRomOffset += textitem.Data.Length;

                    // Sound Effect
                    if (TextGroupInfo.DialogData.HasSoundEffects && TextGroupInfo.DialogData.SoundEffectTable != -1)
                    {
                        data.Position = TextGroupInfo.DialogData.SoundEffectTable + i;
                        data.Write((byte)textitem.SoundEffect);
                    }
                }
            }
            else
            {
                for (int i = 0, loopTo1 = Count - 1; i <= loopTo1; i++)
                {
                    TextTableItem textitem = (TextTableItem)this.ElementAtOrDefault(i);

                    // Table
                    data.Position = lastTableOffset;
                    data.Write(textitem is null ? Conversions.ToUInteger(0) : Conversions.ToUInteger(DataRomOffset - BankRomStart + BankRamStart));
                    lastTableOffset += 4;

                    // Text Data
                    data.Position = DataRomOffset;
                    if (textitem is object)
                        WriteTextItem(data, DataRomOffset, textitem);
                    DataRomOffset += textitem.Data.Length;
                }
            }
        }

        private void WriteTextItem(BinaryData data, int RomAddress, TextTableItem item)
        {
            data.Position = RomAddress;
            foreach (var b in item.Data)
                data.WriteByte(b);
        }
    }
}