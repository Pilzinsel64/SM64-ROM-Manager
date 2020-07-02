using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ObjectBankDataEditor : DevComponents.DotNetBar.OfficeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectBankDataEditor));
            this.ObdTree = new DevComponents.AdvTree.AdvTree();
            this.Node1 = new DevComponents.AdvTree.Node();
            this.NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ButtonItem_CM_ObdList = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AddObd = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveObdList = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CM_Obd = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveObd = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CM_Cmds = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AddCmd = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CM_Cmd = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveCmd = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CM_Objs = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_AddObj = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_CM_Obj = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_RemoveObj = new DevComponents.DotNetBar.ButtonItem();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonItem_Export = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Import = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ObdTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ObdTree
            // 
            this.ObdTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.ObdTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.ObdTree.BackgroundStyle.Class = "TreeBorderKey";
            this.ObdTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ObdTree.CellEdit = true;
            resources.ApplyResources(this.ObdTree, "ObdTree");
            this.ObdTree.DragDropEnabled = false;
            this.ObdTree.DragDropNodeCopyEnabled = false;
            this.ObdTree.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ObdTree.Name = "ObdTree";
            this.ObdTree.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.Node1});
            this.ObdTree.NodesConnector = this.NodeConnector1;
            this.ObdTree.NodeStyle = this.ElementStyle1;
            this.ObdTree.PathSeparator = ";";
            this.ObdTree.Styles.Add(this.ElementStyle1);
            this.ObdTree.TileSize = new System.Drawing.Size(200, 30);
            this.ObdTree.BeforeCellEdit += new DevComponents.AdvTree.CellEditEventHandler(this.ObdTree_BeforeCellEdit);
            this.ObdTree.AfterCellEdit += new DevComponents.AdvTree.CellEditEventHandler(this.ObdTree_AfterCellEdit);
            // 
            // Node1
            // 
            this.Node1.Expanded = true;
            this.Node1.Name = "Node1";
            resources.ApplyResources(this.Node1, "Node1");
            // 
            // NodeConnector1
            // 
            this.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            this.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ElementStyle1.Name = "ElementStyle1";
            this.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ContextMenuBar1
            // 
            this.ContextMenuBar1.AntiAlias = true;
            resources.ApplyResources(this.ContextMenuBar1, "ContextMenuBar1");
            this.ContextMenuBar1.IsMaximized = false;
            this.ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_CM_ObdList,
            this.ButtonItem_CM_Obd,
            this.ButtonItem_CM_Cmds,
            this.ButtonItem_CM_Cmd,
            this.ButtonItem_CM_Objs,
            this.ButtonItem_CM_Obj});
            this.ContextMenuBar1.Name = "ContextMenuBar1";
            this.ContextMenuBar1.Stretch = true;
            this.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar1.TabStop = false;
            // 
            // ButtonItem_CM_ObdList
            // 
            this.ButtonItem_CM_ObdList.AutoExpandOnClick = true;
            this.ButtonItem_CM_ObdList.Name = "ButtonItem_CM_ObdList";
            this.ButtonItem_CM_ObdList.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AddObd,
            this.ButtonItem_RemoveObdList});
            resources.ApplyResources(this.ButtonItem_CM_ObdList, "ButtonItem_CM_ObdList");
            // 
            // ButtonItem_AddObd
            // 
            this.ButtonItem_AddObd.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_AddObd.Name = "ButtonItem_AddObd";
            resources.ApplyResources(this.ButtonItem_AddObd, "ButtonItem_AddObd");
            this.ButtonItem_AddObd.Click += new System.EventHandler(this.ButtonItem_AddObd_Click);
            // 
            // ButtonItem_RemoveObdList
            // 
            this.ButtonItem_RemoveObdList.BeginGroup = true;
            this.ButtonItem_RemoveObdList.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveObdList.Name = "ButtonItem_RemoveObdList";
            resources.ApplyResources(this.ButtonItem_RemoveObdList, "ButtonItem_RemoveObdList");
            this.ButtonItem_RemoveObdList.Click += new System.EventHandler(this.ButtonItem_RemoveObdList_Click);
            // 
            // ButtonItem_CM_Obd
            // 
            this.ButtonItem_CM_Obd.AutoExpandOnClick = true;
            this.ButtonItem_CM_Obd.Name = "ButtonItem_CM_Obd";
            this.ButtonItem_CM_Obd.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_RemoveObd});
            resources.ApplyResources(this.ButtonItem_CM_Obd, "ButtonItem_CM_Obd");
            // 
            // ButtonItem_RemoveObd
            // 
            this.ButtonItem_RemoveObd.BeginGroup = true;
            this.ButtonItem_RemoveObd.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveObd.Name = "ButtonItem_RemoveObd";
            resources.ApplyResources(this.ButtonItem_RemoveObd, "ButtonItem_RemoveObd");
            this.ButtonItem_RemoveObd.Click += new System.EventHandler(this.ButtonItem_RemoveObd_Click);
            // 
            // ButtonItem_CM_Cmds
            // 
            this.ButtonItem_CM_Cmds.AutoExpandOnClick = true;
            this.ButtonItem_CM_Cmds.Name = "ButtonItem_CM_Cmds";
            this.ButtonItem_CM_Cmds.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AddCmd});
            resources.ApplyResources(this.ButtonItem_CM_Cmds, "ButtonItem_CM_Cmds");
            // 
            // ButtonItem_AddCmd
            // 
            this.ButtonItem_AddCmd.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_AddCmd.Name = "ButtonItem_AddCmd";
            resources.ApplyResources(this.ButtonItem_AddCmd, "ButtonItem_AddCmd");
            this.ButtonItem_AddCmd.Click += new System.EventHandler(this.ButtonItem_AddCmd_Click);
            // 
            // ButtonItem_CM_Cmd
            // 
            this.ButtonItem_CM_Cmd.AutoExpandOnClick = true;
            this.ButtonItem_CM_Cmd.Name = "ButtonItem_CM_Cmd";
            this.ButtonItem_CM_Cmd.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_RemoveCmd});
            resources.ApplyResources(this.ButtonItem_CM_Cmd, "ButtonItem_CM_Cmd");
            // 
            // ButtonItem_RemoveCmd
            // 
            this.ButtonItem_RemoveCmd.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveCmd.Name = "ButtonItem_RemoveCmd";
            resources.ApplyResources(this.ButtonItem_RemoveCmd, "ButtonItem_RemoveCmd");
            this.ButtonItem_RemoveCmd.Click += new System.EventHandler(this.ButtonItem_RemoveCmd_Click);
            // 
            // ButtonItem_CM_Objs
            // 
            this.ButtonItem_CM_Objs.AutoExpandOnClick = true;
            this.ButtonItem_CM_Objs.Name = "ButtonItem_CM_Objs";
            this.ButtonItem_CM_Objs.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_AddObj});
            resources.ApplyResources(this.ButtonItem_CM_Objs, "ButtonItem_CM_Objs");
            // 
            // ButtonItem_AddObj
            // 
            this.ButtonItem_AddObj.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_plus_math_16px;
            this.ButtonItem_AddObj.Name = "ButtonItem_AddObj";
            resources.ApplyResources(this.ButtonItem_AddObj, "ButtonItem_AddObj");
            this.ButtonItem_AddObj.Click += new System.EventHandler(this.ButtonItem_AddObj_Click);
            // 
            // ButtonItem_CM_Obj
            // 
            this.ButtonItem_CM_Obj.AutoExpandOnClick = true;
            this.ButtonItem_CM_Obj.Name = "ButtonItem_CM_Obj";
            this.ButtonItem_CM_Obj.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_RemoveObj});
            resources.ApplyResources(this.ButtonItem_CM_Obj, "ButtonItem_CM_Obj");
            // 
            // ButtonItem_RemoveObj
            // 
            this.ButtonItem_RemoveObj.Image = global::SM64_ROM_Manager.My.Resources.MyIcons.icons8_delete_sign_16px;
            this.ButtonItem_RemoveObj.Name = "ButtonItem_RemoveObj";
            resources.ApplyResources(this.ButtonItem_RemoveObj, "ButtonItem_RemoveObj");
            this.ButtonItem_RemoveObj.Click += new System.EventHandler(this.ButtonItem_RemoveObj_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.AutoExpandOnClick = true;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_Export,
            this.ButtonItem_Import});
            // 
            // ButtonItem_Export
            // 
            this.ButtonItem_Export.GlobalItem = false;
            this.ButtonItem_Export.Name = "ButtonItem_Export";
            resources.ApplyResources(this.ButtonItem_Export, "ButtonItem_Export");
            this.ButtonItem_Export.Click += new System.EventHandler(this.ButtonItem_Export_Click);
            // 
            // ButtonItem_Import
            // 
            this.ButtonItem_Import.GlobalItem = false;
            this.ButtonItem_Import.Name = "ButtonItem_Import";
            resources.ApplyResources(this.ButtonItem_Import, "ButtonItem_Import");
            this.ButtonItem_Import.Click += new System.EventHandler(this.ButtonItem_Import_Click);
            // 
            // ObjectBankDataEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.ContextMenuBar1);
            this.Controls.Add(this.ObdTree);
            this.Name = "ObjectBankDataEditor";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.ObdTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevComponents.AdvTree.AdvTree ObdTree;

        private DevComponents.AdvTree.Node Node1;

        private DevComponents.AdvTree.NodeConnector NodeConnector1;

        private DevComponents.DotNetBar.ElementStyle ElementStyle1;

        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Cmd;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Cmds;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Objs;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Obj;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Obd;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_CM_ObdList;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObj;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveCmd;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObd;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObdList;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddObj;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddCmd;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_AddObd;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Export;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Import;
    }
}