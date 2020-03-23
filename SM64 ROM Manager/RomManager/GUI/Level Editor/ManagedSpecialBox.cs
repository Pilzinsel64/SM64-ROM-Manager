using global::System.ComponentModel;
using global::SM64Lib.Levels;

namespace SM64_ROM_Manager.LevelEditor
{
    public class ManagedSpecialBox
    {
        [Browsable(false)]
        public SpecialBox SpecialBox { get; private set; }
        public SpecialBoxType Type { get; set; }
        public short X1 { get; set; } = 8192;
        public short Z1 { get; set; } = 8192;
        public short X2 { get; set; } = -8192;
        public short Z2 { get; set; } = -8192;
        public short Y { get; set; } = 0;
        public short Scale { get; set; } = 16;
        public bool InvisibleWater { get; set; } = false;
        public WaterType WaterType { get; set; } = WaterType.Default;
        public byte Alpha { get; set; } = 78;

        public ManagedSpecialBox(SpecialBox sb)
        {
            SpecialBox = sb;
            Load();
        }

        public void Save()
        {
            SpecialBox.Type = Type;
            SpecialBox.X1 = X1;
            SpecialBox.Z1 = Z1;
            SpecialBox.X2 = X2;
            SpecialBox.Z2 = Z2;
            SpecialBox.Y = Y;
            SpecialBox.Scale = Scale;
            SpecialBox.InvisibleWater = InvisibleWater;
            SpecialBox.WaterType = WaterType;
            SpecialBox.Alpha = Alpha;
        }

        public void Load()
        {
            Type = SpecialBox.Type;
            X1 = SpecialBox.X1;
            Z1 = SpecialBox.Z1;
            X2 = SpecialBox.X2;
            Z2 = SpecialBox.Z2;
            Y = SpecialBox.Y;
            Scale = SpecialBox.Scale;
            InvisibleWater = SpecialBox.InvisibleWater;
            WaterType = SpecialBox.WaterType;
            Alpha = SpecialBox.Alpha;
        }
    }
}