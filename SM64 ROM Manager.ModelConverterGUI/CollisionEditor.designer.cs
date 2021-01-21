using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class CollisionEditor : DevComponents.DotNetBar.OfficeForm
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollisionEditor));
            this.TextBoxX_ColParam2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_ColParam1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX_ColParamsTipp = new DevComponents.DotNetBar.LabelX();
            this.LabelX_Param2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX_Param1 = new DevComponents.DotNetBar.LabelX();
            this.Button_SaveColsettings = new DevComponents.DotNetBar.ButtonX();
            this.LabelX48 = new DevComponents.DotNetBar.LabelX();
            this.CheckBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.CheckBoxX_IsNonSolid = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxX_SearchColTypes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AdvTree_ColTypes = new DevComponents.AdvTree.AdvTree();
            this.columnHeader_ColID = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader_ColTypeName = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.Panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_ColTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxX_ColParam2
            // 
            resources.ApplyResources(this.TextBoxX_ColParam2, "TextBoxX_ColParam2");
            this.TextBoxX_ColParam2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ColParam2.Border.Class = "TextBoxBorder";
            this.TextBoxX_ColParam2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ColParam2.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ColParam2.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ColParam2.Name = "TextBoxX_ColParam2";
            this.TextBoxX_ColParam2.PreventEnterBeep = true;
            this.TextBoxX_ColParam2.TextChanged += new System.EventHandler(this.TextBoxX_ColParam2_TextChanged);
            // 
            // TextBoxX_ColParam1
            // 
            resources.ApplyResources(this.TextBoxX_ColParam1, "TextBoxX_ColParam1");
            this.TextBoxX_ColParam1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ColParam1.Border.Class = "TextBoxBorder";
            this.TextBoxX_ColParam1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ColParam1.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ColParam1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ColParam1.Name = "TextBoxX_ColParam1";
            this.TextBoxX_ColParam1.PreventEnterBeep = true;
            this.TextBoxX_ColParam1.TextChanged += new System.EventHandler(this.TextBoxX_ColParam1_TextChanged);
            // 
            // LabelX_ColParamsTipp
            // 
            resources.ApplyResources(this.LabelX_ColParamsTipp, "LabelX_ColParamsTipp");
            // 
            // 
            // 
            this.LabelX_ColParamsTipp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_ColParamsTipp.Name = "LabelX_ColParamsTipp";
            this.LabelX_ColParamsTipp.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.LabelX_ColParamsTipp.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // LabelX_Param2
            // 
            // 
            // 
            // 
            this.LabelX_Param2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_Param2, "LabelX_Param2");
            this.LabelX_Param2.Name = "LabelX_Param2";
            this.LabelX_Param2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX_Param1
            // 
            // 
            // 
            // 
            this.LabelX_Param1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_Param1, "LabelX_Param1");
            this.LabelX_Param1.Name = "LabelX_Param1";
            this.LabelX_Param1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Button_SaveColsettings
            // 
            this.Button_SaveColsettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.Button_SaveColsettings, "Button_SaveColsettings");
            this.Button_SaveColsettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_SaveColsettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_SaveColsettings.FocusCuesEnabled = false;
            this.Button_SaveColsettings.Name = "Button_SaveColsettings";
            this.Button_SaveColsettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX48
            // 
            // 
            // 
            // 
            this.LabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX48, "LabelX48");
            this.LabelX48.Name = "LabelX48";
            this.LabelX48.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // CheckBoxX1
            // 
            // 
            // 
            // 
            this.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX1.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX1, "CheckBoxX1");
            this.CheckBoxX1.Name = "CheckBoxX1";
            this.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX1.CheckedChanged += new System.EventHandler(this.CheckBoxX1_CheckedChanging);
            // 
            // TextBoxX1
            // 
            resources.ApplyResources(this.TextBoxX1, "TextBoxX1");
            this.TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.PreventEnterBeep = true;
            this.TextBoxX1.TextChanged += new System.EventHandler(this.TextBoxX1_TextChanged);
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(this.SuperTooltip1, "SuperTooltip1");
            this.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // CheckBoxX_IsNonSolid
            // 
            // 
            // 
            // 
            this.CheckBoxX_IsNonSolid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_IsNonSolid.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_IsNonSolid, "CheckBoxX_IsNonSolid");
            this.CheckBoxX_IsNonSolid.Name = "CheckBoxX_IsNonSolid";
            this.CheckBoxX_IsNonSolid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_IsNonSolid.CheckedChanged += new System.EventHandler(this.ButtonItem_IsNonSolid_CheckedChanged);
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(this.CircularProgress1, "CircularProgress1");
            this.CircularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CircularProgress1.Name = "CircularProgress1";
            this.CircularProgress1.SetVisibleStateOnStart = true;
            this.CircularProgress1.SetVisibleStateOnStop = true;
            this.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.CircularProgress1);
            this.Panel2.Controls.Add(this.panel3);
            this.Panel2.Controls.Add(this.advTree1);
            this.Panel2.Controls.Add(this.LabelX48);
            this.Panel2.Controls.Add(this.Button_SaveColsettings);
            resources.ApplyResources(this.Panel2, "Panel2");
            this.Panel2.Name = "Panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.LabelX_ColParamsTipp);
            this.panel3.Controls.Add(this.TextBoxX_ColParam2);
            this.panel3.Controls.Add(this.TextBoxX_ColParam1);
            this.panel3.Controls.Add(this.LabelX_Param2);
            this.panel3.Controls.Add(this.LabelX_Param1);
            this.panel3.Controls.Add(this.CheckBoxX_IsNonSolid);
            this.panel3.Controls.Add(this.TextBoxX_SearchColTypes);
            this.panel3.Controls.Add(this.AdvTree_ColTypes);
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Controls.Add(this.CheckBoxX1);
            this.panel3.Controls.Add(this.TextBoxX1);
            this.panel3.Name = "panel3";
            // 
            // TextBoxX_SearchColTypes
            // 
            resources.ApplyResources(this.TextBoxX_SearchColTypes, "TextBoxX_SearchColTypes");
            // 
            // 
            // 
            this.TextBoxX_SearchColTypes.Border.Class = "TextBoxBorder";
            this.TextBoxX_SearchColTypes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_SearchColTypes.Name = "TextBoxX_SearchColTypes";
            this.TextBoxX_SearchColTypes.PreventEnterBeep = true;
            this.TextBoxX_SearchColTypes.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TextBoxX_SearchColTypes.TextChanged += new System.EventHandler(this.TextBoxX_SearchColTypes_TextChanged);
            // 
            // AdvTree_ColTypes
            // 
            this.AdvTree_ColTypes.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            resources.ApplyResources(this.AdvTree_ColTypes, "AdvTree_ColTypes");
            this.AdvTree_ColTypes.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree_ColTypes.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree_ColTypes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree_ColTypes.Columns.Add(this.columnHeader_ColID);
            this.AdvTree_ColTypes.Columns.Add(this.columnHeader_ColTypeName);
            this.AdvTree_ColTypes.ColumnsVisible = false;
            this.AdvTree_ColTypes.ExpandWidth = 0;
            this.AdvTree_ColTypes.GridColumnLines = false;
            this.AdvTree_ColTypes.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree_ColTypes.Name = "AdvTree_ColTypes";
            this.AdvTree_ColTypes.NodesConnector = this.nodeConnector2;
            this.AdvTree_ColTypes.NodeStyle = this.elementStyle2;
            this.AdvTree_ColTypes.PathSeparator = ";";
            this.AdvTree_ColTypes.Styles.Add(this.elementStyle2);
            this.AdvTree_ColTypes.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree_ColTypes_AfterNodeSelect);
            // 
            // columnHeader_ColID
            // 
            this.columnHeader_ColID.Name = "columnHeader_ColID";
            this.columnHeader_ColID.Width.Absolute = 20;
            // 
            // columnHeader_ColTypeName
            // 
            this.columnHeader_ColTypeName.Name = "columnHeader_ColTypeName";
            this.columnHeader_ColTypeName.StretchToFill = true;
            resources.ApplyResources(this.columnHeader_ColTypeName, "columnHeader_ColTypeName");
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // labelX1
            // 
            resources.ApplyResources(this.labelX1, "labelX1");
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Name = "labelX1";
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
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
            this.advTree1.DragDropEnabled = false;
            this.advTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree1.MultiSelect = true;
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.View = DevComponents.AdvTree.eView.Tile;
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
            // CollisionEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollisionEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_ColTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ColParam2;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ColParam1;

        private DevComponents.DotNetBar.LabelX LabelX_ColParamsTipp;

        private DevComponents.DotNetBar.LabelX LabelX_Param2;

        private DevComponents.DotNetBar.LabelX LabelX_Param1;

        private DevComponents.DotNetBar.ButtonX Button_SaveColsettings;

        private DevComponents.DotNetBar.LabelX LabelX48;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;

        private DevComponents.DotNetBar.SuperTooltip SuperTooltip1;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_IsNonSolid;

        private DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1;

        private System.Windows.Forms.Panel Panel2;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_SearchColTypes;
        private DevComponents.AdvTree.AdvTree AdvTree_ColTypes;
        private DevComponents.AdvTree.ColumnHeader columnHeader_ColID;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.AdvTree.ColumnHeader columnHeader_ColTypeName;
    }
}