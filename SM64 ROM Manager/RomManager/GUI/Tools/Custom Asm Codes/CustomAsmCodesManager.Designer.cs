namespace SM64_ROM_Manager
{
    partial class CustomAsmCodesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAsmCodesManager));
            this.AdvTree_Codes = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_Add = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Remove = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Edit = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_EditHex = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_EditName = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Tools = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ChangeRomAreaForAsm = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AsmToHexConverter = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_Codes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvTree_Codes
            // 
            this.AdvTree_Codes.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree_Codes.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree_Codes.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree_Codes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree_Codes.CellEdit = true;
            this.AdvTree_Codes.Columns.Add(this.columnHeader1);
            this.AdvTree_Codes.Columns.Add(this.columnHeader2);
            resources.ApplyResources(this.AdvTree_Codes, "AdvTree_Codes");
            this.AdvTree_Codes.DragDropEnabled = false;
            this.AdvTree_Codes.DragDropNodeCopyEnabled = false;
            this.AdvTree_Codes.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree_Codes.Name = "AdvTree_Codes";
            this.AdvTree_Codes.NodesConnector = this.nodeConnector1;
            this.AdvTree_Codes.NodeStyle = this.elementStyle1;
            this.AdvTree_Codes.PathSeparator = ";";
            this.AdvTree_Codes.Styles.Add(this.elementStyle1);
            this.AdvTree_Codes.BeforeCellEdit += new DevComponents.AdvTree.CellEditEventHandler(this.AdvTree_Codes_BeforeCellEdit);
            this.AdvTree_Codes.AfterCellEdit += new DevComponents.AdvTree.CellEditEventHandler(this.AdvTree_Codes_AfterCellEdit);
            this.AdvTree_Codes.AfterCellEditComplete += new DevComponents.AdvTree.CellEditEventHandler(this.AdvTree_Codes_AfterCellEditComplete);
            this.AdvTree_Codes.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree_Codes_AfterNodeSelect);
            this.AdvTree_Codes.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.AdvTree_Codes_NodeDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            this.columnHeader1.Width.Absolute = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            this.columnHeader2.Width.Absolute = 80;
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
            // bar1
            // 
            resources.ApplyResources(this.bar1, "bar1");
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_Add,
            this.ButtonItem_Remove,
            this.ButtonItem_Edit,
            this.ButtonItem_Tools});
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabStop = false;
            // 
            // ButtonItem_Add
            // 
            this.ButtonItem_Add.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Add.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_Add.Name = "ButtonItem_Add";
            resources.ApplyResources(this.ButtonItem_Add, "ButtonItem_Add");
            this.ButtonItem_Add.Click += new System.EventHandler(this.ButtonItem_Add_Click);
            // 
            // ButtonItem_Remove
            // 
            this.ButtonItem_Remove.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Remove.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_Remove.Name = "ButtonItem_Remove";
            resources.ApplyResources(this.ButtonItem_Remove, "ButtonItem_Remove");
            this.ButtonItem_Remove.Click += new System.EventHandler(this.ButtonItem_Remove_Click);
            // 
            // ButtonItem_Edit
            // 
            this.ButtonItem_Edit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Edit.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_Edit.Name = "ButtonItem_Edit";
            this.ButtonItem_Edit.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_EditHex,
            this.ButtonItem_EditName});
            resources.ApplyResources(this.ButtonItem_Edit, "ButtonItem_Edit");
            // 
            // ButtonItem_EditHex
            // 
            this.ButtonItem_EditHex.FontBold = true;
            this.ButtonItem_EditHex.HotFontBold = true;
            this.ButtonItem_EditHex.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_EditHex.Name = "ButtonItem_EditHex";
            resources.ApplyResources(this.ButtonItem_EditHex, "ButtonItem_EditHex");
            this.ButtonItem_EditHex.Click += new System.EventHandler(this.ButtonItem_EditHex_Click);
            // 
            // ButtonItem_EditName
            // 
            this.ButtonItem_EditName.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_EditName.Name = "ButtonItem_EditName";
            resources.ApplyResources(this.ButtonItem_EditName, "ButtonItem_EditName");
            this.ButtonItem_EditName.Click += new System.EventHandler(this.ButtonItem_EditName_Click);
            // 
            // ButtonItem_Tools
            // 
            this.ButtonItem_Tools.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_Tools.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_expand_arrow_16px;
            this.ButtonItem_Tools.Name = "ButtonItem_Tools";
            this.ButtonItem_Tools.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ChangeRomAreaForAsm,
            this.ButtonItem_AsmToHexConverter});
            resources.ApplyResources(this.ButtonItem_Tools, "ButtonItem_Tools");
            // 
            // ButtonItem_ChangeRomAreaForAsm
            // 
            this.ButtonItem_ChangeRomAreaForAsm.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_support_16px;
            this.ButtonItem_ChangeRomAreaForAsm.Name = "ButtonItem_ChangeRomAreaForAsm";
            resources.ApplyResources(this.ButtonItem_ChangeRomAreaForAsm, "ButtonItem_ChangeRomAreaForAsm");
            this.ButtonItem_ChangeRomAreaForAsm.Click += new System.EventHandler(this.ButtonItem_ChangeRomAreaForAsm_Click);
            // 
            // ButtonItem_AsmToHexConverter
            // 
            this.ButtonItem_AsmToHexConverter.BeginGroup = true;
            this.ButtonItem_AsmToHexConverter.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_code_16px;
            this.ButtonItem_AsmToHexConverter.Name = "ButtonItem_AsmToHexConverter";
            resources.ApplyResources(this.ButtonItem_AsmToHexConverter, "ButtonItem_AsmToHexConverter");
            this.ButtonItem_AsmToHexConverter.Click += new System.EventHandler(this.ButtonItem_AsmToHexConverter_Click);
            // 
            // CustomAsmCodesManager
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.AdvTree_Codes);
            this.Controls.Add(this.bar1);
            this.Name = "CustomAsmCodesManager";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Shown += new System.EventHandler(this.CustomAsmCodesManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_Codes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree AdvTree_Codes;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Add;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Remove;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Edit;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_EditHex;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_EditName;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Tools;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_AsmToHexConverter;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ChangeRomAreaForAsm;
    }
}