using global::SM64Lib.Configuration;
using Newtonsoft.Json;

namespace SM64Lib.Objects.ModelBanks
{
    public class CustomModel
    {
        public CustomModelConfig Config { get; set; } = new CustomModelConfig();
        public Geolayout.Geolayout Geolayout { get; set; } = null;
        public Model.ObjectModel Model { get; set; } = null;
        public byte ModelID { get; set; } = 0;

        [JsonProperty]
        public int ModelBankOffset { get; internal set; } = 0;
        [JsonProperty]
        public int GeolayoutBankOffset { get; internal set; } = 0;
        [JsonProperty]
        public int CollisionPointer { get; internal set; } = 0;

        public CustomModel()
        {
        }

        public CustomModel(Model.ObjectModel mdl)
        {
            Model = mdl;
        }

        public CustomModel(Geolayout.Geolayout geo)
        {
            Geolayout = geo;
        }

        public CustomModel(Geolayout.Geolayout geo, Model.ObjectModel mdl)
        {
            Geolayout = geo;
            Model = mdl;
        }

        public void GenerateNewGeolayout()
        {
            Geolayout = new Geolayout.Geolayout(SM64Lib.Geolayout.Geolayout.NewScriptCreationMode.Object);
        }
    }
}