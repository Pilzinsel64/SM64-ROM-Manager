using System;

namespace SM64_ROM_Manager.EventArguments
{
    public class LevelAreaEventArgs : EventArgs
    {
        public int LevelIndex { get; private set; }
        public int AreaIndex { get; private set; }
        public byte AreaID { get; private set; }

        public LevelAreaEventArgs(int levelIndex, int areaIndex, byte areaID)
        {
            LevelIndex = levelIndex;
            AreaIndex = areaIndex;
            AreaID = areaID;
        }
    }
}