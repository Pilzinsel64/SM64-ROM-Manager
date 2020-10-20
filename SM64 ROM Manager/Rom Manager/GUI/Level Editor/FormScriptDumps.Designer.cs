namespace SM64_ROM_Manager.LevelEditor
{
    partial class FormScriptDumps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScriptDumps));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RichTextBoxEx_Script = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.ScriptTree = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.SliderItem_Zoom = new DevComponents.DotNetBar.SliderItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.RichTextBoxEx_Script);
            this.panel1.Controls.Add(this.ScriptTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 445);
            this.panel1.TabIndex = 0;
            // 
            // RichTextBoxEx_Script
            // 
            // 
            // 
            // 
            this.RichTextBoxEx_Script.BackgroundStyle.Class = "RichTextBoxBorder";
            this.RichTextBoxEx_Script.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RichTextBoxEx_Script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxEx_Script.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxEx_Script.Location = new System.Drawing.Point(195, 0);
            this.RichTextBoxEx_Script.Name = "RichTextBoxEx_Script";
            this.RichTextBoxEx_Script.ReadOnly = true;
            this.RichTextBoxEx_Script.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1031{\\fonttbl{\\f0\\fnil\\fcharset0 Consolas;}}" +
    "\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.RichTextBoxEx_Script.Size = new System.Drawing.Size(595, 445);
            this.RichTextBoxEx_Script.TabIndex = 0;
            // 
            // ScriptTree
            // 
            this.ScriptTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.ScriptTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.ScriptTree.BackgroundStyle.Class = "TreeBorderKey";
            this.ScriptTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ScriptTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScriptTree.DragDropEnabled = false;
            this.ScriptTree.DragDropNodeCopyEnabled = false;
            this.ScriptTree.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ScriptTree.Location = new System.Drawing.Point(0, 0);
            this.ScriptTree.Name = "ScriptTree";
            this.ScriptTree.NodesConnector = this.nodeConnector1;
            this.ScriptTree.NodeStyle = this.elementStyle1;
            this.ScriptTree.PathSeparator = ";";
            this.ScriptTree.Size = new System.Drawing.Size(195, 445);
            this.ScriptTree.Styles.Add(this.elementStyle1);
            this.ScriptTree.TabIndex = 1;
            this.ScriptTree.Text = "advTree1";
            this.ScriptTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.ScriptTree_AfterNodeSelect);
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
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CanCustomize = false;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(790, 30);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 1;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SliderItem_Zoom});
            this.bar1.Location = new System.Drawing.Point(5, 476);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(790, 22);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
            this.bar1.TabStop = false;
            // 
            // SliderItem_Zoom
            // 
            this.SliderItem_Zoom.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.SliderItem_Zoom.LabelWidth = 75;
            this.SliderItem_Zoom.Maximum = 500;
            this.SliderItem_Zoom.Minimum = 10;
            this.SliderItem_Zoom.Name = "SliderItem_Zoom";
            this.SliderItem_Zoom.Step = 10;
            this.SliderItem_Zoom.Text = "Zoom: 100%";
            this.SliderItem_Zoom.TrackMarker = false;
            this.SliderItem_Zoom.Value = 100;
            this.SliderItem_Zoom.ValueChanged += new System.EventHandler(this.SliderItem_Zoom_ValueChanged);
            // 
            // FormScriptDumps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.bar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScriptDumps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "800; 500";
            this.Text = "Script Dumps";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx RichTextBoxEx_Script;
        private DevComponents.AdvTree.AdvTree ScriptTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.SliderItem SliderItem_Zoom;
    }
}