using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.PatchScripts
{
    [DesignerGenerated()]
    public partial class ObjectCatalog : DevComponents.DotNetBar.OfficeForm
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components = null;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectCatalog));
            _ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            _AdvTree1 = new DevComponents.AdvTree.AdvTree();
            _AdvTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(AdvTree1_AfterNodeSelect);
            _ImageList_RefSymbols = new System.Windows.Forms.ImageList(components);
            _Node1 = new DevComponents.AdvTree.Node();
            _NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            _ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            _TableLayoutPanel_2 = new System.Windows.Forms.TableLayoutPanel();
            _TableLayoutPanel_1 = new System.Windows.Forms.TableLayoutPanel();
            _LabelX_MemberInfo = new DevComponents.DotNetBar.LabelX();
            _CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).BeginInit();
            _TableLayoutPanel_2.SuspendLayout();
            _TableLayoutPanel_1.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewEx1
            // 
            _ListViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _ListViewEx1.Border.Class = "ListViewBorder";
            _ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            _ListViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            _ListViewEx1.ForeColor = System.Drawing.Color.Black;
            _ListViewEx1.HideSelection = false;
            _ListViewEx1.Location = new System.Drawing.Point(400, 3);
            _ListViewEx1.Name = "ListViewEx1";
            _ListViewEx1.Size = new System.Drawing.Size(391, 358);
            _ListViewEx1.TabIndex = 0;
            _ListViewEx1.UseCompatibleStateImageBehavior = false;
            // 
            // AdvTree1
            // 
            _AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            _AdvTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            _AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            _AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _AdvTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            _AdvTree1.DragDropEnabled = false;
            _AdvTree1.DragDropNodeCopyEnabled = false;
            _AdvTree1.ImageList = _ImageList_RefSymbols;
            _AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _AdvTree1.Location = new System.Drawing.Point(3, 3);
            _AdvTree1.Name = "AdvTree1";
            _AdvTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] { _Node1 });
            _AdvTree1.NodesConnector = _NodeConnector1;
            _AdvTree1.NodeStyle = _ElementStyle1;
            _AdvTree1.PathSeparator = ";";
            _AdvTree1.Size = new System.Drawing.Size(391, 358);
            _AdvTree1.Styles.Add(_ElementStyle1);
            _AdvTree1.TabIndex = 1;
            _AdvTree1.Text = "AdvTree1";
            // 
            // ImageList_RefSymbols
            // 
            _ImageList_RefSymbols.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            _ImageList_RefSymbols.ImageSize = new System.Drawing.Size(16, 16);
            _ImageList_RefSymbols.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Node1
            // 
            _Node1.Expanded = true;
            _Node1.Name = "Node1";
            _Node1.Text = "Node1";
            // 
            // NodeConnector1
            // 
            _NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // ElementStyle1
            // 
            _ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ElementStyle1.Name = "ElementStyle1";
            _ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // TableLayoutPanel_2
            // 
            _TableLayoutPanel_2.BackColor = System.Drawing.Color.Transparent;
            _TableLayoutPanel_2.ColumnCount = 2;
            _TableLayoutPanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
            _TableLayoutPanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
            _TableLayoutPanel_2.Controls.Add(_AdvTree1, 0, 0);
            _TableLayoutPanel_2.Controls.Add(_ListViewEx1, 1, 0);
            _TableLayoutPanel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            _TableLayoutPanel_2.Location = new System.Drawing.Point(3, 3);
            _TableLayoutPanel_2.Name = "TableLayoutPanel_2";
            _TableLayoutPanel_2.RowCount = 1;
            _TableLayoutPanel_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
            _TableLayoutPanel_2.Size = new System.Drawing.Size(794, 364);
            _TableLayoutPanel_2.TabIndex = 2;
            // 
            // TableLayoutPanel_1
            // 
            _TableLayoutPanel_1.BackColor = System.Drawing.Color.Transparent;
            _TableLayoutPanel_1.ColumnCount = 1;
            _TableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            _TableLayoutPanel_1.Controls.Add(_TableLayoutPanel_2, 0, 0);
            _TableLayoutPanel_1.Controls.Add(_LabelX_MemberInfo, 0, 1);
            _TableLayoutPanel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            _TableLayoutPanel_1.Location = new System.Drawing.Point(0, 0);
            _TableLayoutPanel_1.Name = "TableLayoutPanel_1";
            _TableLayoutPanel_1.RowCount = 2;
            _TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            _TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0F));
            _TableLayoutPanel_1.Size = new System.Drawing.Size(800, 450);
            _TableLayoutPanel_1.TabIndex = 3;
            _TableLayoutPanel_1.Visible = false;
            // 
            // LabelX_MemberInfo
            // 
            // 
            // 
            // 
            _LabelX_MemberInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_MemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            _LabelX_MemberInfo.Location = new System.Drawing.Point(3, 373);
            _LabelX_MemberInfo.Name = "LabelX_MemberInfo";
            _LabelX_MemberInfo.Size = new System.Drawing.Size(794, 74);
            _LabelX_MemberInfo.TabIndex = 3;
            _LabelX_MemberInfo.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // CircularProgress1
            // 
            // 
            // 
            // 
            _CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CircularProgress1.Location = new System.Drawing.Point(363, 188);
            _CircularProgress1.Name = "CircularProgress1";
            _CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            _CircularProgress1.SetVisibleStateOnStart = true;
            _CircularProgress1.SetVisibleStateOnStop = true;
            _CircularProgress1.Size = new System.Drawing.Size(75, 75);
            _CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            _CircularProgress1.TabIndex = 5;
            // 
            // ObjectCatalog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(_CircularProgress1);
            Controls.Add(_TableLayoutPanel_1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ObjectCatalog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Object Catalog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_AdvTree1).EndInit();
            _TableLayoutPanel_2.ResumeLayout(false);
            _TableLayoutPanel_1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx1;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx1 != null)
                {
                }

                _ListViewEx1 = value;
                if (_ListViewEx1 != null)
                {
                }
            }
        }

        private DevComponents.AdvTree.AdvTree _AdvTree1;

        internal DevComponents.AdvTree.AdvTree AdvTree1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AdvTree1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AdvTree1 != null)
                {
                    _AdvTree1.AfterNodeSelect -= AdvTree1_AfterNodeSelect;
                }

                _AdvTree1 = value;
                if (_AdvTree1 != null)
                {
                    _AdvTree1.AfterNodeSelect += AdvTree1_AfterNodeSelect;
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

        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel_2;

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel_2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel_2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel_2 != null)
                {
                }

                _TableLayoutPanel_2 = value;
                if (_TableLayoutPanel_2 != null)
                {
                }
            }
        }

        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel_1;

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel_1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel_1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel_1 != null)
                {
                }

                _TableLayoutPanel_1 = value;
                if (_TableLayoutPanel_1 != null)
                {
                }
            }
        }

        private System.Windows.Forms.ImageList _ImageList_RefSymbols;

        internal System.Windows.Forms.ImageList ImageList_RefSymbols
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ImageList_RefSymbols;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ImageList_RefSymbols != null)
                {
                }

                _ImageList_RefSymbols = value;
                if (_ImageList_RefSymbols != null)
                {
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

        private DevComponents.DotNetBar.LabelX _LabelX_MemberInfo;

        internal DevComponents.DotNetBar.LabelX LabelX_MemberInfo
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_MemberInfo;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_MemberInfo != null)
                {
                }

                _LabelX_MemberInfo = value;
                if (_LabelX_MemberInfo != null)
                {
                }
            }
        }
    }
}