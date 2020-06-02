
namespace SM64Lib.Model.Collision
{
    public class BoxData
    {
        public BoxDataType Type { get; set; } = BoxDataType.Water;
        public short X1 { get; set; }
        public short X2 { get; set; }
        public short Z1 { get; set; }
        public short Z2 { get; set; }
        public short Y { get; set; }

        public BoxData()
        {
            X1 = 8192;
            X2 = -8192;
            Z1 = 8192;
            Z2 = -8192;
            Y = 0;
        }

        public BoxData(Levels.SpecialBox SpecialBox, short Y)
        {
            X1 = SpecialBox.X1;
            X2 = SpecialBox.X2;
            Z1 = SpecialBox.Z1;
            Z2 = SpecialBox.Z2;
            this.Y = Y;
        }

        public BoxData(BoxData WaterBox)
        {
            X1 = WaterBox.X1;
            X2 = WaterBox.X2;
            Z1 = WaterBox.Z1;
            Z2 = WaterBox.Z2;
            Y = WaterBox.Y;
        }
    }
}