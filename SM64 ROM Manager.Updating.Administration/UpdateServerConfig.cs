using Newtonsoft.Json;
using Pilz.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration
{
    public class UpdateServerConfig
    {
        public bool UseProxyForWebDAV { get; set; } = false;
        public string ServerAdress { get; set; }
        public string PublicPackageBaseURL { get; set; }
        public string UpdateInfoFilename { get; set; }
        public string Username { get; set; }
        [JsonProperty("Password2")]
        public SecureString Password { get; set; }
    }
}
