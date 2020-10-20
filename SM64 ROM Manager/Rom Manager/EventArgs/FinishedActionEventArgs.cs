using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.EventArguments
{
    public class FinishedActionEventArgs : EventArgs
    {
        public bool Successfull { get; private set; }

        public FinishedActionEventArgs(bool successfull)
        {
            Successfull = successfull;
        }
    }
}
