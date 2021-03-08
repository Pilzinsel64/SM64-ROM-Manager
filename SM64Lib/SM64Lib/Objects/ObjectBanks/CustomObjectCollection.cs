using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Json;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Collections.Extensions;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectCollection
    {
        public List<CustomObject> CustomObjects { get; } = new List<CustomObject>();

        public void TakeoverProperties(RomManager rommgr)
        {
            foreach (var cobj in CustomObjects)
                cobj.TakeoverProperties(rommgr);
        }

        public void Export(string filePath, CustomObjectExportOptions options)
        {
            Export(filePath, CustomObjects.ToArray(), options);
        }

        public static void Export(string filePath, CustomObject customObject, CustomObjectExportOptions options)
        {
            Export(filePath, new CustomObject[] { customObject }, options);
        }

        public static void Export(string filePath, CustomObject[] customObjects, CustomObjectExportOptions options)
        {
            var export = new CustomObjectExport()
            {
                ExportDate = DateTime.UtcNow,
                Name = options.ExportName
            };
            export.Data.CustomObjects.AddRange(customObjects);
            export.Data.EmbeddedFiles = options.EmbeddedFiles;
            export.Data.Script = options.Script;

            foreach (var cobj in customObjects)
            {
                if (cobj.BehaviorProps.Behavior is object && !cobj.BehaviorProps.Behavior.IsVanilla)
                {
                    var behav = cobj.BehaviorProps.Behavior.FindBehavior();
                    if (behav is object)
                        export.Data.Behaviors.AddIfNotContainsKey(cobj.BehaviorProps.Behavior, behav);
                }

                if (cobj.ModelProps is object)
                {
                    var mdl = cobj.ModelProps.Model?.FindModel();
                    if (mdl is object)
                        export.Data.CustomModels.AddIfNotContainsKey(cobj.ModelProps.Model, mdl);
                }
            }

            export.Compress();
            export.ID.Generate();

            File.WriteAllText(filePath, JObject.FromObject(export).ToString());
        }

        public static CustomObjectImport LoadImport(string filePath)
        {
            var ser = JsonSerializer.CreateDefault();
            ser.PreserveReferencesHandling = PreserveReferencesHandling.All;
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<CustomObjectImport>(ser);
        }

        public static void DecompressImports(CustomObjectImport[] imports)
        {
            foreach (var import in imports)
                DecompressImport(import);
        }

        public static void DecompressImport(CustomObjectImport import)
        {
            import.Decompress();
        }

        public void Import(CustomObjectImport import)
        {
            // Decompress import
            DecompressImport(import);
            
            foreach (var cobj in import.Data.CustomObjects)
            {
                if (!import.IgnoreCustomObjects.Contains(cobj))
                {
                    // Add Custom Model
                    if (cobj.BehaviorProps.Behavior is object)
                    {
                        if (cobj.BehaviorProps.Behavior.IsVanilla)
                        {
                            var behav = import.DestBehaviorBank.GetBehaviorByBankAddress(cobj.BehaviorProps.BehaviorAddress);
                            cobj.BehaviorProps.Behavior = behav.Config;
                        }
                        else if (import.Data.Behaviors.ContainsKey(cobj.BehaviorProps.Behavior))
                        {
                            var behav = import.Data.Behaviors[cobj.BehaviorProps.Behavior];
                            import.DestBehaviorBank.Behaviors.Add(behav);

                            if (behav.Config.CustomAsmLinks.Any())
                            {
                                import.DestCustomAsmBank.Areas.AddRangeIfNotContains(behav.Config.CustomAsmLinks.Select(n => n.CustomAsm).ToArray());
                                import.DestCustomAsmBank.UpdateAreaConfigCollection();
                            }

                            behav.ParseScript();
                            cobj.BehaviorProps.BehaviorAddress = -1;
                        }
                    }

                    // Add Custom Behavior
                    if (cobj.ModelProps.Model is object && import.Data.CustomModels.ContainsKey(cobj.ModelProps.Model) && import.DestModelBanks.ContainsKey(cobj.ModelProps.Model))
                    {
                        var destModelBank = import.DestModelBanks[cobj.ModelProps.Model];
                        destModelBank.Models.Add(import.Data.CustomModels[cobj.ModelProps.Model]);
                        destModelBank.NeedToSave = true;
                    }

                    // Add Custom Object
                    CustomObjects.Add(cobj);
                }
            }
        }
    }
}
