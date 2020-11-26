using global::Newtonsoft.Json;
using Pilz.Cryptography;
using Pilz.Json.Converters;

namespace SM64_ROM_Manager.UserRequests
{
    public class UserRequestUploadSettings
    {
        internal SecureString Link { get; set; }
        internal SecureString Username { get; set; }
        internal SecureString Password { get; set; }
    }
}