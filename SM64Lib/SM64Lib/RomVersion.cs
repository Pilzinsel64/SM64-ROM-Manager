using System;
using global::Newtonsoft.Json;

namespace SM64Lib
{
    public struct RomVersion
    {
        [JsonProperty("Filename")]
#pragma warning disable IDE0044,CS0649 // Readonly-Modifizierer hinzufügen
        private string _Filename;
#pragma warning restore IDE0044,CS0649 // Readonly-Modifizierer hinzufügen

        public Version Version { get; set; }
        public int DevelopmentStage { get; set; }
        public int DevelopmentBuild { get; set; }

        [JsonIgnore]
        internal string Filename
        {
            get
            {
                return _Filename;
            }
        }

        public static bool operator !=(RomVersion left, RomVersion right)
        {
            return left.Version != right.Version && left.DevelopmentBuild != right.DevelopmentBuild && left.DevelopmentStage != right.DevelopmentStage;
        }

        public static bool operator ==(RomVersion left, RomVersion right)
        {
            return left.Version == right.Version && left.DevelopmentBuild == right.DevelopmentBuild && left.DevelopmentStage == right.DevelopmentStage;
        }

        public static bool operator >(RomVersion left, RomVersion right)
        {
            bool flag = left.Version > right.Version || left.Version == right.Version && left.DevelopmentStage < right.DevelopmentStage || left.Version == right.Version && left.DevelopmentStage == right.DevelopmentStage && left.DevelopmentBuild > right.DevelopmentBuild;
            return flag;
        }

        public static bool operator <(RomVersion left, RomVersion right)
        {
            return !(left >= right);
        }

        public static bool operator >=(RomVersion left, RomVersion right)
        {
            return left == right || left > right;
        }

        public static bool operator <=(RomVersion left, RomVersion right)
        {
            return left == right || left < right;
        }
    }
}