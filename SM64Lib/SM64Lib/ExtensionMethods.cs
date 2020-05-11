
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SM64Lib.Extensions
{
    public static class Int16Extensions
    {
        public static bool IsInRange(this short value, short min, short max)
        {
            return value >= min && value <= max;
        }
    }

    public static class ObjectExtensions
    {
        public static void CloneTo<T>(this T source, T destination) where T : class
        {
            var json = JsonSerializer.CreateDefault();
            var jobj = JObject.FromObject(source);
            jobj.Populate(destination);
        }
    }

    public static class JsonExtensions
    {
        public static void Populate(this JToken value, object target)
        {
            using (var sr = value.CreateReader())
                JsonSerializer.CreateDefault().Populate(sr, target);
        }
    }
}