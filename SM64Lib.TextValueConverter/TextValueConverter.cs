using System;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.TextValueConverter
{
    public static class TextValueConverter
    {
        public static event WantIntegerValueModeEventHandler WantIntegerValueMode;
        public delegate void WantIntegerValueModeEventHandler(WantIntegerValueModeEventArgs e);

        public static int ValueFromText(string Text, int DefaultValue = 0, int useIVM = -1)
        {
            return Conversions.ToInteger(LongFromText(Text, DefaultValue, useIVM));
        }

        public static long LongFromText(string Text, long DefaultValue = 0, int useIVM = -1)
        {
            try
            {
                Text = Text?.Trim();
                int IVM = useIVM > -1 ? useIVM : GetIntegerValueMode();
                switch (true)
                {
                    case object _ when Text.StartsWith("0x"):
                    case object _ when Text.StartsWith("&h"):
                    case object _ when useIVM == 1:
                    case object _ when useIVM == 2:
                        return Convert.ToInt32(Text.Substring(2), 16);
                    case object _ when Text.StartsWith("$"):
                    case object _ when useIVM == 3:
                        return Convert.ToInt32(Text.Substring(1), 16);
                    case object _ when Text.StartsWith("0b"):
                    case object _ when Text.StartsWith("&b"):
                        return Convert.ToInt32(Text.Substring(2), 2);
                    default:
                        if (IVM == 0 || useIVM == 0)
                        {
                            try
                            {
                                return Convert.ToInt32(Text);
                            }
                            catch (Exception)
                            {
                            }

                            try
                            {
                                return Convert.ToInt32(Text, 16);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        else
                        {
                            try
                            {
                                return Convert.ToInt32(Text, 16);
                            }
                            catch (Exception)
                            {
                            }

                            try
                            {
                                return Convert.ToInt32(Text);
                            }
                            catch (Exception)
                            {
                            }
                        }

                        return 0;
                }
            }
            catch (Exception)
            {
                return DefaultValue;
            }
        }

        public static string TextFromValue(long Value, int IVM = -1, int charCount = 0)
        {
            if (IVM == -1)
            {
                IVM = GetIntegerValueMode();
            }

            switch (IVM)
            {
                case 0:
                    return Value.ToString(GetCharCountAsZeroString(charCount));
                case 1:
                    return "0x" + Value.ToString("X" + (charCount > 0 ? charCount.ToString() : ""));
                case 2:
                    return "&H" + Value.ToString("X" + (charCount > 0 ? charCount.ToString() : ""));
                case 3:
                    return "$" + Value.ToString("X" + (charCount > 0 ? charCount.ToString() : ""));
                default:
                    return string.Empty;
            }
        }

        private static string GetCharCountAsZeroString(int charCount)
        {
            string GetCharCountAsZeroStringRet = default;
            GetCharCountAsZeroStringRet = "";
            while (GetCharCountAsZeroStringRet.Length < charCount)
                GetCharCountAsZeroStringRet += "0";
            return GetCharCountAsZeroStringRet;
        }

        private static int GetIntegerValueMode()
        {
            var e = new WantIntegerValueModeEventArgs();
            WantIntegerValueMode?.Invoke(e);
            return e.IntegerValueMode;
        }
    }

    public class WantIntegerValueModeEventArgs : EventArgs
    {
        public int IntegerValueMode { get; set; }
    }
}