using System;
using System.Collections.Generic;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager.LevelEditor
{
    public class BehaviorInfo
    {
        public string Name { get; set; } = "Unknown Behavior";
        public uint BehaviorAddress { get; set; } = 0;
        public BParam BParam1 { get; set; } = new BParam();
        public BParam BParam2 { get; set; } = new BParam();
        public BParam BParam3 { get; set; } = new BParam();
        public BParam BParam4 { get; set; } = new BParam();

        public string BehaviorAddressText
        {
            get
            {
                return TextValueConverter.TextFromValue(BehaviorAddress, Math.Max(1, SettingsManager.Settings.General.IntegerValueMode));
            }
        }

        public class BParam
        {
            public string Name { get; set; } = "New B. Param";
            public List<BParamValue> Values { get; set; } = new List<BParamValue>();
        }

        public class BParamValue
        {
            public string Name { get; set; } = "";
            public byte Value { get; set; } = 0;

            public string ValueText
            {
                get
                {
                    return TextValueConverter.TextFromValue(Value);
                }
            }
        }
    }
}