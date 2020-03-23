
namespace SM64Lib.Levels.Script
{
    public interface IManagedLevelscriptCommand
    {
        LevelscriptCommand Command { get; }

        void LoadProperties();
        void SaveProperties();
        void SaveProperties(LevelscriptCommand Command);
    }
}