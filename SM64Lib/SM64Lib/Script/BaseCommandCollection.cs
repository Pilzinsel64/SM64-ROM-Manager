using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace SM64Lib.Script
{
    public class BaseCommandCollection<TCmd, eTypes> : List<BaseCommand<eTypes>>
    {
        public bool IsDirty
        {
            get
            {
                return this.FirstOrDefault(n => n.IsDirty) is object;
            }
        }

        public override string ToString()
        {
            var Lines = new List<string>();
            foreach (BaseCommand<eTypes> cmd in this)
                Lines.Add(cmd.ToString());
            return string.Join(Constants.vbNewLine, Lines.ToArray());
        }

        public void Close()
        {
            foreach (BaseCommand<eTypes> cmd in this)
                cmd.Close();
        }
    }
}