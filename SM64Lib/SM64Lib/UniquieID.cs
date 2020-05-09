using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib
{
    public class UniquieID<TargetType>
    {
        [JsonProperty]
        public string ID { get; private set; }

        [JsonIgnore]
        public bool HasID { get => !string.IsNullOrEmpty(ID); }

        public void Generate()
            => ID = General.GenerateUniquieID<TargetType>();

        public override string ToString() => ID;

        public static implicit operator string(UniquieID<TargetType> id)    => id.ID;
        public static implicit operator UniquieID<TargetType>(string id)    => new UniquieID<TargetType>() { ID = id };
        public static implicit operator UniquieID<TargetType>(int id)       => new UniquieID<TargetType>() { ID = Convert.ToString(id) };
    }
}
