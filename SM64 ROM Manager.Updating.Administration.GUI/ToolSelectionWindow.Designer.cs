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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSelectionWindow));
            _StyleManager1 = new DevComponents.DotNetBar.StyleManager(components);
            _TableLayoutPanel1 = new TableLayoutPanel();
            _ButtonX_OpenUpdatePackageEditor = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_OpenUpdatePackageEditor.Click += new EventHandler(ButtonX_OpenUpdatePackageEditor_Click);
            _ButtonX_OpenUpdateInfoManager = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_OpenUpdateInfoManager.Click += new EventHandler(ButtonX_OpenUpdateInfoManager_Click);
            _TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // StyleManager1
            // 
            _StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            _StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255))), Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(183)), Conversions.ToInteger(Conversions.ToByte(71)), Conversions.ToInteger(Conversions.ToByte(42))));
            // 
            // TableLayoutPanel1
            // 
            _TableLayoutPanel1.ColumnCount = 1;
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            _TableLayoutPanel1.Controls.Add(_ButtonX_OpenUpdatePackageEditor, 0, 1);
            _TableLayoutPanel1.Controls.Add(_ButtonX_OpenUpdateInfoManager, 0, 0);
            _TableLayoutPanel1.Dock = DockStyle.Fill;
            _TableLayoutPanel1.Location = new Point(0, 0);
            _TableLayoutPanel1.Name = "TableLayoutPanel1";
            _TableLayoutPanel1.RowCount = 2;
            _TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0F));
            _TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0F));
            _TableLayoutPanel1.Size = new Size(208, 143);
            _TableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonX_OpenUpdatePackageEditor
            // 
            _ButtonX_OpenUpdatePackageEditor.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_OpenUpdatePackageEditor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_OpenUpdatePackageEditor.Dock = DockStyle.Fill;
            _ButtonX_OpenUpdatePackageEditor.Image = My.Resources.Resources.icons8_open_box_32px;
            _ButtonX_OpenUpdatePackageEditor.Location = new Point(3, 74);
            _ButtonX_OpenUpdatePackageEditor.Name = "ButtonX_OpenUpdatePackageEditor";
            _ButtonX_OpenUpdatePackageEditor.Size = new Size(202, 66);
            _ButtonX_OpenUpdatePackageEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_OpenUpdatePackageEditor.TabIndex = 1;
            _ButtonX_OpenUpdatePackageEditor.Text = "Paket erstellen";
            _ButtonX_OpenUpdatePackageEditor.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // ButtonX_OpenUpdateInfoManager
            // 
            _ButtonX_OpenUpdateInfoManager.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_OpenUpdateInfoManager.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_OpenUpdateInfoManager.Dock = DockStyle.Fill;
            _ButtonX_OpenUpdateInfoManager.Image = My.Resources.Resources.icons8_administrative_tools_32px;
            _ButtonX_OpenUpdateInfoManager.Location = new Point(3, 3);
            _ButtonX_OpenUpdateInfoManager.Name = "ButtonX_OpenUpdateInfoManager";
            _ButtonX_OpenUpdateInfoManager.Size = new Size(202, 65);
            _ButtonX_OpenUpdateInfoManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_OpenUpdateInfoManager.TabIndex = 0;
            _ButtonX_OpenUpdateInfoManager.Text = "Aktuallisierungsinfo erstellen";
            _ButtonX_OpenUpdateInfoManager.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // ToolSelectionWindow
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 143);
            Controls.Add(_TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ToolSelectionWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Administration";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.StyleManager _StyleManager1;

        internal DevComponents.DotNetBar.StyleManager StyleManager1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StyleManager1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StyleManager1 != null)
                {
                }

                _StyleManager1 = value;
                if (_StyleManager1 != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel1;

        internal TableLayoutPanel TableLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel1 != null)
                {
                }

                _TableLayoutPanel1 = value;
                if (_TableLayoutPanel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_OpenUpdatePackageEditor;

        internal DevComponents.DotNetBar.ButtonX ButtonX_OpenUpdatePackageEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_OpenUpdatePackageEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_OpenUpdatePackageEditor != null)
                {
                    _ButtonX_OpenUpdatePackageEditor.Click -= ButtonX_OpenUpdatePackageEditor_Click;
                }

                _ButtonX_OpenUpdatePackageEditor = value;
                if (_ButtonX_OpenUpdatePackageEditor != null)
                {
                    _ButtonX_OpenUpdatePackageEditor.Click += ButtonX_OpenUpdatePackageEditor_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_OpenUpdateInfoManager;

        internal DevComponents.DotNetBar.ButtonX ButtonX_OpenUpdateInfoManager
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_OpenUpdateInfoManager;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_OpenUpdateInfoManager != null)
                {
                    _ButtonX_OpenUpdateInfoManager.Click -= ButtonX_OpenUpdateInfoManager_Click;
                }

                _ButtonX_OpenUpdateInfoManager = value;
                if (_ButtonX_OpenUpdateInfoManager != null)
                {
                    _ButtonX_OpenUpdateInfoManager.Click += ButtonX_OpenUpdateInfoManager_Click;
                }
            }
        }
    }
}