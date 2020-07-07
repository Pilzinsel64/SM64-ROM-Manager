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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweakViewer));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.labelX_Version = new DevComponents.DotNetBar.LabelX();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.ButtonX8 = new DevComponents.DotNetBar.ButtonX();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            this.LabelX_Description = new DevComponents.DotNetBar.LabelX();
            this.LabelX_PatchName = new DevComponents.DotNetBar.LabelX();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            this.ComboBoxEx_Scripts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.Flyout1 = new DevComponents.DotNetBar.Controls.Flyout(this.components);
            this.ItemListBox1 = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this.SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.ButtonX9 = new DevComponents.DotNetBar.ButtonX();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.WarningBox_TweakUpdates = new DevComponents.DotNetBar.Controls.WarningBox();
            this.WarningBox_UpgradeLegacyTweaks = new DevComponents.DotNetBar.Controls.WarningBox();
            this.ButtonX7 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_AddNew = new DevComponents.DotNetBar.ButtonX();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.labelX_Version);
            this.Panel1.Controls.Add(this.LabelX2);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.TableLayoutPanel2);
            this.Panel1.Controls.Add(this.LabelX_Description);
            this.Panel1.Controls.Add(this.LabelX_PatchName);
            this.Panel1.Controls.Add(this.TableLayoutPanel1);
            this.Panel1.Controls.Add(this.ComboBoxEx_Scripts);
            this.Panel1.Controls.Add(this.LabelX1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // labelX_Version
            // 
            this.labelX_Version.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_Version.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX_Version, "labelX_Version");
            this.labelX_Version.Name = "labelX_Version";
            // 
            // LabelX2
            // 
            this.LabelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX2, "LabelX2");
            this.LabelX2.Name = "LabelX2";
            // 
            // Panel3
            // 
            resources.ApplyResources(this.Panel3, "Panel3");
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.Controls.Add(this.ButtonX8);
            this.Panel3.Name = "Panel3";
            // 
            // ButtonX8
            // 
            this.ButtonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX8.FocusCuesEnabled = false;
            this.ButtonX8.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_triggering_16px;
            resources.ApplyResources(this.ButtonX8, "ButtonX8");
            this.ButtonX8.Name = "ButtonX8";
            this.ButtonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX8.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX8.Click += new System.EventHandler(this.ButtonX8_Click);
            // 
            // TableLayoutPanel2
            // 
            resources.ApplyResources(this.TableLayoutPanel2, "TableLayoutPanel2");
            this.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel2.Controls.Add(this.ButtonX5, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.ButtonX3, 2, 0);
            this.TableLayoutPanel2.Controls.Add(this.ButtonX2, 0, 0);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            // 
            // ButtonX5
            // 
            this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX5.FocusCuesEnabled = false;
            this.ButtonX5.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_delete_sign_16px_1;
            resources.ApplyResources(this.ButtonX5, "ButtonX5");
            this.ButtonX5.Name = "ButtonX5";
            this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX5.Click += new System.EventHandler(this.ButtonX5_Click);
            // 
            // ButtonX3
            // 
            this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX3.FocusCuesEnabled = false;
            this.ButtonX3.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_cancel_16px;
            resources.ApplyResources(this.ButtonX3, "ButtonX3");
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonX2
            // 
            this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX2, "ButtonX2");
            this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX2.FocusCuesEnabled = false;
            this.ButtonX2.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_edit_16px;
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // LabelX_Description
            // 
            resources.ApplyResources(this.LabelX_Description, "LabelX_Description");
            this.LabelX_Description.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_Description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_Description.Name = "LabelX_Description";
            this.LabelX_Description.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.LabelX_Description.WordWrap = true;
            this.LabelX_Description.TextChanged += new System.EventHandler(this.LabelX_Description_MouseEnter);
            // 
            // LabelX_PatchName
            // 
            this.LabelX_PatchName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX_PatchName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.LabelX_PatchName, "LabelX_PatchName");
            this.LabelX_PatchName.Name = "LabelX_PatchName";
            // 
            // TableLayoutPanel1
            // 
            resources.ApplyResources(this.TableLayoutPanel1, "TableLayoutPanel1");
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel1.Controls.Add(this.ButtonX1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX6, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX4, 2, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            // 
            // ButtonX1
            // 
            this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX1.FocusCuesEnabled = false;
            this.ButtonX1.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(this.ButtonX1, "ButtonX1");
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // ButtonX6
            // 
            this.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX6, "ButtonX6");
            this.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX6.FocusCuesEnabled = false;
            this.ButtonX6.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_edit_16px;
            this.ButtonX6.Name = "ButtonX6";
            this.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX6.Click += new System.EventHandler(this.ButtonX6_Click);
            // 
            // ButtonX4
            // 
            this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX4, "ButtonX4");
            this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX4.FocusCuesEnabled = false;
            this.ButtonX4.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_delete_sign_16px_1;
            this.ButtonX4.Name = "ButtonX4";
            this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // ComboBoxEx_Scripts
            // 
            resources.ApplyResources(this.ComboBoxEx_Scripts, "ComboBoxEx_Scripts");
            this.ComboBoxEx_Scripts.DisplayMember = "Text";
            this.ComboBoxEx_Scripts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxEx_Scripts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEx_Scripts.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEx_Scripts.FormattingEnabled = true;
            this.ComboBoxEx_Scripts.Name = "ComboBoxEx_Scripts";
            this.ComboBoxEx_Scripts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxEx_Scripts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx_Scripts_SelectedIndexChanged);
            // 
            // LabelX1
            // 
            resources.ApplyResources(this.LabelX1, "LabelX1");
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Name = "LabelX1";
            // 
            // Flyout1
            // 
            this.Flyout1.Content = this.Panel1;
            this.Flyout1.DisplayMode = DevComponents.DotNetBar.Controls.eFlyoutDisplayMode.Manual;
            this.Flyout1.DropShadow = false;
            this.Flyout1.Parent = this;
            this.Flyout1.FlyoutShown += new System.EventHandler(this.Flyout1_FlyoutShown);
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
            this.ItemListBox1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ItemListBox1_Scroll);
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(this.SuperTooltip1, "SuperTooltip1");
            this.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // TextBoxX1
            // 
            this.TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TextBoxX1, "TextBoxX1");
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.PreventEnterBeep = true;
            this.TextBoxX1.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TextBoxX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxX1_KeyDown);
            // 
            // CircularProgress1
            // 
            // 
            // 
            // 
            this.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.CircularProgress1, "CircularProgress1");
            this.CircularProgress1.Name = "CircularProgress1";
            this.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.CircularProgress1.SetVisibleStateOnStart = true;
            this.CircularProgress1.SetVisibleStateOnStop = true;
            this.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // ButtonX9
            // 
            this.ButtonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX9.FocusCuesEnabled = false;
            this.ButtonX9.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_delete_sign_16px_1;
            resources.ApplyResources(this.ButtonX9, "ButtonX9");
            this.ButtonX9.Name = "ButtonX9";
            this.ButtonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX9.Click += new System.EventHandler(this.ButtonX9_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.ItemListBox1);
            this.Panel2.Controls.Add(this.WarningBox_TweakUpdates);
            this.Panel2.Controls.Add(this.WarningBox_UpgradeLegacyTweaks);
            resources.ApplyResources(this.Panel2, "Panel2");
            this.Panel2.Name = "Panel2";
            // 
            // WarningBox_TweakUpdates
            // 
            this.WarningBox_TweakUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(249)))));
            this.WarningBox_TweakUpdates.CloseButtonVisible = false;
            resources.ApplyResources(this.WarningBox_TweakUpdates, "WarningBox_TweakUpdates");
            this.WarningBox_TweakUpdates.ForeColor = System.Drawing.Color.Black;
            this.WarningBox_TweakUpdates.Name = "WarningBox_TweakUpdates";
            this.WarningBox_TweakUpdates.OptionsClick += new System.EventHandler(this.WarningBox_TweakUpdates_OptionsClick);
            // 
            // WarningBox_UpgradeLegacyTweaks
            // 
            this.WarningBox_UpgradeLegacyTweaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(249)))));
            this.WarningBox_UpgradeLegacyTweaks.CloseButtonVisible = false;
            resources.ApplyResources(this.WarningBox_UpgradeLegacyTweaks, "WarningBox_UpgradeLegacyTweaks");
            this.WarningBox_UpgradeLegacyTweaks.ForeColor = System.Drawing.Color.Black;
            this.WarningBox_UpgradeLegacyTweaks.Name = "WarningBox_UpgradeLegacyTweaks";
            this.WarningBox_UpgradeLegacyTweaks.OptionsClick += new System.EventHandler(this.WarningBox_UpgradeLegacyTweaks_OptionsClick);
            // 
            // ButtonX7
            // 
            this.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX7, "ButtonX7");
            this.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX7.FocusCuesEnabled = false;
            this.ButtonX7.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_search_16px;
            this.ButtonX7.Name = "ButtonX7";
            this.ButtonX7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX7.SymbolSize = 12F;
            this.ButtonX7.Click += new System.EventHandler(this.ButtonX7_Click);
            // 
            // ButtonX_AddNew
            // 
            this.ButtonX_AddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_AddNew, "ButtonX_AddNew");
            this.ButtonX_AddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_AddNew.FocusCuesEnabled = false;
            this.ButtonX_AddNew.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_plus_math_16px;
            this.ButtonX_AddNew.Name = "ButtonX_AddNew";
            this.ButtonX_AddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_AddNew.Click += new System.EventHandler(this.ButtonX_AddNew_Click);
            // 
            // TweakViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ButtonX9);
            this.Controls.Add(this.CircularProgress1);
            this.Controls.Add(this.ButtonX7);
            this.Controls.Add(this.TextBoxX1);
            this.Controls.Add(this.ButtonX_AddNew);
            this.Controls.Add(this.Panel2);
            this.Name = "TweakViewer";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.ButtonX ButtonX5;


        private DevComponents.DotNetBar.ButtonX ButtonX_AddNew;


        private DevComponents.DotNetBar.ButtonX ButtonX8;


        private Panel Panel1;


        private DevComponents.DotNetBar.ButtonX ButtonX3;


        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_Scripts;


        private DevComponents.DotNetBar.LabelX LabelX1;


        private DevComponents.DotNetBar.Controls.Flyout Flyout1;


        private Publics.Controls.ItemListBox ItemListBox1;


        private DevComponents.DotNetBar.ButtonX ButtonX4;


        private DevComponents.DotNetBar.ButtonX ButtonX6;


        private DevComponents.DotNetBar.ButtonX ButtonX1;


        private TableLayoutPanel TableLayoutPanel1;


        private TableLayoutPanel TableLayoutPanel2;


        private DevComponents.DotNetBar.SuperTooltip SuperTooltip1;


        private DevComponents.DotNetBar.LabelX LabelX_PatchName;


        private DevComponents.DotNetBar.LabelX LabelX_Description;


        private DevComponents.DotNetBar.ButtonX ButtonX2;


        private Panel Panel3;


        private DevComponents.DotNetBar.LabelX LabelX2;

                private DevComponents.DotNetBar.ButtonX ButtonX7;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;


        private DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1;


        private DevComponents.DotNetBar.ButtonX ButtonX9;


        private Panel Panel2;


        private DevComponents.DotNetBar.Controls.WarningBox WarningBox_TweakUpdates;
        private DevComponents.DotNetBar.LabelX labelX_Version;
        private DevComponents.DotNetBar.Controls.WarningBox WarningBox_UpgradeLegacyTweaks;
    }
}