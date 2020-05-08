using Newtonsoft.Json;
using Pilz.IO;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Json;
using SM64Lib.Objects.ModelBanks;
using SM64Lib.Patching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectExportData
    {
        public List<CustomObject> CustomObjects { get; set; } = new List<CustomObject>();
        [JsonConverter(typeof(ComplexDictionarJsonConverter<CustomModelConfig, CustomModel>))]
        public Dictionary<CustomModelConfig, CustomModel> CustomModels { get; set; } = new Dictionary<CustomModelConfig, CustomModel>();
        [JsonConverter(typeof(ComplexDictionarJsonConverter<BehaviorConfig, Behavior>))]
        public Dictionary<BehaviorConfig, Behavior> Behaviors { get; set; } = new Dictionary<BehaviorConfig, Behavior>();
        public EmbeddedFilesContainer EmbeddedFiles { get; set; }
        public PatchScript Script { get; set; }
    }
}
