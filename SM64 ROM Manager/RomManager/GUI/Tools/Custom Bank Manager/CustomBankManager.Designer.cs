using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class CustomBankManager : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomBankManager));
            _ItemListBox1 = new Publics.Controls.ItemListBox();
            _ButtonX_CreateNewObject = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_CreateNewObject.Click += new EventHandler(ButtonX1_Click);
            _ButtonX_RemoveObject = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_RemoveObject.Click += new EventHandler(ButtonItem_RemoveObject_Click);
            _TextBoxX_ModelID = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ModelID.TextChanged += new EventHandler(TextBoxX_ModelID_TextChanged);
            _ButtonX_ImportModel = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_ImportModel.Click += new EventHandler(ButtonItem_ImportModell_Click);
            _Panel1 = new Panel();
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _TextBoxX_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_Name.TextChanged += new EventHandler(TextBoxX_Name_TextChanged);
            _LabelX_CollisionPointerDestinationsCount = new DevComponents.DotNetBar.LabelX();
            _ButtonX_EditCollisionPointerDestinations = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_EditCollisionPointerDestinations.Click += new EventHandler(ButtonX_EditCollisionPointerDestinations_Click);
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutGroup_ModelInfo = new DevComponents.DotNetBar.Layout.LayoutGroup();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutGroup_CollisionPointerDestinations = new DevComponents.DotNetBar.Layout.LayoutGroup();
            _LayoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            _CM_Object = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ImportModell = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ImportModell.Click += new EventHandler(ButtonItem_ImportModell_Click);
            _ButtonItem_ImportVisualMap = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ImportVisualMap.Click += new EventHandler(ButtonItem_ImportVisualMap_Click);
            _ButtonItem_ImportCollision = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ImportCollision.Click += new EventHandler(ButtonItem_ImportCollision_Click);
            _ButtonItem_RemoveCollision = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveCollision.Click += new EventHandler(ButtonItem_RemoveCollision_Click);
            _ButtonItem_ShowVisualMap = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ShowVisualMap.Click += new EventHandler(ButtonItem_ShowVisualMap_Click);
            _ButtonItem_ShowCollision = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ShowCollision.Click += new EventHandler(ButtonItem_ShowCollision_Click);
            _ButtonItem_CopyCollisionPointer = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_CopyCollisionPointer.Click += new EventHandler(ButtonItem_CopyCollisionPointer_Click);
            _ButtonItem_RemoveObject = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveObject.Click += new EventHandler(ButtonItem_RemoveObject_Click);
            _Panel1.SuspendLayout();
            _LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).BeginInit();
            SuspendLayout();
            // 
            // ItemListBox1
            // 
            // 
            // 
            // 
            _ItemListBox1.BackgroundStyle.Class = "ItemPanel";
            _ItemListBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemListBox1.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(_ItemListBox1, "ItemListBox1");
            _ItemListBox1.DragDropSupport = true;
            _ItemListBox1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemListBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemListBox1.Name = "ItemListBox1";
            _ItemListBox1.ReserveLeftSpace = false;
            _ItemListBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_CreateNewObject
            // 
            _ButtonX_CreateNewObject.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_CreateNewObject, "ButtonX_CreateNewObject");
            _ButtonX_CreateNewObject.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            _ButtonX_CreateNewObject.FocusCuesEnabled = false;
            _ButtonX_CreateNewObject.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonX_CreateNewObject.Name = "ButtonX_CreateNewObject";
            _ButtonX_CreateNewObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_CreateNewObject.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(82)), Conversions.ToInteger(Conversions.ToByte(124)), Conversions.ToInteger(Conversions.ToByte(64)));
            _ButtonX_CreateNewObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX_CreateNewObject.SymbolSize = 12.0F;
            // 
            // ButtonX_RemoveObject
            // 
            _ButtonX_RemoveObject.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_RemoveObject, "ButtonX_RemoveObject");
            _ButtonX_RemoveObject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_RemoveObject.FocusCuesEnabled = false;
            _ButtonX_RemoveObject.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonX_RemoveObject.Name = "ButtonX_RemoveObject";
            _ButtonX_RemoveObject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_RemoveObject.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonX_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonX_RemoveObject.SymbolSize = 12.0F;
            // 
            // TextBoxX_ModelID
            // 
            _TextBoxX_ModelID.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ModelID.Border.Class = "TextBoxBorder";
            _TextBoxX_ModelID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ModelID.DisabledBackColor = Color.White;
            _TextBoxX_ModelID.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX_ModelID, "TextBoxX_ModelID");
            _TextBoxX_ModelID.Name = "TextBoxX_ModelID";
            _TextBoxX_ModelID.PreventEnterBeep = true;
            // 
            // ButtonX_ImportModel
            // 
            _ButtonX_ImportModel.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_ImportModel, "ButtonX_ImportModel");
            _ButtonX_ImportModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_ImportModel.FocusCuesEnabled = false;
            _ButtonX_ImportModel.Image = My.Resources.MyIcons.icons8_import_16px;
            _ButtonX_ImportModel.Name = "ButtonX_ImportModel";
            _ButtonX_ImportModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ButtonX_CreateNewObject);
            _Panel1.Controls.Add(_ItemListBox1);
            _Panel1.Controls.Add(_LayoutControl1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _LayoutControl1.Controls.Add(_TextBoxX_ModelID);
            _LayoutControl1.Controls.Add(_TextBoxX_Name);
            _LayoutControl1.Controls.Add(_ButtonX_ImportModel);
            _LayoutControl1.Controls.Add(_ButtonX_RemoveObject);
            _LayoutControl1.Controls.Add(_LabelX_CollisionPointerDestinationsCount);
            _LayoutControl1.Controls.Add(_ButtonX_EditCollisionPointerDestinations);
            resources.ApplyResources(_LayoutControl1, "LayoutControl1");
            _LayoutControl1.ForeColor = Color.Black;
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem3, _LayoutControlItem4, _LayoutGroup_ModelInfo, _LayoutGroup_CollisionPointerDestinations });
            // 
            // TextBoxX_Name
            // 
            _TextBoxX_Name.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Name.Border.Class = "TextBoxBorder";
            _TextBoxX_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Name.DisabledBackColor = Color.White;
            _TextBoxX_Name.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX_Name, "TextBoxX_Name");
            _TextBoxX_Name.Name = "TextBoxX_Name";
            _TextBoxX_Name.PreventEnterBeep = true;
            // 
            // LabelX_CollisionPointerDestinationsCount
            // 
            // 
            // 
            // 
            _LabelX_CollisionPointerDestinationsCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX_CollisionPointerDestinationsCount, "LabelX_CollisionPointerDestinationsCount");
            _LabelX_CollisionPointerDestinationsCount.Name = "LabelX_CollisionPointerDestinationsCount";
            _LabelX_CollisionPointerDestinationsCount.TextAlignment = StringAlignment.Center;
            // 
            // ButtonX_EditCollisionPointerDestinations
            // 
            _ButtonX_EditCollisionPointerDestinations.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_EditCollisionPointerDestinations.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_EditCollisionPointerDestinations.Image = My.Resources.MyIcons.icons8_edit_16px;
            resources.ApplyResources(_ButtonX_EditCollisionPointerDestinations, "ButtonX_EditCollisionPointerDestinations");
            _ButtonX_EditCollisionPointerDestinations.Name = "ButtonX_EditCollisionPointerDestinations";
            _ButtonX_EditCollisionPointerDestinations.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _ButtonX_ImportModel;
            _LayoutControlItem3.Height = 31;
            _LayoutControlItem3.MinSize = new Size(32, 20);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            _LayoutControlItem3.Width = 99;
            _LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem4
            // 
            _LayoutControlItem4.Control = _ButtonX_RemoveObject;
            _LayoutControlItem4.Height = 31;
            _LayoutControlItem4.MinSize = new Size(32, 20);
            _LayoutControlItem4.Name = "LayoutControlItem4";
            _LayoutControlItem4.Width = 31;
            // 
            // LayoutGroup_ModelInfo
            // 
            _LayoutGroup_ModelInfo.Height = 57;
            _LayoutGroup_ModelInfo.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem2, _LayoutControlItem1 });
            _LayoutGroup_ModelInfo.MinSize = new Size(120, 32);
            _LayoutGroup_ModelInfo.Name = "LayoutGroup_ModelInfo";
            _LayoutGroup_ModelInfo.Padding = new Padding(0);
            _LayoutGroup_ModelInfo.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutGroup_ModelInfo.Width = 100;
            _LayoutGroup_ModelInfo.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _TextBoxX_Name;
            _LayoutControlItem2.Height = 28;
            _LayoutControlItem2.MinSize = new Size(120, 0);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            resources.ApplyResources(_LayoutControlItem2, "LayoutControlItem2");
            _LayoutControlItem2.Width = 100;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem1
            // 
            _LayoutControlItem1.Control = _TextBoxX_ModelID;
            _LayoutControlItem1.Height = 28;
            _LayoutControlItem1.MinSize = new Size(120, 0);
            _LayoutControlItem1.Name = "LayoutControlItem1";
            resources.ApplyResources(_LayoutControlItem1, "LayoutControlItem1");
            _LayoutControlItem1.Width = 100;
            _LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutGroup_CollisionPointerDestinations
            // 
            _LayoutGroup_CollisionPointerDestinations.Height = 35;
            _LayoutGroup_CollisionPointerDestinations.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem5, _LayoutControlItem6 });
            _LayoutGroup_CollisionPointerDestinations.MinSize = new Size(120, 32);
            _LayoutGroup_CollisionPointerDestinations.Name = "LayoutGroup_CollisionPointerDestinations";
            _LayoutGroup_CollisionPointerDestinations.Padding = new Padding(0);
            _LayoutGroup_CollisionPointerDestinations.TextPadding = new Padding(4, 0, 0, 0);
            _LayoutGroup_CollisionPointerDestinations.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            _LayoutGroup_CollisionPointerDestinations.Width = 100;
            _LayoutGroup_CollisionPointerDestinations.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem5
            // 
            _LayoutControlItem5.Control = _LabelX_CollisionPointerDestinationsCount;
            _LayoutControlItem5.Height = 31;
            _LayoutControlItem5.MinSize = new Size(64, 18);
            _LayoutControlItem5.Name = "LayoutControlItem5";
            resources.ApplyResources(_LayoutControlItem5, "LayoutControlItem5");
            _LayoutControlItem5.Width = 99;
            _LayoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem6
            // 
            _LayoutControlItem6.Control = _ButtonX_EditCollisionPointerDestinations;
            _LayoutControlItem6.Height = 31;
            _LayoutControlItem6.MinSize = new Size(32, 20);
            _LayoutControlItem6.Name = "LayoutControlItem6";
            _LayoutControlItem6.Width = 90;
            // 
            // ContextMenuBar1
            // 
            _ContextMenuBar1.AntiAlias = true;
            resources.ApplyResources(_ContextMenuBar1, "ContextMenuBar1");
            _ContextMenuBar1.IsMaximized = false;
            _ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _CM_Object });
            _ContextMenuBar1.Name = "ContextMenuBar1";
            _ContextMenuBar1.Stretch = true;
            _ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ContextMenuBar1.TabStop = false;
            // 
            // CM_Object
            // 
            _CM_Object.AutoExpandOnClick = true;
            _CM_Object.Name = "CM_Object";
            _CM_Object.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_ImportModell, _ButtonItem_ImportVisualMap, _ButtonItem_ImportCollision, _ButtonItem_RemoveCollision, _ButtonItem_ShowVisualMap, _ButtonItem_ShowCollision, _ButtonItem_CopyCollisionPointer, _ButtonItem_RemoveObject });
            resources.ApplyResources(_CM_Object, "CM_Object");
            // 
            // ButtonItem_ImportModell
            // 
            _ButtonItem_ImportModell.Image = My.Resources.MyIcons.icons8_import_16px;
            _ButtonItem_ImportModell.Name = "ButtonItem_ImportModell";
            resources.ApplyResources(_ButtonItem_ImportModell, "ButtonItem_ImportModell");
            // 
            // ButtonItem_ImportVisualMap
            // 
            _ButtonItem_ImportVisualMap.Image = (Image)resources.GetObject("ButtonItem_ImportVisualMap.Image");
            _ButtonItem_ImportVisualMap.Name = "ButtonItem_ImportVisualMap";
            resources.ApplyResources(_ButtonItem_ImportVisualMap, "ButtonItem_ImportVisualMap");
            // 
            // ButtonItem_ImportCollision
            // 
            _ButtonItem_ImportCollision.Image = (Image)resources.GetObject("ButtonItem_ImportCollision.Image");
            _ButtonItem_ImportCollision.Name = "ButtonItem_ImportCollision";
            resources.ApplyResources(_ButtonItem_ImportCollision, "ButtonItem_ImportCollision");
            // 
            // ButtonItem_RemoveCollision
            // 
            _ButtonItem_RemoveCollision.Image = My.Resources.MyIcons.icons8_delete_2_16px;
            _ButtonItem_RemoveCollision.Name = "ButtonItem_RemoveCollision";
            resources.ApplyResources(_ButtonItem_RemoveCollision, "ButtonItem_RemoveCollision");
            // 
            // ButtonItem_ShowVisualMap
            // 
            _ButtonItem_ShowVisualMap.BeginGroup = true;
            _ButtonItem_ShowVisualMap.Image = (Image)resources.GetObject("ButtonItem_ShowVisualMap.Image");
            _ButtonItem_ShowVisualMap.Name = "ButtonItem_ShowVisualMap";
            resources.ApplyResources(_ButtonItem_ShowVisualMap, "ButtonItem_ShowVisualMap");
            // 
            // ButtonItem_ShowCollision
            // 
            _ButtonItem_ShowCollision.Image = (Image)resources.GetObject("ButtonItem_ShowCollision.Image");
            _ButtonItem_ShowCollision.Name = "ButtonItem_ShowCollision";
            resources.ApplyResources(_ButtonItem_ShowCollision, "ButtonItem_ShowCollision");
            // 
            // ButtonItem_CopyCollisionPointer
            // 
            _ButtonItem_CopyCollisionPointer.BeginGroup = true;
            _ButtonItem_CopyCollisionPointer.Image = My.Resources.MyIcons.icons8_copy_16px;
            _ButtonItem_CopyCollisionPointer.Name = "ButtonItem_CopyCollisionPointer";
            resources.ApplyResources(_ButtonItem_CopyCollisionPointer, "ButtonItem_CopyCollisionPointer");
            // 
            // ButtonItem_RemoveObject
            // 
            _ButtonItem_RemoveObject.BeginGroup = true;
            _ButtonItem_RemoveObject.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem_RemoveObject.Name = "ButtonItem_RemoveObject";
            _ButtonItem_RemoveObject.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(150)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ButtonItem_RemoveObject.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            _ButtonItem_RemoveObject.SymbolSize = 12.0F;
            resources.ApplyResources(_ButtonItem_RemoveObject, "ButtonItem_RemoveObject");
            // 
            // CustomBankManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_ContextMenuBar1);
            Controls.Add(_Panel1);
            MaximizeBox = false;
            Name = "CustomBankManager";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            _LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).EndInit();
            ResumeLayout(false);
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
                }

                _ItemListBox1 = value;
                if (_ItemListBox1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_CreateNewObject;

        internal DevComponents.DotNetBar.ButtonX ButtonX_CreateNewObject
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_CreateNewObject;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_CreateNewObject != null)
                {
                    _ButtonX_CreateNewObject.Click -= ButtonX1_Click;
                }

                _ButtonX_CreateNewObject = value;
                if (_ButtonX_CreateNewObject != null)
                {
                    _ButtonX_CreateNewObject.Click += ButtonX1_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_RemoveObject;

        internal DevComponents.DotNetBar.ButtonX ButtonX_RemoveObject
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_RemoveObject;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_RemoveObject != null)
                {
                    _ButtonX_RemoveObject.Click -= ButtonItem_RemoveObject_Click;
                }

                _ButtonX_RemoveObject = value;
                if (_ButtonX_RemoveObject != null)
                {
                    _ButtonX_RemoveObject.Click += ButtonItem_RemoveObject_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ModelID;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ModelID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ModelID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ModelID != null)
                {
                    _TextBoxX_ModelID.TextChanged -= TextBoxX_ModelID_TextChanged;
                }

                _TextBoxX_ModelID = value;
                if (_TextBoxX_ModelID != null)
                {
                    _TextBoxX_ModelID.TextChanged += TextBoxX_ModelID_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_ImportModel;

        internal DevComponents.DotNetBar.ButtonX ButtonX_ImportModel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_ImportModel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_ImportModel != null)
                {
                    _ButtonX_ImportModel.Click -= ButtonItem_ImportModell_Click;
                }

                _ButtonX_ImportModel = value;
                if (_ButtonX_ImportModel != null)
                {
                    _ButtonX_ImportModel.Click += ButtonItem_ImportModell_Click;
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

        private DevComponents.DotNetBar.ContextMenuBar _ContextMenuBar1;

        internal DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuBar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuBar1 != null)
                {
                }

                _ContextMenuBar1 = value;
                if (_ContextMenuBar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _CM_Object;

        internal DevComponents.DotNetBar.ButtonItem CM_Object
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CM_Object;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CM_Object != null)
                {
                }

                _CM_Object = value;
                if (_CM_Object != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ShowVisualMap;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ShowVisualMap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ShowVisualMap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ShowVisualMap != null)
                {
                    _ButtonItem_ShowVisualMap.Click -= ButtonItem_ShowVisualMap_Click;
                }

                _ButtonItem_ShowVisualMap = value;
                if (_ButtonItem_ShowVisualMap != null)
                {
                    _ButtonItem_ShowVisualMap.Click += ButtonItem_ShowVisualMap_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ShowCollision;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ShowCollision
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ShowCollision;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ShowCollision != null)
                {
                    _ButtonItem_ShowCollision.Click -= ButtonItem_ShowCollision_Click;
                }

                _ButtonItem_ShowCollision = value;
                if (_ButtonItem_ShowCollision != null)
                {
                    _ButtonItem_ShowCollision.Click += ButtonItem_ShowCollision_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveObject;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObject
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveObject;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveObject != null)
                {
                    _ButtonItem_RemoveObject.Click -= ButtonItem_RemoveObject_Click;
                }

                _ButtonItem_RemoveObject = value;
                if (_ButtonItem_RemoveObject != null)
                {
                    _ButtonItem_RemoveObject.Click += ButtonItem_RemoveObject_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportModell;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportModell
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportModell;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportModell != null)
                {
                    _ButtonItem_ImportModell.Click -= ButtonItem_ImportModell_Click;
                }

                _ButtonItem_ImportModell = value;
                if (_ButtonItem_ImportModell != null)
                {
                    _ButtonItem_ImportModell.Click += ButtonItem_ImportModell_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveCollision;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveCollision
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveCollision;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveCollision != null)
                {
                    _ButtonItem_RemoveCollision.Click -= ButtonItem_RemoveCollision_Click;
                }

                _ButtonItem_RemoveCollision = value;
                if (_ButtonItem_RemoveCollision != null)
                {
                    _ButtonItem_RemoveCollision.Click += ButtonItem_RemoveCollision_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportVisualMap;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportVisualMap
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportVisualMap;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportVisualMap != null)
                {
                    _ButtonItem_ImportVisualMap.Click -= ButtonItem_ImportVisualMap_Click;
                }

                _ButtonItem_ImportVisualMap = value;
                if (_ButtonItem_ImportVisualMap != null)
                {
                    _ButtonItem_ImportVisualMap.Click += ButtonItem_ImportVisualMap_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ImportCollision;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ImportCollision
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ImportCollision;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ImportCollision != null)
                {
                    _ButtonItem_ImportCollision.Click -= ButtonItem_ImportCollision_Click;
                }

                _ButtonItem_ImportCollision = value;
                if (_ButtonItem_ImportCollision != null)
                {
                    _ButtonItem_ImportCollision.Click += ButtonItem_ImportCollision_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CopyCollisionPointer;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CopyCollisionPointer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CopyCollisionPointer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CopyCollisionPointer != null)
                {
                    _ButtonItem_CopyCollisionPointer.Click -= ButtonItem_CopyCollisionPointer_Click;
                }

                _ButtonItem_CopyCollisionPointer = value;
                if (_ButtonItem_CopyCollisionPointer != null)
                {
                    _ButtonItem_CopyCollisionPointer.Click += ButtonItem_CopyCollisionPointer_Click;
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

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Name;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Name
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Name;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Name != null)
                {
                    _TextBoxX_Name.TextChanged -= TextBoxX_Name_TextChanged;
                }

                _TextBoxX_Name = value;
                if (_TextBoxX_Name != null)
                {
                    _TextBoxX_Name.TextChanged += TextBoxX_Name_TextChanged;
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

        private DevComponents.DotNetBar.Layout.LayoutGroup _LayoutGroup_ModelInfo;

        internal DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_ModelInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutGroup_ModelInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutGroup_ModelInfo != null)
                {
                }

                _LayoutGroup_ModelInfo = value;
                if (_LayoutGroup_ModelInfo != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutGroup _LayoutGroup_CollisionPointerDestinations;

        internal DevComponents.DotNetBar.Layout.LayoutGroup LayoutGroup_CollisionPointerDestinations
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutGroup_CollisionPointerDestinations;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutGroup_CollisionPointerDestinations != null)
                {
                }

                _LayoutGroup_CollisionPointerDestinations = value;
                if (_LayoutGroup_CollisionPointerDestinations != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_EditCollisionPointerDestinations;

        internal DevComponents.DotNetBar.ButtonX ButtonX_EditCollisionPointerDestinations
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_EditCollisionPointerDestinations;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_EditCollisionPointerDestinations != null)
                {
                    _ButtonX_EditCollisionPointerDestinations.Click -= ButtonX_EditCollisionPointerDestinations_Click;
                }

                _ButtonX_EditCollisionPointerDestinations = value;
                if (_ButtonX_EditCollisionPointerDestinations != null)
                {
                    _ButtonX_EditCollisionPointerDestinations.Click += ButtonX_EditCollisionPointerDestinations_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_CollisionPointerDestinationsCount;

        internal DevComponents.DotNetBar.LabelX LabelX_CollisionPointerDestinationsCount
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_CollisionPointerDestinationsCount;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_CollisionPointerDestinationsCount != null)
                {
                }

                _LabelX_CollisionPointerDestinationsCount = value;
                if (_LabelX_CollisionPointerDestinationsCount != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem5;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem5 != null)
                {
                }

                _LayoutControlItem5 = value;
                if (_LayoutControlItem5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem6;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem6 != null)
                {
                }

                _LayoutControlItem6 = value;
                if (_LayoutControlItem6 != null)
                {
                }
            }
        }
    }
}