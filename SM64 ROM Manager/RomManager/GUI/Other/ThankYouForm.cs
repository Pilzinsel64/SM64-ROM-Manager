using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class ThankYouForm
    {
        public ThankYouForm()
        {
            this.Load += ThankYouForm_Load;
            InitializeComponent();
        }

        private const string WebAddress = "https://pilzinsel64.com/thank-you.html";
        private bool loaded = false;

        private void ThankYouForm_Load(object sender, EventArgs e)
        {
            WebBrowser1.Url = new Uri(WebAddress);
            WebBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            loaded = true;
        }

        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (loaded && (e.Url.ToString() ?? "") != WebAddress)
            {
                e.Cancel = true;
                Process.Start(e.Url.ToString());
            }
        }
    }
}