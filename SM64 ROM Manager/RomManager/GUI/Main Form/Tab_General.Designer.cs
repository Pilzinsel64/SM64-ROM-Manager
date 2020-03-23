using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Tab_General : UserControl
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_General));
            _GroupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _ItemPanel_RecentFiles = new DevComponents.DotNetBar.ItemPanel();
            _GroupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            _Button_G_SaveGameName = new DevComponents.DotNetBar.ButtonX();
            _Button_G_SaveGameName.Click += new EventHandler(Button_G_SaveGameName_Click);
            _LabelX27 = new DevComponents.DotNetBar.LabelX();
            _LabelX_G_Filename = new DevComponents.DotNetBar.LabelX();
            _TextBoxX_G_GameName = new DevComponents.DotNetBar.Controls.TextBoxX();
            _TextBoxX_G_GameName.TextChanged += new EventHandler(TextBoxX_G_GameName_TextChanged);
            _LabelX_G_Filesize = new DevComponents.DotNetBar.LabelX();
            _LabelX34 = new DevComponents.DotNetBar.LabelX();
            _LabelX35 = new DevComponents.DotNetBar.LabelX();
            _GroupPanel2.SuspendLayout();
            _GroupPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // GroupPanel2
            // 
            resources.ApplyResources(_GroupPanel2, "GroupPanel2");
            _GroupPanel2.BackColor = Color.Transparent;
            _GroupPanel2.CanvasColor = SystemColors.Control;
            _GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            _GroupPanel2.Controls.Add(_ItemPanel_RecentFiles);
            _GroupPanel2.DisabledBackColor = Color.Empty;
            _GroupPanel2.Name = "GroupPanel2";
            // 
            // 
            // 
            _GroupPanel2.Style.BackColorGradientAngle = 90;
            _GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderBottomWidth = 1;
            _GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderLeftWidth = 1;
            _GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderRightWidth = 1;
            _GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel2.Style.BorderTopWidth = 1;
            _GroupPanel2.Style.CornerDiameter = 4;
            _GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ItemPanel_RecentFiles
            // 
            resources.ApplyResources(_ItemPanel_RecentFiles, "ItemPanel_RecentFiles");
            // 
            // 
            // 
            _ItemPanel_RecentFiles.BackgroundStyle.Class = "ItemPanel";
            _ItemPanel_RecentFiles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemPanel_RecentFiles.ContainerControlProcessDialogKey = true;
            _ItemPanel_RecentFiles.DragDropSupport = true;
            _ItemPanel_RecentFiles.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemPanel_RecentFiles.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemPanel_RecentFiles.Name = "ItemPanel_RecentFiles";
            _ItemPanel_RecentFiles.ReserveLeftSpace = false;
            _ItemPanel_RecentFiles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // GroupPanel6
            // 
            resources.ApplyResources(_GroupPanel6, "GroupPanel6");
            _GroupPanel6.BackColor = Color.Transparent;
            _GroupPanel6.CanvasColor = Color.Empty;
            _GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            _GroupPanel6.Controls.Add(_Button_G_SaveGameName);
            _GroupPanel6.Controls.Add(_LabelX27);
            _GroupPanel6.Controls.Add(_LabelX_G_Filename);
            _GroupPanel6.Controls.Add(_TextBoxX_G_GameName);
            _GroupPanel6.Controls.Add(_LabelX_G_Filesize);
            _GroupPanel6.Controls.Add(_LabelX34);
            _GroupPanel6.Controls.Add(_LabelX35);
            _GroupPanel6.DisabledBackColor = Color.Empty;
            _GroupPanel6.Name = "GroupPanel6";
            // 
            // 
            // 
            _GroupPanel6.Style.BackColorGradientAngle = 90;
            _GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel6.Style.BorderBottomWidth = 1;
            _GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            _GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel6.Style.BorderLeftWidth = 1;
            _GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel6.Style.BorderRightWidth = 1;
            _GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            _GroupPanel6.Style.BorderTopWidth = 1;
            _GroupPanel6.Style.CornerDiameter = 4;
            _GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _GroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            _GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            _GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            _GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            _GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Button_G_SaveGameName
            // 
            _Button_G_SaveGameName.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_Button_G_SaveGameName, "Button_G_SaveGameName");
            _Button_G_SaveGameName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_G_SaveGameName.FocusCuesEnabled = false;
            _Button_G_SaveGameName.Name = "Button_G_SaveGameName";
            _Button_G_SaveGameName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX27
            // 
            // 
            // 
            // 
            _LabelX27.BackgroundStyle.BackColor = Color.Transparent;
            _LabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX27, "LabelX27");
            _LabelX27.Name = "LabelX27";
            _LabelX27.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX_G_Filename
            // 
            resources.ApplyResources(_LabelX_G_Filename, "LabelX_G_Filename");
            _LabelX_G_Filename.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_G_Filename.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_G_Filename.Name = "LabelX_G_Filename";
            _LabelX_G_Filename.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // TextBoxX_G_GameName
            // 
            resources.ApplyResources(_TextBoxX_G_GameName, "TextBoxX_G_GameName");
            _TextBoxX_G_GameName.BackColor = Color.White;
            // 
            // 
            // 
            _TextBoxX_G_GameName.Border.Class = "TextBoxBorder";
            _TextBoxX_G_GameName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _TextBoxX_G_GameName.DisabledBackColor = Color.White;
            _TextBoxX_G_GameName.ForeColor = Color.Black;
            _TextBoxX_G_GameName.Name = "TextBoxX_G_GameName";
            _TextBoxX_G_GameName.PreventEnterBeep = true;
            // 
            // LabelX_G_Filesize
            // 
            resources.ApplyResources(_LabelX_G_Filesize, "LabelX_G_Filesize");
            _LabelX_G_Filesize.BackColor = Color.Transparent;
            // 
            // 
            // 
            _LabelX_G_Filesize.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_G_Filesize.Name = "LabelX_G_Filesize";
            _LabelX_G_Filesize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX34
            // 
            // 
            // 
            // 
            _LabelX34.BackgroundStyle.BackColor = Color.Transparent;
            _LabelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX34, "LabelX34");
            _LabelX34.Name = "LabelX34";
            _LabelX34.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX35
            // 
            // 
            // 
            // 
            _LabelX35.BackgroundStyle.BackColor = Color.Transparent;
            _LabelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX35, "LabelX35");
            _LabelX35.Name = "LabelX35";
            _LabelX35.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // Tab_General
            // 
            BackColor = Color.White;
            Controls.Add(_GroupPanel2);
            Controls.Add(_GroupPanel6);
            Name = "Tab_General";
            resources.ApplyResources(this, "$this");
            _GroupPanel2.ResumeLayout(false);
            _GroupPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel2;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel2 != null)
                {
                }

                _GroupPanel2 = value;
                if (_GroupPanel2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ItemPanel _ItemPanel_RecentFiles;

        internal DevComponents.DotNetBar.ItemPanel ItemPanel_RecentFiles
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemPanel_RecentFiles;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemPanel_RecentFiles != null)
                {
                }

                _ItemPanel_RecentFiles = value;
                if (_ItemPanel_RecentFiles != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.GroupPanel _GroupPanel6;

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupPanel6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupPanel6 != null)
                {
                }

                _GroupPanel6 = value;
                if (_GroupPanel6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_G_SaveGameName;

        internal DevComponents.DotNetBar.ButtonX Button_G_SaveGameName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_G_SaveGameName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_G_SaveGameName != null)
                {
                    _Button_G_SaveGameName.Click -= Button_G_SaveGameName_Click;
                }

                _Button_G_SaveGameName = value;
                if (_Button_G_SaveGameName != null)
                {
                    _Button_G_SaveGameName.Click += Button_G_SaveGameName_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX27;

        internal DevComponents.DotNetBar.LabelX LabelX27
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX27;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX27 != null)
                {
                }

                _LabelX27 = value;
                if (_LabelX27 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_G_Filename;

        internal DevComponents.DotNetBar.LabelX LabelX_G_Filename
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_G_Filename;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_G_Filename != null)
                {
                }

                _LabelX_G_Filename = value;
                if (_LabelX_G_Filename != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.TextBoxX _TextBoxX_G_GameName;

        internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_G_GameName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxX_G_GameName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxX_G_GameName != null)
                {
                    _TextBoxX_G_GameName.TextChanged -= TextBoxX_G_GameName_TextChanged;
                }

                _TextBoxX_G_GameName = value;
                if (_TextBoxX_G_GameName != null)
                {
                    _TextBoxX_G_GameName.TextChanged += TextBoxX_G_GameName_TextChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_G_Filesize;

        internal DevComponents.DotNetBar.LabelX LabelX_G_Filesize
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_G_Filesize;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_G_Filesize != null)
                {
                }

                _LabelX_G_Filesize = value;
                if (_LabelX_G_Filesize != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX34;

        internal DevComponents.DotNetBar.LabelX LabelX34
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX34;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX34 != null)
                {
                }

                _LabelX34 = value;
                if (_LabelX34 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX35;

        internal DevComponents.DotNetBar.LabelX LabelX35
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX35;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX35 != null)
                {
                }

                _LabelX35 = value;
                if (_LabelX35 != null)
                {
                }
            }
        }
    }
}