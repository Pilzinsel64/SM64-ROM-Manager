namespace SM64_ROM_Manager.ProgressUpdater
{
    partial class DiscordSettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordSettingsDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_UrlExtraCounterParam = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_ImgBaseURL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX_BotToken = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AdvTree1 = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.CheckBoxX_EnableDiscordUpload = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CheckBoxX_EnableDiscordUpload);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.TextBoxX_UrlExtraCounterParam);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.TextBoxX_ImgBaseURL);
            this.panel1.Controls.Add(this.LabelX1);
            this.panel1.Controls.Add(this.TextBoxX_BotToken);
            this.panel1.Controls.Add(this.AdvTree1);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 194);
            this.panel1.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 142);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(194, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "URL extra counter param name:";
            // 
            // TextBoxX_UrlExtraCounterParam
            // 
            this.TextBoxX_UrlExtraCounterParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_UrlExtraCounterParam.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_UrlExtraCounterParam.Border.Class = "TextBoxBorder";
            this.TextBoxX_UrlExtraCounterParam.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_UrlExtraCounterParam.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_UrlExtraCounterParam.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_UrlExtraCounterParam.Location = new System.Drawing.Point(3, 171);
            this.TextBoxX_UrlExtraCounterParam.Name = "TextBoxX_UrlExtraCounterParam";
            this.TextBoxX_UrlExtraCounterParam.PreventEnterBeep = true;
            this.TextBoxX_UrlExtraCounterParam.Size = new System.Drawing.Size(194, 20);
            this.TextBoxX_UrlExtraCounterParam.TabIndex = 6;
            this.TextBoxX_UrlExtraCounterParam.TextChanged += new System.EventHandler(this.TextBoxX_UrlExtraCounterParam_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 87);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(194, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Image Base URL:";
            // 
            // TextBoxX_ImgBaseURL
            // 
            this.TextBoxX_ImgBaseURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_ImgBaseURL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ImgBaseURL.Border.Class = "TextBoxBorder";
            this.TextBoxX_ImgBaseURL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ImgBaseURL.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ImgBaseURL.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ImgBaseURL.Location = new System.Drawing.Point(3, 116);
            this.TextBoxX_ImgBaseURL.Name = "TextBoxX_ImgBaseURL";
            this.TextBoxX_ImgBaseURL.PreventEnterBeep = true;
            this.TextBoxX_ImgBaseURL.Size = new System.Drawing.Size(194, 20);
            this.TextBoxX_ImgBaseURL.TabIndex = 6;
            this.TextBoxX_ImgBaseURL.TextChanged += new System.EventHandler(this.TextBoxX_ImgBaseURL_TextChanged);
            // 
            // LabelX1
            // 
            this.LabelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(3, 32);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(194, 23);
            this.LabelX1.TabIndex = 5;
            this.LabelX1.Text = "Discord Bot Token:";
            // 
            // TextBoxX_BotToken
            // 
            this.TextBoxX_BotToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX_BotToken.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_BotToken.Border.Class = "TextBoxBorder";
            this.TextBoxX_BotToken.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_BotToken.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_BotToken.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_BotToken.Location = new System.Drawing.Point(3, 61);
            this.TextBoxX_BotToken.Name = "TextBoxX_BotToken";
            this.TextBoxX_BotToken.PreventEnterBeep = true;
            this.TextBoxX_BotToken.Size = new System.Drawing.Size(194, 20);
            this.TextBoxX_BotToken.TabIndex = 6;
            this.TextBoxX_BotToken.TextChanged += new System.EventHandler(this.TextBoxX_BotToken_TextChanged);
            // 
            // AdvTree1
            // 
            this.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree1.Location = new System.Drawing.Point(203, 32);
            this.AdvTree1.Name = "AdvTree1";
            this.AdvTree1.NodesConnector = this.nodeConnector1;
            this.AdvTree1.NodeStyle = this.elementStyle1;
            this.AdvTree1.PathSeparator = ";";
            this.AdvTree1.Size = new System.Drawing.Size(188, 159);
            this.AdvTree1.Styles.Add(this.elementStyle1);
            this.AdvTree1.TabIndex = 1;
            this.AdvTree1.Text = "advTree1";
            this.AdvTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree1_AfterNodeSelect);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(203, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(188, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Load Servers and Channels";
            this.buttonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // CheckBoxX_EnableDiscordUpload
            // 
            // 
            // 
            // 
            this.CheckBoxX_EnableDiscordUpload.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_EnableDiscordUpload.Location = new System.Drawing.Point(3, 3);
            this.CheckBoxX_EnableDiscordUpload.Name = "CheckBoxX_EnableDiscordUpload";
            this.CheckBoxX_EnableDiscordUpload.Size = new System.Drawing.Size(194, 23);
            this.CheckBoxX_EnableDiscordUpload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_EnableDiscordUpload.TabIndex = 7;
            this.CheckBoxX_EnableDiscordUpload.Text = "Enable Discord Upload";
            this.CheckBoxX_EnableDiscordUpload.CheckedChanged += new System.EventHandler(this.CheckBoxX_EnableDiscordUpload_CheckedChanged);
            // 
            // DiscordSettingsDialog
            // 
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscordSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Discord Settings";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.AdvTree.AdvTree AdvTree1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_UrlExtraCounterParam;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ImgBaseURL;
        private DevComponents.DotNetBar.LabelX LabelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_BotToken;
        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableDiscordUpload;
    }
}