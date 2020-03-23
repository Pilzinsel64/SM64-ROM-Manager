using System.Collections.Generic;

namespace SM64Lib.Model.Collision
{
    public class VertexList : List<Vertex>
    {
        public new void Add(Vertex item)
        {
            base.Add(item);
            item.ParentList = this;
        }

        public new void Insert(int index, Vertex item)
        {
            base.Insert(index, item);
            item.ParentList = this;
        }

        public new void AddRange(IEnumerable<Vertex> collection)
        {
            foreach (Vertex v in collection)
                v.ParentList = this;
            base.AddRange(collection);
        }
    }
}