using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    [DesignerGenerated()]
    public partial class ToolSelectionWindow : DevComponents.DotNetBar.OfficeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSelectionWindow));
            this.StyleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonX_LoadProject = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_NewProject = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.LabelX_CurProject = new DevComponents.DotNetBar.LabelX();
            this.ButtonX_Einstellungen = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_OpenUpdatePackageEditor = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX_OpenUpdateInfoManager = new DevComponents.DotNetBar.ButtonX();
            this.TableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleManager1
            // 
            this.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42))))));
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.ButtonX_Einstellungen, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX_OpenUpdatePackageEditor, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.ButtonX_OpenUpdateInfoManager, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.TableLayoutPanel1.Enabled = false;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(174, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(208, 206);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LabelX_CurProject);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.ButtonX_NewProject);
            this.panel1.Controls.Add(this.ButtonX_LoadProject);
            this.panel1.Controls.Add(this.TableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 206);
            this.panel1.TabIndex = 1;
            // 
            // ButtonX_LoadProject
            // 
            this.ButtonX_LoadProject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_LoadProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_LoadProject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_LoadProject.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_opened_folder_16px;
            this.ButtonX_LoadProject.Location = new System.Drawing.Point(3, 32);
            this.ButtonX_LoadProject.Name = "ButtonX_LoadProject";
            this.ButtonX_LoadProject.Size = new System.Drawing.Size(169, 23);
            this.ButtonX_LoadProject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_LoadProject.TabIndex = 1;
            this.ButtonX_LoadProject.Text = "Projekt laden ...";
            this.ButtonX_LoadProject.Click += new System.EventHandler(this.ButtonX_LoadProject_Click);
            // 
            // ButtonX_NewProject
            // 
            this.ButtonX_NewProject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_NewProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonX_NewProject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_NewProject.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_new_file_16px;
            this.ButtonX_NewProject.Location = new System.Drawing.Point(3, 3);
            this.ButtonX_NewProject.Name = "ButtonX_NewProject";
            this.ButtonX_NewProject.Size = new System.Drawing.Size(169, 23);
            this.ButtonX_NewProject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_NewProject.TabIndex = 1;
            this.ButtonX_NewProject.Text = "Neues Projekt erstellen ...";
            this.ButtonX_NewProject.Click += new System.EventHandler(this.ButtonX_NewProject_Click);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 61);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(169, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Aktuelles Projekt:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LabelX_CurProject
            // 
            this.LabelX_CurProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.LabelX_CurProject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX_CurProject.Location = new System.Drawing.Point(3, 90);
            this.LabelX_CurProject.Name = "LabelX_CurProject";
            this.LabelX_CurProject.Size = new System.Drawing.Size(169, 113);
            this.LabelX_CurProject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LabelX_CurProject.TabIndex = 2;
            this.LabelX_CurProject.Text = "-";
            this.LabelX_CurProject.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LabelX_CurProject.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.LabelX_CurProject.WordWrap = true;
            // 
            // ButtonX_Einstellungen
            // 
            this.ButtonX_Einstellungen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_Einstellungen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_Einstellungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonX_Einstellungen.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_support_32px_1;
            this.ButtonX_Einstellungen.Location = new System.Drawing.Point(3, 139);
            this.ButtonX_Einstellungen.Name = "ButtonX_Einstellungen";
            this.ButtonX_Einstellungen.Size = new System.Drawing.Size(202, 64);
            this.ButtonX_Einstellungen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_Einstellungen.TabIndex = 2;
            this.ButtonX_Einstellungen.Text = "Einstellungen";
            this.ButtonX_Einstellungen.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.ButtonX_Einstellungen.Click += new System.EventHandler(this.ButtonX_Einstellungen_Click);
            // 
            // ButtonX_OpenUpdatePackageEditor
            // 
            this.ButtonX_OpenUpdatePackageEditor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_OpenUpdatePackageEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_OpenUpdatePackageEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonX_OpenUpdatePackageEditor.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_open_box_32px;
            this.ButtonX_OpenUpdatePackageEditor.Location = new System.Drawing.Point(3, 71);
            this.ButtonX_OpenUpdatePackageEditor.Name = "ButtonX_OpenUpdatePackageEditor";
            this.ButtonX_OpenUpdatePackageEditor.Size = new System.Drawing.Size(202, 62);
            this.ButtonX_OpenUpdatePackageEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_OpenUpdatePackageEditor.TabIndex = 1;
            this.ButtonX_OpenUpdatePackageEditor.Text = "Paket erstellen";
            this.ButtonX_OpenUpdatePackageEditor.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.ButtonX_OpenUpdatePackageEditor.Click += new System.EventHandler(this.ButtonX_OpenUpdatePackageEditor_Click);
            // 
            // ButtonX_OpenUpdateInfoManager
            // 
            this.ButtonX_OpenUpdateInfoManager.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX_OpenUpdateInfoManager.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX_OpenUpdateInfoManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonX_OpenUpdateInfoManager.Image = global::SM64_ROM_Manager.Updating.Administration.GUI.My.Resources.Resources.icons8_administrative_tools_32px;
            this.ButtonX_OpenUpdateInfoManager.Location = new System.Drawing.Point(3, 3);
            this.ButtonX_OpenUpdateInfoManager.Name = "ButtonX_OpenUpdateInfoManager";
            this.ButtonX_OpenUpdateInfoManager.Size = new System.Drawing.Size(202, 62);
            this.ButtonX_OpenUpdateInfoManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX_OpenUpdateInfoManager.TabIndex = 0;
            this.ButtonX_OpenUpdateInfoManager.Text = "Aktuallisierungsinfo erstellen";
            this.ButtonX_OpenUpdateInfoManager.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.ButtonX_OpenUpdateInfoManager.Click += new System.EventHandler(this.ButtonX_OpenUpdateInfoManager_Click);
            // 
            // ToolSelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 206);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolSelectionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Administration";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Load += new System.EventHandler(this.ToolSelectionWindow_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DevComponents.DotNetBar.StyleManager StyleManager1;


        private TableLayoutPanel TableLayoutPanel1;


        private DevComponents.DotNetBar.ButtonX ButtonX_OpenUpdatePackageEditor;


        private DevComponents.DotNetBar.ButtonX ButtonX_OpenUpdateInfoManager;
        private DevComponents.DotNetBar.ButtonX ButtonX_Einstellungen;
        private Panel panel1;
        private DevComponents.DotNetBar.ButtonX ButtonX_NewProject;
        private DevComponents.DotNetBar.ButtonX ButtonX_LoadProject;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX LabelX_CurProject;
    }
}