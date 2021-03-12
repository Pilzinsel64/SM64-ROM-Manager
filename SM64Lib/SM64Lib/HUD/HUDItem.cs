using Newtonsoft.Json;
using SM64Lib.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.HUD
{
    public class HUDItem : HUDElement
    {
        [JsonIgnore]
        public new HUDItemInfo DataInfo => (HUDItemInfo)base.DataInfo;
        public Point? Location { get; set; }

        public HUDItem(HUDItemInfo info) :
            base(info)
        { }

        public override void LoadData(BinaryData data)
        {
            base.LoadData(data);

            if (DataInfo.LocationRomPosition.HasValue)
            {
                short x, y;
                data.Position = DataInfo.LocationRomPosition.Value.X;
                x = data.ReadInt16();
                data.Position = DataInfo.LocationRomPosition.Value.Y;
                y = data.ReadInt16();
                Location = new Point(x, y);
            }
        }

        public override void SaveData(BinaryData data)
        {
            base.SaveData(data);

            if (DataInfo.CanSetLocation && DataInfo.LocationRomPosition.HasValue && Location.HasValue)
            {
                data.Position = DataInfo.LocationRomPosition.Value.X;
                data.Write((short)Location.Value.X);
                data.Position = DataInfo.LocationRomPosition.Value.Y;
                data.Write((short)Location.Value.Y);
            }
        }
    }
}
