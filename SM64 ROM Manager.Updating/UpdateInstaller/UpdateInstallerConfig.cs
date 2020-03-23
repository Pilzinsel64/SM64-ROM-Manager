using System;
using global::System.Drawing;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.Updating.UpdateInstaller
{
    public class UpdateInstallerConfig
    {
        public string PackagePath { get; set; }
        public bool RestartHostApplication { get; set; }
        public string RestartHostApplicationArguments { get; set; }
        public string ApplicationName { get; set; }
        public string HostApplicationPath { get; set; }
        public string HostApplicationProcessPath { get; set; }
        public bool ForceClosingHostApplication { get; set; }
        public uint MillisecondsToWaitForHostApplicationToClose { get; set; }
        public Color UpdateWindowBaseColor { get; set; }
        public Color UpdateWindowCanvasColor { get; set; }
        public ApplicationVersion CurrentApplicationVersion { get; set; }
        public ApplicationVersion NewApplicationVersion { get; set; }

        public static UpdateInstallerConfig Parse(string str)
        {
            return JObject.Parse(System.Text.Encoding.Default.GetString(Convert.FromBase64String(str))).ToObject<UpdateInstallerConfig>();
        }

        public override string ToString()
        {
            return Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(JObject.FromObject(this).ToString()));
        }
    }
}