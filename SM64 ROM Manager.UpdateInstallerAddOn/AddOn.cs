using global::System.IO;
using global::SM64_ROM_Manager.Updating.UpdateInstaller;

namespace UpdateInstaller
{
    public static class AddOn
    {
        public static void Main(UpdateInstallerConfig config, bool isAfterCopyFiles)
        {
            if (!isAfterCopyFiles /*&& config.NewApplicationVersion is null && config.CurrentApplicationVersion is null*/)
            {
                Directory.Delete(Path.Combine(config.HostApplicationPath, @"Data\Importer Presets"), true);
                Directory.Delete(Path.Combine(config.HostApplicationPath, @"Data\Custom Objects\Reviewed"), true);
                Directory.Delete(Path.Combine(config.HostApplicationPath, @"Data\Tweaks\Reviewed"), true);
            }
        }
    }
}