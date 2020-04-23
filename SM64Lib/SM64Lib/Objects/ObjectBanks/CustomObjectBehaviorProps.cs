using Newtonsoft.Json;
using SM64Lib.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectBehaviorProps
    {
        public BehaviorConfig Behavior { get; set; }
        public bool UseCustomAddress { get; set; } = true;
        public bool UseCollisionPointerOfModel { get; set; } = true;

        [JsonProperty(nameof(BehaviorAddress))]
        private int _behaviorAddress;

        [JsonIgnore]
        public int BehaviorAddress
        {
            get
            {
                if (UseCustomAddress || Behavior == null)
                    return _behaviorAddress;
                else
                    return Behavior.BankAddress;
            }
            set
            {
                if (UseCustomAddress)
                    _behaviorAddress = value;
                else
                    Behavior.BankAddress = value;
            }
        }
    }
}
