using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ModelBankManager : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelBankManager));
            this.ItemListBox1 = new SM64_ROM_Manager.Publics.Controls.ItemListBox();
            this.ButtonX_CreateNewObject = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_RemoveObject = new DevComponents.DotNetBar.ButtonX();
            this.TextBoxX_ModelID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonX_ImportModel = new DevComponents.DotNetBar.ButtonX();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.TextBoxX_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX_CollisionPointerDestinationsCount = new DevComponents.DotNetBar.LabelX();
            this.ButtonX_EditCollisionPointerDestinations = new DevComponents.DotNetBar.ButtonX();
            this.LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutGroup_ModelInfo = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutGroup_CollisionPointerDestinations = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.CM_Object = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportModell = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportVisualMap = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ImportCollision = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveCollision = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ShowVisualMap = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ShowCollision = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ObjectShadow = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_EditObjectShadow = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveObjectShadow = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_EditGeolayout = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CopyCollisionPointer = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveObject = new DevComponents.DotNetBar.ButtonItem();
            this.Panel1.SuspendLayout();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // ButtonX_CreateNewObject
            // 
            resources.ApplyResources(this.ButtonX_CreateNewObject, "ButtonX_CreateNewObject");
            this.ButtonX_CreateNewObject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_CreateNewObject.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.ButtonX_CreateNewObject.FocusCuesEnabled = false;
            this.ButtonX_CreateNewObject.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonX_CreateNewObject.Name = "ButtonX_CreateNewObject";
            this.ButtonX_CreateNewObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_CreateNewObject.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(124)))), ((int)(((byte)(64)))));
            this.ButtonX_CreateNewObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX_CreateNewObject.SymbolSize = 12F;
            this.ButtonX_CreateNewObject.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // ButtonX_RemoveObject
            // 
            resources.ApplyResources(this.ButtonX_RemoveObject, "ButtonX_RemoveObject");
            this.ButtonX_RemoveObject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_RemoveObject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_RemoveObject.FocusCuesEnabled = false;
            this.ButtonX_RemoveObject.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonX_RemoveObject.Name = "ButtonX_RemoveObject";
            this.ButtonX_RemoveObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_RemoveObject.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonX_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonX_RemoveObject.SymbolSize = 12F;
            this.ButtonX_RemoveObject.Click += new System.EventHandler(this.ButtonItem_RemoveObject_Click);
            // 
            // TextBoxX_ModelID
            // 
            resources.ApplyResources(this.TextBoxX_ModelID, "TextBoxX_ModelID");
            this.TextBoxX_ModelID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_ModelID.Border.Class = "TextBoxBorder";
            this.TextBoxX_ModelID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_ModelID.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("TextBoxX_ModelID.ButtonCustom.DisplayPosition")));
            this.TextBoxX_ModelID.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("TextBoxX_ModelID.ButtonCustom.Image")));
            this.TextBoxX_ModelID.ButtonCustom.Text = resources.GetString("TextBoxX_ModelID.ButtonCustom.Text");
            this.TextBoxX_ModelID.ButtonCustom.Tooltip = resources.GetString("TextBoxX_ModelID.ButtonCustom.Tooltip");
            this.TextBoxX_ModelID.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("TextBoxX_ModelID.ButtonCustom2.DisplayPosition")));
            this.TextBoxX_ModelID.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("TextBoxX_ModelID.ButtonCustom2.Image")));
            this.TextBoxX_ModelID.ButtonCustom2.Text = resources.GetString("TextBoxX_ModelID.ButtonCustom2.Text");
            this.TextBoxX_ModelID.ButtonCustom2.Tooltip = resources.GetString("TextBoxX_ModelID.ButtonCustom2.Tooltip");
            this.TextBoxX_ModelID.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_ModelID.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_ModelID.Name = "TextBoxX_ModelID";
            this.TextBoxX_ModelID.PreventEnterBeep = true;
            this.TextBoxX_ModelID.TextChanged += new System.EventHandler(this.TextBoxX_ModelID_TextChanged);
            // 
            // ButtonX_ImportModel
            // 
            resources.ApplyResources(this.ButtonX_ImportModel, "ButtonX_ImportModel");
            this.ButtonX_ImportModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_ImportModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_ImportModel.FocusCuesEnabled = false;
            this.ButtonX_ImportModel.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonX_ImportModel.Name = "ButtonX_ImportModel";
            this.ButtonX_ImportModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_ImportModel.Click += new System.EventHandler(this.ButtonItem_ImportModell_Click);
            // 
            // Panel1
            // 
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.ButtonX_CreateNewObject);
            this.Panel1.Controls.Add(this.ItemListBox1);
            this.Panel1.Controls.Add(this.LayoutControl1);
            this.Panel1.Name = "Panel1";
            // 
            // LayoutControl1
            // 
            resources.ApplyResources(this.LayoutControl1, "LayoutControl1");
            this.LayoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LayoutControl1.Controls.Add(this.TextBoxX_ModelID);
            this.LayoutControl1.Controls.Add(this.TextBoxX_Name);
            this.LayoutControl1.Controls.Add(this.ButtonX_ImportModel);
            this.LayoutControl1.Controls.Add(this.ButtonX_RemoveObject);
            this.LayoutControl1.Controls.Add(this.LabelX_CollisionPointerDestinationsCount);
            this.LayoutControl1.Controls.Add(this.ButtonX_EditCollisionPointerDestinations);
            this.LayoutControl1.ForeColor = System.Drawing.Color.Black;
            this.LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            this.LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem3,
            this.LayoutControlItem4,
            this.LayoutGroup_ModelInfo,
            this.LayoutGroup_CollisionPointerDestinations});
            this.LayoutControl1.RootGroup.Text = resources.GetString("resource.Text");
            this.LayoutControl1.RootGroup.Tooltip = resources.GetString("resource.Tooltip");
            // 
            // TextBoxX_Name
            // 
            resources.ApplyResources(this.TextBoxX_Name, "TextBoxX_Name");
            this.TextBoxX_Name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_Name.Border.Class = "TextBoxBorder";
            this.TextBoxX_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_Name.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("TextBoxX_Name.ButtonCustom.DisplayPosition")));
            this.TextBoxX_Name.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("TextBoxX_Name.ButtonCustom.Image")));
            this.TextBoxX_Name.ButtonCustom.Text = resources.GetString("TextBoxX_Name.ButtonCustom.Text");
            this.TextBoxX_Name.ButtonCustom.Tooltip = resources.GetString("TextBoxX_Name.ButtonCustom.Tooltip");
            this.TextBoxX_Name.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("TextBoxX_Name.ButtonCustom2.DisplayPosition")));
            this.TextBoxX_Name.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("TextBoxX_Name.ButtonCustom2.Image")));
            this.TextBoxX_Name.ButtonCustom2.Text = resources.GetString("TextBoxX_Name.ButtonCustom2.Text");
            this.TextBoxX_Name.ButtonCustom2.Tooltip = resources.GetString("TextBoxX_Name.ButtonCustom2.Tooltip");
            this.TextBoxX_Name.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_Name.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_Name.Name = "TextBoxX_Name";
            this.TextBoxX_Name.PreventEnterBeep = true;
            this.TextBoxX_Name.TextChanged += new System.EventHandler(this.TextBoxX_Name_TextChanged);
            // 
            // LabelX_CollisionPointerDestinationsCount
            // 
            resources.ApplyResources(this.LabelX_CollisionPointerDestinationsCount, "LabelX_CollisionPointerDestinationsCount");
            // 
            // 
            // 
            this.LabelX_CollisionPointerDestinationsCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_CollisionPointerDestinationsCount.Name = "LabelX_CollisionPointerDestinationsCount";
            this.LabelX_CollisionPointerDestinationsCount.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ButtonX_EditCollisionPointerDestinations
            // 
            resources.ApplyResources(this.ButtonX_EditCollisionPointerDestinations, "ButtonX_EditCollisionPointerDestinations");
            this.ButtonX_EditCollisionPointerDestinations.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_EditCollisionPointerDestinations.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_EditCollisionPointerDestinations.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonX_EditCollisionPointerDestinations.Name = "ButtonX_EditCollisionPointerDestinations";
            this.ButtonX_EditCollisionPointerDestinations.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_EditCollisionPointerDestinations.Click += new System.EventHandler(this.ButtonX_EditCollisionPointerDestinations_Click);
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.ButtonX_ImportModel;
            this.LayoutControlItem3.Height = 31;
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            resources.ApplyResources(this.LayoutControlItem3, "LayoutControlItem3");
            this.LayoutControlItem3.Width = 99;
            this.LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.ButtonX_RemoveObject;
            this.LayoutControlItem4.Height = 31;
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            resources.ApplyResources(this.LayoutControlItem4, "LayoutControlItem4");
            this.LayoutControlItem4.Width = 31;
            // 
            // LayoutGroup_ModelInfo
            // 
            this.LayoutGroup_ModelInfo.Height = 57;
            this.LayoutGroup_ModelInfo.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem2,
            this.LayoutControlItem1});
            this.LayoutGroup_ModelInfo.MinSize = new System.Drawing.Size(120, 32);
            this.LayoutGroup_ModelInfo.Name = "LayoutGroup_ModelInfo";
            this.LayoutGroup_ModelInfo.Padding = new System.Windows.Forms.Padding(0);
            resources.ApplyResources(this.LayoutGroup_ModelInfo, "LayoutGroup_ModelInfo");
            this.LayoutGroup_ModelInfo.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutGroup_ModelInfo.Width = 100;
            this.LayoutGroup_ModelInfo.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.TextBoxX_Name;
            this.LayoutControlItem2.Height = 28;
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(this.LayoutControlItem2, "LayoutControlItem2");
            this.LayoutControlItem2.Width = 100;
            this.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.TextBoxX_ModelID;
            this.LayoutControlItem1.Height = 28;
            this.LayoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(this.LayoutControlItem1, "LayoutControlItem1");
            this.LayoutControlItem1.Width = 100;
            this.LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutGroup_CollisionPointerDestinations
            // 
            this.LayoutGroup_CollisionPointerDestinations.Height = 35;
            this.LayoutGroup_CollisionPointerDestinations.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.LayoutControlItem5,
            this.LayoutControlItem6});
            this.LayoutGroup_CollisionPointerDestinations.MinSize = new System.Drawing.Size(120, 32);
            this.LayoutGroup_CollisionPointerDestinations.Name = "LayoutGroup_CollisionPointerDestinations";
            this.LayoutGroup_CollisionPointerDestinations.Padding = new System.Windows.Forms.Padding(0);
            resources.ApplyResources(this.LayoutGroup_CollisionPointerDestinations, "LayoutGroup_CollisionPointerDestinations");
            this.LayoutGroup_CollisionPointerDestinations.TextPadding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LayoutGroup_CollisionPointerDestinations.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.LayoutGroup_CollisionPointerDestinations.Width = 100;
            this.LayoutGroup_CollisionPointerDestinations.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            this.LayoutControlItem5.Control = this.LabelX_CollisionPointerDestinationsCount;
            this.LayoutControlItem5.Height = 31;
            this.LayoutControlItem5.MinSize = new System.Drawing.Size(64, 18);
            this.LayoutControlItem5.Name = "LayoutControlItem5";
            resources.ApplyResources(this.LayoutControlItem5, "LayoutControlItem5");
            this.LayoutControlItem5.Width = 99;
            this.LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem6
            // 
            this.LayoutControlItem6.Control = this.ButtonX_EditCollisionPointerDestinations;
            this.LayoutControlItem6.Height = 31;
            this.LayoutControlItem6.MinSize = new System.Drawing.Size(32, 20);
            this.LayoutControlItem6.Name = "LayoutControlItem6";
            resources.ApplyResources(this.LayoutControlItem6, "LayoutControlItem6");
            this.LayoutControlItem6.Width = 90;
            // 
            // ContextMenuBar1
            // 
            resources.ApplyResources(this.ContextMenuBar1, "ContextMenuBar1");
            this.ContextMenuBar1.AntiAlias = true;
            this.ContextMenuBar1.IsMaximized = false;
            this.ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.CM_Object});
            this.ContextMenuBar1.Name = "ContextMenuBar1";
            this.ContextMenuBar1.Stretch = true;
            this.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar1.TabStop = false;
            // 
            // CM_Object
            // 
            resources.ApplyResources(this.CM_Object, "CM_Object");
            this.CM_Object.AutoExpandOnClick = true;
            this.CM_Object.Name = "CM_Object";
            this.CM_Object.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_ImportModell,
            this.ButtonItem_ImportVisualMap,
            this.ButtonItem_ImportCollision,
            this.ButtonItem_RemoveCollision,
            this.ButtonItem_ShowVisualMap,
            this.ButtonItem_ShowCollision,
            this.ButtonItem_EditGeolayout,
            this.ButtonItem_ObjectShadow,
            this.ButtonItem_CopyCollisionPointer,
            this.ButtonItem_RemoveObject});
            this.CM_Object.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.CM_Object_PopupOpen);
            // 
            // ButtonItem_ImportModell
            // 
            resources.ApplyResources(this.ButtonItem_ImportModell, "ButtonItem_ImportModell");
            this.ButtonItem_ImportModell.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_import_16px;
            this.ButtonItem_ImportModell.Name = "ButtonItem_ImportModell";
            this.ButtonItem_ImportModell.Click += new System.EventHandler(this.ButtonItem_ImportModell_Click);
            // 
            // ButtonItem_ImportVisualMap
            // 
            resources.ApplyResources(this.ButtonItem_ImportVisualMap, "ButtonItem_ImportVisualMap");
            this.ButtonItem_ImportVisualMap.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ImportVisualMap.Image")));
            this.ButtonItem_ImportVisualMap.Name = "ButtonItem_ImportVisualMap";
            this.ButtonItem_ImportVisualMap.Click += new System.EventHandler(this.ButtonItem_ImportVisualMap_Click);
            // 
            // ButtonItem_ImportCollision
            // 
            resources.ApplyResources(this.ButtonItem_ImportCollision, "ButtonItem_ImportCollision");
            this.ButtonItem_ImportCollision.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ImportCollision.Image")));
            this.ButtonItem_ImportCollision.Name = "ButtonItem_ImportCollision";
            this.ButtonItem_ImportCollision.Click += new System.EventHandler(this.ButtonItem_ImportCollision_Click);
            // 
            // ButtonItem_RemoveCollision
            // 
            resources.ApplyResources(this.ButtonItem_RemoveCollision, "ButtonItem_RemoveCollision");
            this.ButtonItem_RemoveCollision.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_2_16px;
            this.ButtonItem_RemoveCollision.Name = "ButtonItem_RemoveCollision";
            this.ButtonItem_RemoveCollision.Click += new System.EventHandler(this.ButtonItem_RemoveCollision_Click);
            // 
            // ButtonItem_ShowVisualMap
            // 
            resources.ApplyResources(this.ButtonItem_ShowVisualMap, "ButtonItem_ShowVisualMap");
            this.ButtonItem_ShowVisualMap.BeginGroup = true;
            this.ButtonItem_ShowVisualMap.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ShowVisualMap.Image")));
            this.ButtonItem_ShowVisualMap.Name = "ButtonItem_ShowVisualMap";
            this.ButtonItem_ShowVisualMap.Click += new System.EventHandler(this.ButtonItem_ShowVisualMap_Click);
            // 
            // ButtonItem_ShowCollision
            // 
            resources.ApplyResources(this.ButtonItem_ShowCollision, "ButtonItem_ShowCollision");
            this.ButtonItem_ShowCollision.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_ShowCollision.Image")));
            this.ButtonItem_ShowCollision.Name = "ButtonItem_ShowCollision";
            this.ButtonItem_ShowCollision.Click += new System.EventHandler(this.ButtonItem_ShowCollision_Click);
            // 
            // ButtonItem_EditGeolayout
            // 
            this.ButtonItem_EditGeolayout.BeginGroup = true;
            this.ButtonItem_EditGeolayout.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_EditGeolayout.Name = "ButtonItem_EditGeolayout";
            resources.ApplyResources(this.ButtonItem_EditGeolayout, "ButtonItem_EditGeolayout");
            this.ButtonItem_EditGeolayout.Click += new System.EventHandler(this.ButtonItem_EditGeolayout_Click);
            // 
            // ButtonItem_ObjectShadow
            // 
            resources.ApplyResources(this.ButtonItem_ObjectShadow, "ButtonItem_ObjectShadow");
            this.ButtonItem_ObjectShadow.BeginGroup = true;
            this.ButtonItem_ObjectShadow.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_batman_16px;
            this.ButtonItem_ObjectShadow.Name = "ButtonItem_ObjectShadow";
            this.ButtonItem_ObjectShadow.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_EditObjectShadow,
            this.ButtonItem_RemoveObjectShadow});
            // 
            // ButtonItem_EditObjectShadow
            // 
            resources.ApplyResources(this.ButtonItem_EditObjectShadow, "ButtonItem_EditObjectShadow");
            this.ButtonItem_EditObjectShadow.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_edit_16px;
            this.ButtonItem_EditObjectShadow.Name = "ButtonItem_EditObjectShadow";
            this.ButtonItem_EditObjectShadow.Click += new System.EventHandler(this.ButtonItem_EditObjectShadow_Click);
            // 
            // ButtonItem_RemoveObjectShadow
            // 
            resources.ApplyResources(this.ButtonItem_RemoveObjectShadow, "ButtonItem_RemoveObjectShadow");
            this.ButtonItem_RemoveObjectShadow.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveObjectShadow.Name = "ButtonItem_RemoveObjectShadow";
            this.ButtonItem_RemoveObjectShadow.Click += new System.EventHandler(this.ButtonItem_RemoveObjectShadow_Click);
            // 
            // ButtonItem_CopyCollisionPointer
            // 
            resources.ApplyResources(this.ButtonItem_CopyCollisionPointer, "ButtonItem_CopyCollisionPointer");
            this.ButtonItem_CopyCollisionPointer.BeginGroup = true;
            this.ButtonItem_CopyCollisionPointer.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_copy_16px;
            this.ButtonItem_CopyCollisionPointer.Name = "ButtonItem_CopyCollisionPointer";
            this.ButtonItem_CopyCollisionPointer.Click += new System.EventHandler(this.ButtonItem_CopyCollisionPointer_Click);
            // 
            // ButtonItem_RemoveObject
            // 
            resources.ApplyResources(this.ButtonItem_RemoveObject, "ButtonItem_RemoveObject");
            this.ButtonItem_RemoveObject.BeginGroup = true;
            this.ButtonItem_RemoveObject.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveObject.Name = "ButtonItem_RemoveObject";
            this.ButtonItem_RemoveObject.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonItem_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.ButtonItem_RemoveObject.SymbolSize = 12F;
            this.ButtonItem_RemoveObject.Click += new System.EventHandler(this.ButtonItem_RemoveObject_Click);
            // 
            // ModelBankManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContextMenuBar1);
            this.Controls.Add(this.Panel1);
            this.MaximizeBox = false;
            this.Name = "ModelBankManager";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        private Publics.Controls.ItemListBox ItemListBox1;

        private DevComponents.DotNetBar.ButtonX ButtonX_CreateNewObject;

        private DevComponents.DotNetBar.ButtonX ButtonX_RemoveObject;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ModelID;

        private DevComponents.DotNetBar.ButtonX ButtonX_ImportModel;

        private Panel Panel1;

        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1;

        private DevComponents.DotNetBar.ButtonItem CM_Object;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowVisualMap;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ShowCollision;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObject;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportModell;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveCollision;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportVisualMap;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ImportCollision;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CopyCollisionPointer;

        private DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1;

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Name;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem4;

        private DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_ModelInfo;

        private DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_CollisionPointerDestinations;

        private DevComponents.DotNetBar.ButtonX ButtonX_EditCollisionPointerDestinations;

        private DevComponents.DotNetBar.LabelX LabelX_CollisionPointerDestinationsCount;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5;

        private DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_ObjectShadow;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_EditObjectShadow;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObjectShadow;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_EditGeolayout;
    }
}