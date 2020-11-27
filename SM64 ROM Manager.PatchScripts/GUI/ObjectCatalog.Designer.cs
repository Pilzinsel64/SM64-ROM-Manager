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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectCatalog));
            this.ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.AdvTree1 = new DevComponents.AdvTree.AdvTree();
            this.ImageList_RefSymbols = new System.Windows.Forms.ImageList(this.components);
            this.Node1 = new DevComponents.AdvTree.Node();
            this.NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.TableLayoutPanel_2 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel_1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelX_MemberInfo = new DevComponents.DotNetBar.LabelX();
            this.CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonX_Select = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Cancel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).BeginInit();
            this.TableLayoutPanel_2.SuspendLayout();
            this.TableLayoutPanel_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewEx1
            // 
            this.ListViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ListViewEx1.Border.Class = "ListViewBorder";
            this.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.ListViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewEx1.ForeColor = System.Drawing.Color.Black;
            this.ListViewEx1.HideSelection = false;
            this.ListViewEx1.Location = new System.Drawing.Point(400, 3);
            this.ListViewEx1.Name = "ListViewEx1";
            this.ListViewEx1.Size = new System.Drawing.Size(391, 329);
            this.ListViewEx1.TabIndex = 0;
            this.ListViewEx1.UseCompatibleStateImageBehavior = false;
            // 
            // AdvTree1
            // 
            this.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvTree1.DragDropEnabled = false;
            this.AdvTree1.DragDropNodeCopyEnabled = false;
            this.AdvTree1.ImageList = this.ImageList_RefSymbols;
            this.AdvTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.AdvTree1.Location = new System.Drawing.Point(3, 3);
            this.AdvTree1.Name = "AdvTree1";
            this.AdvTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.Node1});
            this.AdvTree1.NodesConnector = this.NodeConnector1;
            this.AdvTree1.NodeStyle = this.ElementStyle1;
            this.AdvTree1.PathSeparator = ";";
            this.AdvTree1.Size = new System.Drawing.Size(391, 329);
            this.AdvTree1.Styles.Add(this.ElementStyle1);
            this.AdvTree1.TabIndex = 1;
            this.AdvTree1.Text = "AdvTree1";
            this.AdvTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.AdvTree1_AfterNodeSelect);
            // 
            // ImageList_RefSymbols
            // 
            this.ImageList_RefSymbols.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList_RefSymbols.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList_RefSymbols.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Node1
            // 
            this.Node1.Expanded = true;
            this.Node1.Name = "Node1";
            this.Node1.Text = "Node1";
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
            // TableLayoutPanel_2
            // 
            this.TableLayoutPanel_2.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel_2.ColumnCount = 2;
            this.TableLayoutPanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_2.Controls.Add(this.AdvTree1, 0, 0);
            this.TableLayoutPanel_2.Controls.Add(this.ListViewEx1, 1, 0);
            this.TableLayoutPanel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_2.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel_2.Name = "TableLayoutPanel_2";
            this.TableLayoutPanel_2.RowCount = 1;
            this.TableLayoutPanel_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_2.Size = new System.Drawing.Size(794, 335);
            this.TableLayoutPanel_2.TabIndex = 2;
            // 
            // TableLayoutPanel_1
            // 
            this.TableLayoutPanel_1.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel_1.ColumnCount = 1;
            this.TableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_1.Controls.Add(this.TableLayoutPanel_2, 0, 0);
            this.TableLayoutPanel_1.Controls.Add(this.LabelX_MemberInfo, 0, 1);
            this.TableLayoutPanel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel_1.Name = "TableLayoutPanel_1";
            this.TableLayoutPanel_1.RowCount = 2;
            this.TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TableLayoutPanel_1.Size = new System.Drawing.Size(800, 421);
            this.TableLayoutPanel_1.TabIndex = 3;
            this.TableLayoutPanel_1.Visible = false;
            // 
            // LabelX_MemberInfo
            // 
            // 
            // 
            // 
            this.LabelX_MemberInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_MemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelX_MemberInfo.Location = new System.Drawing.Point(3, 344);
            this.LabelX_MemberInfo.Name = "LabelX_MemberInfo";
            this.LabelX_MemberInfo.Size = new System.Drawing.Size(794, 74);
            this.LabelX_MemberInfo.TabIndex = 3;
            this.LabelX_MemberInfo.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // CircularProgress1
            // 
            // 
            // 
            // 
            this.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CircularProgress1.Location = new System.Drawing.Point(363, 188);
            this.CircularProgress1.Name = "CircularProgress1";
            this.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.CircularProgress1.SetVisibleStateOnStart = true;
            this.CircularProgress1.SetVisibleStateOnStop = true;
            this.CircularProgress1.Size = new System.Drawing.Size(75, 75);
            this.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.CircularProgress1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonX_Cancel);
            this.panel1.Controls.Add(this.buttonX_Select);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 6;
            // 
            // buttonX_Select
            // 
            this.buttonX_Select.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Select.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonX_Select.Enabled = false;
            this.buttonX_Select.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_checkmark_16px;
            this.buttonX_Select.Location = new System.Drawing.Point(722, 3);
            this.buttonX_Select.Name = "buttonX_Select";
            this.buttonX_Select.Size = new System.Drawing.Size(75, 23);
            this.buttonX_Select.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Select.TabIndex = 0;
            this.buttonX_Select.Text = "Select";
            // 
            // buttonX_Cancel
            // 
            this.buttonX_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX_Cancel.Image = global::SM64_ROM_Manager.PatchScripts.MyIcons.icons8_delete_sign_16px_1;
            this.buttonX_Cancel.Location = new System.Drawing.Point(641, 3);
            this.buttonX_Cancel.Name = "buttonX_Cancel";
            this.buttonX_Cancel.Size = new System.Drawing.Size(75, 23);
            this.buttonX_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Cancel.TabIndex = 0;
            this.buttonX_Cancel.Text = "Cancel";
            // 
            // ObjectCatalog
            // 
            this.AcceptButton = this.buttonX_Select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonX_Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CircularProgress1);
            this.Controls.Add(this.TableLayoutPanel_1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObjectCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object Catalog";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree1)).EndInit();
            this.TableLayoutPanel_2.ResumeLayout(false);
            this.TableLayoutPanel_1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1;

        private DevComponents.AdvTree.AdvTree AdvTree1;

        private DevComponents.AdvTree.Node Node1;

        private DevComponents.AdvTree.NodeConnector NodeConnector1;

        private DevComponents.DotNetBar.ElementStyle ElementStyle1;

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_2;

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_1;

        private System.Windows.Forms.ImageList ImageList_RefSymbols;

        private DevComponents.DotNetBar.Controls.CircularProgress CircularProgress1;

        private DevComponents.DotNetBar.LabelX LabelX_MemberInfo;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX buttonX_Cancel;
        private DevComponents.DotNetBar.ButtonX buttonX_Select;
    }
}