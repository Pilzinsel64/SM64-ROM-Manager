using System;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Levels;
using DevComponents.DotNetBar.Controls;

namespace SM64_ROM_Manager
{
    public partial class Form_AddSpecialItem
    {
        public Form_AddSpecialItem(ref SpecialBox SpecialBox)
        {
            base.Load += Form_AddSpecialItem_Load;
            InitializeComponent();
            StyleManager.UpdateAmbientColors(this);
            wType = WindowType.SpecialBox;
            specialData = SpecialBox;
            {
                var withBlock = specialData;
                IntegerInput_Alpha.Value = Conversions.ToInteger(Math.Round(withBlock.Alpha / (double)255 * 100));
                IntegerInput_Scale.Value = withBlock.Scale;
                LabelX_Height.Text = string.Format("Height: {0}", SpecialBox.Y);
                LabelX_Pos1.Text = string.Format("Edge 1: {0}, {1}", withBlock.X1, withBlock.Z1);
                LabelX_Pos2.Text = string.Format("Edge 2: {0}, {1}", withBlock.X2, withBlock.Z2);
            }

            var switchExpr = SpecialBox.WaterType;
            switch (switchExpr)
            {
                case WaterType.Default:
                        ComboBox_WaterType.SelectedIndex = SpecialBox.InvisibleWater ? 1 : 0;
                        break;
                case WaterType.JRBWater:
                        ComboBox_WaterType.SelectedIndex = 2;
                        break;
                case WaterType.GreenWater:
                        ComboBox_WaterType.SelectedIndex = 3;
                        break;
                case WaterType.LavaWater:
                        ComboBox_WaterType.SelectedIndex = 4;
                        break;
            }

            var switchExpr1 = SpecialBox.Type;
            switch (switchExpr1)
            {
                case SpecialBoxType.Water:
                        CheckBoxX_Water.Checked = true;
                        break;
                case SpecialBoxType.ToxicHaze:
                        CheckBoxX_ToxicHaze.Checked = true;
                        break;
                case SpecialBoxType.Mist:
                        CheckBoxX_Mist.Checked = true;
                        break;
            }
        }

        public Form_AddSpecialItem(WindowType Type)
        {
            base.Load += Form_AddSpecialItem_Load;
            InitializeComponent();
            base.UpdateAmbientColors();
            wType = Type;
            CheckBoxX_Water.Checked = true;
        }

        public readonly WindowType wType = default;
        public readonly SpecialBox specialData;

        public enum WindowType
        {
            SpecialBox = 0,
            ScrollingTexture
        }

        private void Form_AddSpecialItem_Load(object sender, EventArgs e)
        {
            ComboBox_WaterType.SelectedIndex = 0;
            IntegerInput_Scale.Value = 16;
        }

        private void CheckBoxX_SpecialBoxType_CheckedChanged(object sender, DevComponents.DotNetBar.Controls.CheckBoxXChangeEventArgs e)
        {
            if (!((CheckBoxX)sender).Checked)
                return;
            switch (true)
            {
                case object _ when CheckBoxX_Water.Checked:
                    {
                        specialData.Type = SpecialBoxType.Water;
                        break;
                    }

                case object _ when CheckBoxX_Mist.Checked:
                    {
                        specialData.Type = SpecialBoxType.Mist;
                        break;
                    }

                case object _ when CheckBoxX_ToxicHaze.Checked:
                    {
                        specialData.Type = SpecialBoxType.ToxicHaze;
                        break;
                    }
            }

            GroupBox_Box.Visible = CheckBoxX_Water.Checked || CheckBoxX_Mist.Checked || CheckBoxX_ToxicHaze.Checked;
        }

        private void Button_SelectTexture_Click(object sender, EventArgs e)
        {
            // Dim frm As New Form_CollisionEditor(Modelfile, Form_CollisionEditor_WindowType.SelectTexture, STData.MaterialName)
            // If frm.ShowDialog <> DialogResult.OK Then Return

            // STData.MaterialName = CType(frm.ListBoxAdv_Textures.Items(frm.cItemIndex), MtlTextureItem).Text
            // LabelX_Texture.Text = "Texture: " & STData.MaterialName
        }

        private void Button_SetUpPos1_Click(object sender, EventArgs e)
        {
            int xpos = 0;
            int zpos = 0;
            int pointnumber = 1;
            var switchExpr = sender.GetHashCode();
            switch (switchExpr)
            {
                case var @case when @case == Button_SetUpPos1.GetHashCode():
                    {
                        xpos = specialData.X1;
                        zpos = specialData.Z1;
                        pointnumber = 1;
                        break;
                    }

                case var case1 when case1 == Button_SetUpPos2.GetHashCode():
                    {
                        xpos = specialData.X2;
                        zpos = specialData.Z2;
                        pointnumber = 2;
                        break;
                    }
            }

            var frm = new Form_SetUpPoint("Box Edge " + Conversions.ToString(pointnumber), true, false, true, xpos, 0, zpos);
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            var switchExpr1 = sender.GetHashCode();
            switch (switchExpr1)
            {
                case var case2 when case2 == Button_SetUpPos1.GetHashCode():
                    {
                        specialData.X1 = Conversions.ToShort(frm.IntegerInput_X.Value);
                        specialData.Z1 = Conversions.ToShort(frm.IntegerInput_Z.Value);
                        LabelX_Pos1.Text = string.Format("Edge 1: {0}, {1}", specialData.X1, specialData.Z1);
                        break;
                    }

                case var case3 when case3 == Button_SetUpPos2.GetHashCode():
                    {
                        specialData.X2 = Conversions.ToShort(frm.IntegerInput_X.Value);
                        specialData.Z2 = Conversions.ToShort(frm.IntegerInput_Z.Value);
                        LabelX_Pos2.Text = string.Format("Edge 2: {0}, {1}", specialData.X2, specialData.Z2);
                        break;
                    }
            }
        }

        private void Button_SetUpHeight_Click(object sender, EventArgs e)
        {
            var frm = new Form_SetUpPoint("Box Height", false, true, false, 0, specialData.Y, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                specialData.Y = Conversions.ToShort(frm.IntegerInput_Y.Value);
                LabelX_Height.Text = string.Format("Height: {0}", specialData.Y);
            }
        }

        private void IntegerInput_Scale_ValueChanged(object sender, EventArgs e)
        {
            specialData.Scale = Conversions.ToShort(IntegerInput_Scale.Value);
        }

        private void ComboBox_WaterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specialData is null)
                return;
            specialData.InvisibleWater = ComboBox_WaterType.SelectedIndex == 1;
            var switchExpr = ComboBox_WaterType.SelectedIndex;
            switch (switchExpr)
            {
                case 0:
                case 1:
                    {
                        specialData.WaterType = WaterType.Default;
                        break;
                    }

                case 2:
                    {
                        specialData.WaterType = WaterType.JRBWater;
                        specialData.InvisibleWater = false;
                        break;
                    }

                case 3:
                    {
                        specialData.WaterType = WaterType.GreenWater;
                        specialData.InvisibleWater = false;
                        break;
                    }

                case 4:
                    {
                        specialData.WaterType = WaterType.LavaWater;
                        specialData.InvisibleWater = false;
                        break;
                    }
            }
        }

        private void CheckBoxX_Water_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_WaterType.Enabled = CheckBoxX_Water.Checked;
            LabelX1.Enabled = CheckBoxX_Water.Checked;
        }

        private void IntegerInput1_ValueChanged(object sender, EventArgs e)
        {
            specialData.Alpha = Conversions.ToByte(Math.Round(255 / (double)100 * IntegerInput_Alpha.Value));
        }

        private void Button_Okay_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}