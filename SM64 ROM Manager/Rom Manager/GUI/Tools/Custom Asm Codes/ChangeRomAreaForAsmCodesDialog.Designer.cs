namespace SM64_ROM_Manager
{
    partial class ChangeRomAreaForAsmCodesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeRomAreaForAsmCodesDialog));
            this.textBoxX_RomAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Save = new DevComponents.DotNetBar.ButtonX();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.textBoxX_Length = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_RamAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxX_RomAddress
            // 
            // 
            // 
            // 
            this.textBoxX_RomAddress.Border.Class = "TextBoxBorder";
            this.textBoxX_RomAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.textBoxX_RomAddress, "textBoxX_RomAddress");
            this.textBoxX_RomAddress.Name = "textBoxX_RomAddress";
            this.textBoxX_RomAddress.PreventEnterBeep = true;
            this.textBoxX_RomAddress.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // ButtonX_Cancel
            // 
            this.ButtonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX_Cancel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            resources.ApplyResources(this.ButtonX_Cancel, "ButtonX_Cancel");
            this.ButtonX_Cancel.Name = "ButtonX_Cancel";
            this.ButtonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Save
            // 
            this.ButtonX_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Save.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_checkmark_16px_1;
            resources.ApplyResources(this.ButtonX_Save, "ButtonX_Save");
            this.ButtonX_Save.Name = "ButtonX_Save";
            this.ButtonX_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Save.Click += new System.EventHandler(this.ButtonX_Save_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.textBoxX_RomAddress);
            this.layoutControl1.Controls.Add(this.ButtonX_Save);
            this.layoutControl1.Controls.Add(this.ButtonX_Cancel);
            this.layoutControl1.Controls.Add(this.textBoxX_Length);
            this.layoutControl1.Controls.Add(this.textBoxX_RamAddress);
            this.layoutControl1.Controls.Add(this.buttonX1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutSpacerItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            // 
            // textBoxX_Length
            // 
            // 
            // 
            // 
            this.textBoxX_Length.Border.Class = "TextBoxBorder";
            this.textBoxX_Length.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.textBoxX_Length, "textBoxX_Length");
            this.textBoxX_Length.Name = "textBoxX_Length";
            this.textBoxX_Length.PreventEnterBeep = true;
            this.textBoxX_Length.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // textBoxX_RamAddress
            // 
            // 
            // 
            // 
            this.textBoxX_RamAddress.Border.Class = "TextBoxBorder";
            this.textBoxX_RamAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.textBoxX_RamAddress, "textBoxX_RamAddress");
            this.textBoxX_RamAddress.Name = "textBoxX_RamAddress";
            this.textBoxX_RamAddress.PreventEnterBeep = true;
            this.textBoxX_RamAddress.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_refresh_16px;
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBoxX_RomAddress;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textBoxX_RamAddress;
            this.layoutControlItem5.Height = 28;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.Width = 100;
            this.layoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textBoxX_Length;
            this.layoutControlItem4.Height = 28;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.Width = 100;
            this.layoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.buttonX1;
            this.layoutControlItem6.Height = 31;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Width = 88;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 31;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 99;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ButtonX_Save;
            this.layoutControlItem2.Height = 31;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Width = 88;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ButtonX_Cancel;
            this.layoutControlItem3.Height = 31;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Width = 88;
            // 
            // ChangeRomAreaForAsmCodesDialog
            // 
            this.AcceptButton = this.ButtonX_Save;
            this.CancelButton = this.ButtonX_Cancel;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeRomAreaForAsmCodesDialog";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_RomAddress;
        private DevComponents.DotNetBar.ButtonX ButtonX_Cancel;
        private DevComponents.DotNetBar.ButtonX ButtonX_Save;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Length;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_RamAddress;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
    }
}