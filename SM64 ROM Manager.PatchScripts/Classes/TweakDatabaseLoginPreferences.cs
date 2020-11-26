using global::Newtonsoft.Json;
using Pilz.Cryptography;
using Pilz.Json.Converters;

namespace SM64_ROM_Manager.PatchScripts
{
    public class TweakDatabaseLoginPreferences
    {
        public SecureString Link { get; set; }
        public SecureString Username { get; set; }
        public SecureString Password { get; set; }
    }
}