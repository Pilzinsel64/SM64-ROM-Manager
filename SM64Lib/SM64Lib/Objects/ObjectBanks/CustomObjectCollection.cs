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

        public void Export(string filePath, string exportName)
        {
            Export(filePath, CustomObjects.ToArray(), exportName);
        }

        public static void Export(string filePath, CustomObject customObject, string exportName)
        {
            Export(filePath, new CustomObject[] { customObject }, exportName);
        }

        public static void Export(string filePath, CustomObject[] customObjects, string exportName)
        {
            var export = new CustomObjectExport()
            {
                ExportDate = DateTime.UtcNow,
                Name = exportName
            };
            export.CustomObjects.AddRange(customObjects);

            foreach (var cobj in customObjects)
            {
                if (cobj.BehaviorProps.Behavior is object && !cobj.BehaviorProps.Behavior.IsVanilla)
                {
                    var behav = cobj.BehaviorProps.Behavior.FindBehavior();
                    if (behav is object)
                        export.Behaviors.Add(cobj.BehaviorProps.Behavior, behav);
                }

                if (cobj.ModelProps is object)
                {
                    var mdl = cobj.ModelProps.Model?.FindModel();
                    if (mdl is object)
                        export.CustomModels.Add(cobj.ModelProps.Model, mdl);
                }
            }

            var ser = JsonSerializer.CreateDefault();
            ser.PreserveReferencesHandling = PreserveReferencesHandling.All;
            File.WriteAllText(filePath, JObject.FromObject(export, ser).ToString());
        }

        public static CustomObjectImport LoadImport(string filePath)
        {
            var ser = JsonSerializer.CreateDefault();
            ser.PreserveReferencesHandling = PreserveReferencesHandling.All;
            //ser.Converters.Add(new ArrayReferencePreservngConverter());
            return JObject.Parse(File.ReadAllText(filePath)).ToObject<CustomObjectImport>(ser);
        }

        public void Import(CustomObjectImport import)
        {
            foreach (var cobj in import.CustomObjects)
            {
                // Add Custom Model
                if (cobj.BehaviorProps.Behavior is object)
                {
                    if (cobj.BehaviorProps.Behavior.IsVanilla)
                    {
                        var behav = import.DestBehaviorBank.GetBehaviorByBankAddress(cobj.BehaviorProps.BehaviorAddress);
                        cobj.BehaviorProps.Behavior = behav.Config;
                        cobj.BehaviorProps.Behavior.IsVanilla = false;
                    }
                    else if (import.Behaviors.ContainsKey(cobj.BehaviorProps.Behavior))
                    {
                        var behav = import.Behaviors[cobj.BehaviorProps.Behavior];
                        import.DestBehaviorBank.Behaviors.Add(behav);
                    }
                    cobj.BehaviorProps.BehaviorAddress = -1;
                }

                // Add Custom Behavior
                if (cobj.ModelProps.Model is object && import.CustomModels.ContainsKey(cobj.ModelProps.Model) && import.DestModelBanks.ContainsKey(cobj.ModelProps.Model))
                {
                    var destModelBank = import.DestModelBanks[cobj.ModelProps.Model];
                    destModelBank.Models.Add(import.CustomModels[cobj.ModelProps.Model]);
                    destModelBank.NeedToSave = true;
                }

                // Add Custom Object
                CustomObjects.Add(cobj);
            }
        }
    }
}
