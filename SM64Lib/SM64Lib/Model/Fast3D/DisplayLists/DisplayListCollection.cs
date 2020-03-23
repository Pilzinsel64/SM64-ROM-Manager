using System.Collections.Generic;
using global::Pilz.S3DFileParser;

namespace SM64Lib.Model.Fast3D.DisplayLists
{
    public class DisplayListCollection : List<DisplayList>
    {
        public Object3D ToObject3D(RomManager rommgr, byte? AreaID)
        {
            var obj = new Object3D();
            foreach (DisplayList dl in this)
                dl.ToObject3D(obj, rommgr, AreaID);
            return obj;
        }

        public new void Clear()
        {
            Close();
            base.Clear();
        }

        public void Close()
        {
            foreach (var dl in this)
                dl.Close();
        }
    }
}