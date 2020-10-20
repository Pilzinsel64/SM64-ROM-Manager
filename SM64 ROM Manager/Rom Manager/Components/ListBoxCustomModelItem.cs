using System.Collections.Generic;

namespace SM64_ROM_Manager
{
    public partial class ListBoxCustomModelItem : DevComponents.DotNetBar.ListBoxItem
    {
        public ListBoxCustomModelItem()
        {
            InitializeComponent();
        }

        public bool EnableCollision = false;
        public uint Colpointer = 0;
        public readonly List<SM64Lib.Geolayout.Geopointer> Geopointer = new List<SM64Lib.Geolayout.Geopointer>();
        public uint RomOffset = 0;
        public uint RamOffset = 0;
        public uint MaxRomOffset = 0;
        public string ExtraData = "";
    }
}