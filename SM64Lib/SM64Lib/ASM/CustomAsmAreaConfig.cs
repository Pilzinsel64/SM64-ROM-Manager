using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.ASM
{
    public class CustomAsmAreaConfig
    {
        public string ID { get; set; }
        public string Name { get; set; }
        [JsonProperty]
        public int RamAddress { get; internal set; } = -1;
        [JsonProperty]
        public int RomAddress { get; internal set; } = -1;
        [JsonProperty]
        public int Length { get; internal set; } = 0;
    }
}
