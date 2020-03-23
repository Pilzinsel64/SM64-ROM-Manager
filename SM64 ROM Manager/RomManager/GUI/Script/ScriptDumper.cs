using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::PaintingControls;
using global::SM64Lib.Script;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class ScriptDumper<TCmd, eTypes>
    {
        public ScriptDumper()
        {
            PaintingControl1 = new PaintingControl() { Dock = DockStyle.None, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, Location = Point.Empty, AutoScroll = true, BackColor = Color.Transparent };
            base.Shown += ScriptDumper_Shown;
            SuspendLayout();

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            PanelEx_PaintingControl1.Controls.Add(PaintingControl1);
            PaintingControl1.Parent = PanelEx_PaintingControl1;
            PaintingControl1.AutoMoveObjects = false;
            PaintingControl1.Size = PanelEx_PaintingControl1.Size;
            PanelEx_PaintingControl1.VerticalScroll.Visible = false;
            ResumeLayout();
        }

        private PaintingControl _PaintingControl1; // .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top, .Location = New Point(0, 0)

        private PaintingControl PaintingControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PaintingControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PaintingControl1 != null)
                {
                }

                _PaintingControl1 = value;
                if (_PaintingControl1 != null)
                {
                }
            }
        }

        public BaseCommandCollection<TCmd, eTypes> Script { get; set; } = null;

        private Dictionary<string, LabelX> dicLabelItems = new Dictionary<string, LabelX>();
        private Dictionary<string, BaseCommand<eTypes>> dicCommands = new Dictionary<string, BaseCommand<eTypes>>();

        private void ScriptDumper_Shown(object sender, EventArgs e)
        {
            ListCommands();
        }

        private void ListCommands()
        {
            PaintingControl1.SuspendLayout();
            PaintingControl1.PaintingObjects.Clear();
            dicLabelItems.Clear();
            dicCommands.Clear();
            int curY = 10;
            int curWidth = 0;
            foreach (BaseCommand<eTypes> cmd in Script)
            {
                var po = new PaintingObject() { EnableResize = false };
                PaintingControl1.PaintingObjects.Add(po);
                po.Text = $"{cmd.ToString()}";
                po.TextColor = ForeColor;
                po.Type = PaintingObjectType.Custom;
                po.TextFont = new Font(po.TextFont.FontFamily, 12, po.TextFont.Style);
                po.HorizontalTextAlignment = StringAlignment.Near;
                var lb = new LabelX() { Text = po.Text, Font = po.TextFont };
                string newName = Conversions.ToString(dicLabelItems.Count);
                lb.BackColor = PanelEx_PaintingControl1.Style.BackColor1.Color;
                po.Name = newName;
                lb.Name = newName;
                lb.Visible = false;
                lb.Refresh();
                dicLabelItems.Add(newName, lb);
                dicCommands.Add(newName, cmd);
                po.Y = curY;
                po.X = 10;
                po.FitSizeToText();
                lb.Size = Size.Round(po.Size);
                curWidth = Conversions.ToInteger(Math.Max(curWidth, po.Width));
                curY += (int)po.Height + 10;
                po.MouseUp += PaintingObject_MouseUp;
                po.DrawMethodes.Add(DrawCmdText);
            }

            PaintingControl1.Size = new Size(PanelEx_PaintingControl1.Width - 17, curY);
            PaintingControl1.ResumeLayout();
            PaintingControl1.Invalidate();
        }

        private void DrawCmdText(PaintingObjectPaintEventArgs e)
        {
            var lb = dicLabelItems[e.PaintingObject.Name];
            var bmp = new Bitmap(Conversions.ToInteger(e.PaintingObject.Width), Conversions.ToInteger(e.PaintingObject.Height));
            lb.Text = e.PaintingObject.Text;
            lb.DrawToBitmap(bmp, new Rectangle(Point.Empty, lb.Size));
            e.Graphics.DrawImage(bmp, e.Location);
            bmp.Dispose();
        }

        private string SelectedName
        {
            get
            {
                var obj = PaintingControl1.SelectedObjects.FirstOrDefault();
                if (obj is object)
                {
                    return obj.Name;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        private void CopyRomAddress()
        {
            string name = SelectedName;
            if (!string.IsNullOrEmpty(name))
            {
                Clipboard.SetText(TextValueConverter.TextFromValue(dicCommands[name].RomAddress));
            }
        }

        private void CopyRamAddress()
        {
            string name = SelectedName;
            if (!string.IsNullOrEmpty(name))
            {
                Clipboard.SetText(TextValueConverter.TextFromValue(dicCommands[name].BankAddress));
            }
        }

        private void CopyAsHexArray()
        {
            string name = SelectedName;
            if (!string.IsNullOrEmpty(name))
            {
                var cmd = dicCommands[name];
                string strCmd = string.Empty;
                foreach (byte b in cmd.ToArray())
                {
                    if (!string.IsNullOrEmpty(strCmd))
                        strCmd += " ";
                    strCmd += b.ToString("X2");
                }

                Clipboard.SetText(strCmd);
            }
        }

        private void EditHex()
        {
            var po = PaintingControl1.SelectedObjects.FirstOrDefault();
            if (po is object)
            {
                SM64Lib.Script.ICommand cmd = dicCommands[po.Name];
                General.OpenHexEditor(cmd);
                po.Text = cmd.ToString();
                PaintingControl1.Refresh();
            }
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            CopyRomAddress();
        }

        private void ButtonItem2_Click(object sender, EventArgs e)
        {
            CopyRamAddress();
        }

        private void ButtonItem4_Click(object sender, EventArgs e)
        {
            CopyAsHexArray();
        }

        private void ButtonItem3_Click(object sender, EventArgs e)
        {
            EditHex();
        }

        private void PaintingObject_MouseUp(PaintingObject sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PaintingControl1.Refresh();
                CM_Cmd.Popup(Cursor.Position);
            }
        }
    }
}