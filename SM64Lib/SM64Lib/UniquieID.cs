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
        private static int currentSimpleID = 0;

        [JsonProperty(nameof(ID))]
        private string _iD;

        [JsonIgnore]
        public string ID
        {
            get
            {
                if (GenerateOnGet)
                    GenerateIfNull();
                return _iD;
            }
            internal set
                => _iD = value;
        }

        [JsonIgnore]
        public bool HasID { get => !string.IsNullOrEmpty(_iD); }
        [JsonIgnore]
        public bool SimpleMode { get; set; } = false;
        [JsonIgnore]
        public bool GenerateOnGet { get; set; } = false;

        public UniquieID() : this(false)
        {
        }

        public UniquieID(bool autoGenerate)
        {
            if (autoGenerate)
                GenerateIfNull();
        }

        public void Generate()
        {
            if (SimpleMode)
                ID = typeof(TargetType).ToString() + currentSimpleID++.ToString();
            else
                ID = General.GenerateUniquieID<TargetType>();
        }
        public void GenerateIfNull()
        {
            if (!HasID) Generate();
        }

        public override string ToString() => ID;

        public static implicit operator string(UniquieID<TargetType> id)    => id.ID;
        public static implicit operator UniquieID<TargetType>(string id)    => new UniquieID<TargetType>() { ID = id };
        public static implicit operator UniquieID<TargetType>(int id)       => new UniquieID<TargetType>() { ID = Convert.ToString(id) };

        public static bool operator ==(UniquieID<TargetType> left, UniquieID<TargetType> right) => left.ID == right.ID;
        public static bool operator !=(UniquieID<TargetType> left, UniquieID<TargetType> right) => left.ID != right.ID;
    }
}
