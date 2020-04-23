namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    partial class DiscordPostDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordPostDialog));
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ButtonX_SendMsg = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxX_AddChangelog = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_PingAtEveryone = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBoxX_Msg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.textBoxX_AppName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.panel1.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Dock = System.Windows.Forms.DockStyle.Left;
            this.advTree1.DragDropEnabled = false;
            this.advTree1.DragDropNodeCopyEnabled = false;
            this.advTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree1.Location = new System.Drawing.Point(0, 0);
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(237, 461);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
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
            // ButtonX_SendMsg
            // 
            this.ButtonX_SendMsg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_SendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_SendMsg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_SendMsg.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_email_send_16px;
            this.ButtonX_SendMsg.Location = new System.Drawing.Point(469, 3);
            this.ButtonX_SendMsg.Name = "ButtonX_SendMsg";
            this.ButtonX_SendMsg.Size = new System.Drawing.Size(75, 23);
            this.ButtonX_SendMsg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_SendMsg.TabIndex = 2;
            this.ButtonX_SendMsg.Text = "Senden";
            this.ButtonX_SendMsg.Click += new System.EventHandler(this.ButtonX_SendMsg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBoxX_AddChangelog);
            this.panel1.Controls.Add(this.checkBoxX_PingAtEveryone);
            this.panel1.Controls.Add(this.ButtonX_SendMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(237, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 29);
            this.panel1.TabIndex = 3;
            // 
            // checkBoxX_AddChangelog
            // 
            // 
            // 
            // 
            this.checkBoxX_AddChangelog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_AddChangelog.Checked = true;
            this.checkBoxX_AddChangelog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_AddChangelog.CheckValue = "Y";
            this.checkBoxX_AddChangelog.Location = new System.Drawing.Point(322, 3);
            this.checkBoxX_AddChangelog.Name = "checkBoxX_AddChangelog";
            this.checkBoxX_AddChangelog.Size = new System.Drawing.Size(141, 23);
            this.checkBoxX_AddChangelog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_AddChangelog.TabIndex = 4;
            this.checkBoxX_AddChangelog.Text = "Beschreibung anhängen";
            // 
            // checkBoxX_PingAtEveryone
            // 
            // 
            // 
            // 
            this.checkBoxX_PingAtEveryone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_PingAtEveryone.Checked = true;
            this.checkBoxX_PingAtEveryone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_PingAtEveryone.CheckValue = "Y";
            this.checkBoxX_PingAtEveryone.Location = new System.Drawing.Point(211, 3);
            this.checkBoxX_PingAtEveryone.Name = "checkBoxX_PingAtEveryone";
            this.checkBoxX_PingAtEveryone.Size = new System.Drawing.Size(105, 23);
            this.checkBoxX_PingAtEveryone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_PingAtEveryone.TabIndex = 3;
            this.checkBoxX_PingAtEveryone.Text = "Ping @everyone";
            // 
            // textBoxX_Msg
            // 
            this.textBoxX_Msg.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_Msg.Border.Class = "TextBoxBorder";
            this.textBoxX_Msg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Msg.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_Msg.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_Msg.Location = new System.Drawing.Point(96, 32);
            this.textBoxX_Msg.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX_Msg.Multiline = true;
            this.textBoxX_Msg.Name = "textBoxX_Msg";
            this.textBoxX_Msg.PreventEnterBeep = true;
            this.textBoxX_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxX_Msg.Size = new System.Drawing.Size(447, 396);
            this.textBoxX_Msg.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.textBoxX_Msg);
            this.layoutControl1.Controls.Add(this.textBoxX_AppName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.ForeColor = System.Drawing.Color.Black;
            this.layoutControl1.Location = new System.Drawing.Point(237, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControl1.Size = new System.Drawing.Size(547, 432);
            this.layoutControl1.TabIndex = 6;
            // 
            // textBoxX_AppName
            // 
            this.textBoxX_AppName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_AppName.Border.Class = "TextBoxBorder";
            this.textBoxX_AppName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_AppName.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_AppName.ForeColor = System.Drawing.Color.Black;
            this.textBoxX_AppName.Location = new System.Drawing.Point(96, 4);
            this.textBoxX_AppName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX_AppName.Name = "textBoxX_AppName";
            this.textBoxX_AppName.PreventEnterBeep = true;
            this.textBoxX_AppName.Size = new System.Drawing.Size(447, 20);
            this.textBoxX_AppName.TabIndex = 0;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxX_AppName;
            this.layoutControlItem2.Height = 28;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Programmname:";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBoxX_Msg;
            this.layoutControlItem1.Height = 100;
            this.layoutControlItem1.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Nachricht:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // DiscordPostDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.advTree1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscordPostDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aktuallisierungspost auf Discord";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ButtonX ButtonX_SendMsg;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_PingAtEveryone;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Msg;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_AppName;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_AddChangelog;
    }
}