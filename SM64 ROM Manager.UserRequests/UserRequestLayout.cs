using global::System.IO;
using global::Newtonsoft.Json;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.UserRequests
{
    public class UserRequestLayout
    {

        // F i e l d s

        [JsonProperty]
        internal string Name { get; set; }
        [JsonProperty]
        internal UserRequestProperty[] Properties { get; set; }
        [JsonProperty]
        internal UserRequestUploadSettings UploadSettings { get; set; }

        // C o n s t r u c t o r

        private UserRequestLayout()
        {
        }

        // S h a r e d   F e a t u r e s

        public static UserRequestLayout LoadFrom(string filePath)
        {
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var layout = LoadFrom(fs);
            fs.Close();
            return layout;
        }

        public static UserRequestLayout LoadFrom(Stream stream)
        {
            var reader = new StreamReader(stream);
            var style = JObject.Parse(reader.ReadToEnd()).ToObject<UserRequestLayout>();
            reader.Close();
            return style;
        }
    }
}