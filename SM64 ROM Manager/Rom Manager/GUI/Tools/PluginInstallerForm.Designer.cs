using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class PluginInstallerForm : DevComponents.DotNetBar.OfficeForm
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
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginInstallerForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader4 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ButtonX_Remove = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_Install = new DevComponents.DotNetBar.ButtonX();
            this.ButtonItem_SingleFile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_ZipFile = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItem_Directory = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonX_Close = new DevComponents.DotNetBar.ButtonX();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.advTree1);
            this.Panel1.Controls.Add(this.ButtonX_Remove);
            this.Panel1.Controls.Add(this.ButtonX_Install);
            this.Panel1.Controls.Add(this.ButtonX_Close);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            resources.ApplyResources(this.advTree1, "advTree1");
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Columns.Add(this.columnHeader1);
            this.advTree1.Columns.Add(this.columnHeader2);
            this.advTree1.Columns.Add(this.columnHeader3);
            this.advTree1.Columns.Add(this.columnHeader4);
            this.advTree1.DragDropEnabled = false;
            this.advTree1.ExpandWidth = 0;
            this.advTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree1.MultiSelect = true;
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.advTree1_AfterNodeSelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            this.columnHeader1.Width.Absolute = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            this.columnHeader2.Width.Absolute = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            this.columnHeader3.Width.Absolute = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            this.columnHeader4.Width.Absolute = 400;
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
            // ButtonX_Remove
            // 
            this.ButtonX_Remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_Remove, "ButtonX_Remove");
            this.ButtonX_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Remove.Name = "ButtonX_Remove";
            this.ButtonX_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Remove.Click += new System.EventHandler(this.ButtonX_Remove_Click);
            // 
            // ButtonX_Install
            // 
            this.ButtonX_Install.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_Install, "ButtonX_Install");
            this.ButtonX_Install.AutoExpandOnClick = true;
            this.ButtonX_Install.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Install.Name = "ButtonX_Install";
            this.ButtonX_Install.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Install.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItem_SingleFile,
            this.ButtonItem_ZipFile,
            this.ButtonItem_Directory});
            // 
            // ButtonItem_SingleFile
            // 
            this.ButtonItem_SingleFile.GlobalItem = false;
            this.ButtonItem_SingleFile.Name = "ButtonItem_SingleFile";
            resources.ApplyResources(this.ButtonItem_SingleFile, "ButtonItem_SingleFile");
            this.ButtonItem_SingleFile.Click += new System.EventHandler(this.ButtonItem_SingleFile_Click);
            // 
            // ButtonItem_ZipFile
            // 
            this.ButtonItem_ZipFile.GlobalItem = false;
            this.ButtonItem_ZipFile.Name = "ButtonItem_ZipFile";
            resources.ApplyResources(this.ButtonItem_ZipFile, "ButtonItem_ZipFile");
            this.ButtonItem_ZipFile.Click += new System.EventHandler(this.ButtonItem_ZipFile_Click);
            // 
            // ButtonItem_Directory
            // 
            this.ButtonItem_Directory.GlobalItem = false;
            this.ButtonItem_Directory.Name = "ButtonItem_Directory";
            resources.ApplyResources(this.ButtonItem_Directory, "ButtonItem_Directory");
            this.ButtonItem_Directory.Click += new System.EventHandler(this.ButtonItem_Directory_Click);
            // 
            // ButtonX_Close
            // 
            this.ButtonX_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ButtonX_Close, "ButtonX_Close");
            this.ButtonX_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonX_Close.Name = "ButtonX_Close";
            this.ButtonX_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Close.Click += new System.EventHandler(this.ButtonX_Close_Click);
            // 
            // PluginInstallerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonX_Close;
            this.Controls.Add(this.Panel1);
            this.Name = "PluginInstallerForm";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel1;


        private DevComponents.DotNetBar.ButtonX ButtonX_Close;

        private DevComponents.DotNetBar.ButtonX ButtonX_Remove;

        private DevComponents.DotNetBar.ButtonX ButtonX_Install;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_SingleFile;

        private DevComponents.DotNetBar.ButtonItem ButtonItem_ZipFile;
        private DevComponents.DotNetBar.ButtonItem ButtonItem_Directory;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.AdvTree.ColumnHeader columnHeader3;
        private DevComponents.AdvTree.ColumnHeader columnHeader4;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}