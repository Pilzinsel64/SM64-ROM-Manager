using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class UpdateServerInfoEditor : OfficeForm
    {
        public UpdateServerInfoEditor()
        {
            InitializeComponent();
            UpdateAmbientColors();
        }

        private void UpdateServerInfoEditor_Shown(object sender, EventArgs e)
        {
            TextBoxX_ServerAddress.Text = ProjectConfig.Current.UpdateServerInfo.ServerAdress;
            TextBoxX_PublicBaseURL.Text = ProjectConfig.Current.UpdateServerInfo.PublicPackageBaseURL;
            TextBoxX_PackageInfoFilename.Text = ProjectConfig.Current.UpdateServerInfo.UpdateInfoFilename;
            TextBoxX_Username.Text = ProjectConfig.Current.UpdateServerInfo.Username;
            TextBoxX_Password.Text = ProjectConfig.Current.UpdateServerInfo.Password;
        }

        private void ButtonX_OK_Click(object sender, EventArgs e)
        {
            ProjectConfig.Current.UpdateServerInfo.ServerAdress = TextBoxX_ServerAddress.Text.Trim();
            ProjectConfig.Current.UpdateServerInfo.PublicPackageBaseURL  = TextBoxX_PublicBaseURL.Text.Trim();
            ProjectConfig.Current.UpdateServerInfo.UpdateInfoFilename = TextBoxX_PackageInfoFilename.Text.Trim();
            ProjectConfig.Current.UpdateServerInfo.Username = TextBoxX_Username.Text.Trim();
            ProjectConfig.Current.UpdateServerInfo.Password = TextBoxX_Password.Text;
        }
    }
}
