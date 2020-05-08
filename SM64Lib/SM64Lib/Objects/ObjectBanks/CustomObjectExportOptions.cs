using Pilz.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Objects.ObjectBanks
{
    public class CustomObjectExportOptions
    {
        public string ExportName { get; set; }
        public EmbeddedFilesContainer EmbeddedFiles { get; set; }
        public Patching.PatchScript Script { get; set; }
    }
}
