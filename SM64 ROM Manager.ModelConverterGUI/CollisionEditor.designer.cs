using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class CollisionEditor : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CollisionEditor));
            _TextBoxX_ColParam2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ColParam2.TextChanged += new EventHandler(ComboBox_CI_ColType_SelectedIndexChanged);
            _TextBoxX_ColParam1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_ColParam1.TextChanged += new EventHandler(ComboBox_CI_ColType_SelectedIndexChanged);
            _LabelX_ColParamsTipp = new DevComponents.DotNetBar.LabelX();
            _LabelX_Param2 = new DevComponents.DotNetBar.LabelX();
            _LabelX_Param1 = new DevComponents.DotNetBar.LabelX();
            _Button_SaveColsettings = new DevComponents.DotNetBar.ButtonX();
            _LabelX48 = new DevComponents.DotNetBar.LabelX();
            _ComboBox_ColType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_ColType.SelectedIndexChanged += new EventHandler(ComboBox_CI_ColType_SelectedIndexChanged);
            _LabelX_CollisionType = new DevComponents.DotNetBar.LabelX();
            _CheckBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX1.CheckedChanged += new EventHandler(CheckBoxX1_CheckedChanging);
            _TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX1.TextChanged += new EventHandler(TextBoxX1_TextChanged);
            _ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ListViewEx1.SelectedIndexChanged += new EventHandler(ListBoxAdv_CI_Textures_ItemClick);
            _SuperTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            _PictureBox1 = new System.Windows.Forms.PictureBox();
            _Panel1 = new System.Windows.Forms.Panel();
            _CheckBoxX_IsNonSolid = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_IsNonSolid.CheckedChanged += new EventHandler(ButtonItem_IsNonSolid_CheckedChanged);
            _CircularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            _Panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).BeginInit();
            _Panel1.SuspendLayout();
            _Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxX_ColParam2
            // 
            resources.ApplyResources(_TextBoxX_ColParam2, "TextBoxX_ColParam2");
            _TextBoxX_ColParam2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX_ColParam2.Border.Class = "TextBoxBorder";
            _TextBoxX_ColParam2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ColParam2.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX_ColParam2.ForeColor = System.Drawing.Color.Black;
            _TextBoxX_ColParam2.Name = "TextBoxX_ColParam2";
            _TextBoxX_ColParam2.PreventEnterBeep = true;
            // 
            // TextBoxX_ColParam1
            // 
            resources.ApplyResources(_TextBoxX_ColParam1, "TextBoxX_ColParam1");
            _TextBoxX_ColParam1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX_ColParam1.Border.Class = "TextBoxBorder";
            _TextBoxX_ColParam1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_ColParam1.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX_ColParam1.ForeColor = System.Drawing.Color.Black;
            _TextBoxX_ColParam1.Name = "TextBoxX_ColParam1";
            _TextBoxX_ColParam1.PreventEnterBeep = true;
            // 
            // LabelX_ColParamsTipp
            // 
            resources.ApplyResources(_LabelX_ColParamsTipp, "LabelX_ColParamsTipp");
            // 
            // 
            // 
            _LabelX_ColParamsTipp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_ColParamsTipp.Name = "LabelX_ColParamsTipp";
            _LabelX_ColParamsTipp.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            _LabelX_ColParamsTipp.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // LabelX_Param2
            // 
            resources.ApplyResources(_LabelX_Param2, "LabelX_Param2");
            // 
            // 
            // 
            _LabelX_Param2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Param2.Name = "LabelX_Param2";
            _LabelX_Param2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX_Param1
            // 
            resources.ApplyResources(_LabelX_Param1, "LabelX_Param1");
            // 
            // 
            // 
            _LabelX_Param1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_Param1.Name = "LabelX_Param1";
            _LabelX_Param1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Button_SaveColsettings
            // 
            _Button_SaveColsettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(_Button_SaveColsettings, "Button_SaveColsettings");
            _Button_SaveColsettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_SaveColsettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            _Button_SaveColsettings.FocusCuesEnabled = false;
            _Button_SaveColsettings.Name = "Button_SaveColsettings";
            _Button_SaveColsettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX48
            // 
            // 
            // 
            // 
            _LabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX48, "LabelX48");
            _LabelX48.Name = "LabelX48";
            _LabelX48.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // ComboBox_ColType
            // 
            resources.ApplyResources(_ComboBox_ColType, "ComboBox_ColType");
            _ComboBox_ColType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBox_ColType.DropDownHeight = 150;
            _ComboBox_ColType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _ComboBox_ColType.ForeColor = System.Drawing.Color.Black;
            _ComboBox_ColType.FormattingEnabled = true;
            _ComboBox_ColType.Name = "ComboBox_ColType";
            _ComboBox_ColType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX_CollisionType
            // 
            resources.ApplyResources(_LabelX_CollisionType, "LabelX_CollisionType");
            // 
            // 
            // 
            _LabelX_CollisionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_CollisionType.Name = "LabelX_CollisionType";
            _LabelX_CollisionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // CheckBoxX1
            // 
            resources.ApplyResources(_CheckBoxX1, "CheckBoxX1");
            // 
            // 
            // 
            _CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX1.FocusCuesEnabled = false;
            _CheckBoxX1.Name = "CheckBoxX1";
            _CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TextBoxX1
            // 
            resources.ApplyResources(_TextBoxX1, "TextBoxX1");
            _TextBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _TextBoxX1.Border.Class = "TextBoxBorder";
            _TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
            _TextBoxX1.ForeColor = System.Drawing.Color.Black;
            _TextBoxX1.Name = "TextBoxX1";
            _TextBoxX1.PreventEnterBeep = true;
            // 
            // ListViewEx1
            // 
            resources.ApplyResources(_ListViewEx1, "ListViewEx1");
            _ListViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _ListViewEx1.Border.Class = "ListViewBorder";
            _ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            _ListViewEx1.FocusCuesEnabled = false;
            _ListViewEx1.ForeColor = System.Drawing.Color.Black;
            _ListViewEx1.FullRowSelect = true;
            _ListViewEx1.HideSelection = false;
            _ListViewEx1.Name = "ListViewEx1";
            _ListViewEx1.UseCompatibleStateImageBehavior = false;
            // 
            // SuperTooltip1
            // 
            resources.ApplyResources(_SuperTooltip1, "SuperTooltip1");
            _SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // PictureBox1
            // 
            resources.ApplyResources(_PictureBox1, "PictureBox1");
            _PictureBox1.Name = "PictureBox1";
            _PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_LabelX_CollisionType);
            _Panel1.Controls.Add(_ComboBox_ColType);
            _Panel1.Controls.Add(_LabelX_Param2);
            _Panel1.Controls.Add(_LabelX_ColParamsTipp);
            _Panel1.Controls.Add(_LabelX_Param1);
            _Panel1.Controls.Add(_TextBoxX_ColParam1);
            _Panel1.Controls.Add(_CheckBoxX1);
            _Panel1.Controls.Add(_TextBoxX_ColParam2);
            _Panel1.Controls.Add(_TextBoxX1);
            _Panel1.Name = "Panel1";
            // 
            // CheckBoxX_IsNonSolid
            // 
            resources.ApplyResources(_CheckBoxX_IsNonSolid, "CheckBoxX_IsNonSolid");
            // 
            // 
            // 
            _CheckBoxX_IsNonSolid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_IsNonSolid.FocusCuesEnabled = false;
            _CheckBoxX_IsNonSolid.Name = "CheckBoxX_IsNonSolid";
            _CheckBoxX_IsNonSolid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CircularProgress1
            // 
            resources.ApplyResources(_CircularProgress1, "CircularProgress1");
            _CircularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            _CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CircularProgress1.Name = "CircularProgress1";
            _CircularProgress1.SetVisibleStateOnStart = true;
            _CircularProgress1.SetVisibleStateOnStop = true;
            _CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Panel2
            // 
            _Panel2.BackColor = System.Drawing.Color.Transparent;
            _Panel2.Controls.Add(_LabelX48);
            _Panel2.Controls.Add(_CircularProgress1);
            _Panel2.Controls.Add(_Button_SaveColsettings);
            _Panel2.Controls.Add(_CheckBoxX_IsNonSolid);
            _Panel2.Controls.Add(_ListViewEx1);
            _Panel2.Controls.Add(_Panel1);
            _Panel2.Controls.Add(_PictureBox1);
            resources.ApplyResources(_Panel2, "Panel2");
            _Panel2.Name = "Panel2";
            // 
            // CollisionEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(_Panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CollisionEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).EndInit();
            _Panel1.ResumeLayout(false);
            _Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ColParam2;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ColParam2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ColParam2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ColParam2 != null)
                {
                    _TextBoxX_ColParam2.TextChanged -= ComboBox_CI_ColType_SelectedIndexChanged;
                }

                _TextBoxX_ColParam2 = value;
                if (_TextBoxX_ColParam2 != null)
                {
                    _TextBoxX_ColParam2.TextChanged += ComboBox_CI_ColType_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_ColParam1;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_ColParam1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_ColParam1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_ColParam1 != null)
                {
                    _TextBoxX_ColParam1.TextChanged -= ComboBox_CI_ColType_SelectedIndexChanged;
                }

                _TextBoxX_ColParam1 = value;
                if (_TextBoxX_ColParam1 != null)
                {
                    _TextBoxX_ColParam1.TextChanged += ComboBox_CI_ColType_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_ColParamsTipp;

        internal DevComponents.DotNetBar.LabelX LabelX_ColParamsTipp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_ColParamsTipp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_ColParamsTipp != null)
                {
                }

                _LabelX_ColParamsTipp = value;
                if (_LabelX_ColParamsTipp != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Param2;

        internal DevComponents.DotNetBar.LabelX LabelX_Param2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Param2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Param2 != null)
                {
                }

                _LabelX_Param2 = value;
                if (_LabelX_Param2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_Param1;

        internal DevComponents.DotNetBar.LabelX LabelX_Param1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_Param1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_Param1 != null)
                {
                }

                _LabelX_Param1 = value;
                if (_LabelX_Param1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_SaveColsettings;

        internal DevComponents.DotNetBar.ButtonX Button_SaveColsettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_SaveColsettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_SaveColsettings != null)
                {
                }

                _Button_SaveColsettings = value;
                if (_Button_SaveColsettings != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX48;

        internal DevComponents.DotNetBar.LabelX LabelX48
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX48;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX48 != null)
                {
                }

                _LabelX48 = value;
                if (_LabelX48 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_ColType;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_ColType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_ColType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_ColType != null)
                {
                    _ComboBox_ColType.SelectedIndexChanged -= ComboBox_CI_ColType_SelectedIndexChanged;
                }

                _ComboBox_ColType = value;
                if (_ComboBox_ColType != null)
                {
                    _ComboBox_ColType.SelectedIndexChanged += ComboBox_CI_ColType_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_CollisionType;

        internal DevComponents.DotNetBar.LabelX LabelX_CollisionType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_CollisionType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_CollisionType != null)
                {
                }

                _LabelX_CollisionType = value;
                if (_LabelX_CollisionType != null)
                {
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
                    _CheckBoxX1.CheckedChanged -= CheckBoxX1_CheckedChanging;
                }

                _CheckBoxX1 = value;
                if (_CheckBoxX1 != null)
                {
                    _CheckBoxX1.CheckedChanged += CheckBoxX1_CheckedChanging;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX1;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX1 != null)
                {
                    _TextBoxX1.TextChanged -= TextBoxX1_TextChanged;
                }

                _TextBoxX1 = value;
                if (_TextBoxX1 != null)
                {
                    _TextBoxX1.TextChanged += TextBoxX1_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx1;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx1 != null)
                {
                    _ListViewEx1.SelectedIndexChanged -= ListBoxAdv_CI_Textures_ItemClick;
                }

                _ListViewEx1 = value;
                if (_ListViewEx1 != null)
                {
                    _ListViewEx1.SelectedIndexChanged += ListBoxAdv_CI_Textures_ItemClick;
                }
            }
        }

        private DevComponents.DotNetBar.SuperTooltip _SuperTooltip1;

        internal DevComponents.DotNetBar.SuperTooltip SuperTooltip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SuperTooltip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SuperTooltip1 != null)
                {
                }

                _SuperTooltip1 = value;
                if (_SuperTooltip1 != null)
                {
                }
            }
        }

        private System.Windows.Forms.PictureBox _PictureBox1;

        internal System.Windows.Forms.PictureBox PictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox1 != null)
                {
                }

                _PictureBox1 = value;
                if (_PictureBox1 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel1;

        internal System.Windows.Forms.Panel Panel1
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

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_IsNonSolid;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_IsNonSolid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_IsNonSolid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_IsNonSolid != null)
                {
                    _CheckBoxX_IsNonSolid.CheckedChanged -= ButtonItem_IsNonSolid_CheckedChanged;
                }

                _CheckBoxX_IsNonSolid = value;
                if (_CheckBoxX_IsNonSolid != null)
                {
                    _CheckBoxX_IsNonSolid.CheckedChanged += ButtonItem_IsNonSolid_CheckedChanged;
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

        private System.Windows.Forms.Panel _Panel2;

        internal System.Windows.Forms.Panel Panel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel2 != null)
                {
                }

                _Panel2 = value;
                if (_Panel2 != null)
                {
                }
            }
        }
    }
}