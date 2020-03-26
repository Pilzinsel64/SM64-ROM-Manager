using drsPwEnc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating
{
    public class UpdateServerInfo
    {
        public string ServerAdress { get; set; }
        public string PublicPackageBaseURL { get; set; }
        public string UpdateInfoFilename { get; set; }
        public string Username { get; set; }

        [JsonProperty("Password")]
        public string password;

        [JsonIgnore]
        public string Password
        {
            get
            {
                if (string.IsNullOrEmpty(password))
                    return string.Empty;
                else
                    return new drsPwEnc.drsPwEnc().DecryptData(password);
            }
            set
            {
                password = new drsPwEnc.drsPwEnc().EncryptData(value);
            }
        }
    }
}
