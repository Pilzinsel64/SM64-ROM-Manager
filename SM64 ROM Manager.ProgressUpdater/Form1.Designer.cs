using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ProgressUpdater
{
    [DesignerGenerated()]
    public partial class Form1 : DevComponents.DotNetBar.OfficeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ButtonX_PasteClipboard = new DevComponents.DotNetBar.ButtonX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ComboBoxEx_Version = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ButtonX_SetupWebDav = new DevComponents.DotNetBar.ButtonX();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.ButtonX_DiscordSetup = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Upload = new DevComponents.DotNetBar.ButtonX();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.StyleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ButtonX_PasteDocument = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.buttonX1);
            this.Panel1.Controls.Add(this.ButtonX_PasteDocument);
            this.Panel1.Controls.Add(this.ButtonX_PasteClipboard);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(694, 508);
            this.Panel1.TabIndex = 0;
            // 
            // ButtonX_PasteClipboard
            // 
            this.ButtonX_PasteClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_PasteClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_PasteClipboard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_PasteClipboard.Location = new System.Drawing.Point(562, 3);
            this.ButtonX_PasteClipboard.Name = "ButtonX_PasteClipboard";
            this.ButtonX_PasteClipboard.Size = new System.Drawing.Size(129, 23);
            this.ButtonX_PasteClipboard.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_PasteClipboard.TabIndex = 0;
            this.ButtonX_PasteClipboard.Text = "Paste from Clipboard";
            this.ButtonX_PasteClipboard.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location = new System.Drawing.Point(200, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(494, 508);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.ComboBoxEx_Version);
            this.Panel2.Controls.Add(this.ButtonX_SetupWebDav);
            this.Panel2.Controls.Add(this.circularProgress1);
            this.Panel2.Controls.Add(this.ButtonX_DiscordSetup);
            this.Panel2.Controls.Add(this.ButtonX_Upload);
            this.Panel2.Controls.Add(this.LabelX6);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(200, 508);
            this.Panel2.TabIndex = 1;
            // 
            // ComboBoxEx_Version
            // 
            this.ComboBoxEx_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxEx_Version.DisplayMember = "Text";
            this.ComboBoxEx_Version.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_Version.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_Version.FormattingEnabled = true;
            this.ComboBoxEx_Version.ItemHeight = 14;
            this.ComboBoxEx_Version.Location = new System.Drawing.Point(4, 91);
            this.ComboBoxEx_Version.Name = "ComboBoxEx_Version";
            this.ComboBoxEx_Version.Size = new System.Drawing.Size(193, 20);
            this.ComboBoxEx_Version.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_Version.TabIndex = 15;
            this.ComboBoxEx_Version.WatermarkText = "e.g. 1.2.0.0";
            this.ComboBoxEx_Version.TextChanged += new System.EventHandler(this.TextBoxX_Version_TextChanged);
            // 
            // ButtonX_SetupWebDav
            // 
            this.ButtonX_SetupWebDav.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_SetupWebDav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_SetupWebDav.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_SetupWebDav.Location = new System.Drawing.Point(3, 3);
            this.ButtonX_SetupWebDav.Name = "ButtonX_SetupWebDav";
            this.ButtonX_SetupWebDav.Size = new System.Drawing.Size(194, 23);
            this.ButtonX_SetupWebDav.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_SetupWebDav.TabIndex = 14;
            this.ButtonX_SetupWebDav.Text = "Setup WebDav Client";
            this.ButtonX_SetupWebDav.Click += new System.EventHandler(this.ButtonX_SetupWebDav_Click);
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(63, 217);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress1.SetVisibleStateOnStart = true;
            this.circularProgress1.SetVisibleStateOnStop = true;
            this.circularProgress1.Size = new System.Drawing.Size(75, 75);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 13;
            // 
            // ButtonX_DiscordSetup
            // 
            this.ButtonX_DiscordSetup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_DiscordSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_DiscordSetup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_DiscordSetup.Location = new System.Drawing.Point(3, 32);
            this.ButtonX_DiscordSetup.Name = "ButtonX_DiscordSetup";
            this.ButtonX_DiscordSetup.Size = new System.Drawing.Size(194, 23);
            this.ButtonX_DiscordSetup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_DiscordSetup.TabIndex = 12;
            this.ButtonX_DiscordSetup.Text = "Setup Discord Bot";
            this.ButtonX_DiscordSetup.Click += new System.EventHandler(this.ButtonX_DiscordSetup_Click);
            // 
            // ButtonX_Upload
            // 
            this.ButtonX_Upload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_Upload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Upload.Location = new System.Drawing.Point(3, 465);
            this.ButtonX_Upload.Name = "ButtonX_Upload";
            this.ButtonX_Upload.Size = new System.Drawing.Size(194, 40);
            this.ButtonX_Upload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Upload.TabIndex = 10;
            this.ButtonX_Upload.Text = "Upload";
            this.ButtonX_Upload.Click += new System.EventHandler(this.ButtonX_Upload_Click);
            // 
            // LabelX6
            // 
            this.LabelX6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX6.Location = new System.Drawing.Point(3, 61);
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Size = new System.Drawing.Size(194, 23);
            this.LabelX6.TabIndex = 1;
            this.LabelX6.Text = "Version:";
            // 
            // StyleManager1
            // 
            this.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(123))))));
            // 
            // ButtonX_PasteDocument
            // 
            this.ButtonX_PasteDocument.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_PasteDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_PasteDocument.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_PasteDocument.Location = new System.Drawing.Point(427, 3);
            this.ButtonX_PasteDocument.Name = "ButtonX_PasteDocument";
            this.ButtonX_PasteDocument.Size = new System.Drawing.Size(129, 23);
            this.ButtonX_PasteDocument.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_PasteDocument.TabIndex = 0;
            this.ButtonX_PasteDocument.Text = "Paste from Document";
            this.ButtonX_PasteDocument.Click += new System.EventHandler(this.ButtonX_PasteDocument_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(562, 32);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(129, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "Invert Image";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonX_Upload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 508);
            this.Controls.Add(this.Panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SM64RM Progress Updater";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel Panel1;


        private DevComponents.DotNetBar.StyleManager StyleManager1;


        private PictureBox PictureBox1;


        private Panel Panel2;


        private DevComponents.DotNetBar.ButtonX ButtonX_Upload;












        private DevComponents.DotNetBar.ButtonX ButtonX_PasteClipboard;



        private DevComponents.DotNetBar.LabelX LabelX6;
        private DevComponents.DotNetBar.ButtonX ButtonX_DiscordSetup;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.ButtonX ButtonX_SetupWebDav;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Version;
        private DevComponents.DotNetBar.ButtonX ButtonX_PasteDocument;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}