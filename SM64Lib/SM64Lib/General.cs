using System;
using System.Collections.Generic;
using System.Diagnostics;
using global::System.Drawing;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Patching;

namespace SM64Lib
{
    public static class General
    {
        public static byte[] DisplayListCommandsWithPointerList { get; private set; } = new byte[] { 0x1, 0x3, 0x4, 0x6, 0xFD };
        public static bool[] ActSelectorDefaultValues { get; private set; } = new bool[] { false, false, false, true, true, false, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false };
        public static IniParser.FileIniDataParser FileIniParser { get; private set; } = new IniParser.FileIniDataParser();
        public static IniParser.StreamIniDataParser StreamIniParser { get; private set; } = new IniParser.StreamIniDataParser();
        public static Objects.ObjectBanks.Data.ObjectBankDataListCollection ObjectBankData { get; private set; } = new Objects.ObjectBanks.Data.ObjectBankDataListCollection();
        public static PatchClass PatchClass { get; private set; } = new PatchClass();

        public static bool IsDebugging
        {
            get
            {
                return Debugger.IsAttached;
            }
        }

        public static short KeepInInt16Range(double value)
        {
            if (value > short.MaxValue)
            {
                value = short.MaxValue;
            }
            else if (value < short.MinValue)
            {
                value = short.MinValue;
            }

            return Conversions.ToShort(value);
        }

        internal static IReadOnlyDictionary<string, string> MyFilePaths
        {
            get
            {
                return FilePathsConfiguration.DefaultConfiguration.Files;
            }
        }

        public static void CopyBitmap(Bitmap src, Bitmap dest)
        {
            for (int y = 0, loopTo = src.Height - 1; y <= loopTo; y++)
            {
                for (int x = 0, loopTo1 = src.Width - 1; x <= loopTo1; x++)
                    dest.SetPixel(x, y, src.GetPixel(x, y));
            }
        }

        public static Bitmap CopyBitmap(Bitmap src)
        {
            return CopyBitmap(src, src.PixelFormat);
        }

        public static Bitmap CopyBitmap(Bitmap src, System.Drawing.Imaging.PixelFormat pixelFormat)
        {
            var dest = new Bitmap(src.Width, src.Height, pixelFormat);
            CopyBitmap(src, dest);
            return dest;
        }

        public static double Round(double d)
        {
            return Math.Round(d, MidpointRounding.AwayFromZero);
        }

        public static bool CompareTwoByteArrays(byte[] arr1, byte[] arr2, uint size = 0)
        {
            if (arr2.Length != arr1.Length) return false;

            int loopTo = size != 0 ? (int)size : arr1.Length;

            for (int i = 0; i < loopTo; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        public static byte GetLevelIndexFromID(byte LevelID)
        {
            switch (LevelID)
            {
                case 0x4:
                    {
                        return 0;
                    }

                case 0x5:
                    {
                        return 1;
                    }

                case 0x6:
                    {
                        return 2;
                    }

                case 0x7:
                    {
                        return 3;
                    }

                case 0x8:
                    {
                        return 4;
                    }

                case 0x9:
                    {
                        return 5;
                    }

                case 0xA:
                    {
                        return 6;
                    }

                case 0xB:
                    {
                        return 7;
                    }

                case 0xC:
                    {
                        return 8;
                    }

                case 0xD:
                    {
                        return 9;
                    }

                case 0xE:
                    {
                        return 10;
                    }

                case 0xF:
                    {
                        return 11;
                    }

                case 0x10:
                    {
                        return 12;
                    }

                case 0x11:
                    {
                        return 13;
                    }

                case 0x12:
                    {
                        return 14;
                    }

                case 0x13:
                    {
                        return 15;
                    }

                case 0x14:
                    {
                        return 16;
                    }

                case 0x15:
                    {
                        return 17;
                    }

                case 0x16:
                    {
                        return 18;
                    }

                case 0x17:
                    {
                        return 19;
                    }

                case 0x18:
                    {
                        return 20;
                    }

                case 0x19:
                    {
                        return 21;
                    }

                case 0x1A:
                    {
                        return 22;
                    }

                case 0x1B:
                    {
                        return 23;
                    }

                case 0x1C:
                    {
                        return 24;
                    }

                case 0x1D:
                    {
                        return 25;
                    }

                case 0x1E:
                    {
                        return 26;
                    }

                case 0x1F:
                    {
                        return 27;
                    }

                case 0x21:
                    {
                        return 28;
                    }

                case 0x22:
                    {
                        return 29;
                    }

                case 0x24:
                    {
                        return 30;
                    }

                default:
                    {
                        return 5;
                    }
            }
        }

        public static byte GetLevelIDFromIndex(byte LevelID)
        {
            switch (LevelID)
            {
                case 0:
                    {
                        return 0x4;
                    }

                case 1:
                    {
                        return 0x5;
                    }

                case 2:
                    {
                        return 0x6;
                    }

                case 3:
                    {
                        return 0x7;
                    }

                case 4:
                    {
                        return 0x8;
                    }

                case 5:
                    {
                        return 0x9;
                    }

                case 6:
                    {
                        return 0xA;
                    }

                case 7:
                    {
                        return 0xB;
                    }

                case 8:
                    {
                        return 0xC;
                    }

                case 9:
                    {
                        return 0xD;
                    }

                case 10:
                    {
                        return 0xE;
                    }

                case 11:
                    {
                        return 0xF;
                    }

                case 12:
                    {
                        return 0x10;
                    }

                case 13:
                    {
                        return 0x11;
                    }

                case 14:
                    {
                        return 0x12;
                    }

                case 15:
                    {
                        return 0x13;
                    }

                case 16:
                    {
                        return 0x14;
                    }

                case 17:
                    {
                        return 0x15;
                    }

                case 18:
                    {
                        return 0x16;
                    }

                case 19:
                    {
                        return 0x17;
                    }

                case 20:
                    {
                        return 0x18;
                    }

                case 21:
                    {
                        return 0x19;
                    }

                case 22:
                    {
                        return 0x1A;
                    }

                case 23:
                    {
                        return 0x1B;
                    }

                case 24:
                    {
                        return 0x1C;
                    }

                case 25:
                    {
                        return 0x1D;
                    }

                case 26:
                    {
                        return 0x1E;
                    }

                case 27:
                    {
                        return 0x1F;
                    }

                case 28:
                    {
                        return 0x21;
                    }

                case 29:
                    {
                        return 0x22;
                    }

                case 30:
                    {
                        return 0x24;
                    }

                default:
                    {
                        return 5;
                    }
            }
        }

        public static int HexRoundUp1(int value)
        {
            while (value % 0x10 != 0)
                value += 1;
            return value;
        }

        public static long HexRoundUp1(long value)
        {
            while (value % 0x10 != 0)
                value += 1;
            return value;
        }

        public static void HexRoundUp2(ref long value)
        {
            while (value % 0x10 != 0)
                value += 1;
        }

        public static void HexRoundUp2(ref uint value)
        {
            while (value % 0x10 != 0)
                value += 1;
        }

        public static void HexRoundUp2(ref int value)
        {
            while (value % 0x10 != 0)
                value += 1;
        }

        public static string FillStrToCharCount(string str, int charCount, string fillVal = "0")
        {
            if (fillVal.Count() == 0)
                return str;
            if (charCount == 0)
                return str;
            while (str.Count() < charCount)
                str = fillVal + str;
            return str;
        }

        public static Geolayout.BackgroundPointers GetBackgroundAddressOfID(Geolayout.BackgroundIDs ID, bool EndAddr)
        {
            switch (ID)
            {
                case Geolayout.BackgroundIDs.AboveClouds:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.AboveCloudsEnd;
                        return Geolayout.BackgroundPointers.AboveCloudsStart;
                    }

                case Geolayout.BackgroundIDs.BelowClouds:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.BelowCloudsEnd;
                        return Geolayout.BackgroundPointers.BelowCloudsStart;
                    }

                case Geolayout.BackgroundIDs.Cavern:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.CavernEnd;
                        return Geolayout.BackgroundPointers.CavernStart;
                    }

                case Geolayout.BackgroundIDs.Desert:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.DesertEnd;
                        return Geolayout.BackgroundPointers.DesertStart;
                    }

                case Geolayout.BackgroundIDs.FlamingSky:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.FlamingSkyEnd;
                        return Geolayout.BackgroundPointers.FlamingSkyStart;
                    }

                case Geolayout.BackgroundIDs.HauntedForest:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.HauntedForestEnd;
                        return Geolayout.BackgroundPointers.HauntedForestStart;
                    }

                case Geolayout.BackgroundIDs.Ocean:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.OceanEnd;
                        return Geolayout.BackgroundPointers.OceanStart;
                    }

                case Geolayout.BackgroundIDs.PurpleClouds:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.PurpleCloudsEnd;
                        return Geolayout.BackgroundPointers.PurpleCloudsStart;
                    }

                case Geolayout.BackgroundIDs.SnowyMountains:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.SnowyMountainsEnd;
                        return Geolayout.BackgroundPointers.SnowyMountainsStart;
                    }

                case Geolayout.BackgroundIDs.UnderwaterCity:
                    {
                        if (EndAddr)
                            return Geolayout.BackgroundPointers.UnderwaterCityEnd;
                        return Geolayout.BackgroundPointers.UnderwaterCityStart;
                    }
            }

            return EndAddr ? Geolayout.BackgroundPointers.OceanEnd : Geolayout.BackgroundPointers.OceanStart;
        }

        public static string CommandByteArrayToString(byte[] bytes)
        {
            string res = string.Empty;
            foreach (byte b in bytes)
            {
                if (!string.IsNullOrEmpty(res))
                {
                    res += " ";
                }

                res += b.ToString("X2");
            }

            return res;
        }
    }
}