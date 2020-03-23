using System;
using System.Diagnostics;

namespace SM64_ROM_Manager
{
    public partial class Form_About
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void PictureBox_Donate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BCA34KB48SNRG&source=url");
        }
    }
}