using global::System.Numerics;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.Geolayout.Script
{
    namespace Commands
    {
        public class cgBackground
        {
            public static short GetBackgroundID(GeolayoutCommand command)
            {
                command.Position = 0x2;
                short value = command.ReadInt16();
                command.Position = 0;
                return value;
            }

            public static void SetBackgroundID(GeolayoutCommand command, short ID)
            {
                command.Position = 0x2;
                command.Write(ID);
                command.Position = 0;
            }

            public static int GetBackgroundPointer(GeolayoutCommand command)
            {
                command.Position = 0x4;
                int value = command.ReadInt32();
                command.Position = 0;
                return value;
            }

            public static void SetBackgroundPointer(GeolayoutCommand command, int Pointer)
            {
                command.Position = 0x4;
                command.Write(Pointer);
                command.Position = 0;
            }

            public static System.Drawing.Color GetRrgbaColor(GeolayoutCommand command)
            {
                command.Position = 0x2;
                byte b1 = command.ReadByte();
                byte b2 = command.ReadByte();
                command.Position = 0;
                return N64Graphics.N64Graphics.RGBA16Color(b1, b2);
            }

            public static void SetRgbaColor(GeolayoutCommand command, System.Drawing.Color color)
            {
                byte b1, b2;
                N64Graphics.N64Graphics.ColorRGBA16(color, out b1, out b2);
                command.Position = 0x2;
                command.WriteByte(b1);
                command.WriteByte(b2);
                command.Position = 0;
            }
        }

        public class cgCameraPreset
        {
            public static byte GetCameraPreset(ref GeolayoutCommand command)
            {
                command.Position = 0x3;
                byte value = command.ReadByte();
                command.Position = 0;
                return value;
            }

            public static void SetCameraPreset(ref GeolayoutCommand command, byte Preset)
            {
                command.Position = 0x3;
                command.Write(Preset);
                command.Position = 0;
            }
        }

        public class cgx18
        {
            public static ushort GetParam1(ref GeolayoutCommand command)
            {
                command.Position = 0x2;
                ushort value = command.ReadUInt16();
                command.Position = 0;
                return value;
            }

            public static void SetParam1(ref GeolayoutCommand command, ushort ID)
            {
                command.Position = 0x2;
                command.Write(ID);
                command.Position = 0;
            }

            public static int GetAsmPointer(ref GeolayoutCommand command)
            {
                command.Position = 0x4;
                int value = command.ReadInt32();
                command.Position = 0;
                return value;
            }

            public static void SetAsmPointer(ref GeolayoutCommand command, int AsmPointer)
            {
                command.Position = 0x4;
                command.Write(AsmPointer);
                command.Position = 0;
            }
        }

        public class cgLoadDisplayList
        {
            public static byte GetDrawingLayer(ref GeolayoutCommand command)
            {
                command.Position = 0x1;
                byte value = command.ReadByte();
                command.Position = 0;
                return value;
            }

            public static void SetDrawingLayer(ref GeolayoutCommand command, byte Layer)
            {
                command.Position = 0x1;
                command.Write(Layer);
                command.Position = 0;
            }

            public static int GetSegGeopointer(ref GeolayoutCommand command)
            {
                command.Position = 0x4;
                int value = command.ReadInt32();
                command.Position = 0;
                return value;
            }

            public static void SetSegGeopointer(ref GeolayoutCommand command, int SegPointer)
            {
                command.Position = 0x4;
                command.Write(SegPointer);
                command.Position = 0;
            }
        }

        public class cgLoadDisplayListWithOffset
        {
            public static byte GetDrawingLayer(ref GeolayoutCommand command)
            {
                command.Position = 0x1;
                byte value = command.ReadByte();
                command.Position = 0;
                return value;
            }

            public static void SetDrawingLayer(ref GeolayoutCommand command, byte Layer)
            {
                command.Position = 0x1;
                command.Write(Layer);
                command.Position = 0;
            }

            public static Vector3 GetOffset(ref GeolayoutCommand command)
            {
                command.Position = 2;
                var value = new Vector3();
                value.X = command.ReadInt16();
                value.Y = command.ReadInt16();
                value.Z = command.ReadInt16();
                command.Position = 0;
                return value;
            }

            public static void SetOffset(ref GeolayoutCommand Command, Vector3 value)
            {
                Command.Position = 2;
                Command.Write(Conversions.ToShort(value.X));
                Command.Write(Conversions.ToShort(value.Y));
                Command.Write(Conversions.ToShort(value.Z));
                Command.Position = 0;
            }

            public static void SetOffset(ref GeolayoutCommand Command, int X, int Y, int Z)
            {
                SetOffset(ref Command, new Vector3(X, Y, Z));
            }

            public static uint GetSegGeopointer(ref GeolayoutCommand command)
            {
                command.Position = 0x8;
                uint value = command.ReadUInt32();
                command.Position = 0;
                return value;
            }

            public static void SetSegGeopointer(ref GeolayoutCommand command, uint SegPointer)
            {
                command.Position = 0x8;
                command.Write(SegPointer);
                command.Position = 0;
            }
        }

        public class cgx10
        {
            public static Vector3 GetOffset(ref GeolayoutCommand command)
            {
                command.Position = 2;
                var value = new Vector3();
                value.X = command.ReadInt16();
                value.Y = command.ReadInt16();
                command.Position += 2;
                value.Z = command.ReadInt16();
                command.Position = 0;
                return value;
            }
        }
    }
}