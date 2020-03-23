using global::SM64Lib.Data;

namespace SM64Lib.Levels
{
    public interface ILevelManager
    {
        void LoadLevel(Level lvl, RomManager rommgr, ushort LevelID, uint segAddress);
        LevelSaveResult SaveLevel(Level lvl, RomManager rommgr, BinaryData output, ref uint curOff);
    }
}