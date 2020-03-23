using global::System.IO;
using global::SM64_ROM_Manager.Updating.UpdateInstaller;

namespace UpdateInstaller
{
    public static class AddOn
    {
        public static void Main(UpdateInstallerConfig config)
        {
            if (config.NewApplicationVersion is null && config.CurrentApplicationVersion is null)
            {
                foreach (string dir in Directory.GetDirectories(Path.Combine(config.HostApplicationPath, @"Data\Tweaks")))
                {
                    if (Path.GetFileName(dir) != "Reviewed")
                    {
                        Directory.Delete(dir, true);
                    }
                }

                foreach (string dir in Directory.GetFiles(Path.Combine(config.HostApplicationPath, @"Data\Tweaks")))
                    File.Delete(dir);
            }
        }
    }
}