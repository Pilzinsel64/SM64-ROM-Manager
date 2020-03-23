using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.PatchScripts
{
    [DesignerGenerated()]
    public partial class TweakViewer : DevComponents.DotNetBar.OfficeForm
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TweakViewer));
            _Panel1 = new Panel();
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _Panel3 = new Panel();
            _ButtonX8 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX8.Click += new EventHandler(ButtonX8_Click);
            _TableLayoutPanel2 = new TableLayoutPanel();
            _ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX5.Click += new EventHandler(ButtonX5_Click);
            _ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX3.Click += new EventHandler(ButtonX3_Click);
            _ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX2.Click += new EventHandler(ButtonX2_Click);
            _LabelX_Description = new DevComponents.DotNetBar.LabelX();
            _LabelX_Description.TextChanged += new EventHandler(LabelX_Description_MouseEnter);
            _LabelX_PatchName = new DevComponents.DotNetBar.LabelX();
            _TableLayoutPanel1 = new TableLayoutPanel();
            _ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX1.Click += new EventHandler(ButtonX1_Click);
            _ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX6.Click += new EventHandler(ButtonX6_Click);
            _ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX4.Click += new EventHandler(ButtonX4_Click);
            _ComboBoxEx_Scripts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_Scripts.SelectedIndexChanged += new EventHandler(ComboBoxEx_Scripts_SelectedIndexChanged);
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _Flyout1 = new DevComponents.DotNetBar.Controls.Flyout(components);
            _Flyout1.FlyoutShown += new EventHandler(Flyout1_FlyoutShown);
            _ItemListBox1 = new Publics.Controls.ItemListBox();
            _ItemListBox1.SelectedItemChanged += new Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(ItemListBox1_SelectedItemChanged);
            _ItemListBox1.Scroll += new ScrollEventHandler(ItemListBox1_Scroll);
            _SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            _TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX1.KeyDown += new KeyEventHandler(TextBoxX1_KeyDown);
            _CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            _ButtonX9 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX9.Click += new EventHandler(ButtonX9_Click);
            _Panel2 = new Panel();
            _WarningBox_TweakUpdates = new DevComponents.DotNetBar.Controls.WarningBox();
            _WarningBox_TweakUpdates.OptionsClick += new EventHandler(WarningBox_TweakUpdates_OptionsClick);
            _ButtonX7 = new DevComponents.DotNetBar.ButtonX();
            _ButtonX7.Click += new EventHandler(ButtonX7_Click);
            _ButtonX_AddNew = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_AddNew.Click += new EventHandler(ButtonX_AddNew_Click);
            _Panel1.SuspendLayout();
            _Panel3.SuspendLayout();
            _TableLayoutPanel2.SuspendLayout();
            _TableLayoutPanel1.SuspendLayout();
            _Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_LabelX2);
            _Panel1.Controls.Add(_Panel3);
            _Panel1.Controls.Add(_TableLayoutPanel2);
            _Panel1.Controls.Add(_LabelX_Description);
            _Panel1.Controls.Add(_LabelX_PatchName);
            _Panel1.Controls.Add(_TableLayoutPanel1);
            _Panel1.Controls.Add(_ComboBoxEx_Scripts);
            _Panel1.Controls.Add(_LabelX1);
            _Panel1.Name = "Panel1";
            _SuperTooltip1.SetSuperTooltip(_Panel1, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("Panel1.SuperTooltip"));
            // 
            // LabelX2
            // 
            resources.ApplyResources(_LabelX2, "LabelX2");
            _LabelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Name = "LabelX2";
            _SuperTooltip1.SetSuperTooltip(_LabelX2, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("LabelX2.SuperTooltip"));
            // 
            // Panel3
            // 
            resources.ApplyResources(_Panel3, "Panel3");
            _Panel3.BackColor = System.Drawing.Color.Transparent;
            _Panel3.Controls.Add(_ButtonX8);
            _Panel3.Name = "Panel3";
            _SuperTooltip1.SetSuperTooltip(_Panel3, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("Panel3.SuperTooltip"));
            // 
            // ButtonX8
            // 
            resources.ApplyResources(_ButtonX8, "ButtonX8");
            _ButtonX8.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX8.FocusCuesEnabled = false;
            _ButtonX8.Image = MyIcons.icons8_triggering_16px;
            _ButtonX8.Name = "ButtonX8";
            _ButtonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX8, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX8.SuperTooltip"));
            _ButtonX8.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // TableLayoutPanel2
            // 
            resources.ApplyResources(_TableLayoutPanel2, "TableLayoutPanel2");
            _TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            _TableLayoutPanel2.Controls.Add(_ButtonX5, 1, 0);
            _TableLayoutPanel2.Controls.Add(_ButtonX3, 2, 0);
            _TableLayoutPanel2.Controls.Add(_ButtonX2, 0, 0);
            _TableLayoutPanel2.Name = "TableLayoutPanel2";
            _SuperTooltip1.SetSuperTooltip(_TableLayoutPanel2, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("TableLayoutPanel2.SuperTooltip"));
            // 
            // ButtonX5
            // 
            resources.ApplyResources(_ButtonX5, "ButtonX5");
            _ButtonX5.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX5.FocusCuesEnabled = false;
            _ButtonX5.Image = MyIcons.icons8_delete_sign_16px_1;
            _ButtonX5.Name = "ButtonX5";
            _ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX5, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX5.SuperTooltip"));
            _ButtonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // ButtonX3
            // 
            resources.ApplyResources(_ButtonX3, "ButtonX3");
            _ButtonX3.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX3.FocusCuesEnabled = false;
            _ButtonX3.Image = MyIcons.icons8_cancel_16px;
            _ButtonX3.Name = "ButtonX3";
            _ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX3, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX3.SuperTooltip"));
            _ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // ButtonX2
            // 
            resources.ApplyResources(_ButtonX2, "ButtonX2");
            _ButtonX2.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX2.FocusCuesEnabled = false;
            _ButtonX2.Image = MyIcons.icons8_edit_16px;
            _ButtonX2.Name = "ButtonX2";
            _ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX2, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX2.SuperTooltip"));
            _ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // LabelX_Description
            // 
            resources.ApplyResources(_LabelX_Description, "LabelX_Description");
            _LabelX_Description.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            _LabelX_Description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Description.Name = "LabelX_Description";
            _SuperTooltip1.SetSuperTooltip(_LabelX_Description, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("LabelX_Description.SuperTooltip"));
            _LabelX_Description.TextLineAlignment = System.Drawing.StringAlignment.Near;
            _LabelX_Description.WordWrap = true;
            // 
            // LabelX_PatchName
            // 
            resources.ApplyResources(_LabelX_PatchName, "LabelX_PatchName");
            _LabelX_PatchName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            _LabelX_PatchName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_PatchName.Name = "LabelX_PatchName";
            _SuperTooltip1.SetSuperTooltip(_LabelX_PatchName, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("LabelX_PatchName.SuperTooltip"));
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(_TableLayoutPanel1, "TableLayoutPanel1");
            _TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            _TableLayoutPanel1.Controls.Add(_ButtonX1, 0, 0);
            _TableLayoutPanel1.Controls.Add(_ButtonX6, 1, 0);
            _TableLayoutPanel1.Controls.Add(_ButtonX4, 2, 0);
            _TableLayoutPanel1.Name = "TableLayoutPanel1";
            _SuperTooltip1.SetSuperTooltip(_TableLayoutPanel1, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("TableLayoutPanel1.SuperTooltip"));
            // 
            // ButtonX1
            // 
            resources.ApplyResources(_ButtonX1, "ButtonX1");
            _ButtonX1.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX1.FocusCuesEnabled = false;
            _ButtonX1.Image = MyIcons.icons8_plus_math_16px;
            _ButtonX1.Name = "ButtonX1";
            _ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX1, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX1.SuperTooltip"));
            _ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // ButtonX6
            // 
            resources.ApplyResources(_ButtonX6, "ButtonX6");
            _ButtonX6.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX6.FocusCuesEnabled = false;
            _ButtonX6.Image = MyIcons.icons8_edit_16px;
            _ButtonX6.Name = "ButtonX6";
            _ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX6, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX6.SuperTooltip"));
            _ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // ButtonX4
            // 
            resources.ApplyResources(_ButtonX4, "ButtonX4");
            _ButtonX4.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX4.FocusCuesEnabled = false;
            _ButtonX4.Image = MyIcons.icons8_delete_sign_16px_1;
            _ButtonX4.Name = "ButtonX4";
            _ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX4, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX4.SuperTooltip"));
            _ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // ComboBoxEx_Scripts
            // 
            resources.ApplyResources(_ComboBoxEx_Scripts, "ComboBoxEx_Scripts");
            _ComboBoxEx_Scripts.DisplayMember = "Text";
            _ComboBoxEx_Scripts.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx_Scripts.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBoxEx_Scripts.ForeColor = System.Drawing.Color.Black;
            _ComboBoxEx_Scripts.FormattingEnabled = true;
            _ComboBoxEx_Scripts.Name = "ComboBoxEx_Scripts";
            _ComboBoxEx_Scripts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ComboBoxEx_Scripts, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ComboBoxEx_Scripts.SuperTooltip"));
            // 
            // LabelX1
            // 
            resources.ApplyResources(_LabelX1, "LabelX1");
            _LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Name = "LabelX1";
            _SuperTooltip1.SetSuperTooltip(_LabelX1, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("LabelX1.SuperTooltip"));
            // 
            // Flyout1
            // 
            _Flyout1.Content = _Panel1;
            _Flyout1.DisplayMode = DevComponents.DotNetBar.Controls.eFlyoutDisplayMode.Manual;
            _Flyout1.DropShadow = false;
            _Flyout1.Parent = this;
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
            _SuperTooltip1.SetSuperTooltip(_ItemListBox1, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ItemListBox1.SuperTooltip"));
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(_SuperTooltip1, "SuperTooltip1");
            _SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // TextBoxX1
            // 
            resources.ApplyResources(_TextBoxX1, "TextBoxX1");
            _TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX1.Border.Class = "TextBoxBorder";
            _TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX1.ButtonCustom.DisplayPosition = Conversions.ToInteger(resources.GetObject("TextBoxX1.ButtonCustom.DisplayPosition"));
            _TextBoxX1.ButtonCustom.Image = (System.Drawing.Image)resources.GetObject("TextBoxX1.ButtonCustom.Image");
            _TextBoxX1.ButtonCustom.Text = resources.GetString("TextBoxX1.ButtonCustom.Text");
            _TextBoxX1.ButtonCustom.Tooltip = resources.GetString("TextBoxX1.ButtonCustom.Tooltip");
            _TextBoxX1.ButtonCustom2.DisplayPosition = Conversions.ToInteger(resources.GetObject("TextBoxX1.ButtonCustom2.DisplayPosition"));
            _TextBoxX1.ButtonCustom2.Image = (System.Drawing.Image)resources.GetObject("TextBoxX1.ButtonCustom2.Image");
            _TextBoxX1.ButtonCustom2.Text = resources.GetString("TextBoxX1.ButtonCustom2.Text");
            _TextBoxX1.ButtonCustom2.Tooltip = resources.GetString("TextBoxX1.ButtonCustom2.Tooltip");
            _TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX1.ForeColor = System.Drawing.Color.Black;
            _TextBoxX1.Name = "TextBoxX1";
            _TextBoxX1.PreventEnterBeep = true;
            _SuperTooltip1.SetSuperTooltip(_TextBoxX1, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("TextBoxX1.SuperTooltip"));
            _TextBoxX1.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(_CircularProgress1, "CircularProgress1");
            // 
            // 
            // 
            _CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CircularProgress1.Name = "CircularProgress1";
            _CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            _CircularProgress1.SetVisibleStateOnStart = true;
            _CircularProgress1.SetVisibleStateOnStop = true;
            _CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            _SuperTooltip1.SetSuperTooltip(_CircularProgress1, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("CircularProgress1.SuperTooltip"));
            // 
            // ButtonX9
            // 
            resources.ApplyResources(_ButtonX9, "ButtonX9");
            _ButtonX9.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX9.FocusCuesEnabled = false;
            _ButtonX9.Name = "ButtonX9";
            _ButtonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX9, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX9.SuperTooltip"));
            _ButtonX9.Symbol = "57676";
            _ButtonX9.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX9.SymbolSize = 12.0F;
            // 
            // Panel2
            // 
            resources.ApplyResources(_Panel2, "Panel2");
            _Panel2.BackColor = System.Drawing.Color.Transparent;
            _Panel2.Controls.Add(_ItemListBox1);
            _Panel2.Controls.Add(_WarningBox_TweakUpdates);
            _Panel2.Name = "Panel2";
            _SuperTooltip1.SetSuperTooltip(_Panel2, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("Panel2.SuperTooltip"));
            // 
            // WarningBox_TweakUpdates
            // 
            resources.ApplyResources(_WarningBox_TweakUpdates, "WarningBox_TweakUpdates");
            _WarningBox_TweakUpdates.BackColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _WarningBox_TweakUpdates.CloseButtonVisible = false;
            _WarningBox_TweakUpdates.ForeColor = System.Drawing.Color.Black;
            _WarningBox_TweakUpdates.Name = "WarningBox_TweakUpdates";
            _SuperTooltip1.SetSuperTooltip(_WarningBox_TweakUpdates, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("WarningBox_TweakUpdates.SuperTooltip"));
            // 
            // ButtonX7
            // 
            resources.ApplyResources(_ButtonX7, "ButtonX7");
            _ButtonX7.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX7.FocusCuesEnabled = false;
            _ButtonX7.Image = MyIcons.icons8_search_16px;
            _ButtonX7.Name = "ButtonX7";
            _ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX7, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX7.SuperTooltip"));
            _ButtonX7.SymbolColor = System.Drawing.Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX7.SymbolSize = 12.0F;
            // 
            // ButtonX_AddNew
            // 
            resources.ApplyResources(_ButtonX_AddNew, "ButtonX_AddNew");
            _ButtonX_AddNew.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_AddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_AddNew.FocusCuesEnabled = false;
            _ButtonX_AddNew.Image = MyIcons.icons8_plus_math_16px;
            _ButtonX_AddNew.Name = "ButtonX_AddNew";
            _ButtonX_AddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _SuperTooltip1.SetSuperTooltip(_ButtonX_AddNew, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("ButtonX_AddNew.SuperTooltip"));
            _ButtonX_AddNew.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // TweakViewer
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            Controls.Add(_ButtonX9);
            Controls.Add(_CircularProgress1);
            Controls.Add(_ButtonX7);
            Controls.Add(_TextBoxX1);
            Controls.Add(_ButtonX_AddNew);
            Controls.Add(_Panel2);
            Name = "TweakViewer";
            _SuperTooltip1.SetSuperTooltip(this, (DevComponents.DotNetBar.SuperTooltipInfo)resources.GetObject("$this.SuperTooltip"));
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            _Panel1.PerformLayout();
            _Panel3.ResumeLayout(false);
            _TableLayoutPanel2.ResumeLayout(false);
            _TableLayoutPanel1.ResumeLayout(false);
            _Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX5;

        internal DevComponents.DotNetBar.ButtonX ButtonX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click -= ButtonX5_Click;
                }

                _ButtonX5 = value;
                if (_ButtonX5 != null)
                {
                    _ButtonX5.Click += ButtonX5_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_AddNew;

        internal DevComponents.DotNetBar.ButtonX ButtonX_AddNew
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_AddNew;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_AddNew != null)
                {
                    _ButtonX_AddNew.Click -= ButtonX_AddNew_Click;
                }

                _ButtonX_AddNew = value;
                if (_ButtonX_AddNew != null)
                {
                    _ButtonX_AddNew.Click += ButtonX_AddNew_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX8;

        internal DevComponents.DotNetBar.ButtonX ButtonX8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX8 != null)
                {
                    _ButtonX8.Click -= ButtonX8_Click;
                }

                _ButtonX8 = value;
                if (_ButtonX8 != null)
                {
                    _ButtonX8.Click += ButtonX8_Click;
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

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_Scripts;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Scripts
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_Scripts;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_Scripts != null)
                {
                    _ComboBoxEx_Scripts.SelectedIndexChanged -= ComboBoxEx_Scripts_SelectedIndexChanged;
                }

                _ComboBoxEx_Scripts = value;
                if (_ComboBoxEx_Scripts != null)
                {
                    _ComboBoxEx_Scripts.SelectedIndexChanged += ComboBoxEx_Scripts_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX1;

        internal DevComponents.DotNetBar.LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX1 != null)
                {
                }

                _LabelX1 = value;
                if (_LabelX1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.Flyout _Flyout1;

        internal DevComponents.DotNetBar.Controls.Flyout Flyout1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Flyout1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Flyout1 != null)
                {
                    _Flyout1.FlyoutShown -= Flyout1_FlyoutShown;
                }

                _Flyout1 = value;
                if (_Flyout1 != null)
                {
                    _Flyout1.FlyoutShown += Flyout1_FlyoutShown;
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
                    _ItemListBox1.SelectedItemChanged -= (_, __) => ItemListBox1_SelectedItemChanged();
                    _ItemListBox1.Scroll -= ItemListBox1_Scroll;
                }

                _ItemListBox1 = value;
                if (_ItemListBox1 != null)
                {
                    _ItemListBox1.SelectedItemChanged += (_, __) => ItemListBox1_SelectedItemChanged();
                    _ItemListBox1.Scroll += ItemListBox1_Scroll;
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

        private DevComponents.DotNetBar.ButtonX _ButtonX6;

        internal DevComponents.DotNetBar.ButtonX ButtonX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click -= ButtonX6_Click;
                }

                _ButtonX6 = value;
                if (_ButtonX6 != null)
                {
                    _ButtonX6.Click += ButtonX6_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX1;

        internal DevComponents.DotNetBar.ButtonX ButtonX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click -= ButtonX1_Click;
                }

                _ButtonX1 = value;
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click += ButtonX1_Click;
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel1;

        internal TableLayoutPanel TableLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel1 != null)
                {
                }

                _TableLayoutPanel1 = value;
                if (_TableLayoutPanel1 != null)
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

        private DevComponents.DotNetBar.SuperTooltip _SuperTooltip1;

        internal DevComponents.DotNetBar.SuperTooltip SuperTooltip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTooltip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTooltip1 != null)
                {
                }

                _SuperTooltip1 = value;
                if (_SuperTooltip1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_PatchName;

        internal DevComponents.DotNetBar.LabelX LabelX_PatchName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_PatchName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_PatchName != null)
                {
                }

                _LabelX_PatchName = value;
                if (_LabelX_PatchName != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Description;

        internal DevComponents.DotNetBar.LabelX LabelX_Description
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Description;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Description != null)
                {
                    _LabelX_Description.TextChanged -= LabelX_Description_MouseEnter;
                }

                _LabelX_Description = value;
                if (_LabelX_Description != null)
                {
                    _LabelX_Description.TextChanged += LabelX_Description_MouseEnter;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX2;

        internal DevComponents.DotNetBar.ButtonX ButtonX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX2 != null)
                {
                    _ButtonX2.Click -= ButtonX2_Click;
                }

                _ButtonX2 = value;
                if (_ButtonX2 != null)
                {
                    _ButtonX2.Click += ButtonX2_Click;
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

        private DevComponents.DotNetBar.LabelX _LabelX2;

        internal DevComponents.DotNetBar.LabelX LabelX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX2 != null)
                {
                }

                _LabelX2 = value;
                if (_LabelX2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX7;

        internal DevComponents.DotNetBar.ButtonX ButtonX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX7 != null)
                {
                    _ButtonX7.Click -= ButtonX7_Click;
                }

                _ButtonX7 = value;
                if (_ButtonX7 != null)
                {
                    _ButtonX7.Click += ButtonX7_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX1;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX1 != null)
                {
                    _TextBoxX1.KeyDown -= TextBoxX1_KeyDown;
                }

                _TextBoxX1 = value;
                if (_TextBoxX1 != null)
                {
                    _TextBoxX1.KeyDown += TextBoxX1_KeyDown;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CircularProgress _CircularProgress1;

        internal DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CircularProgress1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CircularProgress1 != null)
                {
                }

                _CircularProgress1 = value;
                if (_CircularProgress1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX9;

        internal DevComponents.DotNetBar.ButtonX ButtonX9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX9 != null)
                {
                    _ButtonX9.Click -= ButtonX9_Click;
                }

                _ButtonX9 = value;
                if (_ButtonX9 != null)
                {
                    _ButtonX9.Click += ButtonX9_Click;
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

        private DevComponents.DotNetBar.Controls.WarningBox _WarningBox_TweakUpdates;

        internal DevComponents.DotNetBar.Controls.WarningBox WarningBox_TweakUpdates
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _WarningBox_TweakUpdates;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_WarningBox_TweakUpdates != null)
                {
                    _WarningBox_TweakUpdates.OptionsClick -= WarningBox_TweakUpdates_OptionsClick;
                }

                _WarningBox_TweakUpdates = value;
                if (_WarningBox_TweakUpdates != null)
                {
                    _WarningBox_TweakUpdates.OptionsClick += WarningBox_TweakUpdates_OptionsClick;
                }
            }
        }
    }
}