
namespace SM64Lib.Levels
{
    public class SM64ELevelArea : LevelArea
    {
        public SM64ELevelArea(byte AreaID) : base(AreaID)
        {
        }

        public SM64ELevelArea(byte AreaID, byte LevelID) : base(AreaID, LevelID)
        {
        }

        public SM64ELevelArea(byte AreaID, byte LevelID, bool AddWarps, bool AddObjects) : base(AreaID, LevelID, AddWarps, AddObjects)
        {
        }

        public SM64ELevelArea() : base()
        {
        }
    }
}