#pragma warning disable CS0618 // Typ oder Element ist veraltet

using DevComponents.DotNetBar;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
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
        private WebView2 webViewCompatible1;
        private Uri navigateTo;

        public WebViewer(Uri uri)
        {
            navigateTo = uri;

            InitializeComponent();
            UpdateAmbientColors();

            webViewCompatible1 = new WebView2();
            webViewCompatible1.Dock = DockStyle.Fill;
            webViewCompatible1.Location = new Point(0, 0);
            webViewCompatible1.Name = "webViewCompatible1";
            webViewCompatible1.Size = new Size(784, 611);
            webViewCompatible1.TabIndex = 0;
            webViewCompatible1.Text = "webViewCompatible1";
            webViewCompatible1.ContentLoading += new EventHandler<CoreWebView2ContentLoadingEventArgs>(this.webViewCompatible1_ContentLoading);
            webViewCompatible1.NavigationCompleted += new EventHandler<CoreWebView2NavigationCompletedEventArgs>(this.webViewCompatible1_NavigationCompleted);
        }

        private string GetDocumentTitel()
        {
            return webViewCompatible1.CoreWebView2.DocumentTitle;
        }

        private void webViewCompatible1_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            Text = GetDocumentTitel();
        }

        private void webViewCompatible1_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
        {
        }

        private void WebViewer_Shown(object sender, EventArgs e)
        {
            Controls.Add(webViewCompatible1);
            webViewCompatible1.NavigateToString(navigateTo.ToString());
        }

        private void WebViewer_Load(object sender, EventArgs e)
        {
        }
    }
}

#pragma warning restore CS0618 // Typ oder Element ist veraltet
