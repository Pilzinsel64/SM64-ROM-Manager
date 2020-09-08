using System.Linq;
using global::DevComponents.DotNetBar;

namespace System.Drawing
{
    public static class Extensions
    {
        public static float GetAspectRatio(this Bitmap bmp)
        {
            return (float)(bmp.Height / (double)bmp.Width);
        }
    }
}

namespace System.Windows.Forms
{
    public static class Extensions
    {
        private readonly static Type[] ambientColorControlTypesBlackList = new[] { typeof(Panel) };

        public static void UpdateAmbientColors(this Control c)
        {
            StyleManager.UpdateAmbientColors(c);
        }
    }
}