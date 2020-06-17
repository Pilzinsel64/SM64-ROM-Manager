using global::System.ComponentModel;
using System.Drawing;
using global::System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.Updating.Client.GUI.My.Resources;
using System;

namespace SM64_ROM_Manager.Updating.Client.GUI
{
    public class UpdateClientGUI
    {

        // F i e l d s

        private Form parentForm;
        private UpdateClient _UpdateClient;

        private UpdateClient UpdateClient
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UpdateClient;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UpdateClient != null)
                {

                    // U p d a t e C l i e n t - E v e n t s

                    _UpdateClient.UpdateStatusChanged -= MyUpdateClient_UpdateStatusChanged;
                    _UpdateClient.DownloadingUpdate -= MyUpdateClient_DownloadingUpdate;
                    _UpdateClient.InstallingUpdate -= MyUpdateClient_InstallingUpdate;
                    _UpdateClient.UpdateInstallerStarted -= MyUpdateClient_FinishWork;
                    _UpdateClient.NoUpdatesFound -= MyUpdateClient_NoUpdatesFound;
                }

                _UpdateClient = value;
                if (_UpdateClient != null)
                {
                    _UpdateClient.UpdateStatusChanged += MyUpdateClient_UpdateStatusChanged;
                    _UpdateClient.DownloadingUpdate += MyUpdateClient_DownloadingUpdate;
                    _UpdateClient.InstallingUpdate += MyUpdateClient_InstallingUpdate;
                    _UpdateClient.UpdateInstallerStarted += MyUpdateClient_FinishWork;
                    _UpdateClient.NoUpdatesFound += MyUpdateClient_NoUpdatesFound;
                }
            }
        }

        private SimpleActionDialog curProgressDialog = null;

        // P r o p e r t i e s

        public bool UseHiddenSearch { get; set; } = false;

        private Image MyAppIcon
        {
            get
            {
                return Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location).ToBitmap();
            }
        }

        // C o n s t r u c t o r s

        public UpdateClientGUI(UpdateClient updateClient)
        {
            UpdateClient = updateClient;
        }

        // F e a t u r e s

        public void UpdateInteractive(Form parentForm)
        {
            this.parentForm = parentForm;
            UpdateClient.UpdateInteractiveAsync();
        }

        private void EndUpdating()
        {
            curProgressDialog?.Invoke(new Action(() => curProgressDialog.Close()));
            UpdateClient = null;
        }

        private void MyUpdateClient_UpdateStatusChanged(UpdateStatus newStatus, int progress)
        {
            bool useGui = false;
            if (!(newStatus == UpdateStatus.Searching && UseHiddenSearch))
            {
                useGui = true;
            }

            if (useGui && curProgressDialog is null)
            {
                parentForm.Invoke(new Action(() =>
                {
                    curProgressDialog = new SimpleActionDialog();
                    curProgressDialog.SetCurrentState(UpdateStatus.Waiting);
                    curProgressDialog.Show(parentForm);
                }));
            }

            curProgressDialog?.Invoke(new Action(() => curProgressDialog.SetCurrentState(newStatus, progress)));
        }

        private void MyUpdateClient_DownloadingUpdate(UpdatePackageInfo pkg, CancelEventArgs e)
        {
            curProgressDialog?.Invoke(new Action(() => curProgressDialog.Hide()));
            var dres = default(DialogResult);
            parentForm.Invoke(new Action(() =>
            {
                var dialog = new UpdatesAvailableDialog(MyAppIcon, UpdateClient.CurrentVersion.Version.ToString(), UpdateClient.CurrentVersion.Channel.ToString(), Conversions.ToString(UpdateClient.CurrentVersion.Build), pkg.Version.Version.ToString(), pkg.Version.Channel.ToString(), Conversions.ToString(pkg.Version.Build), pkg.Notes, UpdateClient.InstallAsAdmin);
                dres = dialog.ShowDialog(parentForm);
            }));
            if (dres != DialogResult.OK)
            {
                e.Cancel = true;
                EndUpdating();
            }
            else
            {
                e.Cancel = false;
                curProgressDialog?.Invoke(new Action(() => curProgressDialog.Show()));
            }
        }

        private void MyUpdateClient_InstallingUpdate(UpdatePackageInfo pkg, CancelEventArgs e)
        {
            e.Cancel = false;
        }

        private void MyUpdateClient_FinishWork()
        {
            EndUpdating();
        }

        private void MyUpdateClient_NoUpdatesFound()
        {
            EndUpdating();
            if (!UseHiddenSearch)
            {
                MessageBoxEx.Show(UpdatingClientGuiLangRes.MsgBox_NoUpdatesFound, UpdatingClientGuiLangRes.MsgBox_NoUpdatesFound_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}