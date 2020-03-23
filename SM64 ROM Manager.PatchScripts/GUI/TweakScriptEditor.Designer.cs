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
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TweakScriptEditor));
            _TextBoxX_ScriptDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ScriptDescription.TextChanged += new EventHandler(AnyTextChanged);
            _TextBoxX_ScriptName = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ScriptName.TextChanged += new EventHandler(AnyTextChanged);
            _CheckBoxX_TweakScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_TweakScript.CheckedChanged += new EventHandler(CheckBoxX_ScriptChange_CheckedChanged);
            _Panel1 = new Panel();
            _CheckBoxX_CSharpScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_CSharpScript.CheckedChanged += new EventHandler(CheckBoxX_ScriptChange_CheckedChanged);
            _CheckBoxX_VBScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_VBScript.CheckedChanged += new EventHandler(CheckBoxX_ScriptChange_CheckedChanged);
            _Panel2 = new Panel();
            _ItemListBox1 = new Publics.Controls.ItemListBox();
            _ItemListBox1.SelectedItemChanged += new Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(ItemListBox1_SelectedItemChanged);
            _Panel3 = new Panel();
            _TableLayoutPanel2 = new TableLayoutPanel();
            _ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX3.Click += new EventHandler(ButtonX3_Click);
            _ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX4.Click += new EventHandler(ButtonX4_Click);
            _TextBoxX_ReferenceName = new DevComponents.DotNetBar.Controls.TextBoxX();
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _Panel4 = new Panel();
            _Bar1 = new DevComponents.DotNetBar.Bar();
            _ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_NewTemplate = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem1.Click += new EventHandler(ButtonItem1_Click);
            _ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem2.Click += new EventHandler(ButtonItem2_Click);
            _ButtonItem_SaveToFile = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_SaveToFile.Click += new EventHandler(ButtonItem3_Click);
            _ButtonItem_LoadFromFile = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_LoadFromFile.Click += new EventHandler(ButtonItem4_Click);
            _ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RunInTestMode = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RunInTestMode.CheckedChanged += new EventHandler(ButtonItem_RunInTestMode_CheckedChanged);
            _ButtonItem_CheckForErrors = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_CheckForErrors.Click += new EventHandler(ButtonX5_Click);
            _ButtonItem_ShowObjectCatalog = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ShowObjectCatalog.Click += new EventHandler(ButtonX_ShowObjectCatalog_Click);
            _ButtonItem_ShowObjectCatalog.Click += new EventHandler(ButtonX_ShowObjectCatalog_Click);
            _ButtonItem_ShowObjectCatalog.Click += new EventHandler(ButtonX_ShowObjectCatalog_Click);
            _ButtonItem_ShowObjectCatalog.Click += new EventHandler(ButtonX_ShowObjectCatalog_Click);
            _CheckBoxX_ArmipsScript = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_ArmipsScript.CheckedChanged += new EventHandler(CheckBoxX_ScriptChange_CheckedChanged);
            _Panel1.SuspendLayout();
            _Panel3.SuspendLayout();
            _TableLayoutPanel2.SuspendLayout();
            _LayoutControl1.SuspendLayout();
            _Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Bar1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxX_ScriptDescription
            // 
            _TextBoxX_ScriptDescription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX_ScriptDescription.Border.Class = "TextBoxBorder";
            _TextBoxX_ScriptDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ScriptDescription.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX_ScriptDescription.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(_TextBoxX_ScriptDescription, "TextBoxX_ScriptDescription");
            _TextBoxX_ScriptDescription.Name = "TextBoxX_ScriptDescription";
            _TextBoxX_ScriptDescription.PreventEnterBeep = true;
            // 
            // TextBoxX_ScriptName
            // 
            _TextBoxX_ScriptName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX_ScriptName.Border.Class = "TextBoxBorder";
            _TextBoxX_ScriptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ScriptName.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX_ScriptName.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(_TextBoxX_ScriptName, "TextBoxX_ScriptName");
            _TextBoxX_ScriptName.Name = "TextBoxX_ScriptName";
            _TextBoxX_ScriptName.PreventEnterBeep = true;
            // 
            // CheckBoxX_TweakScript
            // 
            // 
            // 
            // 
            _CheckBoxX_TweakScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_TweakScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX_TweakScript.Checked = true;
            _CheckBoxX_TweakScript.CheckState = CheckState.Checked;
            _CheckBoxX_TweakScript.CheckValue = "Y";
            _CheckBoxX_TweakScript.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_TweakScript, "CheckBoxX_TweakScript");
            _CheckBoxX_TweakScript.Name = "CheckBoxX_TweakScript";
            _CheckBoxX_TweakScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_CheckBoxX_ArmipsScript);
            _Panel1.Controls.Add(_CheckBoxX_CSharpScript);
            _Panel1.Controls.Add(_CheckBoxX_VBScript);
            _Panel1.Controls.Add(_CheckBoxX_TweakScript);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // CheckBoxX_CSharpScript
            // 
            // 
            // 
            // 
            _CheckBoxX_CSharpScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_CSharpScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX_CSharpScript.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_CSharpScript, "CheckBoxX_CSharpScript");
            _CheckBoxX_CSharpScript.Name = "CheckBoxX_CSharpScript";
            _CheckBoxX_CSharpScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_VBScript
            // 
            // 
            // 
            // 
            _CheckBoxX_VBScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_VBScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX_VBScript.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_VBScript, "CheckBoxX_VBScript");
            _CheckBoxX_VBScript.Name = "CheckBoxX_VBScript";
            _CheckBoxX_VBScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel2
            // 
            resources.ApplyResources(_Panel2, "Panel2");
            _Panel2.Name = "Panel2";
            // 
            // ItemListBox1
            // 
            resources.ApplyResources(_ItemListBox1, "ItemListBox1");
            // 
            // 
            // 
            _ItemListBox1.BackgroundStyle.Class = "ItemPanel";
            _ItemListBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemListBox1.ContainerControlProcessDialogKey = true;
            _ItemListBox1.DragDropSupport = true;
            _ItemListBox1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemListBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemListBox1.Name = "ItemListBox1";
            _ItemListBox1.ReserveLeftSpace = false;
            _ItemListBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel3
            // 
            _Panel3.BackColor = System.Drawing.Color.Transparent;
            _Panel3.Controls.Add(_TableLayoutPanel2);
            _Panel3.Controls.Add(_ItemListBox1);
            resources.ApplyResources(_Panel3, "Panel3");
            _Panel3.Name = "Panel3";
            // 
            // TableLayoutPanel2
            // 
            resources.ApplyResources(_TableLayoutPanel2, "TableLayoutPanel2");
            _TableLayoutPanel2.Controls.Add(_ButtonX3, 1, 0);
            _TableLayoutPanel2.Controls.Add(_ButtonX4, 2, 0);
            _TableLayoutPanel2.Controls.Add(_TextBoxX_ReferenceName, 0, 0);
            _TableLayoutPanel2.Name = "TableLayoutPanel2";
            // 
            // ButtonX3
            // 
            _ButtonX3.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX3.FocusCuesEnabled = false;
            resources.ApplyResources(_ButtonX3, "ButtonX3");
            _ButtonX3.Name = "ButtonX3";
            _ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX3.Symbol = "57669";
            _ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX3.SymbolSize = 12.0F;
            // 
            // ButtonX4
            // 
            _ButtonX4.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX4, "ButtonX4");
            _ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX4.FocusCuesEnabled = false;
            _ButtonX4.Name = "ButtonX4";
            _ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX4.Symbol = "57676";
            _ButtonX4.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX4.SymbolSize = 12.0F;
            // 
            // TextBoxX_ReferenceName
            // 
            resources.ApplyResources(_TextBoxX_ReferenceName, "TextBoxX_ReferenceName");
            _TextBoxX_ReferenceName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX_ReferenceName.Border.Class = "TextBoxBorder";
            _TextBoxX_ReferenceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ReferenceName.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX_ReferenceName.ForeColor = System.Drawing.Color.Black;
            _TextBoxX_ReferenceName.Name = "TextBoxX_ReferenceName";
            _TextBoxX_ReferenceName.PreventEnterBeep = true;
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = System.Drawing.Color.Transparent;
            _LayoutControl1.Controls.Add(_TextBoxX_ScriptName);
            _LayoutControl1.Controls.Add(_TextBoxX_ScriptDescription);
            _LayoutControl1.Controls.Add(_Panel1);
            _LayoutControl1.Controls.Add(_Panel3);
            resources.ApplyResources(_LayoutControl1, "LayoutControl1");
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem1, _LayoutControlItem2, _LayoutControlItem3, _LayoutControlItem4 });
            // 
            // LayoutControlItem1
            // 
            _LayoutControlItem1.Control = _TextBoxX_ScriptName;
            _LayoutControlItem1.Height = 45;
            _LayoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            _LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(_LayoutControlItem1, "LayoutControlItem1");
            _LayoutControlItem1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutControlItem1.Width = 100;
            _LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _TextBoxX_ScriptDescription;
            _LayoutControlItem2.Height = 200;
            _LayoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(_LayoutControlItem2, "LayoutControlItem2");
            _LayoutControlItem2.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutControlItem2.Width = 100;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _Panel1;
            _LayoutControlItem3.Height = 48;
            _LayoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            resources.ApplyResources(_LayoutControlItem3, "LayoutControlItem3");
            _LayoutControlItem3.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutControlItem3.Width = 100;
            _LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            _LayoutControlItem4.Control = _Panel3;
            _LayoutControlItem4.Height = 100;
            _LayoutControlItem4.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            _LayoutControlItem4.MinSize = new System.Drawing.Size(64, 18);
            _LayoutControlItem4.Name = "LayoutControlItem4";
            resources.ApplyResources(_LayoutControlItem4, "LayoutControlItem4");
            _LayoutControlItem4.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutControlItem4.Width = 100;
            _LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // Panel4
            // 
            _Panel4.BackColor = System.Drawing.Color.Transparent;
            _Panel4.Controls.Add(_LayoutControl1);
            _Panel4.Controls.Add(_Panel2);
            resources.ApplyResources(_Panel4, "Panel4");
            _Panel4.Name = "Panel4";
            // 
            // Bar1
            // 
            resources.ApplyResources(_Bar1, "Bar1");
            _Bar1.AccessibleRole = AccessibleRole.MenuBar;
            _Bar1.AntiAlias = true;
            _Bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            _Bar1.IsMaximized = false;
            _Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem5, _ButtonItem4, _ButtonItem_ShowObjectCatalog });
            _Bar1.MenuBar = true;
            _Bar1.Name = "Bar1";
            _Bar1.Stretch = true;
            _Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _Bar1.TabStop = false;
            // 
            // ButtonItem5
            // 
            _ButtonItem5.Name = "ButtonItem5";
            _ButtonItem5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_NewTemplate, _ButtonItem_SaveToFile, _ButtonItem_LoadFromFile });
            resources.ApplyResources(_ButtonItem5, "ButtonItem5");
            // 
            // ButtonItem_NewTemplate
            // 
            _ButtonItem_NewTemplate.Name = "ButtonItem_NewTemplate";
            _ButtonItem_NewTemplate.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem1, _ButtonItem2 });
            resources.ApplyResources(_ButtonItem_NewTemplate, "ButtonItem_NewTemplate");
            // 
            // ButtonItem1
            // 
            _ButtonItem1.GlobalItem = false;
            _ButtonItem1.Name = "ButtonItem1";
            resources.ApplyResources(_ButtonItem1, "ButtonItem1");
            // 
            // ButtonItem2
            // 
            _ButtonItem2.GlobalItem = false;
            _ButtonItem2.Name = "ButtonItem2";
            resources.ApplyResources(_ButtonItem2, "ButtonItem2");
            // 
            // ButtonItem_SaveToFile
            // 
            _ButtonItem_SaveToFile.BeginGroup = true;
            _ButtonItem_SaveToFile.GlobalItem = false;
            _ButtonItem_SaveToFile.Image = MyIcons.icons8_save_16px_1;
            _ButtonItem_SaveToFile.Name = "ButtonItem_SaveToFile";
            resources.ApplyResources(_ButtonItem_SaveToFile, "ButtonItem_SaveToFile");
            // 
            // ButtonItem_LoadFromFile
            // 
            _ButtonItem_LoadFromFile.GlobalItem = false;
            _ButtonItem_LoadFromFile.Image = MyIcons.icons8_open_folder_16px_1;
            _ButtonItem_LoadFromFile.Name = "ButtonItem_LoadFromFile";
            resources.ApplyResources(_ButtonItem_LoadFromFile, "ButtonItem_LoadFromFile");
            // 
            // ButtonItem4
            // 
            _ButtonItem4.Name = "ButtonItem4";
            _ButtonItem4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem3, _ButtonItem_RunInTestMode, _ButtonItem_CheckForErrors });
            resources.ApplyResources(_ButtonItem4, "ButtonItem4");
            // 
            // ButtonItem3
            // 
            _ButtonItem3.Image = MyIcons.icons8_play_16px;
            _ButtonItem3.Name = "ButtonItem3";
            resources.ApplyResources(_ButtonItem3, "ButtonItem3");
            // 
            // ButtonItem_RunInTestMode
            // 
            _ButtonItem_RunInTestMode.AutoCheckOnClick = true;
            _ButtonItem_RunInTestMode.Checked = true;
            _ButtonItem_RunInTestMode.GlobalItem = false;
            _ButtonItem_RunInTestMode.Name = "ButtonItem_RunInTestMode";
            resources.ApplyResources(_ButtonItem_RunInTestMode, "ButtonItem_RunInTestMode");
            // 
            // ButtonItem_CheckForErrors
            // 
            _ButtonItem_CheckForErrors.BeginGroup = true;
            _ButtonItem_CheckForErrors.Name = "ButtonItem_CheckForErrors";
            resources.ApplyResources(_ButtonItem_CheckForErrors, "ButtonItem_CheckForErrors");
            // 
            // ButtonItem_ShowObjectCatalog
            // 
            _ButtonItem_ShowObjectCatalog.Name = "ButtonItem_ShowObjectCatalog";
            resources.ApplyResources(_ButtonItem_ShowObjectCatalog, "ButtonItem_ShowObjectCatalog");
            // 
            // CheckBoxX_ArmipsScript
            // 
            // 
            // 
            // 
            _CheckBoxX_ArmipsScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_ArmipsScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX_ArmipsScript.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_ArmipsScript, "CheckBoxX_ArmipsScript");
            _CheckBoxX_ArmipsScript.Name = "CheckBoxX_ArmipsScript";
            _CheckBoxX_ArmipsScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TweakScriptEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel4);
            Controls.Add(_Bar1);
            Name = "TweakScriptEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            _Panel3.ResumeLayout(false);
            _Panel3.PerformLayout();
            _TableLayoutPanel2.ResumeLayout(false);
            _LayoutControl1.ResumeLayout(false);
            _Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_Bar1).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ScriptDescription;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ScriptDescription
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ScriptDescription;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ScriptDescription != null)
                {
                    _TextBoxX_ScriptDescription.TextChanged -= AnyTextChanged;
                }

                _TextBoxX_ScriptDescription = value;
                if (_TextBoxX_ScriptDescription != null)
                {
                    _TextBoxX_ScriptDescription.TextChanged += AnyTextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ScriptName;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ScriptName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ScriptName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ScriptName != null)
                {
                    _TextBoxX_ScriptName.TextChanged -= AnyTextChanged;
                }

                _TextBoxX_ScriptName = value;
                if (_TextBoxX_ScriptName != null)
                {
                    _TextBoxX_ScriptName.TextChanged += AnyTextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_TweakScript;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_TweakScript
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_TweakScript;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_TweakScript != null)
                {
                    _CheckBoxX_TweakScript.CheckedChanged -= CheckBoxX_ScriptChange_CheckedChanged;
                }

                _CheckBoxX_TweakScript = value;
                if (_CheckBoxX_TweakScript != null)
                {
                    _CheckBoxX_TweakScript.CheckedChanged += CheckBoxX_ScriptChange_CheckedChanged;
                }
            }
        }

        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_CSharpScript;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_CSharpScript
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_CSharpScript;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_CSharpScript != null)
                {
                    _CheckBoxX_CSharpScript.CheckedChanged -= CheckBoxX_ScriptChange_CheckedChanged;
                }

                _CheckBoxX_CSharpScript = value;
                if (_CheckBoxX_CSharpScript != null)
                {
                    _CheckBoxX_CSharpScript.CheckedChanged += CheckBoxX_ScriptChange_CheckedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_VBScript;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_VBScript
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_VBScript;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_VBScript != null)
                {
                    _CheckBoxX_VBScript.CheckedChanged -= CheckBoxX_ScriptChange_CheckedChanged;
                }

                _CheckBoxX_VBScript = value;
                if (_CheckBoxX_VBScript != null)
                {
                    _CheckBoxX_VBScript.CheckedChanged += CheckBoxX_ScriptChange_CheckedChanged;
                }
            }
        }

        private Panel _Panel2;

        internal Panel Panel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel2 != null)
                {
                }

                _Panel2 = value;
                if (_Panel2 != null)
                {
                }
            }
        }

        private Publics.Controls.ItemListBox _ItemListBox1;

        internal Publics.Controls.ItemListBox ItemListBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemListBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemListBox1 != null)
                {
                    _ItemListBox1.SelectedItemChanged -= ItemListBox1_SelectedItemChanged;
                }

                _ItemListBox1 = value;
                if (_ItemListBox1 != null)
                {
                    _ItemListBox1.SelectedItemChanged += ItemListBox1_SelectedItemChanged;
                }
            }
        }

        private Panel _Panel3;

        internal Panel Panel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel3 != null)
                {
                }

                _Panel3 = value;
                if (_Panel3 != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel2;

        internal TableLayoutPanel TableLayoutPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel2 != null)
                {
                }

                _TableLayoutPanel2 = value;
                if (_TableLayoutPanel2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ReferenceName;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ReferenceName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ReferenceName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ReferenceName != null)
                {
                }

                _TextBoxX_ReferenceName = value;
                if (_TextBoxX_ReferenceName != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX3;

        internal DevComponents.DotNetBar.ButtonX ButtonX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX3 != null)
                {
                    _ButtonX3.Click -= ButtonX3_Click;
                }

                _ButtonX3 = value;
                if (_ButtonX3 != null)
                {
                    _ButtonX3.Click += ButtonX3_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX4;

        internal DevComponents.DotNetBar.ButtonX ButtonX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click -= ButtonX4_Click;
                }

                _ButtonX4 = value;
                if (_ButtonX4 != null)
                {
                    _ButtonX4.Click += ButtonX4_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControl1 != null)
                {
                }

                _LayoutControl1 = value;
                if (_LayoutControl1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem1;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem1 != null)
                {
                }

                _LayoutControlItem1 = value;
                if (_LayoutControlItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem2;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem2 != null)
                {
                }

                _LayoutControlItem2 = value;
                if (_LayoutControlItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem3 != null)
                {
                }

                _LayoutControlItem3 = value;
                if (_LayoutControlItem3 != null)
                {
                }
            }
        }

        private Panel _Panel4;

        internal Panel Panel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel4 != null)
                {
                }

                _Panel4 = value;
                if (_Panel4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem4;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem4 != null)
                {
                }

                _LayoutControlItem4 = value;
                if (_LayoutControlItem4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Bar _Bar1;

        internal DevComponents.DotNetBar.Bar Bar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Bar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Bar1 != null)
                {
                }

                _Bar1 = value;
                if (_Bar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem5;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem5 != null)
                {
                }

                _ButtonItem5 = value;
                if (_ButtonItem5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_NewTemplate;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_NewTemplate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_NewTemplate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_NewTemplate != null)
                {
                }

                _ButtonItem_NewTemplate = value;
                if (_ButtonItem_NewTemplate != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_SaveToFile;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_SaveToFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_SaveToFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_SaveToFile != null)
                {
                    _ButtonItem_SaveToFile.Click -= ButtonItem3_Click;
                }

                _ButtonItem_SaveToFile = value;
                if (_ButtonItem_SaveToFile != null)
                {
                    _ButtonItem_SaveToFile.Click += ButtonItem3_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_LoadFromFile;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_LoadFromFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_LoadFromFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_LoadFromFile != null)
                {
                    _ButtonItem_LoadFromFile.Click -= ButtonItem4_Click;
                }

                _ButtonItem_LoadFromFile = value;
                if (_ButtonItem_LoadFromFile != null)
                {
                    _ButtonItem_LoadFromFile.Click += ButtonItem4_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem1;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click -= ButtonItem1_Click;
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click += ButtonItem1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem2;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click -= ButtonItem2_Click;
                }

                _ButtonItem2 = value;
                if (_ButtonItem2 != null)
                {
                    _ButtonItem2.Click += ButtonItem2_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CheckForErrors;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CheckForErrors
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CheckForErrors;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CheckForErrors != null)
                {
                    _ButtonItem_CheckForErrors.Click -= ButtonX5_Click;
                }

                _ButtonItem_CheckForErrors = value;
                if (_ButtonItem_CheckForErrors != null)
                {
                    _ButtonItem_CheckForErrors.Click += ButtonX5_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem3;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem3 != null)
                {
                }

                _ButtonItem3 = value;
                if (_ButtonItem3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RunInTestMode;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RunInTestMode
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RunInTestMode;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RunInTestMode != null)
                {
                    _ButtonItem_RunInTestMode.CheckedChanged -= ButtonItem_RunInTestMode_CheckedChanged;
                }

                _ButtonItem_RunInTestMode = value;
                if (_ButtonItem_RunInTestMode != null)
                {
                    _ButtonItem_RunInTestMode.CheckedChanged += ButtonItem_RunInTestMode_CheckedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ShowObjectCatalog;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ShowObjectCatalog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ShowObjectCatalog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ShowObjectCatalog != null)
                {
                    _ButtonItem_ShowObjectCatalog.Click -= ButtonX_ShowObjectCatalog_Click;
                    _ButtonItem_ShowObjectCatalog.Click -= ButtonX_ShowObjectCatalog_Click;
                }

                _ButtonItem_ShowObjectCatalog = value;
                if (_ButtonItem_ShowObjectCatalog != null)
                {
                    _ButtonItem_ShowObjectCatalog.Click += ButtonX_ShowObjectCatalog_Click;
                    _ButtonItem_ShowObjectCatalog.Click += ButtonX_ShowObjectCatalog_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem4;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem4 != null)
                {
                }

                _ButtonItem4 = value;
                if (_ButtonItem4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_ArmipsScript;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_ArmipsScript
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_ArmipsScript;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_ArmipsScript != null)
                {
                    _CheckBoxX_ArmipsScript.CheckedChanged -= CheckBoxX_ScriptChange_CheckedChanged;
                }

                _CheckBoxX_ArmipsScript = value;
                if (_CheckBoxX_ArmipsScript != null)
                {
                    _CheckBoxX_ArmipsScript.CheckedChanged += CheckBoxX_ScriptChange_CheckedChanged;
                }
            }
        }
    }
}