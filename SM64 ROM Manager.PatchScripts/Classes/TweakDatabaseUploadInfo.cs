using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.PatchScripts
{
    public class TweakDatabaseUploadInfo
    {
        public uint ID { get; set; }
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TweakDatabaseUploadState State { get; set; }
        public string Comments { get; set; }

        public TweakDatabaseUploadInfo(uint id)
        {
            ID = id;
            State = TweakDatabaseUploadState.Waiting;
        }

        public Stream ToStream()
        {
            var ms = new MemoryStream();
            using (var sw = new StreamWriter(ms))
            {
                sw.Write(JObject.FromObject(this).ToString());
                sw.Flush();
            }
            ms.Position = 0;
            return ms;
        }

        public static TweakDatabaseUploadInfo FromStream(Stream s)
        {
            string txt;
            using (var sr = new StreamReader(s))
                txt = sr.ReadToEnd();
            return JObject.Parse(txt).ToObject<TweakDatabaseUploadInfo>();
        }
    }
}
