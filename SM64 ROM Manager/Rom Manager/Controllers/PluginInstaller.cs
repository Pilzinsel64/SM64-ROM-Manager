using System;
using System.Collections.Generic;
using System.Diagnostics;
using global::System.IO;
using global::System.IO.Compression;
using System.Linq;
using global::System.Reflection;
using global::Pilz.Reflection.PluginSystem;
using global::SM64_ROM_Manager.SettingsManager;
using Z.Collections.Extensions;
using Z.IO.Extensions;

namespace SM64_ROM_Manager
{
    public static class PluginInstaller
    {
        public static IEnumerable<PluginInfo> GetAllPlugins()
        {
            var list = new List<PluginInfo>();
            foreach (var kvp in Publics.General.PluginManager.Plugins)
                list.Add(new PluginInfo(kvp.Value));
            return list;
        }

        public static void RemovePlugin(PluginInfo plugin)
        {
            var allPlugins = GetAllPlugins();
            string pluginDir = Path.GetDirectoryName(plugin.Location);
            var asmWantToRemove = new List<AssemblyName>() { plugin.Plugin.Assembly.GetName() };
            var asmToRemove = new List<AssemblyName>();
            var filesToRemove = new List<string>();
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();

            // Check what should be removed
            foreach (var @ref in plugin.Plugin.Assembly.GetReferencedAssemblies())
            {
                foreach (Assembly asm in loadedAssemblies)
                {
                    if ((asm.FullName ?? "") == (@ref.FullName ?? ""))
                    {
                        asmWantToRemove.Add(asm.GetName());
                    }
                }
            }

            // Check for references assemblies
            foreach (AssemblyName asm in asmWantToRemove.ToArray())
            {
                foreach (PluginInfo p in allPlugins)
                {
                    foreach (var @ref in p.Plugin.Assembly.GetReferencedAssemblies())
                    {
                        if (!asmToRemove.Contains(asm) && (@ref.FullName ?? "") == (asm.FullName ?? ""))
                        {
                            if ((asm.FullName ?? "") == (plugin.Plugin.Assembly.FullName ?? ""))
                            {
                                throw new InvalidOperationException("This Plugin can't be removed since it is used by an other Plugin.");
                            }
                            else
                            {
                                asmWantToRemove.Remove(asm);
                            }
                        }
                        else
                        {
                            asmToRemove.Add(asm);
                        }
                    }
                }
            }

            // Check what assemblies are loaded and can be removed
            foreach (AssemblyName asmName in asmToRemove)
            {
                var asm = loadedAssemblies.FirstOrDefault(n => (n.FullName ?? "") == (asmName.FullName ?? ""));
                if (asm is object && Path.GetDirectoryName(asm.Location).Contains(Publics.General.MyPluginsPath))
                {
                    filesToRemove.AddIfNotContains(asm.Location);
                }
            }

            // Remove files
            foreach (string f in filesToRemove)
                Settings.JobsToDo.Add(new JobToDo() { Type = JobToDoType.DeleteFile, Urgency = JobToDoUrgency.OnNextStartup, Params = new[] { f } });

            // Remove directory if empty
            if (Directory.GetFiles(pluginDir, string.Empty, SearchOption.AllDirectories).Length == filesToRemove.Count)
            {
                Settings.JobsToDo.Add(new JobToDo() { Type = JobToDoType.DeleteDirectory, Urgency = JobToDoUrgency.OnNextStartup, Params = new object[] { pluginDir, true } });
            }
        }

        public static (string destinationPath, bool isDirectory) InstallPluginFrom(string filePath, bool isFolder)
        {
            void throwIsAlreadyInstalled() { throw new InvalidOperationException("This plugin (or an other version of it) is already installed!"); };
            string destPath = Path.Combine(Publics.General.MyPluginsPath, Path.GetFileName(filePath));
            bool isDirectory = true;
            if (isFolder)
            {
                var dirInfo = new DirectoryInfo(destPath);
                if (dirInfo.Exists)
                {
                    throwIsAlreadyInstalled();
                }

                dirInfo.CopyTo(destPath, SearchOption.AllDirectories);
            }
            else
            {
                if (File.Exists(destPath))
                {
                    throwIsAlreadyInstalled();
                }

                var switchExpr = Path.GetExtension(filePath).ToLower();
                switch (switchExpr)
                {
                    case ".zip":
                        {
                            ZipFile.ExtractToDirectory(filePath, destPath);
                            break;
                        }

                    case ".dll":
                        {
                            var asm = Assembly.ReflectionOnlyLoadFrom(filePath);
                            foreach (PluginInfo pi in GetAllPlugins())
                            {
                                if ((pi.Plugin.Assembly.FullName ?? "") == (asm.FullName ?? ""))
                                {
                                    throwIsAlreadyInstalled();
                                }
                            }

                            File.Copy(filePath, destPath);
                            isDirectory = false;
                            break;
                        }
                }
            }

            return (destPath, isDirectory);
        }

        public class PluginInfo
        {
            public Plugin Plugin { get; private set; }
            public string Name { get; private set; }
            public Version Version { get; private set; }
            public string Developer { get; private set; }
            public string Location { get; private set; }

            public PluginInfo(Plugin p)
            {
                Plugin = p;
                var asmName = p.Assembly.GetName();
                Name = asmName.Name;
                Version = asmName.Version;
                var fvi = FileVersionInfo.GetVersionInfo(p.Assembly.Location);
                Developer = fvi.CompanyName;
                Location = p.Assembly.Location;
            }
        }
    }
}