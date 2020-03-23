using System;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64Lib;
using global::SM64Lib.Objects;

namespace SM64_ROM_Manager
{
    public partial class StarPositionEditor
    {

        private StarPosition curStar;
        private RomManager rommgr;

        public StarPositionEditor(RomManager rommgr)
        {
            base.Load += StarPositionEditor_Load;
            InitializeComponent();
            base.UpdateAmbientColors();
            this.rommgr = rommgr;
        }

        private void StarPositionEditor_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void ComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem item = (ComboItem)ComboBoxEx1.SelectedItem;
            curStar = new StarPosition((StarNames)item.Tag);
            curStar.Position = GetPosition();
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            curStar.Position = GetPosition();
            curStar.SavePosition(rommgr);
            General.PatchClass.UpdateChecksum(rommgr.RomFile);
            MessageBoxEx.Show(Star_Position_Editor_Resources.MsgBox_Done, Star_Position_Editor_Resources.MsgBox_Done_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Funktionen

        private System.Numerics.Vector3 GetPosition()
        {
            return new System.Numerics.Vector3(IntegerInput_X.Value, IntegerInput_Y.Value, IntegerInput_z.Value);
        }

        private void LoadList()
        {
            foreach (StarNames value in Enum.GetValues(typeof(StarNames)))
                ComboBoxEx1.Items.Add(new ComboItem() { Text = Conversions.ToString(GetTextOfStarName(value)), Tag = value });
            ComboBoxEx1.SelectedIndex = 0;
        }

        private object GetTextOfStarName(StarNames value)
        {
            switch (value)
            {
                case StarNames.KoopaTheQuick1:
                    return "Koopa-The-Quick #1";
                case StarNames.KoopaTheQuick2:
                    return "Koopa-The-Quick #2";
                case StarNames.KingBobOmbBoss:
                    return "Big Bob-Omb Boss";
                case StarNames.WhompBoss:
                    return "Whomp Boss";
                case StarNames.EyerockBoss:
                    return "Eyerock Boss";
                case StarNames.BigBullyBoss:
                    return "Big Bully Boss";
                case StarNames.ChillBullyBoss:
                    return "Chill Bully Boss";
                case StarNames.GiantPiranhaPlants:
                    return "Giant Piranha Plants";
                case StarNames.PenguinMother:
                    return "Penguin Mother and Race";
                case StarNames.WigglerBoss:
                    return "Wiggler Boss";
                case StarNames.PeachSlideStar:
                    return "Slide Star (Collision 33/34)";
                case StarNames.BigPenguinRace:
                    return "Penguin Mother and Race";
                case StarNames.TreasureChests:
                    return "4 Treasure Chests";
                case StarNames.BooInHauntedHouse:
                    return "First Big Boo";
                case StarNames.Klepto:
                    return "Klepto";
                case StarNames.MerryGoRoundboss:
                    return "Merry-Go-Round Boo";
                case StarNames.MrIboss:
                    return "Mr. I. Boss";
                case StarNames.RooftopBoo:
                    return "Rooftop Boo";
                case StarNames.SecondactBigBully:
                    return "Second Big Bully in LLL";
                default:
                    return "";
            }
        }

        #endregion
    }
}