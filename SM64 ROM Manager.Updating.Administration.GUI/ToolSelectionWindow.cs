using System;
using System.IO;
using System.Windows.Forms;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class ToolSelectionWindow
    {
        private string curProjectFilePath;

        public ToolSelectionWindow()
        {
            InitializeComponent();
        }

        private void ButtonX_OpenUpdateInfoManager_Click(object sender, EventArgs e)
        {
            //My.MyProject.Forms.UpdateServerInfoEditor.Show();
        }

        private void ButtonX_OpenUpdatePackageEditor_Click(object sender, EventArgs e)
        {
            //My.MyProject.Forms.PackageCreationDialog.Show();
        }

        private void ButtonX_Einstellungen_Click(object sender, EventArgs e)
        {
            //My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog();
            General.CurProject.Save(curProjectFilePath);
        }

        private void ButtonX_NewProject_Click(object sender, EventArgs e)
        {
            var sfd_updateadministration_upa = new SaveFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (sfd_updateadministration_upa.ShowDialog() == DialogResult.OK)
            {
                curProjectFilePath = sfd_updateadministration_upa.FileName;
                General.CurProject = new UpdateProject();
                General.CurProject.Save(curProjectFilePath);
                LabelX_CurProject.Text = curProjectFilePath;
                TableLayoutPanel1.Enabled = true;
            }            
        }

        private void ButtonX_LoadProject_Click(object sender, EventArgs e)
        {
            var ofd_updateadministration_upa = new OpenFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (ofd_updateadministration_upa.ShowDialog() == DialogResult.OK)
                LoadProject(ofd_updateadministration_upa.FileName);
        }

        private void LoadProject(string filePath)
        {
            curProjectFilePath = filePath;
            General.CurProject = UpdateProject.Load(filePath);
            LabelX_CurProject.Text = filePath;
            TableLayoutPanel1.Enabled = true;
        }

        private void ToolSelectionWindow_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                try
                {
                    LoadProject(args[1]);
                }
                catch (Exception) { }
            }
        }
    }
}