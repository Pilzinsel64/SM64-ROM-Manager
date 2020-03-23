using global::Pilz.S3DFileParser;

namespace SM64_ROM_Manager.SettingsManager
{
    public class FileParserSettingsStruc
    {

        // Public Property LoaderModule As Integer = S3DFileParser.LoaderModule
        public string FileLoaderModule { get; set; }
        public string FileExporterModule { get; set; }
        public UpAxis UpAxis { get; set; }

        public void ResetValues()
        {
            // LoaderModule = S3DFileParser.LoaderModule.Assimp
            FileLoaderModule = "#1";
            FileExporterModule = "#0";
            UpAxis = UpAxis.Y;
        }
    }
}