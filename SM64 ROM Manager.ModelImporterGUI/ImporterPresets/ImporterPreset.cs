using Newtonsoft.Json;
using Pilz.IO;
using SM64Lib.Patching;
using System;
using System.Collections.Generic;

namespace SM64_ROM_Manager.ModelImporterGUI.ImporterPresets
{
    public class ImporterProfile
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<ImporterPreset> Presets { get; } = new List<ImporterPreset>();
        [JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Version { get; set; } = new Version("1.0.0.0");
        [JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinVersion { get; set; } = new Version("1.0.0.0");
        [JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MaxVersion { get; set; } = new Version("0.0.0.0");
        public string FileName { get; set; } = "";
        public EmbeddedFilesContainer EmbeddedFiles { get; } = new EmbeddedFilesContainer();
    }

    public class ImporterPreset
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public PatchScript ScriptAfter { get; set; } = null;
        public PatchScript ScriptBefore { get; set; } = null;
        public int RomAddress { get; set; } = 0;
        public int RamAddress { get; set; } = 0;
        public int MaxLength { get; set; } = 0;
        public List<int> CollisionPointers { get; } = new List<int>();
        public List<int> GeometryPointers { get; } = new List<int>();
    }
}