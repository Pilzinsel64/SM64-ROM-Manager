using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace SM64Lib.Text
{
    public class M64TextEncoding : System.Text.Encoding
    {
        private static M64TextEncoding M64Text_enc = new M64TextEncoding();
        public static bool AutoDetectStartEndQuotationMarks { get; set; } = true;

        public static System.Text.Encoding M64Text
        {
            get
            {
                return M64Text_enc;
            }
        }

        public override string GetString(byte[] bytes)
        {
            string txt = "";
            foreach (byte b in bytes)
            {
                switch (b)
                {
                    case 0x0:
                        {
                            txt += "0";
                            break;
                        }

                    case 0x1:
                        {
                            txt += "1";
                            break;
                        }

                    case 0x2:
                        {
                            txt += "2";
                            break;
                        }

                    case 0x3:
                        {
                            txt += "3";
                            break;
                        }

                    case 0x4:
                        {
                            txt += "4";
                            break;
                        }

                    case 0x5:
                        {
                            txt += "5";
                            break;
                        }

                    case 0x6:
                        {
                            txt += "6";
                            break;
                        }

                    case 0x7:
                        {
                            txt += "7";
                            break;
                        }

                    case 0x8:
                        {
                            txt += "8";
                            break;
                        }

                    case 0x9:
                        {
                            txt += "9";
                            break;
                        }

                    case 0xA:
                        {
                            txt += "A";
                            break;
                        }

                    case 0xB:
                        {
                            txt += "B";
                            break;
                        }

                    case 0xC:
                        {
                            txt += "C";
                            break;
                        }

                    case 0xD:
                        {
                            txt += "D";
                            break;
                        }

                    case 0xE:
                        {
                            txt += "E";
                            break;
                        }

                    case 0xF:
                        {
                            txt += "F";
                            break;
                        }

                    case 0x10:
                        {
                            txt += "G";
                            break;
                        }

                    case 0x11:
                        {
                            txt += "H";
                            break;
                        }

                    case 0x12:
                        {
                            txt += "I";
                            break;
                        }

                    case 0x13:
                        {
                            txt += "J";
                            break;
                        }

                    case 0x14:
                        {
                            txt += "K";
                            break;
                        }

                    case 0x15:
                        {
                            txt += "L";
                            break;
                        }

                    case 0x16:
                        {
                            txt += "M";
                            break;
                        }

                    case 0x17:
                        {
                            txt += "N";
                            break;
                        }

                    case 0x18:
                        {
                            txt += "O";
                            break;
                        }

                    case 0x19:
                        {
                            txt += "P";
                            break;
                        }

                    case 0x1A:
                        {
                            txt += "Q";
                            break;
                        }

                    case 0x1B:
                        {
                            txt += "R";
                            break;
                        }

                    case 0x1C:
                        {
                            txt += "S";
                            break;
                        }

                    case 0x1D:
                        {
                            txt += "T";
                            break;
                        }

                    case 0x1E:
                        {
                            txt += "U";
                            break;
                        }

                    case 0x1F:
                        {
                            txt += "V";
                            break;
                        }

                    case 0x20:
                        {
                            txt += "W";
                            break;
                        }

                    case 0x21:
                        {
                            txt += "X";
                            break;
                        }

                    case 0x22:
                        {
                            txt += "Y";
                            break;
                        }

                    case 0x23:
                        {
                            txt += "Z";
                            break;
                        }

                    case 0x24:
                        {
                            txt += "a";
                            break;
                        }

                    case 0x25:
                        {
                            txt += "b";
                            break;
                        }

                    case 0x26:
                        {
                            txt += "c";
                            break;
                        }

                    case 0x27:
                        {
                            txt += "d";
                            break;
                        }

                    case 0x28:
                        {
                            txt += "e";
                            break;
                        }

                    case 0x29:
                        {
                            txt += "f";
                            break;
                        }

                    case 0x2A:
                        {
                            txt += "g";
                            break;
                        }

                    case 0x2B:
                        {
                            txt += "h";
                            break;
                        }

                    case 0x2C:
                        {
                            txt += "i";
                            break;
                        }

                    case 0x2D:
                        {
                            txt += "j";
                            break;
                        }

                    case 0x2E:
                        {
                            txt += "k";
                            break;
                        }

                    case 0x2F:
                        {
                            txt += "l";
                            break;
                        }

                    case 0x30:
                        {
                            txt += "m";
                            break;
                        }

                    case 0x31:
                        {
                            txt += "n";
                            break;
                        }

                    case 0x32:
                        {
                            txt += "o";
                            break;
                        }

                    case 0x33:
                        {
                            txt += "p";
                            break;
                        }

                    case 0x34:
                        {
                            txt += "q";
                            break;
                        }

                    case 0x35:
                        {
                            txt += "r";
                            break;
                        }

                    case 0x36:
                        {
                            txt += "s";
                            break;
                        }

                    case 0x37:
                        {
                            txt += "t";
                            break;
                        }

                    case 0x38:
                        {
                            txt += "u";
                            break;
                        }

                    case 0x39:
                        {
                            txt += "v";
                            break;
                        }

                    case 0x3A:
                        {
                            txt += "w";
                            break;
                        }

                    case 0x3B:
                        {
                            txt += "x";
                            break;
                        }

                    case 0x3C:
                        {
                            txt += "y";
                            break;
                        }

                    case 0x3D:
                        {
                            txt += "z";
                            break;
                        }

                    case 0x3E:
                        {
                            txt += "'";
                            break;
                        }

                    case 0x3F:
                        {
                            txt += ".";
                            break;
                        }

                    case 0x50:
                        {
                            txt += "↑"; // [Up]
                            break;
                        }

                    case 0x51:
                        {
                            txt += "↓"; // [Down]
                            break;
                        }

                    case 0x52:
                        {
                            txt += "←"; // [Left]
                            break;
                        }

                    case 0x53:
                        {
                            txt += "→"; // [Right]
                            break;
                        }

                    case 0x54:
                        {
                            txt += "[A]";
                            break;
                        }

                    case 0x55:
                        {
                            txt += "[B]";
                            break;
                        }

                    case 0x56:
                        {
                            txt += "[C]";
                            break;
                        }

                    case 0x57:
                        {
                            txt += "[Z]";
                            break;
                        }

                    case 0x58:
                        {
                            txt += "[R]";
                            break;
                        }

                    case 0x6F:
                        {
                            txt += ",";
                            break;
                        }

                    case 0xD0:
                        {
                            txt += "/";
                            break;
                        }

                    case 0xD1:
                        {
                            txt += "the";
                            break;
                        }

                    case 0xD2:
                        {
                            txt += "you";
                            break;
                        }

                    case 0x9E:
                        {
                            txt += " ";
                            break;
                        }

                    case 0x9F:
                        {
                            txt += "-";
                            break;
                        }

                    case 0xE0:
                        {
                            txt += "{starsleft}";
                            break;
                        }

                    case 0xE1:
                        {
                            txt += "(";
                            break;
                        }

                    case 0xE2:
                        {
                            txt += ")(";
                            break;
                        }

                    case 0xE3:
                        {
                            txt += ")";
                            break;
                        }

                    case 0xE4:
                        {
                            txt += "+";
                            break;
                        }

                    case 0xE5:
                        {
                            txt += "&";
                            break;
                        }

                    case 0xE6:
                        {
                            txt += ":";
                            break;
                        }

                    case 0xF2:
                        {
                            txt += "!";
                            break;
                        }

                    case 0xF4:
                        {
                            txt += "?";
                            break;
                        }

                    case 0xF5:
                        {
                            if (AutoDetectStartEndQuotationMarks)
                                txt += "\"";
                            else
                                txt += "{sqm}";
                            break;
                        }

                    case 0xF6:
                        {
                            if (AutoDetectStartEndQuotationMarks)
                                txt += "\"";
                            else
                                txt += "{eqm}";
                            break;
                        }

                    case 0xF7:
                        {
                            txt += "~";
                            break;
                        }

                    case 0xF9:
                        {
                            txt += "$";
                            break;
                        }

                    case 0xFA:
                        {
                            txt += "★"; // [star]
                            break;
                        }

                    case 0xFB:
                        {
                            txt += "[x]";
                            break;
                        }

                    case 0xFC:
                        {
                            txt += "•"; // [•]
                            break;
                        }

                    case 0xFD:
                        {
                            txt += "☆"; // [emptystar]
                            break;
                        }

                    case 0xFE:
                        {
                            txt += Environment.NewLine;
                            break;
                        }

                    case 0xFF:
                        {
                            break;
                        }
                }
            }

            return txt;
        }

        public override byte[] GetBytes(string s)
        {
            bool isFirst = true;
            var bytes = new List<byte>();
            s = s.Replace("{starsleft}", "€");
            s = s.Replace("you", "²");
            s = s.Replace("the", "³");
            s = s.Replace("[A]", @"\");
            s = s.Replace("[B]", "°");
            s = s.Replace("[C]", "#");
            s = s.Replace("[Z]", "*");
            s = s.Replace("[R]", ";");
            s = s.Replace(")(", "}");
            s = s.Replace("[x]", "{");
            s = s.Replace("{sqm}", "[");
            s = s.Replace("{eqm}", "]");
            s = s.Replace(Environment.NewLine, "§");
            if (s is object)
            {
                foreach (char ccb in s)
                {
                    string cb = System.Convert.ToString(ccb);
                    switch (cb)
                    {
                        case "0":
                            {
                                bytes.Add(0x0);
                                break;
                            }

                        case "1":
                            {
                                bytes.Add(0x1);
                                break;
                            }

                        case "2":
                            {
                                bytes.Add(0x2);
                                break;
                            }

                        case "3":
                            {
                                bytes.Add(0x3);
                                break;
                            }

                        case "4":
                            {
                                bytes.Add(0x4);
                                break;
                            }

                        case "5":
                            {
                                bytes.Add(0x5);
                                break;
                            }

                        case "6":
                            {
                                bytes.Add(0x6);
                                break;
                            }

                        case "7":
                            {
                                bytes.Add(0x7);
                                break;
                            }

                        case "8":
                            {
                                bytes.Add(0x8);
                                break;
                            }

                        case "9":
                            {
                                bytes.Add(0x9);
                                break;
                            }

                        case "A":
                            {
                                bytes.Add(0xA);
                                break;
                            }

                        case "B":
                            {
                                bytes.Add(0xB);
                                break;
                            }

                        case "C":
                            {
                                bytes.Add(0xC);
                                break;
                            }

                        case "D":
                            {
                                bytes.Add(0xD);
                                break;
                            }

                        case "E":
                            {
                                bytes.Add(0xE);
                                break;
                            }

                        case "F":
                            {
                                bytes.Add(0xF);
                                break;
                            }

                        case "G":
                            {
                                bytes.Add(0x10);
                                break;
                            }

                        case "H":
                            {
                                bytes.Add(0x11);
                                break;
                            }

                        case "I":
                            {
                                bytes.Add(0x12);
                                break;
                            }

                        case "J":
                            {
                                bytes.Add(0x13);
                                break;
                            }

                        case "K":
                            {
                                bytes.Add(0x14);
                                break;
                            }

                        case "L":
                            {
                                bytes.Add(0x15);
                                break;
                            }

                        case "M":
                            {
                                bytes.Add(0x16);
                                break;
                            }

                        case "N":
                            {
                                bytes.Add(0x17);
                                break;
                            }

                        case "O":
                            {
                                bytes.Add(0x18);
                                break;
                            }

                        case "P":
                            {
                                bytes.Add(0x19);
                                break;
                            }

                        case "Q":
                            {
                                bytes.Add(0x1A);
                                break;
                            }

                        case "R":
                            {
                                bytes.Add(0x1B);
                                break;
                            }

                        case "S":
                            {
                                bytes.Add(0x1C);
                                break;
                            }

                        case "T":
                            {
                                bytes.Add(0x1D);
                                break;
                            }

                        case "U":
                            {
                                bytes.Add(0x1E);
                                break;
                            }

                        case "V":
                            {
                                bytes.Add(0x1F);
                                break;
                            }

                        case "W":
                            {
                                bytes.Add(0x20);
                                break;
                            }

                        case "X":
                            {
                                bytes.Add(0x21);
                                break;
                            }

                        case "Y":
                            {
                                bytes.Add(0x22);
                                break;
                            }

                        case "Z":
                            {
                                bytes.Add(0x23);
                                break;
                            }

                        case "a":
                            {
                                bytes.Add(0x24);
                                break;
                            }

                        case "b":
                            {
                                bytes.Add(0x25);
                                break;
                            }

                        case "c":
                            {
                                bytes.Add(0x26);
                                break;
                            }

                        case "d":
                            {
                                bytes.Add(0x27);
                                break;
                            }

                        case "e":
                            {
                                bytes.Add(0x28);
                                break;
                            }

                        case "f":
                            {
                                bytes.Add(0x29);
                                break;
                            }

                        case "g":
                            {
                                bytes.Add(0x2A);
                                break;
                            }

                        case "h":
                            {
                                bytes.Add(0x2B);
                                break;
                            }

                        case "i":
                            {
                                bytes.Add(0x2C);
                                break;
                            }

                        case "j":
                            {
                                bytes.Add(0x2D);
                                break;
                            }

                        case "k":
                            {
                                bytes.Add(0x2E);
                                break;
                            }

                        case "l":
                            {
                                bytes.Add(0x2F);
                                break;
                            }

                        case "m":
                            {
                                bytes.Add(0x30);
                                break;
                            }

                        case "n":
                            {
                                bytes.Add(0x31);
                                break;
                            }

                        case "o":
                            {
                                bytes.Add(0x32);
                                break;
                            }

                        case "p":
                            {
                                bytes.Add(0x33);
                                break;
                            }

                        case "q":
                            {
                                bytes.Add(0x34);
                                break;
                            }

                        case "r":
                            {
                                bytes.Add(0x35);
                                break;
                            }

                        case "s":
                            {
                                bytes.Add(0x36);
                                break;
                            }

                        case "t":
                            {
                                bytes.Add(0x37);
                                break;
                            }

                        case "u":
                            {
                                bytes.Add(0x38);
                                break;
                            }

                        case "v":
                            {
                                bytes.Add(0x39);
                                break;
                            }

                        case "w":
                            {
                                bytes.Add(0x3A);
                                break;
                            }

                        case "x":
                            {
                                bytes.Add(0x3B);
                                break;
                            }

                        case "y":
                            {
                                bytes.Add(0x3C);
                                break;
                            }

                        case "z":
                            {
                                bytes.Add(0x3D);
                                break;
                            }

                        case "'":
                            {
                                bytes.Add(0x3E);
                                break;
                            }

                        case ".":
                            {
                                bytes.Add(0x3F);
                                break;
                            }

                        case "↑":
                            {
                                bytes.Add(0x50);
                                break;
                            }

                        case "↓":
                            {
                                bytes.Add(0x51);
                                break;
                            }

                        case "←":
                            {
                                bytes.Add(0x52);
                                break;
                            }

                        case "→":
                            {
                                bytes.Add(0x53);
                                break;
                            }

                        case @"\":
                            {
                                bytes.Add(0x54);
                                break;
                            }

                        case "°":
                            {
                                bytes.Add(0x55);
                                break;
                            }

                        case "#":
                            {
                                bytes.Add(0x56);
                                break;
                            }

                        case "*":
                            {
                                bytes.Add(0x57);
                                break;
                            }

                        case ";":
                            {
                                bytes.Add(0x58);
                                break;
                            }

                        case ",":
                            {
                                bytes.Add(0x6F);
                                break;
                            }

                        case "/":
                            {
                                bytes.Add(0xD0);
                                break;
                            }

                        case "³":
                            {
                                bytes.Add(0xD1);
                                break;
                            }

                        case "²":
                            {
                                bytes.Add(0xD2);
                                break;
                            }

                        case " ":
                            {
                                bytes.Add(0x9E);
                                break;
                            }

                        case "-":
                            {
                                bytes.Add(0x9F);
                                break;
                            }

                        case "€":
                            {
                                bytes.Add(0xE0);
                                break;
                            }

                        case "(":
                            {
                                bytes.Add(0xE1);
                                break;
                            }

                        case "}":
                            {
                                bytes.Add(0xE2);
                                break;
                            }

                        case ")":
                            {
                                bytes.Add(0xE3);
                                break;
                            }

                        case "+":
                            {
                                bytes.Add(0xE4);
                                break;
                            }

                        case "&":
                            {
                                bytes.Add(0xE5);
                                break;
                            }

                        case ":":
                            {
                                bytes.Add(0xE6);
                                break;
                            }

                        case "!":
                            {
                                bytes.Add(0xF2);
                                break;
                            }

                        case "?":
                            {
                                bytes.Add(0xF4);
                                break;
                            }

                        case "\"":
                            {
                                switch (isFirst)
                                {
                                    case true:
                                        bytes.Add(0xF5);
                                        isFirst = false;
                                        break;
                                    case false:
                                        isFirst = true;
                                        bytes.Add(0xF6);
                                        break;
                                }

                                break;
                            }

                        case "[":
                            bytes.Add(0xF5);
                            break;
                        case "]":
                            bytes.Add(0xF6);
                            break;

                        case "~":
                            {
                                bytes.Add(0xF7);
                                break;
                            }

                        case "$":
                            {
                                bytes.Add(0xF9);
                                break;
                            }

                        case "★":
                            {
                                bytes.Add(0xFA);
                                break;
                            }

                        case "{":
                            {
                                bytes.Add(0xFB);
                                break;
                            }

                        case "•":
                            {
                                bytes.Add(0xFC);
                                break;
                            }

                        case "☆":
                            {
                                bytes.Add(0xFD);
                                break;
                            }

                        case "§":
                            {
                                bytes.Add(0xFE);
                                break;
                            }
                    }
                }
            }

            bytes.Add(0xFF);
            return bytes.ToArray();
        }

        public override int GetByteCount(char[] chars, int index, int count)
        {
            char[] myChars = (char[])chars.Skip(index).Take(count);
            var nbytes = GetBytes(new string(myChars));
            return nbytes.Length;
        }

        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            char[] myChars = (char[])chars.Skip(charIndex).Take(charCount);
            var nbytes = GetBytes(new string(myChars));
            int bytesToCopy = Math.Min(nbytes.Length, bytes.Length - byteIndex);
            for (int i = 0, loopTo = bytesToCopy - 1; i <= loopTo; i++)
                bytes[i + byteIndex] = nbytes[i];
            return bytesToCopy;
        }

        public override int GetCharCount(byte[] bytes, int index, int count)
        {
            byte[] myBytes = (byte[])bytes.Skip(index).Take(count);
            string nstring = GetString(bytes);
            return nstring.Length;
        }

        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
        {
            byte[] myBytes = (byte[])bytes.Skip(byteIndex).Take(byteCount);
            string nstring = GetString(bytes);
            int charsToCopy = Math.Min(nstring.Length, chars.Length - charIndex);
            for (int i = 0, loopTo = charsToCopy; i <= loopTo; i++)
                chars[i + charIndex] = nstring[i];
            return charsToCopy;
        }

        public override int GetMaxByteCount(int charCount)
        {
            throw new NotSupportedException();
        }

        public override int GetMaxCharCount(int byteCount)
        {
            throw new NotSupportedException();
        }
    }
}