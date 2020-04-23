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

namespace SM64_ROM_Manager.ProgressUpdater
{
    public partial class WebDavSettingsDialog : OfficeForm
    {
        private readonly Settings settings;

        public WebDavSettingsDialog(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();


            // Load TextBoxes
            TextBoxX_ProxUsr.Text = settings.ProxyUsr;
            TextBoxX_ProxPwd.Text = settings.ProxyPwd;
            TextBoxX_WebDavUploadUri.Text = settings.WebDavUri;
            TextBoxX_WebDavUploadUsr.Text = settings.WebDavUsr;
            TextBoxX_WebDavUploadPwd.Text = settings.WebDavPwd;
        }

        private void TextBoxX_WebDavUploadUri_TextChanged(object sender, EventArgs e)
        {
            settings.WebDavUri = TextBoxX_WebDavUploadUri.Text.Trim();
        }

        private void TextBoxX_WebDavUploadUsr_TextChanged(object sender, EventArgs e)
        {
            settings.WebDavUsr = TextBoxX_WebDavUploadUsr.Text.Trim();
        }

        private void TextBoxX_WebDavUploadPwd_TextChanged(object sender, EventArgs e)
        {
            settings.WebDavPwd = TextBoxX_WebDavUploadPwd.Text;
        }

        private void TextBoxX_ProxUsr_TextChanged(object sender, EventArgs e)
        {
            settings.ProxyUsr = TextBoxX_ProxUsr.Text.Trim();
        }

        private void TextBoxX_ProxPwd_TextChanged(object sender, EventArgs e)
        {
            settings.ProxyPwd = TextBoxX_ProxPwd.Text;
        }
    }
}
