using System;

namespace SM64_ROM_Manager.EventArguments
{
    public class RomChangesAvaiableEventArgs : EventArgs
    {
        public bool Mute { get; set; } = false;
    }
}