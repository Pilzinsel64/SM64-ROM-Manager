using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebDav;
using static Microsoft.VisualBasic.CompilerServices.LikeOperator;

namespace SM64_ROM_Manager.ProgressUpdater
{
    public class WebDavMgr
    {
        private Settings settings;
        private WebDavClient client = null;
        public bool IsConnected { get; private set; } = false;

        public WebDavMgr(Settings settings)
        {
            this.settings = settings;
        }

        public bool Connect()
        {
            bool result = false;

            if (!IsConnected)
            {
                if (!string.IsNullOrEmpty(settings.WebDavUri))
                {
                    // Set web proxy
                    if (!string.IsNullOrEmpty(settings.ProxyUsr) || !string.IsNullOrEmpty(settings.ProxyPwd))
                    {
                        WebRequest.DefaultWebProxy.Credentials = new NetworkCredential(settings.ProxyUsr, settings.ProxyPwd);
                    }

                    // Create client params
                    var clientparams = new WebDavClientParams()
                    {
                        BaseAddress = new Uri(settings.WebDavUri),
                        Credentials = new NetworkCredential(settings.WebDavUsr.Trim(), settings.WebDavPwd),
                        UseProxy = false
                    };
                    
                    // Create client
                    client = new WebDavClient(clientparams);

                    result = true;
                    IsConnected = true;
                }
            }

            return result;
        }

        public async Task<bool> UploadImage(Image img)
        {
            bool result;

            if (string.IsNullOrEmpty(settings.Version) || !Version.TryParse(settings.Version, out Version version))
                result = false;
            else
            {

                // Save image to memory
                var msImage = new MemoryStream();
                img.Save(msImage, System.Drawing.Imaging.ImageFormat.Png);
                msImage.Position = 0;

                // Upload image
                try
                {
                    var res = await client.PutFile($"{settings.Version}.png", msImage);
                    result = res.IsSuccessful;
                }
                catch (Exception)
                {
                    result = false;
                }
                finally
                {
                    msImage.Close();
                }

                result = true;
            }

            return result;
        }

        public async Task<IEnumerable<Version>> GetUsedVersions()
        {
            var versions = new List<Version>();
            var response = await client.Propfind(string.Empty);
            
            if (response.IsSuccessful)
            {
                foreach (var resource in response.Resources)
                {
                    string displayName = Path.GetFileNameWithoutExtension(resource.Uri);
                    if (!string.IsNullOrEmpty(displayName) && LikeString(displayName, "*.*.*.*", CompareMethod.Text))
                    {
                        if (Version.TryParse(displayName, out Version version))
                            versions.Add(version);
                    }
                }
            }

            return versions;
        }
    }
}
