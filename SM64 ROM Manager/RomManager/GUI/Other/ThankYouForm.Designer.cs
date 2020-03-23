using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ThankYouForm : DevComponents.DotNetBar.OfficeForm
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ThankYouForm));
            _WebBrowser1 = new WebBrowser();
            _WebBrowser1.Navigating += new WebBrowserNavigatingEventHandler(WebBrowser1_Navigating);
            SuspendLayout();
            // 
            // WebBrowser1
            // 
            _WebBrowser1.Dock = DockStyle.Fill;
            _WebBrowser1.Location = new Point(0, 0);
            _WebBrowser1.MinimumSize = new Size(20, 20);
            _WebBrowser1.Name = "WebBrowser1";
            _WebBrowser1.Size = new Size(1234, 711);
            _WebBrowser1.TabIndex = 0;
            _WebBrowser1.Url = new Uri("", UriKind.Relative);
            // 
            // ThankYouForm
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 711);
            Controls.Add(_WebBrowser1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThankYouForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thank You!";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ResumeLayout(false);
        }

        private WebBrowser _WebBrowser1;

        internal WebBrowser WebBrowser1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _WebBrowser1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_WebBrowser1 != null)
                {
                    _WebBrowser1.Navigating -= WebBrowser1_Navigating;
                }

                _WebBrowser1 = value;
                if (_WebBrowser1 != null)
                {
                    _WebBrowser1.Navigating += WebBrowser1_Navigating;
                }
            }
        }
    }
}