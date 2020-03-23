using System;
using System.Drawing;
using global::SM64Lib.Levels;

namespace SM64_ROM_Manager.EventArguments
{
    public class LevelAreaBackgroundModeChangedEventArgs : EventArgs
    {
        public AreaBGs BackgroundType { get; private set; }
        public Color BackgroundColor { get; private set; }

        public LevelAreaBackgroundModeChangedEventArgs(AreaBGs typ, Color color)
        {
            BackgroundType = typ;
            BackgroundColor = color;
        }
    }
}