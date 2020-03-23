using System.Collections.Generic;

namespace SM64Lib.Model.Collision
{
    public class TriangleList : List<Triangle>
    {
        public new void Add(Triangle item)
        {
            base.Add(item);
            item.ParentList = this;
        }

        public new void Insert(int index, Triangle item)
        {
            base.Insert(index, item);
            item.ParentList = this;
        }

        public new void AddRange(IEnumerable<Triangle> collection)
        {
            foreach (Triangle v in collection)
                v.ParentList = this;
            base.AddRange(collection);
        }
    }
}