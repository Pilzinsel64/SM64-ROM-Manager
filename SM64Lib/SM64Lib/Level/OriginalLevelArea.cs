
namespace SM64Lib.Levels
{
    public class OriginalLevelArea : LevelArea
    {
        public OriginalLevelArea(byte AreaID) : base(AreaID)
        {
        }

        public OriginalLevelArea(byte AreaID, byte LevelID) : base(AreaID, LevelID)
        {
        }

        public OriginalLevelArea(byte AreaID, byte LevelID, bool AddWarps, bool AddObjects) : base(AreaID, LevelID, AddWarps, AddObjects)
        {
        }

        public OriginalLevelArea() : base()
        {
        }
    }
}