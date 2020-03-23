using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_Stylemanager : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Stylemanager));
            _ComboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx1.SelectedIndexChanged += new EventHandler(ComboBoxEx1_SelectedIndexChanged);
            _CheckBoxX_KeepEditorControlBarBlue = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_KeepEditorControlBarBlue.CheckedChanged += new EventHandler(CheckBoxX_KeepEditorControlBarBlue_CheckedChanged);
            _CheckBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX1.CheckedChanged += new EventHandler(ComboBoxEx1_SelectedIndexChanged);
            _CheckBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX2.CheckedChanged += new EventHandler(CheckBoxX2_CheckedChanged);
            _Panel1 = new Panel();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxEx1
            // 
            _ComboBoxEx1.DisplayMember = "Text";
            _ComboBoxEx1.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBoxEx1.DropDownHeight = 150;
            _ComboBoxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(_ComboBoxEx1, "ComboBoxEx1");
            _ComboBoxEx1.ForeColor = Color.Black;
            _ComboBoxEx1.FormattingEnabled = true;
            _ComboBoxEx1.Name = "ComboBoxEx1";
            _ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_KeepEditorControlBarBlue
            // 
            // 
            // 
            // 
            _CheckBoxX_KeepEditorControlBarBlue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_KeepEditorControlBarBlue.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX_KeepEditorControlBarBlue, "CheckBoxX_KeepEditorControlBarBlue");
            _CheckBoxX_KeepEditorControlBarBlue.Name = "CheckBoxX_KeepEditorControlBarBlue";
            _CheckBoxX_KeepEditorControlBarBlue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX1
            // 
            // 
            // 
            // 
            _CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX1.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX1, "CheckBoxX1");
            _CheckBoxX1.Name = "CheckBoxX1";
            _CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX2
            // 
            // 
            // 
            // 
            _CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            _CheckBoxX2.FocusCuesEnabled = false;
            resources.ApplyResources(_CheckBoxX2, "CheckBoxX2");
            _CheckBoxX2.Name = "CheckBoxX2";
            _CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_CheckBoxX1);
            _Panel1.Controls.Add(_CheckBoxX2);
            _Panel1.Controls.Add(_ComboBoxEx1);
            _Panel1.Controls.Add(_CheckBoxX_KeepEditorControlBarBlue);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // Form_Stylemanager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BottomLeftCornerSize = 0;
            BottomRightCornerSize = 0;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Stylemanager";
            ShowInTaskbar = false;
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx1;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx1 != null)
                {
                    _ComboBoxEx1.SelectedIndexChanged -= ComboBoxEx1_SelectedIndexChanged;
                }

                _ComboBoxEx1 = value;
                if (_ComboBoxEx1 != null)
                {
                    _ComboBoxEx1.SelectedIndexChanged += ComboBoxEx1_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_KeepEditorControlBarBlue;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_KeepEditorControlBarBlue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_KeepEditorControlBarBlue;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_KeepEditorControlBarBlue != null)
                {
                    _CheckBoxX_KeepEditorControlBarBlue.CheckedChanged -= CheckBoxX_KeepEditorControlBarBlue_CheckedChanged;
                }

                _CheckBoxX_KeepEditorControlBarBlue = value;
                if (_CheckBoxX_KeepEditorControlBarBlue != null)
                {
                    _CheckBoxX_KeepEditorControlBarBlue.CheckedChanged += CheckBoxX_KeepEditorControlBarBlue_CheckedChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX1;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX1 != null)
                {
                    _CheckBoxX1.CheckedChanged -= ComboBoxEx1_SelectedIndexChanged;
                }

                _CheckBoxX1 = value;
                if (_CheckBoxX1 != null)
                {
                    _CheckBoxX1.CheckedChanged += ComboBoxEx1_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX2;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX2 != null)
                {
                    _CheckBoxX2.CheckedChanged -= CheckBoxX2_CheckedChanged;
                }

                _CheckBoxX2 = value;
                if (_CheckBoxX2 != null)
                {
                    _CheckBoxX2.CheckedChanged += CheckBoxX2_CheckedChanged;
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
    }
}