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

        private void ShowEditorWindow(byte mode)
        {
            switch (mode)
            {
                case 0:
                    My.MyProject.Forms.EditorWindow.InitVersionInfoEditor();
                    break;
                case 1:
                    My.MyProject.Forms.EditorWindow.InitPackageEditor();
                    break;
            }

            My.MyProject.Forms.EditorWindow.Show();
            ButtonX_Einstellungen.Enabled = false;
        }

        private void ButtonX_OpenUpdateInfoManager_Click(object sender, EventArgs e)
        {
            ShowEditorWindow(0);
        }

        private void ButtonX_OpenUpdatePackageEditor_Click(object sender, EventArgs e)
        {
            ShowEditorWindow(1);
        }

        private void ButtonX_Einstellungen_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UpdateServerInfoEditor.ShowDialog();
            ProjectConfig.Current.Save(curProjectFilePath);
        }

        private void ButtonX_NewProject_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                curProjectFilePath = sfd.FileName;
                ProjectConfig.Current = new ProjectConfig();
                ProjectConfig.Current.Save(curProjectFilePath);
                LabelX_CurProject.Text = curProjectFilePath;
                TableLayoutPanel1.Enabled = true;
            }            
        }

        private void ButtonX_LoadProject_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "Update Project Files (*.upa)|*.upa"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
                LoadProject(ofd.FileName);
        }

        private void LoadProject(string filePath)
        {
            curProjectFilePath = filePath;
            ProjectConfig.Current = ProjectConfig.Load(filePath);
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