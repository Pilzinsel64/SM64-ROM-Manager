using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;

namespace SM64_ROM_Manager.Updating.UpdateInstaller
{
    public partial class Main
    {

        // C o n s t r u c t o r s

        public Main()
        {

            // G u i
            this.Shown += Main_Shown;
            this.FormClosed += Main_FormClosed;
            this.FormClosing += Main_FormClosing;

            // Get arguments
            var args = My.MyProject.Application.CommandLineArgs.ToArray();
            if (args.Any())
            {
                // Load config
                Installer = new UpdateInstaller(UpdateInstallerConfig.Parse(args[0]));

                // Init Form
                InitializeComponent();

                // Init Style
                StyleManager.Style = eStyle.Office2016;
                StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Installer.Configuration.UpdateWindowCanvasColor, Installer.Configuration.UpdateWindowBaseColor);
                StyleManager.UpdateAmbientColors(this);

                // Init Application Header Text
                string header;
                if (!string.IsNullOrEmpty(Installer.Configuration.ApplicationName))
                {
                    header = string.Format(My.Resources.UpdateInstallerGuiLangRes.String_UpdatingApplicationX, Installer.Configuration.ApplicationName);
                }
                else
                {
                    header = My.Resources.UpdateInstallerGuiLangRes.String_UpdateIsRunning;
                }

                LabelX_Header.Text = $"<div align=\"center\" valign=\"center\"><font color=\"#B7472A\" size=\"20\"><b>{header}</b></font></div>";
            }

            if (Installer is null)
                Environment.Exit(0);
        }

        // F i e l d s

        private bool allowClose = false;
        private UpdateInstaller _Installer;

        private UpdateInstaller Installer
        {
            get
            {
                return _Installer;
            }
            set
            {
                if (_Installer != null)
                {
                    _Installer.StatusChanges -= Installer_StatusChanges;
                }

                _Installer = value;
                if (_Installer != null)
                {
                    _Installer.StatusChanges += Installer_StatusChanges;
                }
            }
        }

        // F e a t u r e s

        private void SetStatus(UpdateInstallerStatus newStatus)
        {
            string newStatusText = string.Empty;
            switch (newStatus)
            {
                case UpdateInstallerStatus.CopyingFiles:
                    {
                        newStatusText = My.Resources.UpdateInstallerGuiLangRes.Status_CopyingFiles;
                        break;
                    }

                case UpdateInstallerStatus.Done:
                    {
                        newStatusText = My.Resources.UpdateInstallerGuiLangRes.Status_Done;
                        break;
                    }

                case UpdateInstallerStatus.Extracting:
                    {
                        newStatusText = My.Resources.UpdateInstallerGuiLangRes.Status_Extracting;
                        break;
                    }

                case UpdateInstallerStatus.RunningAddons:
                    {
                        newStatusText = My.Resources.UpdateInstallerGuiLangRes.Status_RunningAddOns;
                        break;
                    }

                case UpdateInstallerStatus.RemovingFiles:
                    {
                        newStatusText = My.Resources.UpdateInstallerGuiLangRes.Status_RemovingFiles;
                        break;
                    }

                case UpdateInstallerStatus.Waiting:
                    {
                        newStatusText = My.Resources.UpdateInstallerGuiLangRes.Status_Waiting;
                        break;
                    }
            }

            LabelX_Status.Text = newStatusText;
            //if (newStatus == UpdateInstallerStatus.Done)
            //{
            //    allowClose = true;
            //    Close();
            //}
        }

        private async Task WaitforHostApp()
        {
            SetStatus(UpdateInstallerStatus.Waiting);
            await Task.Run(() => Installer.WaitForHostApplication());
        }

        private async void ExecuteUpdate()
        {
            await Task.Run(() => Installer.InstallUpdate());
            allowClose = true;
            Close();
        }

        private async void Main_Shown(object sender, EventArgs e)
        {
            await WaitforHostApp();
            ExecuteUpdate();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Installer.StartHostApplication();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !allowClose;
        }

        private void Installer_StatusChanges(object sender, UpdateInstallerStatusChangedEventArgs e)
        {
            base.Invoke(new Action(() => SetStatus(e.NewStatus)));
        }
    }
}