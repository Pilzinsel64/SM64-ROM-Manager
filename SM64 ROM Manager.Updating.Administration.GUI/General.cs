using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public static class General
    {
        private static string myAppPath = string.Empty;
        public static UpdateProject CurProject { get; set; } = null;

        public static string MyAppPath
        {
            get
            {
                if (string.IsNullOrEmpty(myAppPath))
                    Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                return myAppPath;
            }
        }

        public static void SetProxyConfig()
        {
            if (CurProject.ProxyConfig.UseProxyAuth)
                WebRequest.DefaultWebProxy.Credentials = new NetworkCredential(CurProject.ProxyConfig.Username, CurProject.ProxyConfig.Password);
            else
                WebRequest.DefaultWebProxy.Credentials = null;
        }
    }
}
