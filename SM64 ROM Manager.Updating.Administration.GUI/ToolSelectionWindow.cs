using System;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class ToolSelectionWindow
    {
        public ToolSelectionWindow()
        {
            InitializeComponent();
        }

        private void ShowEditorWindow(byte mode)
        {
            switch (mode)
            {
                case 0:
                    {
                        My.MyProject.Forms.EditorWindow.InitVersionInfoEditor();
                        break;
                    }

                case 1:
                    {
                        My.MyProject.Forms.EditorWindow.InitPackageEditor();
                        break;
                    }
            }

            My.MyProject.Forms.EditorWindow.Show();
            Close();
        }

        private void ButtonX_OpenUpdateInfoManager_Click(object sender, EventArgs e)
        {
            ShowEditorWindow(0);
        }

        private void ButtonX_OpenUpdatePackageEditor_Click(object sender, EventArgs e)
        {
            ShowEditorWindow(1);
        }
    }
}