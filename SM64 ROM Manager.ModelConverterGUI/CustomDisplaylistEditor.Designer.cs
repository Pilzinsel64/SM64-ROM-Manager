using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class CustomDisplaylistEditor : DevComponents.DotNetBar.OfficeForm
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDisplaylistEditor));
            _Panel1 = new System.Windows.Forms.Panel();
            _ItemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_ItemPanel1);
            _Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            _Panel1.Location = new System.Drawing.Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new System.Drawing.Size(384, 261);
            _Panel1.TabIndex = 0;
            // 
            // ItemPanel1
            // 
            _ItemPanel1.AutoScroll = true;
            // 
            // 
            // 
            _ItemPanel1.BackgroundStyle.Class = "ItemPanel";
            _ItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ItemPanel1.ContainerControlProcessDialogKey = true;
            _ItemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            _ItemPanel1.DragDropSupport = true;
            _ItemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            _ItemPanel1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            _ItemPanel1.Location = new System.Drawing.Point(0, 0);
            _ItemPanel1.Name = "ItemPanel1";
            _ItemPanel1.ReserveLeftSpace = false;
            _ItemPanel1.Size = new System.Drawing.Size(384, 261);
            _ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ItemPanel1.TabIndex = 0;
            // 
            // CustomDisplaylistEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 261);
            Controls.Add(_Panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "CustomDisplaylistEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit custom displaylists";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            _Panel1.ResumeLayout(false);
            ResumeLayout(false);
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

        private DevComponents.DotNetBar.ItemPanel _ItemPanel1;

        internal DevComponents.DotNetBar.ItemPanel ItemPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ItemPanel1 != null)
                {
                }

                _ItemPanel1 = value;
                if (_ItemPanel1 != null)
                {
                }
            }
        }
    }
}