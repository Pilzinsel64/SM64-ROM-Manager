using System.Collections.Generic;
using global::System.IO;
using global::System.Numerics;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Data;
using SM64Lib.Data.System;

namespace SM64Lib.Trajectorys
{
    public class Trajectory
    {
        public List<Vector3> Points { get; private set; } = new List<Vector3>();
        public bool NeedToSave { get; set; } = false;
        public TrajectoryName Name { get; set; } = TrajectoryName.None;

        public void Write(BinaryData data, uint startPos)
        {
            // Set position
            data.Position = startPos;

            // Write xyz
            for (short i = 0, loopTo = Conversions.ToShort(Points.Count - 1); i <= loopTo; i++)
            {
                var point = Points[i];
                data.Write(i);
                data.Write(Conversions.ToShort(point.X));
                data.Write(Conversions.ToShort(point.Y));
                data.Write(Conversions.ToShort(point.Z));
            }

            data.Write(0xFFFFFFFF);
            data.Write(0xFFFFFFFF);
        }

        public void Read(BinaryData data, uint startPos)
        {
            bool ende = false;

            // Set position
            data.Position = startPos;

            // Clear list
            Points.Clear();

            // Read xyz
            while (!ende)
            {
                if ((ulong)data.ReadInt64() != 0xFFFFFFFFFFFFFFFF)
                {
                    data.Position -= 6;
                    var point = new Vector3();
                    point.X = data.ReadInt16();
                    point.Y = data.ReadInt16();
                    point.Z = data.ReadInt16();
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