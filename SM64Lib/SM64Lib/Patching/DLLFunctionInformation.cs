using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Patching
{
    public class DLLFunctionInformation
    {
        public string EmbeddedFileName { get; set; }
        public string Typename { get; set; }

        public void Set(PatchScript script)
        {
            script.Script = JObject.FromObject(this).ToString();
        }

        public static PatchFileInformations Get(PatchScript script)
        {
            return JObject.Parse(script.Script).ToObject<PatchFileInformations>();
        }
    }
}
