using System;

namespace SM64_ROM_Manager.EventArguments
{
    public class EnabledEventArgs : EventArgs
    {
        public bool Enabled { get; set; }

        public EnabledEventArgs(bool enabled)
        {
            Enabled = enabled;
        }
    }
}