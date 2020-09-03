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
        public WebViewer(Uri uri)
        {
            InitializeComponent();
            UpdateAmbientColors();
            webViewCompatible1.Navigate(uri);
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
    }
}

#pragma warning restore CS0618 // Typ oder Element ist veraltet
