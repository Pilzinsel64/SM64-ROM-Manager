
using SM64Lib.Configuration;

namespace SM64Lib.Levels
{
    public class RMLevel : Level
    {
        public LevelConfig Config { get; }

        public string Name
        {
            get => Config.LevelName;
            set => Config.LevelName = value;
        }

        public RMLevel(ushort LevelID, int LevelIndex) : base(LevelID, LevelIndex)
        {
            Config = new LevelConfig();
        }

        public RMLevel(LevelConfig config) : base()
        {
            Config = config;
        }
    }
}