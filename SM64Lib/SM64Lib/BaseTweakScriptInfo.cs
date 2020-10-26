using SM64Lib.Patching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib
{
    public class BaseTweakScriptInfo
    {
        public PatchScript Script { get; private set; }
        public int Priority { get; private set; }
        public bool IsReadOnly { get; private set; }
        public string Name { get; private set; }
        public bool EnabledByDefault { get; private set; }
        public bool Enabled { get; set; }

        public BaseTweakScriptInfo(PatchScript script)
        {
            var infos = script.Name.Split('#');
            Priority = Convert.ToInt32(infos[0]);
            IsReadOnly = infos[1] == "w" ? true : false;
            EnabledByDefault = infos[2] == "y" ? true : false;
            Enabled = EnabledByDefault;
            Name = infos[3];
            Script = script;
        }
    }
}
