using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.HUD
{
    public abstract class HUDElementInfo
    {
        [JsonProperty]
        public bool CanSetVisible { get; private set; }
        [JsonProperty]
        public int? VisibleRomPosition { get; private set; }
    }
}
