using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Levels
{
    public class LevelExportImportParameters
    {
        public List<object> WhitelistedObjects { get; } = new List<object>();
        public List<Type> WhitelistedTypes { get; } = new List<Type>();
    }
}
