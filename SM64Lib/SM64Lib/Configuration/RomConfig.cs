using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SM64Lib.Behaviors;
using SM64Lib.Objects.ObjectBanks;

namespace SM64Lib.Configuration
{
    public class RomConfig
    {
        public Dictionary<byte, LevelConfig> LevelConfigs { get; private set; } = new Dictionary<byte, LevelConfig>();
        public MusicConfiguration MusicConfig { get; private set; } = new MusicConfiguration();
        public string SelectedTextProfileInfo { get; set; } = string.Empty;
        public ScrollTexConfig ScrollTexConfig { get; set; } = new ScrollTexConfig();
        [JsonProperty("GlobalObjectBankConfig")]
        public ObjectModelConfig GlobalModelBank { get; private set; } = new ObjectModelConfig();
        public BehaviorBankConfig GlobalBehaviorBank { get; private set; } = new BehaviorBankConfig();
        public CustomObjectCollection GlobalObjectBank { get; private set; } = new CustomObjectCollection();

        public LevelConfig GetLevelConfig(ushort levelID)
        {
            if (LevelConfigs.ContainsKey(Conversions.ToByte(levelID)))
            {
                return LevelConfigs[Conversions.ToByte(levelID)];
            }
            else
            {
                var conf = new LevelConfig();
                LevelConfigs.Add(Conversions.ToByte(levelID), conf);
                return conf;
            }
        }

        public static RomConfig Load(string filePath)
        {
            var serializer = JsonSerializer.CreateDefault();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.All;
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<RomConfig>(serializer);
        }

        public void Save(string filePath)
        {
            var serializer = JsonSerializer.CreateDefault();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.All;
            File.WriteAllText(filePath, JObject.FromObject(this, serializer).ToString());
        }
    }
}