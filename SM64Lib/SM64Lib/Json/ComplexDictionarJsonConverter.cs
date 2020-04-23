using Newtonsoft.Json;
using SM64Lib.Model.Fast3D;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Collections.Extensions;

namespace SM64Lib.Json
{
    internal class ComplexDictionarJsonConverter<TKey, TValue> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(List<KeyValuePair<TKey, TValue>>).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var list = serializer.Deserialize<List<KeyValuePair<TKey, TValue>>>(reader);
            var dic = new Dictionary<TKey, TValue>();
            dic.AddRange(list.ToArray());

            return dic;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is Dictionary<TKey, TValue>)
                serializer.Serialize(writer, ((Dictionary<TKey, TValue>)value).ToArray());
        }
    }
}
