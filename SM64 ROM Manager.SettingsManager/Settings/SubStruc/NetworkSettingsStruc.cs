﻿using global::SM64_ROM_Manager.Updating;
using Pilz.Cryptography;
using System;

namespace SM64_ROM_Manager.SettingsManager
{
    public class NetworkSettingsStruc
    {
        public bool AutoUpdates { get; set; }
        public Channels MinimumUpdateChannel { get; set; }
        public bool UseAdminRightsForUpdates { get; set; }
        public string ProxyUsername { get; set; }
        public SecureString ProxyPassword { get; set; }
        public DateTime LastUpdateCheck { get; set; }

        public void ResetValues()
        {
            AutoUpdates = true;
            MinimumUpdateChannel = Channels.Stable;
            UseAdminRightsForUpdates = false;
            LastUpdateCheck = DateTime.MinValue;
            ProxyUsername = null;
            ProxyPassword = null;
        }
    }
}