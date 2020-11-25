using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace SM64Lib.Script
{
    public class BaseCommandCollection<TCmd, eTypes> : List<TCmd> where TCmd : BaseCommand<eTypes>
    {
        public long Length
        {
            get
            {
                return this.Sum(n => n.Length);
            }
        }

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
            foreach (TCmd cmd in this)
                Lines.Add(cmd.ToString());
            return string.Join(Environment.NewLine, Lines.ToArray());
        }

        public void Close()
        {
            foreach (TCmd cmd in this)
                cmd.Close();
            Clear();
        }
    }
}