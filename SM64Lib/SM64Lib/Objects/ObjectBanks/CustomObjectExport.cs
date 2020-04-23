using Newtonsoft.Json;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Json;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectExport
    {
        public string Name { get; set; } = string.Empty;
        public List<CustomObject> CustomObjects { get; set; } = new List<CustomObject>();
        public DateTime ExportDate { get; set; }
        [JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Version { get; set; } = new Version("1.0.0.0");
        [JsonConverter(typeof(ComplexDictionarJsonConverter<CustomModelConfig, CustomModel>))]
        public Dictionary<CustomModelConfig, CustomModel> CustomModels { get; set; } = new Dictionary<CustomModelConfig, CustomModel>();
        [JsonConverter(typeof(ComplexDictionarJsonConverter<BehaviorConfig, Behavior>))]
        public Dictionary<BehaviorConfig, Behavior> Behaviors { get; set; } = new Dictionary<BehaviorConfig, Behavior>();
    }
}
