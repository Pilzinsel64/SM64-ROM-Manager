
namespace SM64Lib.Levels
{
    public class RMLevelArea : LevelArea
    {
        public RMLevelArea(byte AreaID) : base(AreaID)
        {
        }

        public RMLevelArea(byte AreaID, byte LevelID) : base(AreaID, LevelID)
        {
        }

        public RMLevelArea(byte AreaID, byte LevelID, bool AddWarps, bool AddObjects) : base(AreaID, LevelID, AddWarps, AddObjects)
        {
        }

        public RMLevelArea() : base()
        {
        }
    }
}