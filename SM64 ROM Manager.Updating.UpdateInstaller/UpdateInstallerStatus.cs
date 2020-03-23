
namespace SM64_ROM_Manager.Updating.UpdateInstaller
{
    internal enum UpdateInstallerStatus
    {
        Waiting,
        Extracting,
        CopyingFiles,
        RunningAddons,
        RemovingFiles,
        Done
    }
}