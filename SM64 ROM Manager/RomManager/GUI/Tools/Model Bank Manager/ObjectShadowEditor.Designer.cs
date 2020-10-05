namespace SM64_ROM_Manager
{
    partial class ObjectShadowEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectShadowEditor));
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.ComboBoxEx_Type = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.IntegerInput_Diameter = new DevComponents.Editors.IntegerInput();
            this.IntegerInput_Opacity = new DevComponents.Editors.IntegerInput();
            this.ButtonX_Save = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_Diameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_Opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.ComboBoxEx_Type);
            this.layoutControl1.Controls.Add(this.IntegerInput_Diameter);
            this.layoutControl1.Controls.Add(this.IntegerInput_Opacity);
            this.layoutControl1.Controls.Add(this.ButtonX_Save);
            this.layoutControl1.Controls.Add(this.ButtonX_Cancel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutSpacerItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControl1.Size = new System.Drawing.Size(260, 115);
            this.layoutControl1.TabIndex = 0;
            // 
            // ComboBoxEx_Type
            // 
            this.ComboBoxEx_Type.DisplayMember = "Text";
            this.ComboBoxEx_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_Type.FormattingEnabled = true;
            this.ComboBoxEx_Type.ItemHeight = 15;
            this.ComboBoxEx_Type.Location = new System.Drawing.Point(60, 4);
            this.ComboBoxEx_Type.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxEx_Type.Name = "ComboBoxEx_Type";
            this.ComboBoxEx_Type.Size = new System.Drawing.Size(196, 21);
            this.ComboBoxEx_Type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_Type.TabIndex = 0;
            // 
            // IntegerInput_Diameter
            // 
            // 
            // 
            // 
            this.IntegerInput_Diameter.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_Diameter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_Diameter.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput_Diameter.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.IntegerInput_Diameter.Location = new System.Drawing.Point(60, 32);
            this.IntegerInput_Diameter.Margin = new System.Windows.Forms.Padding(0);
            this.IntegerInput_Diameter.MaxValue = 65536;
            this.IntegerInput_Diameter.MinValue = 0;
            this.IntegerInput_Diameter.Name = "IntegerInput_Diameter";
            this.IntegerInput_Diameter.ShowUpDown = true;
            this.IntegerInput_Diameter.Size = new System.Drawing.Size(196, 20);
            this.IntegerInput_Diameter.TabIndex = 1;
            // 
            // IntegerInput_Opacity
            // 
            // 
            // 
            // 
            this.IntegerInput_Opacity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_Opacity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_Opacity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput_Opacity.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.IntegerInput_Opacity.Location = new System.Drawing.Point(60, 60);
            this.IntegerInput_Opacity.Margin = new System.Windows.Forms.Padding(0);
            this.IntegerInput_Opacity.MaxValue = 255;
            this.IntegerInput_Opacity.MinValue = 0;
            this.IntegerInput_Opacity.Name = "IntegerInput_Opacity";
            this.IntegerInput_Opacity.ShowUpDown = true;
            this.IntegerInput_Opacity.Size = new System.Drawing.Size(196, 20);
            this.IntegerInput_Opacity.TabIndex = 2;
            // 
            // ButtonX_Save
            // 
            this.ButtonX_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonX_Save.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_checkmark_16px_1;
            this.ButtonX_Save.Location = new System.Drawing.Point(68, 88);
            this.ButtonX_Save.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Save.Name = "ButtonX_Save";
            this.ButtonX_Save.Size = new System.Drawing.Size(90, 23);
            this.ButtonX_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Save.TabIndex = 4;
            this.ButtonX_Save.Text = "Save";
            this.ButtonX_Save.Click += new System.EventHandler(this.ButtonX_Save_Click);
            // 
            // ButtonX_Cancel
            // 
            this.ButtonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX_Cancel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonX_Cancel.Location = new System.Drawing.Point(166, 88);
            this.ButtonX_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_Cancel.Name = "ButtonX_Cancel";
            this.ButtonX_Cancel.Size = new System.Drawing.Size(90, 23);
            this.ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Cancel.TabIndex = 5;
            this.ButtonX_Cancel.Text = "Cancel";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ComboBoxEx_Type;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Type:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.IntegerInput_Diameter;
            this.layoutControlItem2.Height = 28;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Diameter:";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.IntegerInput_Opacity;
            this.layoutControlItem3.Height = 28;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "Opacity:";
            this.layoutControlItem3.Width = 100;
            this.layoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
            this.layoutControlItem4.Control = this.ButtonX_Save;
            this.layoutControlItem4.Height = 31;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Width = 98;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ButtonX_Cancel;
            this.layoutControlItem5.Height = 31;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Width = 98;
            // 
            // ObjectShadowEditor
            // 
            this.AcceptButton = this.ButtonX_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonX_Cancel;
            this.ClientSize = new System.Drawing.Size(260, 115);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ObjectShadowEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Object Shadow";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Load += new System.EventHandler(this.ObjectShadowEditor_Load);
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_Diameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_Opacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Type;
        private DevComponents.Editors.IntegerInput IntegerInput_Diameter;
        private DevComponents.Editors.IntegerInput IntegerInput_Opacity;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.ButtonX ButtonX_Save;
        private DevComponents.DotNetBar.ButtonX ButtonX_Cancel;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
    }
}