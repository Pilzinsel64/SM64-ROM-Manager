using System;

namespace SM64_ROM_Manager.Updating.UpdateInstaller
{
    internal class UpdateInstallerStatusChangedEventArgs : EventArgs
    {
        public UpdateInstallerStatus NewStatus { get; private set; }

        public UpdateInstallerStatusChangedEventArgs(UpdateInstallerStatus newStatus) : base()
        {
            NewStatus = newStatus;
        }
    }
}