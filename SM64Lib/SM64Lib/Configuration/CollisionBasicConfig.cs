using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Configuration
{
    public class CollisionBasicConfig
    {
        private List<byte> collisionTypesWithParams = new List<byte>()
        { 14, 44, 36, 37, 39, 45 };

        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public List<byte> CollisionTypesWithParams
        {
            get => collisionTypesWithParams;
            private set => collisionTypesWithParams = value.Distinct().ToList();
        }
    }
}
