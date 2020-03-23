using System;
using global::SM64Lib.Data;

namespace SM64Lib.Levels
{
    public class OriginalLevelManager : ILevelManager
    {
        public void LoadLevel(Level lvl, RomManager rommgr, ushort LevelID, uint segAddress)
        {
            throw new NotImplementedException();
        }

        public LevelSaveResult SaveLevel(Level lvl, RomManager rommgr, BinaryData output, ref uint curOff)
        {
            throw new NotImplementedException();
        }
    }
}