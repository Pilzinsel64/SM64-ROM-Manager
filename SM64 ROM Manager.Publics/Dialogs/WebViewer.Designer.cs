#pragma warning disable CS0618 // Typ oder Element ist veraltet

namespace SM64_ROM_Manager.Publics
{
    partial class WebViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebViewer));
            this.webViewCompatible1 = new Microsoft.Toolkit.Forms.UI.Controls.WebViewCompatible();
            this.SuspendLayout();
            // 
            // webViewCompatible1
            // 
            this.webViewCompatible1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewCompatible1.Location = new System.Drawing.Point(0, 0);
            this.webViewCompatible1.Name = "webViewCompatible1";
            this.webViewCompatible1.Size = new System.Drawing.Size(784, 611);
            this.webViewCompatible1.TabIndex = 0;
            this.webViewCompatible1.Text = "webViewCompatible1";
            this.webViewCompatible1.ContentLoading += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlContentLoadingEventArgs>(this.webViewCompatible1_ContentLoading);
            this.webViewCompatible1.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.webViewCompatible1_NavigationCompleted);
            // 
            // WebViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.webViewCompatible1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Toolkit.Forms.UI.Controls.WebViewCompatible webViewCompatible1;
    }
}

#pragma warning restore CS0618 // Typ oder Element ist veraltet
