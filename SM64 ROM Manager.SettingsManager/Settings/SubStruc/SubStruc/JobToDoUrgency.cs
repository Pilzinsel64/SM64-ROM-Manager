
namespace SM64_ROM_Manager.SettingsManager
{
    public enum JobToDoUrgency
    {
        OnNextExit = 1,
        OnNextStartup = 2,
        AsSoonAsPossible = OnNextExit | OnNextStartup
    }
}