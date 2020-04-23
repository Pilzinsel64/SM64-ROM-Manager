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
    }
}
