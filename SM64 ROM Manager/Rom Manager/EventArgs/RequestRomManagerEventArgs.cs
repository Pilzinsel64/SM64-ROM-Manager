using System;
using global::SM64Lib;

namespace SM64_ROM_Manager.EventArguments
{
    public class RequestRomManagerEventArgs : EventArgs
    {
        public RomManager RomManager { get; set; }
    }
}