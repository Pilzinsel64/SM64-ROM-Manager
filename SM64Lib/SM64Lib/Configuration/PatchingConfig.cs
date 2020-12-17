using Pilz.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Configuration
{
    public class PatchingConfig
    {
        public EmbeddedFilesContainer TweakBackups { get; } = new EmbeddedFilesContainer();
        public bool Patched2DCamera { get; set; } = false;
    }
}
