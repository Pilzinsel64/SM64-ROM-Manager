using System;
using System.Collections.Generic;
using System.Data;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;

namespace SM64Lib.Music
{
    public class MusicList : List<MusicSequence>
    {

        // C o n s t s

        public const int addrMusicStart = 0x1210000;

        // A u t o   P r o p e r t i e s

        public bool EnableMusicHack { get; set; } = false;
        public bool NeedToSaveNInsts { get; set; } = false;
        public bool NeedToSaveSequenceNames { get; set; } = false;
        public bool NeedToSaveSequences { get; set; } = false;
        public bool NeedToSaveMusicHackSettings { get; set; } = false;

        // O t h e r   P r o p e r t i e s

        public bool NeedToSave
        {
            get
            {
                return NeedToSaveNInsts || NeedToSaveMusicHackSettings || NeedToSaveSequenceNames || NeedToSaveSequences;
            }
        }

        public long Length
        {
            get
            {
                return this.Sum(n => n.Lenght + 0x8) + 0x4;
            }
        }

        // M e t h o d s

        public void Read(RomManager rommgr)
        {
            BinaryData s = rommgr.GetBinaryRom(FileAccess.Read);
            s.Position = 0x1210002;
            short musicCount = s.ReadInt16();

            // Read NInsts
            var tNInstList = ReadNInsts(s, 0x7F0000, musicCount);

            // Read Sequence Names
            var tNames = ReadSequenceNames(rommgr);
            if (!tNames.Any())
            {
                tNames = ReadSequenceNames(s, 0x7F1000, musicCount);
            }

            // Read Sequences
            Clear();
            AddRange(ReadSequences(s, addrMusicStart, musicCount, tNInstList, tNames));

            // Check for Music Hack
            s.Position = 0xD213A;
            ushort t001 = s.ReadUInt16();
            s.Position = 0xD213E;
            ushort t002 = s.ReadUInt16();
            EnableMusicHack = t001 == 0x807C & t002 == 0x0;
            s.Close();
        }

        public void Write(RomManager rommgr, ref int lastPosition)
        {
            BinaryData s = rommgr.GetBinaryRom(FileAccess.ReadWrite);

            // Enable/Disable Music Hack
            if (NeedToSaveMusicHackSettings)
            {
                s.Position = 0xD213A;
                s.Write(Conversions.ToUShort(EnableMusicHack ? 0x807C : 0x801D));
                s.Position = 0xD213E;
                s.Write(Conversions.ToUShort(EnableMusicHack ? 0x0 : 0xE000));
                s.Position = 0xD215A;
                s.Write(Conversions.ToUShort(EnableMusicHack ? 0x807C : 0x801D));
                s.Position = 0xD215E;
                s.Write(Conversions.ToUShort(EnableMusicHack ? 0x0 : 0xE000));
                s.Position = 0xD459A;
                s.Write(Conversions.ToUShort(EnableMusicHack ? 0x807C : 0x801D));
                s.Position = 0xD459E;
                s.Write(Conversions.ToUShort(EnableMusicHack ? 0x0 : 0xE000));
                s.Position = 0xEE2B0;
                s.Write(Conversions.ToUInteger(EnableMusicHack ? 0xBD00 : 0x6D00));
                s.Position = 0xD48B4;
                s.Write(Conversions.ToUInteger(EnableMusicHack ? 0x3C02803D : 0x3C02807C)); // &H3C02807C
                s.Position = 0xD48B8;
                s.Write(Conversions.ToUInteger(EnableMusicHack ? 0x34420000 : 0x34420000));
            }

            var arrMe = ToArray();

            // Write Music Names
            if (NeedToSaveSequenceNames)
            {
                WriteSequenceNames(rommgr, arrMe);
            }

            // Write NInsts
            if (NeedToSaveNInsts)
            {
                WriteNInst(s, 0x7F0000, arrMe);
            }

            // Write Music Sequences
            lastPosition = WriteSequences(s, addrMusicStart, arrMe, NeedToSaveSequences);

            // Reset NeedToSave Properties
            NeedToSaveSequences = false;
            NeedToSaveNInsts = false;
            NeedToSaveSequenceNames = false;
            NeedToSaveMusicHackSettings = false;
            s.Close();
        }

        // S h a r e d   M e t h o d s

        private static InstrumentSetList[] ReadNInsts(BinaryData s, int TableStart, short Count)
        {
            var tNInstList = new List<InstrumentSetList>();
            s.Position = TableStart;
            for (int i = 0, loopTo = Count - 1; i <= loopTo; i++)
            {
                ushort startoff = s.ReadUInt16();
                var n = new InstrumentSetList();
                tNInstList.Add(n);
                int offBefore = Conversions.ToInteger(s.Position);
                n.ReadNInst(s, TableStart + startoff);
                s.Position = offBefore;
            }

            return tNInstList.ToArray();
        }

        private static string[] ReadSequenceNames(BinaryData s, int RomAddress, int Count)
        {
            s.Position = RomAddress;
            var tNames = new List<string>();
            for (int i = 0, loopTo = Count - 1; i <= loopTo; i++)
            {
                if (s.ReadByte() == 0xFF)
                {
                    s.Position -= 1;
                }
                else
                {
                    s.Position -= 1;
                    tNames.Add(s.ReadString());
                }
            }

            return tNames.ToArray();
        }

        private static string[] ReadSequenceNames(RomManager rommgr)
        {
            return rommgr.RomConfig.MusicConfig.SqeuenceNames.ToArray();
        }

        private static MusicSequence[] ReadSequences(BinaryData s, int TableStart, int Count, InstrumentSetList[] tNInstList, string[] tNames)
        {
            s.Position = TableStart + 4;
            var tSequences = new List<MusicSequence>();
            for (int i = 0, loopTo = Count - 1; i <= loopTo; i++)
            {
                uint startoff = s.ReadUInt32();
                uint len = s.ReadUInt32();
                var ms = new MusicSequence();
                tSequences.Add(ms);
                if (tNames.Length > i)
                    ms.Name = tNames[i];
                if (tNInstList.Length > i)
                    ms.InstrumentSets = tNInstList[i];
                int offBefore = Conversions.ToInteger(s.Position);
                ms.ReadData(s, (int)(TableStart + startoff), Conversions.ToInteger(len));
                s.Position = offBefore;
            }

            return tSequences.ToArray();
        }

        public static void Prepaire(RomManager rommgr)
        {
            BinaryData s = rommgr.GetBinaryRom(FileAccess.ReadWrite);
            s.Position = 0x7B0863;
            byte musicCount = s.ReadByte();

            // Set original Names
            var tNames = new[] { "No Music", "High Score", "Title Screen", "Bob-Omb Battlefield", "Inside Castle", "Dire, Dire Docks", "Lethal Lava Land", "Bowser Battle", "Snow", "Slide", "Haunted House", "Piranha Plant Lullaby", "Hazy Maze Cave", "Star Select", "Wing Cap", "Metal Cap", "Bowser Message", "Bowser Course", "Star Catch", "Merry-Go-Round", "Start and End Race with Koopa the Quick", "Star Appears", "Boss Fight", "Take a Key", "Endless Stairs", "Final Boss", "Staff Credits", "Puzzle Solved", "Toad Message", "Peach Message", "Introduction Scene", "Last Star Fanfare", "Ending Scene", "File Select", "Lakitu Appears" };

            // Read original sequences
            var tSequences = ReadSequences(s, 0x7B0860, musicCount, Array.Empty<InstrumentSetList>(), tNames);
            s.Position = 0xDC0B8;
            s.Write(0);

            // Write sequences to the new Position
            WriteSequences(s, addrMusicStart, tSequences, true);

            // Write new sequence names
            WriteSequenceNames(rommgr, tSequences);

            // Write NInsts
            WriteNInst(s, 0x7F0000, tSequences);

            // Edit ASM-Code to load from the new location
            s.Position = 0x7B085F;
            s.Write(17);
            s.Position = 0xD4714;
            s.Write(0x3C040121);
            s.Position = 0xD471C;
            s.Write(0x24840000);
            s.Position = 0xD4768;
            s.Write(0x3C040121);
            s.Position = 0xD4770;
            s.Write(0x24840000);
            s.Position = 0xD4784;
            s.Write(0x3C050121);
            s.Position = 0xD4788;
            s.Write(0x24A50000);
            s.Position = 0xD48B4;
            s.Write(0x3C02807C);
            s.Position = 0xD48B8;
            s.Write(0x34420000);

            // Edit ASM-Code to load from new location
            s.Position = 0xD48C6;
            s.Write(Conversions.ToShort(0x7F));
            s.Position = 0xD48CC;
            s.Write(0x34840000);
            s.Position = 0xD48DA;
            s.Write(Conversions.ToShort(0x200));

            // Check for Music Hack
            s.Position = 0xD213A;
            ushort t001 = s.ReadUInt16();
            s.Position = 0xD213E;
            ushort t002 = s.ReadUInt16();
            if (t001 == 0x805D & t002 == 0xC000)
            {
                s.Position = 0xD213A;
                s.Write(Conversions.ToUShort(0x807C));
                s.Position = 0xD213E;
                s.Write(Conversions.ToUShort(0x0));
                s.Position = 0xD215A;
                s.Write(Conversions.ToUShort(0x807C));
                s.Position = 0xD215E;
                s.Write(Conversions.ToUShort(0x0));
                s.Position = 0xD459A;
                s.Write(Conversions.ToUShort(0x807C));
                s.Position = 0xD459E;
                s.Write(Conversions.ToUShort(0x0));
                s.Position = 0xEE2B0;
                s.Write(Conversions.ToUInteger(0xBD00));
            }

            s.Close();
        }

        private static void WriteSequenceNames(RomManager rommgr, MusicSequence[] sequences)
        {
            rommgr.RomConfig.MusicConfig.SqeuenceNames.Clear();
            rommgr.RomConfig.MusicConfig.SqeuenceNames.AddRange(sequences.Select(n => n.Name));
        }

        private static void WriteNInst(BinaryData s, int TableStart, MusicSequence[] sequences)
        {
            s.Position = TableStart;
            int lastNInstDataOffset = TableStart + sequences.Length * 2;
            foreach (MusicSequence ms in sequences)
            {
                s.Write(Conversions.ToUShort(lastNInstDataOffset - TableStart));
                int lastOff = Conversions.ToInteger(s.Position);
                ms.InstrumentSets.WriteNInst(s, lastNInstDataOffset);
                lastNInstDataOffset += ms.InstrumentSets.NInstLength;
                s.Position = lastOff;
            }
        }

        private static int WriteSequences(BinaryData s, int TableStart, MusicSequence[] sequences, bool WriteData)
        {
            s.Position = TableStart;
            s.Write(Conversions.ToShort(3));
            s.Write(Conversions.ToShort(sequences.Length));

            // Write sequences to the new Position
            int curMsDataOff = General.HexRoundUp1(TableStart + 4 + sequences.Length * 0x8);
            foreach (MusicSequence ms in sequences)
            {
                if (WriteData)
                {
                    s.Write(Conversions.ToUInteger(curMsDataOff - TableStart));
                    s.Write(Conversions.ToUInteger(ms.Lenght));
                    int lastOff = Conversions.ToInteger(s.Position);
                    ms.WriteData(s, curMsDataOff);
                    s.Position = lastOff;
                }

                curMsDataOff += General.HexRoundUp1(ms.Lenght);
            }

            return curMsDataOff;
        }
    }
}