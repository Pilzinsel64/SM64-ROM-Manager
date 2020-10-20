using global::System.Reflection;

namespace SM64_ROM_Manager
{
    internal static class Extensions
    {
        public static object GetValue(this object @base, string name)
        {
            var type = @base.GetType();
            var fi = type.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (fi is object)
            {
                return fi.GetValue(@base);
            }

            var pi = type.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (pi is object)
            {
                return pi.GetValue(@base);
            }

            return null;
        }

        public static T GetValue<T>(this object @base, string name)
        {
            return (T)@base.GetValue(name);
        }

        public static void SetValue(this object @base, string name, object value)
        {
            var type = @base.GetType();
            var fi = type.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (fi is object)
            {
                fi.SetValue(@base, value);
            }

            var pi = type.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (pi is object)
            {
                pi.SetValue(@base, value);
            }
        }
    }
}