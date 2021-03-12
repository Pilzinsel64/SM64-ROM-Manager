
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
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.IntegerInput_LocationX = new DevComponents.Editors.IntegerInput();
            this.IntegerInput_LocationY = new DevComponents.Editors.IntegerInput();
            this.CheckBoxX_Visible = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ButtonX_SnapToGrid = new DevComponents.DotNetBar.ButtonX();
            this.layoutControlItem_LocationX = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem_LocationY = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem_Visible = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem_SnapToGrid = new DevComponents.DotNetBar.Layout.LayoutControlItem();
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
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_LocationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_LocationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.layoutControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(526, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 483);
            this.panel1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.IntegerInput_LocationX);
            this.layoutControl1.Controls.Add(this.IntegerInput_LocationY);
            this.layoutControl1.Controls.Add(this.CheckBoxX_Visible);
            this.layoutControl1.Controls.Add(this.ButtonX_SnapToGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem_LocationX,
            this.layoutControlItem_LocationY,
            this.layoutControlItem_Visible,
            this.layoutControlItem_SnapToGrid});
            this.layoutControl1.Size = new System.Drawing.Size(200, 483);
            this.layoutControl1.TabIndex = 4;
            // 
            // IntegerInput_LocationX
            // 
            // 
            // 
            // 
            this.IntegerInput_LocationX.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_LocationX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_LocationX.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput_LocationX.Location = new System.Drawing.Point(68, 4);
            this.IntegerInput_LocationX.Margin = new System.Windows.Forms.Padding(0);
            this.IntegerInput_LocationX.Name = "IntegerInput_LocationX";
            this.IntegerInput_LocationX.ShowUpDown = true;
            this.IntegerInput_LocationX.Size = new System.Drawing.Size(128, 20);
            this.IntegerInput_LocationX.TabIndex = 0;
            this.IntegerInput_LocationX.ValueChanged += new System.EventHandler(this.IntegerInput_Location_ValueChanged);
            // 
            // IntegerInput_LocationY
            // 
            // 
            // 
            // 
            this.IntegerInput_LocationY.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput_LocationY.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput_LocationY.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput_LocationY.Location = new System.Drawing.Point(68, 32);
            this.IntegerInput_LocationY.Margin = new System.Windows.Forms.Padding(0);
            this.IntegerInput_LocationY.Name = "IntegerInput_LocationY";
            this.IntegerInput_LocationY.ShowUpDown = true;
            this.IntegerInput_LocationY.Size = new System.Drawing.Size(128, 20);
            this.IntegerInput_LocationY.TabIndex = 1;
            this.IntegerInput_LocationY.ValueChanged += new System.EventHandler(this.IntegerInput_Location_ValueChanged);
            // 
            // CheckBoxX_Visible
            // 
            // 
            // 
            // 
            this.CheckBoxX_Visible.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_Visible.Location = new System.Drawing.Point(68, 60);
            this.CheckBoxX_Visible.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxX_Visible.Name = "CheckBoxX_Visible";
            this.CheckBoxX_Visible.Size = new System.Drawing.Size(128, 23);
            this.CheckBoxX_Visible.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_Visible.TabIndex = 2;
            this.CheckBoxX_Visible.CheckedChanged += new System.EventHandler(this.CheckBoxX_Visible_CheckedChanged);
            // 
            // ButtonX_SnapToGrid
            // 
            this.ButtonX_SnapToGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_SnapToGrid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_SnapToGrid.Location = new System.Drawing.Point(4, 91);
            this.ButtonX_SnapToGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonX_SnapToGrid.Name = "ButtonX_SnapToGrid";
            this.ButtonX_SnapToGrid.Size = new System.Drawing.Size(103, 23);
            this.ButtonX_SnapToGrid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_SnapToGrid.TabIndex = 3;
            this.ButtonX_SnapToGrid.Text = "Snap to Grid";
            this.ButtonX_SnapToGrid.Click += new System.EventHandler(this.ButtonX_SnapToGrid_Click);
            // 
            // layoutControlItem_LocationX
            // 
            this.layoutControlItem_LocationX.Control = this.IntegerInput_LocationX;
            this.layoutControlItem_LocationX.Height = 28;
            this.layoutControlItem_LocationX.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem_LocationX.Name = "layoutControlItem_LocationX";
            this.layoutControlItem_LocationX.Text = "Location X:";
            this.layoutControlItem_LocationX.Width = 100;
            this.layoutControlItem_LocationX.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem_LocationY
            // 
            this.layoutControlItem_LocationY.Control = this.IntegerInput_LocationY;
            this.layoutControlItem_LocationY.Height = 28;
            this.layoutControlItem_LocationY.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem_LocationY.Name = "layoutControlItem_LocationY";
            this.layoutControlItem_LocationY.Text = "Location Y:";
            this.layoutControlItem_LocationY.Width = 100;
            this.layoutControlItem_LocationY.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem_Visible
            // 
            this.layoutControlItem_Visible.Control = this.CheckBoxX_Visible;
            this.layoutControlItem_Visible.Height = 31;
            this.layoutControlItem_Visible.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem_Visible.Name = "layoutControlItem_Visible";
            this.layoutControlItem_Visible.Text = "Visible:";
            this.layoutControlItem_Visible.Width = 100;
            this.layoutControlItem_Visible.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem_SnapToGrid
            // 
            this.layoutControlItem_SnapToGrid.Control = this.ButtonX_SnapToGrid;
            this.layoutControlItem_SnapToGrid.Height = 31;
            this.layoutControlItem_SnapToGrid.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem_SnapToGrid.Name = "layoutControlItem_SnapToGrid";
            this.layoutControlItem_SnapToGrid.Width = 111;
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
            this.ButtonItem_LoadFromFile.Click += new System.EventHandler(this.ButtonItem_LoadFromFile_Click);
            // 
            // ButtonItem_SaveProfile
            // 
            this.ButtonItem_SaveProfile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_SaveProfile.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            this.ButtonItem_SaveProfile.Name = "ButtonItem_SaveProfile";
            this.ButtonItem_SaveProfile.Text = "Save profile";
            this.ButtonItem_SaveProfile.Click += new System.EventHandler(this.ButtonItem_SaveProfile_Click);
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
            this.ButtonItem_ShowGrid.CheckedChanged += new System.EventHandler(this.ButtonItem_ShowGrid_CheckedChanged);
            // 
            // ButtonItem_AutoSnapToGrid
            // 
            this.ButtonItem_AutoSnapToGrid.AutoCheckOnClick = true;
            this.ButtonItem_AutoSnapToGrid.Checked = true;
            this.ButtonItem_AutoSnapToGrid.Name = "ButtonItem_AutoSnapToGrid";
            this.ButtonItem_AutoSnapToGrid.Text = "Auto snap to Grid";
            this.ButtonItem_AutoSnapToGrid.CheckedChanged += new System.EventHandler(this.ButtonItem_AutoSnapToGrid_CheckedChanged);
            // 
            // ButtonItem_SimplyfiedMode
            // 
            this.ButtonItem_SimplyfiedMode.AutoCheckOnClick = true;
            this.ButtonItem_SimplyfiedMode.Checked = true;
            this.ButtonItem_SimplyfiedMode.Name = "ButtonItem_SimplyfiedMode";
            this.ButtonItem_SimplyfiedMode.Text = "Simplyfied mode";
            this.ButtonItem_SimplyfiedMode.CheckedChanged += new System.EventHandler(this.ButtonItem_SimplyfiedMode_CheckedChanged);
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
            this.paintingControl1.SelectionChanged += new Pilz.UI.PaintingControl.SelectionChangedEventHandler(this.PaintingControl1_SelectionChanged);
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
            this.Shown += new System.EventHandler(this.HUDEditorForm_Shown);
            this.panel1.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_LocationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput_LocationY)).EndInit();
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
        private DevComponents.DotNetBar.ButtonX ButtonX_SnapToGrid;
        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_Visible;
        private DevComponents.Editors.IntegerInput IntegerInput_LocationY;
        private DevComponents.Editors.IntegerInput IntegerInput_LocationX;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_SimplyfiedMode;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_PredefinedProfiles;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LoadFromFile;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem_LocationX;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem_LocationY;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem_Visible;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem_SnapToGrid;
    }
}