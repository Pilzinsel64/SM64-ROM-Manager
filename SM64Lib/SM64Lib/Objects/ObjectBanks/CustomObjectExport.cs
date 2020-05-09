using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Json;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectExport
    {
        public string Name { get; set; } = string.Empty;
        public DateTime ExportDate { get; set; }
        [JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Version { get; set; } = new Version("1.0.0.0");
        public string ID { get; set; }

        [JsonIgnore]
        public CustomObjectExportData Data { get; private set; } = new CustomObjectExportData();
        [JsonProperty("CompressedData")]
        private byte[] compressedData = null;

        [JsonProperty("CustomModels")]
        [JsonConverter(typeof(ComplexDictionarJsonConverter<CustomModelConfig, CustomModel>))]
        private Dictionary<CustomModelConfig, CustomModel> ObsulateCustomModels { set => Data.CustomModels = value; }
        [JsonProperty("Behaviors")]
        [JsonConverter(typeof(ComplexDictionarJsonConverter<BehaviorConfig, Behavior>))]
        private Dictionary<BehaviorConfig, Behavior> ObsulateBehaviors { set => Data.Behaviors = value; }
        [JsonProperty("CustomObjects")]
        private List<CustomObject> ObsulateCustomObjects { set => Data.CustomObjects = value; }

        [JsonIgnore]
        public bool IsCompressed
        {
            get => compressedData is object;
        }

        public void Compress()
        {
            using (var outputRaw = new MemoryStream())
            {
                using (var sw = new StreamWriter(outputRaw))
                {
                    var ser = JsonSerializer.CreateDefault();
                    ser.PreserveReferencesHandling = PreserveReferencesHandling.All;
                    sw.Write(JObject.FromObject(Data, ser).ToString());
                    sw.Flush();
                    compressedData = General.CompressData(outputRaw, CompressionLevel.Optimal);
                }
            }
        }

        public void Decompress()
        {
            if (IsCompressed)
            {
                using (var raw = new MemoryStream())
                {
                    General.DecompressData(compressedData, raw);
                    raw.Position = 0;
                    using (var sr = new StreamReader(raw))
                    {
                        var ser = JsonSerializer.CreateDefault();
                        ser.PreserveReferencesHandling = PreserveReferencesHandling.All;
                        Data = JObject.Parse(sr.ReadToEnd()).ToObject<CustomObjectExportData>(ser);
                        compressedData = null;
                    }
                }
            }
        }
    }
}
