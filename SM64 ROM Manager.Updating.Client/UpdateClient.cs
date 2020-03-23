using System;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Diagnostics;
using global::System.Drawing;
using global::System.IO;
using global::System.IO.Compression;
using System.Linq;
using global::System.Net;
using global::System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.Updating.UpdateInstaller;

namespace SM64_ROM_Manager.Updating
{
    public class UpdateClient
    {

        // E b v e n t s

        public event UpdateStatusChangedEventHandler UpdateStatusChanged;

        public delegate void UpdateStatusChangedEventHandler(UpdateStatus newStatus, int progress);

        public event DownloadingUpdateEventHandler DownloadingUpdate;

        public delegate void DownloadingUpdateEventHandler(UpdatePackageInfo pkg, CancelEventArgs e);

        public event InstallingUpdateEventHandler InstallingUpdate;

        public delegate void InstallingUpdateEventHandler(UpdatePackageInfo pkg, CancelEventArgs e);

        public event UpdateInstallerStartedEventHandler UpdateInstallerStarted;

        public delegate void UpdateInstallerStartedEventHandler();

        public event NoUpdatesFoundEventHandler NoUpdatesFound;

        public delegate void NoUpdatesFoundEventHandler();

        // F i e l d s

        private readonly Dictionary<UpdatePackageInfo, string> dicPackagePaths = new Dictionary<UpdatePackageInfo, string>();
        private UpdateStatus curDownloadingStatus = UpdateStatus.Waiting;

        // P r o p e r t i e s

        public WebClient WebClient { get; private set; } = new WebClient();
        public string UpdateUrl { get; private set; }
        public ApplicationVersion CurrentVersion { get; private set; }
        public Channels MinimumChannel { get; private set; }
        public UpdateInfo UpdateInfo { get; private set; } = null;
        public UpdatePackageInfo UpdatePackageInfo { get; private set; } = null;
        public bool AutoCloseHostApplication { get; set; } = false;
        public bool AutoRestartHostApplication { get; set; } = false;
        public string RestartHostApplicationArguments { get; set; }
        public string HostApplicationPath { get; set; } = string.Empty;
        public string ApplicationName { get; set; } = string.Empty;
        public bool InstallAsAdmin { get; set; } = false;
        public uint MillisecondsToWaitForHostApplicationToClose { get; set; } = 10000;
        public bool ForceClosingHostApplication { get; set; } = true;
        public Color UpdateWindowBaseColor { get; set; } = Color.FromArgb(unchecked((int)0xFFB7472A));
        public Color UpdateWindowCanvasColor { get; set; } = Color.FromArgb(unchecked((int)0xFFFFFFFF));

        // C o n s t r u c t o r s

        public UpdateClient(string updateUrl, ApplicationVersion currentVersion, Channels minimumChannel)
        {
            UpdateUrl = updateUrl;
            CurrentVersion = currentVersion;
            MinimumChannel = (Channels)Math.Max((int)minimumChannel, (int)currentVersion.Channel);
            WebClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
        }

        // E v e n t   M e t h o d s

        private bool RaiseDownloadingUpdate(UpdatePackageInfo pkg)
        {
            var e = new CancelEventArgs(false);
            DownloadingUpdate?.Invoke(pkg, e);
            return e.Cancel;
        }

        private bool RaiseInstallingUpdate(UpdatePackageInfo pkg)
        {
            var e = new CancelEventArgs(true);
            InstallingUpdate?.Invoke(pkg, e);
            return e.Cancel;
        }

        // W e b C l i e n t   E v e n t s

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            RaiseUpdateStatusChanged(curDownloadingStatus, e.ProgressPercentage);
        }

        // U p d a t e   R o u t i n e s

        public Task UpdateInteractiveAsync()
        {
            return Task.Run(UpdateInteractive);
        }

        public void UpdateInteractive()
        {
            var latestVersion = CheckForUpdate();
            if (latestVersion is null)
            {
                NoUpdatesFound?.Invoke();
            }
            else
            {
                UpdateInteractive(latestVersion);
            }
        }

        public void UpdateInteractive(UpdatePackageInfo package)
        {
            if (!RaiseDownloadingUpdate(package) && DownloadPackage(package))
            {
                if (!RaiseInstallingUpdate(package))
                {
                    InstallPackage(package);
                }
            }
        }

        public void RaiseUpdateStatusChanged(UpdateStatus newStatus, int progress = -1)
        {
            UpdateStatusChanged?.Invoke(newStatus, progress);
        }

        // F e a t u r e s

        public UpdateInfo GetUpdateInfo()
        {
            string str = WebClient.DownloadString(UpdateUrl);
            var info = UpdateInfo.Parse(str);
            return info;
        }

        public UpdatePackageInfo CheckForUpdate()
        {
            RaiseUpdateStatusChanged(UpdateStatus.Searching);
            UpdateInfo = GetUpdateInfo();
            if (UpdateInfo is object)
            {
                return CheckForUpdate(UpdateInfo);
            }
            else
            {
                return null;
            }
        }

        public UpdatePackageInfo CheckForUpdate(UpdateInfo updateInfo)
        {
            UpdatePackageInfo foundPkgInfo = null;
            var latestVersion = CurrentVersion;
            RaiseUpdateStatusChanged(UpdateStatus.Searching);
            foreach (UpdatePackageInfo pkgInfo in updateInfo.Packages)
            {
                if (pkgInfo.Version.Channel <= MinimumChannel && pkgInfo.Version > latestVersion)
                {
                    foundPkgInfo = pkgInfo;
                    latestVersion = pkgInfo.Version;
                }
            }

            UpdatePackageInfo = foundPkgInfo;
            return foundPkgInfo;
        }

        public bool DownloadPackage(UpdatePackageInfo package)
        {
            curDownloadingStatus = UpdateStatus.DownloadingPackage;
            RaiseUpdateStatusChanged(curDownloadingStatus);
            string dirPath = Path.Combine(MyPaths.GetMyAppDataPath(), Conversions.ToString(package.GetHashCode()));
            string zipPath = Path.Combine(dirPath, PackageFileNameDefinations.ZIP_PACKAGE_FILENAME);
            var dir = new DirectoryInfo(dirPath);
            try
            {
                // Ensure existing and empty directory for the Zip File
                if (dir.Exists)
                {
                    dir.Delete(true);
                }

                dir.Create();

                // Download zip package
                WebClient.DownloadFile(package.Packagelink, zipPath);

                // Remember path to package directory
                dicPackagePaths.Add(package, dirPath);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private FileInfo DownloadUpdateInstaller()
        {
            curDownloadingStatus = UpdateStatus.DownloadingInstaller;
            RaiseUpdateStatusChanged(curDownloadingStatus);

            // Ensure update installer path is empty
            var installerDirPath = new DirectoryInfo(Path.Combine(MyPaths.GetMyAppDataPath(), "UpdateInstallerTool"));
            if (installerDirPath.Exists)
            {
                installerDirPath.Delete(true);
            }

            Task.Delay(100);
            installerDirPath.Create();
            Task.Delay(100);

            // Download update installer zip
            string installerZipPath = Path.Combine(installerDirPath.FullName, "UpdatenInstaller.zip");
            WebClient.DownloadFile(UpdateInfo.UpdateInstallerLink, installerZipPath);

            // Extract update installer
            var installerExtractPath = installerDirPath.CreateSubdirectory("extracted");
            ZipFile.ExtractToDirectory(installerZipPath, installerExtractPath.FullName);
            File.Delete(installerZipPath);

            // Get UpdateInstaller.exe file
            return installerExtractPath.EnumerateFiles("*.exe").FirstOrDefault();
        }

        private void StartUpdateInstaller(string packagePath, string installerPath)
        {
            RaiseUpdateStatusChanged(UpdateStatus.StartingInstaller);

            // Create update settings
            var updateConfig = new UpdateInstallerConfig()
            {
                PackagePath = packagePath,
                RestartHostApplication = AutoRestartHostApplication,
                RestartHostApplicationArguments = AutoRestartHostApplication ? RestartHostApplicationArguments : string.Empty,
                ApplicationName = ApplicationName,
                HostApplicationPath = string.IsNullOrEmpty(HostApplicationPath) ? Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) : HostApplicationPath,
                HostApplicationProcessPath = Assembly.GetEntryAssembly().Location,
                MillisecondsToWaitForHostApplicationToClose = MillisecondsToWaitForHostApplicationToClose,
                ForceClosingHostApplication = ForceClosingHostApplication,
                UpdateWindowBaseColor = UpdateWindowBaseColor,
                UpdateWindowCanvasColor = UpdateWindowCanvasColor
            };

            // Start UpdateInstaller
            var procStartInfo = new ProcessStartInfo()
            {
                FileName = installerPath,
                Arguments = updateConfig.ToString(),
                UseShellExecute = false,
                Verb = InstallAsAdmin ? "runas" : string.Empty
            };
            Process.Start(procStartInfo);
            UpdateInstallerStarted?.Invoke();
        }

        public bool InstallPackage(UpdatePackageInfo package)
        {
            string packagePath = null;
            bool hasDownloaded = dicPackagePaths.TryGetValue(package, out packagePath);
            if (hasDownloaded)
            {
                // Download update installer
                var installerPath = DownloadUpdateInstaller();

                // Start update installer
                StartUpdateInstaller(packagePath, installerPath.FullName);

                // Close Host Application
                if (AutoCloseHostApplication)
                {
                    Environment.Exit(Environment.ExitCode);
                }
            }

            return hasDownloaded;
        }
    }
}