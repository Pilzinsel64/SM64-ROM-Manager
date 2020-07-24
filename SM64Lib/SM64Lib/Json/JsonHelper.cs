using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.Json
{
    internal class JsonHelper
    {
        public static JsonSerializer CreateJsonSerializer(
            bool allowReferences = false,
            bool rememberTypeNames = false,
            bool enableIndentedFormatting = true)
        {
            var serializer = JsonSerializer.CreateDefault();

            if (enableIndentedFormatting)
                serializer.Formatting = Formatting.Indented;

            if (rememberTypeNames)
                serializer.TypeNameHandling = TypeNameHandling.Auto;

            if (allowReferences)
            {
                serializer.PreserveReferencesHandling = PreserveReferencesHandling.All;
                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            }

            return serializer;
        }
    }
}
