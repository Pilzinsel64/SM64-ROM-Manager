namespace SM64_ROM_Manager.GUI.Main_Form
{
    partial class Tab_LevelManagerV2
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LevelsTree = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panel_SideMenu = new System.Windows.Forms.Panel();
            this.panel_Tools = new System.Windows.Forms.Panel();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_LevelTools_AddLevel = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_ImportLevel = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AreaTools_AddArea = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AreaTools_ImportArea = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_OpenLevelEditor = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveItem = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_ExportLevel = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_More = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_EditLevelscript = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_ChangeLevelName = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_ChangeSizeOfBank0x19 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_CopyRomAddress = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LevelTools_ChangeLevelID = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AreaTools_More = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AreaTools_EditAreaLevelScript = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AreaTools_ChangeAreaID = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AreaTools_EditGeolayoutScript = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.LevelsTree)).BeginInit();
            this.panel_SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // LevelsTree
            // 
            this.LevelsTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.LevelsTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.LevelsTree.BackgroundStyle.Class = "TreeBorderKey";
            this.LevelsTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LevelsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelsTree.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.LevelsTree.Location = new System.Drawing.Point(0, 0);
            this.LevelsTree.Name = "LevelsTree";
            this.LevelsTree.NodesConnector = this.nodeConnector1;
            this.LevelsTree.NodeStyle = this.elementStyle1;
            this.LevelsTree.PathSeparator = ";";
            this.LevelsTree.Size = new System.Drawing.Size(200, 521);
            this.LevelsTree.Styles.Add(this.elementStyle1);
            this.LevelsTree.TabIndex = 0;
            this.LevelsTree.Text = "advTree1";
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
            // panel_SideMenu
            // 
            this.panel_SideMenu.BackColor = System.Drawing.Color.Transparent;
            this.panel_SideMenu.Controls.Add(this.LevelsTree);
            this.panel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SideMenu.Location = new System.Drawing.Point(0, 25);
            this.panel_SideMenu.Name = "panel_SideMenu";
            this.panel_SideMenu.Size = new System.Drawing.Size(200, 521);
            this.panel_SideMenu.TabIndex = 1;
            // 
            // panel_Tools
            // 
            this.panel_Tools.BackColor = System.Drawing.Color.Transparent;
            this.panel_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Tools.Location = new System.Drawing.Point(200, 25);
            this.panel_Tools.Name = "panel_Tools";
            this.panel_Tools.Size = new System.Drawing.Size(494, 521);
            this.panel_Tools.TabIndex = 1;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_LevelTools_AddLevel,
            this.ButtonItem_LevelTools_ImportLevel,
            this.ButtonItem_AreaTools_AddArea,
            this.ButtonItem_AreaTools_ImportArea,
            this.ButtonItem_OpenLevelEditor,
            this.ButtonItem_RemoveItem,
            this.ButtonItem_LevelTools_ExportLevel,
            this.ButtonItem_LevelTools_More,
            this.ButtonItem_AreaTools_More});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(694, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
            this.bar1.TabStop = false;
            // 
            // ButtonItem_LevelTools_AddLevel
            // 
            this.ButtonItem_LevelTools_AddLevel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_LevelTools_AddLevel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_LevelTools_AddLevel.Name = "ButtonItem_LevelTools_AddLevel";
            this.ButtonItem_LevelTools_AddLevel.Text = "Add Level";
            // 
            // ButtonItem_LevelTools_ImportLevel
            // 
            this.ButtonItem_LevelTools_ImportLevel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_LevelTools_ImportLevel.GlobalItem = false;
            this.ButtonItem_LevelTools_ImportLevel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonItem_LevelTools_ImportLevel.Name = "ButtonItem_LevelTools_ImportLevel";
            this.ButtonItem_LevelTools_ImportLevel.Text = "Import Level";
            // 
            // ButtonItem_AreaTools_AddArea
            // 
            this.ButtonItem_AreaTools_AddArea.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_AreaTools_AddArea.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_AreaTools_AddArea.Name = "ButtonItem_AreaTools_AddArea";
            this.ButtonItem_AreaTools_AddArea.Text = "Add Area";
            // 
            // ButtonItem_AreaTools_ImportArea
            // 
            this.ButtonItem_AreaTools_ImportArea.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_AreaTools_ImportArea.GlobalItem = false;
            this.ButtonItem_AreaTools_ImportArea.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonItem_AreaTools_ImportArea.Name = "ButtonItem_AreaTools_ImportArea";
            this.ButtonItem_AreaTools_ImportArea.Text = "Import Area";
            // 
            // ButtonItem_OpenLevelEditor
            // 
            this.ButtonItem_OpenLevelEditor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_OpenLevelEditor.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_OpenLevelEditor.Name = "ButtonItem_OpenLevelEditor";
            this.ButtonItem_OpenLevelEditor.Text = "Level Editor";
            // 
            // ButtonItem_RemoveItem
            // 
            this.ButtonItem_RemoveItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_RemoveItem.GlobalItem = false;
            this.ButtonItem_RemoveItem.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveItem.Name = "ButtonItem_RemoveItem";
            this.ButtonItem_RemoveItem.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem_RemoveItem.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_RemoveItem.SymbolSize = 12F;
            this.ButtonItem_RemoveItem.Text = "Remove";
            // 
            // ButtonItem_LevelTools_ExportLevel
            // 
            this.ButtonItem_LevelTools_ExportLevel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_LevelTools_ExportLevel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_export_16px;
            this.ButtonItem_LevelTools_ExportLevel.Name = "ButtonItem_LevelTools_ExportLevel";
            this.ButtonItem_LevelTools_ExportLevel.Text = "Export Level";
            // 
            // ButtonItem_LevelTools_More
            // 
            this.ButtonItem_LevelTools_More.AutoExpandOnClick = true;
            this.ButtonItem_LevelTools_More.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_LevelTools_More.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_expand_arrow_16px;
            this.ButtonItem_LevelTools_More.Name = "ButtonItem_LevelTools_More";
            this.ButtonItem_LevelTools_More.ShowSubItems = false;
            this.ButtonItem_LevelTools_More.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_LevelTools_ChangeLevelID,
            this.ButtonItem_LevelTools_EditLevelscript,
            this.ButtonItem_LevelTools_ChangeLevelName,
            this.ButtonItem_LevelTools_ChangeSizeOfBank0x19,
            this.ButtonItem_LevelTools_CopyRomAddress});
            this.ButtonItem_LevelTools_More.Text = "More";
            // 
            // ButtonItem_LevelTools_EditLevelscript
            // 
            this.ButtonItem_LevelTools_EditLevelscript.BeginGroup = true;
            this.ButtonItem_LevelTools_EditLevelscript.GlobalItem = false;
            this.ButtonItem_LevelTools_EditLevelscript.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_LevelTools_EditLevelscript.Name = "ButtonItem_LevelTools_EditLevelscript";
            this.ButtonItem_LevelTools_EditLevelscript.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem_LevelTools_EditLevelscript.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_LevelTools_EditLevelscript.SymbolSize = 12F;
            this.ButtonItem_LevelTools_EditLevelscript.Text = "Edit Level Script";
            // 
            // ButtonItem_LevelTools_ChangeLevelName
            // 
            this.ButtonItem_LevelTools_ChangeLevelName.BeginGroup = true;
            this.ButtonItem_LevelTools_ChangeLevelName.GlobalItem = false;
            this.ButtonItem_LevelTools_ChangeLevelName.Name = "ButtonItem_LevelTools_ChangeLevelName";
            this.ButtonItem_LevelTools_ChangeLevelName.Text = "Change Level Name";
            // 
            // ButtonItem_LevelTools_ChangeSizeOfBank0x19
            // 
            this.ButtonItem_LevelTools_ChangeSizeOfBank0x19.GlobalItem = false;
            this.ButtonItem_LevelTools_ChangeSizeOfBank0x19.Name = "ButtonItem_LevelTools_ChangeSizeOfBank0x19";
            this.ButtonItem_LevelTools_ChangeSizeOfBank0x19.Text = "Change Size of Bank 0x19";
            // 
            // ButtonItem_LevelTools_CopyRomAddress
            // 
            this.ButtonItem_LevelTools_CopyRomAddress.BeginGroup = true;
            this.ButtonItem_LevelTools_CopyRomAddress.GlobalItem = false;
            this.ButtonItem_LevelTools_CopyRomAddress.Name = "ButtonItem_LevelTools_CopyRomAddress";
            this.ButtonItem_LevelTools_CopyRomAddress.Text = "Copy ROM Address";
            // 
            // ButtonItem_LevelTools_ChangeLevelID
            // 
            this.ButtonItem_LevelTools_ChangeLevelID.GlobalItem = false;
            this.ButtonItem_LevelTools_ChangeLevelID.Name = "ButtonItem_LevelTools_ChangeLevelID";
            this.ButtonItem_LevelTools_ChangeLevelID.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem_LevelTools_ChangeLevelID.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_LevelTools_ChangeLevelID.SymbolSize = 12F;
            this.ButtonItem_LevelTools_ChangeLevelID.Text = "Change Level ID";
            // 
            // ButtonItem_AreaTools_More
            // 
            this.ButtonItem_AreaTools_More.AutoExpandOnClick = true;
            this.ButtonItem_AreaTools_More.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_AreaTools_More.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_expand_arrow_16px;
            this.ButtonItem_AreaTools_More.Name = "ButtonItem_AreaTools_More";
            this.ButtonItem_AreaTools_More.ShowSubItems = false;
            this.ButtonItem_AreaTools_More.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AreaTools_ChangeAreaID,
            this.ButtonItem_AreaTools_EditAreaLevelScript,
            this.ButtonItem_AreaTools_EditGeolayoutScript});
            this.ButtonItem_AreaTools_More.Text = "More";
            // 
            // ButtonItem_AreaTools_EditAreaLevelScript
            // 
            this.ButtonItem_AreaTools_EditAreaLevelScript.BeginGroup = true;
            this.ButtonItem_AreaTools_EditAreaLevelScript.GlobalItem = false;
            this.ButtonItem_AreaTools_EditAreaLevelScript.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_AreaTools_EditAreaLevelScript.Name = "ButtonItem_AreaTools_EditAreaLevelScript";
            this.ButtonItem_AreaTools_EditAreaLevelScript.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem_AreaTools_EditAreaLevelScript.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_AreaTools_EditAreaLevelScript.SymbolSize = 12F;
            this.ButtonItem_AreaTools_EditAreaLevelScript.Text = "Edit Level Script";
            // 
            // ButtonItem_AreaTools_ChangeAreaID
            // 
            this.ButtonItem_AreaTools_ChangeAreaID.GlobalItem = false;
            this.ButtonItem_AreaTools_ChangeAreaID.Name = "ButtonItem_AreaTools_ChangeAreaID";
            this.ButtonItem_AreaTools_ChangeAreaID.Text = "Change ID";
            // 
            // ButtonItem_AreaTools_EditGeolayoutScript
            // 
            this.ButtonItem_AreaTools_EditGeolayoutScript.GlobalItem = false;
            this.ButtonItem_AreaTools_EditGeolayoutScript.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_AreaTools_EditGeolayoutScript.Name = "ButtonItem_AreaTools_EditGeolayoutScript";
            this.ButtonItem_AreaTools_EditGeolayoutScript.SymbolColor = System.Drawing.Color.Goldenrod;
            this.ButtonItem_AreaTools_EditGeolayoutScript.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_AreaTools_EditGeolayoutScript.SymbolSize = 12F;
            this.ButtonItem_AreaTools_EditGeolayoutScript.Text = "Edit Geo Layout Script";
            // 
            // Tab_LevelManagerV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Tools);
            this.Controls.Add(this.panel_SideMenu);
            this.Controls.Add(this.bar1);
            this.Name = "Tab_LevelManagerV2";
            this.Size = new System.Drawing.Size(694, 546);
            ((System.ComponentModel.ISupportInitialize)(this.LevelsTree)).EndInit();
            this.panel_SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree LevelsTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.Panel panel_SideMenu;
        private System.Windows.Forms.Panel panel_Tools;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_AddLevel;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_ImportLevel;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AreaTools_AddArea;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AreaTools_ImportArea;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_OpenLevelEditor;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_ExportLevel;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveItem;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_More;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_EditLevelscript;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_ChangeLevelName;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_ChangeSizeOfBank0x19;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_CopyRomAddress;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_LevelTools_ChangeLevelID;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AreaTools_More;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AreaTools_ChangeAreaID;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AreaTools_EditAreaLevelScript;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AreaTools_EditGeolayoutScript;
    }
}
