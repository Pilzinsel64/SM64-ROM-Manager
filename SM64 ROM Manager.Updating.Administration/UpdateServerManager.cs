using global::System.IO;
using global::Newtonsoft.Json.Linq;
using WebDav;
using System.Net;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.VisualBasic.CompilerServices.LikeOperator;
using Microsoft.VisualBasic;

namespace SM64_ROM_Manager.Updating.Administration
{
    public class UpdateServerManager
    {
        private const string PKG_SEARCHTEXT = "pkg*.*.*.*.zip";
        private const string PKG_FILENAME_TEMPLATE = "pkg{0}{1}.zip";
        private const string PKG_FILENAME_ALPHADEFINITION = "a";
        private const string PKG_FILENAME_BETADEFINITION = "b";
        private const string PKG_FILENAME_RCDEFINITION = "rc";
        private const string PKG_FILENAME_RELEASEDEFINITION = "r";

        private WebDavClient client;
        public UpdateInfo UpdateInfo { get; private set; }
        public UpdateServerConfig Config { get; private set; }
        public bool IsReady { get; private set; }

        public UpdateServerManager(UpdateServerConfig config)
        {
            GenerateClient(config);
            NewInfo();
        }

        public bool GenerateClient(UpdateServerConfig config)
        {
            bool success;

            try
            {
                // Create client params
                var clientparams = new WebDavClientParams()
                {
                    BaseAddress = new Uri(config.ServerAdress),
                    Credentials = new NetworkCredential(config.Username, config.Password),
                };

                // Create client
                client = new WebDavClient(clientparams);

                // Remember config
                Config = config;

                success = true;
            }
            catch (Exception)
            {
                success = false;
                Config = null;
                client = null;
            }

            return success;
        }

        public async Task<bool> LoadInfoFromServer()
        {
            bool success;

            try
            {
                var response = await client.GetProcessedFile(Config.UpdateInfoFilename);

                if (response.IsSuccessful)
                {
                    var sr = new StreamReader(response.Stream);
                    var raw = await sr.ReadToEndAsync();
                    sr.Close();
                    UpdateInfo = JObject.Parse(raw).ToObject<UpdateInfo>();
                }

                success = true;
            }
            catch (Exception)
            {
                success = false;
            }

            return success;
        }

        public async Task<bool> SaveInfoToServer()
        {
            bool success;

            try
            {
                // Remove configs of non-existing packages
                await ClearUpdateInfo();

                // Update Packagelinks
                UpdatePackageLinks();

                // Write
                var raw = UpdateInfo.ToString();
                var ms = new MemoryStream();
                var sw = new StreamWriter(ms);
                await sw.WriteAsync(raw);
                await sw.FlushAsync();

                // Upload
                ms.Position = 0;
                await client.PutFile(Config.UpdateInfoFilename, ms);

                ms.Close();
                success = true;
            }
            catch (Exception)
            {
                success = false;
            }

            return success;
        }

        public void LoadInfoFromFile(string filePath)
        {
            UpdateInfo = JObject.Parse(File.ReadAllText(filePath)).ToObject<UpdateInfo>();
        }

        public async Task SaveInfoToFile(string filePath)
        {
            // Remove configs of non-existing packages
            await ClearUpdateInfo();

            // Update Packagelinks
            UpdatePackageLinks();

            // Write
            File.WriteAllText(filePath, UpdateInfo.ToString());
        }

        public void NewInfo()
        {
            UpdateInfo = new UpdateInfo();
        }

        private async Task ClearUpdateInfo()
        {
            var pkgs = await GetUpdatePackagesList();
            var infosToRemove = new List<UpdatePackageInfo>();
            
            // Find non-existing packages
            foreach (var info in UpdateInfo.Packages)
            {
                if (!pkgs.Where((n) => n == info.Version).Any())
                {
                    infosToRemove.Add(info);
                }
            }

            // Remove found packages
            foreach (var info in infosToRemove)
                UpdateInfo.Packages.Remove(info);
        }

        private void UpdatePackageLinks()
        {
            foreach (var info in UpdateInfo.Packages)
                UpdatePackageLink(info);
        }

        private void UpdatePackageLink(UpdatePackageInfo info)
        {
            info.Packagelink = Config.PublicPackageBaseURL + BuildPackageFilename(info.Version);
        }

        public async Task<IEnumerable<ApplicationVersion>> GetUpdatePackagesList()
        {
            var pkgs = new List<ApplicationVersion>();
            var response = await client.Propfind(string.Empty);

            if (response.IsSuccessful)
            {
                foreach (var resource in response.Resources)
                {
                    var fileName = Path.GetFileName(resource.Uri);
                    if (!string.IsNullOrEmpty(fileName) && fileName.ToLower() != Config.UpdateInfoFilename && LikeString(fileName, "pkg*.*.*.*.zip", CompareMethod.Text))
                    {
                        var appVersion = new ApplicationVersion();
                        bool allowAdd = true;

                        fileName = Path.GetFileNameWithoutExtension(fileName);
                        fileName = fileName.Substring(3);

                        // Get alpha/beta/rc value
                        {
                            int indexAlpha, indexBeta, indexRC, indexRelease;
                            indexAlpha = fileName.IndexOf(PKG_FILENAME_ALPHADEFINITION);
                            indexBeta = fileName.IndexOf(PKG_FILENAME_BETADEFINITION);
                            indexRC = fileName.IndexOf(PKG_FILENAME_RCDEFINITION);
                            indexRelease = fileName.IndexOf(PKG_FILENAME_RELEASEDEFINITION);

                            int indexDef;
                            string pkgFilenameDef;
                            if (indexAlpha > -1)
                            {
                                indexDef = indexAlpha;
                                pkgFilenameDef = PKG_FILENAME_ALPHADEFINITION;
                            }
                            else if (indexBeta > -1)
                            {
                                indexDef = indexBeta;
                                pkgFilenameDef = PKG_FILENAME_BETADEFINITION;
                            }
                            else if (indexRC > -1)
                            {
                                indexDef = indexRC;
                                pkgFilenameDef = PKG_FILENAME_RCDEFINITION;
                            }
                            else if (indexRelease > -1)
                            {
                                indexDef = indexRelease;
                                pkgFilenameDef = PKG_FILENAME_RELEASEDEFINITION;
                            }
                            else
                            {
                                indexDef = -1;
                                pkgFilenameDef = null;
                            }

                            if (indexDef > -1)
                            {
                                // Get def from filename
                                var def = fileName.Substring(indexDef);
                                fileName = fileName.Remove(indexDef);

                                // Get channel
                                switch (pkgFilenameDef)
                                {
                                    case PKG_FILENAME_ALPHADEFINITION:
                                        appVersion.Channel = Channels.Alpha;
                                        break;
                                    case PKG_FILENAME_BETADEFINITION:
                                        appVersion.Channel = Channels.Beta;
                                        break;
                                    case PKG_FILENAME_RCDEFINITION:
                                        appVersion.Channel = Channels.PreRelease;
                                        break;
                                    case PKG_FILENAME_RELEASEDEFINITION:
                                        appVersion.Channel = Channels.Stable;
                                        break;
                                }

                                // Get build
                                var defBuild = def.Substring(pkgFilenameDef.Length);
                                appVersion.Build = Convert.ToInt32(defBuild);
                            }
                            else
                            {
                                // Set to default
                                appVersion.Build = 1;
                                appVersion.Channel = Channels.Stable;
                            }
                        }

                        // Get version
                        if (Version.TryParse(fileName, out Version version))
                            appVersion.Version = version;
                        else
                            allowAdd = false;

                        if (allowAdd)
                            pkgs.Add(appVersion);
                    }
                }
            }

            return pkgs;
        }

        public async Task<bool> DeletePackage(ApplicationVersion version)
        {
            var fileName = BuildPackageFilename(version);
            var response = await client.Delete(fileName);
            return response.IsSuccessful;
        }

        public async Task<bool> UploadPackage(string filePath, ApplicationVersion version)
        {
            bool success;
            var fileName = BuildPackageFilename(version);

            // Upload
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var response = await client.PutFile(fileName, fs);
            fs.Close();
            success = response.IsSuccessful;

            // Generate public downloadlink
            if (success)
            {
                var pkgInfo = GetOrCreateUpdatePackageInfo(version);
                pkgInfo.Packagelink = Config.PublicPackageBaseURL + fileName;
            }

            return success;
        }

        private string BuildPackageFilename(ApplicationVersion version)
        {
            // Build channel/build definition of filename
            string def = string.Empty;
            switch (version.Channel)
            {
                case Channels.Alpha:
                    def = PKG_FILENAME_ALPHADEFINITION + version.Build;
                    break;
                case Channels.Stable:
                    if (version.Build != 1)
                        def = PKG_FILENAME_RELEASEDEFINITION + version.Build;
                    break;
                case Channels.PreRelease:
                    def = PKG_FILENAME_RCDEFINITION + version.Build;
                    break;
                case Channels.Beta:
                    def = PKG_FILENAME_BETADEFINITION + version.Build;
                    break;
            }

            // Build filename
            var fileName = string.Format(PKG_FILENAME_TEMPLATE, version.Version, def);

            return fileName;
        }

        private UpdatePackageInfo GetOrCreateUpdatePackageInfo(ApplicationVersion version)
        {
            var info = GetUpdatePackageInfo(version);

            if (info == null)
                info = CreateUpdatePackageInfo(version);

            return info;
        }

        private UpdatePackageInfo GetUpdatePackageInfo(ApplicationVersion version)
        {
            return UpdateInfo.Packages.FirstOrDefault((n) => n.Version == version);
        }

        private UpdatePackageInfo CreateUpdatePackageInfo(ApplicationVersion version)
        {
            var info = new UpdatePackageInfo()
            {
                Version = version
            };
            UpdateInfo.Packages.Add(info);
            return info;
        }

        public (string name, string description, UpdateNotesContentType descriptionType) GetPackageDescription(ApplicationVersion version)
        {
            var pkg = GetUpdatePackageInfo(version);
            if (pkg is object)
                return (pkg.Name, pkg.Notes.Content, pkg.Notes.ContentType);
            else
                return default;
        }

        public void SetPackageDescription(ApplicationVersion version, string name, string description, UpdateNotesContentType descriptionType)
        {
            var pkg = GetOrCreateUpdatePackageInfo(version);
            if (pkg is object)
            {
                pkg.Name = name;
                pkg.Notes.Content = description;
                pkg.Notes.ContentType = descriptionType;
            }
        }

        public async Task<bool> ChangePackageVersion(ApplicationVersion currentVersion, ApplicationVersion newVersion)
        {
            bool success = false;

            // Get file names
            var currentFilename = BuildPackageFilename(currentVersion);
            var newFilename = BuildPackageFilename(newVersion);

            // Move
            var response = await client.Move(currentFilename, newFilename);

            // Change package info version, if exists
            if (response.IsSuccessful)
            {
                var pkg = GetUpdatePackageInfo(currentVersion);
                if (pkg is object)
                    pkg.Version = newVersion;
                success = true;
            }

            return success;
        }
    }
}