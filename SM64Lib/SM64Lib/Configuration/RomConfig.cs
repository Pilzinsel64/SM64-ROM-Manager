using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SM64Lib.Behaviors;
using SM64Lib.Objects.ObjectBanks;
using SM64Lib.ASM;
using SM64Lib.Objects.ObjectBanks.Data;

namespace SM64Lib.Configuration
{
    public class RomConfig
    {
        // Levels
        public Dictionary<byte, LevelConfig> LevelConfigs { get; } = new Dictionary<byte, LevelConfig>();

        // Global Banks
        [JsonProperty("GlobalObjectBankConfig")]
        public ObjectModelConfig GlobalModelBank { get; } = new ObjectModelConfig();
        public BehaviorBankConfig GlobalBehaviorBank { get; } = new BehaviorBankConfig();
        public CustomObjectCollection GlobalObjectBank { get; } = new CustomObjectCollection();
        public CustomAsmBankConfig GlobalCustomAsmBank { get; } = new CustomAsmBankConfig();

        // Music
        public MusicConfiguration MusicConfig { get;  } = new MusicConfiguration();

        // Texts
        public string SelectedTextProfileInfo { get; set; } = string.Empty;

        // Other
        public ScrollTexConfig ScrollTexConfig { get; set; } = new ScrollTexConfig();
        public ObjectBankDataListCollection ObjectBankInfoData { get; } = new ObjectBankDataListCollection();

        // F e a t u r e s

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

        // L o a d / S a v e

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