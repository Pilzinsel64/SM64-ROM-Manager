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
        public IReadOnlyCollection<CustomObject> ReferenceObjects { get; }
        public IReadOnlyCollection<BehaviorConfig> ReferenceBehaviors { get; }
        public IReadOnlyCollection<CustomAsmArea> ReferenceAsmAreas { get; }
        public IReadOnlyCollection<CustomModelConfig> ReferenceModels { get; }

        public bool HasReferences
        {
            get => ReferenceObjects.Any() || ReferenceBehaviors.Any() || ReferenceAsmAreas.Any() || ReferenceModels.Any();
        }

        private CustomObjectReferences(CustomObject[] refObject, BehaviorConfig[] refBehaviors, CustomAsmArea[] refAsmAreas, CustomModelConfig[] refModels)
        {
            ReferenceObjects = refObject;
            ReferenceBehaviors = refBehaviors;
            ReferenceAsmAreas = refAsmAreas;
            ReferenceModels = refModels;
        }

        public void DeleteReferences(RomManager rommgr)
        {
            var refObjs = ReferenceObjects.ToArray();
            var refBehavs = ReferenceBehaviors.Select(n => n.FindBehavior()).TakeWhile(n => n is object).ToArray();
            var refAsmAreas = ReferenceAsmAreas.ToArray();
            var refMdls = ReferenceModels.Select(n => n.FindModel()).TakeWhile(n => n is object).ToArray();

            rommgr.CustomObjects.CustomObjects.RemoveRangeIfContains(refObjs);
            rommgr.GlobalBehaviorBank.Behaviors.RemoveRangeIfContains(refBehavs);
            rommgr.GlobalCustomAsmBank.Areas.RemoveRangeIfContains(refAsmAreas);
            rommgr.GlobalModelBank.Models.RemoveRangeIfContains(refMdls);

            foreach (var lvl in rommgr.Levels)
            {
                if (lvl.LocalObjectBank is object)
                    lvl.LocalObjectBank.Models.RemoveRangeIfContains(ReferenceModels.Select(n => n.FindModel()).ToArray());
            }
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
                        FindReferenceCustomModels(rommgr.CustomObjects, behavConfig, refObjects);

                        foreach (var asmArea in behavConfig.CustomAsmLinks)
                        {
                            if (!refAsmAreas.Contains(asmArea.CustomAsm))
                            {
                                refAsmAreas.Add(asmArea.CustomAsm);
                                FIndReferenceBehaviors(rommgr.GlobalBehaviorBank, asmArea.CustomAsm, refBehaviors);
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
                        FindReferenceCustomModels(rommgr.CustomObjects, modelConfig, refObjects);
                    }
                }

            }

            return new CustomObjectReferences(refObjects.ToArray(), refBehaviors.ToArray(), refAsmAreas.ToArray(), refModels.ToArray());
        }

        private static void FindReferenceCustomModels(CustomObjectCollection collection, BehaviorConfig behavior, List<CustomObject> refObjects)
        {
            foreach (var customObject in collection.CustomObjects)
            {
                if (!customObject.BehaviorProps.UseCustomAddress && customObject.BehaviorProps.Behavior == behavior)
                    refObjects.AddIfNotContains(customObject);
            }
        }

        private static void FIndReferenceBehaviors(BehaviorBank bank, CustomAsmArea asmArea, List<BehaviorConfig> refBehaviors)
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

        private static void FindReferenceCustomModels(CustomObjectCollection collection, CustomModelConfig model, List<CustomObject> refObjects)
        {
            foreach (var customObject in collection.CustomObjects)
            {
                if (!customObject.ModelProps.UseCustomModelID && customObject.ModelProps.Model == model)
                    refObjects.AddIfNotContains(customObject);
            }
        }

    }
}
