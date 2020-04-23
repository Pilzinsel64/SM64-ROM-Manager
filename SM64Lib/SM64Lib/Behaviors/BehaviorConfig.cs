using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Behaviors
{
    public class BehaviorConfig
    {
        internal delegate void RequestModelEventHandler(BehaviorConfig config, RequestBehaviorEventArgs request);
        internal static event RequestModelEventHandler RequestBehavior;

        public int BankAddress { get; set; } = -1;
        public bool IsVanilla { get; set; } = false;
        public string Name { get; set; } = string.Empty;
        public int FixedLength { get; set; } = -1;

        public Behavior FindBehavior()
        {
            var args = new RequestBehaviorEventArgs();
            RequestBehavior?.Invoke(this, args);
            return args.Behavior;
        }

        internal class RequestBehaviorEventArgs
        {
            public Behavior Behavior { get; set; }
        }
    }
}
