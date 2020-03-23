using global::System.Collections.Specialized;

namespace SM64_ROM_Manager.SettingsManager
{
    public class RecentFilesSettingsStruc
    {
        public StringCollection RecentROMs { get; set; }
        public StringCollection RecentModelFiles { get; set; }

        public void ResetValues()
        {
            RecentROMs = new StringCollection();
            RecentModelFiles = new StringCollection();
        }
    }
}