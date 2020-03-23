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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectBankDataEditor));
            _ObdTree = new DevComponents.AdvTree.AdvTree();
            _ObdTree.BeforeCellEdit += new DevComponents.AdvTree.CellEditEventHandler(ObdTree_BeforeCellEdit);
            _ObdTree.AfterCellEdit += new DevComponents.AdvTree.CellEditEventHandler(ObdTree_AfterCellEdit);
            _Node1 = new DevComponents.AdvTree.Node();
            _NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            _ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            _ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            _ButtonItem_CM_ObdList = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveObdList = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveObdList.Click += new EventHandler(ButtonItem_RemoveObdList_Click);
            _ButtonItem_CM_Obd = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveObd = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveObd.Click += new EventHandler(ButtonItem_RemoveObd_Click);
            _ButtonItem_CM_Cmds = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_CM_Cmd = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveCmd = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveCmd.Click += new EventHandler(ButtonItem_RemoveCmd_Click);
            _ButtonItem_CM_Objs = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_CM_Obj = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveObj = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_RemoveObj.Click += new EventHandler(ButtonItem_RemoveObj_Click);
            _ButtonItem_AddObj = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_AddObj.Click += new EventHandler(ButtonItem_AddObj_Click);
            _ButtonItem_AddCmd = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_AddCmd.Click += new EventHandler(ButtonItem_AddCmd_Click);
            _ButtonItem_AddObd = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_AddObd.Click += new EventHandler(ButtonItem_AddObd_Click);
            ((System.ComponentModel.ISupportInitialize)_ObdTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).BeginInit();
            SuspendLayout();
            // 
            // ObdTree
            // 
            _ObdTree.AccessibleRole = AccessibleRole.Outline;
            _ObdTree.BackColor = SystemColors.Window;
            // 
            // 
            // 
            _ObdTree.BackgroundStyle.Class = "TreeBorderKey";
            _ObdTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ObdTree.CellEdit = true;
            _ObdTree.Dock = DockStyle.Fill;
            _ObdTree.DragDropEnabled = false;
            _ObdTree.DragDropNodeCopyEnabled = false;
            _ObdTree.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ObdTree.Location = new Point(0, 0);
            _ObdTree.Name = "ObdTree";
            _ObdTree.Nodes.AddRange(new DevComponents.AdvTree.Node[] { _Node1 });
            _ObdTree.NodesConnector = _NodeConnector1;
            _ObdTree.NodeStyle = _ElementStyle1;
            _ObdTree.PathSeparator = ";";
            _ObdTree.Size = new Size(484, 661);
            _ObdTree.Styles.Add(_ElementStyle1);
            _ObdTree.TabIndex = 0;
            _ObdTree.Text = "AdvTree1";
            _ObdTree.TileSize = new Size(200, 30);
            // 
            // Node1
            // 
            _Node1.Expanded = true;
            _Node1.Name = "Node1";
            _Node1.Text = "Node1";
            // 
            // NodeConnector1
            // 
            _NodeConnector1.LineColor = SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            _ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ElementStyle1.Name = "ElementStyle1";
            _ElementStyle1.TextColor = SystemColors.ControlText;
            // 
            // ContextMenuBar1
            // 
            _ContextMenuBar1.AntiAlias = true;
            _ContextMenuBar1.Font = new Font("Segoe UI", 9.0F);
            _ContextMenuBar1.IsMaximized = false;
            _ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_CM_ObdList, _ButtonItem_CM_Obd, _ButtonItem_CM_Cmds, _ButtonItem_CM_Cmd, _ButtonItem_CM_Objs, _ButtonItem_CM_Obj });
            _ContextMenuBar1.Location = new Point(140, 0);
            _ContextMenuBar1.Name = "ContextMenuBar1";
            _ContextMenuBar1.Size = new Size(341, 25);
            _ContextMenuBar1.Stretch = true;
            _ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ContextMenuBar1.TabIndex = 1;
            _ContextMenuBar1.TabStop = false;
            _ContextMenuBar1.Text = "ContextMenuBar1";
            // 
            // ButtonItem_CM_ObdList
            // 
            _ButtonItem_CM_ObdList.AutoExpandOnClick = true;
            _ButtonItem_CM_ObdList.Name = "ButtonItem_CM_ObdList";
            _ButtonItem_CM_ObdList.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_AddObd, _ButtonItem_RemoveObdList });
            _ButtonItem_CM_ObdList.Text = "ObdList";
            // 
            // ButtonItem_RemoveObdList
            // 
            _ButtonItem_RemoveObdList.BeginGroup = true;
            _ButtonItem_RemoveObdList.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem_RemoveObdList.Name = "ButtonItem_RemoveObdList";
            _ButtonItem_RemoveObdList.Text = "Remove";
            // 
            // ButtonItem_CM_Obd
            // 
            _ButtonItem_CM_Obd.AutoExpandOnClick = true;
            _ButtonItem_CM_Obd.Name = "ButtonItem_CM_Obd";
            _ButtonItem_CM_Obd.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_RemoveObd });
            _ButtonItem_CM_Obd.Text = "Obd";
            // 
            // ButtonItem_RemoveObd
            // 
            _ButtonItem_RemoveObd.BeginGroup = true;
            _ButtonItem_RemoveObd.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem_RemoveObd.Name = "ButtonItem_RemoveObd";
            _ButtonItem_RemoveObd.Text = "Remove";
            // 
            // ButtonItem_CM_Cmds
            // 
            _ButtonItem_CM_Cmds.AutoExpandOnClick = true;
            _ButtonItem_CM_Cmds.Name = "ButtonItem_CM_Cmds";
            _ButtonItem_CM_Cmds.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_AddCmd });
            _ButtonItem_CM_Cmds.Text = "Cmds";
            // 
            // ButtonItem_CM_Cmd
            // 
            _ButtonItem_CM_Cmd.AutoExpandOnClick = true;
            _ButtonItem_CM_Cmd.Name = "ButtonItem_CM_Cmd";
            _ButtonItem_CM_Cmd.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_RemoveCmd });
            _ButtonItem_CM_Cmd.Text = "Cmd";
            // 
            // ButtonItem_RemoveCmd
            // 
            _ButtonItem_RemoveCmd.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem_RemoveCmd.Name = "ButtonItem_RemoveCmd";
            _ButtonItem_RemoveCmd.Text = "Remove";
            // 
            // ButtonItem_CM_Objs
            // 
            _ButtonItem_CM_Objs.AutoExpandOnClick = true;
            _ButtonItem_CM_Objs.Name = "ButtonItem_CM_Objs";
            _ButtonItem_CM_Objs.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_AddObj });
            _ButtonItem_CM_Objs.Text = "Objs";
            // 
            // ButtonItem_CM_Obj
            // 
            _ButtonItem_CM_Obj.AutoExpandOnClick = true;
            _ButtonItem_CM_Obj.Name = "ButtonItem_CM_Obj";
            _ButtonItem_CM_Obj.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_RemoveObj });
            _ButtonItem_CM_Obj.Text = "Obj";
            // 
            // ButtonItem_RemoveObj
            // 
            _ButtonItem_RemoveObj.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            _ButtonItem_RemoveObj.Name = "ButtonItem_RemoveObj";
            _ButtonItem_RemoveObj.Text = "Remove";
            // 
            // ButtonItem_AddObj
            // 
            _ButtonItem_AddObj.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonItem_AddObj.Name = "ButtonItem_AddObj";
            _ButtonItem_AddObj.Text = "Add Object Name";
            // 
            // ButtonItem_AddCmd
            // 
            _ButtonItem_AddCmd.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonItem_AddCmd.Name = "ButtonItem_AddCmd";
            _ButtonItem_AddCmd.Text = "Add Command";
            // 
            // ButtonItem_AddObd
            // 
            _ButtonItem_AddObd.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            _ButtonItem_AddObd.Name = "ButtonItem_AddObd";
            _ButtonItem_AddObd.Text = "Add Object Bank Data";
            // 
            // ObjectBankDataEditor
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 661);
            Controls.Add(_ContextMenuBar1);
            Controls.Add(_ObdTree);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ObjectBankDataEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object Bank Data Editor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_ObdTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.AdvTree.AdvTree _ObdTree;

        internal DevComponents.AdvTree.AdvTree ObdTree
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ObdTree;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ObdTree != null)
                {
                    _ObdTree.BeforeCellEdit -= ObdTree_BeforeCellEdit;
                    _ObdTree.AfterCellEdit -= ObdTree_AfterCellEdit;
                }

                _ObdTree = value;
                if (_ObdTree != null)
                {
                    _ObdTree.BeforeCellEdit += ObdTree_BeforeCellEdit;
                    _ObdTree.AfterCellEdit += ObdTree_AfterCellEdit;
                }
            }
        }

        private DevComponents.AdvTree.Node _Node1;

        internal DevComponents.AdvTree.Node Node1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Node1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Node1 != null)
                {
                }

                _Node1 = value;
                if (_Node1 != null)
                {
                }
            }
        }

        private DevComponents.AdvTree.NodeConnector _NodeConnector1;

        internal DevComponents.AdvTree.NodeConnector NodeConnector1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NodeConnector1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NodeConnector1 != null)
                {
                }

                _NodeConnector1 = value;
                if (_NodeConnector1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ElementStyle _ElementStyle1;

        internal DevComponents.DotNetBar.ElementStyle ElementStyle1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ElementStyle1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ElementStyle1 != null)
                {
                }

                _ElementStyle1 = value;
                if (_ElementStyle1 != null)
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

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM_Cmd;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Cmd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM_Cmd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM_Cmd != null)
                {
                }

                _ButtonItem_CM_Cmd = value;
                if (_ButtonItem_CM_Cmd != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM_Cmds;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Cmds
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM_Cmds;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM_Cmds != null)
                {
                }

                _ButtonItem_CM_Cmds = value;
                if (_ButtonItem_CM_Cmds != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM_Objs;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Objs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM_Objs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM_Objs != null)
                {
                }

                _ButtonItem_CM_Objs = value;
                if (_ButtonItem_CM_Objs != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM_Obj;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Obj
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM_Obj;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM_Obj != null)
                {
                }

                _ButtonItem_CM_Obj = value;
                if (_ButtonItem_CM_Obj != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM_Obd;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM_Obd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM_Obd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM_Obd != null)
                {
                }

                _ButtonItem_CM_Obd = value;
                if (_ButtonItem_CM_Obd != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM_ObdList;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM_ObdList
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM_ObdList;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM_ObdList != null)
                {
                }

                _ButtonItem_CM_ObdList = value;
                if (_ButtonItem_CM_ObdList != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveObj;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObj
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveObj;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveObj != null)
                {
                    _ButtonItem_RemoveObj.Click -= ButtonItem_RemoveObj_Click;
                }

                _ButtonItem_RemoveObj = value;
                if (_ButtonItem_RemoveObj != null)
                {
                    _ButtonItem_RemoveObj.Click += ButtonItem_RemoveObj_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveCmd;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveCmd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveCmd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveCmd != null)
                {
                    _ButtonItem_RemoveCmd.Click -= ButtonItem_RemoveCmd_Click;
                }

                _ButtonItem_RemoveCmd = value;
                if (_ButtonItem_RemoveCmd != null)
                {
                    _ButtonItem_RemoveCmd.Click += ButtonItem_RemoveCmd_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveObd;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveObd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveObd != null)
                {
                    _ButtonItem_RemoveObd.Click -= ButtonItem_RemoveObd_Click;
                }

                _ButtonItem_RemoveObd = value;
                if (_ButtonItem_RemoveObd != null)
                {
                    _ButtonItem_RemoveObd.Click += ButtonItem_RemoveObd_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_RemoveObdList;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_RemoveObdList
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_RemoveObdList;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_RemoveObdList != null)
                {
                    _ButtonItem_RemoveObdList.Click -= ButtonItem_RemoveObdList_Click;
                }

                _ButtonItem_RemoveObdList = value;
                if (_ButtonItem_RemoveObdList != null)
                {
                    _ButtonItem_RemoveObdList.Click += ButtonItem_RemoveObdList_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddObj;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddObj
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddObj;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddObj != null)
                {
                    _ButtonItem_AddObj.Click -= ButtonItem_AddObj_Click;
                }

                _ButtonItem_AddObj = value;
                if (_ButtonItem_AddObj != null)
                {
                    _ButtonItem_AddObj.Click += ButtonItem_AddObj_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddCmd;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddCmd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddCmd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddCmd != null)
                {
                    _ButtonItem_AddCmd.Click -= ButtonItem_AddCmd_Click;
                }

                _ButtonItem_AddCmd = value;
                if (_ButtonItem_AddCmd != null)
                {
                    _ButtonItem_AddCmd.Click += ButtonItem_AddCmd_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_AddObd;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_AddObd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_AddObd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_AddObd != null)
                {
                    _ButtonItem_AddObd.Click -= ButtonItem_AddObd_Click;
                }

                _ButtonItem_AddObd = value;
                if (_ButtonItem_AddObd != null)
                {
                    _ButtonItem_AddObd.Click += ButtonItem_AddObd_Click;
                }
            }
        }
    }
}