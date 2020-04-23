namespace SM64_ROM_Manager
{
    partial class CustomObjectsDatabaseViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomObjectsDatabaseViewer));
            this.advTree_CustomObjects = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonX_Import = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX_Description = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.warningBox1 = new DevComponents.DotNetBar.Controls.WarningBox();
            this.itemListBox_CustomObjectFiles = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this.CirProg = new DevComponents.DotNetBar.Controls.CircularProgress();
            ((System.ComponentModel.ISupportInitialize)(this.advTree_CustomObjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.itemListBox_CustomObjectFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // advTree_CustomObjects
            // 
            resources.ApplyResources(this.advTree_CustomObjects, "advTree_CustomObjects");
            this.advTree_CustomObjects.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree_CustomObjects.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree_CustomObjects.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree_CustomObjects.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree_CustomObjects.Columns.Add(this.columnHeader1);
            this.advTree_CustomObjects.Columns.Add(this.columnHeader2);
            this.advTree_CustomObjects.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree_CustomObjects.Name = "advTree_CustomObjects";
            this.advTree_CustomObjects.NodesConnector = this.nodeConnector1;
            this.advTree_CustomObjects.NodeStyle = this.elementStyle1;
            this.advTree_CustomObjects.PathSeparator = ";";
            this.advTree_CustomObjects.Styles.Add(this.elementStyle1);
            this.advTree_CustomObjects.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree1_AfterNodeSelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            this.columnHeader1.Width.Absolute = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            this.columnHeader2.Width.Absolute = 60;
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
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonX_Import);
            this.panel1.Name = "panel1";
            // 
            // buttonX_Import
            // 
            resources.ApplyResources(this.buttonX_Import, "buttonX_Import");
            this.buttonX_Import.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Import.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Import.Name = "buttonX_Import";
            this.buttonX_Import.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Import.Click += new System.EventHandler(this.ButtonX_Import_Click);
            // 
            // textBoxX_Description
            // 
            resources.ApplyResources(this.textBoxX_Description, "textBoxX_Description");
            // 
            // 
            // 
            this.textBoxX_Description.Border.Class = "TextBoxBorder";
            this.textBoxX_Description.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_Description.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("textBoxX_Description.ButtonCustom.DisplayPosition")));
            this.textBoxX_Description.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("textBoxX_Description.ButtonCustom.Image")));
            this.textBoxX_Description.ButtonCustom.Text = resources.GetString("textBoxX_Description.ButtonCustom.Text");
            this.textBoxX_Description.ButtonCustom.Tooltip = resources.GetString("textBoxX_Description.ButtonCustom.Tooltip");
            this.textBoxX_Description.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("textBoxX_Description.ButtonCustom2.DisplayPosition")));
            this.textBoxX_Description.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("textBoxX_Description.ButtonCustom2.Image")));
            this.textBoxX_Description.ButtonCustom2.Text = resources.GetString("textBoxX_Description.ButtonCustom2.Text");
            this.textBoxX_Description.ButtonCustom2.Tooltip = resources.GetString("textBoxX_Description.ButtonCustom2.Tooltip");
            this.textBoxX_Description.Name = "textBoxX_Description";
            this.textBoxX_Description.PreventEnterBeep = true;
            this.textBoxX_Description.ReadOnly = true;
            // 
            // warningBox1
            // 
            resources.ApplyResources(this.warningBox1, "warningBox1");
            this.warningBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(249)))));
            this.warningBox1.CloseButtonVisible = false;
            this.warningBox1.Name = "warningBox1";
            this.warningBox1.OptionsClick += new System.EventHandler(this.WarningBox1_OptionsClick);
            // 
            // itemListBox_CustomObjectFiles
            // 
            resources.ApplyResources(this.itemListBox_CustomObjectFiles, "itemListBox_CustomObjectFiles");
            // 
            // 
            // 
            this.itemListBox_CustomObjectFiles.BackgroundStyle.Class = "ItemPanel";
            this.itemListBox_CustomObjectFiles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemListBox_CustomObjectFiles.ContainerControlProcessDialogKey = true;
            this.itemListBox_CustomObjectFiles.Controls.Add(this.CirProg);
            this.itemListBox_CustomObjectFiles.DragDropSupport = true;
            this.itemListBox_CustomObjectFiles.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemListBox_CustomObjectFiles.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.itemListBox_CustomObjectFiles.Name = "itemListBox_CustomObjectFiles";
            this.itemListBox_CustomObjectFiles.ReserveLeftSpace = false;
            this.itemListBox_CustomObjectFiles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.itemListBox_CustomObjectFiles.SelectedItemChanged += new SM64_ROM_Manager.Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(this.ItemListBox_CustomObjectFiles_SelectedItemChanged);
            // 
            // CirProg
            // 
            resources.ApplyResources(this.CirProg, "CirProg");
            this.CirProg.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CirProg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CirProg.Name = "CirProg";
            this.CirProg.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.CirProg.SetVisibleStateOnStart = true;
            this.CirProg.SetVisibleStateOnStop = true;
            this.CirProg.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // CustomObjectsDatabaseViewer
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.advTree_CustomObjects);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxX_Description);
            this.Controls.Add(this.itemListBox_CustomObjectFiles);
            this.Controls.Add(this.warningBox1);
            this.Name = "CustomObjectsDatabaseViewer";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomObjectsDatabaseViewer_FormClosing);
            this.Shown += new System.EventHandler(this.CustomObjectsDatabaseViewer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.advTree_CustomObjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.itemListBox_CustomObjectFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Publics.Controls.ItemListBox itemListBox_CustomObjectFiles;
        private DevComponents.AdvTree.AdvTree advTree_CustomObjects;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.WarningBox warningBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_Description;
        private DevComponents.DotNetBar.Controls.CircularProgress CirProg;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.ButtonX buttonX_Import;
    }
}