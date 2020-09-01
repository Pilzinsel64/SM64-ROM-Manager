using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Configuration
{
    public class CollisionBasicConfig
    {
        public List<byte> CollisionTypesWithParams { get; } = new List<byte>()
        { 14, 44, 36, 37, 39, 45 };
    }
}
