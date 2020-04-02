using global::System.IO;
using global::SM64_ROM_Manager.Updating.UpdateInstaller;

namespace UpdateInstaller
{
    public static class AddOn
    {
        public static void Main(UpdateInstallerConfig config, bool isAfterCopyFiles)
        {
            if (!isAfterCopyFiles && config.NewApplicationVersion is null && config.CurrentApplicationVersion is null)
            {
                foreach (string dir in Directory.GetDirectories(Path.Combine(config.HostApplicationPath, @"Data\Tweaks")))
                {
                    if (Path.GetFileName(dir) == "Reviewed")
                        Directory.Delete(dir, true);
                }
            }
        }
    }
}