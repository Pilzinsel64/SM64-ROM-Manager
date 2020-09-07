#pragma warning disable CS0618 // Typ oder Element ist veraltet

using DevComponents.DotNetBar;
using Microsoft.Toolkit.Forms.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.Publics
{
    public partial class WebViewer : OfficeForm
    {
        private Microsoft.Toolkit.Forms.UI.Controls.WebViewCompatible webViewCompatible1;
        private Uri navigateTo;

        public WebViewer(Uri uri)
        {
            navigateTo = uri;

            InitializeComponent();
            UpdateAmbientColors();

            webViewCompatible1 = new WebViewCompatible();
            webViewCompatible1.Dock = DockStyle.Fill;
            webViewCompatible1.Location = new Point(0, 0);
            webViewCompatible1.Name = "webViewCompatible1";
            webViewCompatible1.Size = new Size(784, 611);
            webViewCompatible1.TabIndex = 0;
            webViewCompatible1.Text = "webViewCompatible1";
            webViewCompatible1.ContentLoading += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlContentLoadingEventArgs>(this.webViewCompatible1_ContentLoading);
            webViewCompatible1.NavigationCompleted += new EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.webViewCompatible1_NavigationCompleted);

        }

        private string GetDocumentTitel()
        {
            string title;

            if (webViewCompatible1.View is WebView)
            {
                var webView = webViewCompatible1.View as WebView;
                title = webView.DocumentTitle;
            }
            else if (webViewCompatible1.View is WebBrowser)
            {
                var webBrowser = webViewCompatible1.View as WebBrowser;
                title = webBrowser.DocumentTitle;
            }
            else
                title = string.Empty;

            return title;
        }

        private void webViewCompatible1_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            Text = GetDocumentTitel();
        }

        private void webViewCompatible1_ContentLoading(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlContentLoadingEventArgs e)
        {
        }

        private void WebViewer_Shown(object sender, EventArgs e)
        {
            Controls.Add(webViewCompatible1);
            webViewCompatible1.Navigate(navigateTo);
        }

        private void WebViewer_Load(object sender, EventArgs e)
        {
        }
    }
}

#pragma warning restore CS0618 // Typ oder Element ist veraltet
