using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TextProfilesManagerDialog : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TextProfilesManagerDialog));
            _Panel1 = new Panel();
            _TextBoxX_ProfileName = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ProfileName.TextChanged += new EventHandler(TextBoxX_ProfileName_TextChanged);
            _ButtonX_Delete = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Delete.Click += new EventHandler(ButtonX_Delete_Click);
            _ButtonX_Export = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Export.Click += new EventHandler(ButtonX_Export_Click);
            _ButtonX_Import = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Import.Click += new EventHandler(ButtonX_Import_Click);
            _ButtonX_Edit = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Edit.Click += new EventHandler(ButtonX_Edit_Click);
            _ButtonX_Create = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Create.Click += new EventHandler(ButtonX_Create_Click);
            _ItemPanel_Profiles = new DevComponents.DotNetBar.ItemPanel();
            _ItemPanel_Profiles.SelectedIndexChanged += new EventHandler(ItemPanel_Profiles_SelectedIndexChanged);
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_TextBoxX_ProfileName);
            _Panel1.Controls.Add(_ButtonX_Delete);
            _Panel1.Controls.Add(_ButtonX_Export);
            _Panel1.Controls.Add(_ButtonX_Import);
            _Panel1.Controls.Add(_ButtonX_Edit);
            _Panel1.Controls.Add(_ButtonX_Create);
            _Panel1.Controls.Add(_ItemPanel_Profiles);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // TextBoxX_ProfileName
            // 
            resources.ApplyResources(_TextBoxX_ProfileName, "TextBoxX_ProfileName");
            _TextBoxX_ProfileName.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_ProfileName.Border.Class = "TextBoxBorder";
            _TextBoxX_ProfileName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ProfileName.DisabledBackColor = Color.White;
            _TextBoxX_ProfileName.ForeColor = Color.Black;
            _TextBoxX_ProfileName.Name = "TextBoxX_ProfileName";
            _TextBoxX_ProfileName.PreventEnterBeep = true;
            _TextBoxX_ProfileName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            // 
            // ButtonX_Delete
            // 
            _ButtonX_Delete.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Delete.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            resources.ApplyResources(_ButtonX_Delete, "ButtonX_Delete");
            _ButtonX_Delete.Name = "ButtonX_Delete";
            _ButtonX_Delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Export
            // 
            _ButtonX_Export.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Export.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Export.Image = My.Resources.MyIcons.icons8_export_16px;
            resources.ApplyResources(_ButtonX_Export, "ButtonX_Export");
            _ButtonX_Export.Name = "ButtonX_Export";
            _ButtonX_Export.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Import
            // 
            _ButtonX_Import.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Import.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Import.Image = My.Resources.MyIcons.icons8_import_16px;
            resources.ApplyResources(_ButtonX_Import, "ButtonX_Import");
            _ButtonX_Import.Name = "ButtonX_Import";
            _ButtonX_Import.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Edit
            // 
            _ButtonX_Edit.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Edit.Image = My.Resources.MyIcons.icons8_edit_16px;
            resources.ApplyResources(_ButtonX_Edit, "ButtonX_Edit");
            _ButtonX_Edit.Name = "ButtonX_Edit";
            _ButtonX_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Create
            // 
            _ButtonX_Create.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Create.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Create.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(_ButtonX_Create, "ButtonX_Create");
            _ButtonX_Create.Name = "ButtonX_Create";
            _ButtonX_Create.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ItemPanel_Profiles
            // 
            resources.ApplyResources(_ItemPanel_Profiles, "ItemPanel_Profiles");
            // 
            // 
            // 
            _ItemPanel_Profiles.BackgroundStyle.Class = "ItemPanel";
            _ItemPanel_Profiles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemPanel_Profiles.ContainerControlProcessDialogKey = true;
            _ItemPanel_Profiles.DragDropSupport = true;
            _ItemPanel_Profiles.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemPanel_Profiles.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemPanel_Profiles.Name = "ItemPanel_Profiles";
            _ItemPanel_Profiles.ReserveLeftSpace = false;
            _ItemPanel_Profiles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TextProfilesManagerDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_Panel1);
            MaximizeBox = false;
            Name = "TextProfilesManagerDialog";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
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

        private DevComponents.DotNetBar.ButtonX _ButtonX_Delete;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Delete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Delete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Delete != null)
                {
                    _ButtonX_Delete.Click -= ButtonX_Delete_Click;
                }

                _ButtonX_Delete = value;
                if (_ButtonX_Delete != null)
                {
                    _ButtonX_Delete.Click += ButtonX_Delete_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Edit;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Edit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Edit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Edit != null)
                {
                    _ButtonX_Edit.Click -= ButtonX_Edit_Click;
                }

                _ButtonX_Edit = value;
                if (_ButtonX_Edit != null)
                {
                    _ButtonX_Edit.Click += ButtonX_Edit_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Create;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Create
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Create;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Create != null)
                {
                    _ButtonX_Create.Click -= ButtonX_Create_Click;
                }

                _ButtonX_Create = value;
                if (_ButtonX_Create != null)
                {
                    _ButtonX_Create.Click += ButtonX_Create_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ItemPanel _ItemPanel_Profiles;

        internal DevComponents.DotNetBar.ItemPanel ItemPanel_Profiles
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemPanel_Profiles;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemPanel_Profiles != null)
                {
                    _ItemPanel_Profiles.SelectedIndexChanged -= ItemPanel_Profiles_SelectedIndexChanged;
                }

                _ItemPanel_Profiles = value;
                if (_ItemPanel_Profiles != null)
                {
                    _ItemPanel_Profiles.SelectedIndexChanged += ItemPanel_Profiles_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ProfileName;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ProfileName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ProfileName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ProfileName != null)
                {
                    _TextBoxX_ProfileName.TextChanged -= TextBoxX_ProfileName_TextChanged;
                }

                _TextBoxX_ProfileName = value;
                if (_TextBoxX_ProfileName != null)
                {
                    _TextBoxX_ProfileName.TextChanged += TextBoxX_ProfileName_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Export;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Export
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Export;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Export != null)
                {
                    _ButtonX_Export.Click -= ButtonX_Export_Click;
                }

                _ButtonX_Export = value;
                if (_ButtonX_Export != null)
                {
                    _ButtonX_Export.Click += ButtonX_Export_Click;
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
    }
}