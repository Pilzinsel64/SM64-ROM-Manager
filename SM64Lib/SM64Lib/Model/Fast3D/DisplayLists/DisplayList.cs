using System;
using System.Threading.Tasks;
using global::Pilz.S3DFileParser;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Model.Fast3D.DisplayLists.Script;

namespace SM64Lib.Model.Fast3D.DisplayLists
{
    public class DisplayList
    {
        public DisplayListScript Script { get; private set; } = new DisplayListScript();
        public Geopointer GeoPointer { get; set; } = null;
        // Public Property Data As Stream = Nothing

        public DisplayList()
        {
        }

        public DisplayList(Geopointer gp)
        {
            GeoPointer = gp;
        }

        public void TryFromStream(Geopointer gp, RomManager rommgr, byte? AreaID)
        {
            try
            {
                FromStream(gp, rommgr, AreaID);
            }
            catch (Exception)
            {
            }
        }

        public Task TryFromStreamAsync(Geopointer gp, RomManager rommgr, byte? AreaID)
        {
            var t = new Task(() => TryFromStream(gp, rommgr, AreaID));
            t.Start();
            return t;
        }

        public void FromStream(Geopointer gp, RomManager rommgr, byte? AreaID)
        {
            GeoPointer = gp;
            Script.FromStream(rommgr, gp.SegPointer, AreaID);
        }

        public Task FromStreamAsync(Geopointer gp, RomManager rommgr, byte? AreaID)
        {
            var t = new Task(() => FromStream(gp, rommgr, AreaID));
            t.Start();
            return t;
        }

        public void TryToObject3D(Object3D obj, RomManager rommgr, byte? AreaID)
        {
            try
            {
                ToObject3D(obj, rommgr, AreaID);
            }
            catch (Exception)
            {
            }
        }

        public Task TryToObject3DAsync(Object3D obj, RomManager rommgr, byte? AreaID)
        {
            var t = new Task(() => TryToObject3D(obj, rommgr, AreaID));
            t.Start();
            return t;
        }

        public void ToObject3D(Object3D obj, RomManager rommgr, byte? AreaID)
        {
            Conversion.Fast3DParsing.Fast3DParser.Convert(obj, this, rommgr, AreaID);
        }

        public Task ToObject3DAsync(Object3D obj, RomManager rommgr, byte? AreaID)
        {
            var t = new Task(() => ToObject3D(obj, rommgr, AreaID));
            t.Start();
            return t;
        }

        public void Close()
        {
            Script.Close();
        }
    }
}