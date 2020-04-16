using System;
using global::System.Drawing;
using global::System.Numerics;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.Model.Fast3D.DisplayLists.Script.Commands
{
    public class F3D_VTX
    {
        public static byte GetNumberOfVertices(DisplayListCommand cmd)
        {
            cmd.Position = 1;
            byte value = cmd.ReadByte();
            cmd.Position = 0;
            return (byte)(value >> 4);
        }

        public static byte GetStartIndexInVertexBuffer(DisplayListCommand cmd)
        {
            cmd.Position = 1;
            byte value = cmd.ReadByte();
            cmd.Position = 0;
            return Conversions.ToByte(value & 0xF);
        }

        public static short GetLengthOfVertexData(DisplayListCommand cmd)
        {
            cmd.Position = 2;
            short value = cmd.ReadInt16();
            cmd.Position = 0;
            return value;
        }

        public static int GetSegmentedAddress(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            int value = cmd.ReadInt32();
            cmd.Position = 0;
            return value;
        }

        public static void SetSegmentedAddress(DisplayListCommand cmd, int value)
        {
            cmd.Position = 4;
            cmd.Write(value);
            cmd.Position = 0;
        }
    }

    public class F3D_TRI1
    {
        public static byte GetVertice(DisplayListCommand cmd, byte VerticeNumber)
        {
            cmd.Position = 5 + VerticeNumber - 1;
            byte value = cmd.ReadByte();
            cmd.Position = 0;
            if (value > 0)
                value = (byte)(value / (double)0xA);
            return value;
        }
    }

    public class F3D_SETTILE
    {
        public static N64Graphics.N64Codec GetTextureFormat(DisplayListCommand cmd)
        {
            cmd.Position = 1;
            byte type = cmd.ReadByte();
            cmd.Position = 0;
            switch (type)
            {
                case 0x10:
                    {
                        return N64Graphics.N64Codec.RGBA16;
                    }

                case 0x18:
                    {
                        return N64Graphics.N64Codec.RGBA32;
                    }

                case 0x40:
                    {
                        return N64Graphics.N64Codec.CI4;
                    }

                case 0x48:
                    {
                        return N64Graphics.N64Codec.CI8;
                    }

                case 0x60:
                    {
                        return N64Graphics.N64Codec.IA4;
                    }

                case 0x68:
                    {
                        return N64Graphics.N64Codec.IA8;
                    }

                case 0x70:
                    {
                        return N64Graphics.N64Codec.IA16;
                    }

                case 0x80:
                case 0x90:
                    {
                        return N64Graphics.N64Codec.I4;
                    }

                case 0x88:
                    {
                        return N64Graphics.N64Codec.I8;
                    }

                default:
                    {
                        return default;
                    }
            }
        }

        public static byte GetWrapT(DisplayListCommand cmd)
        {
            cmd.Position = 5;
            byte val = cmd.ReadByte();
            cmd.Position = 0;
            return Conversions.ToByte((val >> 2) & 0x2);
        }

        public static byte GetWrapS(DisplayListCommand cmd)
        {
            cmd.Position = 6;
            byte val = cmd.ReadByte();
            cmd.Position = 0;
            return Conversions.ToByte(val & 0x2);
        }
    }

    public class F3D_TEXTURE
    {
        public static Size GetTextureSize(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            ushort tsX = cmd.ReadUInt16();
            ushort tsY = cmd.ReadUInt16();
            cmd.Position = 0;
            tsX = (ushort)(tsX >> 6);
            if (tsX == 31)
            {
                tsX = 32;
            }
            else if (tsX == 62)
            {
                tsX = 64;
            }

            tsY = (ushort)(tsY >> 6);
            if (tsY == 31)
            {
                tsY = 32;
            }
            else if (tsY == 62)
            {
                tsY = 64;
            }

            return new Size(tsX, tsY);
        }

        public static Vector2 GetTextureScaling(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            ushort tsX = cmd.ReadUInt16();
            ushort tsY = cmd.ReadUInt16();
            cmd.Position = 0;
            var vec = new Vector2();
            if (tsX != 0xFFFF)
            {
                vec.X = tsX / 65536.0F;
            }
            else
            {
                vec.X = 1.0F;
            }

            if (tsY != 0xFFFF)
            {
                vec.Y = tsY / 65536.0F;
            }
            else
            {
                vec.Y = 1.0F;
            }

            return vec;
        }
    }

    public class F3D_SETIMG
    {
        public static int GetSegmentedAddress(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            int value = cmd.ReadInt32();
            cmd.Position = 0;
            return value;
        }

        public static void SetSegmentedAddress(DisplayListCommand cmd, int value)
        {
            cmd.Position = 4;
            cmd.Write(value);
            cmd.Position = 0;
        }

        public static ColorFormat GetColorFormat(DisplayListCommand cmd)
        {
            cmd.Position = 1;
            byte val = cmd.ReadByte();
            cmd.Position = 0;
            return (ColorFormat)(val >> 5);
        }

        public static BitSize GetBitSize(DisplayListCommand cmd)
        {
            cmd.Position = 1;
            byte val = cmd.ReadByte();
            cmd.Position = 0;
            return (BitSize)(val >> 3 & 0x3);
        }

        public enum ColorFormat : byte
        {
            /// <summary>
            /// Color and alpha
            /// </summary>
            RGBA = 0,
            /// <summary>
            /// Luminance and Chrominance
            /// </summary>
            YUV = 1,
            /// <summary>
            /// Index and look-up palette
            /// </summary>
            CI = 2,
            /// <summary>
            /// Grayscale and alpha
            /// </summary>
            IA = 3,
            /// <summary>
            /// Grayscale
            /// </summary>
            I = 4
        }

        public enum BitSize : byte
        {
            _4 = 0,
            _8 = 1,
            _16 = 2,
            _32 = 3
        }
    }

    public class F3D_SETTILESIZE
    {
        public static Size GetSize(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            int var = cmd.ReadInt32();
            cmd.Position = 0;
            short w = Conversions.ToShort(var >> 12 & 0xFFF);
            short h = Conversions.ToShort(var & 0xFFF);
            w = Conversions.ToShort((w >> 2) + 1);
            h = Conversions.ToShort((h >> 2) + 1);
            return new Size(w, h);
        }

        public static void SetSize(DisplayListCommand cmd, Size size)
        {
            int w = size.Width;
            int h = size.Height;
            w = w - 1 << 2;
            h = h - 1 << 2;
            int var = w << 12 | h;
            cmd.Position = 4;
            cmd.Write(var);
            cmd.Position = 0;
        }
    }

    public class F3D_MOVEMEM
    {
        public static int GetSegmentedOffset(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            int value = cmd.ReadInt32();
            cmd.Position = 0;
            return value;
        }

        public static void SetSegmentedOffset(DisplayListCommand cmd, int value)
        {
            cmd.Position = 4;
            cmd.Write(value);
            cmd.Position = 0;
        }

        public static byte GetLightValueMode(DisplayListCommand cmd)
        {
            cmd.Position = 1;
            byte value = cmd.ReadByte();
            cmd.Position = 0;
            return value;
        }
    }

    public class F3D_CLEARGEOMETRYMODE
    {
        public static uint GetGeometryMode(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            uint flag = cmd.ReadUInt32();
            cmd.Position = 0;
            return flag;
        }
    }

    public class F3D_SETRGEOMETRYMODE : F3D_CLEARGEOMETRYMODE
    {
    }

    public class F3D_SETOTHERMODE_H
    {
        public static uint GetModeBits(DisplayListCommand cmd)
        {
            cmd.Position = 4;
            uint bits = cmd.ReadUInt32();
            cmd.Position = 0;
            return bits;
        }
    }

    public class F3D_SETCOMBINE
    {
        public enum CCMUX : byte
        {
            COMBINED = 0,
            TEXEL0,
            TEXEL1,
            PRIMITIVE,
            SHADE,
            ENVIRONMENT,
            CENTER,
            COMBINED_ALPHA,
            TEXEL0_ALPHA,
            TEXEL1_ALPHA,
            PRIMITIVE_ALPHA,
            SHADE_ALPHA,
            ENV_ALPHA,
            LOD_FRACTION,
            PRIM_LOD_FRAC,
            SCALE = 6,
            NOISE = 7,
            K4 = 7,
            K5 = 15,
            ONE = 6,
            ZERO = 31
        }

        public enum ACMUX : byte
        {
            COMBINED = 0,
            TEXEL0,
            TEXEL1,
            PRIMITIVE,
            SHADE,
            ENVIRONMENT,
            PRIM_LOD_FRAC,
            ONE = 6,
            ZERO = 7,
            LOD_FRACTION = 0
        }

        public class Formula
        {
            public readonly byte a;
            public readonly byte b;
            public readonly byte c;
            public readonly byte d;

            public Formula(byte a, byte b, byte c, byte d) // CC formula is (a - b) * c + d
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
            }

            public static Formula Output(CCMUX a)
            {
                return new Formula((byte)CCMUX.ZERO, (byte)CCMUX.ZERO, (byte)CCMUX.ZERO, (byte)a); // (0 - 0) * 0 + a = a
            }

            public static Formula Output(ACMUX a)
            {
                return new Formula((byte)ACMUX.ZERO, (byte)ACMUX.ZERO, (byte)ACMUX.ZERO, (byte)a);
            }

            public static Formula Multiply(CCMUX a, CCMUX b)
            {
                return new Formula((byte)a, (byte)CCMUX.ZERO, (byte)b, (byte)CCMUX.ZERO); // (a - 0) * b + 0 = a * b
            }

            public static Formula Multiply(byte a, byte b)
            {
                return new Formula(a, (byte)ACMUX.ZERO, b, (byte)ACMUX.ZERO); // (a - 0) * b + 0 = a * b
            }
        }

        private static uint _SHIFTL(uint v, uint s, uint w)
        {
            return Conversions.ToUInteger((v & (1 << Conversions.ToInteger(w)) - 1) << Conversions.ToInteger(s));
        }

        private static uint GCCc0w0(uint saRGB0, uint mRGB0, uint saA0, uint mA0)
        {
            return _SHIFTL(saRGB0, 20, 4) | _SHIFTL(mRGB0, 15, 5) | _SHIFTL(saA0, 12, 3) | _SHIFTL(mA0, 9, 3);
        }

        private static uint GCCc1w0(uint saRGB1, uint mRGB1)
        {
            return _SHIFTL(saRGB1, 5, 4) | _SHIFTL(mRGB1, 0, 5);
        }

        private static uint GCCc0w1(uint sbRGB0, uint aRGB0, uint sbA0, uint aA0)
        {
            return _SHIFTL(sbRGB0, 28, 4) | _SHIFTL(aRGB0, 15, 3) | _SHIFTL(sbA0, 12, 3) | _SHIFTL(aA0, 9, 3);
        }

        private static uint GCCc1w1(uint sbRGB1, uint saA1, uint mA1, uint aRGB1, uint sbA1, uint aA1)
        {
            return _SHIFTL(sbRGB1, 24, 4) | _SHIFTL(saA1, 21, 3) | _SHIFTL(mA1, 18, 3) | _SHIFTL(aRGB1, 6, 3) | _SHIFTL(sbA1, 3, 3) | _SHIFTL(aA1, 0, 3);
        }

        // For Jabo plugin you can't specify anything you want for 2nd cycle, only combined or the same as previous :(
        public static string Make(Formula color, Formula alpha, bool isFog)
        {
            if (!isFog)
            {
                return Make(color, alpha, color, alpha);
            }
            else
            {
                return Make(color, alpha, Formula.Output(CCMUX.COMBINED), Formula.Output(ACMUX.COMBINED));
            }
        }

        // TODO: Let user specify custom combiner with this
        public static string Make(Formula color0, Formula alpha0, Formula color1, Formula alpha1)
        {
            return Make((CCMUX)color0.a, (CCMUX)color0.b, (CCMUX)color0.c, (CCMUX)color0.d, (ACMUX)alpha0.a, (ACMUX)alpha0.b, (ACMUX)alpha0.c, (ACMUX)alpha0.d, (CCMUX)color1.a, (CCMUX)color1.b, (CCMUX)color1.c, (CCMUX)color1.d, (ACMUX)alpha1.a, (ACMUX)alpha1.b, (ACMUX)alpha1.c, (ACMUX)alpha1.d);
        }

        private static string Make(CCMUX a0, CCMUX b0, CCMUX c0, CCMUX d0, ACMUX Aa0, ACMUX Ab0, ACMUX Ac0, ACMUX Ad0, CCMUX a1, CCMUX b1, CCMUX c1, CCMUX d1, ACMUX Aa1, ACMUX Ab1, ACMUX Ac1, ACMUX Ad1)
        {
            uint w0 = _SHIFTL(0xFC, 24, 8) | _SHIFTL(GCCc0w0((uint)a0, (uint)c0, (uint)Aa0, (uint)Ac0) | GCCc1w0((uint)a1, (uint)c1), 0, 24);
            uint w1 = GCCc0w1((uint)b0, (uint)d0, (uint)Ab0, (uint)Ad0) | GCCc1w1((uint)b1, (uint)Aa1, (uint)Ac1, (uint)d1, (uint)Ab1, (uint)Ad1);
            var w0bytes = BitConverter.GetBytes(w0);
            var w1bytes = BitConverter.GetBytes(w1);
            // Little endian assumed
            string ret = w0bytes[3].ToString("X");
            ret += " " + w0bytes[2].ToString("X");
            ret += " " + w0bytes[1].ToString("X");
            ret += " " + w0bytes[0].ToString("X");
            ret += " " + w1bytes[3].ToString("X");
            ret += " " + w1bytes[2].ToString("X");
            ret += " " + w1bytes[1].ToString("X");
            ret += " " + w1bytes[0].ToString("X");
            return ret;
        }
    }
}