using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.SettingsManager
{
    public class WindowSettingsStruc
    {
        public WindowSettings LevelEditor { get; set; }

        public void ResetValues()
        {
            LevelEditor = new WindowSettings();
        }
    }
}
