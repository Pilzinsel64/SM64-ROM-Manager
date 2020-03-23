using global::System.Drawing;

namespace SM64Lib.Levels
{
    public class AreaBG
    {
        public AreaBGs Type { get; set; } = AreaBGs.Levelbackground;
        public Color Color { get; set; } = Color.Black;
    }

    public enum AreaBGs
    {
        Levelbackground,
        Color
    }
}