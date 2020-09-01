using System;
using System.Collections.Generic;
using System.IO;
using global::System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Pilz.IO;
using Pilz.Cryptography;
using Pilz.Json.Converters;

namespace SM64Lib.Patching
{
    public class PatchProfile
    {
        /// <summary>
        /// The Name of the Profile.
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; } = "";
        /// <summary>
        /// A list with scripts.
        /// </summary>
        /// <returns></returns>
        public List<PatchScript> Scripts { get; set; } = new List<PatchScript>();
        /// <summary>
        /// The version of this profile.
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; } = new Version("1.0.0.0");
        /// <summary>
        /// The minimum ROM Manager version requied for this tweak.
        /// </summary>
        [JsonConverter(typeof(VersionConverter))]
        public Version MinVersion { get; set; } = new Version("1.0.0.0");
        /// <summary>
        /// The maximum ROM Manager version allowed for this tweak.
        /// </summary>
        [JsonConverter(typeof(VersionConverter))]
        public Version MaxVersion { get; set; } = new Version("0.0.0.0");
        /// <summary>
        /// The description of this profile
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; } = "";
        /// <summary>
        /// The Xml file for this profile.
        /// </summary>
        /// <returns></returns>
        [JsonIgnore]
        public string FileName { get; set; } = "";
        /// <summary>
        /// Indicates if this patch use the old XML format.
        /// </summary>
        [JsonIgnore]
        public bool IsLegacy { get => Path.GetExtension(FileName).ToLower() == ".xml"; }
        /// <summary>
        /// Contains files embedded into this profile.
        /// </summary>
        public EmbeddedFilesContainer EmbeddedFiles { get; } = new EmbeddedFilesContainer();
        /// <summary>
        /// Defines an uniquie ID to identify this tweak (e.g. for undo patch).
        /// </summary>
        [JsonConverter(typeof(UniquiIDStringJsonConverter<PatchProfile>))]
        public UniquieID<PatchProfile> ID { get; set; } = new UniquieID<PatchProfile>();
    }

    /// <summary>
    /// A Profile containing a script and some descriptions.
    /// </summary>
    public class PatchScript
    {
        /// <summary>
        /// The Name of this Script.
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; } = "";
        /// <summary>
        /// The Script.
        /// </summary>
        /// <returns></returns>
        public string Script { get; set; } = "";
        /// <summary>
        /// Defines the syntax of the script.
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringEnumConverter))]
        public ScriptType Type { get; set; } = ScriptType.TweakScript;
        /// <summary>
        /// The description of this Script.
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; } = "";
        /// <summary>
        /// A collection of Reference Assemblies to bind at compiling script.
        /// </summary>
        /// <returns></returns>
        public StringCollection References { get; set; } = new StringCollection();
        /// <summary>
        /// Defines an uniquie ID to identify this script (e.g. for undo patch).
        /// </summary>
        [JsonConverter(typeof(UniquiIDStringJsonConverter<PatchScript>))]
        public UniquieID<PatchScript> ID { get; set; } = new UniquieID<PatchScript>();
    }

    /// <summary>
    /// Defines the script type, so the behavior on write it.
    /// </summary>
    public enum ScriptType
    {
        /// <summary>
        /// A tweak syntax known from the SM64 Editor.
        /// </summary>
        TweakScript,
        /// <summary>
        /// A Visual Basic code.
        /// </summary>
        VisualBasic,
        /// <summary>
        /// A C# Code.
        /// </summary>
        CSharp,
        /// <summary>
        /// A DLL file containing the Code.
        /// </summary>
        DynamicLinkLibrary,
        /// <summary>
        /// Code that can be applied using Armips.
        /// </summary>
        Armips
    }
}