using Newtonsoft.Json;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectImport : CustomObjectExport
    {
        [JsonIgnore]
        public Dictionary<CustomModelConfig, CustomModelBank> DestModelBanks { get; } = new Dictionary<CustomModelConfig, CustomModelBank>();
        [JsonIgnore]
        public BehaviorBank DestBehaviorBank { get; set; } = null;
        [JsonIgnore]
        public List<CustomObject> IgnoreCustomObjects { get; } = new List<CustomObject>();
    }
}
