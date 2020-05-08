using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64Lib.Patching
{
    public class PatchScriptManagerProcessingInputValueEventArgs
    {
        public InputValueType ValueType { get; private set; }
        public string Titel { get; private set; }
        public RomManager RomManager { get; private set; }
        public IWin32Window Owner { get; private set; }
        public object ReturnValue { get; set; }
        public bool SettedValue { get; set; }

        internal PatchScriptManagerProcessingInputValueEventArgs(InputValueType valueType, string titel, RomManager romManager, IWin32Window owner)
        {
            ValueType = valueType;
            Titel = titel;
            RomManager = romManager;
            Owner = owner;
            SettedValue = false;
        }
    }
}
