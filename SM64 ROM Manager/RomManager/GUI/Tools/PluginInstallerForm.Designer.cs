using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    public partial class PluginInstallerForm : DevComponents.DotNetBar.OfficeForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginInstallerForm));
            _Panel1 = new Panel();
            _ButtonX_Remove = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Remove.Click += new EventHandler(ButtonX_Remove_Click);
            _ButtonX_Install = new DevComponents.DotNetBar.ButtonX();
            _ButtonItem_SingleFile = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_SingleFile.Click += new EventHandler(ButtonItem_SingleFile_Click);
            _ButtonItem_ZipFile = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_ZipFile.Click += new EventHandler(ButtonItem_ZipFile_Click);
            _ButtonItem_Directory = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_Directory.Click += new EventHandler(ButtonItem_Directory_Click);
            _ButtonX_Close = new DevComponents.DotNetBar.ButtonX();
            _ButtonX_Close.Click += new EventHandler(ButtonX_Close_Click);
            _ListViewEx_Plugins = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _ColumnHeader3 = new ColumnHeader();
            _ColumnHeader4 = new ColumnHeader();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.Controls.Add(_ButtonX_Remove);
            _Panel1.Controls.Add(_ButtonX_Install);
            _Panel1.Controls.Add(_ButtonX_Close);
            _Panel1.Controls.Add(_ListViewEx_Plugins);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // ButtonX_Remove
            // 
            _ButtonX_Remove.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_Remove, "ButtonX_Remove");
            _ButtonX_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Remove.Name = "ButtonX_Remove";
            _ButtonX_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ButtonX_Install
            // 
            _ButtonX_Install.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_Install, "ButtonX_Install");
            _ButtonX_Install.AutoExpandOnClick = true;
            _ButtonX_Install.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Install.Name = "ButtonX_Install";
            _ButtonX_Install.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ButtonX_Install.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_SingleFile, _ButtonItem_ZipFile, _ButtonItem_Directory });
            // 
            // ButtonItem_SingleFile
            // 
            _ButtonItem_SingleFile.GlobalItem = false;
            _ButtonItem_SingleFile.Name = "ButtonItem_SingleFile";
            resources.ApplyResources(_ButtonItem_SingleFile, "ButtonItem_SingleFile");
            // 
            // ButtonItem_ZipFile
            // 
            _ButtonItem_ZipFile.GlobalItem = false;
            _ButtonItem_ZipFile.Name = "ButtonItem_ZipFile";
            resources.ApplyResources(_ButtonItem_ZipFile, "ButtonItem_ZipFile");
            // 
            // ButtonItem_Directory
            // 
            _ButtonItem_Directory.GlobalItem = false;
            _ButtonItem_Directory.Name = "ButtonItem_Directory";
            resources.ApplyResources(_ButtonItem_Directory, "ButtonItem_Directory");
            // 
            // ButtonX_Close
            // 
            _ButtonX_Close.AccessibleRole = AccessibleRole.PushButton;
            resources.ApplyResources(_ButtonX_Close, "ButtonX_Close");
            _ButtonX_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _ButtonX_Close.DialogResult = DialogResult.Cancel;
            _ButtonX_Close.Name = "ButtonX_Close";
            _ButtonX_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ListViewEx_Plugins
            // 
            resources.ApplyResources(_ListViewEx_Plugins, "ListViewEx_Plugins");
            _ListViewEx_Plugins.BackColor = Color.White;
            // 
            // 
            // 
            _ListViewEx_Plugins.Border.Class = "ListViewBorder";
            _ListViewEx_Plugins.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx_Plugins.Columns.AddRange(new ColumnHeader[] { _ColumnHeader1, _ColumnHeader2, _ColumnHeader3, _ColumnHeader4 });
            _ListViewEx_Plugins.DisabledBackColor = Color.Empty;
            _ListViewEx_Plugins.ForeColor = Color.Black;
            _ListViewEx_Plugins.FullRowSelect = true;
            _ListViewEx_Plugins.Groups.AddRange(new ListViewGroup[] { (ListViewGroup)resources.GetObject("ListViewEx_Plugins.Groups"), (ListViewGroup)resources.GetObject("ListViewEx_Plugins.Groups1") });
            _ListViewEx_Plugins.HideSelection = false;
            _ListViewEx_Plugins.Name = "ListViewEx_Plugins";
            _ListViewEx_Plugins.UseCompatibleStateImageBehavior = false;
            _ListViewEx_Plugins.View = View.Details;
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(_ColumnHeader1, "ColumnHeader1");
            // 
            // ColumnHeader2
            // 
            resources.ApplyResources(_ColumnHeader2, "ColumnHeader2");
            // 
            // ColumnHeader3
            // 
            resources.ApplyResources(_ColumnHeader3, "ColumnHeader3");
            // 
            // ColumnHeader4
            // 
            resources.ApplyResources(_ColumnHeader4, "ColumnHeader4");
            // 
            // PluginInstallerForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _ButtonX_Close;
            Controls.Add(_Panel1);
            Name = "PluginInstallerForm";
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

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx_Plugins;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx_Plugins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx_Plugins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx_Plugins != null)
                {
                }

                _ListViewEx_Plugins = value;
                if (_ListViewEx_Plugins != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _ButtonX_Close;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Close
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Close;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Close != null)
                {
                    _ButtonX_Close.Click -= ButtonX_Close_Click;
                }

                _ButtonX_Close = value;
                if (_ButtonX_Close != null)
                {
                    _ButtonX_Close.Click += ButtonX_Close_Click;
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

        private DevComponents.DotNetBar.ButtonX _ButtonX_Install;

        internal DevComponents.DotNetBar.ButtonX ButtonX_Install
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX_Install;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX_Install != null)
                {
                }

                _ButtonX_Install = value;
                if (_ButtonX_Install != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader1;

        internal ColumnHeader ColumnHeader1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader1 != null)
                {
                }

                _ColumnHeader1 = value;
                if (_ColumnHeader1 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader2;

        internal ColumnHeader ColumnHeader2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader2 != null)
                {
                }

                _ColumnHeader2 = value;
                if (_ColumnHeader2 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader3;

        internal ColumnHeader ColumnHeader3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader3 != null)
                {
                }

                _ColumnHeader3 = value;
                if (_ColumnHeader3 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader4;

        internal ColumnHeader ColumnHeader4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader4 != null)
                {
                }

                _ColumnHeader4 = value;
                if (_ColumnHeader4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_SingleFile;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_SingleFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_SingleFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_SingleFile != null)
                {
                    _ButtonItem_SingleFile.Click -= ButtonItem_SingleFile_Click;
                }

                _ButtonItem_SingleFile = value;
                if (_ButtonItem_SingleFile != null)
                {
                    _ButtonItem_SingleFile.Click += ButtonItem_SingleFile_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_ZipFile;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_ZipFile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_ZipFile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_ZipFile != null)
                {
                    _ButtonItem_ZipFile.Click -= ButtonItem_ZipFile_Click;
                }

                _ButtonItem_ZipFile = value;
                if (_ButtonItem_ZipFile != null)
                {
                    _ButtonItem_ZipFile.Click += ButtonItem_ZipFile_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_Directory;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_Directory
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_Directory;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_Directory != null)
                {
                    _ButtonItem_Directory.Click -= ButtonItem_Directory_Click;
                }

                _ButtonItem_Directory = value;
                if (_ButtonItem_Directory != null)
                {
                    _ButtonItem_Directory.Click += ButtonItem_Directory_Click;
                }
            }
        }
    }
}