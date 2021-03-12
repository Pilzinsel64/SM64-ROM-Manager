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
    public class HUDGroup : HUDElement
    {
        [JsonIgnore]
        public new HUDGroupInfo DataInfo => (HUDGroupInfo)base.DataInfo;
        public List<HUDItem> Items { get; } = new();

        [JsonIgnore]
        public Point Location
        {
            get
            {
                if (Items.Any())
                    return Items.First().Location.Value;
                else
                    return Point.Empty;
            }
            set
            {
                if (Items.Any())
                    Items.First().Location = value;
            }
        }

        [JsonIgnore]
        public Size Size
        {
            get
            {
                int maxWith = 0;
                int maxHeight = 0;

                foreach (var item in Items)
                {
                    if (item.DataInfo.ItemSize?.Width > maxWith)
                        maxWith = item.DataInfo.ItemSize.Value.Width;
                    if (item.DataInfo.ItemSize?.Height > maxHeight)
                        maxHeight = item.DataInfo.ItemSize.Value.Height;
                }

                return new Size(maxWith, maxHeight);
            }
        }

        [JsonIgnore]
        public bool CanSetLocation
        {
            get => !Items.Where(n => !n.DataInfo.CanSetLocation).Any();
        }

        public HUDGroup(HUDGroupInfo dataInfo) :
            base(dataInfo)
        { }

        public override void LoadData(BinaryData data)
        {
            base.LoadData(data);

            foreach (var item in Items)
                item.LoadData(data);
        }

        public override void SaveData(BinaryData data)
        {
            base.SaveData(data);

            foreach (var item in Items)
                item.SaveData(data);
        }

    }
}
