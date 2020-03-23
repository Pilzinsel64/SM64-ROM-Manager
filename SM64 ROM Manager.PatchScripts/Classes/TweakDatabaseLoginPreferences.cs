using global::Newtonsoft.Json;

namespace SM64_ROM_Manager.PatchScripts
{
    public class TweakDatabaseLoginPreferences
    {
        private static drsPwEnc.drsPwEnc crypter = new drsPwEnc.drsPwEnc();
#pragma warning disable CS0649 // Readonly-Modifizierer hinzufügen
        [JsonProperty(nameof(Link))]
        private string encryptedLink;
        [JsonProperty(nameof(Username))]
        private string encryptedUsername;
        [JsonProperty(nameof(Password))]
        private string encryptedPassword;
#pragma warning restore CS0649 // Readonly-Modifizierer hinzufügen

        [JsonIgnore]
        public string Link
        {
            get
            {
                return crypter.DecryptData(encryptedLink);
            }
        }

        [JsonIgnore]
        public string Username
        {
            get
            {
                return crypter.DecryptData(encryptedUsername);
            }
        }

        [JsonIgnore]
        public string Password
        {
            get
            {
                return crypter.DecryptData(encryptedPassword);
            }
        }
    }
}