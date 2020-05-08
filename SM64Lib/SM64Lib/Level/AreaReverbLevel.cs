using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Levels
{
    public enum AreaReverbLevel : byte
    {
        None,
        Level01 = 0x8,
        Level02 = 0xC,
        Level03 = 0x10,
        Level04 = 0x18,
        Level05 = 0x20,
        Level06 = 0x28,
        Level07 = 0x30,
        Level08 = 0x38,
        Level09 = 0x40,
        Level10 = 0x70
    }
}
