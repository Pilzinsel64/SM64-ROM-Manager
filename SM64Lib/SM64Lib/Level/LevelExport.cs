using Newtonsoft.Json;
using SM64Lib.Levels.Script;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Levels
{
    public class LevelExport
    {
        // P r o p e r t i e s

        [JsonProperty]
        public object Content { get; protected set; }
        [JsonProperty]
        public LevelExportContentType ContentType { get; set; }

        // C o n s t r u c t o r s

        private LevelExport(object content, LevelExportContentType type) : this()
        {
            Content = content;
            ContentType = type;
        }

        public LevelExport(Level level) : this(new  List<Level> { level }) { }
        public LevelExport(List<Level> levels) : this(levels, LevelExportContentType.Level) { }
        public LevelExport(LevelArea area) : this(new List<LevelArea> { area }) { }
        public LevelExport(List<LevelArea> areas) : this(areas, LevelExportContentType.Area) { }
        public LevelExport(List<LevelscriptCommand> cmds, LevelExportContentType contentType) : this((object)cmds, contentType) { }

        [JsonConstructor]
        private LevelExport() { }

        // F e a t u r e s

        public void WriteToFile(string filePath, CompressionLevel compressionLevel)
        {
            var plainText = compressionLevel == CompressionLevel.NoCompression;

            // Open streams
            var fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            var output = new DeflateStream(fs, compressionLevel, true);
            var sw = new StreamWriter(output);

            // Create serializer
            var serializer = Json.JsonHelper.CreateJsonSerializer(true, true, plainText);

            // Serialize
            serializer.Serialize(sw, this);

            sw.Flush();
            output.Close();
            fs.Close();
        }

        public static LevelExport ReadFromFile(string filePath)
        {
            // Open streams
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var input = new DeflateStream(fs, CompressionMode.Decompress);
            var sr = new StreamReader(input);
            
            // Create serializer
            var serializer = Json.JsonHelper.CreateJsonSerializer(true, true);

            // Deserialize
            var export = (LevelExport)serializer.Deserialize(sr, typeof(LevelExport));

            fs.Close();

            return export;
        }
    }
}
