using System;
using System.Collections.Generic;
using System.Data;
using global::System.IO;
using System.Linq;
using global::System.Net;
using System.Threading.Tasks;
using global::WebDav;

namespace SM64_ROM_Manager.PatchScripts
{
    public class TweakDatabaseManager
    {
        private static readonly Random random = new Random();

        private Dictionary<TweakDatabaseLoginTypes, WebDavClient> dicClients = new Dictionary<TweakDatabaseLoginTypes, WebDavClient>();
        public TweakDatabasePreferences Preferences { get; private set; }

        public TweakDatabaseManager(TweakDatabasePreferences pref)
        {
            Preferences = pref;
        }

        private WebDavClient CreateClient(TweakDatabaseLoginTypes t)
        {
            if (!dicClients.ContainsKey(t))
            {
                var login = Preferences.Logins[t];
                var @params = new WebDavClientParams()
                {
                    BaseAddress = new Uri(login.Link),
                    Credentials = new NetworkCredential(login.Username, login.Password),
                    UseProxy = false
                };
                dicClients.Add(t, new WebDavClient(@params));
            }

            return dicClients[t];
        }

        public async Task<IEnumerable<TweakDatabaseSyncFile>> CheckForUpdates(string localPath)
        {
            var client = CreateClient(TweakDatabaseLoginTypes.ReadOnlyAll);
            var syncFiles = new List<TweakDatabaseSyncFile>();
            WebDavResource resTopFolder = null;
            var checkedFiles = new List<string>();
            bool responseSuccessfull = false;

            async Task checkOutFolder(string remotePath)
            {
                var response = await client.Propfind(remotePath, new PropfindParameters() { ApplyTo = ApplyTo.Propfind.ResourceAndAncestors });
                if (resTopFolder is null && response.IsSuccessful && response.Resources.Any())
                {
                    resTopFolder = response.Resources.ElementAtOrDefault(0);
                    responseSuccessfull = true;
                }

                if (responseSuccessfull && response.Resources.Count > 1)
                {
                    for (int i = 1, loopTo = response.Resources.Count - 1; i <= loopTo; i++)
                    {
                        var res = response.Resources.ElementAtOrDefault(i);
                        bool isFolder = res.Uri.EndsWith("/");

                        if (!isFolder)
                        {
                            TweakDatabaseSyncAction? syncAction = default;
                            string localFile = string.Empty;
                            string remoteFile = string.Empty;

                            // Get remote file path
                            remoteFile = res.Uri;

                            // Get local file path
                            localFile = Path.Combine(localPath, Uri.UnescapeDataString(res.Uri.Substring(resTopFolder.Uri.Length)).Replace("/", @"\"));

                            // Check action
                            if (File.Exists(localFile))
                            {
                                if (File.GetLastWriteTime(localFile) < res.LastModifiedDate == true)
                                    syncAction = TweakDatabaseSyncAction.UpdatedFile;
                            }
                            else
                                syncAction = TweakDatabaseSyncAction.NewFile;

                            // Add to list
                            checkedFiles.Add(localFile);
                            if (syncAction is object)
                                syncFiles.Add(new TweakDatabaseSyncFile((TweakDatabaseSyncAction)syncAction, localFile, remoteFile));
                        }
                    }
                }
            };

            // Check for new & updated files
            await checkOutFolder(Preferences.CategoryPaths[TweakDatabaseCategories.Reviewed]);

            // Find all old files to remove
            if (responseSuccessfull)
            {
                var allLocalFiles = Directory.GetFiles(localPath, "*", SearchOption.AllDirectories);
                foreach (string lf in allLocalFiles)
                {
                    bool isKnown = false;
                    foreach (string checkedFile in checkedFiles)
                    {
                        if (!isKnown && (checkedFile ?? "") == (lf ?? ""))
                            isKnown = true;
                    }

                    if (!isKnown)
                        syncFiles.Add(new TweakDatabaseSyncFile(TweakDatabaseSyncAction.RemovedFile, lf, string.Empty));
                }
            }

            return syncFiles;
        }

        public async Task Update(IEnumerable<TweakDatabaseSyncFile> syncFiles)
        {
            var client = CreateClient(TweakDatabaseLoginTypes.ReadOnlyAll);
            foreach (TweakDatabaseSyncFile syncFile in syncFiles)
            {
                if (syncFile.SyncAction == TweakDatabaseSyncAction.UpdatedFile || syncFile.SyncAction == TweakDatabaseSyncAction.RemovedFile)
                {
                    File.Delete(syncFile.LocalFile);
                }

                if (syncFile.SyncAction == TweakDatabaseSyncAction.UpdatedFile || syncFile.SyncAction == TweakDatabaseSyncAction.NewFile)
                {
                    var response = await client.GetProcessedFile(syncFile.RemoteFile);
                    var dirParent = new DirectoryInfo(Path.GetDirectoryName(syncFile.LocalFile));
                    if (!dirParent.Exists)
                    {
                        dirParent.Create();
                    }

                    var fs = new FileStream(syncFile.LocalFile, FileMode.Create, FileAccess.Write);
                    response.Stream.CopyTo(fs);
                    fs.Close();
                }
            }
        }

        //public async Task<bool> Upload(string path)
        //{
        //    var client = CreateClient(TweakDatabaseLoginTypes.UserUploads);
        //    var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        //    var result = await client.PutFile(Path.GetFileName(path), fs);
        //    fs.Close();
        //    return result.IsSuccessful;
        //}

        //public async Task<bool> GetUploadInfo(uint uploadID)
        //{

        //}

        //private async Task<IEnumerable<uint>> GetAllUploadIDs()
        //{

        //}

        //private async Task<int> GetNewUploadID()
        //{

        //}
    }
}