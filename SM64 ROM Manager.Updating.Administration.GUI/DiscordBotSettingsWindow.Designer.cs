namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    partial class DiscordBotSettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordBotSettingsWindow));
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.TextBoxX_AppName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_Msg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_BotToken = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Okay = new DevComponents.DotNetBar.ButtonX();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.TextBoxX_AppName);
            this.layoutControl1.Controls.Add(this.TextBoxX_Msg);
            this.layoutControl1.Controls.Add(this.TextBoxX_BotToken);
            this.layoutControl1.Controls.Add(this.ButtonX_Cancel);
            this.layoutControl1.Controls.Add(this.ButtonX_Okay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.ForeColor = System.Drawing.Color.Black;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutSpacerItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControl1.Size = new System.Drawing.Size(736, 471);
            this.layoutControl1.TabIndex = 0;
            // 
            // TextBoxX_AppName
            // 
            this.TextBoxX_AppName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_AppName.Border.Class = "TextBoxBorder";
            this.TextBoxX_AppName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_AppName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_AppName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_AppName.Location = new System.Drawing.Point(142, 32);
            this.TextBoxX_AppName.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX_AppName.Name = "TextBoxX_AppName";
            this.TextBoxX_AppName.PreventEnterBeep = true;
            this.TextBoxX_AppName.Size = new System.Drawing.Size(590, 20);
            this.TextBoxX_AppName.TabIndex = 1;
            this.TextBoxX_AppName.TextChanged += new System.EventHandler(this.TextBoxX_AppName_TextChanged);
            // 
            // TextBoxX_Msg
            // 
            this.TextBoxX_Msg.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_Msg.Border.Class = "TextBoxBorder";
            this.TextBoxX_Msg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_Msg.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_Msg.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_Msg.Location = new System.Drawing.Point(142, 60);
            this.TextBoxX_Msg.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX_Msg.Multiline = true;
            this.TextBoxX_Msg.Name = "TextBoxX_Msg";
            this.TextBoxX_Msg.PreventEnterBeep = true;
            this.TextBoxX_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxX_Msg.Size = new System.Drawing.Size(590, 376);
            this.TextBoxX_Msg.TabIndex = 2;
            this.TextBoxX_Msg.TextChanged += new System.EventHandler(this.TextBoxX_Msg_TextChanged);
            // 
            // TextBoxX_BotToken
            // 
            this.TextBoxX_BotToken.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_BotToken.Border.Class = "TextBoxBorder";
            this.TextBoxX_BotToken.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_BotToken.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_BotToken.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_BotToken.Location = new System.Drawing.Point(142, 4);
            this.TextBoxX_BotToken.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX_BotToken.Name = "TextBoxX_BotToken";
            this.TextBoxX_BotToken.PreventEnterBeep = true;
            this.TextBoxX_BotToken.Size = new System.Drawing.Size(590, 20);
            this.TextBoxX_BotToken.TabIndex = 0;
            this.TextBoxX_BotToken.TextChanged += new System.EventHandler(this.TextBoxX_BotToken_TextChanged);
            // 
            // ButtonX_Cancel
            // 
            this.ButtonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX_Cancel.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_delete_sign_16px;
            this.ButtonX_Cancel.Location = new System.Drawing.Point(574, 444);
            this.ButtonX_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Cancel.Name = "ButtonX_Cancel";
            this.ButtonX_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Cancel.TabIndex = 4;
            this.ButtonX_Cancel.Text = "Abbrechen";
            // 
            // ButtonX_Okay
            // 
            this.ButtonX_Okay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Okay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Okay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonX_Okay.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_checkmark_16px;
            this.ButtonX_Okay.Location = new System.Drawing.Point(657, 444);
            this.ButtonX_Okay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Okay.Name = "ButtonX_Okay";
            this.ButtonX_Okay.Size = new System.Drawing.Size(75, 23);
            this.ButtonX_Okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Okay.TabIndex = 5;
            this.ButtonX_Okay.Text = "Okay";
            this.ButtonX_Okay.Click += new System.EventHandler(this.ButtonX_Okay_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TextBoxX_BotToken;
            this.layoutControlItem3.Height = 28;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "Bot-Token:";
            this.layoutControlItem3.Width = 100;
            this.layoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TextBoxX_AppName;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Standart-Programmname:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TextBoxX_Msg;
            this.layoutControlItem2.Height = 100;
            this.layoutControlItem2.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Standart-Nachricht:";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 31;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 99;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ButtonX_Cancel;
            this.layoutControlItem4.Height = 31;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Width = 83;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ButtonX_Okay;
            this.layoutControlItem5.Height = 31;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Width = 83;
            // 
            // DiscordBotSettingsWindow
            // 
            this.CancelButton = this.ButtonX_Cancel;
            this.ClientSize = new System.Drawing.Size(736, 471);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscordBotSettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Discord Bot-Einstellungen";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_AppName;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Msg;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_BotToken;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.ButtonX ButtonX_Cancel;
        private DevComponents.DotNetBar.ButtonX ButtonX_Okay;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
    }
}