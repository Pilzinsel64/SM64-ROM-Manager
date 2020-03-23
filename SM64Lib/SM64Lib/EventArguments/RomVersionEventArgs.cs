using System;

namespace SM64Lib.EventArguments
{
    public class RomVersionEventArgs : EventArgs
    {
        public RomVersion RomVersion { get; set; }

        internal RomVersionEventArgs(RomVersion romVersion)
        {
            RomVersion = romVersion;
        }
    }
}