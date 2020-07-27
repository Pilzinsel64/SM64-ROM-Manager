using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Geolayout
{
    public class ObjectShadow
    {
        public bool Enabled { get; set; } = false;
        public ObjectShadowType Type { get; set; } = ObjectShadowType.Circle_9Verts;
        public short Scale { get; set; }
        public byte Solidity { get; set; } = 0xFF;
    }
}
