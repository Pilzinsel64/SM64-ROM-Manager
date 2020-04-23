using global::System.IO;
using global::System.IO.Compression;
using SM64_ROM_Manager.Updating.UpdateInstaller;
using Z.IO.Extensions;

namespace SM64_ROM_Manager.Updating.Administration.Packaging
{
    public class UpdatePackagePackager
    {
        public UpdatePackageTemplate UpdatePackageTemplate { get; set; }

        public UpdatePackagePackager(UpdatePackageTemplate updatePackageTemplate)
        {
            UpdatePackageTemplate = updatePackageTemplate;
        }

        public void Export(string exportPath)
        {
            string tempPath = MyPaths.GetMyAppDataPath();
            var packageDir = new DirectoryInfo(Path.Combine(tempPath, "UpdatePackageCreation"));

            // Ensure package directory exists and is empty
            if (packageDir.Exists)
                packageDir.Delete(true);
            packageDir.Create();

            // Copy local data to temp data directory
            var dataDir = packageDir.CreateSubdirectory(PackageFileNameDefinations.ZIP_APP_DATA_FILES_DIRECTORY);
            var localDataDir = new DirectoryInfo(UpdatePackageTemplate.FilesToCopyPath);
            localDataDir.CopyTo(dataDir.FullName, SearchOption.AllDirectories);

            // Copy all UpdateInstaller AddOns
            var addOnsDir = packageDir.CreateSubdirectory(PackageFileNameDefinations.ZIP_UPDATE_INSTALLER_ADDONS_DIRECTORY);
            uint curAddOnID = 0;
            foreach (string fAddOn in UpdatePackageTemplate.UpdateInstallerAddOns)
            {
                File.Copy(fAddOn, Path.Combine(addOnsDir.FullName, $"installer_addon_{curAddOnID}.dll"));
                curAddOnID += 1;
            }

            // Ensure destination file doesn't exist
            if (File.Exists(exportPath))
                File.Delete(exportPath);

            // Export to ZIP
            ZipFile.CreateFromDirectory(packageDir.FullName, exportPath);

            // Delete temp directory
            packageDir.Delete(true);
        }
    }
}