using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    [DesignerGenerated()]
    internal partial class ApplyStyleMgrStyle : Form
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
            _StyleManager1 = new DevComponents.DotNetBar.StyleManager(components);
            SuspendLayout();
            // 
            // StyleManager1
            // 
            _StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            _StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255))), Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(57)), Conversions.ToInteger(Conversions.ToByte(123))));
            // 
            // ApplyStyleMgrStyle
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ApplyStyleMgrStyle";
            Text = "DummyStyle";
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.StyleManager _StyleManager1;

        internal DevComponents.DotNetBar.StyleManager StyleManager1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StyleManager1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _StyleManager1 = value;
            }
        }
    }
}