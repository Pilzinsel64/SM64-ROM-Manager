using System;
using global::System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using global::System.IO;
using System.Linq;
using global::System.Reflection;
using global::System.Windows.Forms;
using System.Xml.Linq;
using global::Microsoft.CSharp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;
using global::SM64Lib;
using Newtonsoft.Json.Linq;
using Pilz.IO;

namespace SM64Lib.Patching
{
    public class PatchingManager
    {
        public delegate void PatchScriptManagerProcessingInputValueEventHandler(object sender, PatchScriptManagerProcessingInputValueEventArgs e);
        public static event PatchScriptManagerProcessingInputValueEventHandler ProcessingInputValue;

        public void Save(PatchProfile patch, string dir)
        {
            // Check for old file extension and change it
            if (string.IsNullOrEmpty(patch.FileName))
            {
                patch.FileName = Path.Combine(dir, patch.Name + ".json");
            }
            else if (Path.GetExtension(patch.FileName) == ".xml")
            {
                var newFileName = Path.ChangeExtension(patch.FileName, ".json");
                File.Delete(patch.FileName);
                patch.FileName = newFileName;
            }

            // Generate profile ID if null
            patch.ID.GenerateIfNull();

            // Generate script IDs if null
            foreach (var script in patch.Scripts)
                script.ID.GenerateIfNull();

            // Write file
            File.WriteAllText(patch.FileName, JObject.FromObject(patch).ToString());
        }

        public PatchProfile Read(string fileName)
        {
            switch (Path.GetExtension(fileName))
            {
                case ".json":
                    var profile = JObject.Parse(File.ReadAllText(fileName)).ToObject<PatchProfile>();
                    profile.FileName = fileName;
                    return profile;
                case ".xml":
                    return ReadPatchProfileFromXml(fileName);
                default:
                    return null;
            }
        }

        private PatchProfile ReadPatchProfileFromXml(string fileName)
        {
            var patch = new PatchProfile();
            var xml = XDocument.Load(fileName);
            patch.FileName = fileName;
            var mainNode = xml.Elements().FirstOrDefault(n => n.Name == "m64tweak");
            foreach (XAttribute attr in mainNode.Attributes())
            {
                var switchExpr = attr.Name;
                switch (switchExpr)
                {
                    case var @case when @case == "name":
                        patch.Name = attr.Value;
                        break;
                    case var case1 when case1 == "description":
                        patch.Description = attr.Value;
                        break;
                    case var case2 when case2 == "version":
                        patch.Version = new Version(attr.Value);
                        break;
                }
            }

            foreach (XElement element in mainNode.Elements())
            {
                var switchExpr1 = element.Name;
                switch (switchExpr1)
                {
                    case var case3 when case3 == "name":
                        patch.Name = element.Value;
                        break;
                    case var case4 when case4 == "description":
                        patch.Description = element.Value;
                        break;
                    case var case5 when case5 == "patch":
                        patch.Scripts.Add(XElementToScript(element));
                        break;
                }
            }

            if (string.IsNullOrEmpty(patch.Name))
            {
                patch.Name = Path.GetFileNameWithoutExtension(fileName);
            }

            return patch;
        }

        public PatchScript XElementToScript(XElement element)
        {
            var script = new PatchScript();
            script.Script = element.Value;
            foreach (XAttribute attr in element.Attributes())
            {
                var switchExpr = attr.Name;
                switch (switchExpr)
                {
                    case var @case when @case == "name":
                        script.Name = attr.Value;
                        break;
                    case var case1 when case1 == "description":
                        script.Description = attr.Value;
                        break;
                    case var case2 when case2 == "type":
                        script.Type = (ScriptType)Convert.ToInt32(attr.Value);
                        break;
                    case var case3 when case3 == "references":
                        if (!string.IsNullOrEmpty(attr.Value))
                        {
                            script.References.AddRange(attr.Value.Split(';'));
                        }

                        break;
                }
            }

            return script;
        }

        public PatchScriptResult Patch(PatchScript script, IWin32Window owner, IReadOnlyDictionary<string, object> @params, string[] additionalAssemblyReferences, bool createUndoPatch = false)
        {
            return Patch(script, null, owner, @params, additionalAssemblyReferences, false);
        }

        public PatchScriptResult Patch(PatchScript script, RomManager rommgr, IWin32Window owner, IReadOnlyDictionary<string, object> @params, string[] additionalAssemblyReferences, bool createUndoPatch = false)
        {
            if (script is null)
                throw new ArgumentNullException(nameof(script));

            object oromfile = "";
            if (@params is null || !@params.TryGetValue("romfile", out oromfile))
                oromfile = rommgr.RomFile;

            string romfile = (string)oromfile;
            string romfileBackup = null;
            var result = new PatchScriptResult();
            var flips = new Flips();
            createUndoPatch &= script.AllowRevert && script.ID.HasID && flips.Enabled;

            if (createUndoPatch)
            {
                romfileBackup = Path.GetTempFileName();
                File.Copy(romfile, romfileBackup, true);
            }

            switch (script.Type)
            {
                case ScriptType.TweakScript:
                    {
                        var stream = new FileStream(romfile, FileMode.Open, FileAccess.ReadWrite);
                        var bw = new BinaryWriter(stream);
                        var br = new BinaryReader(stream);
                        var reader = new StringReader(script.Script);
                        while (reader.Peek() > -1)
                        {
                            string line = reader.ReadLine().Trim().ToLower();
                            int commentStart = line.IndexOf("//");
                            if (commentStart > -1)
                            {
                                line = line.Substring(0, commentStart);
                            }

                            if (string.IsNullOrEmpty(line.Trim()))
                            {
                                continue;
                            }

                            int nextDP = line.IndexOf(":");
                            string body = line.Substring(nextDP + 1).Trim();
                            if (nextDP > -1)
                            {
                                string addr;
                                addr = line.Substring(0, nextDP);
                                stream.Position = Convert.ToInt32(addr, 16);
                            }

                            int nextKlammer = body.IndexOf('[');
                            while (nextKlammer > -1)
                            {
                                int endKl = body.IndexOf(']', nextKlammer + 1);
                                string str = body.Substring(nextKlammer, endKl - nextKlammer + 1);
                                string newVal = "";
                                switch (true)
                                {
                                    case object _ when str.StartsWith("["):
                                        var parts = str.Substring(1, str.Length - 2).Split(','); // body.Substring(1, body.Length - 1).Split(",")
                                        if (parts.Count() > 0)
                                        {
                                            var switchExpr1 = parts[0].Trim();
                                            switch (switchExpr1)
                                            {
                                                case "copy":
                                                    {
                                                        if (parts.Count() > 1)
                                                        {
                                                            int startAddr = Convert.ToInt32(parts[1].Trim(), 16);
                                                            int endAddr = parts.Length > 2 ? Convert.ToInt32(parts[2].Trim(), 16) : startAddr + 1;
                                                            int length = endAddr - startAddr;
                                                            int lastPos = Conversions.ToInteger(stream.Position);
                                                            body = "";
                                                            stream.Position = startAddr;
                                                            for (int i = 1, loopTo = length; i <= loopTo; i++)
                                                                body += " " + br.ReadByte().ToString("X2");
                                                            stream.Position = lastPos;
                                                        }

                                                        break;
                                                    }

                                                case "fill":
                                                    {
                                                        if (parts.Count() > 2)
                                                        {
                                                            byte value = Convert.ToByte(parts[1].Trim(), 16);
                                                            string valueString = value.ToString("X2");
                                                            int length = Convert.ToInt32(parts[2].Trim(), 16);
                                                            body = "";
                                                            for (int i = 1, loopTo1 = length; i <= loopTo1; i++)
                                                                body += " " + valueString;
                                                        }

                                                        break;
                                                    }

                                                default:
                                                    {
                                                        var inputType = InputValueType.Byte;
                                                        var switchExpr2 = parts[0].Trim();
                                                        switch (switchExpr2)
                                                        {
                                                            case "8":
                                                                inputType = InputValueType.Byte;
                                                                break;
                                                            case "16":
                                                                inputType = InputValueType.UInt16;
                                                                break;
                                                            case "32":
                                                                inputType = InputValueType.UInt32;
                                                                break;
                                                            case "half":
                                                                inputType = InputValueType.Single;
                                                                break;
                                                            case "string":
                                                                inputType = InputValueType.String;
                                                                break;
                                                            case "sequence":
                                                                inputType = InputValueType.Sequence;
                                                                break;
                                                            case "level":
                                                                inputType = InputValueType.LevelID;
                                                                break;
                                                        }

                                                        var titel = parts.ElementAtOrDefault(1)?.Trim()?.Trim('"', '[', ']');
                                                        var processingEventArgs = new PatchScriptManagerProcessingInputValueEventArgs(inputType, titel, rommgr, owner);
                                                        ProcessingInputValue?.Invoke(this, processingEventArgs);

                                                        if (processingEventArgs.SettedValue)
                                                        {
                                                            if (inputType == InputValueType.String)
                                                            {
                                                                byte[] barr = System.Text.Encoding.ASCII.GetBytes((string)processingEventArgs.ReturnValue);
                                                                foreach (byte b in barr)
                                                                    newVal += b.ToString("X2");
                                                            }
                                                            else
                                                            {
                                                                string barr = string.Empty;
                                                                switch (inputType)
                                                                {
                                                                    case InputValueType.Byte:
                                                                    case InputValueType.Sequence:
                                                                        barr = Conversions.ToByte(processingEventArgs.ReturnValue).ToString("X2");
                                                                        break;
                                                                    case InputValueType.UInt16:
                                                                    case InputValueType.LevelID:
                                                                        barr = Conversions.ToUShort(processingEventArgs.ReturnValue).ToString("X4");
                                                                        break;
                                                                    case InputValueType.Single:
                                                                        barr = Data.System.SwapInts.SwapHalf(Convert.ToSingle(processingEventArgs.ReturnValue)).ToString("X4");
                                                                        break;
                                                                    case InputValueType.UInt32:
                                                                        barr = Conversions.ToUInteger(processingEventArgs.ReturnValue).ToString("X8");
                                                                        break;
                                                                }

                                                                for (int i = 0, loopTo2 = barr.Length - 1; i <= loopTo2; i += 2)
                                                                    newVal += " " + barr.Substring(i, 2);
                                                            }
                                                        }

                                                        body = body.Replace(str, newVal);
                                                        break;
                                                    }
                                            }
                                            break;
                                        }
                                        break;
                                    default:
                                        continue;
                                }

                                nextKlammer = body.IndexOf('[', nextKlammer + 1);
                            }

                            if (!string.IsNullOrEmpty(body))
                            {
                                foreach (string str in body.Split(' '))
                                {
                                    if (!string.IsNullOrWhiteSpace(str))
                                    {
                                        byte value = Convert.ToByte(str, 16);
                                        bw.Write(value);
                                    }
                                }
                            }
                        }

                        reader.Close();
                        stream.Close();
                        break;
                    }

                case ScriptType.VisualBasic:
                case ScriptType.CSharp:
                    {
                        var assembly = GetAssembly(script, additionalAssemblyReferences);
                        if (assembly is object)
                        {
                            ExecuteScript(assembly, @params);
                        }

                        break;
                    }

                case ScriptType.Armips:
                    {
                        RunArmips(script.Script, romfile, Path.GetDirectoryName(Conversions.ToString(@params["profilepath"])));
                        break;
                    }
            }

            if (createUndoPatch)
            {
                var ipsFile = Path.GetTempFileName();
                if (flips.CreatePatch(romfile, romfileBackup, ipsFile, FlipsPatchType.BPS))
                    rommgr?.RomConfig.PatchingConfig.TweakBackups.AddFile(GetUndoPatchFileNameOfScript(script), ipsFile);
                if (File.Exists(ipsFile))
                    File.Delete(ipsFile);
                File.Delete(romfileBackup);
            }

            General.PatchClass.UpdateChecksum(romfile);

            return result;
        }

        public CompilerResults CompileScript(PatchScript script, string[] additionalAssemblyReferences)
        {
            CodeDomProvider cp;
            var switchExpr = script.Type;
            switch (switchExpr)
            {
                case ScriptType.VisualBasic:
                    {
                        cp = new VBCodeProvider();
                        break;
                    }

                case ScriptType.CSharp:
                    {
                        cp = new CSharpCodeProvider();
                        break;
                    }

                default:
                    {
                        return null;
                    }
            }

            var options = new CompilerParameters();
            options.GenerateExecutable = false;
            options.GenerateInMemory = true;
            var switchExpr1 = script.Type;
            switch (switchExpr1)
            {
                case ScriptType.VisualBasic:
                    {
                        options.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
                        break;
                    }

                case ScriptType.CSharp:
                    {
                        options.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
                        break;
                    }
            }

            options.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            options.ReferencedAssemblies.Add("System.dll");
            options.ReferencedAssemblies.Add("System.Core.dll");
            options.ReferencedAssemblies.Add("System.Data.dll");
            options.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll");
            options.ReferencedAssemblies.Add("System.Deployment.dll");
            options.ReferencedAssemblies.Add("System.Net.Http.dll");
            options.ReferencedAssemblies.Add("System.Xml.dll");
            options.ReferencedAssemblies.Add("System.Xml.Linq.dll");
            options.ReferencedAssemblies.Add("System.IO.dll");
            options.ReferencedAssemblies.Add("System.Drawing.dll");
            options.ReferencedAssemblies.Add(typeof(Object3D).Assembly.Location);
            options.ReferencedAssemblies.Add(typeof(RomManager).Assembly.Location);
            options.ReferencedAssemblies.Add(typeof(EmbeddedFilesContainer).Assembly.Location);

            if (additionalAssemblyReferences is object)
                options.ReferencedAssemblies.AddRange(additionalAssemblyReferences);

            // Alternative???
            // For Each asm As Assembly In AppDomain.CurrentDomain.GetAssemblies
            // options.ReferencedAssemblies.Add(asm.Location)
            // Next

            foreach (string @ref in script.References)
            {
                if (!options.ReferencedAssemblies.Contains(@ref))
                {
                    options.ReferencedAssemblies.Add(@ref);
                }
            }

            return cp.CompileAssemblyFromSource(options, script.Script);
        }

        public Assembly GetAssembly(PatchScript script, string[] additionalAssemblyReferences)
        {
            var res = CompileScript(script, additionalAssemblyReferences);
            if (res.Errors.Count == 0)
            {
                return res.CompiledAssembly;
            }
            else
            {
                throw new SyntaxErrorException("Error hat compiling Script. Either there are syntax errors or there are missing some references.");
            }
        }

        public void ExecuteScript(Assembly assembly, IReadOnlyDictionary<string, object> @params)
        {
            var main = assembly.GetType("Script")?.GetMethod("Main", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            FileStream fs = null;
            var param = new object[] { null };
            var paraminfo = main.GetParameters();
            string romfile = "";
            object argvalue = romfile;
            @params.TryGetValue("romfile", out argvalue);
            if (paraminfo.Length == 1 && paraminfo[0].ParameterType == typeof(Stream) && !string.IsNullOrEmpty(romfile))
            {
                fs = new FileStream(romfile, FileMode.Open, FileAccess.ReadWrite);
                param = new object[] { fs };
            }
            else if (paraminfo.Length == 1 && paraminfo[0].ParameterType == typeof(string))
            {
                param = new object[] { romfile };
            }
            else if (paraminfo.Length == 1 && paraminfo[0].ParameterType == typeof(IReadOnlyDictionary<string, object>))
            {
                param = new object[] { @params };
            }

            if (main != null)
            {
                main.Invoke(null, param);
            }

            if (fs != null)
            {
                fs.Close();
            }
        }

        private static void RunArmips(string script, string filePath, string rootPath)
        {
            string createText =
$@".Open ""{filePath}"", 0
.n64
{script}
.Close";
            string tmpAsmFile = Path.GetTempFileName();
            File.WriteAllText(tmpAsmFile, createText);
            var p = new Process();
            p.StartInfo.FileName = Path.Combine(General.MyFilePaths["armips.exe"]);
            p.StartInfo.Arguments = $"-root \"{rootPath}\" \"{tmpAsmFile}\"";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            while (!p.HasExited)
            {
            }

            File.Delete(tmpAsmFile);
        }

        public static byte[] ConvertAsmToBytes(string script)
        {
            string tmpBinFile = Path.GetTempFileName();
            RunArmips(script, tmpBinFile, Path.GetDirectoryName(tmpBinFile));
            var bytes = File.ReadAllBytes(tmpBinFile);
            File.Delete(tmpBinFile);
            return bytes;
        }

        public static string GetUndoPatchFileNameOfScript(PatchScript script)
        {
            return $"patch-undo.{script.ID}";
        }

        public static bool HasUndoPatch(PatchScript script, RomManager rommgr)
        {
            var fileName = GetUndoPatchFileNameOfScript(script);
            return rommgr.RomConfig.PatchingConfig.TweakBackups.HasFile(fileName);
        }

        public static void ApplyUndoPatch(PatchScript script, RomManager rommgr, bool removeFileAfterPatching = true)
        {
            var fileName = GetUndoPatchFileNameOfScript(script);
            var filePath = rommgr.RomConfig.PatchingConfig.TweakBackups.GetLocalFilePath(fileName);

            var flips = new Flips();
            flips.ApplyPatch(rommgr.RomFile, filePath);

            if (removeFileAfterPatching)
                rommgr.RomConfig.PatchingConfig.TweakBackups.RemoveFile(fileName);

            File.Delete(filePath);

            General.PatchClass.UpdateChecksum(rommgr.RomFile);
        }
    }
}