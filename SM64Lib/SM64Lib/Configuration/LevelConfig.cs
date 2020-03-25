using System.Collections.Generic;

namespace SM64Lib.Configuration
{
    public class LevelConfig
    {
        public string LevelName { get; set; }
        public bool EnableLocalObjectBank { get; set; } = false;
        public Dictionary<byte, LevelAreaConfig> AreaConfigs { get; private set; } = new Dictionary<byte, LevelAreaConfig>();

        public LevelAreaConfig GetLevelAreaConfig(byte areaID)
        {
            if (AreaConfigs.ContainsKey(areaID))
            {
                return AreaConfigs[areaID];
            }
            else
            {
                var conf = new LevelAreaConfig();
                AreaConfigs.Add(areaID, conf);
                return conf;
            }
        }
    }
}