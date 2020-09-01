using Pilz.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration
{
    public class ProxyConfiguration
    {
        public bool UseProxyAuth { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }
    }
}
