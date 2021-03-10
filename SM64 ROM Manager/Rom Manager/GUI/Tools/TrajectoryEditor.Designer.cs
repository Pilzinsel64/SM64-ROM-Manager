using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class TrajectoryEditor : DevComponents.DotNetBar.OfficeForm
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrajectoryEditor));
            this.ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.IntegerInput1 = new DevComponents.Editors.IntegerInput();
            this.IntegerInput2 = new DevComponents.Editors.IntegerInput();
            this.IntegerInput3 = new DevComponents.Editors.IntegerInput();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX7 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX8 = new DevComponents.DotNetBar.ButtonX();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.columnHeader5 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader6 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader7 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader8 = new DevComponents.AdvTree.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput3)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxEx1
            // 
            resources.ApplyResources(this.ComboBoxEx1, "ComboBoxEx1");
            this.ComboBoxEx1.DisplayMember = "Text";
            this.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx1.DropDownWidth = 250;
            this.ComboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx1.FormattingEnabled = true;
            this.ComboBoxEx1.Name = "ComboBoxEx1";
            this.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx1_SelectedIndexChanged);
            // 
            // IntegerInput1
            // 
            resources.ApplyResources(this.IntegerInput1, "IntegerInput1");
            // 
            // 
            // 
            this.IntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput1.MaxValue = 65535;
            this.IntegerInput1.MinValue = -65535;
            this.IntegerInput1.Name = "IntegerInput1";
            this.IntegerInput1.ShowUpDown = true;
            this.IntegerInput1.ValueChanged += new System.EventHandler(this.IntegerInput1_ValueChanged);
            // 
            // IntegerInput2
            // 
            resources.ApplyResources(this.IntegerInput2, "IntegerInput2");
            // 
            // 
            // 
            this.IntegerInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput2.MaxValue = 65535;
            this.IntegerInput2.MinValue = -65535;
            this.IntegerInput2.Name = "IntegerInput2";
            this.IntegerInput2.ShowUpDown = true;
            this.IntegerInput2.ValueChanged += new System.EventHandler(this.IntegerInput1_ValueChanged);
            // 
            // IntegerInput3
            // 
            resources.ApplyResources(this.IntegerInput3, "IntegerInput3");
            // 
            // 
            // 
            this.IntegerInput3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IntegerInput3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IntegerInput3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IntegerInput3.MaxValue = 65535;
            this.IntegerInput3.MinValue = -65535;
            this.IntegerInput3.Name = "IntegerInput3";
            this.IntegerInput3.ShowUpDown = true;
            this.IntegerInput3.ValueChanged += new System.EventHandler(this.IntegerInput1_ValueChanged);
            // 
            // LabelX2
            // 
            resources.ApplyResources(this.LabelX2, "LabelX2");
            this.LabelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX3
            // 
            resources.ApplyResources(this.LabelX3, "LabelX3");
            this.LabelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX1, "ButtonX1");
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX1.FocusCuesEnabled = false;
            this.ButtonX1.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_add_subnode_16px;
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX1.SymbolSize = 12F;
            this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // ButtonX2
            // 
            this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX2, "ButtonX2");
            this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX2.FocusCuesEnabled = false;
            this.ButtonX2.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_subnode_16px;
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX2.SymbolSize = 12F;
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // ButtonX3
            // 
            this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX3, "ButtonX3");
            this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX3.FocusCuesEnabled = false;
            this.ButtonX3.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_export_16px;
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonX4
            // 
            this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX4, "ButtonX4");
            this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX4.FocusCuesEnabled = false;
            this.ButtonX4.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonX4.Name = "ButtonX4";
            this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // LabelX4
            // 
            resources.ApplyResources(this.LabelX4, "LabelX4");
            this.LabelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Name = "LabelX4";
            // 
            // LabelX5
            // 
            resources.ApplyResources(this.LabelX5, "LabelX5");
            this.LabelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX5.Name = "LabelX5";
            // 
            // LabelX6
            // 
            resources.ApplyResources(this.LabelX6, "LabelX6");
            this.LabelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX6.Name = "LabelX6";
            // 
            // LabelX7
            // 
            resources.ApplyResources(this.LabelX7, "LabelX7");
            this.LabelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX7.Name = "LabelX7";
            // 
            // ButtonX5
            // 
            this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX5, "ButtonX5");
            this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX5.FocusCuesEnabled = false;
            this.ButtonX5.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_save_16px;
            this.ButtonX5.Name = "ButtonX5";
            this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX5.Click += new System.EventHandler(this.ButtonX5_Click);
            // 
            // ButtonX6
            // 
            this.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX6, "ButtonX6");
            this.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX6.FocusCuesEnabled = false;
            this.ButtonX6.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_move_node_up_16px;
            this.ButtonX6.Name = "ButtonX6";
            this.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX6.SymbolSize = 12F;
            this.ButtonX6.Click += new System.EventHandler(this.ButtonX6_Click);
            // 
            // ButtonX7
            // 
            this.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX7, "ButtonX7");
            this.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX7.FocusCuesEnabled = false;
            this.ButtonX7.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_move_node_down_16px;
            this.ButtonX7.Name = "ButtonX7";
            this.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX7.SymbolSize = 12F;
            this.ButtonX7.Click += new System.EventHandler(this.ButtonX7_Click);
            // 
            // ButtonX8
            // 
            this.ButtonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX8, "ButtonX8");
            this.ButtonX8.AutoExpandOnClick = true;
            this.ButtonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX8.FocusCuesEnabled = false;
            this.ButtonX8.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonX8.Name = "ButtonX8";
            this.ButtonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX8.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonX8.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX8.SymbolSize = 12F;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.advTree1);
            this.Panel1.Controls.Add(this.ButtonX8);
            this.Panel1.Controls.Add(this.ButtonX6);
            this.Panel1.Controls.Add(this.ComboBoxEx1);
            this.Panel1.Controls.Add(this.ButtonX7);
            this.Panel1.Controls.Add(this.LabelX4);
            this.Panel1.Controls.Add(this.ButtonX5);
            this.Panel1.Controls.Add(this.ButtonX3);
            this.Panel1.Controls.Add(this.LabelX7);
            this.Panel1.Controls.Add(this.ButtonX2);
            this.Panel1.Controls.Add(this.IntegerInput3);
            this.Panel1.Controls.Add(this.IntegerInput2);
            this.Panel1.Controls.Add(this.LabelX5);
            this.Panel1.Controls.Add(this.LabelX6);
            this.Panel1.Controls.Add(this.LabelX3);
            this.Panel1.Controls.Add(this.LabelX2);
            this.Panel1.Controls.Add(this.ButtonX4);
            this.Panel1.Controls.Add(this.ButtonX1);
            this.Panel1.Controls.Add(this.IntegerInput1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            resources.ApplyResources(this.advTree1, "advTree1");
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.advTree1.Columns.Add(this.columnHeader5);
            this.advTree1.Columns.Add(this.columnHeader6);
            this.advTree1.Columns.Add(this.columnHeader7);
            this.advTree1.Columns.Add(this.columnHeader8);
            this.advTree1.DragDropEnabled = false;
            this.advTree1.ExpandWidth = 0;
            this.advTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree1.MultiSelect = true;
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree1_AfterNodeSelect);
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
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            this.columnHeader5.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            this.columnHeader6.Width.Absolute = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            this.columnHeader7.Width.Absolute = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Name = "columnHeader8";
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            this.columnHeader8.Width.Absolute = 80;
            // 
            // TrajectoryEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrajectoryEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegerInput3)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx1;

        private DevComponents.Editors.IntegerInput IntegerInput1;

        private DevComponents.Editors.IntegerInput IntegerInput2;

        private DevComponents.Editors.IntegerInput IntegerInput3;

        private DevComponents.DotNetBar.LabelX LabelX2;

        private DevComponents.DotNetBar.LabelX LabelX3;

        private DevComponents.DotNetBar.ButtonX ButtonX1;

        private DevComponents.DotNetBar.ButtonX ButtonX2;

        private DevComponents.DotNetBar.ButtonX ButtonX3;

        private DevComponents.DotNetBar.ButtonX ButtonX4;

        private DevComponents.DotNetBar.LabelX LabelX4;

        private DevComponents.DotNetBar.LabelX LabelX5;

        private DevComponents.DotNetBar.LabelX LabelX6;

        private DevComponents.DotNetBar.LabelX LabelX7;

        private DevComponents.DotNetBar.ButtonX ButtonX5;

        private DevComponents.DotNetBar.ButtonX ButtonX6;

        private DevComponents.DotNetBar.ButtonX ButtonX7;

        private DevComponents.DotNetBar.ButtonX ButtonX8;

        private Panel Panel1;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.ColumnHeader columnHeader5;
        private DevComponents.AdvTree.ColumnHeader columnHeader6;
        private DevComponents.AdvTree.ColumnHeader columnHeader7;
        private DevComponents.AdvTree.ColumnHeader columnHeader8;
    }
}