using System;
using System.Drawing;
using System.Windows.Forms;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class RGBEditInfoEditor
    {
        public RGBEditInfoEditor()
        {
            base.Load += RGBEditInfoEditor_Load;
            this.FormClosing += RGBEditInfoEditor_FormClosing;
            InitializeComponent();
            base.UpdateAmbientColors();
            Panel1.BackColor = Color.Transparent;
            SwitchButton_LightMult.Enabled = false;
            SwitchButton_DarkMult.Enabled = false;
            TextBoxX_Light.Enabled = false;
            TextBoxX_Dark.Enabled = false;
            TextBoxX_Alpha.Enabled = false;
        }

        public RGBEditor.RGBEditInfo RGBEditInfo { get; set; } = null;

        private void LoadRgbInfo()
        {
            var e = RGBEditInfo;
            TextBoxX_Name.Text = e.Name;
            bool enableLight = e.LightAddress is object;
            SwitchButton_Light.Value = enableLight;
            if (enableLight)
            {
                SwitchButton_LightMult.Value = e.DoubleLightRGB;
                TextBoxX_Light.Text = TextValueConverter.TextFromValue((long)e.LightAddress);
            }

            bool enableDark = e.DarkAddress is object;
            SwitchButton_Dark.Value = enableDark;
            if (enableDark)
            {
                SwitchButton_DarkMult.Value = e.DoubleDarkRGB;
                TextBoxX_Dark.Text = TextValueConverter.TextFromValue((long)e.DarkAddress);
            }

            bool enableAlpha = e.AlphaAddress is object;
            SwitchButton_Alpha.Value = enableAlpha;
            if (enableAlpha)
            {
                TextBoxX_Alpha.Text = TextValueConverter.TextFromValue((long)e.AlphaAddress);
            }
        }

        private void SaveRgbInfo()
        {
            var e = RGBEditInfo;
            e.Name = TextBoxX_Name.Text;
            if (SwitchButton_Light.Value)
            {
                e.LightAddress = (uint?)TextValueConverter.ValueFromText(TextBoxX_Light.Text);
                e.DoubleLightRGB = SwitchButton_LightMult.Value;
            }
            else
            {
                e.LightAddress = default;
            }

            if (SwitchButton_Dark.Value)
            {
                e.DarkAddress = (uint?)TextValueConverter.ValueFromText(TextBoxX_Dark.Text);
                e.DoubleDarkRGB = SwitchButton_DarkMult.Value;
            }
            else
            {
                e.DarkAddress = default;
            }

            if (SwitchButton_Alpha.Value)
            {
                e.AlphaAddress = (uint?)TextValueConverter.ValueFromText(TextBoxX_Alpha.Text);
            }
            else
            {
                e.AlphaAddress = default;
            }
        }

        private void SwitchButton_Light_ValueChanged(object sender, EventArgs e)
        {
            bool @checked = SwitchButton_Light.Value;
            TextBoxX_Light.Enabled = @checked;
            SwitchButton_LightMult.Enabled = @checked;
        }

        private void SwitchButton_Dark_ValueChanged(object sender, EventArgs e)
        {
            bool @checked = SwitchButton_Dark.Value;
            TextBoxX_Dark.Enabled = @checked;
            SwitchButton_DarkMult.Enabled = @checked;
        }

        private void SwitchButton_Alpha_ValueChanged(object sender, EventArgs e)
        {
            bool @checked = SwitchButton_Alpha.Value;
            TextBoxX_Alpha.Enabled = @checked;
        }

        private void RGBEditInfoEditor_Load(object sender, EventArgs e)
        {
            if (RGBEditInfo is null)
            {
                RGBEditInfo = new RGBEditor.RGBEditInfo() { Name = "Unknown" };
            }

            LoadRgbInfo();
        }

        private void RGBEditInfoEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRgbInfo();
        }
    }
}