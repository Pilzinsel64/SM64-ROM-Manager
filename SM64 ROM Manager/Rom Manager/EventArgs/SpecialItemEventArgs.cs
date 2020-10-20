using System;

namespace SM64_ROM_Manager.EventArguments
{
    public class SpecialItemEventArgs : EventArgs
    {
        public int ItemIndex { get; private set; }
        public int LevelIndex { get; private set; }
        public int AreaIndex { get; private set; }

        public SpecialItemEventArgs(int itemIndex, int levelIndex, int areaIndex)
        {
            ItemIndex = itemIndex;
            LevelIndex = levelIndex;
            AreaIndex = areaIndex;
        }
    }
}