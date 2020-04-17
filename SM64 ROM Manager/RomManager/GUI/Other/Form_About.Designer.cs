using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class Form_About : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.PictureBox_Donate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Donate)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelX1
            // 
            resources.ApplyResources(this.LabelX1, "LabelX1");
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.LabelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // PictureBox_Donate
            // 
            resources.ApplyResources(this.PictureBox_Donate, "PictureBox_Donate");
            this.PictureBox_Donate.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Donate.Image = global::SM64_ROM_Manager.My.Resources.Resources.btn_donateCC_LG;
            this.PictureBox_Donate.Name = "PictureBox_Donate";
            this.PictureBox_Donate.TabStop = false;
            this.PictureBox_Donate.Click += new System.EventHandler(this.PictureBox_Donate_Click);
            // 
            // Form_About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureBox_Donate);
            this.Controls.Add(this.LabelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.ShowIcon = false;
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Donate)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.LabelX LabelX1;

        private PictureBox PictureBox_Donate;
    }
}