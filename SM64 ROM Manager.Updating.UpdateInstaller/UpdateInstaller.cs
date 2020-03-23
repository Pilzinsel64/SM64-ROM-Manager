using System;
using System.Diagnostics;
using global::System.IO;
using global::System.IO.Compression;
using System.Linq;
using global::System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.UpdateInstaller
{
    internal class UpdateInstaller
    {

        // E v e n t s

        public event StatusChangesEventHandler StatusChanges;

        public delegate void StatusChangesEventHandler(object sender, UpdateInstallerStatusChangedEventArgs e);

        // F i e l d s

        private string dataPath = string.Empty;

        // P r o p e r t i e s

        public UpdateInstallerConfig Configuration { get; private set; }

        // C o n s t r c u t o r s

        public UpdateInstaller(UpdateInstallerConfig config)
        {
            Configuration = config;
        }

        // F e a t u r e s

        private void ChangeStatus(UpdateInstallerStatus newStatus)
        {
            StatusChanges?.Invoke(this, new UpdateInstallerStatusChangedEventArgs(newStatus));
        }

        public void StartHostApplication()
        {
            if (!string.IsNullOrEmpty(Conversions.ToString(Configuration.RestartHostApplication)) && File.Exists(Configuration.HostApplicationProcessPath))
            {
                Process.Start(Configuration.HostApplicationProcessPath, Configuration.RestartHostApplicationArguments);
            }
        }

        public void InstallUpdate()
        {
            // Extract Package
            ChangeStatus(UpdateInstallerStatus.Extracting);
            ExtractPackage();

            // Install Package
            InstallPackage();

            // Delete Package
            ChangeStatus(UpdateInstallerStatus.RemovingFiles);
            DeletePackage();

            // Finish
            ChangeStatus(UpdateInstallerStatus.Done);
        }

        public void WaitForHostApplication()
        {
            bool forcedKill = false;
            bool enabled = true;
            var stw = new Stopwatch();
            stw.Start();
            Process[] getProcesses() => Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Configuration.HostApplicationProcessPath));
            while (enabled)
            {
                if (getProcesses().Any())
                {
                    if (stw.ElapsedMilliseconds >= Configuration.MillisecondsToWaitForHostApplicationToClose)
                    {
                        if (!forcedKill && Configuration.ForceClosingHostApplication)
                        {
                            foreach (Process p in getProcesses())
                                p.Kill();
                            stw.Reset();
                            forcedKill = true;
                        }
                        else
                        {
                            stw.Stop();
                            enabled = false;
                        }
                    }
                }
                else
                {
                    enabled = false;
                }
            }
        }

        private void ExtractPackage()
        {
            string packagePath = Configuration.PackagePath;
            string zipPath = Path.Combine(packagePath, PackageFileNameDefinations.ZIP_PACKAGE_FILENAME);
            dataPath = Path.Combine(packagePath, Path.GetFileNameWithoutExtension(PackageFileNameDefinations.ZIP_PACKAGE_FILENAME));
            var dataPathDir = new DirectoryInfo(dataPath);
            if (dataPathDir.Exists)
            {
                dataPathDir.Delete(true);
                Task.Delay(100);
            }

            ZipFile.ExtractToDirectory(zipPath, dataPath);
        }

        private void InstallPackage()
        {
            // Copy files
            ChangeStatus(UpdateInstallerStatus.CopyingFiles);
            CopyFiles();

            // Run installation addon
            ChangeStatus(UpdateInstallerStatus.RunningAddons);
            RunAddOns();
        }

        private void CopyFiles()
        {
            var sourceDir = new DirectoryInfo(Path.Combine(dataPath, PackageFileNameDefinations.ZIP_APP_DATA_FILES_DIRECTORY));
            var destDir = new DirectoryInfo(Configuration.HostApplicationPath);
            CopyFiles(sourceDir, destDir);
        }

        private void CopyFiles(DirectoryInfo sourceDir, DirectoryInfo destinationDir)
        {
            if (!destinationDir.Exists)
            {
                destinationDir.Create();
            }

            foreach (FileInfo sFile in sourceDir.EnumerateFiles("*", SearchOption.TopDirectoryOnly))
            {
                var dFile = new FileInfo(Path.Combine(destinationDir.FullName, sFile.Name));
                try
                {
                    sFile.CopyTo(dFile.FullName, true);
                }
                catch (Exception)
                {
                }
            }

            foreach (DirectoryInfo sDir in sourceDir.EnumerateDirectories("*", SearchOption.TopDirectoryOnly))
            {
                var dDir = destinationDir.CreateSubdirectory(sDir.Name);
                CopyFiles(sDir, dDir);
            }
        }

        private void RunAddOns()
        {
            foreach (string addOnPath in Directory.GetFiles(Path.Combine(General.MyAppPath, "AddOns"))) // Directory.GetFiles(Path.Combine(dataPath, ZIP_UPDATE_INSTALLER_ADDONS_DIRECTORY))
            {
                var asm = Assembly.LoadFile(addOnPath);
                var t = asm.GetType($"{UpdateInstallerAddOnNameDefinitions.UPDATE_INSTALLER_ADDON_NAMESPACE}.{UpdateInstallerAddOnNameDefinitions.UPDATE_INSTALLER_ADDON_TYPE}", false);
                if (t is object)
                {
                    var m = t.GetMethod(UpdateInstallerAddOnNameDefinitions.UPDATE_INSTALLER_ADDON_METHOD, BindingFlags.Static | BindingFlags.Public);
                    m.Invoke(null, new[] { Configuration });
                }
            }
        }

        private void DeletePackage()
        {
            Directory.Delete(Configuration.PackagePath, true);
        }
    }
}