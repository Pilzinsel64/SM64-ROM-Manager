using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager
{
    public class ListViewItemSpecial : ListViewItem
    {
        private SM64Lib.Levels.SpecialBox _Box;

        public SM64Lib.Levels.SpecialBox Box
        {
            get
            {
                return _Box;
            }
        }

        public ListViewItemSpecial(SM64Lib.Levels.SpecialBox BoxData, SM64Lib.Model.Collision.BoxData WaterData, int ItemNumber)
        {
            for (int i = 0; i <= 7; i++)
                SubItems.Add(new ListViewSubItem());
            AktuallisiereDaten(BoxData, WaterData, ItemNumber);
        }

        public void AktuallisiereDaten(SM64Lib.Levels.SpecialBox SpecialData, SM64Lib.Model.Collision.BoxData BoxData, int ItemNumber = 0)
        {
            _Box = SpecialData;
            if (ItemNumber > 0)
                Text = Conversions.ToString(ItemNumber);
            SubItems[1].Text = SpecialData.Type.ToString();
            SubItems[2].Text = Conversions.ToString(BoxData.X1);
            SubItems[3].Text = Conversions.ToString(BoxData.Z1);
            SubItems[4].Text = Conversions.ToString(BoxData.X2);
            SubItems[5].Text = Conversions.ToString(BoxData.Z2);
            SubItems[6].Text = Conversions.ToString(BoxData.Y);
            SubItems[7].Text = _Box.Type == SM64Lib.Levels.SpecialBoxType.Water ? _Box.InvisibleWater ? "Invisible" : _Box.WaterType.ToString() : "-";
        }
    }
}