
using Newtonsoft.Json;

namespace SM64Lib.Model.Collision
{
    public class Vertex
    {
        public short X { get; set; } = 0;
        public short Y { get; set; } = 0;
        public short Z { get; set; } = 0;
        public VertexList ParentList { get; set; } = null;

        public int Index
        {
            get
            {
                return ParentList.IndexOf(this);
            }
        }
    }
}