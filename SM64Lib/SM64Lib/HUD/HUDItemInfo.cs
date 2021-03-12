using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.HUD
{
    public class HUDItemInfo
    {
        [JsonProperty]
        public bool CanSetVisible { get; private set; }
        [JsonProperty]
        public bool CanSetLocation { get; private set; }
        [JsonProperty]
        public Point? LocationRomPosition { get; private set; }
        [JsonProperty]
        public int? VisibleRomPosition { get; private set; }
        [JsonProperty]
        public Size? ItemSize { get; private set; }
        [JsonProperty]
        public Point? LocationDefaultValue { get; private set; }
    }
}
