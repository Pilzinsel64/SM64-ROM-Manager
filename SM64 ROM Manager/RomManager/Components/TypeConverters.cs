using System;
using System.Collections;
using global::System.ComponentModel;
using global::System.Globalization;
using global::System.Numerics;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Levels;
using Z.Core.Extensions;

namespace SM64_ROM_Manager.TypeConverters
{
    internal class Vector3Converter : TypeConverter // ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
        {
            if (destType == typeof(Vector3))
            {
                return true;
            }
            else
            {
                return base.CanConvertTo(context, destType);
            }
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is Vector3)
            {
                string seperator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;
                Vector3 v3 = (Vector3)value;
                return $"{v3.X}{seperator} {v3.Y}{seperator} {v3.Z}";
            }
            else
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            else
            {
                return base.CanConvertFrom(context, sourceType);
            }
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                string seperator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;
                var split = Conversions.ToString(value).Split(seperator);
                var v3 = new Vector3();
                v3.X = Conversions.ToSingle(Math.Truncate(Conversions.ToSingle(split[0])));
                v3.Y = Conversions.ToSingle(Math.Truncate(Conversions.ToSingle(split[1])));
                v3.Z = Conversions.ToSingle(Math.Truncate(Conversions.ToSingle(split[2])));
                return v3;
            }
            else
            {
                return base.ConvertFrom(context, culture, value);
            }
        }

        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            // Return MyBase.CreateInstance(context, propertyValues)

            if (propertyValues is null)
            {
                throw new ArgumentNullException("propertyValues");
            }

            var objX = propertyValues["X"];
            var objY = propertyValues["Y"];
            var objZ = propertyValues["Z"];
            return new Vector3(Conversions.ToSingle(objX), Conversions.ToSingle(objY), Conversions.ToSingle(objZ));
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            var props = TypeDescriptor.GetProperties(value.GetType(), attributes);
            return props.Sort(new string[] { "X", "Y", "Z" });
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }

    internal class LevelsTypeConverter : TypeConverter // ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
        {
            if (destType == typeof(Levels))
            {
                return true;
            }
            else
            {
                return base.CanConvertTo(context, destType);
            }
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is Levels)
            {
                var values = Enum.GetValues(value.GetType());
                return Array.IndexOf(values, value).ToString();
            }
            else
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            else
            {
                return base.CanConvertFrom(context, sourceType);
            }
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            try
            {
                var values = Enum.GetValues(typeof(Levels));
                return values.GetValue((int)value);
            }
            catch (Exception ex)
            {
                return base.ConvertFrom(context, culture, value);
            }
        }
    }
}