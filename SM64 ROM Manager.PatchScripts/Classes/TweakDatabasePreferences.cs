using System.Collections.Generic;
using global::System.IO;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.PatchScripts
{
    public class TweakDatabasePreferences
    {
        public Dictionary<TweakDatabaseCategories, string> CategoryPaths { get; set; }
        public Dictionary<TweakDatabaseLoginTypes, TweakDatabaseLoginPreferences> Logins { get; set; }

        public static TweakDatabasePreferences Load(string filePath)
        {
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<TweakDatabasePreferences>();
        }
    }
}