using global::System.ComponentModel;
using System.Runtime.CompilerServices;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager
{
    public class MinimalAdvPropertyGridManager
    {
        private AdvPropertyGrid _AdvPropertyGrid1;

        private AdvPropertyGrid AdvPropertyGrid1
        {
            get
            {
                return _AdvPropertyGrid1;
            }
            set
            {
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.ConvertFromStringToPropertyValue -= AdvPropertyGrid1_ConvertFromStringToPropertyValue;
                    _AdvPropertyGrid1.ConvertPropertyValueToString -= AdvPropertyGrid1_ConvertPropertyValueToString;
                    _AdvPropertyGrid1.PropertyValueChanged -= AdvPropertyGrid1_PropertyValueChanged;
                }

                _AdvPropertyGrid1 = value;
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.ConvertFromStringToPropertyValue += AdvPropertyGrid1_ConvertFromStringToPropertyValue;
                    _AdvPropertyGrid1.ConvertPropertyValueToString += AdvPropertyGrid1_ConvertPropertyValueToString;
                    _AdvPropertyGrid1.PropertyValueChanged += AdvPropertyGrid1_PropertyValueChanged;
                }
            }
        }

        public MinimalAdvPropertyGridManager(AdvPropertyGrid advPropGrid)
        {
            AdvPropertyGrid1 = advPropGrid;
        }

        private void AdvPropertyGrid1_ConvertFromStringToPropertyValue(object sender, ConvertValueEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.PropertyType;
            switch (switchExpr)
            {
                case var @case when @case == typeof(bool):
                    {
                        if (e.StringValue == "Yes")
                        {
                            e.TypedValue = true;
                        }
                        else
                        {
                            e.TypedValue = false;
                        }

                        e.IsConverted = true;
                        break;
                    }

                case var case1 when case1 == typeof(byte):
                    {
                        e.TypedValue = Conversions.ToByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case2 when case2 == typeof(sbyte):
                    {
                        e.TypedValue = Conversions.ToSByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case3 when case3 == typeof(short):
                    {
                        e.TypedValue = Conversions.ToShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case4 when case4 == typeof(ushort):
                    {
                        e.TypedValue = Conversions.ToUShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case5 when case5 == typeof(int):
                    {
                        e.TypedValue = Conversions.ToInteger(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case6 when case6 == typeof(uint):
                    {
                        e.TypedValue = Conversions.ToUInteger(TextValueConverter.LongFromText(e.StringValue.Trim()));
                        e.IsConverted = true;
                        break;
                    }

                case var case7 when case7 == typeof(float):
                    {
                        e.TypedValue = Conversions.ToSingle(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }

                case var case8 when case8 == typeof(double):
                    {
                        e.TypedValue = Conversions.ToDouble(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }

                case var case9 when case9 == typeof(decimal):
                    {
                        e.TypedValue = Conversions.ToDecimal(e.StringValue.Trim());
                        e.IsConverted = true;
                        break;
                    }
            }
        }

        private void AdvPropertyGrid1_ConvertPropertyValueToString(object sender, ConvertValueEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.PropertyType;
            switch (switchExpr)
            {
                case var @case when @case == typeof(bool):
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(e.TypedValue, true, false)))
                    {
                        e.StringValue = "Yes";
                    }
                    else
                    {
                        e.StringValue = "No";
                    }
                    e.IsConverted = true;
                    break;
                case var case1 when case1 == typeof(byte):
                case var case2 when case2 == typeof(sbyte):
                case var case3 when case3 == typeof(short):
                case var case4 when case4 == typeof(ushort):
                case var case5 when case5 == typeof(int):
                case var case6 when case6 == typeof(uint):
                    e.StringValue = TextValueConverter.TextFromValue(Conversions.ToLong(e.TypedValue));
                    e.IsConverted = true;
                    break;
            }
        }

        private void AdvPropertyGrid1_PropertyValueChanged(object sender, PropertyChangedEventArgs e)
        {
            AdvPropertyGrid1.RefreshPropertyValues();
        }
    }
}