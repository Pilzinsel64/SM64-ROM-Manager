using System.Collections.Generic;

namespace SM64_ROM_Manager.Updating.Administration.Packaging
{
    public class UpdatePackageTemplate
    {
        public string FilesToCopyPath { get; set; }
        public List<string> UpdateInstallerAddOns { get; set; } = new List<string>();
    }
}