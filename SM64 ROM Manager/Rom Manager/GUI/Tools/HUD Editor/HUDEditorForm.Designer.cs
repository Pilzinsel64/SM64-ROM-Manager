
namespace SM64_ROM_Manager
{
    partial class HUDEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HUDEditorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.integerInput2 = new DevComponents.Editors.IntegerInput();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_LoadProfile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_PredefinedProfiles = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LoadFromFile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_SaveProfile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Options = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ShowGrid = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AutoSnapToGrid = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_SimplyfiedMode = new DevComponents.DotNetBar.ButtonItem();
            this.paintingControl1 = new Pilz.UI.PaintingControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.integerInput2);
            this.panel1.Controls.Add(this.integerInput1);
            this.panel1.Controls.Add(this.checkBoxX1);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(526, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 483);
            this.panel1.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(27, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Y:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(27, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "X:";
            // 
            // integerInput2
            // 
            // 
            // 
            // 
            this.integerInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput2.Location = new System.Drawing.Point(36, 33);
            this.integerInput2.Name = "integerInput2";
            this.integerInput2.ShowUpDown = true;
            this.integerInput2.Size = new System.Drawing.Size(161, 20);
            this.integerInput2.TabIndex = 2;
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(36, 4);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(161, 20);
            this.integerInput1.TabIndex = 2;
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(3, 98);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 1;
            this.checkBoxX1.Text = "Visible";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(122, 154);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Snap to Grid";
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_LoadProfile,
            this.ButtonItem_SaveProfile,
            this.ButtonItem_Options});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(726, 24);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // ButtonItem_LoadProfile
            // 
            this.ButtonItem_LoadProfile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_LoadProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_folder_16px;
            this.ButtonItem_LoadProfile.Name = "ButtonItem_LoadProfile";
            this.ButtonItem_LoadProfile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_PredefinedProfiles,
            this.ButtonItem_LoadFromFile});
            this.ButtonItem_LoadProfile.Text = "Load profile";
            // 
            // ButtonItem_PredefinedProfiles
            // 
            this.ButtonItem_PredefinedProfiles.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_database_16px;
            this.ButtonItem_PredefinedProfiles.Name = "ButtonItem_PredefinedProfiles";
            this.ButtonItem_PredefinedProfiles.Text = "Predefined Profiles";
            // 
            // ButtonItem_LoadFromFile
            // 
            this.ButtonItem_LoadFromFile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_open_folder_16px;
            this.ButtonItem_LoadFromFile.Name = "ButtonItem_LoadFromFile";
            this.ButtonItem_LoadFromFile.Text = "Load from file ...";
            // 
            // ButtonItem_SaveProfile
            // 
            this.ButtonItem_SaveProfile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_SaveProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            this.ButtonItem_SaveProfile.Name = "ButtonItem_SaveProfile";
            this.ButtonItem_SaveProfile.Text = "Save profile";
            // 
            // ButtonItem_Options
            // 
            this.ButtonItem_Options.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Options.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_settings_16px;
            this.ButtonItem_Options.Name = "ButtonItem_Options";
            this.ButtonItem_Options.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ShowGrid,
            this.ButtonItem_AutoSnapToGrid,
            this.ButtonItem_SimplyfiedMode});
            this.ButtonItem_Options.Text = "Options";
            // 
            // ButtonItem_ShowGrid
            // 
            this.ButtonItem_ShowGrid.AutoCheckOnClick = true;
            this.ButtonItem_ShowGrid.Checked = true;
            this.ButtonItem_ShowGrid.Name = "ButtonItem_ShowGrid";
            this.ButtonItem_ShowGrid.Text = "Show Grid";
            // 
            // ButtonItem_AutoSnapToGrid
            // 
            this.ButtonItem_AutoSnapToGrid.AutoCheckOnClick = true;
            this.ButtonItem_AutoSnapToGrid.Checked = true;
            this.ButtonItem_AutoSnapToGrid.Name = "ButtonItem_AutoSnapToGrid";
            this.ButtonItem_AutoSnapToGrid.Text = "Auto snap to Grid";
            // 
            // ButtonItem_SimplyfiedMode
            // 
            this.ButtonItem_SimplyfiedMode.AutoCheckOnClick = true;
            this.ButtonItem_SimplyfiedMode.Checked = true;
            this.ButtonItem_SimplyfiedMode.Name = "ButtonItem_SimplyfiedMode";
            this.ButtonItem_SimplyfiedMode.Text = "Simplyfied mode";
            // 
            // paintingControl1
            // 
            this.paintingControl1.AreaSelectionColor = System.Drawing.Color.CornflowerBlue;
            this.paintingControl1.AreaSelectionDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.paintingControl1.AutoAreaSelection = true;
            this.paintingControl1.AutoMoveObjects = true;
            this.paintingControl1.AutoMultiselection = true;
            this.paintingControl1.AutoRemoveSelection = true;
            this.paintingControl1.AutoSingleSelection = true;
            this.paintingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintingControl1.DrawAreaSelectionMethode = ((Pilz.UI.DelegateDrawPaintingControlAreaSelectionMethode)(resources.GetObject("paintingControl1.DrawAreaSelectionMethode")));
            this.paintingControl1.DrawGridMethode = ((Pilz.UI.DelegateDrawPaintingControlGridMethode)(resources.GetObject("paintingControl1.DrawGridMethode")));
            this.paintingControl1.GridChunkSize = new System.Drawing.Size(16, 16);
            this.paintingControl1.GridColor = System.Drawing.Color.LightGray;
            this.paintingControl1.GridEnabled = true;
            this.paintingControl1.GridVisible = true;
            this.paintingControl1.Location = new System.Drawing.Point(0, 24);
            this.paintingControl1.Name = "paintingControl1";
            this.paintingControl1.Offset = ((System.Drawing.PointF)(resources.GetObject("paintingControl1.Offset")));
            this.paintingControl1.Size = new System.Drawing.Size(526, 483);
            this.paintingControl1.TabIndex = 0;
            this.paintingControl1.VisibleForMouseEvents = true;
            this.paintingControl1.ZoomFactor = new System.Drawing.SizeF(1.5F, 1.5F);
            // 
            // HUDEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 507);
            this.Controls.Add(this.paintingControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HUDEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUD Editor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pilz.UI.PaintingControl paintingControl1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LoadProfile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_SaveProfile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Options;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowGrid;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AutoSnapToGrid;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.Editors.IntegerInput integerInput2;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_SimplyfiedMode;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_PredefinedProfiles;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LoadFromFile;
    }
}