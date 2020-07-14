using Newtonsoft.Json;
using SM64Lib.Objects.ModelBanks;
using System.Collections.Generic;
using Pilz.Cryptography;
using Pilz.Json.Converters;

namespace SM64Lib.Configuration
{
    public class CustomModelConfig
    {
        internal delegate void RequestModelEventHandler(CustomModelConfig config, RequestModelEventArgs request);
        internal static event RequestModelEventHandler RequestModel;

        [JsonConverter(typeof(UniquiIDStringJsonConverter<CustomModelConfig>))]
        public UniquieID<CustomModelConfig> ID { get; set; } = new UniquieID<CustomModelConfig>();
        public string Name { get; set; } = string.Empty;
        public List<int> CollisionPointerDestinations { get; private set; } = new List<int>();

        public CustomModel FindModel()
        {
            var args = new RequestModelEventArgs();
            RequestModel?.Invoke(this, args);
            return args.Model;
        }

        internal class RequestModelEventArgs
        {
            public CustomModel Model { get; set; }
        }
    }
}