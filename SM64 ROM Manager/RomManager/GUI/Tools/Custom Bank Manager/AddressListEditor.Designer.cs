using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddressListEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressListEditor));
            _ItemPanel_Values = new DevComponents.DotNetBar.ItemPanel();
            _ItemPanel_Values.SelectedIndexChanged += new EventHandler(ItemPanel_Values_SelectedIndexChanged);
            _LayoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            _TextBoxX_Value = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_Value.TextChanged += new EventHandler(TextBoxX_Value_TextChanged);
            _ButtonX_Hinzufügen = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Hinzufügen.Click += new EventHandler(ButtonX_Hinzufügen_Click);
            _ButtonX_Entfernen = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Entfernen.Click += new EventHandler(ButtonX_Entfernen_Click);
            _LayoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            _LayoutControl1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemPanel_Values
            // 
            resources.ApplyResources(_ItemPanel_Values, "ItemPanel_Values");
            _ItemPanel_Values.BackColor = Color.Transparent;
            // 
            // 
            // 
            _ItemPanel_Values.BackgroundStyle.Class = "ItemPanel";
            _ItemPanel_Values.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemPanel_Values.ContainerControlProcessDialogKey = true;
            _ItemPanel_Values.DragDropSupport = true;
            _ItemPanel_Values.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemPanel_Values.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemPanel_Values.Name = "ItemPanel_Values";
            _ItemPanel_Values.ReserveLeftSpace = false;
            _ItemPanel_Values.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControl1
            // 
            _LayoutControl1.BackColor = Color.Transparent;
            _LayoutControl1.Controls.Add(_TextBoxX_Value);
            _LayoutControl1.Controls.Add(_ButtonX_Hinzufügen);
            _LayoutControl1.Controls.Add(_ButtonX_Entfernen);
            resources.ApplyResources(_LayoutControl1, "LayoutControl1");
            _LayoutControl1.ForeColor = Color.Black;
            _LayoutControl1.Name = "LayoutControl1";
            // 
            // 
            // 
            _LayoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] { _LayoutControlItem1, _LayoutControlItem2, _LayoutControlItem3 });
            // 
            // TextBoxX_Value
            // 
            _TextBoxX_Value.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_Value.Border.Class = "TextBoxBorder";
            _TextBoxX_Value.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_Value.DisabledBackColor = Color.White;
            _TextBoxX_Value.ForeColor = Color.Black;
            resources.ApplyResources(_TextBoxX_Value, "TextBoxX_Value");
            _TextBoxX_Value.Name = "TextBoxX_Value";
            _TextBoxX_Value.PreventEnterBeep = true;
            // 
            // ButtonX_Hinzufügen
            // 
            _ButtonX_Hinzufügen.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Hinzufügen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Hinzufügen.Image = My.Resources.MyIcons.icons8_plus_math_16px;
            resources.ApplyResources(_ButtonX_Hinzufügen, "ButtonX_Hinzufügen");
            _ButtonX_Hinzufügen.Name = "ButtonX_Hinzufügen";
            _ButtonX_Hinzufügen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Entfernen
            // 
            _ButtonX_Entfernen.AccessibleRole = AccessibleRole.PushButton;
            _ButtonX_Entfernen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Entfernen.Image = My.Resources.MyIcons.icons8_delete_sign_16px;
            resources.ApplyResources(_ButtonX_Entfernen, "ButtonX_Entfernen");
            _ButtonX_Entfernen.Name = "ButtonX_Entfernen";
            _ButtonX_Entfernen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LayoutControlItem1
            // 
            _LayoutControlItem1.Control = _TextBoxX_Value;
            _LayoutControlItem1.Height = 28;
            _LayoutControlItem1.MinSize = new Size(120, 0);
            _LayoutControlItem1.Name = "LayoutControlItem1";
            _LayoutControlItem1.Width = 100;
            _LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem2
            // 
            _LayoutControlItem2.Control = _ButtonX_Hinzufügen;
            _LayoutControlItem2.Height = 31;
            _LayoutControlItem2.MinSize = new Size(32, 20);
            _LayoutControlItem2.Name = "LayoutControlItem2";
            _LayoutControlItem2.Width = 50;
            _LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // LayoutControlItem3
            // 
            _LayoutControlItem3.Control = _ButtonX_Entfernen;
            _LayoutControlItem3.Height = 31;
            _LayoutControlItem3.MinSize = new Size(32, 20);
            _LayoutControlItem3.Name = "LayoutControlItem3";
            _LayoutControlItem3.Width = 50;
            _LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // AddressListEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_ItemPanel_Values);
            Controls.Add(_LayoutControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddressListEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _LayoutControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.ItemPanel _ItemPanel_Values;

        internal DevComponents.DotNetBar.ItemPanel ItemPanel_Values
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemPanel_Values;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemPanel_Values != null)
                {
                    _ItemPanel_Values.SelectedIndexChanged -= ItemPanel_Values_SelectedIndexChanged;
                }

                _ItemPanel_Values = value;
                if (_ItemPanel_Values != null)
                {
                    _ItemPanel_Values.SelectedIndexChanged += ItemPanel_Values_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControl _LayoutControl1;

        internal DevComponents.DotNetBar.Layout.LayoutControl LayoutControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControl1 != null)
                {
                }

                _LayoutControl1 = value;
                if (_LayoutControl1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_Value;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_Value
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_Value;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_Value != null)
                {
                    _TextBoxX_Value.TextChanged -= TextBoxX_Value_TextChanged;
                }

                _TextBoxX_Value = value;
                if (_TextBoxX_Value != null)
                {
                    _TextBoxX_Value.TextChanged += TextBoxX_Value_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Hinzufügen;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Hinzufügen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Hinzufügen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Hinzufügen != null)
                {
                    _ButtonX_Hinzufügen.Click -= ButtonX_Hinzufügen_Click;
                }

                _ButtonX_Hinzufügen = value;
                if (_ButtonX_Hinzufügen != null)
                {
                    _ButtonX_Hinzufügen.Click += ButtonX_Hinzufügen_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Entfernen;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Entfernen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Entfernen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Entfernen != null)
                {
                    _ButtonX_Entfernen.Click -= ButtonX_Entfernen_Click;
                }

                _ButtonX_Entfernen = value;
                if (_ButtonX_Entfernen != null)
                {
                    _ButtonX_Entfernen.Click += ButtonX_Entfernen_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem1;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem1 != null)
                {
                }

                _LayoutControlItem1 = value;
                if (_LayoutControlItem1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem2;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem2 != null)
                {
                }

                _LayoutControlItem2 = value;
                if (_LayoutControlItem2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Layout.LayoutControlItem _LayoutControlItem3;

        internal DevComponents.DotNetBar.Layout.LayoutControlItem LayoutControlItem3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LayoutControlItem3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LayoutControlItem3 != null)
                {
                }

                _LayoutControlItem3 = value;
                if (_LayoutControlItem3 != null)
                {
                }
            }
        }
    }
}