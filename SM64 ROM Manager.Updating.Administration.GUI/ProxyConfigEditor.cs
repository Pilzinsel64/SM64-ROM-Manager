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
    public partial class ProxyConfigEditor : OfficeForm
    {
        private readonly ProxyConfiguration config = null;

        public ProxyConfigEditor(ProxyConfiguration config)
        {
            this.config = config;
            InitializeComponent();
            UpdateAmbientColors();
        }

        private void UpdateServerInfoEditor_Shown(object sender, EventArgs e)
        {
            switchButton_UseProxyAuth.Value = config.UseProxyAuth;
            TextBoxX_ProxyUsr.Text = config.Username;
            TextBoxX_ProxyPW.Text = config.Password ?? string.Empty;
        }

        private void ButtonX_OK_Click(object sender, EventArgs e)
        {
            config.UseProxyAuth = switchButton_UseProxyAuth.Value;
            config.Username = TextBoxX_ProxyUsr.Text.Trim();
            config.Password = TextBoxX_ProxyPW.Text;
        }
    }
}
