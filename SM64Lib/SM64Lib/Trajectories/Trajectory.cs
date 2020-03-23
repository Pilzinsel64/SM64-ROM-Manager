using System.Collections.Generic;
using global::System.IO;
using global::System.Numerics;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Data.System;

namespace SM64Lib.Trajectorys
{
    public class Trajectory
    {
        public List<Vector3> Points { get; private set; } = new List<Vector3>();
        public bool NeedToSave { get; set; } = false;
        public TrajectoryName Name { get; set; } = TrajectoryName.None;

        public void Write(Stream rom, uint startPos)
        {
            var bw = new BinaryWriter(rom);

            // Set position
            rom.Position = startPos;

            // Write xyz
            for (short i = 0, loopTo = Conversions.ToShort(Points.Count - 1); i <= loopTo; i++)
            {
                var point = Points[i];
                bw.Write(SwapInts.SwapInt16(i));
                bw.Write(SwapInts.SwapInt16(Conversions.ToShort(point.X)));
                bw.Write(SwapInts.SwapInt16(Conversions.ToShort(point.Y)));
                bw.Write(SwapInts.SwapInt16(Conversions.ToShort(point.Z)));
            }

            bw.Write(SwapInts.SwapUInt32(0xFFFFFFFF));
            bw.Write(SwapInts.SwapUInt32(0xFFFFFFFF));
        }

        public void Read(Stream rom, uint startPos)
        {
            var br = new BinaryReader(rom);
            bool ende = false;

            // Set position
            rom.Position = startPos;

            // Clear list
            Points.Clear();

            // Read xyz
            while (!ende)
            {
                if ((ulong)SwapInts.SwapInt64(br.ReadInt64()) != 0xFFFFFFFFFFFFFFFF)
                {
                    rom.Position -= 6;
                    var point = new Vector3();
                    point.X = SwapInts.SwapInt16(br.ReadInt16());
                    point.Y = SwapInts.SwapInt16(br.ReadInt16());
                    point.Z = SwapInts.SwapInt16(br.ReadInt16());
                    Points.Add(point);
                }
                else
                {
                    ende = true;
                }
            }
        }
    }
}