using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pilz.Cryptography;
using Pilz.Json.Converters;

namespace SM64Lib.ASM
{
    public class CustomAsmAreaConfig
    {
        [JsonConverter(typeof(UniquiIDStringJsonConverter<CustomAsmAreaConfig>))]
        public UniquieID<CustomAsmAreaConfig> ID { get; set; } = new UniquieID<CustomAsmAreaConfig>();
        public string Name { get; set; }
        [JsonProperty]
        public int RamAddress { get; internal set; } = -1;
        [JsonProperty]
        public int RomAddress { get; internal set; } = -1;
        [JsonProperty]
        public int Length { get; internal set; } = 0;
    }
}
