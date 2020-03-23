using System.Collections.Generic;

namespace SM64Lib.Configuration
{
    public class ObjectBankConfig
    {
        public Dictionary<int, CustomObjectConfig> CustomObjectConfigs { get; private set; } = new Dictionary<int, CustomObjectConfig>();

        public CustomObjectConfig GetCustomObjectConfig(int id)
        {
            CustomObjectConfig conf = null;
            if (!CustomObjectConfigs.TryGetValue(id, out conf))
            {
                conf = new CustomObjectConfig();
            }

            return conf;
        }
    }
}