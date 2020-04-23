using Newtonsoft.Json;
using System;

namespace SM64_ROM_Manager.Updating
{
    public class ApplicationVersion
    {

        // P r o p e r t i e s

        [JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Version { get; set; }
        public int Build { get; set; }
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Channels Channel { get; set; }

        // C o n s t r u c t o r s

        public ApplicationVersion() : this(new Version("1.0.0.0"))
        {
        }

        public ApplicationVersion(Version version) : this(version, 1, Channels.Stable)
        {
        }

        public ApplicationVersion(Version version, int build, Channels channel)
        {
            Version = version;
            Build = build;
            Channel = channel;
        }

        // F e a t u r e s

        public override string ToString()
        {
            return $"{Version.ToString()} {Channel.ToString()} {Build}";
        }

        // O p e r a t o r s

        public static bool operator >(ApplicationVersion a, ApplicationVersion b)
        {
            return a.Version > b.Version || a.Version == b.Version && (a.Channel < b.Channel || a.Channel == b.Channel && a.Build > b.Build);
        }

        public static bool operator <(ApplicationVersion a, ApplicationVersion b)
        {
            return a.Version < b.Version || a.Version == b.Version && (a.Channel > b.Channel || a.Channel == b.Channel && a.Build < b.Build);
        }

        public static bool operator ==(ApplicationVersion a, ApplicationVersion b)
        {
            return !(a != b);
        }

        public static bool operator !=(ApplicationVersion a, ApplicationVersion b)
        {
            return a.Version != b.Version || a.Channel != b.Channel || a.Build != b.Build;
        }

        public static bool operator >=(ApplicationVersion a, ApplicationVersion b)
        {
            return a == b || a > b;
        }

        public static bool operator <=(ApplicationVersion a, ApplicationVersion b)
        {
            return a == b || a < b;
        }
    }
}