
namespace SM64_ROM_Manager.PatchScripts
{
    public class TweakDatabaseSyncFile
    {
        public TweakDatabaseSyncAction SyncAction { get; private set; }
        public string LocalFile { get; private set; }
        public string RemoteFile { get; private set; }

        internal TweakDatabaseSyncFile(TweakDatabaseSyncAction syncAction, string localFile, string remoteFile)
        {
            SyncAction = syncAction;
            LocalFile = localFile;
            RemoteFile = remoteFile;
        }
    }
}