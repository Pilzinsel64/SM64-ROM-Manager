using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors
{
    public class BehaviorBankConfig
    {
        public bool IsVanilla { get; set; } = true;
        public List<BehaviorConfig> BehaviorConfigs { get; } = new List<BehaviorConfig>();

        [JsonProperty(nameof(Enabled))]
        private bool enabled = false;
        public void Enable() => enabled = true;
        internal void Disable()
        {
            enabled = false;
            IsVanilla = true;
            BehaviorConfigs.Clear();
        }

        [JsonIgnore]
        public bool Enabled
        {
            get
            {
                if (!enabled && !IsVanilla)
                    enabled = true;
                return enabled;
            }
        }
    }
}
