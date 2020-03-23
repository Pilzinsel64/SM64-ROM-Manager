using System;
using System.Collections.Generic;
using System.Data;
using global::System.IO;
using System.Linq;
using global::System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.Extensions;
using global::SM64Lib.Data;

namespace SM64Lib.Model.Collision
{
    public class CollisionMap : IToObject3D
    {
        private int _Length = 0;

        public ColMesh Mesh { get; set; } = new ColMesh();
        public List<BoxData> SpecialBoxes { get; set; } = new List<BoxData>();

        private readonly byte[] ColtypesWithParams = new byte[] { 14, 44, 36, 37, 39, 45 };

        public void FromRom(string FileName, int RomOffset)
        {
            var fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            FromStream(fs, RomOffset);
            fs.Close();
        }

        public Task FromRomAsync(string FileName, int RomOffset)
        {
            var t = new Task(() => FromRom(FileName, RomOffset));
            t.Start();
            return t;
        }

        public void FromStream(Stream s, int RomOffset)
        {
            FromBinaryData(new BinaryStreamData(s), RomOffset);
        }

        public void FromBinaryData(BinaryData s, int dataOffset)
        {
            bool endlessOn = true;
            Mesh = new ColMesh();
            SpecialBoxes.Clear();
            s.Position = dataOffset;

            do
            {
                short curVal = s.ReadInt16();
                switch (curVal)
                {
                    case 0x40: // S T A R T   O F   V E R T I C E S
                               // Lese Eckpunkte / Read Vertices
                        for (int i = 1, loopTo = s.ReadUInt16(); i <= loopTo; i++)
                        {
                            var nVert = new Vertex()
                            {
                                X = s.ReadInt16(),
                                Y = s.ReadInt16(),
                                Z = s.ReadInt16()
                            };
                            Mesh.Vertices.Add(nVert);
                        }

                        // Lese und erstelle Polygone / Read and build polygones
                        if (Mesh.Vertices.Count > 0)
                        {
                            bool ende = false;
                            while (!ende)
                            {
                                short Coltype = s.ReadInt16();
                                if (!Coltype.IsInRange(0x40, 0x44))
                                {
                                    for (int i = 1, loopTo1 = s.ReadUInt16(); i <= loopTo1; i++)
                                    {
                                        var pol = new Triangle() { CollisionType = Conversions.ToByte(Coltype) };
                                        for (int iv = 0, loopTo2 = pol.Vertices.Count() - 1; iv <= loopTo2; iv++)
                                            pol.Vertices[iv] = Mesh.Vertices[s.ReadInt16()];
                                        if (ColtypesWithParams.Contains(Conversions.ToByte(Coltype)))
                                        {
                                            for (int ip = 0, loopTo3 = pol.ColParams.Count() - 1; ip <= loopTo3; ip++)
                                                pol.ColParams[ip] = s.ReadByte();
                                        }

                                        Mesh.Triangles.Add(pol);
                                    }
                                }
                                else
                                {
                                    ende = true;
                                }
                            }
                        }

                        break;
                    case 0x41: // E N D   O F   0 x 4 0   C O M M A N D
                        break;
                    case 0x42: // E N D   O F   C O L L I S I O N   D A T A          
                        endlessOn = false;
                        break;
                    case 0x43: // S P E C I A L   O B J E C T                               
                        break;
                    case 0x44: // W A T E R   B O X E S
                        SpecialBoxes.AddRange(ReadBoxData(s, BoxDataType.Water));
                        break;
                    case 0x33: // M I S T
                        SpecialBoxes.AddRange(ReadBoxData(s, BoxDataType.Mist));
                        break;
                    case 0x32: // T O X I C   H A Z E
                        SpecialBoxes.AddRange(ReadBoxData(s, BoxDataType.ToxicHaze));
                        break;
                }
            }
            while (endlessOn);
            _Length = (int)(s.Position - dataOffset);
        }

        public Task FromStreamAsync(Stream s, int RomOffset)
        {
            var t = new Task(() => FromStream(s, RomOffset));
            t.Start();
            return t;
        }

        private static BoxData[] ReadBoxData(BinaryData s, BoxDataType type)
        {
            var spBoxes = new List<BoxData>();
            for (int i = 1, loopTo = s.ReadInt16(); i <= loopTo; i++)
            {
                var wb = new BoxData();
                short index = s.ReadInt16();
                wb.Type = type;
                wb.X1 = s.ReadInt16();
                wb.Z1 = s.ReadInt16();
                wb.X2 = s.ReadInt16();
                wb.Z2 = s.ReadInt16();
                wb.Y = s.ReadInt16();
                spBoxes.Add(wb);
            }

            return spBoxes.ToArray();
        }

        public void FromObject3D(ObjectInputSettings ObjSettings, Object3D model, CollisionSettings colSettings = null)
        {
            var dicMatNames = new Dictionary<Material, string>();

            // Clear Lists
            Mesh.Vertices.Clear();
            Mesh.Triangles.Clear();

            // Create MatNames
            foreach (KeyValuePair<string, Material> kvp in model.Materials)
                dicMatNames.Add(kvp.Value, kvp.Key);

            // Add Faces
            var dicVertices = new Dictionary<Pilz.S3DFileParser.Vertex, Vertex>();
            foreach (Mesh m in model.Meshes)
            {
                foreach (Face f in m.Faces.OrderBy(n => n.Material))
                {
                    var cs = colSettings.GetEntry(dicMatNames[f.Material]);
                    if (!cs.IsNonSolid)
                    {
                        var t = new Triangle();
                        t.CollisionType = cs.CollisionType;
                        t.ColParams[0] = cs.CollisionParam1;
                        t.ColParams[0] = cs.CollisionParam2;
                        for (int i = 0, loopTo = Math.Min(f.Points.Count - 1, 2); i <= loopTo; i++)
                        {
                            Vertex v;
                            var curVert = f.Points[i].Vertex;
                            if (dicVertices.ContainsKey(curVert))
                            {
                                v = dicVertices[curVert];
                            }
                            else
                            {
                                v = new Vertex();
                                v.X = General.KeepInInt16Range(General.Round(curVert.X * ObjSettings.Scaling));
                                v.Y = General.KeepInInt16Range(General.Round(curVert.Y * ObjSettings.Scaling));
                                v.Z = General.KeepInInt16Range(General.Round(curVert.Z * ObjSettings.Scaling));
                                Mesh.Vertices.Add(v);
                                dicVertices.Add(curVert, v);
                            }

                            t.Vertices[i] = v;
                        }

                        Mesh.Triangles.Add(t);
                    }
                }
            }
        }

        public Task FromObject3DAsync(ObjectInputSettings ObjSettings, Object3D model, CollisionSettings colSettings = null)
        {
            var t = new Task(() => FromObject3D(ObjSettings, model, colSettings));
            t.Start();
            return t;
        }

        public void ToStream(Stream s, int RomOffset)
        {
            ToBinaryData(new BinaryStreamData(s), RomOffset);
        }

        public void ToBinaryData(BinaryData data, int dataOffset)
        {
            data.Position = dataOffset;
            foreach (ColMesh mesh in Mesh.SplitMesh())
            {

                // V E R T I C E S

                if (mesh.Vertices.Count > 0)
                {
                    // Start vertices
                    data.Write(Conversions.ToShort(0x40));
                    data.Write(Conversions.ToShort(mesh.Vertices.Count));

                    // Write vertices data
                    foreach (var vert in mesh.Vertices)
                    {
                        data.Write(vert.X);
                        data.Write(vert.Y);
                        data.Write(vert.Z);
                    }
                }

                // P O L Y G O N E S

                foreach (byte curType in UsedPolytypes(mesh))
                {
                    // Search for all triangles with current collision type
                    var tries = mesh.Triangles.Where(n => n.CollisionType == curType).ToArray();
                    if (tries.Length > 0)
                    {
                        // Write new collision type
                        data.Write(Conversions.ToShort(curType));

                        // Write count of triangles
                        data.Write(Conversions.ToShort(tries.Length));

                        // Check if collisiontype has params
                        bool hasParams = ColtypesWithParams.Contains(curType);
                        foreach (Triangle tri in tries)
                        {
                            // Write Vertex Indicies
                            foreach (Vertex vert in tri.Vertices)
                                data.Write(Conversions.ToShort(vert.Index));

                            // Write Collision Params, if avaiable
                            if (hasParams)
                            {
                                for (int ip = 0, loopTo = tri.ColParams.Count() - 1; ip <= loopTo; ip++)
                                    data.Write(tri.ColParams[ip]);
                            }
                        }
                    }
                }

                // E N D   0 x 4 0   C O M M A N D

                data.Write(Conversions.ToShort(0x41));
            }

            // S P E C I A L   O B J E C T S

            // Dont know what this is.

            // S P E C I A L   B O X E S

            if (SpecialBoxes.Count > 0)
            {
                WriteBoxData(data, SpecialBoxes.OrderBy(n => n.Type));
            }

            // E N D   C O L L I S I O N   D A T A

            data.Write(Conversions.ToShort(0x42));
        }

        private static void WriteBoxData(BinaryData data, IEnumerable<BoxData> bodex)
        {
            if (bodex.Any())
            {
                data.Write(Conversions.ToShort(0x44));
                data.Write(Conversions.ToShort(bodex.Count()));
                foreach (BoxDataType t in Enum.GetValues(typeof(BoxDataType)))
                {
                    foreach (var wb in bodex.Where(n => n.Type == t))
                    {
                        data.Write(wb.Index);
                        data.Write(wb.X1);
                        data.Write(wb.Z1);
                        data.Write(wb.X2);
                        data.Write(wb.Z2);
                        data.Write(wb.Y);
                    }
                }
            }
        }

        public long Length
        {
            get
            {
                long LengthRet = default;
                LengthRet = _Length;
                General.HexRoundUp2(ref LengthRet);
                return LengthRet;
            }

            set
            {
                _Length = Conversions.ToInteger(value);
            }
        }

        public static byte[] UsedPolytypes(ColMesh mesh)
        {
            var types = new List<byte>();
            foreach (Triangle tri in mesh.Triangles)
            {
                if (!types.Contains(tri.CollisionType))
                {
                    types.Add(tri.CollisionType);
                }
            }

            return types.ToArray();
        }

        private float[] DropToGroud_GetFoundList(Vector3 pos)
        {
            var found = new List<float>();
            foreach (Triangle tri in Mesh.Triangles)
            {
                var a = new Vector3(tri.Vertices[0].X, tri.Vertices[0].Y, tri.Vertices[0].Z);
                var b = new Vector3(tri.Vertices[1].X, tri.Vertices[1].Y, tri.Vertices[1].Z);
                var c = new Vector3(tri.Vertices[2].X, tri.Vertices[2].Y, tri.Vertices[2].Z);
                if (PointInTriangle(new Vector2(pos.X, pos.Z), a, b, c))
                {
                    found.Add(barryCentric(a, b, c, pos));
                }
            }

            return found.ToArray();
        }

        public float DropToButtom(Vector3 pos)
        {
            var found = DropToGroud_GetFoundList(pos);
            if (found.Any())
            {
                return found.Min();
            }
            else
            {
                return pos.Y;
            }
        }

        public float DropToTop(Vector3 pos)
        {
            var found = DropToGroud_GetFoundList(pos);
            if (found.Any())
            {
                return found.Max();
            }
            else
            {
                return pos.Y;
            }
        }

        public float DropToNearesGround(Vector3 pos)
        {
            var found = DropToGroud_GetFoundList(pos);
            if (found.Count() == 0)
                return pos.Y;
            int closest_index = 0;
            float closest_abs = 9999999.0F;
            for (int i = 0, loopTo = found.Count() - 1; i <= loopTo; i++)
            {
                float abs = Math.Abs(pos.Y - found[i]);
                if (abs < closest_abs)
                {
                    closest_abs = abs;
                    closest_index = i;
                }
            }

            return found[closest_index];
        }

        private static bool PointInTriangle(Vector2 p, Vector3 p0, Vector3 p1, Vector3 p2)
        {
            float s = p0.Z * p2.X - p0.X * p2.Z + (p2.Z - p0.Z) * p.X + (p0.X - p2.X) * p.Y;
            float t = p0.X * p1.Z - p0.Z * p1.X + (p0.Z - p1.Z) * p.X + (p1.X - p0.X) * p.Y;
            if (s < 0 != t < 0)
                return false;
            float A = -p1.Z * p2.X + p0.Z * (p2.X - p1.X) + p0.X * (p1.Z - p2.Z) + p1.X * p2.Z;
            if (A < 0.0)
            {
                s = -s;
                t = -t;
                A = -A;
            }

            return s > 0 && t > 0 && s + t <= A;
        }

        private static float barryCentric(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 pos)
        {
            float det = (p2.Z - p3.Z) * (p1.X - p3.X) + (p3.X - p2.X) * (p1.Z - p3.Z);
            float l1 = ((p2.Z - p3.Z) * (pos.X - p3.X) + (p3.X - p2.X) * (pos.Z - p3.Z)) / det;
            float l2 = ((p3.Z - p1.Z) * (pos.X - p3.X) + (p1.X - p3.X) * (pos.Z - p3.Z)) / det;
            float l3 = 1.0F - l1 - l2;
            return l1 * p1.Y + l2 * p2.Y + l3 * p3.Y;
        }

        public Object3D ToObject3D()
        {
            var obj = new Object3D();
            var m = new Mesh();

            // Vertices
            foreach (var vert in Mesh.Vertices)
                m.Vertices.Add(new Pilz.S3DFileParser.Vertex()
                {
                    X = vert.X,
                    Y = vert.Y,
                    Z = vert.Z
                });

            // Triangles
            foreach (var tri in Mesh.Triangles)
            {
                var newTri = new Face();
                for (int i = 0; i <= 2; i++)
                {
                    var p = new Point() { Vertex = m.Vertices[tri.Vertices[i].Index] };
                    newTri.Points.Add(p);
                }

                newTri.Tag = tri.CollisionType;
                m.Faces.Add(newTri);
            }

            obj.Meshes.Add(m);
            return obj;
        }

        public Task<Object3D> ToObject3DAsync()
        {
            var t = new Task<Object3D>(ToObject3D);
            t.Start();
            return t;
        }
    }
}