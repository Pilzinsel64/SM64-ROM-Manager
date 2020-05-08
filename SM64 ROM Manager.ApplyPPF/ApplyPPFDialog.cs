using System;
using System.Diagnostics;
using global::System.IO;
using global::System.Reflection;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::SM64_ROM_Manager.ApplyPPF.My.Resources;
using global::SM64_ROM_Manager.Publics;
using global::SM64_ROM_Manager.SettingsManager;

namespace SM64_ROM_Manager.ApplyPPF
{
    public partial class ApplyPPFDialog
    {
        private string romFile = string.Empty;
        private string patchFile = string.Empty;

        public ApplyPPFDialog()
        {
            if (Assembly.GetExecutingAssembly() == Assembly.GetEntryAssembly())
            {
                Settings.SettingsConfigFilePath = Path.Combine(General.MyDataPath, "Settings.json");
                StyleManager.Style = eStyle.Metro;
                StyleManager.MetroColorGeneratorParameters = Settings.StyleManager.MetroColorParams;
            }

            InitializeComponent();
        }

        public ApplyPPFDialog(string romFile, string patchFile) : this()
        {
            this.romFile = romFile;
            this.patchFile = patchFile;
            UpdateSafeFileNames();
        }

        private void UpdateSafeFileNames()
        {
            LabelX3.Text = !string.IsNullOrEmpty(romFile) ? Path.GetFileName(romFile) : ApplyPPFTranslation.Text_NoFileLoaded;
            LabelX4.Text = !string.IsNullOrEmpty(patchFile) ? Path.GetFileName(patchFile) : ApplyPPFTranslation.Text_NoFileLoaded;
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            ApplyPPF(romFile, patchFile, CheckBoxX1.Checked);
        }

        private void ApplyPPF(string romFile, string patchFile, bool updateChecksum)
        {
            try
            {
                var p = new Process();
                p.StartInfo.FileName = Path.Combine(Application.StartupPath, @"Data\Tools\ApplyPPF3.exe");
                p.StartInfo.Arguments = $"a \"{romFile}\" \"{patchFile}\"";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.ErrorDialog = true;
                p.Start();
                SetEnabled(false);
                while (!p.HasExited)
                    Application.DoEvents();
                if (updateChecksum)
                {
                    SM64Lib.General.PatchClass.UpdateChecksum(romFile);
                }

                MessageBoxEx.Show(this, ApplyPPFTranslation.MsgBox_Success, ApplyPPFTranslation.MsgBox_Success_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBoxEx.Show(this, ApplyPPFTranslation.MsgBox_FileNotFound, ApplyPPFTranslation.MsgBox_FileNotFound_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBoxEx.Show(this, ApplyPPFTranslation.MsgBox_UnkownError, ApplyPPFTranslation.MsgBox_UnkownError_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetEnabled(true);
            }
        }

        private void SetEnabled(bool value)
        {
            CircularProgress1.IsRunning = !value;
            CircularProgress1.Visible = !value;
            ButtonX1.Visible = value;
            ButtonX2.Enabled = value;
            ButtonX3.Enabled = value;
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "SM64 ROMs (*.z64)|*.z64|All files|*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                romFile = ofd.FileName;
                UpdateSafeFileNames();
            }
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "PPF Patch (*.ppf)|*.ppf|All files|*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                patchFile = ofd.FileName;
                UpdateSafeFileNames();
            }
        }

        private void TextBoxX1_TextChanged(object sender, EventArgs e)
        {
            ButtonX1.Enabled = !string.IsNullOrEmpty(romFile) && !string.IsNullOrEmpty(patchFile);
        }
    }
}