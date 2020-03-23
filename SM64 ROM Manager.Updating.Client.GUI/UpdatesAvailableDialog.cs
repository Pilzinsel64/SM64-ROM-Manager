using System.Drawing;
using global::DevComponents.DotNetBar;
using SM64_ROM_Manager.Updating.GUIBase;

namespace SM64_ROM_Manager.Updating.Client.GUI
{
    internal partial class UpdatesAvailableDialog
    {
        public UpdatesAvailableDialog(Image appIcon, string curVersion, string curChannel, string curBuild, string newVersion, string newChannel, string newBuild, string changelog, bool installAsAdmin)
        {
            InitializeComponent();
            StyleManager.UpdateAmbientColors(this);
            if (installAsAdmin)
            {
                ButtonX_Install.Image = BaseFeatures.GetUacShieldImage();
            }

            PictureBox_AppIcon.Image = appIcon ?? Icon.ToBitmap();
            LabelX_CurrentVersion.Text = curVersion;
            LabelX_CurrentChannel.Text = curChannel;
            LabelX_CurrentBuild.Text = curBuild;
            LabelX_NewVersion.Text = newVersion;
            LabelX_NewChannel.Text = newChannel;
            LabelX_NewBuild.Text = newBuild;
            RichTextBoxEx_Changelog.Text = changelog;
        }
    }
}