using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib
{
    public class RomSpaceInfo
    {
        public long MaxAvailableSpace { get; set; }
        public long UsedLevelsSpace { get; set; }
        public long UsedMusicSpace { get; set; }
        public long UsedGlobalBehaviorSpace { get; set; }
        public long UsedGlobalModelsSpace { get; set; }

        public long TotalUsedSpace
        {
            get =>
                UsedLevelsSpace +
                UsedMusicSpace +
                UsedGlobalBehaviorSpace +
                UsedGlobalModelsSpace;
        }

        public long FreeSpace
        {
            get => MaxAvailableSpace - TotalUsedSpace;
        }
    }
}
