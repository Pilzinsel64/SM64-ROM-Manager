using Newtonsoft.Json;
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
        public string Text { get; set; }

        [JsonConstructor]
        private HUDItem()
        {
        }

        public HUDItem(HUDItemInfo info) : base()
        {
            DataInfo = info;
        }
    }
}
