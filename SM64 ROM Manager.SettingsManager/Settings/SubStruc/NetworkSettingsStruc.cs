using global::SM64_ROM_Manager.Updating;

namespace SM64_ROM_Manager.SettingsManager
{
    public class NetworkSettingsStruc
    {
        public bool AutoUpdates { get; set; }
        public Channels MinimumUpdateChannel { get; set; }
        public bool UseAdminRightsForUpdates { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPasswordEncrypted { get; set; }

        public void ResetValues()
        {
            AutoUpdates = true;
            MinimumUpdateChannel = Channels.Stable;
            UseAdminRightsForUpdates = false;
        }
    }
}