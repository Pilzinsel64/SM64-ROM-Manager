using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Patching
{
    public class PPF
    {
        private readonly string applyPPFFilePath = null;

        public string ApplyPPFFilePath
        {
            get => applyPPFFilePath ?? General.MyFilePaths["ApplyPPF3.exe"];
        }

        public bool Enabled
        { get => !string.IsNullOrEmpty(ApplyPPFFilePath); }

        public PPF()
        {
        }

        public PPF(string applyPPFFilePath)
        {
            this.applyPPFFilePath = applyPPFFilePath;
        }

        public bool ApplyPatch(string romPath, string patchPath)
        {
            var args = string.Format("a \"{0}\" \"{1}\"", romPath, patchPath);
            return ExecuteApplyPPF(args);
        }

        private bool ExecuteApplyPPF(string arguments)
        {
            // Create process
            var proc = new Process();
            proc.StartInfo.FileName = ApplyPPFFilePath;
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
