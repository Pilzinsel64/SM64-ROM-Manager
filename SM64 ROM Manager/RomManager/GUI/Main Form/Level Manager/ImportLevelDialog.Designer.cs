using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class ImportLevelDialog : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportLevelDialog));
            _ButtonX_Import = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Import.Click += new EventHandler(ButtonX_Import_Click);
            _LabelX_Romfile = new DevComponents.DotNetBar.LabelX();
            _ItemListBox_Levels = new Publics.Controls.ItemListBox();
            _ItemListBox_Levels.SelectedIndexChanged += new EventHandler(ItemListBox1_SelectedIndexChanged);
            _ItemListBox_Levels.SelectedIndexChanged += new EventHandler(ItemListBox_Levels_SelectedIndexChanged);
            _TableLayoutPanel1 = new TableLayoutPanel();
            _ItemPanel_Areas = new DevComponents.DotNetBar.ItemPanel();
            _CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            _ItemListBox_Levels.SuspendLayout();
            _TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonX_Import
            // 
            _ButtonX_Import.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Import.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Import.Dock = DockStyle.Fill;
            _ButtonX_Import.Enabled = false;
            _ButtonX_Import.FocusCuesEnabled = false;
            _ButtonX_Import.Location = new Point(271, 3);
            _ButtonX_Import.Name = "ButtonX_Import";
            _ButtonX_Import.Size = new Size(110, 23);
            _ButtonX_Import.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Import.TabIndex = 2;
            _ButtonX_Import.Text = "Import";
            // 
            // LabelX_Romfile
            // 
            // 
            // 
            // 
            _LabelX_Romfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Romfile.Dock = DockStyle.Fill;
            _LabelX_Romfile.Location = new Point(3, 3);
            _LabelX_Romfile.Name = "LabelX_Romfile";
            _LabelX_Romfile.Size = new Size(262, 23);
            _LabelX_Romfile.TabIndex = 3;
            _LabelX_Romfile.Text = "Please open a ROM file!";
            // 
            // ItemListBox_Levels
            // 
            _ItemListBox_Levels.AutoScroll = true;
            // 
            // 
            // 
            _ItemListBox_Levels.BackgroundStyle.Class = "ItemPanel";
            _ItemListBox_Levels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemListBox_Levels.ContainerControlProcessDialogKey = true;
            _ItemListBox_Levels.Controls.Add(_CircularProgress1);
            _ItemListBox_Levels.Dock = DockStyle.Fill;
            _ItemListBox_Levels.DragDropSupport = true;
            _ItemListBox_Levels.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemListBox_Levels.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemListBox_Levels.Location = new Point(3, 32);
            _ItemListBox_Levels.Name = "ItemListBox_Levels";
            _ItemListBox_Levels.ReserveLeftSpace = false;
            _ItemListBox_Levels.Size = new Size(262, 226);
            _ItemListBox_Levels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ItemListBox_Levels.TabIndex = 1;
            _ItemListBox_Levels.Text = "ItemListBox1";
            // 
            // TableLayoutPanel1
            // 
            _TableLayoutPanel1.BackColor = Color.Transparent;
            _TableLayoutPanel1.ColumnCount = 2;
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.0F));
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0F));
            _TableLayoutPanel1.Controls.Add(_ButtonX_Import, 1, 0);
            _TableLayoutPanel1.Controls.Add(_LabelX_Romfile, 0, 0);
            _TableLayoutPanel1.Controls.Add(_ItemListBox_Levels, 0, 1);
            _TableLayoutPanel1.Controls.Add(_ItemPanel_Areas, 1, 1);
            _TableLayoutPanel1.Dock = DockStyle.Fill;
            _TableLayoutPanel1.Location = new Point(0, 0);
            _TableLayoutPanel1.Name = "TableLayoutPanel1";
            _TableLayoutPanel1.RowCount = 2;
            _TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29.0F));
            _TableLayoutPanel1.RowStyles.Add(new RowStyle());
            _TableLayoutPanel1.Size = new Size(384, 261);
            _TableLayoutPanel1.TabIndex = 4;
            // 
            // ItemPanel_Areas
            // 
            _ItemPanel_Areas.AutoScroll = true;
            // 
            // 
            // 
            _ItemPanel_Areas.BackgroundStyle.Class = "ItemPanel";
            _ItemPanel_Areas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemPanel_Areas.ContainerControlProcessDialogKey = true;
            _ItemPanel_Areas.Dock = DockStyle.Fill;
            _ItemPanel_Areas.DragDropSupport = true;
            _ItemPanel_Areas.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemPanel_Areas.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemPanel_Areas.Location = new Point(271, 32);
            _ItemPanel_Areas.Name = "ItemPanel_Areas";
            _ItemPanel_Areas.ReserveLeftSpace = false;
            _ItemPanel_Areas.Size = new Size(110, 226);
            _ItemPanel_Areas.TabIndex = 4;
            _ItemPanel_Areas.Text = "ItemPanel1";
            // 
            // CircularProgress1
            // 
            _CircularProgress1.Anchor = AnchorStyles.None;
            _CircularProgress1.BackColor = Color.Transparent;
            // 
            // 
            // 
            _CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CircularProgress1.Location = new Point(94, 76);
            _CircularProgress1.Name = "CircularProgress1";
            _CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            _CircularProgress1.SetVisibleStateOnStart = true;
            _CircularProgress1.SetVisibleStateOnStop = true;
            _CircularProgress1.Size = new Size(75, 75);
            _CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            _CircularProgress1.TabIndex = 9;
            // 
            // ImportLevelDialog
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(_TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ImportLevelDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Import Levels";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _ItemListBox_Levels.ResumeLayout(false);
            _TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Publics.Controls.ItemListBox _ItemListBox_Levels;

        internal Publics.Controls.ItemListBox ItemListBox_Levels
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemListBox_Levels;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemListBox_Levels != null)
                {
                    _ItemListBox_Levels.SelectedIndexChanged -= ItemListBox1_SelectedIndexChanged;
                    _ItemListBox_Levels.SelectedIndexChanged -= ItemListBox_Levels_SelectedIndexChanged;
                }

                _ItemListBox_Levels = value;
                if (_ItemListBox_Levels != null)
                {
                    _ItemListBox_Levels.SelectedIndexChanged += ItemListBox1_SelectedIndexChanged;
                    _ItemListBox_Levels.SelectedIndexChanged += ItemListBox_Levels_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Import;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Import
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Import;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Import != null)
                {
                    _ButtonX_Import.Click -= ButtonX_Import_Click;
                }

                _ButtonX_Import = value;
                if (_ButtonX_Import != null)
                {
                    _ButtonX_Import.Click += ButtonX_Import_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Romfile;

        internal DevComponents.DotNetBar.LabelX LabelX_Romfile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Romfile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Romfile != null)
                {
                }

                _LabelX_Romfile = value;
                if (_LabelX_Romfile != null)
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

        private DevComponents.DotNetBar.ItemPanel _ItemPanel_Areas;

        internal DevComponents.DotNetBar.ItemPanel ItemPanel_Areas
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemPanel_Areas;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemPanel_Areas != null)
                {
                }

                _ItemPanel_Areas = value;
                if (_ItemPanel_Areas != null)
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
    }
}