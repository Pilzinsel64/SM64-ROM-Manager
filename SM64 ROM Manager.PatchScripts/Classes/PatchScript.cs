using System;
using System.Collections.Generic;
using global::System.Collections.Specialized;

namespace SM64_ROM_Manager.PatchScripts
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
        public Version Version { get; set; } = new Version("1.0.0.0");
        /// <summary>
        /// The description of this profile
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; } = "";
        /// <summary>
        /// The Xml file for this profile.
        /// </summary>
        /// <returns></returns>
        public string FileName { get; set; } = "";
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