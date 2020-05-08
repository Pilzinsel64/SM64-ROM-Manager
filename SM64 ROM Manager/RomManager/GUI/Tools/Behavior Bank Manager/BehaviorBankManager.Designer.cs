namespace SM64_ROM_Manager
{
    partial class BehaviorBankManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BehaviorBankManager));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.ButtonItem_NewBehav = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.ButtonItem_NewBehav_SolidObject = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveBehav = new DevComponents.DotNetBar.ButtonItem();
            this.AdvTree_Behaviors = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.TabControl_Behav = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.TextBoxX_BehavName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_BehavColPtr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBoxX_BehavEnableColPtr = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ListViewEx_CustomAsmFunctions = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonX_AddCustomAsmFunction = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_RemoveCustomAsmFunction = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_LoopCustomAsmFunction = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_EditParamInfos = new DevComponents.DotNetBar.ButtonX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem2 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem3 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutGroup1 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.TabItem_BehavProps = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.ButtonX_SaveScript = new DevComponents.DotNetBar.ButtonX();
            this.RichTextBoxEx_Script = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.TabItem_BehavScript = new DevComponents.DotNetBar.TabItem(this.components);
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.customValidator2 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.highlighter_Script = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_Behaviors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_Behav)).BeginInit();
            this.TabControl_Behav.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            resources.ApplyResources(this.bar1, "bar1");
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_NewBehav,
            this.ButtonItem_RemoveBehav});
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabStop = false;
            // 
            // ButtonItem_NewBehav
            // 
            this.ButtonItem_NewBehav.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_NewBehav.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_NewBehav.Name = "ButtonItem_NewBehav";
            this.ButtonItem_NewBehav.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.ButtonItem_NewBehav_SolidObject});
            resources.ApplyResources(this.ButtonItem_NewBehav, "ButtonItem_NewBehav");
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.labelItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.PaddingBottom = 1;
            this.labelItem1.PaddingLeft = 10;
            this.labelItem1.PaddingTop = 1;
            this.labelItem1.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            resources.ApplyResources(this.labelItem1, "labelItem1");
            // 
            // ButtonItem_NewBehav_SolidObject
            // 
            this.ButtonItem_NewBehav_SolidObject.Name = "ButtonItem_NewBehav_SolidObject";
            resources.ApplyResources(this.ButtonItem_NewBehav_SolidObject, "ButtonItem_NewBehav_SolidObject");
            this.ButtonItem_NewBehav_SolidObject.Click += new System.EventHandler(this.ButtonItem_NewBehav_SolidObject_Click);
            // 
            // ButtonItem_RemoveBehav
            // 
            this.ButtonItem_RemoveBehav.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ButtonItem_RemoveBehav.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveBehav.Name = "ButtonItem_RemoveBehav";
            resources.ApplyResources(this.ButtonItem_RemoveBehav, "ButtonItem_RemoveBehav");
            this.ButtonItem_RemoveBehav.Click += new System.EventHandler(this.ButtonItem_RemoveBehav_Click);
            // 
            // AdvTree_Behaviors
            // 
            this.AdvTree_Behaviors.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree_Behaviors.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree_Behaviors.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree_Behaviors.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree_Behaviors.Columns.Add(this.columnHeader1);
            this.AdvTree_Behaviors.Columns.Add(this.columnHeader2);
            resources.ApplyResources(this.AdvTree_Behaviors, "AdvTree_Behaviors");
            this.AdvTree_Behaviors.DragDropEnabled = false;
            this.AdvTree_Behaviors.DragDropNodeCopyEnabled = false;
            this.AdvTree_Behaviors.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree_Behaviors.Name = "AdvTree_Behaviors";
            this.AdvTree_Behaviors.NodesConnector = this.nodeConnector1;
            this.AdvTree_Behaviors.NodeStyle = this.elementStyle1;
            this.AdvTree_Behaviors.PathSeparator = ";";
            this.AdvTree_Behaviors.Styles.Add(this.elementStyle1);
            this.AdvTree_Behaviors.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree_Behaviors_AfterNodeSelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            this.columnHeader1.Width.Relative = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            this.columnHeader2.Width.Absolute = 80;
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
            // TabControl_Behav
            // 
            this.TabControl_Behav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControl_Behav.CanReorderTabs = true;
            this.TabControl_Behav.Controls.Add(this.tabControlPanel1);
            this.TabControl_Behav.Controls.Add(this.tabControlPanel2);
            resources.ApplyResources(this.TabControl_Behav, "TabControl_Behav");
            this.TabControl_Behav.ForeColor = System.Drawing.Color.Black;
            this.TabControl_Behav.Name = "TabControl_Behav";
            this.TabControl_Behav.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabControl_Behav.SelectedTabIndex = 0;
            this.TabControl_Behav.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.TabControl_Behav.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.TabControl_Behav.Tabs.Add(this.TabItem_BehavProps);
            this.TabControl_Behav.Tabs.Add(this.TabItem_BehavScript);
            this.TabControl_Behav.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.TabControl_Behav_SelectedTabChanged);
            this.TabControl_Behav.SelectedTabChanging += new DevComponents.DotNetBar.TabStrip.SelectedTabChangingEventHandler(this.TabControl_Behav_SelectedTabChanging);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.layoutControl1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.tabControlPanel1, "tabControlPanel1");
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabItem = this.TabItem_BehavProps;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.TextBoxX_BehavName);
            this.layoutControl1.Controls.Add(this.textBoxX_BehavColPtr);
            this.layoutControl1.Controls.Add(this.checkBoxX_BehavEnableColPtr);
            this.layoutControl1.Controls.Add(this.ListViewEx_CustomAsmFunctions);
            this.layoutControl1.Controls.Add(this.ButtonX_AddCustomAsmFunction);
            this.layoutControl1.Controls.Add(this.ButtonX_RemoveCustomAsmFunction);
            this.layoutControl1.Controls.Add(this.ButtonX_LoopCustomAsmFunction);
            this.layoutControl1.Controls.Add(this.ButtonX_EditParamInfos);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.ForeColor = System.Drawing.Color.Black;
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutSpacerItem2,
            this.layoutControlItem8,
            this.layoutSpacerItem3,
            this.layoutSpacerItem1,
            this.layoutControlItem4,
            this.layoutGroup1});
            // 
            // TextBoxX_BehavName
            // 
            this.TextBoxX_BehavName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_BehavName.Border.Class = "TextBoxBorder";
            this.TextBoxX_BehavName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_BehavName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_BehavName.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TextBoxX_BehavName, "TextBoxX_BehavName");
            this.TextBoxX_BehavName.Name = "TextBoxX_BehavName";
            this.TextBoxX_BehavName.PreventEnterBeep = true;
            this.TextBoxX_BehavName.TextChanged += new System.EventHandler(this.TextBoxX_BehavName_TextChanged);
            // 
            // textBoxX_BehavColPtr
            // 
            this.textBoxX_BehavColPtr.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX_BehavColPtr.Border.Class = "TextBoxBorder";
            this.textBoxX_BehavColPtr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_BehavColPtr.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX_BehavColPtr.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.textBoxX_BehavColPtr, "textBoxX_BehavColPtr");
            this.textBoxX_BehavColPtr.Name = "textBoxX_BehavColPtr";
            this.textBoxX_BehavColPtr.PreventEnterBeep = true;
            this.textBoxX_BehavColPtr.TextChanged += new System.EventHandler(this.TextBoxX_BehavColPtr_TextChanged);
            // 
            // checkBoxX_BehavEnableColPtr
            // 
            // 
            // 
            // 
            this.checkBoxX_BehavEnableColPtr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX_BehavEnableColPtr.Checked = true;
            this.checkBoxX_BehavEnableColPtr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX_BehavEnableColPtr.CheckValue = "Y";
            resources.ApplyResources(this.checkBoxX_BehavEnableColPtr, "checkBoxX_BehavEnableColPtr");
            this.checkBoxX_BehavEnableColPtr.Name = "checkBoxX_BehavEnableColPtr";
            this.checkBoxX_BehavEnableColPtr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX_BehavEnableColPtr.CheckedChanged += new System.EventHandler(this.CheckBoxX_BehavEnableColPtr_CheckedChanged);
            // 
            // ListViewEx_CustomAsmFunctions
            // 
            // 
            // 
            // 
            this.ListViewEx_CustomAsmFunctions.Border.Class = "ListViewBorder";
            this.ListViewEx_CustomAsmFunctions.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx_CustomAsmFunctions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewEx_CustomAsmFunctions.DisabledBackColor = System.Drawing.Color.Empty;
            this.ListViewEx_CustomAsmFunctions.FullRowSelect = true;
            this.ListViewEx_CustomAsmFunctions.HideSelection = false;
            resources.ApplyResources(this.ListViewEx_CustomAsmFunctions, "ListViewEx_CustomAsmFunctions");
            this.ListViewEx_CustomAsmFunctions.Name = "ListViewEx_CustomAsmFunctions";
            this.ListViewEx_CustomAsmFunctions.UseCompatibleStateImageBehavior = false;
            this.ListViewEx_CustomAsmFunctions.View = System.Windows.Forms.View.Details;
            this.ListViewEx_CustomAsmFunctions.SelectedIndexChanged += new System.EventHandler(this.ListViewEx_CustomAsmFunctions_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // ButtonX_AddCustomAsmFunction
            // 
            this.ButtonX_AddCustomAsmFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_AddCustomAsmFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_AddCustomAsmFunction.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(this.ButtonX_AddCustomAsmFunction, "ButtonX_AddCustomAsmFunction");
            this.ButtonX_AddCustomAsmFunction.Name = "ButtonX_AddCustomAsmFunction";
            this.ButtonX_AddCustomAsmFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_AddCustomAsmFunction.Click += new System.EventHandler(this.ButtonX_AddCustomAsmFunction_Click);
            // 
            // ButtonX_RemoveCustomAsmFunction
            // 
            this.ButtonX_RemoveCustomAsmFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_RemoveCustomAsmFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_RemoveCustomAsmFunction, "ButtonX_RemoveCustomAsmFunction");
            this.ButtonX_RemoveCustomAsmFunction.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonX_RemoveCustomAsmFunction.Name = "ButtonX_RemoveCustomAsmFunction";
            this.ButtonX_RemoveCustomAsmFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_RemoveCustomAsmFunction.Click += new System.EventHandler(this.ButtonX_RemoveCustomAsmFunction_Click);
            // 
            // ButtonX_LoopCustomAsmFunction
            // 
            this.ButtonX_LoopCustomAsmFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_LoopCustomAsmFunction.AutoCheckOnClick = true;
            this.ButtonX_LoopCustomAsmFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_LoopCustomAsmFunction, "ButtonX_LoopCustomAsmFunction");
            this.ButtonX_LoopCustomAsmFunction.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_repeat_16px;
            this.ButtonX_LoopCustomAsmFunction.Name = "ButtonX_LoopCustomAsmFunction";
            this.ButtonX_LoopCustomAsmFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_LoopCustomAsmFunction.CheckedChanged += new System.EventHandler(this.ButtonX_LoopCustomAsmFunction_CheckedChanged);
            // 
            // ButtonX_EditParamInfos
            // 
            this.ButtonX_EditParamInfos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_EditParamInfos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.ButtonX_EditParamInfos, "ButtonX_EditParamInfos");
            this.ButtonX_EditParamInfos.Name = "ButtonX_EditParamInfos";
            this.ButtonX_EditParamInfos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_EditParamInfos.Click += new System.EventHandler(this.ButtonX_EditParamInfos_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TextBoxX_BehavName;
            this.layoutControlItem1.Height = 28;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textBoxX_BehavColPtr;
            this.layoutControlItem2.Height = 28;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Width = 99;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkBoxX_BehavEnableColPtr;
            this.layoutControlItem3.Height = 28;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Width = 80;
            // 
            // layoutSpacerItem2
            // 
            this.layoutSpacerItem2.Height = 28;
            this.layoutSpacerItem2.Name = "layoutSpacerItem2";
            this.layoutSpacerItem2.Width = 1;
            this.layoutSpacerItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.ButtonX_EditParamInfos;
            this.layoutControlItem8.Height = 31;
            this.layoutControlItem8.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem8.Name = "layoutControlItem8";
            resources.ApplyResources(this.layoutControlItem8, "layoutControlItem8");
            this.layoutControlItem8.TextPadding = new System.Windows.Forms.Padding(0, 5, 0, -5);
            this.layoutControlItem8.Width = 200;
            // 
            // layoutSpacerItem3
            // 
            this.layoutSpacerItem3.Height = 31;
            this.layoutSpacerItem3.Name = "layoutSpacerItem3";
            this.layoutSpacerItem3.Width = 99;
            this.layoutSpacerItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 31;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 100;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ListViewEx_CustomAsmFunctions;
            this.layoutControlItem4.Height = 100;
            this.layoutControlItem4.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.SharedTextSizeEnabled = false;
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutControlItem4.Width = 99;
            this.layoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutGroup1
            // 
            this.layoutGroup1.Height = 120;
            this.layoutGroup1.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutGroup1.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup1.Name = "layoutGroup1";
            this.layoutGroup1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup1.Width = 50;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ButtonX_AddCustomAsmFunction;
            this.layoutControlItem5.Height = 31;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Width = 100;
            this.layoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ButtonX_RemoveCustomAsmFunction;
            this.layoutControlItem6.Height = 31;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Width = 100;
            this.layoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ButtonX_LoopCustomAsmFunction;
            this.layoutControlItem7.Height = 31;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(32, 20);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Width = 112;
            // 
            // TabItem_BehavProps
            // 
            this.TabItem_BehavProps.AttachedControl = this.tabControlPanel1;
            this.TabItem_BehavProps.Name = "TabItem_BehavProps";
            resources.ApplyResources(this.TabItem_BehavProps, "TabItem_BehavProps");
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.ButtonX_SaveScript);
            this.tabControlPanel2.Controls.Add(this.RichTextBoxEx_Script);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.tabControlPanel2, "tabControlPanel2");
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabItem = this.TabItem_BehavScript;
            // 
            // ButtonX_SaveScript
            // 
            this.ButtonX_SaveScript.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_SaveScript, "ButtonX_SaveScript");
            this.ButtonX_SaveScript.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_SaveScript.Name = "ButtonX_SaveScript";
            this.ButtonX_SaveScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_SaveScript.Click += new System.EventHandler(this.ButtonX_SaveScript_Click);
            // 
            // RichTextBoxEx_Script
            // 
            // 
            // 
            // 
            this.RichTextBoxEx_Script.BackgroundStyle.Class = "RichTextBoxBorder";
            this.RichTextBoxEx_Script.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.RichTextBoxEx_Script, "RichTextBoxEx_Script");
            this.RichTextBoxEx_Script.Name = "RichTextBoxEx_Script";
            this.RichTextBoxEx_Script.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1031{\\fonttbl{\\f0\\fnil\\fcharset0 Consolas;}}" +
    "\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.RichTextBoxEx_Script.GotFocus += new System.EventHandler(this.RichTextBoxEx_Script_GotFocus);
            this.RichTextBoxEx_Script.LostFocus += new System.EventHandler(this.RichTextBoxEx_Script_LostFocus);
            // 
            // TabItem_BehavScript
            // 
            this.TabItem_BehavScript.AttachedControl = this.tabControlPanel2;
            this.TabItem_BehavScript.Name = "TabItem_BehavScript";
            resources.ApplyResources(this.TabItem_BehavScript, "TabItem_BehavScript");
            // 
            // customValidator1
            // 
            resources.ApplyResources(this.customValidator1, "customValidator1");
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // customValidator2
            // 
            resources.ApplyResources(this.customValidator2, "customValidator2");
            this.customValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // highlighter_Script
            // 
            this.highlighter_Script.ContainerControl = this.tabControlPanel2;
            this.highlighter_Script.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // BehaviorBankManager
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.TabControl_Behav);
            this.Controls.Add(this.AdvTree_Behaviors);
            this.Controls.Add(this.bar1);
            this.Name = "BehaviorBankManager";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BehaviorBankManager_FormClosing);
            this.Shown += new System.EventHandler(this.BehaviorBankManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree_Behaviors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_Behav)).EndInit();
            this.TabControl_Behav.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_NewBehav;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveBehav;
        private DevComponents.AdvTree.AdvTree AdvTree_Behaviors;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.TabControl TabControl_Behav;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem TabItem_BehavProps;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem TabItem_BehavScript;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx RichTextBoxEx_Script;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_BehavName;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_BehavColPtr;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX_BehavEnableColPtr;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator2;
        private DevComponents.DotNetBar.ButtonX ButtonX_SaveScript;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter_Script;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_NewBehav_SolidObject;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_CustomAsmFunctions;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.ButtonX ButtonX_AddCustomAsmFunction;
        private DevComponents.DotNetBar.ButtonX ButtonX_RemoveCustomAsmFunction;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.ButtonX ButtonX_LoopCustomAsmFunction;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem2;
        private DevComponents.DotNetBar.ButtonX ButtonX_EditParamInfos;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem3;
    }
}