using System.Collections.Generic;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;

namespace SM64Lib.Configuration
{
    public class RomConfig
    {
        public Dictionary<byte, LevelConfig> LevelConfigs { get; private set; } = new Dictionary<byte, LevelConfig>();
        public ObjectBankConfig GlobalObjectBankConfig { get; private set; } = new ObjectBankConfig();
        public MusicConfiguration MusicConfig { get; private set; } = new MusicConfiguration();
        public string SelectedTextProfileInfo { get; set; } = string.Empty;
        public ScrollTexConfig ScrollTexConfig { get; set; } = new ScrollTexConfig();

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
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<RomConfig>();
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(this).ToString());
        }
    }
}