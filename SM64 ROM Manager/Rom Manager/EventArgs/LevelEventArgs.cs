using System;

namespace SM64_ROM_Manager.EventArguments
{
    public class LevelEventArgs : EventArgs
    {
        public int LevelIndex { get; private set; }
        public ushort LevelID { get; private set; }

        public LevelEventArgs(int levelIndex, ushort levelID)
        {
            LevelIndex = levelIndex;
            LevelID = levelID;
        }
    }
}