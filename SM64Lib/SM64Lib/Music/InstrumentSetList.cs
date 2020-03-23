using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;

namespace SM64Lib.Music
{
    public class InstrumentSetList
    {
        public List<byte> Sets { get; private set; } = new List<byte>();

        public int Count
        {
            get
            {
                return Sets.Count;
            }
        }

        public byte NInstLength
        {
            get
            {
                return Conversions.ToByte(Sets.Count + 1);
            }
        }

        public void ReadNInst(BinaryData s, int RomAddress)
        {
            s.Position = RomAddress;
            Sets.Clear();
            for (int i = 0, loopTo = s.ReadByte() - 1; i <= loopTo; i++)
                Sets.Add(s.ReadByte());
        }

        public void WriteNInst(BinaryData s, int RomAddress)
        {
            s.Position = RomAddress;
            s.WriteByte(Conversions.ToByte(Sets.Count));
            foreach (byte b in Sets)
                s.WriteByte(b);
        }
    }

    // Public Enum InstSets As Byte
    // ''' <summary>NInst 00 - SFX</summary>
    // NInst_00_SFX
    // ''' <summary>NInst 01 - SFX</summary>
    // NInst_01_SFX
    // ''' <summary>NInst 02 - SFX</summary>
    // NInst_02_SFX
    // ''' <summary>NInst 03 - SFX</summary>
    // NInst_03_SFX
    // ''' <summary>NInst 04 - SFX</summary>
    // NInst_04_SFX
    // ''' <summary>NInst 05 - SFX</summary>
    // NInst_05_SFX
    // ''' <summary>NInst 06 - SFX</summary>
    // NInst_06_SFX
    // ''' <summary>NInst 07 - SFX</summary>
    // NInst_07_SFX
    // ''' <summary>NInst 08 - SFX</summary>
    // NInst_08_SFX
    // ''' <summary>NInst 09 - SFX</summary>
    // NInst_09_SFX
    // ''' <summary>NInst 10 - SFX</summary>
    // NInst_10_SFX
    // ''' <summary>NInst 11 - Snow</summary>
    // NInst_11_Snow
    // ''' <summary>NInst 12 - Unused</summary>
    // NInst_12_Unused
    // ''' <summary>NInst 13 - Slide</summary>
    // NInst_13_Slide
    // ''' <summary>NInst 14 - Inside Castle</summary>
    // NInst_14_Inside_Castle
    // ''' <summary>NInst 15 - Shifting Sand Land</summary>
    // NInst_15_Shifting_Sand_Land
    // ''' <summary>NInst 16 - Haunted House</summary>
    // NInst_16_Haunted_House
    // ''' <summary>NInst 17 - Title Screen</summary>
    // NInst_17_Title_Screen
    // ''' <summary>NInst 18 - Bowser Battle</summary>
    // NInst_18_Bowser_Battle
    // ''' <summary>NInst 19 - Water</summary>
    // NInst_19_Water
    // ''' <summary>NInst 20 - Piranha Plant</summary>
    // NInst_20_Piranha_Plant
    // ''' <summary>NInst 21 - Hazy Maze</summary>
    // NInst_21_Hazy_Maze
    // ''' <summary>NInst 22 - Star Select</summary>
    // NInst_22_Star_Select
    // ''' <summary>NInst 23 - Wing Cap</summary>
    // NInst_23_Wing_Cap
    // ''' <summary>NInst 24 - Metal Cap</summary>
    // NInst_24_Metal_Cap
    // ''' <summary>NInst 25 - Bowser Course</summary>
    // NInst_25_Bowser_Course
    // ''' <summary>NInst 26 - Fanfare</summary>
    // NInst_26_Fanfare
    // ''' <summary>NInst 27 - Boss Fight</summary>
    // NInst_27_Boss_Fight
    // ''' <summary>NInst 28 - Looping Stairs</summary>
    // NInst_28_Looping_Stairs
    // ''' <summary>NInst 29 - Final Bowser</summary>
    // NInst_29_Final_Bowser
    // ''' <summary>NInst 30 - Peach Message</summary>
    // NInst_30_Peach_Message
    // ''' <summary>NInst 31 - Star Catch</summary>
    // NInst_31_Star_Catch
    // ''' <summary>NInst 32 - Toad</summary>
    // NInst_32_Toad
    // ''' <summary>NInst 33 - Merry-Go-Round</summary>
    // NInst_33_Merry_Go_Round
    // ''' <summary>NInst 34 - Bob-Omb- Battlefield</summary>
    // NInst_34_Bob_Omb_Battlefield
    // ''' <summary>NInst 35 - Ending</summary>
    // NInst_35_Ending
    // ''' <summary>NInst 36 - File Select</summary>
    // NInst_36_File_Select
    // ''' <summary>NInst 37 - Credits</summary>
    // NInst_37_Credits
    // End Enum

}