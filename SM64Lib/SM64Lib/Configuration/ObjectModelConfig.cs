using System.Collections.Generic;

namespace SM64Lib.Configuration
{
    public class ObjectModelConfig
    {
        public Dictionary<int, CustomModelConfig> CustomObjectConfigs { get; private set; } = new Dictionary<int, CustomModelConfig>();

        public CustomModelConfig GetCustomObjectConfig(int id)
        {
            CustomModelConfig conf = null;
            if (!CustomObjectConfigs.TryGetValue(id, out conf))
            {
                conf = new CustomModelConfig();
            }

            return conf;
        }
    }
}