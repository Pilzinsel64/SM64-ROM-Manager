using System;
using global::System.Numerics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Data.System;

namespace SM64Lib.Levels.Script
{
    public class ObjBParams
    {
        public byte BParam1 { get; set; } = 0;
        public byte BParam2 { get; set; } = 0;
        public byte BParam3 { get; set; } = 0;
        public byte BParam4 { get; set; } = 0;

        public ObjBParams()
        {
        }

        public ObjBParams(byte BParam1, byte BParam2, byte BParam3, byte BParam4)
        {
            this.BParam1 = BParam1;
            this.BParam2 = BParam2;
            this.BParam3 = BParam3;
            this.BParam4 = BParam4;
        }
    }

    namespace Commands
    {
        public class clJumpToSegAddr // Jump to
        {
            public static int GetSegJumpAddr(LevelscriptCommand Command)
            {
                Command.Position = 4;
                int jumpaddr = Command.ReadInt32();
                Command.Position = 0;
                return jumpaddr;
            }

            public static void SetSegJumpAddr(LevelscriptCommand Command, int SegJumpAddr)
            {
                Command.Position = 4;
                Command.Write(Conversions.ToUInteger(SegJumpAddr));
                Command.Position = 0;
            }
        }

        public class clStartArea // Start Area
        {
            public static byte GetAreaID(LevelscriptCommand Command)
            {
                Command.Position = 2;
                int areaid = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(areaid);
            }

            public static void SetAreaID(LevelscriptCommand Command, byte AreaID)
            {
                Command.Position = 2;
                Command.Write(AreaID);
                Command.Position = 0;
            }

            public static uint GetSegGeolayoutAddr(LevelscriptCommand Command)
            {
                Command.Position = 4;
                uint SegGeolayoutAddr = Command.ReadUInt32();
                Command.Position = 0;
                return SegGeolayoutAddr;
            }

            public static void SetSegGeolayoutAddr(LevelscriptCommand Command, uint SegGeolayoutAddr)
            {
                Command.Position = 4;
                Command.Write(SegGeolayoutAddr);
                Command.Position = 0;
            }
        }

        public class clNormal3DObject // Object
        {
            public static byte GetActs(LevelscriptCommand Command)
            {
                Command.Position = 2;
                int Acts = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(Acts);
            }

            public static void SetActs(LevelscriptCommand Command, byte Acts)
            {
                Command.Position = 2;
                Command.Write(Acts);
                Command.Position = 0;
            }

            public static byte GetModelID(LevelscriptCommand Command)
            {
                Command.Position = 3;
                int ModelID = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(ModelID);
            }

            public static void SetModelID(LevelscriptCommand Command, byte ModelID)
            {
                Command.Position = 3;
                Command.Write(ModelID);
                Command.Position = 0;
            }

            public static Vector3 GetPosition(LevelscriptCommand Command)
            {
                Command.Position = 4;
                var Pos = new Vector3();
                Pos.X = Command.ReadInt16();
                Pos.Y = Command.ReadInt16();
                Pos.Z = Command.ReadInt16();
                Command.Position = 0;
                return Pos;
            }

            public static void SetPosition(LevelscriptCommand Command, Vector3 Pos)
            {
                Command.Position = 4;
                Command.Write(Conversions.ToShort(Pos.X));
                Command.Write(Conversions.ToShort(Pos.Y));
                Command.Write(Conversions.ToShort(Pos.Z));
                Command.Position = 0;
            }

            public static Vector3 GetRotation(LevelscriptCommand Command)
            {
                Command.Position = 10;
                var Rot = new Vector3();
                Rot.X = Command.ReadInt16();
                Rot.Y = Command.ReadInt16();
                Rot.Z = Command.ReadInt16();
                Command.Position = 0;
                return Rot;
            }

            public static void SetRotation(LevelscriptCommand Command, Vector3 Rot)
            {
                Command.Position = 10;
                Command.Write(Conversions.ToShort(Rot.X));
                Command.Write(Conversions.ToShort(Rot.Y));
                Command.Write(Conversions.ToShort(Rot.Z));
                Command.Position = 0;
            }

            public static ObjBParams GetParams(LevelscriptCommand Command)
            {
                Command.Position = 16;
                var Params = new ObjBParams();
                Params.BParam1 = Command.ReadByte();
                Params.BParam2 = Command.ReadByte();
                Params.BParam3 = Command.ReadByte();
                Params.BParam4 = Command.ReadByte();
                Command.Position = 0;
                return Params;
            }

            public static void SetParams(LevelscriptCommand Command, ObjBParams Params)
            {
                Command.Position = 16;
                Command.Write(Params.BParam1);
                Command.Write(Params.BParam2);
                Command.Write(Params.BParam3);
                Command.Write(Params.BParam4);
                Command.Position = 0;
            }

            public static uint GetSegBehaviorAddr(LevelscriptCommand Command)
            {
                Command.Position = 20;
                uint SegBehaviorAddr = Command.ReadUInt32();
                Command.Position = 0;
                return SegBehaviorAddr;
            }

            public static void SetSegBehaviorAddr(LevelscriptCommand Command, uint SegBehaviorAddr)
            {
                Command.Position = 20;
                Command.Write(SegBehaviorAddr);
                Command.Position = 0;
            }

            public static void UpdateScrollingTexturePointer(LevelscriptCommand Command, uint Difference)
            {
                Interaction.MsgBox("UpdateScrollingTexturePointer() is not done!");
            }

            public static string GetListBoxText(LevelscriptCommand Command)
            {
                return "GetListBoxText() is not done!";
            }
        }

        public class clWarp // Warp
        {
            public static byte GetWarpID(LevelscriptCommand Command)
            {
                Command.Position = 2;
                byte ID = Command.ReadByte();
                Command.Position = 0;
                return ID;
            }

            public static void SetWarpID(LevelscriptCommand Command, byte ID)
            {
                Command.Position = 2;
                Command.Write(ID);
                Command.Position = 0;
            }

            public static Levels GetDestinationLevelID(LevelscriptCommand Command)
            {
                Command.Position = 3;
                Levels LevelID = (Levels)Command.ReadByte();
                Command.Position = 0;
                return LevelID;
            }

            public static void SetDestinationLevelID(LevelscriptCommand Command, Levels LevelID)
            {
                Command.Position = 3;
                Command.WriteByte((byte)LevelID);
                Command.Position = 0;
            }

            public static byte GetDestinationAreaID(LevelscriptCommand Command)
            {
                Command.Position = 4;
                byte ID = Command.ReadByte();
                Command.Position = 0;
                return ID;
            }

            public static void SetDestinationAreaID(LevelscriptCommand Command, byte ID)
            {
                Command.Position = 4;
                Command.Write(ID);
                Command.Position = 0;
            }

            public static byte GetDestinationWarpID(LevelscriptCommand Command)
            {
                Command.Position = 5;
                byte ID = Command.ReadByte();
                Command.Position = 0;
                return ID;
            }

            public static void SetDestinationWarpID(LevelscriptCommand Command, byte ID)
            {
                Command.Position = 5;
                Command.Write(ID);
                Command.Position = 0;
            }

            public static bool GetCreateCheckpoint(LevelscriptCommand cmd)
            {
                cmd.Position = 6;
                return Bits.GetBoolOfByte(cmd.ReadByte(), 0);
            }

            public static void SetCreateCheckpoint(LevelscriptCommand cmd, bool value)
            {
                cmd.Position = 6;
                byte b = cmd.ReadByte();
                b = Bits.SetInByte(b, 0, value);
                cmd.Position -= 1;
                cmd.Write(b);
            }
        }

        public class clInstantWarp
        {
            public static byte GetCollisionType(LevelscriptCommand cmd)
            {
                cmd.Position = 2;
                byte value = cmd.ReadByte();
                cmd.Position = 0;
                return value;
            }

            public static void SetCollisionType(LevelscriptCommand cmd, byte collisionType)
            {
                cmd.Position = 2;
                cmd.WriteByte(collisionType);
                cmd.Position = 0;
            }

            public static byte GetAreaID(LevelscriptCommand cmd)
            {
                cmd.Position = 3;
                byte value = cmd.ReadByte();
                cmd.Position = 0;
                return value;
            }

            public static void SetAreaID(LevelscriptCommand cmd, byte areaID)
            {
                cmd.Position = 3;
                cmd.WriteByte(areaID);
                cmd.Position = 0;
            }

            public static Vector3 GetLocation(LevelscriptCommand cmd)
            {
                cmd.Position = 4;
                short x = cmd.ReadInt16();
                short y = cmd.ReadInt16();
                short z = cmd.ReadInt16();
                cmd.Position = 0;
                return new Vector3(x, y, z);
            }

            public static void SetLocation(LevelscriptCommand cmd, Vector3 loc)
            {
                cmd.Position = 4;
                cmd.Write(Conversions.ToShort(loc.X));
                cmd.Write(Conversions.ToShort(loc.Y));
                cmd.Write(Conversions.ToShort(loc.Z));
                cmd.Position = 0;
            }
        }

        public class clAreaCollision // Area Collision
        {
            public static uint GetAreaCollision(LevelscriptCommand Command)
            {
                Command.Position = 4;
                uint AreaCollision = Command.ReadUInt32();
                Command.Position = 0;
                return AreaCollision;
            }

            public static void SetAreaCollision(LevelscriptCommand Command, uint AreaCollision)
            {
                Command.Position = 4;
                Command.Write(AreaCollision);
                Command.Position = 0;
            }
        }

        public class clTerrian // Terrian-Type
        {
            public static byte GetTerrainType(LevelscriptCommand Command)
            {
                Command.Position = 3;
                int Type = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(Type);
            }

            public static void SetTerrainType(LevelscriptCommand Command, byte Type)
            {
                Command.Position = 3;
                Command.Write(Type);
                Command.Position = 0;
            }
        }

        public class clAreaMusic // Area Music
        {
            public static byte GetMusicID(LevelscriptCommand Command)
            {
                Command.Position = 5;
                int MusicID = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(MusicID);
            }

            public static void SetMusicID(LevelscriptCommand Command, byte MusicID)
            {
                Command.Position = 5;
                Command.Write(MusicID);
                Command.Position = 0;
            }
        }

        public class clAreaMusicSimple // Area Music
        {
            public static byte GetMusicID(LevelscriptCommand Command)
            {
                Command.Position = 3;
                int MusicID = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(MusicID);
            }

            public static void SetMusicID(LevelscriptCommand Command, byte MusicID)
            {
                Command.Position = 3;
                Command.Write(MusicID);
                Command.Position = 0;
            }
        }

        public class clLoadRomToRam // 0x17 Load ROM to RAM
        {
            public static byte GetParam1(LevelscriptCommand Command)
            {
                Command.Position = 2;
                int value = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(value);
            }

            public static void SetParam1(LevelscriptCommand Command, byte value)
            {
                Command.Position = 2;
                Command.Write(value);
                Command.Position = 0;
            }

            public static byte GetSegmentedID(LevelscriptCommand Command)
            {
                Command.Position = 3;
                int value = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(value);
            }

            public static void SetSegmentedID(LevelscriptCommand Command, byte ID)
            {
                Command.Position = 3;
                Command.Write(ID);
                Command.Position = 0;
            }

            public static int GetRomStart(LevelscriptCommand Command)
            {
                Command.Position = 4;
                int value = Command.ReadInt32();
                Command.Position = 0;
                return value;
            }

            public static void SetRomStart(LevelscriptCommand Command, int Address)
            {
                Command.Position = 4;
                Command.Write(Address);
                Command.Position = 0;
            }

            public static int GetRomEnd(LevelscriptCommand Command)
            {
                Command.Position = 8;
                uint value = Command.ReadUInt32();
                Command.Position = 0;
                return Conversions.ToInteger(value);
            }

            public static void SetRomEnd(LevelscriptCommand Command, int Address)
            {
                Command.Position = 8;
                Command.Write(Conversions.ToUInteger(Address));
                Command.Position = 0;
            }

            public static int GetSegmentedAddressToJump(LevelscriptCommand Command)
            {
                Command.Position = 12;
                uint value = Command.ReadUInt32();
                Command.Position = 0;
                return Conversions.ToInteger(value);
            }

            public static void SetSegmentedAddressToJump(LevelscriptCommand Command, int Address)
            {
                Command.Position = 12;
                Command.Write(Conversions.ToUInteger(Address));
                Command.Position = 0;
            }
        }

        public class clDefaultPosition
        {
            public static byte GetAreaID(LevelscriptCommand Command)
            {
                Command.Position = 2;
                byte value = Command.ReadByte();
                Command.Position = 0;
                return value;
            }

            public static void SetAreaID(LevelscriptCommand Command, byte value)
            {
                Command.Position = 2;
                Command.Write(value);
                Command.Position = 0;
            }

            public static Vector3 GetPosition(LevelscriptCommand Command)
            {
                Command.Position = 6;
                var value = new Vector3();
                value.X = Command.ReadInt16();
                value.Y = Command.ReadInt16();
                value.Z = Command.ReadInt16();
                Command.Position = 0;
                return value;
            }

            public static void SetPosition(LevelscriptCommand Command, Vector3 value)
            {
                Command.Position = 6;
                Command.Write(Conversions.ToShort(value.X));
                Command.Write(Conversions.ToShort(value.Y));
                Command.Write(Conversions.ToShort(value.Z));
                Command.Position = 0;
            }

            public static void SetPosition(LevelscriptCommand Command, int X, int Y, int Z)
            {
                SetPosition(Command, new Vector3(X, Y, Z));
            }

            public static short GetRotation(LevelscriptCommand Command)
            {
                Command.Position = 4;
                short value = Command.ReadInt16();
                Command.Position = 0;
                value = Conversions.ToShort(value % 360);
                if (value < 0)
                    value *= -1;
                return value;
            }

            public static void SetRotation(LevelscriptCommand Command, short value)
            {
                Command.Position = 4;
                if (value < 0)
                    value *= -1;
                value = Conversions.ToShort(value % 360);
                Command.Write(value);
                Command.Position = 0;
            }
        }

        public class clLoadPolygonWithoutGeo : clLoadPolygonWithGeo
        {
            public static byte GetDrawingLayer(LevelscriptCommand Command)
            {
                Command.Position = 3;
                int areaid = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(areaid >> 4);
            }

            public static void SetDrawingLayer(LevelscriptCommand Command, byte layer)
            {
                Command.Position = 3;
                Command.Write(layer << 4);
                Command.Position = 0;
            }
        }

        public class clLoadPolygonWithGeo
        {
            public static byte GetModelID(LevelscriptCommand Command)
            {
                Command.Position = 3;
                int areaid = Command.ReadByte();
                Command.Position = 0;
                return Conversions.ToByte(areaid);
            }

            public static void SetModelID(LevelscriptCommand Command, byte ModelID)
            {
                Command.Position = 3;
                Command.Write(ModelID);
                Command.Position = 0;
            }

            public static int GetSegAddress(LevelscriptCommand Command)
            {
                Command.Position = 4;
                int SegGeolayoutAddr = Command.ReadInt32();
                Command.Position = 0;
                return SegGeolayoutAddr;
            }

            public static void SetSegAddress(LevelscriptCommand Command, int SegAddress)
            {
                Command.Position = 4;
                Command.Write(SegAddress);
                Command.Position = 0;
            }
        }

        public class clShowDialog
        {
            public static byte GetDialogID(LevelscriptCommand cmd)
            {
                cmd.Position = 3;
                byte dialogID = cmd.ReadByte();
                cmd.Position = 0;
                return dialogID;
            }

            public static void SetDialogID(LevelscriptCommand cmd, byte dialogID)
            {
                cmd.Position = 3;
                cmd.WriteByte(dialogID);
                cmd.Position = 0;
            }
        }

        public class clScrollingTexture
        {
            public static ushort GetCountOfFaces(LevelscriptCommand cmd)
            {
                cmd.Position = 4;
                ushort val = cmd.ReadUInt16();
                cmd.Position = 0;
                return val;
            }

            public static void SetCountOfFaces(LevelscriptCommand cmd, ushort count)
            {
                cmd.Position = 4;
                cmd.Write(count);
                cmd.Position = 0;
            }

            public static uint GetVertexPointer(LevelscriptCommand cmd)
            {
                cmd.Position = 0x10;
                int value = cmd.ReadInt32();
                return Conversions.ToUInteger(value);
            }

            public static void SetVertexPointer(LevelscriptCommand cmd, uint ptr)
            {
                cmd.Position = 0x10;
                cmd.Write(Conversions.ToInteger(ptr));
                cmd.Position = 0;
            }

            public static byte GetCycleDuration(LevelscriptCommand cmd)
            {
                cmd.Position = 7;
                byte val = cmd.ReadByte();
                cmd.Position = 0;
                return val;
            }

            public static void SetCycleDuration(LevelscriptCommand cmd, byte ptr)
            {
                cmd.Position = 7;
                cmd.WriteByte(ptr);
                cmd.Position = 0;
            }

            public static byte GetScrollBehavior(LevelscriptCommand cmd)
            {
                cmd.Position = 6;
                byte val = Conversions.ToByte(cmd.ReadByte() & 0xE0);
                cmd.Position = 0;
                return val;
            }

            public static void SetScrollBehavior(LevelscriptCommand cmd, byte behav)
            {
                byte val = GetScrollType(cmd);
                val = (byte)(val | behav);
                cmd.Position = 6;
                cmd.WriteByte(val);
                cmd.Position = 0;
            }

            public static byte GetScrollType(LevelscriptCommand cmd)
            {
                cmd.Position = 6;
                byte val = Conversions.ToByte(cmd.ReadByte() & 0x1F);
                cmd.Position = 0;
                return val;
            }

            public static void SetScrollType(LevelscriptCommand cmd, byte behav)
            {
                byte val = GetScrollBehavior(cmd);
                val = (byte)(val | behav);
                cmd.Position = 6;
                cmd.WriteByte(val);
                cmd.Position = 0;
            }

            public static short GetScrollSpeed(LevelscriptCommand cmd)
            {
                cmd.Position = 8;
                short val = cmd.ReadInt16();
                cmd.Position = 0;
                return val;
            }

            public static void SetScrollSpeed(LevelscriptCommand cmd, short count)
            {
                cmd.Position = 8;
                cmd.Write(Conversions.ToShort(Math.Min((int)count, 0xFFF)));
                cmd.Position = 0;
            }

            public static short GetGroupID(LevelscriptCommand Command)
            {
                Command.Position = 14;
                short id = Command.ReadInt16();
                Command.Position = 0;
                return id;
            }

            public static void SetGroupID(LevelscriptCommand Command, short id)
            {
                Command.Position = 14;
                Command.Write(id);
                Command.Position = 0;
            }
        }
    }
}