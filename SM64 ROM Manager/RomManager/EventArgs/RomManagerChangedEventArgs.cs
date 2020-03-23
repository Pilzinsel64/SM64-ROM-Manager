using System;
using global::SM64Lib;

namespace SM64_ROM_Manager.EventArguments
{
    public class RomManagerChangedEventArgs : EventArgs
    {
        public RomManager Old { get; private set; }
        public RomManager New { get; private set; }

        public RomManagerChangedEventArgs(RomManager old, RomManager @new)
        {
            Old = old;
            New = @new;
        }
    }
}