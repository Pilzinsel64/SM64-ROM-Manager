namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    partial class ProxyConfigEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxyConfigEditor));
            this.TextBoxX_ProxyUsr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.TextBoxX_ProxyPW = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX_OK = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.switchButton_UseProxyAuth = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.layoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem2 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxX_ProxyUsr
            // 
            this.TextBoxX_ProxyUsr.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ProxyUsr.Border.Class = "TextBoxBorder";
            this.TextBoxX_ProxyUsr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ProxyUsr.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ProxyUsr.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ProxyUsr.Location = new System.Drawing.Point(132, 34);
            this.TextBoxX_ProxyUsr.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX_ProxyUsr.Name = "TextBoxX_ProxyUsr";
            this.TextBoxX_ProxyUsr.PreventEnterBeep = true;
            this.TextBoxX_ProxyUsr.Size = new System.Drawing.Size(363, 20);
            this.TextBoxX_ProxyUsr.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.TextBoxX_ProxyUsr);
            this.layoutControl1.Controls.Add(this.TextBoxX_ProxyPW);
            this.layoutControl1.Controls.Add(this.ButtonX_OK);
            this.layoutControl1.Controls.Add(this.ButtonX_Cancel);
            this.layoutControl1.Controls.Add(this.switchButton_UseProxyAuth);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.ForeColor = System.Drawing.Color.Black;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem8,
            this.layoutSpacerItem2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutSpacerItem1,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.layoutControl1.Size = new System.Drawing.Size(499, 117);
            this.layoutControl1.TabIndex = 1;
            // 
            // TextBoxX_ProxyPW
            // 
            this.TextBoxX_ProxyPW.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ProxyPW.Border.Class = "TextBoxBorder";
            this.TextBoxX_ProxyPW.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ProxyPW.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ProxyPW.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ProxyPW.Location = new System.Drawing.Point(132, 62);
            this.TextBoxX_ProxyPW.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxX_ProxyPW.Name = "TextBoxX_ProxyPW";
            this.TextBoxX_ProxyPW.PreventEnterBeep = true;
            this.TextBoxX_ProxyPW.Size = new System.Drawing.Size(363, 20);
            this.TextBoxX_ProxyPW.TabIndex = 3;
            this.TextBoxX_ProxyPW.UseSystemPasswordChar = true;
            // 
            // ButtonX_OK
            // 
            this.ButtonX_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonX_OK.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_checkmark_16px;
            this.ButtonX_OK.Location = new System.Drawing.Point(403, 90);
            this.ButtonX_OK.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_OK.Name = "ButtonX_OK";
            this.ButtonX_OK.Size = new System.Drawing.Size(92, 23);
            this.ButtonX_OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_OK.TabIndex = 6;
            this.ButtonX_OK.Text = "Speichern";
            this.ButtonX_OK.Click += new System.EventHandler(this.ButtonX_OK_Click);
            // 
            // ButtonX_Cancel
            // 
            this.ButtonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX_Cancel.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_delete_sign_16px;
            this.ButtonX_Cancel.Location = new System.Drawing.Point(303, 90);
            this.ButtonX_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Cancel.Name = "ButtonX_Cancel";
            this.ButtonX_Cancel.Size = new System.Drawing.Size(92, 23);
            this.ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Cancel.TabIndex = 5;
            this.ButtonX_Cancel.Text = "Abbrechen";
            // 
            // switchButton_UseProxyAuth
            // 
            // 
            // 
            // 
            this.switchButton_UseProxyAuth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton_UseProxyAuth.Location = new System.Drawing.Point(132, 4);
            this.switchButton_UseProxyAuth.Margin = new System.Windows.Forms.Padding(0);
            this.switchButton_UseProxyAuth.Name = "switchButton_UseProxyAuth";
            this.switchButton_UseProxyAuth.OffText = "Nein";
            this.switchButton_UseProxyAuth.OnText = "Ja";
            this.switchButton_UseProxyAuth.Size = new System.Drawing.Size(114, 22);
            this.switchButton_UseProxyAuth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton_UseProxyAuth.TabIndex = 0;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.switchButton_UseProxyAuth;
            this.layoutControlItem8.Height = 30;
            this.layoutControlItem8.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Text = "Proxy-Authentifizierung:";
            this.layoutControlItem8.TextPadding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.layoutControlItem8.Width = 250;
            // 
            // layoutSpacerItem2
            // 
            this.layoutSpacerItem2.Height = 30;
            this.layoutSpacerItem2.Name = "layoutSpacerItem2";
            this.layoutSpacerItem2.Width = 99;
            this.layoutSpacerItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TextBoxX_ProxyUsr;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Benutzername:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TextBoxX_ProxyPW;
            this.layoutControlItem2.Height = 28;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Passwort:";
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
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ButtonX_Cancel;
            this.layoutControlItem7.Height = 31;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Width = 100;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ButtonX_OK;
            this.layoutControlItem6.Height = 31;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Width = 100;
            // 
            // ProxyConfigEditor
            // 
            this.AcceptButton = this.ButtonX_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonX_Cancel;
            this.ClientSize = new System.Drawing.Size(499, 117);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProxyConfigEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateServerInfoEditor";
            this.Shown += new System.EventHandler(this.UpdateServerInfoEditor_Shown);
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxyUsr;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProxyPW;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.ButtonX ButtonX_OK;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.ButtonX ButtonX_Cancel;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton_UseProxyAuth;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem2;
    }
}