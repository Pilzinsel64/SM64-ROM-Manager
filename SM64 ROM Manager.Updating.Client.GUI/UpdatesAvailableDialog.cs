using System.Drawing;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using SM64_ROM_Manager.Updating.GUIBase;

namespace SM64_ROM_Manager.Updating.Client.GUI
{
    internal partial class UpdatesAvailableDialog
    {
        public UpdatesAvailableDialog(Image appIcon, string curVersion, string curChannel, string curBuild, string newVersion, string newChannel, string newBuild, UpdateNotes updateNotes, bool installAsAdmin)
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

            // Update Notes
            Control updateNotesControl = null;
            switch (updateNotes.ContentType)
            {
                case UpdateNotesContentType.PlainText:
                    updateNotesControl = new DevComponents.DotNetBar.Controls.RichTextBoxEx
                    {
                        Text = updateNotes.Content
                    };
                    break;
                case UpdateNotesContentType.Markdown:
                    updateNotesControl = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel
                    {
                        Text = CommonMark.CommonMarkConverter.Convert(updateNotes.Content)
                    };
                    break;
                case UpdateNotesContentType.HTML:
                    updateNotesControl = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel
                    {
                        Text = updateNotes.Content
                    };
                    break;
            }
            if (updateNotesControl is object)
            {
                updateNotesControl.Dock = DockStyle.Fill;
                Panel_Changelog.Controls.Add(updateNotesControl);
            }
        }
    }
}