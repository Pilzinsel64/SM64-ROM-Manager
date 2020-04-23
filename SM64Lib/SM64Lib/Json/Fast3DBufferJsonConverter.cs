using Newtonsoft.Json;
using SM64Lib.Model.Fast3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Json
{
    internal class Fast3DBufferJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Fast3DBuffer).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var export = serializer.Deserialize<Fast3DBufferExport>(reader);
            Fast3DBuffer c;

            if (existingValue is object)
                c = (Fast3DBuffer)existingValue;
            else
                c = new Fast3DBuffer();

            if (export?.Buffer is object)
            {
                c.Position = 0;
                c.Write(export.Buffer, 0, export.Buffer.Length);
                c.Position = 0;
            }

            c.Fast3DBankStart = export.Fast3DBankStart;
            c.DLPointers = export.DLPointers.ToArray();

            return c;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var buffer = (Fast3DBuffer)value;
            var export = new Fast3DBufferExport
            {
                Buffer = buffer.ToArray(),
                Fast3DBankStart = buffer.Fast3DBankStart,
                DLPointers = buffer.DLPointers.ToList()
            };
            buffer.Position = 0;

            serializer.Serialize(writer, export);
        }

        private class Fast3DBufferExport
        {
            public byte[] Buffer { get; set; }
            public int Fast3DBankStart { get; set; }
            public List<Geolayout.Geopointer> DLPointers { get; set; }
        }
    }
}
