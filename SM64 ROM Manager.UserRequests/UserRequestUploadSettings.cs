using global::Newtonsoft.Json;

namespace SM64_ROM_Manager.UserRequests
{
    public class UserRequestUploadSettings
    {
        [JsonProperty]
        internal string Link { get; set; }
        [JsonProperty]
        internal string Username { get; set; }
        [JsonProperty]
        internal string Password { get; set; }
    }
}