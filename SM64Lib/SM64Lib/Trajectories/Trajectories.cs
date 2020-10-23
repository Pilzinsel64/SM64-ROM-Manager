using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Data.System;
using SM64Lib.Data;

namespace SM64Lib.Trajectorys
{
    public class Trajectories : List<Trajectory>
    {
        public bool NeedToSave
        {
            get
            {
                return this.FirstOrDefault(n => n.NeedToSave) is object;
            }
        }

        public void WriteTrajectories(BinaryData data)
        {
            int curPos = 0x1205000;
            int romstartAddr = 0x1200000;
            int ramStartAddr = unchecked((int)0x80400000);
            foreach (Trajectory traj in this)
            {
                int ramAddr = curPos - romstartAddr + ramStartAddr;
                var switchExpr = traj.Name;
                switch (switchExpr)
                {
                    case TrajectoryName.KoopaTheQuick1:
                        data.Position = 0xED864;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.KoopaTheQuick2:
                        data.Position = 0xED874;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.RacingPenguin:
                        data.Position = 0xCCA6E;
                        data.Write(ramAddr >> 16);
                        data.Position = 0xCCA76;
                        data.Write(Conversions.ToUShort(ramAddr & 0xFFFF));
                        break;
                    case TrajectoryName.SnowmansBottom:
                        data.Position = 0xABC9E;
                        data.Write(Conversions.ToUShort(ramAddr >> 16));
                        data.Position = 0xABCA6;
                        data.Write(Conversions.ToUShort(ramAddr & 0xFFFF));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_00:
                        data.Position = 0xED9DC + 0 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_01:
                        data.Position = 0xED9DC + 1 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_02:
                        data.Position = 0xED9DC + 2 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_03:
                        data.Position = 0xED9DC + 3 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_04:
                        data.Position = 0xED9DC + 4 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_05:
                        data.Position = 0xED9DC + 5 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_06:
                        data.Position = 0xED9DC + 6 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_07:
                        data.Position = 0xED9DC + 7 * 4;
                        data.Write(ramAddr);
                        break;
                    case TrajectoryName.MetalBallsGenerators_BParam2_00:
                        data.Position = 0xA9AB4;
                        data.Write(0x3C048040); // LUI A0, 0x8040
                        data.Position = 0xA9ABC;
                        data.Write((short)0x3484); // ORI A0, A0, 0x8040xxxx
                        data.Write((short)(ramAddr & 0xFFFF));
                        break;
                    case TrajectoryName.MetalBallsGenerators_BParam2_01:
                        data.Position = 0xA9AD4;
                        data.Write(0x3C048040); // LUI A0, 0x8040
                        data.Position = 0xA9ADC;
                        data.Write((short)0x3484); // ORI A0, A0, 0x8040xxxx
                        data.Write((short)(ramAddr & 0xFFFF));
                        break;
                    case TrajectoryName.MetalBallsGenerators_BParam2_02:
                        data.Position = 0xA9AF4;
                        data.Write(0x3C048040); // LUI A0, 0x8040
                        data.Position = 0xA9AFC;
                        data.Write((short)0x3484); // ORI A0, A0, 0x8040xxxx
                        data.Write((short)(ramAddr & 0xFFFF));
                        break;
                    case TrajectoryName.MiniMetalBallGenerator_BParam2_03:
                        data.Position = 0xA9B1C;
                        data.Write(0x3C098040); // LU3 T3, 0x8040
                        data.Write((short)0x356B); // ORI T3, T3, 0x8040xxxx
                        data.Write((short)(ramAddr & 0xFFFF));
                        break;
                    case TrajectoryName.MiniMetalBallGenerator_BParam2_04:
                        data.Position = 0xA9B38;
                        data.Write(0x3C098040); // LU3 T3, 0x8040
                        data.Write((short)0x356B); // ORI T3, T3, 0x8040xxxx
                        data.Write((short)(ramAddr & 0xFFFF));
                        break;
                    case TrajectoryName.MipsTheRabbit:
                        continue;
                }

                traj.Write(data, Conversions.ToUInteger(curPos));
                curPos = Conversions.ToInteger(data.Position);
            }

            // Mips the Rabbit
            var mipsTrajects = this.Where(n => n.Name == TrajectoryName.MipsTheRabbit).ToArray();
            if (mipsTrajects.Length > 0)
            {
                data.Position = 0xB3816;
                data.Write(0x8040);
                data.Position += 6;
                data.Write(Conversions.ToUShort(curPos - romstartAddr + ramStartAddr & 0xFFFF));
                foreach (Trajectory traj in mipsTrajects)
                {
                    traj.Write(data, Conversions.ToUInteger(curPos));
                    curPos = Conversions.ToInteger(data.Position);
                }

                data.Position = 0xB371E;
                data.Write(Conversions.ToUShort(mipsTrajects.Length));
            }
        }

        private void AddTrajectory(BinaryData data, int addr, TrajectoryName name)
        {
            AddTrajectory(data, addr, name, 1);
        }

        private void AddTrajectory(BinaryData data, int addr, TrajectoryName name, ushort count, bool checkAddress = true)
        {
            if (!checkAddress || ((uint)addr > 0x80400000 && (uint)addr < 0x80410000))
            {
                data.Position = (uint)addr - 0x80400000 + 0x1200000;
                for (int i = 1, loopTo = count; i <= loopTo; i++)
                {
                    var trajectory = new Trajectory();
                    trajectory.Name = name;
                    trajectory.Read(data, Conversions.ToUInteger(data.Position));
                    Add(trajectory);
                }
            }
        }

        public void ReadTrajectories(BinaryData data)
        {
            int addr;

            // Clear list
            Clear();

            // Koopa-The-Quick #1
            data.Position = 0xED864;
            addr = data.ReadInt32();
            AddTrajectory(data, addr, TrajectoryName.KoopaTheQuick1);

            // Koopa-The-Quick #2
            data.Position = 0xED874;
            addr = data.ReadInt32();
            AddTrajectory(data, addr, TrajectoryName.KoopaTheQuick2);

            // Racing Penguin
            data.Position = 0xCCA6E;
            addr = data.ReadUInt16() << 16;
            data.Position = 0xCCA76;
            addr = addr | data.ReadUInt16();
            AddTrajectory(data, addr, TrajectoryName.RacingPenguin);

            // Snowman's Bottom
            data.Position = 0xABC9E;
            addr = data.ReadUInt16() << 16;
            data.Position = 0xABCA6;
            addr = addr | data.ReadUInt16();
            AddTrajectory(data, addr, TrajectoryName.SnowmansBottom);

            // Platform on Tracks Behavior (B.Param 2 = 0 - 8)
            for (byte bparam = 0; bparam <= 8; bparam++)
            {
                data.Position = 0xED9DC + bparam * 4;
                addr = data.ReadInt32();
                AddTrajectory(data, addr, (TrajectoryName)((int)TrajectoryName.PlatformOnTracksBehavior_BParam2_00 + bparam));
            }

            // Metal Balls Generators - B.Param 2 = 00
            data.Position = 0xA9AB4 + 2;
            addr = data.ReadUInt16() << 16;
            data.Position = 0xA9ABC + 2;
            var val3 = data.ReadUInt16();
            addr = addr | val3;
            AddTrajectory(data, addr, TrajectoryName.MetalBallsGenerators_BParam2_00);

            // Metal Balls Generators - B.Param 2 = 01
            data.Position = 0xA9AD4 + 2;
            addr = data.ReadUInt16() << 16;
            data.Position = 0xA9ADC + 2;
            addr = addr | data.ReadUInt16();
            AddTrajectory(data, addr, TrajectoryName.MetalBallsGenerators_BParam2_01);

            // Metal Balls Generators - B.Param 2 = 02
            data.Position = 0xA9AF4 + 2;
            addr = data.ReadUInt16() << 16;
            data.Position = 0xA9AFC + 2;
            addr = addr | data.ReadUInt16();
            AddTrajectory(data, addr, TrajectoryName.MetalBallsGenerators_BParam2_02);

            // Mini-Metal Ball Generator - B.Param 2 = 03
            data.Position = 0xA9B1C + 2;
            addr = data.ReadUInt16() << 16;
            data.Position += 2;
            addr = addr | data.ReadUInt16();
            AddTrajectory(data, addr, TrajectoryName.MiniMetalBallGenerator_BParam2_03);

            // Mini-Metal Ball Generator - B.Param 2 = 04
            data.Position = 0xA9B1C + 2;
            addr = data.ReadUInt16() << 16;
            data.Position += 2;
            addr = addr | data.ReadUInt16();
            AddTrajectory(data, addr, TrajectoryName.MiniMetalBallGenerator_BParam2_04);

            // Mips the Rabbit
            data.Position = 0xB3816;
            addr = data.ReadUInt16();
            data.Position += 6;
            addr = addr | data.ReadUInt16();
            data.Position = 0xB371E;
            ushort numOfPaths = data.ReadUInt16();
            AddTrajectory(data, addr, TrajectoryName.MipsTheRabbit, numOfPaths);
        }
    }
}