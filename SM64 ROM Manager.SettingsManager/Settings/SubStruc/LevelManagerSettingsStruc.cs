﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.SettingsManager
{
    public class LevelManagerSettingsStruc
    {
        public bool UseNewGUI { get; set; }

        public void ResetValues()
        {
            UseNewGUI = false;
        }
    }
}