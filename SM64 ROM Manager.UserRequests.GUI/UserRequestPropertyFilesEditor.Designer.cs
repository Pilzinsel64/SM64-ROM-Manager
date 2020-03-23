using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager.UserRequests.GUI
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserRequestPropertyFilesEditor : UserControl
    {

        // UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRequestPropertyFilesEditor));
            _ItemPanel_Files = new DevComponents.DotNetBar.ItemPanel();
            _ItemPanel_Files.SelectedIndexChanged += new EventHandler(ItemPanel_Files_SelectedIndexChanged);
            _Panel1 = new Panel();
            _ButtonX_Remove = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Remove.Click += new EventHandler(ButtonX_Remove_Click);
            _ButtonX_Add = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Add.Click += new EventHandler(ButtonX_Add_Click);
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemPanel_Files
            // 
            resources.ApplyResources(_ItemPanel_Files, "ItemPanel_Files");
            // 
            // 
            // 
            _ItemPanel_Files.BackgroundStyle.Class = "ItemPanel";
            _ItemPanel_Files.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemPanel_Files.ContainerControlProcessDialogKey = true;
            _ItemPanel_Files.DragDropSupport = true;
            _ItemPanel_Files.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemPanel_Files.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemPanel_Files.Name = "ItemPanel_Files";
            _ItemPanel_Files.ReserveLeftSpace = false;
            _ItemPanel_Files.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ButtonX_Remove);
            _Panel1.Controls.Add(_ButtonX_Add);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // ButtonX_Remove
            // 
            _ButtonX_Remove.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_Remove, "ButtonX_Remove");
            _ButtonX_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Remove.Image = My.Resources.Resources.icons8_delete_16px;
            _ButtonX_Remove.Name = "ButtonX_Remove";
            _ButtonX_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Add
            // 
            _ButtonX_Add.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Add.Image = My.Resources.Resources.icons8_plus_math_16px;
            resources.ApplyResources(_ButtonX_Add, "ButtonX_Add");
            _ButtonX_Add.Name = "ButtonX_Add";
            _ButtonX_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // UserRequestPropertyFilesEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_ItemPanel_Files);
            Controls.Add(_Panel1);
            Name = "UserRequestPropertyFilesEditor";
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.ItemPanel _ItemPanel_Files;

        internal DevComponents.DotNetBar.ItemPanel ItemPanel_Files
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemPanel_Files;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemPanel_Files != null)
                {
                    _ItemPanel_Files.SelectedIndexChanged -= ItemPanel_Files_SelectedIndexChanged;
                }

                _ItemPanel_Files = value;
                if (_ItemPanel_Files != null)
                {
                    _ItemPanel_Files.SelectedIndexChanged += ItemPanel_Files_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Add;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Add
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Add;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Add != null)
                {
                    _ButtonX_Add.Click -= ButtonX_Add_Click;
                }

                _ButtonX_Add = value;
                if (_ButtonX_Add != null)
                {
                    _ButtonX_Add.Click += ButtonX_Add_Click;
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

        private DevComponents.DotNetBar.ButtonX _ButtonX_Remove;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Remove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Remove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Remove != null)
                {
                    _ButtonX_Remove.Click -= ButtonX_Remove_Click;
                }

                _ButtonX_Remove = value;
                if (_ButtonX_Remove != null)
                {
                    _ButtonX_Remove.Click += ButtonX_Remove_Click;
                }
            }
        }
    }
}