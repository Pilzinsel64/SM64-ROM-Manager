using Newtonsoft.Json;
using SM64Lib.Behaviors.Script;
using SM64Lib.Geolayout.Script;
using SM64Lib.Levels.Script;
using SM64Lib.Model.Fast3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Json
{
    internal class LevelscriptCommandJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(LevelscriptCommand).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var export = serializer.Deserialize<CmdExport>(reader);
            LevelscriptCommand c;

            if (existingValue is object)
                c = (LevelscriptCommand)existingValue;
            else
                c = new LevelscriptCommand();

            if (export?.Buffer is object)
            {
                c.Position = 0;
                c.Write(export.Buffer, 0, export.Buffer.Length);
                c.Position = 0;
            }

            c.BankAddress = export.BankAddress;

            return c;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var cmd = (LevelscriptCommand)value;

            var export = new CmdExport
            {
                Buffer = cmd.ToArray(),
                BankAddress = cmd.BankAddress
            };

            serializer.Serialize(writer, export);
        }

        private class CmdExport
        {
            public byte[] Buffer { get; set; }
            public int BankAddress { get; set; }
        }
    }
}
