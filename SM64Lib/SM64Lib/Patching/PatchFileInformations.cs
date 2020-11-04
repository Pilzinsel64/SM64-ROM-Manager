﻿using Newtonsoft.Json.Linq;
using SM64Lib.Patching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Patching
{
    public class PatchFileInformations
    {
        public string PatchFileName { get; set; }

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