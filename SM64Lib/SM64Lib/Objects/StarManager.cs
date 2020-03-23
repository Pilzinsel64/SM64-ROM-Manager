using global::System.IO;
using System.Linq;
using global::System.Numerics;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Data;

namespace SM64Lib.Objects
{
    public class StarPosition
    {
        public Vector3 Position { get; set; }
        public StarNames Name { get; set; }

        public StarPosition()
        {
            Position = Vector3.Zero;
        }

        public StarPosition(StarNames name) : this()
        {
            Name = name;
        }

        public StarPosition(StarNames name, Vector3 position)
        {
            Position = position;
            Name = name;
        }

        public void SavePosition(RomManager rommgr)
        {
            var rom = rommgr.GetBinaryRom(FileAccess.ReadWrite);
            if (!new[] { StarNames.KoopaTheQuick1, StarNames.KoopaTheQuick2 }.Contains(Name))
            {
                WriteStarWrapperFunction(rom);
            }

            var switchExpr = Name;
            switch (switchExpr)
            {
                case StarNames.KoopaTheQuick1:
                    {
                        WritePositionAsShort(rom, Position, 0xED868);
                        break;
                    }

                case StarNames.KoopaTheQuick2:
                    {
                        WritePositionAsShort(rom, Position, 0xED878);
                        break;
                    }

                case StarNames.KingBobOmbBoss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F00);
                        rom.Position = 0x62AD4;
                        rom.Write(0x3C048040);   // LUI A0, &H8040
                        rom.Write(0xC1009C0);    // JAL &H80402700
                        rom.Write(0x34844F00);   // ORI A0, A0, &H4F40
                        rom.Write(0x0);
                        rom.Write(0x0);
                        rom.Write(0x0);
                        rom.Write(0x0);
                        rom.Write(0x0);
                        break;
                    }

                case StarNames.WhompBoss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F10);
                        rom.Position = 0x82900;
                        rom.Write(0x3C018040);
                        rom.Write(0xC42C4F10);
                        rom.Write(0xC42E4F14);
                        rom.Write(0x8C264F18);
                        rom.Position = 0x82914;
                        rom.Write(0x0);
                        break;
                    }

                case StarNames.EyerockBoss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F20);
                        rom.Position = 0xC9A1C;  // 0x8030EA1c
                        rom.Write(0x3C048040);   // LUI A0, &H8040
                        rom.Write(0xC1009C0);    // JAL &H80402700
                        rom.Write(0x34844F20);   // ORI A0, A0, &H4F20
                        rom.Write(0x0);          // NOPs
                        rom.Write(0x0);
                        rom.Write(0x0);
                        break;
                    }

                case StarNames.BigBullyBoss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F30);
                        rom.Position = 0xA6970;  // 0x802EB970
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844F30);   // ORI A0, A0, 0x4F30
                        break;
                    }

                case StarNames.ChillBullyBoss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F40);
                        rom.Position = 0xA6950;  // 0x802EB950
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844F40);   // ORI A0, A0, 0x4F40
                        break;
                    }

                case StarNames.GiantPiranhaPlants:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F50);
                        rom.Position = 0xC802C;  // 0x8030D02C
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844F50);   // ORI A0, A0, 0x4F50
                        break;
                    }

                case StarNames.PenguinMother:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F60);
                        rom.Position = 0x605E4;  // 0x802a55e4
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844F60);
                        break;
                    }

                case StarNames.WigglerBoss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F70);
                        rom.Position = 0xBCFE0;  // 80301FE0
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844F70);
                        break;
                    }

                case StarNames.PeachSlideStar:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F80);
                        rom.Position = 0xB7D0;   // 80301FE0
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844F80);
                        break;
                    }

                case StarNames.BigPenguinRace:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204F90);
                        rom.Position = 0x605E4;  // 80301FE0
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844F90);
                        break;
                    }

                case StarNames.TreasureChests:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204FA0);
                        rom.Position = 0xB32B0;
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844FA0);
                        break;
                    }

                case StarNames.BooInHauntedHouse:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204FAC);
                        rom.Position = 0x7FBB0;
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844FAC);
                        break;
                    }

                case StarNames.Klepto:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204FC4);
                        rom.Position = 0xCC47C;
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844FC4);
                        break;
                    }

                case StarNames.MerryGoRoundboss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204FB8);
                        rom.Position = 0x7FC24;
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844FB8);
                        break;
                    }

                case StarNames.MrIboss:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204FD0);
                        rom.Position = 0x61450;
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844FD0);
                        break;
                    }

                case StarNames.RooftopBoo:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204FDC);
                        rom.Position = 0x7FBEC;
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844FDC);
                        break;
                    }

                case StarNames.SecondactBigBully:
                    {
                        WritePositionAsSingle(rom, Position, 0x1204FE4);
                        rom.Position = 0x7FBEC;
                        rom.Write(0x3C048040);   // LUI A0, 0x8040
                        rom.Write(0xC1009C0);    // JAL 0x80402700
                        rom.Write(0x34844FE4);
                        break;
                    }
            }

            rom.Close();
        }

        private void WritePositionAsShort(BinaryRom rom, Vector3 position, int offset)
        {
            rom.Position = offset;
            rom.Write(Conversions.ToShort(position.X));
            rom.Write(Conversions.ToShort(position.Y));
            rom.Write(Conversions.ToShort(position.Z));
        }

        private void WritePositionAsSingle(BinaryRom rom, Vector3 position, int offset)
        {
            rom.Position = offset;
            rom.Write(position.X);
            rom.Write(position.Y);
            rom.Write(position.Z);
        }

        public static void WriteStarWrapperFunction(BinaryRom rom)
        {
            var StarWrapperFunction = new[] { 0x27, 0xBD, 0xFF, 0xE8, 0xAF, 0xBF, 0x0, 0x14, 0xC4, 0x8C, 0x0, 0x0, 0xC4, 0x8E, 0x0, 0x4, 0xC, 0xB, 0xCA, 0xE2, 0x8C, 0x86, 0x0, 0x8, 0x8F, 0xBF, 0x0, 0x14, 0x27, 0xBD, 0x0, 0x18, 0x3, 0xE0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0 };
            rom.Position = 0x1202700;
            foreach (byte b in StarWrapperFunction)
                rom.Write(b);
        }
    }
}