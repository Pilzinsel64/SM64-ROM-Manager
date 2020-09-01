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
            TextBoxX_ServerAddress.Text = General.CurProject.UpdateServerConfig.ServerAdress;
            TextBoxX_PublicBaseURL.Text = General.CurProject.UpdateServerConfig.PublicPackageBaseURL;
            TextBoxX_PackageInfoFilename.Text = General.CurProject.UpdateServerConfig.UpdateInfoFilename;
            TextBoxX_Username.Text = General.CurProject.UpdateServerConfig.Username;
            TextBoxX_Password.Text = General.CurProject.UpdateServerConfig.Password;
            switchButton_UseProxyForWebDAV.Value = General.CurProject.UpdateServerConfig.UseProxyForWebDAV;
        }

        private void ButtonX_OK_Click(object sender, EventArgs e)
        {
            General.CurProject.UpdateServerConfig.ServerAdress = TextBoxX_ServerAddress.Text.Trim();
            General.CurProject.UpdateServerConfig.PublicPackageBaseURL  = TextBoxX_PublicBaseURL.Text.Trim();
            General.CurProject.UpdateServerConfig.UpdateInfoFilename = TextBoxX_PackageInfoFilename.Text.Trim();
            General.CurProject.UpdateServerConfig.Username = TextBoxX_Username.Text.Trim();
            General.CurProject.UpdateServerConfig.Password = TextBoxX_Password.Text;
            General.CurProject.UpdateServerConfig.UseProxyForWebDAV = switchButton_UseProxyForWebDAV.Value;
        }
    }
}
