
using Newtonsoft.Json;

namespace SM64Lib.Levels
{
    public class RMLevelArea : LevelArea
    {
        // P r o p e r t i e s

        public AreaReverbLevel ReverbLevel { get; set; } = AreaReverbLevel.None;

        // C o n s t r u c t o r s

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

        [JsonConstructor]
        private RMLevelArea(JsonConstructorAttribute attr) : base(attr)
        {
        }
    }
}