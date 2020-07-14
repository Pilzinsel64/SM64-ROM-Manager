using Pilz.Cryptography;
using Newtonsoft.Json;
using SM64Lib;

namespace SM64_ROM_Manager.LevelEditor
{
    public class ObjectCombo
    {
        [JsonIgnore]
        public UniquieID<ObjectCombo> ID { get; set; } = new UniquieID<ObjectCombo>() { GenerateOnGet = true, SimpleMode = true };

        public string Name { get; set; } = "Unknown Combo";
        public byte ModelID { get; set; } = 0;
        public int ModelAddress { get; set; } = 0;
        public uint BehaviorAddress { get; set; } = 0;
        public BParam BParam1 { get; set; } = new BParam();
        public BParam BParam2 { get; set; } = new BParam();
        public BParam BParam3 { get; set; } = new BParam();
        public BParam BParam4 { get; set; } = new BParam();

        public class BParam
        {
            public string Name { get; set; } = "New B. Param";
            public string Description { get; set; } = "";
        }
    }
}