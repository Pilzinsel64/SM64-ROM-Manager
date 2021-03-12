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
    public class HUDItem
    {
        [JsonIgnore]
        public HUDItemInfo DataInfo { get; private set; }
        public string Name { get; set; }
        public Point? Location { get; set; }
        public bool? Visible { get; set; }

        [JsonConstructor]
        private HUDItem()
        {
        }

        public HUDItem(HUDItemInfo info) : base()
        {
            DataInfo = info;
        }

        public void LoadData(BinaryData data)
        {
            if (DataInfo.LocationRomPosition.HasValue)
            {
                short x, y;
                data.Position = DataInfo.LocationRomPosition.Value.X;
                x = data.ReadInt16();
                data.Position = DataInfo.LocationRomPosition.Value.Y;
                y = data.ReadInt16();
                Location = new Point(x, y);
            }

            if (DataInfo.VisibleRomPosition.HasValue)
            {
                data.Position = DataInfo.VisibleRomPosition.Value;
                var checkVal = data.ReadInt16();
                Visible = checkVal == 0x2400;
            }
        }

        public void SaveData(BinaryData data)
        {
            if (DataInfo.CanSetLocation && DataInfo.LocationRomPosition.HasValue && Location.HasValue)
            {
                data.Position = DataInfo.LocationRomPosition.Value.X;
                data.Write((short)Location.Value.X);
                data.Position = DataInfo.LocationRomPosition.Value.Y;
                data.Write((short)Location.Value.Y);
            }

            if (DataInfo.CanSetVisible && DataInfo.VisibleRomPosition.HasValue && Visible.HasValue)
            {
                short checkVal;

                if (Visible.Value)
                    checkVal = 0x2400;
                else
                    checkVal = 0x0C0B;

                data.Position = DataInfo.VisibleRomPosition.Value;
                data.Write(checkVal);
            }
        }
    }
}
