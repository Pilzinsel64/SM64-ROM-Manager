using global::System.Drawing;
using global::System.IO;
using global::Newtonsoft.Json.Linq;
using global::SM64Lib.Model;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public class GuiInputPreferences
    {
        public double Scaling { get; set; } = 500.0F;
        public object ReduceDupVerts { get; set; } = ObjectInputSettings.ReduceDuplicateVerticesLevel.Level1;
        public Fog Fog { get; set; } = null;
        public bool ResizeTextures { get; set; } = true;
        public bool CenterModel { get; set; } = false;
        public Pilz.S3DFileParser.Shading Shading { get; private set; } = new Pilz.S3DFileParser.Shading() { AmbientColor = Color.FromArgb(unchecked((int)0xFF7F7F7F)), DiffuseColor = Color.FromArgb(unchecked((int)0xFFFFFFFF)), DiffusePosition = null };
        public bool OptimizeTransparencyChecks { get; set; } = false;

        public static GuiInputPreferences Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                return JObject.Parse(File.ReadAllText(filePath)).ToObject<GuiInputPreferences>();
            }
            else
            {
                return new GuiInputPreferences();
            }
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(this).ToString());
        }
    }
}