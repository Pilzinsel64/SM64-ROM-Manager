using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SM64Lib.Levels
{
    public class LevelList : List<Level>
    {
        public bool NeedToSave
        {
            get
            {
                return this.Where(n => n.NeedToSaveLevelscript || n.NeedToSaveBanks0E).Count() > 0;
            }
        }

        public long Length
        {
            get => this.Sum(n => n.Length);
        }
    }
}