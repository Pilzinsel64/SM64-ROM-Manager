using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager
{
    public class HUDOptionsValueSelection
    {
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HUDOptionsValueTypes ValueType { get; set; }
        public bool AllowFreeMode { get; set; }
        public int RomPos { get; set; }
        public Dictionary<string, int> Values { get; set; }
    }
}
