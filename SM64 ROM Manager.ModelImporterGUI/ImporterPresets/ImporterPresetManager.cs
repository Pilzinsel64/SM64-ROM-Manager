using System;
using global::System.IO;
using System.Linq;
using System.Xml.Linq;

namespace SM64_ROM_Manager.ModelImporterGUI.ImporterPresets
{
    public class ImporterProfileManager
    {
        public void Save(ImporterProfile profile, string dir)
        {
            var psmgr = new PatchScripts.PatchingManager();
            XElement xml = XElement.Parse($"<m64custom name=\"{profile.Name}\" version=\"{profile.Version.ToString()}\"><description>{profile.Description}</description></m64custom>");
            foreach (ImporterPreset preset in profile.Presets)
            {
                XElement xpreset = XElement.Parse($"<preset name=\"{preset.Name}\"><description>{preset.Description}</description><max_length>{preset.MaxLength.ToString("X")}</max_length><rom_address>{preset.RomAddress.ToString("X")}</rom_address><ram_address>{preset.RamAddress.ToString("X")}</ram_address></preset>");
                if (preset.ScriptAfter is object)
                {
                    var xscript = psmgr.ScriptToXElement(preset.ScriptAfter);
                    xscript.Name = "script_after";
                    xpreset.Add(xscript);
                }
                
                if (preset.ScriptBefore is object)
                {
                    var xscript = psmgr.ScriptToXElement(preset.ScriptBefore);
                    xscript.Name = "script_before";
                    xpreset.Add(xscript);
                }

                XElement xcolpointer = XElement.Parse($"<collision_pointers></collision_pointers>");
                foreach (int colpointer in preset.CollisionPointers)
                    xcolpointer.Add(XElement.Parse($"<ptr>{colpointer.ToString("X")}</ptr>"));
                xpreset.Add(xcolpointer);
                XElement xgeopointer = XElement.Parse($"<geometry_pointers></geometry_pointers>");
                foreach (int geopointer in preset.GeometryPointers)
                    xgeopointer.Add(XElement.Parse($"<ptr>{geopointer.ToString("X")}</ptr>"));
                xpreset.Add(xgeopointer);
                xml.Add(xpreset);
            }

            if (string.IsNullOrEmpty(profile.FileName))
            {
                profile.FileName = Path.Combine(dir, profile.Name + ".xml");
            }

            xml.Save(profile.FileName);
        }

        public ImporterProfile Read(string fileName)
        {
            var profile = new ImporterProfile();
            var xml = XDocument.Load(fileName);
            var mainNode = xml.Elements().FirstOrDefault(n => n.Name == "m64custom");
            profile.FileName = fileName;
            foreach (XAttribute attr in mainNode.Attributes())
            {
                var switchExpr = attr.Name;
                switch (switchExpr)
                {
                    case var @case when @case == "name":
                        {
                            profile.Name = attr.Value;
                            break;
                        }

                    case var case1 when case1 == "description":
                        {
                            profile.Name = attr.Value;
                            break;
                        }

                    case var case2 when case2 == "version":
                        {
                            profile.Version = new Version(attr.Value);
                            break;
                        }
                }
            }

            var mainPreset = new ImporterPreset();
            bool mainPreset_EnableCollision = false;
            foreach (XElement element in mainNode.Elements())
            {
                var switchExpr1 = element.Name;
                switch (switchExpr1)
                {
                    case var case3 when case3 == "ram":
                        {
                            mainPreset.RamAddress = Convert.ToInt32(element.Value, 16);
                            break;
                        }

                    case var case4 when case4 == "rom":
                        {
                            mainPreset.RomAddress = Convert.ToInt32(element.Value, 16);
                            break;
                        }

                    case var case5 when case5 == "limit":
                        {
                            mainPreset.MaxLength = Convert.ToInt32(element.Value, 16) - mainPreset.RomAddress;
                            break;
                        }

                    case var case6 when case6 == "colpointer":
                        {
                            mainPreset.CollisionPointers.Add(Convert.ToInt32(element.Value, 16));
                            break;
                        }

                    case var case7 when case7 == "collision":
                        {
                            mainPreset_EnableCollision = (element.Value ?? "") != "0";
                            break;
                        }

                    case var case8 when case8 == "geometry":
                        {
                            mainPreset.GeometryPointers.Add(Convert.ToInt32(element.Value, 16));
                            break;
                        }

                    case var case9 when case9 == "extra":
                        {
                            var script = new PatchScripts.PatchScript();
                            script.Name = "Extra Data";
                            script.Type = PatchScripts.ScriptType.TweakScript;
                            script.Script = element.Value;
                            mainPreset.ScriptAfter = script;
                            break;
                        }

                    case var case10 when case10 == "preset":
                        {
                            mainPreset = null;
                            profile.Presets.Add(ParsePreset(element));
                            break;
                        }

                    case var case11 when case11 == "description":
                        {
                            profile.Description = element.Value;
                            break;
                        }
                }
            }

            if (mainPreset is object)
            {
                if (!mainPreset_EnableCollision)
                {
                    mainPreset.CollisionPointers.Clear();
                }

                profile.Presets.Add(mainPreset);
            }

            if (string.IsNullOrEmpty(profile.Name))
            {
                profile.Name = Path.GetFileNameWithoutExtension(fileName);
            }

            return profile;
        }

        private ImporterPreset ParsePreset(XElement xpreset)
        {
            var preset = new ImporterPreset();
            var psmgr = new PatchScripts.PatchingManager();
            foreach (XAttribute attr in xpreset.Attributes())
            {
                var switchExpr = attr.Name;
                switch (switchExpr)
                {
                    case var @case when @case == "name":
                        {
                            preset.Name = attr.Value;
                            break;
                        }
                }
            }

            foreach (XElement element in xpreset.Elements())
            {
                var switchExpr1 = element.Name;
                switch (switchExpr1)
                {
                    case var case1 when case1 == "description":
                        {
                            preset.Description = element.Value;
                            break;
                        }

                    case var case2 when case2 == "script":
                    case var case3 when case3 == "script_after":
                        {
                            preset.ScriptAfter = psmgr.XElementToScript(element);
                            break;
                        }

                    case var case4 when case4 == "script_before":
                        {
                            preset.ScriptBefore = psmgr.XElementToScript(element);
                            break;
                        }

                    case var case5 when case5 == "max_length":
                        {
                            preset.MaxLength = Convert.ToInt32(element.Value, 16);
                            break;
                        }

                    case var case6 when case6 == "rom_address":
                        {
                            preset.RomAddress = Convert.ToInt32(element.Value, 16);
                            break;
                        }

                    case var case7 when case7 == "ram_address":
                        {
                            preset.RamAddress = Convert.ToInt32(element.Value, 16);
                            break;
                        }

                    case var case8 when case8 == "collision_pointers":
                        {
                            foreach (XElement xptr in element.Elements())
                                preset.CollisionPointers.Add(Convert.ToInt32(xptr.Value, 16));
                            break;
                        }

                    case var case9 when case9 == "geometry_pointers":
                        {
                            foreach (XElement xptr in element.Elements())
                                preset.GeometryPointers.Add(Convert.ToInt32(xptr.Value, 16));
                            break;
                        }
                }
            }

            return preset;
        }
    }
}