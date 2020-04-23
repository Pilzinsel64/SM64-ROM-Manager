using SM64Lib.Objects.ModelBanks;
using System.Collections.Generic;

namespace SM64Lib.Configuration
{
    public class CustomModelConfig
    {
        internal delegate void RequestModelEventHandler(CustomModelConfig config, RequestModelEventArgs request);
        internal static event RequestModelEventHandler RequestModel;

        public string Name { get; set; } = string.Empty;
        public List<int> CollisionPointerDestinations { get; private set; } = new List<int>();

        public CustomModel FindModel()
        {
            var args = new RequestModelEventArgs();
            RequestModel?.Invoke(this, args);
            return args.Model;
        }

        internal class RequestModelEventArgs
        {
            public CustomModel Model { get; set; }
        }
    }
}