using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Collections.Extensions;

namespace SM64_ROM_Manager.SettingsManager
{
    public class DiagnosticDataStruc
    {
        public const string KEY_ALLOW_EXTENDED_SYSTEM_INFORMATIONS = "AllowExtendedSystemInformations";
        public const string KEY_CURRENTLY_OPEN_ROM = "CurrentlyOpenRom";
        public const string KEY_CURRENT_ROM_MANAGER_CONFIG = "CurrentRomManagerConfig";

        [JsonProperty]
        private readonly Dictionary<string, bool?> values = new Dictionary<string, bool?>();

        [JsonIgnore]
        public IReadOnlyDictionary<string, bool?> Values => values;

        public static string[] Keys { get; } = new string[]
        {
            KEY_ALLOW_EXTENDED_SYSTEM_INFORMATIONS,
            KEY_CURRENTLY_OPEN_ROM,
            KEY_CURRENT_ROM_MANAGER_CONFIG
        };

        [JsonIgnore]
        public bool? AllowExtendedSystemInformations
        {
            get => GetValue(KEY_ALLOW_EXTENDED_SYSTEM_INFORMATIONS);
            set => SetValue(KEY_ALLOW_EXTENDED_SYSTEM_INFORMATIONS, value);
        }

        [JsonIgnore]
        public bool? AllowCurrentlyOpenRom
        {
            get => GetValue(KEY_CURRENTLY_OPEN_ROM);
            set => SetValue(KEY_CURRENTLY_OPEN_ROM, value);
        }

        [JsonIgnore]
        public bool? AllowCurrentRomManagerConfig
        {
            get => GetValue(KEY_CURRENT_ROM_MANAGER_CONFIG);
            set => SetValue(KEY_CURRENT_ROM_MANAGER_CONFIG, value);
        }

        public bool? GetValue(string key)
        {
            if (values.ContainsKey(key))
                return values[key];
            else
                return null;
        }

        public void SetValue(string key, bool? value)
        {
            values.AddOrUpdate(key, value);
        }

        public void ResetValues()
        {
            values.Clear();
        }
    }
}
