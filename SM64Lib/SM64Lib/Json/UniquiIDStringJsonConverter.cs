using Newtonsoft.Json;
using SM64Lib.Model.Fast3D;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Json
{
    internal class UniquiIDStringJsonConverter<TargetType> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(UniquieID<TargetType>).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var idString = serializer.Deserialize<string>(reader);
            UniquieID<TargetType> id;

            if (existingValue is object)
                id = (UniquieID<TargetType>)existingValue;
            else
                id = new UniquieID<TargetType>();

            id.ID = idString;

            return id;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((UniquieID<TargetType>)value).ID);
        }
    }
}
