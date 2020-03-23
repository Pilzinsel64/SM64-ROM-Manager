using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Data.System;

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

        public void WriteTrajectories(Stream rom)
        {
            var bw = new BinaryWriter(rom);
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
                        rom.Position = 0xED864;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.KoopaTheQuick2:
                        rom.Position = 0xED874;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.RacingPenguin:
                        rom.Position = 0xCCA6E;
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr >> 16)));
                        rom.Position = 0xCCA76;
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr & 0xFFFF)));
                        break;
                    case TrajectoryName.SnowmansBottom:
                        rom.Position = 0xABC9E;
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr >> 16)));
                        rom.Position = 0xABCA6;
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr & 0xFFFF)));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_00:
                        rom.Position = 0xED9DC + 0 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_01:
                        rom.Position = 0xED9DC + 1 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_02:
                        rom.Position = 0xED9DC + 2 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_03:
                        rom.Position = 0xED9DC + 3 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_04:
                        rom.Position = 0xED9DC + 4 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_05:
                        rom.Position = 0xED9DC + 5 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_06:
                        rom.Position = 0xED9DC + 6 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.PlatformOnTracksBehavior_BParam2_07:
                        rom.Position = 0xED9DC + 7 * 4;
                        bw.Write(SwapInts.SwapInt32(ramAddr));
                        break;
                    case TrajectoryName.MetalBallsGenerators_BParam2_00:
                        rom.Position = 0xA9AB4;
                        bw.Write(SwapInts.SwapInt32(0x3C048040)); // LUI A0, 0x8040
                        rom.Position = 0xA9ABC;
                        bw.Write(SwapInts.SwapUInt16(0x3484)); // ORI A0, A0, 0x8040xxxx
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr & 0xFFFF)));
                        break;
                    case TrajectoryName.MetalBallsGenerators_BParam2_01:
                        rom.Position = 0xA9AD4;
                        bw.Write(SwapInts.SwapInt32(0x3C048040)); // LUI A0, 0x8040
                        rom.Position = 0xA9ADC;
                        bw.Write(SwapInts.SwapUInt16(0x3484)); // ORI A0, A0, 0x8040xxxx
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr & 0xFFFF)));
                        break;
                    case TrajectoryName.MetalBallsGenerators_BParam2_02:
                        rom.Position = 0xA9AF4;
                        bw.Write(SwapInts.SwapInt32(0x3C048040)); // LUI A0, 0x8040
                        rom.Position = 0xA9AFC;
                        bw.Write(SwapInts.SwapUInt16(0x3484)); // ORI A0, A0, 0x8040xxxx
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr & 0xFFFF)));
                        break;
                    case TrajectoryName.MiniMetalBallGenerator_BParam2_03:
                        rom.Position = 0xA9B1C;
                        bw.Write(SwapInts.SwapInt32(0x3C098040)); // LU3 T3, 0x8040
                        bw.Write(SwapInts.SwapUInt16(0x356B)); // ORI T3, T3, 0x8040xxxx
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr & 0xFFFF)));
                        break;
                    case TrajectoryName.MiniMetalBallGenerator_BParam2_04:
                        rom.Position = 0xA9B38;
                        bw.Write(SwapInts.SwapInt32(0x3C098040)); // LU3 T3, 0x8040
                        bw.Write(SwapInts.SwapUInt16(0x356B)); // ORI T3, T3, 0x8040xxxx
                        bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(ramAddr & 0xFFFF)));
                        break;
                    case TrajectoryName.MipsTheRabbit:
                        continue;
                }

                traj.Write(rom, Conversions.ToUInteger(curPos));
                curPos = Conversions.ToInteger(rom.Position);
            }

            // Mips the Rabbit
            var mipsTrajects = this.Where(n => n.Name == TrajectoryName.MipsTheRabbit).ToArray();
            if (mipsTrajects.Length > 0)
            {
                rom.Position = 0xB3816;
                bw.Write(SwapInts.SwapUInt16(0x8040));
                rom.Position += 6;
                bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(curPos - romstartAddr + ramStartAddr & 0xFFFF)));
                foreach (Trajectory traj in mipsTrajects)
                {
                    traj.Write(rom, Conversions.ToUInteger(curPos));
                    curPos = Conversions.ToInteger(rom.Position);
                }

                rom.Position = 0xB371E;
                bw.Write(SwapInts.SwapUInt16(Conversions.ToUShort(mipsTrajects.Length)));
            }
        }

        private void AddTrajectory(Stream rom, int addr, TrajectoryName name)
        {
            AddTrajectory(rom, addr, name, 1);
        }

        private void AddTrajectory(Stream rom, int addr, TrajectoryName name, ushort count)
        {
            if ((uint)addr > 0x80400000 && (uint)addr < 0x80410000)
            {
                rom.Position = addr - 0x80400000 + 0x1200000;
                for (int i = 1, loopTo = count; i <= loopTo; i++)
                {
                    var trajectory = new Trajectory();
                    trajectory.Name = name;
                    trajectory.Read(rom, Conversions.ToUInteger(rom.Position));
                    Add(trajectory);
                }
            }
        }

        public void ReadTrajectories(Stream rom)
        {
            var br = new BinaryReader(rom);
            int addr;

            // Clear list
            Clear();

            // Koopa-The-Quick #1
            rom.Position = 0xED864;
            addr = SwapInts.SwapInt32(br.ReadInt32());
            AddTrajectory(rom, addr, TrajectoryName.KoopaTheQuick1);

            // Koopa-The-Quick #2
            rom.Position = 0xED874;
            addr = SwapInts.SwapInt32(br.ReadInt32());
            AddTrajectory(rom, addr, TrajectoryName.KoopaTheQuick2);

            // Racing Penguin
            rom.Position = 0xCCA6E;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position = 0xCCA76;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.RacingPenguin);

            // Snowman's Bottom
            rom.Position = 0xABC9E;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position = 0xABCA6;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.SnowmansBottom);

            // Platform on Tracks Behavior (B.Param 2 = 0 - 8)
            for (byte bparam = 0; bparam <= 8; bparam++)
            {
                rom.Position = 0xED9DC + bparam * 4;
                addr = SwapInts.SwapInt32(br.ReadInt32());
                AddTrajectory(rom, addr, (TrajectoryName)((int)TrajectoryName.PlatformOnTracksBehavior_BParam2_00 + bparam));
            }

            // Metal Balls Generators - B.Param 2 = 00
            rom.Position = 0xA9AB4 + 2;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position = 0xA9ABC + 2;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.MetalBallsGenerators_BParam2_00);

            // Metal Balls Generators - B.Param 2 = 01
            rom.Position = 0xA9AD4 + 2;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position = 0xA9ADC + 2;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.MetalBallsGenerators_BParam2_01);

            // Metal Balls Generators - B.Param 2 = 02
            rom.Position = 0xA9AF4 + 2;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position = 0xA9AFC + 2;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.MetalBallsGenerators_BParam2_02);

            // Mini-Metal Ball Generator - B.Param 2 = 03
            rom.Position = 0xA9B1C + 2;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position += 2;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.MiniMetalBallGenerator_BParam2_03);

            // Mini-Metal Ball Generator - B.Param 2 = 04
            rom.Position = 0xA9B1C + 2;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position += 2;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.MiniMetalBallGenerator_BParam2_04);

            // Mips the Rabbit
            rom.Position = 0xB3816;
            addr = Conversions.ToInteger(SwapInts.SwapUInt16(br.ReadUInt16())) << 16;
            rom.Position += 6;
            addr = addr | SwapInts.SwapUInt16(br.ReadUInt16());
            rom.Position = 0xB371E;
            ushort numOfPaths = SwapInts.SwapUInt16(br.ReadUInt16());
            AddTrajectory(rom, addr, TrajectoryName.MipsTheRabbit, numOfPaths);
        }
    }
}