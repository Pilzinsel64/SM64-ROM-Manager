using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LevelSelectorDialog : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelSelectorDialog));
            _Button_Cancel = new DevComponents.DotNetBar.ButtonX();
            _LabelX10 = new DevComponents.DotNetBar.LabelX();
            _Button_Add = new DevComponents.DotNetBar.ButtonX();
            _ComboBox_Level = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _Panel1 = new Panel();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Cancel
            // 
            _Button_Cancel.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_Button_Cancel, "Button_Cancel");
            _Button_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Cancel.DialogResult = DialogResult.Cancel;
            _Button_Cancel.FocusCuesEnabled = false;
            _Button_Cancel.Name = "Button_Cancel";
            _Button_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX10
            // 
            resources.ApplyResources(_LabelX10, "LabelX10");
            // 
            // 
            // 
            _LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX10.Name = "LabelX10";
            _LabelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            // 
            // Button_Add
            // 
            _Button_Add.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_Button_Add, "Button_Add");
            _Button_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_Add.DialogResult = DialogResult.OK;
            _Button_Add.FocusCuesEnabled = false;
            _Button_Add.Name = "Button_Add";
            _Button_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_Level
            // 
            resources.ApplyResources(_ComboBox_Level, "ComboBox_Level");
            _ComboBox_Level.DisplayMember = "Text";
            _ComboBox_Level.DrawMode = DrawMode.OwnerDrawFixed;
            _ComboBox_Level.DropDownHeight = 150;
            _ComboBox_Level.DropDownStyle = ComboBoxStyle.DropDownList;
            _ComboBox_Level.ForeColor = Color.Black;
            _ComboBox_Level.FormattingEnabled = true;
            _ComboBox_Level.Name = "ComboBox_Level";
            _ComboBox_Level.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_LabelX10);
            _Panel1.Controls.Add(_ComboBox_Level);
            _Panel1.Controls.Add(_Button_Cancel);
            _Panel1.Controls.Add(_Button_Add);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // LevelSelectorDialog
            // 
            AcceptButton = _Button_Add;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _Button_Cancel;
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LevelSelectorDialog";
            ShowIcon = false;
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.ButtonX _Button_Cancel;

        internal DevComponents.DotNetBar.ButtonX Button_Cancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_Cancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_Cancel != null)
                {
                }

                _Button_Cancel = value;
                if (_Button_Cancel != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX10;

        internal DevComponents.DotNetBar.LabelX LabelX10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX10 != null)
                {
                }

                _LabelX10 = value;
                if (_LabelX10 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_Add;

        internal DevComponents.DotNetBar.ButtonX Button_Add
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_Add;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_Add != null)
                {
                }

                _Button_Add = value;
                if (_Button_Add != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_Level;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_Level
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_Level;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_Level != null)
                {
                }

                _ComboBox_Level = value;
                if (_ComboBox_Level != null)
                {
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