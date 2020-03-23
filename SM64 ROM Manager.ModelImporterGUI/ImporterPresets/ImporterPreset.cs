using System;
using System.Collections.Generic;

namespace SM64_ROM_Manager.ModelImporterGUI.ImporterPresets
{
    public class ImporterProfile
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<ImporterPreset> Presets { get; private set; } = new List<ImporterPreset>();
        public Version Version { get; set; } = new Version("1.0.0.0");
        public string FileName { get; set; } = "";
    }

    public class ImporterPreset
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public PatchScripts.PatchScript ScriptAfter { get; set; } = null;
        public PatchScripts.PatchScript ScriptBefore { get; set; } = null;
        public int RomAddress { get; set; } = 0;
        public int RamAddress { get; set; } = 0;
        public int MaxLength { get; set; } = 0;
        public List<int> CollisionPointers { get; private set; } = new List<int>();
        public List<int> GeometryPointers { get; private set; } = new List<int>();
    }
}