using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.LevelEditor
{
    [DesignerGenerated()]
    public partial class InformationListDialog : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationListDialog));
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonX_CancelSearch = new DevComponents.DotNetBar.ButtonX();
            this.ItemList = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this.TextBoxX_Search = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AdvPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.TabItem_ObjectCombos = new DevComponents.DotNetBar.TabItem(this.components);
            this.TabItem_Behaviors = new DevComponents.DotNetBar.TabItem(this.components);
            this.Bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_Add = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Remove = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_SaveAll = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ReloadList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            resources.ApplyResources(this.SplitContainer1, "SplitContainer1");
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.ButtonX_CancelSearch);
            this.SplitContainer1.Panel1.Controls.Add(this.ItemList);
            this.SplitContainer1.Panel1.Controls.Add(this.TextBoxX_Search);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.AdvPropertyGrid1);
            // 
            // ButtonX_CancelSearch
            // 
            resources.ApplyResources(this.ButtonX_CancelSearch, "ButtonX_CancelSearch");
            this.ButtonX_CancelSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX_CancelSearch.FocusCuesEnabled = false;
            this.ButtonX_CancelSearch.Name = "ButtonX_CancelSearch";
            this.ButtonX_CancelSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_CancelSearch.Symbol = "57676";
            this.ButtonX_CancelSearch.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX_CancelSearch.SymbolSize = 12F;
            this.ButtonX_CancelSearch.Click += new System.EventHandler(this.ButtonX_CancelSearch_Click);
            // 
            // ItemList
            // 
            resources.ApplyResources(this.ItemList, "ItemList");
            // 
            // 
            // 
            this.ItemList.BackgroundStyle.Class = "ItemPanel";
            this.ItemList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ItemList.ContainerControlProcessDialogKey = true;
            this.ItemList.DragDropSupport = true;
            this.ItemList.FitButtonsToContainerWidth = true;
            this.ItemList.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ItemList.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ItemList.Name = "ItemList";
            this.ItemList.ReserveLeftSpace = false;
            this.ItemList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ItemList.SelectedItemChanged += new SM64_ROM_Manager.Publics.Controls.ItemListBox.SelectedItemChangedEventHandler(this.ItemList_SelectedItemChanged);
            this.ItemList.ItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ItemListBox1_ItemDoubleClick);
            // 
            // TextBoxX_Search
            // 
            this.TextBoxX_Search.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_Search.Border.Class = "TextBoxBorder";
            this.TextBoxX_Search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_Search.DisabledBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.TextBoxX_Search, "TextBoxX_Search");
            this.TextBoxX_Search.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_Search.Name = "TextBoxX_Search";
            this.TextBoxX_Search.PreventEnterBeep = true;
            this.TextBoxX_Search.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TextBoxX_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxX_Search_KeyDown);
            // 
            // AdvPropertyGrid1
            // 
            resources.ApplyResources(this.AdvPropertyGrid1, "AdvPropertyGrid1");
            this.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.AdvPropertyGrid1.Name = "AdvPropertyGrid1";
            this.AdvPropertyGrid1.ConvertPropertyValueToString += new DevComponents.DotNetBar.ConvertValueEventHandler(this.AdvPropertyGrid1_ConvertPropertyValueToString);
            this.AdvPropertyGrid1.ConvertFromStringToPropertyValue += new DevComponents.DotNetBar.ConvertValueEventHandler(this.AdvPropertyGrid1_ConvertFromStringToPropertyValue);
            this.AdvPropertyGrid1.PropertyValueChanged += new System.ComponentModel.PropertyChangedEventHandler(this.AdvPropertyGrid1_PropertiesLoaded);
            this.AdvPropertyGrid1.ValidatePropertyValue += new DevComponents.DotNetBar.ValidatePropertyValueEventHandler(this.AdvPropertyGrid1_PropertiesLoaded);
            this.AdvPropertyGrid1.PropertiesLoaded += new System.EventHandler(this.AdvPropertyGrid1_PropertiesLoaded);
            this.AdvPropertyGrid1.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.AdvPropertyGrid1_PropertiesLoaded);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.SplitContainer1);
            this.Panel1.Controls.Add(this.TabStrip1);
            this.Panel1.Controls.Add(this.Bar1);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // TabStrip1
            // 
            this.TabStrip1.AutoSelectAttachedControl = true;
            this.TabStrip1.CanReorderTabs = true;
            this.TabStrip1.CloseButtonVisible = true;
            this.TabStrip1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.TabStrip1, "TabStrip1");
            this.TabStrip1.ForeColor = System.Drawing.Color.Black;
            this.TabStrip1.Name = "TabStrip1";
            this.TabStrip1.SelectedTab = this.TabItem_ObjectCombos;
            this.TabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.TabStrip1.Tabs.Add(this.TabItem_ObjectCombos);
            this.TabStrip1.Tabs.Add(this.TabItem_Behaviors);
            this.TabStrip1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.TabStrip1_SelectedTabChanged);
            // 
            // TabItem_ObjectCombos
            // 
            this.TabItem_ObjectCombos.Name = "TabItem_ObjectCombos";
            resources.ApplyResources(this.TabItem_ObjectCombos, "TabItem_ObjectCombos");
            // 
            // TabItem_Behaviors
            // 
            this.TabItem_Behaviors.Name = "TabItem_Behaviors";
            resources.ApplyResources(this.TabItem_Behaviors, "TabItem_Behaviors");
            // 
            // Bar1
            // 
            this.Bar1.AntiAlias = true;
            resources.ApplyResources(this.Bar1, "Bar1");
            this.Bar1.DockOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.Bar1.IsMaximized = false;
            this.Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_Add,
            this.ButtonItem_Remove,
            this.ButtonItem_SaveAll,
            this.ButtonItem_ReloadList});
            this.Bar1.Name = "Bar1";
            this.Bar1.RoundCorners = false;
            this.Bar1.Stretch = true;
            this.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar1.TabStop = false;
            // 
            // ButtonItem_Add
            // 
            this.ButtonItem_Add.Image = global::SM64_ROM_Manager.My.Resources.MyOldIcons.Add_16px;
            this.ButtonItem_Add.Name = "ButtonItem_Add";
            resources.ApplyResources(this.ButtonItem_Add, "ButtonItem_Add");
            this.ButtonItem_Add.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // ButtonItem_Remove
            // 
            this.ButtonItem_Remove.Image = global::SM64_ROM_Manager.My.Resources.MyOldIcons.Remove_16px;
            this.ButtonItem_Remove.Name = "ButtonItem_Remove";
            resources.ApplyResources(this.ButtonItem_Remove, "ButtonItem_Remove");
            this.ButtonItem_Remove.Click += new System.EventHandler(this.ButtonItem3_Click);
            // 
            // ButtonItem_SaveAll
            // 
            this.ButtonItem_SaveAll.Image = global::SM64_ROM_Manager.My.Resources.MyOldIcons.SaveAll_16px1;
            this.ButtonItem_SaveAll.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.ButtonItem_SaveAll.Name = "ButtonItem_SaveAll";
            resources.ApplyResources(this.ButtonItem_SaveAll, "ButtonItem_SaveAll");
            this.ButtonItem_SaveAll.Click += new System.EventHandler(this.ButtonItem_SaveAll_Click);
            // 
            // ButtonItem_ReloadList
            // 
            this.ButtonItem_ReloadList.Image = global::SM64_ROM_Manager.My.Resources.MyOldIcons.Refresh_16px;
            this.ButtonItem_ReloadList.Name = "ButtonItem_ReloadList";
            resources.ApplyResources(this.ButtonItem_ReloadList, "ButtonItem_ReloadList");
            this.ButtonItem_ReloadList.Click += new System.EventHandler(this.ButtonItem_ReloadList_Click);
            // 
            // InformationListDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Name = "InformationListDialog";
            this.ShowIcon = false;
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvPropertyGrid1)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Bar Bar1;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Add;


        private DevComponents.DotNetBar.ButtonItem ButtonItem_Remove;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_SaveAll;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ReloadList;

        private DevComponents.DotNetBar.TabStrip TabStrip1;

        private DevComponents.DotNetBar.TabItem TabItem_ObjectCombos;


        private DevComponents.DotNetBar.TabItem TabItem_Behaviors;


        private Panel Panel1;

        private SplitContainer SplitContainer1;

        private Publics.Controls.ItemListBox ItemList;


        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Search;


        private DevComponents.DotNetBar.ButtonX ButtonX_CancelSearch;


        private DevComponents.DotNetBar.AdvPropertyGrid AdvPropertyGrid1;


    }
}