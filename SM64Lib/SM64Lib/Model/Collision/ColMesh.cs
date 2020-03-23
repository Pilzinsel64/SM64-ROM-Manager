using System.Collections.Generic;

namespace SM64Lib.Model.Collision
{
    public class ColMesh
    {
        public VertexList Vertices { get; set; } = new VertexList();
        public TriangleList Triangles { get; set; } = new TriangleList();

        public ColMesh[] SplitMesh()
        {
            return SplitMesh(this);
        }

        public static ColMesh[] SplitMesh(ColMesh mesh)
        {
            var meshes = new List<ColMesh>();
            if (mesh.Vertices.Count > short.MaxValue || mesh.Triangles.Count > short.MaxValue)
            {
                var curMesh = new ColMesh();
                var curVertCopies = new Dictionary<Vertex, Vertex>();
                foreach (Triangle t in mesh.Triangles)
                {
                    var newTri = new Triangle();
                    newTri.CollisionType = t.CollisionType;
                    for (int i = 0, loopTo = t.ColParams.Length - 1; i <= loopTo; i++)
                        newTri.ColParams[i] = t.ColParams[i];
                    for (int i = 0, loopTo1 = t.Vertices.Length - 1; i <= loopTo1; i++)
                    {
                        var v = t.Vertices[i];
                        if (curVertCopies.ContainsKey(v))
                        {
                            newTri.Vertices[i] = curVertCopies[v];
                        }
                        else
                        {
                            var newVert = new Vertex();
                            newVert.X = v.X;
                            newVert.Y = v.Y;
                            newVert.Z = v.Z;
                            curMesh.Vertices.Add(newVert);
                            curVertCopies.Add(v, newVert);
                            newTri.Vertices[i] = newVert;
                        }
                    }

                    if (curMesh.Vertices.Count > short.MaxValue - 3 || curMesh.Triangles.Count >= short.MaxValue)
                    {
                        meshes.Add(curMesh);
                        curMesh = new ColMesh();
                        curVertCopies.Clear();
                    }
                }

                if (!meshes.Contains(curMesh) && curMesh.Triangles.Count > 0 && curMesh.Vertices.Count > 0)
                {
                    meshes.Add(curMesh);
                }
            }
            else
            {
                meshes.Add(mesh);
            }

            return meshes.ToArray();
        }
    }
}