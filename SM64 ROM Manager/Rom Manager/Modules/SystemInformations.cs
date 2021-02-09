using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Rom_Manager.Modules
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


        public void CollectInformations()
        {
            Is64BitOS = Environment.Is64BitOperatingSystem;
            Is64BitProcess = Environment.Is64BitProcess;
            MachineName = Environment.MachineName;
            OSVersion = Environment.OSVersion;
            ProcessorCount = Environment.ProcessorCount;
            UserDomainName = Environment.UserDomainName;
            Username = Environment.UserName;
            Version = Environment.Version;
        }
    }
}
