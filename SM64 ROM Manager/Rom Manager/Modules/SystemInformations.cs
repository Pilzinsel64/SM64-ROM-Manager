using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SM64_ROM_Manager.SettingsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager
{
    class SystemInformations
    {
        public bool Is64BitOS { get; set; }
        public bool Is64BitProcess { get; set; }
        public string MachineName { get; set; }
        public OperatingSystem OSVersion { get; set; }
        public int ProcessorCount { get; set; }
        public string UserDomainName { get; set; }
        public string Username { get; set; }
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }
        public string InstallationPath { get; set; }

        public void CollectInformations()
        {
            Is64BitOS = Environment.Is64BitOperatingSystem;
            Is64BitProcess = Environment.Is64BitProcess;
            OSVersion = Environment.OSVersion;
            ProcessorCount = Environment.ProcessorCount;
            Version = Environment.Version;

            if (Settings.DiagnosticData.AllowExtendedSystemInformations.GetValueOrDefault())
            {
                UserDomainName = Environment.UserDomainName;
                Username = Environment.UserName;
                MachineName = Environment.MachineName;
                InstallationPath = Publics.General.MyDataPath;
            }
        }
    }
}
