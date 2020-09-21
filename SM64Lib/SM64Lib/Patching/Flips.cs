using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Patching
{
    public class Flips
    {
        private readonly string flipsFilePath = null;

        public static string FlipsFilePath
        {
            get => FlipsFilePath ?? General.MyFilePaths["Flips.exe"];
        }

        public static bool Enabled
        { get => !string.IsNullOrEmpty(FlipsFilePath); }

        public Flips()
        {
        }

        public Flips(string flipsFilePath) : this()
        {
            this.flipsFilePath = flipsFilePath;
        }

        public bool CreatePatch(string originalRomPath, string patchedRomPath, string patchPath, FlipsPatchType patchType)
        {
            return ExecuteFlips($"--create {GetArgumentParameter(patchType)} \"{originalRomPath}\" \"{patchedRomPath}\" \"{patchPath}\"");
        }

        public bool ApplyPatch(string romPath, string patchPath)
        {
            return ExecuteFlips($"--apply \"{patchPath}\" \"{romPath}\"");
        }

        public static string GetExtension(FlipsPatchType patchType)
        {
            string ext;

            switch (patchType)
            {
                case FlipsPatchType.IPS:
                    ext = ".ips";
                    break;
                case FlipsPatchType.BPS:
                    ext = ".bps";
                    break;
                default:
                    ext = string.Empty;
                    break;
            }

            return ext;
        }

        private static string GetArgumentParameter(FlipsPatchType patchType)
        {
            string ext;

            switch (patchType)
            {
                case FlipsPatchType.IPS:
                    ext = "--ips";
                    break;
                case FlipsPatchType.BPS:
                    ext = "--bps";
                    break;
                default:
                    ext = string.Empty;
                    break;
            }

            return ext;
        }

        private static bool ExecuteFlips(string arguments)
        {
            // Create process
            var proc = new Process();
            proc.StartInfo.FileName = FlipsFilePath;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.CreateNoWindow = true;

            // Execute
            proc.Start();
            proc.WaitForExit();

            // Check for errors
            var success = proc.ExitCode == 0;

            return success;
        }
    }
}
