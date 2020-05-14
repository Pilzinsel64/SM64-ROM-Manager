using SM64Lib.ASM;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Objects.ModelBanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Collections.Extensions;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectReferences
    {
        public CustomObject[] ReferenceObjects { get; }
        public BehaviorConfig[] ReferenceBehaviors { get; }
        public CustomAsmArea[] ReferenceAsmAreas { get; }
        public CustomModelConfig[] ReferenceModels { get; }

        private CustomObjectReferences(CustomObject[] refObject, BehaviorConfig[] refBehaviors, CustomAsmArea[] refAsmAreas, CustomModelConfig[] refModels)
        {
            ReferenceObjects = refObject;
            ReferenceBehaviors = refBehaviors;
            ReferenceAsmAreas = refAsmAreas;
            ReferenceModels = refModels;
        }

        public static CustomObjectReferences Find(CustomObject[] customObjects, RomManager rommgr)
        {
            var refObjects = new List<CustomObject>();
            var refBehaviors = new List<BehaviorConfig>();
            var refAsmAreas = new List<CustomAsmArea>();
            var refModels = new List<CustomModelConfig>();

            foreach (var customObject in customObjects)
            {
                if (!customObject.BehaviorProps.UseCustomAddress && customObject.BehaviorProps.Behavior is object)
                {
                    var behavConfig = customObject.BehaviorProps.Behavior;
                    if (!refBehaviors.Contains(behavConfig))
                    {
                        refBehaviors.Add(behavConfig);
                        CheckBehaviors(rommgr.CustomObjects, behavConfig, refObjects);

                        foreach (var asmArea in behavConfig.CustomAsmLinks)
                        {
                            if (!refAsmAreas.Contains(asmArea.CustomAsm))
                            {
                                refAsmAreas.Add(asmArea.CustomAsm);
                                CheckAsmAreas(rommgr.GlobalBehaviorBank, asmArea.CustomAsm, refBehaviors);
                            }
                        }
                    }
                }

                if (!customObject.ModelProps.UseCustomModelID && customObject.ModelProps.Model is object)
                {
                    var modelConfig = customObject.ModelProps.Model;
                    if (!refModels.Contains(modelConfig))
                    {
                        refModels.Add(modelConfig);
                        CheckModels(rommgr.CustomObjects, modelConfig, refObjects);
                    }
                }

            }

            return new CustomObjectReferences(refObjects.ToArray(), refBehaviors.ToArray(), refAsmAreas.ToArray(), refModels.ToArray());
        }

        private static void CheckBehaviors(CustomObjectCollection collection, BehaviorConfig behavior, List<CustomObject> refObjects)
        {
            foreach (var customObject in collection.CustomObjects)
            {
                if (!customObject.BehaviorProps.UseCustomAddress && customObject.BehaviorProps.Behavior == behavior)
                    refObjects.AddIfNotContains(customObject);
            }
        }

        private static void CheckAsmAreas(BehaviorBank bank, CustomAsmArea asmArea, List<BehaviorConfig> refBehaviors)
        {
            foreach (var behav in bank.Behaviors)
            {
                foreach (var link in behav.Config.CustomAsmLinks)
                {
                    if (link.CustomAsm == asmArea)
                        refBehaviors.AddIfNotContains(behav.Config);
                }
            }
        }

        private static void CheckModels(CustomObjectCollection collection, CustomModelConfig model, List<CustomObject> refObjects)
        {
            foreach (var customObject in collection.CustomObjects)
            {
                if (!customObject.ModelProps.UseCustomModelID && customObject.ModelProps.Model == model)
                    refObjects.AddIfNotContains(customObject);
            }
        }

    }
}
