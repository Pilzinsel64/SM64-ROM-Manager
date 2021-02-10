using Newtonsoft.Json.Linq;
using SM64_ROM_Manager.SettingsManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager
{
    class DiagnosticProtocol
    {
        public string CurrentStackTrace { get; set; }
        public string CurrentException { get; set; }
        public SystemInformations SystemInformations { get; set; } = new SystemInformations();

        public void CollectData(Exception currentException)
        {
            if (currentException is object)
                CurrentException = currentException.ToString();
            CurrentStackTrace = Environment.StackTrace;
            SystemInformations.CollectInformations();
        }

        public void SaveProtocolFile(string outputPath)
        {
			string tempPath = null;
			List<string> errorList = new List<string>();

			void addErrorMsg(string msg, Exception ex)
			{
				errorList.Add($"{msg}\n> {ex.Message}");
			};
			void copyFile(string source, string destFileName)
			{
				if (!string.IsNullOrEmpty(source) && File.Exists(source))
				{
					try
					{
						string projectFile = Path.Combine(tempPath, destFileName);
						File.Copy(source, projectFile);
					}
					catch (Exception ex)
					{
						addErrorMsg($"ERROR: Can not copy file '{Path.GetFileName(source)}'!", ex);
					}
				}
			}

			//Get random temp directory path
			var tempFile = Path.GetTempFileName();
			tempPath = Path.Combine(Path.GetDirectoryName(tempFile), Path.GetFileNameWithoutExtension(tempFile));
			File.Delete(tempFile);
			Directory.CreateDirectory(tempPath);

			//Copy ROMs with config
			if (Settings.DiagnosticData.AllowCurrentlyOpenRom.GetValueOrDefault())
            {
				foreach (SM64Lib.RomManager romManager in SM64Lib.RomManagerInstances.CurrentInstances)
				{
					var romFile = romManager.RomFile;
					copyFile(romFile, Path.GetFileName(romFile));
					var configFile = romManager.GetRomConfigFilePath();
					copyFile(configFile, Path.GetFileName(configFile));
				}
			}

			//Copy settings file
			if (Settings.DiagnosticData.AllowCurrentRomManagerConfig.GetValueOrDefault())
				copyFile(Settings.SettingsConfigFilePath, "Settings.json");

			//Save this file
			try
			{
				string protocolFile = Path.Combine(tempPath, "Protocol.json");
				File.WriteAllText(protocolFile, JObject.FromObject(this).ToString());
			}
			catch (Exception ex)
			{
				addErrorMsg("ERROR: Can not save the Protocol.json!", ex);
			}

			//Write error log
			if (errorList.Any())
			{
				string errorLogFilePath = Path.Combine(outputPath, "Error.txt");
				File.WriteAllLines(errorLogFilePath, errorList);
			}

			//Pack to file
			ZipFile.CreateFromDirectory(tempPath, tempFile);

			//Copy to output path
			File.Copy(tempFile, outputPath);

			//Delete temp files
			File.Delete(tempFile);
			Directory.Delete(tempPath, true);
		}
	}
}
