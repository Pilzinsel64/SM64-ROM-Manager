
namespace SM64_ROM_Manager.SettingsManager
{
    public class JobToDo
    {
        public JobToDoUrgency Urgency { get; set; }
        public JobToDoType Type { get; set; }
        public object[] Params { get; set; }
    }
}