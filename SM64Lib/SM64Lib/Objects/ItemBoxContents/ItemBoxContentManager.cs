using System;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using global::SM64Lib.Data;

namespace SM64Lib.Objects
{
    public class ItemBoxContentManager
    {
        private const uint TableRamLocation = 0x80404000U;
        private const uint TableRomLocationCustom = 0x1204000;
        private const uint TableRomLocationOriginal = 0xEBBA0;

        public ItemBoxContentTable ContentTable { get; private set; }

        public ItemBoxContentManager()
        {
            ContentTable = new ItemBoxContentTable();
        }

        public ItemBoxContentManager(ItemBoxContentTable table)
        {
            ContentTable = table;
        }

        public void Read(RomManager rommgr)
        {
            Read(rommgr, true);
        }

        public void Read(RomManager rommgr, bool clearList)
        {
            try
            {
                BinaryRom rom;
                if (clearList)
                    ContentTable.Clear();
                rom = rommgr.GetBinaryRom(FileAccess.Read);

                // Get RAM location
                uint address = GetRamLocation(rom);

                // Set ROM position
                if (address == TableRamLocation)
                {
                    address = TableRomLocationCustom;
                }
                else
                {
                    address = TableRomLocationOriginal;
                }

                // Read table
                Read(rom, address);
                rom.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error at reading table from ROM.", ex);
            }
        }

        private uint GetRamLocation(BinaryData rom)
        {
            uint address;
            rom.Position = 0x7C8E2;
            address = Conversions.ToUInteger(rom.ReadUInt16()) << 16;
            rom.Position = 0x7C8E6;
            address = address | rom.ReadUInt16();
            return address;
        }

        public void ResetToOriginal(RomManager rommgr)
        {
            try
            {
                var rom = rommgr.GetBinaryRom(FileAccess.Read);
                ContentTable.Clear();
                Read(rom, TableRomLocationOriginal);
                rom.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error at reading original content from ROM.", ex);
            }
        }

        private void Read(BinaryRom rom, uint location)
        {
            int curID = -1;
            rom.Position = location;
            while (rom.ReadUInt64() != (decimal)0x6300000000000000)
            {
                var entry = new ItemBoxContentEntry();
                rom.Position -= 8;
                curID = rom.ReadByte();
                entry.ID = Conversions.ToByte(curID);
                entry.BParam1 = rom.ReadByte();
                entry.BParam2 = rom.ReadByte();
                entry.ModelID = rom.ReadByte();
                entry.BehavAddress = rom.ReadUInt32();
                ContentTable.Add(entry);
            }
        }

        public void Write(RomManager rommgr)
        {
            try
            {
                var rom = rommgr.GetBinaryRom(FileAccess.ReadWrite);

                // Set ROM position
                rom.Position = TableRomLocationCustom;

                // Write data of each entry in the list
                for (int i = 0, loopTo = ContentTable.Count - 1; i <= loopTo; i++)
                {
                    var entry = ContentTable[i];
                    rom.Write(Conversions.ToByte(i));
                    rom.Write(entry.BParam1);
                    rom.Write(entry.BParam2);
                    rom.Write(entry.ModelID);
                    rom.Write(entry.BehavAddress);
                }

                // Finish table
                rom.Write(0x6300000000000000);

                // Update RAM Pointer in the ASM Code
                bool shouldUpdate = WriteNewPointer(rom);
                rom.Close();

                // Update Checksum
                if (shouldUpdate)
                {
                    General.PatchClass.UpdateChecksum(rommgr.RomFile);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error at writing table to ROM.", ex);
            }
        }

        private bool WriteNewPointer(BinaryRom rom)
        {
            // Get RAM location
            uint address = GetRamLocation(rom);

            // Set ROM position
            if (address != TableRamLocation)
            {
                rom.Position = 0x7C8E2;
                rom.Write(Conversions.ToUShort(TableRamLocation >> 16 & (long)0xFFFF));
                rom.Position = 0x7C8E6;
                rom.Write(Conversions.ToUShort(TableRamLocation & (long)0xFFFF));
                return true;
            }

            return false;
        }

        public void Read(string fileName)
        {
            Read(fileName, true);
        }

        public void Read(string fileName, bool clearList)
        {
            if (clearList)
                ContentTable.Clear();
            try
            {
                var switchExpr = Path.GetExtension(fileName).ToLower();
                switch (switchExpr)
                {
                    case ".ibc":
                        {
                            ReadFromJson(fileName);
                            break;
                        }

                    case ".txt":
                        {
                            ReadFromTxt(fileName);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw new FormatException("Error at reading file. It probably has a wrong format.", ex);
            }
        }

        public void Write(string fileName)
        {
            try
            {
                var switchExpr = Path.GetExtension(fileName).ToLower();
                switch (switchExpr)
                {
                    case ".ibc":
                        {
                            WriteToJson(fileName);
                            break;
                        }

                    case ".txt":
                        {
                            WriteToTxt(fileName);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw new FormatException("Error at reading file. It probably has a wrong format.", ex);
            }
        }

        private void ReadFromJson(string fileName)
        {
            var ct = JToken.Parse(File.ReadAllText(fileName)).ToObject<ItemBoxContentTable>();
            ContentTable.AddRange(ct.ToArray());
        }

        private void ReadFromTxt(string fileName)
        {
            foreach (string line in File.ReadAllLines(fileName))
            {
                var vals = line.Split(',');
                var entry = new ItemBoxContentEntry();
                entry.ID = Convert.ToByte(vals[0].Trim(), 16);
                vals[1] = vals[1].Trim();
                entry.BParam1 = Convert.ToByte(vals[1].Substring(0, 2), 16);
                entry.BParam2 = Convert.ToByte(vals[1].Substring(2, 2), 16);
                entry.ModelID = Convert.ToByte(vals[2].Trim(), 16);
                entry.BehavAddress = Convert.ToUInt32(vals[3].Trim(), 16);
                ContentTable.Add(entry);
            }
        }

        private void WriteToJson(string fileName)
        {
            File.WriteAllText(fileName, JToken.FromObject(ContentTable).ToString());
        }

        private void WriteToTxt(string fileName)
        {
            var sw = new StreamWriter(fileName);
            foreach (ItemBoxContentEntry entry in ContentTable)
            {
                ushort bparams = (ushort)(Conversions.ToUShort(entry.BParam1) << 16 | entry.BParam2);
                sw.WriteLine($"{entry.ID.ToString("X2")}, {bparams.ToString("X4")}, {entry.ModelID.ToString("X2")}, {entry.BehavAddress.ToString("X8")}");
            }

            sw.Flush();
            sw.Close();
        }
    }
}