using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.PatchScripts
{
    [DesignerGenerated()]
    public partial class TweakScriptEditor : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components = null;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweakScriptEditor));
            this.TextBoxX_ScriptDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxX_ScriptName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CheckBoxX_TweakScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.checkBoxX_DLL = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_PPFPatch = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_IPSPatch = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX_BPSPatch = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBoxX_ArmipsScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBoxX_CSharpScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBoxX_VBScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.itemPanel_SelectEmbeddedFile = new DevComponents.DotNetBar.ItemPanel();
            this.ItemListBox1 = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            this.TextBoxX_ReferenceName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonX_AddEmbeddedFile = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_RemoveEmbeddedFile = new DevComponents.DotNetBar.ButtonX();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CheckBoxX_AllowRevert = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_NewTemplate = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_SaveToFile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_LoadFromFile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RunInTestMode = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CheckForErrors = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ShowObjectCatalog = new DevComponents.DotNetBar.ButtonItem();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.AdvTree_EmbeddedFiles = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.LayoutControl1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_EmbeddedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxX_ScriptDescription
            // 
            this.TextBoxX_ScriptDescription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ScriptDescription.Border.Class = "TextBoxBorder";
            this.TextBoxX_ScriptDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ScriptDescription.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ScriptDescription.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TextBoxX_ScriptDescription, "TextBoxX_ScriptDescription");
            this.TextBoxX_ScriptDescription.Name = "TextBoxX_ScriptDescription";
            this.TextBoxX_ScriptDescription.PreventEnterBeep = true;
            this.TextBoxX_ScriptDescription.TextChanged += new System.EventHandler(this.AnyTextChanged);
            // 
            // TextBoxX_ScriptName
            // 
            this.TextBoxX_ScriptName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ScriptName.Border.Class = "TextBoxBorder";
            this.TextBoxX_ScriptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ScriptName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ScriptName.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TextBoxX_ScriptName, "TextBoxX_ScriptName");
            this.TextBoxX_ScriptName.Name = "TextBoxX_ScriptName";
            this.TextBoxX_ScriptName.PreventEnterBeep = true;
            this.TextBoxX_ScriptName.TextChanged += new System.EventHandler(this.AnyTextChanged);
            // 
            // CheckBoxX_TweakScript
            // 
            // 
            // 
            // 
            this.CheckBoxX_TweakScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_TweakScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxX_TweakScript.Checked = true;
            this.CheckBoxX_TweakScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxX_TweakScript.CheckValue = "Y";
            this.CheckBoxX_TweakScript.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_TweakScript, "CheckBoxX_TweakScript");
            this.CheckBoxX_TweakScript.Name = "CheckBoxX_TweakScript";
            this.CheckBoxX_TweakScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_TweakScript.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.checkBoxX_DLL);
            this.Panel1.Controls.Add(this.checkBoxX_PPFPatch);
            this.Panel1.Controls.Add(this.checkBoxX_IPSPatch);
            this.Panel1.Controls.Add(this.checkBoxX_BPSPatch);
            this.Panel1.Controls.Add(this.CheckBoxX_ArmipsScript);
            this.Panel1.Controls.Add(this.CheckBoxX_CSharpScript);
            this.Panel1.Controls.Add(this.CheckBoxX_VBScript);
            this.Panel1.Controls.Add(this.CheckBoxX_TweakScript);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // checkBoxX_DLL
            // 
            // 
            // 
            // 
            this.checkBoxX_DLL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_DLL.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX_DLL.FocusCuesEnabled = false;
            resources.ApplyResources(this.checkBoxX_DLL, "checkBoxX_DLL");
            this.checkBoxX_DLL.Name = "checkBoxX_DLL";
            this.checkBoxX_DLL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_DLL.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // checkBoxX_PPFPatch
            // 
            // 
            // 
            // 
            this.checkBoxX_PPFPatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_PPFPatch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX_PPFPatch.FocusCuesEnabled = false;
            resources.ApplyResources(this.checkBoxX_PPFPatch, "checkBoxX_PPFPatch");
            this.checkBoxX_PPFPatch.Name = "checkBoxX_PPFPatch";
            this.checkBoxX_PPFPatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_PPFPatch.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // checkBoxX_IPSPatch
            // 
            // 
            // 
            // 
            this.checkBoxX_IPSPatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_IPSPatch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX_IPSPatch.FocusCuesEnabled = false;
            resources.ApplyResources(this.checkBoxX_IPSPatch, "checkBoxX_IPSPatch");
            this.checkBoxX_IPSPatch.Name = "checkBoxX_IPSPatch";
            this.checkBoxX_IPSPatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_IPSPatch.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // checkBoxX_BPSPatch
            // 
            // 
            // 
            // 
            this.checkBoxX_BPSPatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_BPSPatch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX_BPSPatch.FocusCuesEnabled = false;
            resources.ApplyResources(this.checkBoxX_BPSPatch, "checkBoxX_BPSPatch");
            this.checkBoxX_BPSPatch.Name = "checkBoxX_BPSPatch";
            this.checkBoxX_BPSPatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_BPSPatch.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // CheckBoxX_ArmipsScript
            // 
            // 
            // 
            // 
            this.CheckBoxX_ArmipsScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_ArmipsScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxX_ArmipsScript.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_ArmipsScript, "CheckBoxX_ArmipsScript");
            this.CheckBoxX_ArmipsScript.Name = "CheckBoxX_ArmipsScript";
            this.CheckBoxX_ArmipsScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_ArmipsScript.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // CheckBoxX_CSharpScript
            // 
            // 
            // 
            // 
            this.CheckBoxX_CSharpScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_CSharpScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxX_CSharpScript.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_CSharpScript, "CheckBoxX_CSharpScript");
            this.CheckBoxX_CSharpScript.Name = "CheckBoxX_CSharpScript";
            this.CheckBoxX_CSharpScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_CSharpScript.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // CheckBoxX_VBScript
            // 
            // 
            // 
            // 
            this.CheckBoxX_VBScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxX_VBScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.CheckBoxX_VBScript.FocusCuesEnabled = false;
            resources.ApplyResources(this.CheckBoxX_VBScript, "CheckBoxX_VBScript");
            this.CheckBoxX_VBScript.Name = "CheckBoxX_VBScript";
            this.CheckBoxX_VBScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_VBScript.CheckedChanged += new System.EventHandler(this.CheckBoxX_ScriptChange_CheckedChanged);
            // 
            // Panel2
            // 
            resources.ApplyResources(this.Panel2, "Panel2");
            this.Panel2.Controls.Add(this.itemPanel_SelectEmbeddedFile);
            this.Panel2.Name = "Panel2";
            // 
            // itemPanel_SelectEmbeddedFile
            // 
            // 
            // 
            // 
            this.itemPanel_SelectEmbeddedFile.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel_SelectEmbeddedFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel_SelectEmbeddedFile.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(this.itemPanel_SelectEmbeddedFile, "itemPanel_SelectEmbeddedFile");
            this.itemPanel_SelectEmbeddedFile.DragDropSupport = true;
            this.itemPanel_SelectEmbeddedFile.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel_SelectEmbeddedFile.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.itemPanel_SelectEmbeddedFile.Name = "itemPanel_SelectEmbeddedFile";
            this.itemPanel_SelectEmbeddedFile.ReserveLeftSpace = false;
            this.itemPanel_SelectEmbeddedFile.ItemClick += new System.EventHandler(this.ItemPanel_SelectEmbeddedFile_ItemClick);
            // 
            // ItemListBox1
            // 
            resources.ApplyResources(this.ItemListBox1, "ItemListBox1");
            // 
            // 
            // 
            this.ItemListBox1.BackgroundStyle.Class = "ItemPanel";
            this.ItemListBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemListBox1.ContainerControlProcessDialogKey = true;
            this.ItemListBox1.DragDropSupport = true;
            this.ItemListBox1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ItemListBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ItemListBox1.Name = "ItemListBox1";
            this.ItemListBox1.ReserveLeftSpace = false;
            this.ItemListBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ItemListBox1.SelectedItemChanged += new SM64_ROM_Manager.Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(this.ItemListBox1_SelectedItemChanged);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.Controls.Add(this.TableLayoutPanel2);
            this.Panel3.Controls.Add(this.ItemListBox1);
            resources.ApplyResources(this.Panel3, "Panel3");
            this.Panel3.Name = "Panel3";
            // 
            // TableLayoutPanel2
            // 
            resources.ApplyResources(this.TableLayoutPanel2, "TableLayoutPanel2");
            this.TableLayoutPanel2.Controls.Add(this.ButtonX3, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.ButtonX4, 2, 0);
            this.TableLayoutPanel2.Controls.Add(this.TextBoxX_ReferenceName, 0, 0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            // 
            // ButtonX3
            // 
            this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX3.FocusCuesEnabled = false;
            this.ButtonX3.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(this.ButtonX3, "ButtonX3");
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonX4
            // 
            this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX4, "ButtonX4");
            this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX4.FocusCuesEnabled = false;
            this.ButtonX4.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_delete_sign_16px_1;
            this.ButtonX4.Name = "ButtonX4";
            this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // TextBoxX_ReferenceName
            // 
            resources.ApplyResources(this.TextBoxX_ReferenceName, "TextBoxX_ReferenceName");
            this.TextBoxX_ReferenceName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ReferenceName.Border.Class = "TextBoxBorder";
            this.TextBoxX_ReferenceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ReferenceName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ReferenceName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ReferenceName.Name = "TextBoxX_ReferenceName";
            this.TextBoxX_ReferenceName.PreventEnterBeep = true;
            // 
            // LayoutControl1
            // 
            resources.ApplyResources(this.LayoutControl1, "LayoutControl1");
            this.LayoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.LayoutControl1.Controls.Add(this.TextBoxX_ScriptName);
            this.LayoutControl1.Controls.Add(this.TextBoxX_ScriptDescription);
            this.LayoutControl1.Controls.Add(this.Panel1);
            this.LayoutControl1.Controls.Add(this.Panel3);
            this.LayoutControl1.Controls.Add(this.panel5);
            this.LayoutControl1.Controls.Add(this.panel6);
            this.LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            this.LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem1,
            this.LayoutControlItem2,
            this.LayoutControlItem3,
            this.layoutControlItem6,
            this.LayoutControlItem4,
            this.layoutControlItem5});
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.AdvTree_EmbeddedFiles);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.ButtonX_AddEmbeddedFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonX_RemoveEmbeddedFile, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ButtonX_AddEmbeddedFile
            // 
            this.ButtonX_AddEmbeddedFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_AddEmbeddedFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_AddEmbeddedFile.FocusCuesEnabled = false;
            this.ButtonX_AddEmbeddedFile.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(this.ButtonX_AddEmbeddedFile, "ButtonX_AddEmbeddedFile");
            this.ButtonX_AddEmbeddedFile.Name = "ButtonX_AddEmbeddedFile";
            this.ButtonX_AddEmbeddedFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_AddEmbeddedFile.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX_AddEmbeddedFile.Click += new System.EventHandler(this.ButtonX_AddEmbeddedFile_Click);
            // 
            // ButtonX_RemoveEmbeddedFile
            // 
            this.ButtonX_RemoveEmbeddedFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_RemoveEmbeddedFile, "ButtonX_RemoveEmbeddedFile");
            this.ButtonX_RemoveEmbeddedFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_RemoveEmbeddedFile.FocusCuesEnabled = false;
            this.ButtonX_RemoveEmbeddedFile.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_delete_sign_16px_1;
            this.ButtonX_RemoveEmbeddedFile.Name = "ButtonX_RemoveEmbeddedFile";
            this.ButtonX_RemoveEmbeddedFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_RemoveEmbeddedFile.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX_RemoveEmbeddedFile.Click += new System.EventHandler(this.ButtonX_RemoveEmbeddedFile_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.CheckBoxX_AllowRevert);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // CheckBoxX_AllowRevert
            // 
            // 
            // 
            // 
            this.CheckBoxX_AllowRevert.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.CheckBoxX_AllowRevert, "CheckBoxX_AllowRevert");
            this.CheckBoxX_AllowRevert.Name = "CheckBoxX_AllowRevert";
            this.CheckBoxX_AllowRevert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxX_AllowRevert.CheckedChanged += new System.EventHandler(this.CheckBoxX_AllowRevert_CheckedChanged);
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.TextBoxX_ScriptName;
            this.LayoutControlItem1.Height = 45;
            this.LayoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(this.LayoutControlItem1, "LayoutControlItem1");
            this.LayoutControlItem1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutControlItem1.Width = 100;
            this.LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.TextBoxX_ScriptDescription;
            this.LayoutControlItem2.Height = 100;
            this.LayoutControlItem2.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(this.LayoutControlItem2, "LayoutControlItem2");
            this.LayoutControlItem2.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutControlItem2.Width = 100;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.Panel1;
            this.LayoutControlItem3.Height = 77;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            resources.ApplyResources(this.LayoutControlItem3, "LayoutControlItem3");
            this.LayoutControlItem3.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutControlItem3.Width = 100;
            this.LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.panel6;
            this.layoutControlItem6.Height = 48;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem6.Name = "layoutControlItem6";
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutControlItem6.Width = 379;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.Panel3;
            this.LayoutControlItem4.Height = 200;
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            resources.ApplyResources(this.LayoutControlItem4, "LayoutControlItem4");
            this.LayoutControlItem4.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutControlItem4.Width = 100;
            this.LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.panel5;
            this.layoutControlItem5.Height = 183;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem5.Name = "layoutControlItem5";
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutControlItem5.Width = 379;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.Controls.Add(this.LayoutControl1);
            this.Panel4.Controls.Add(this.Panel2);
            resources.ApplyResources(this.Panel4, "Panel4");
            this.Panel4.Name = "Panel4";
            // 
            // Bar1
            // 
            resources.ApplyResources(this.Bar1, "Bar1");
            this.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Bar1.AntiAlias = true;
            this.Bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.Bar1.IsMaximized = false;
            this.Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem5,
            this.ButtonItem4,
            this.ButtonItem_ShowObjectCatalog});
            this.Bar1.MenuBar = true;
            this.Bar1.Name = "Bar1";
            this.Bar1.Stretch = true;
            this.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar1.TabStop = false;
            // 
            // ButtonItem5
            // 
            this.ButtonItem5.Name = "ButtonItem5";
            this.ButtonItem5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_NewTemplate,
            this.ButtonItem_SaveToFile,
            this.ButtonItem_LoadFromFile});
            resources.ApplyResources(this.ButtonItem5, "ButtonItem5");
            // 
            // ButtonItem_NewTemplate
            // 
            this.ButtonItem_NewTemplate.Name = "ButtonItem_NewTemplate";
            this.ButtonItem_NewTemplate.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem1,
            this.ButtonItem2});
            resources.ApplyResources(this.ButtonItem_NewTemplate, "ButtonItem_NewTemplate");
            // 
            // ButtonItem1
            // 
            this.ButtonItem1.GlobalItem = false;
            this.ButtonItem1.Name = "ButtonItem1";
            resources.ApplyResources(this.ButtonItem1, "ButtonItem1");
            this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // ButtonItem2
            // 
            this.ButtonItem2.GlobalItem = false;
            this.ButtonItem2.Name = "ButtonItem2";
            resources.ApplyResources(this.ButtonItem2, "ButtonItem2");
            this.ButtonItem2.Click += new System.EventHandler(this.ButtonItem2_Click);
            // 
            // ButtonItem_SaveToFile
            // 
            this.ButtonItem_SaveToFile.BeginGroup = true;
            this.ButtonItem_SaveToFile.GlobalItem = false;
            this.ButtonItem_SaveToFile.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_save_16px_1;
            this.ButtonItem_SaveToFile.Name = "ButtonItem_SaveToFile";
            resources.ApplyResources(this.ButtonItem_SaveToFile, "ButtonItem_SaveToFile");
            this.ButtonItem_SaveToFile.Click += new System.EventHandler(this.ButtonItem3_Click);
            // 
            // ButtonItem_LoadFromFile
            // 
            this.ButtonItem_LoadFromFile.GlobalItem = false;
            this.ButtonItem_LoadFromFile.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_open_folder_16px_1;
            this.ButtonItem_LoadFromFile.Name = "ButtonItem_LoadFromFile";
            resources.ApplyResources(this.ButtonItem_LoadFromFile, "ButtonItem_LoadFromFile");
            this.ButtonItem_LoadFromFile.Click += new System.EventHandler(this.ButtonItem4_Click);
            // 
            // ButtonItem4
            // 
            this.ButtonItem4.Name = "ButtonItem4";
            this.ButtonItem4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem3,
            this.ButtonItem_RunInTestMode,
            this.ButtonItem_CheckForErrors});
            resources.ApplyResources(this.ButtonItem4, "ButtonItem4");
            // 
            // ButtonItem3
            // 
            this.ButtonItem3.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_play_16px;
            this.ButtonItem3.Name = "ButtonItem3";
            resources.ApplyResources(this.ButtonItem3, "ButtonItem3");
            // 
            // ButtonItem_RunInTestMode
            // 
            this.ButtonItem_RunInTestMode.AutoCheckOnClick = true;
            this.ButtonItem_RunInTestMode.Checked = true;
            this.ButtonItem_RunInTestMode.GlobalItem = false;
            this.ButtonItem_RunInTestMode.Name = "ButtonItem_RunInTestMode";
            resources.ApplyResources(this.ButtonItem_RunInTestMode, "ButtonItem_RunInTestMode");
            this.ButtonItem_RunInTestMode.CheckedChanged += new System.EventHandler(this.ButtonItem_RunInTestMode_CheckedChanged);
            // 
            // ButtonItem_CheckForErrors
            // 
            this.ButtonItem_CheckForErrors.BeginGroup = true;
            this.ButtonItem_CheckForErrors.Name = "ButtonItem_CheckForErrors";
            resources.ApplyResources(this.ButtonItem_CheckForErrors, "ButtonItem_CheckForErrors");
            this.ButtonItem_CheckForErrors.Click += new System.EventHandler(this.ButtonX5_Click);
            // 
            // ButtonItem_ShowObjectCatalog
            // 
            this.ButtonItem_ShowObjectCatalog.Name = "ButtonItem_ShowObjectCatalog";
            resources.ApplyResources(this.ButtonItem_ShowObjectCatalog, "ButtonItem_ShowObjectCatalog");
            this.ButtonItem_ShowObjectCatalog.Click += new System.EventHandler(this.ButtonX_ShowObjectCatalog_Click);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            resources.ApplyResources(this.contextMenuBar1, "contextMenuBar1");
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabStop = false;
            // 
            // AdvTree_EmbeddedFiles
            // 
            this.AdvTree_EmbeddedFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            resources.ApplyResources(this.AdvTree_EmbeddedFiles, "AdvTree_EmbeddedFiles");
            this.AdvTree_EmbeddedFiles.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree_EmbeddedFiles.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree_EmbeddedFiles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree_EmbeddedFiles.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree_EmbeddedFiles.Name = "AdvTree_EmbeddedFiles";
            this.AdvTree_EmbeddedFiles.DragDropEnabled = false;
            this.AdvTree_EmbeddedFiles.ExpandWidth = 0;
            this.AdvTree_EmbeddedFiles.MultiSelect = false;
            this.AdvTree_EmbeddedFiles.NodesConnector = this.nodeConnector1;
            this.AdvTree_EmbeddedFiles.NodeStyle = this.elementStyle1;
            this.AdvTree_EmbeddedFiles.PathSeparator = ";";
            this.AdvTree_EmbeddedFiles.Styles.Add(this.elementStyle1);
            this.AdvTree_EmbeddedFiles.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree_EmbeddedFiles_AfterNodeSelect);
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
            // TweakScriptEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Bar1);
            this.Name = "TweakScriptEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.LayoutControl1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_EmbeddedFiles)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ScriptDescription;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ScriptName;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_TweakScript;

        private Panel Panel1;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_CSharpScript;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_VBScript;

        private Panel Panel2;

        private Publics.Controls.ItemListBox ItemListBox1;

        private Panel Panel3;

        private TableLayoutPanel TableLayoutPanel2;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ReferenceName;

        private DevComponents.DotNetBar.ButtonX ButtonX3;

        private DevComponents.DotNetBar.ButtonX ButtonX4;

        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

        private Panel Panel4;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;

        private DevComponents.DotNetBar.Bar Bar1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem5;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_NewTemplate;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_SaveToFile;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_LoadFromFile;

        private DevComponents.DotNetBar.ButtonItem ButtonItem1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem2;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CheckForErrors;

        private DevComponents.DotNetBar.ButtonItem ButtonItem3;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RunInTestMode;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowObjectCatalog;

        private DevComponents.DotNetBar.ButtonItem ButtonItem4;

        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_ArmipsScript;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX ButtonX_AddEmbeddedFile;
        private DevComponents.DotNetBar.ButtonX ButtonX_RemoveEmbeddedFile;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private Panel panel6;
        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_AllowRevert;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.ItemPanel itemPanel_SelectEmbeddedFile;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_PPFPatch;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_IPSPatch;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_BPSPatch;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_DLL;
        private DevComponents.AdvTree.AdvTree AdvTree_EmbeddedFiles;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}