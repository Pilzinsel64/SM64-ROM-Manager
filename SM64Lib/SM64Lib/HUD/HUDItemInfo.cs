using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public bool CanSetText { get; private set; }
        [JsonProperty]
        public int? SizeXPosition { get; private set; }
        [JsonProperty]
        public int? SizeYPosition { get; private set; }
        [JsonProperty]
        public int? VisiblePosition { get; private set; }
        [JsonProperty]
        public int? TextPosition { get; private set; }
    }
}
