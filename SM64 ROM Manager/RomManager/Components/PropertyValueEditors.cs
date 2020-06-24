using System;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Levels;
using global::SM64Lib.TextValueConverter;
using Z.Collections.Extensions;
using Z.Core.Extensions;

namespace SM64_ROM_Manager.PropertyValueEditors
{
    internal enum SelectedTypes
    {
        SelectedItem,
        SelectedComboItem,
        SelectedIndex
    }

    internal class ComboBoxPropertyEditor : PropertyValueEditor
    {
        public int DropDownWidth { get; set; } = 0;
        public SelectedTypes SelectedType { get; set; } = SelectedTypes.SelectedItem;
        public object Items { get; set; }

        public ComboBoxPropertyEditor()
        {
            Items = new object[] { };
        }

        public ComboBoxPropertyEditor(object[] items)
        {
            Items = items;
        }

        public override IPropertyValueEditor CreateEditor(PropertyDescriptor propertyDescriptor, object targetObject)
        {
            var editor = new ComboBoxEditor();
            editor.Style = eDotNetBarStyle.StyleManagerControlled;
            editor.DrawMode = DrawMode.OwnerDrawFixed;
            editor.DropDownStyle = ComboBoxStyle.DropDownList;
            editor.FormattingEnabled = true;
            editor.IntegralHeight = true;
            editor.Items.AddRange((object[])Items);
            editor.DropDownWidth = DropDownWidth;
            editor.SelectedType = SelectedType;
            return editor;
        }

        internal class ComboBoxEditor : ComboBoxEx, IPropertyValueEditor
        {
            public SelectedTypes SelectedType { get; set; } = SelectedTypes.SelectedItem;

            public Font EditorFont
            {
                get => Font;
                set => Font = value;
            }

            public bool IsEditorFocused
            {
                get => Focused;
            }

            public object EditValue
            {
                get
                {
                    if (SelectedIndex >= 0)
                    {
                        var switchExpr = SelectedType;
                        switch (switchExpr)
                        {
                            case SelectedTypes.SelectedIndex:
                                return SelectedIndex.ToString(); // SelectedTypes.SelectedItem
                            case SelectedTypes.SelectedComboItem:
                                return (SelectedItem as ComboItem)?.Tag;
                            case SelectedTypes.SelectedItem:
                                return SelectedItem;
                        }
                    }
                    return null;
                }
                set
                {
                    var switchExpr = SelectedType;
                    switch (switchExpr)
                    {
                        case SelectedTypes.SelectedIndex:
                            SelectedIndex = Conversions.ToInteger(value);
                            break;
                        case SelectedTypes.SelectedComboItem:
                            var found = false;
                            foreach (ComboItem item in Items)
                            {
                                if (!found && item.Tag == value)
                                {
                                    SelectedItem = item;
                                    found = true;
                                }
                            }
                            break;
                        case SelectedTypes.SelectedItem:
                            SelectedItem = value;
                            break;
                    }
                }
            }

            public event EventHandler EditValueChanged;

            public void FocusEditor()
            {
                Focus();
            }

            protected override void OnSelectedIndexChanged(EventArgs e)
            {
                OnEditSelectedValueChanged(e);
                base.OnSelectedIndexChanged(e);
            }

            protected override void OnSelectedItemChanged(EventArgs e)
            {
                OnEditSelectedValueChanged(e);
                base.OnSelectedItemChanged(e);
            }

            private void OnEditSelectedValueChanged(EventArgs e)
            {
                EditValueChanged?.Invoke(this, e);
            }
        }
    }

    internal class LevelsEnumEditor : PropertyValueEditor
    {
        public int DropDownWidth { get; set; } = 0;
        public object Items { get; set; }
        public List<Levels> Levels { get; set; }

        public LevelsEnumEditor()
        {
            Items = new object[] { };
        }

        public LevelsEnumEditor(object[] items, List<Levels> levels)
        {
            Items = items;
            Levels = levels;
        }

        public override IPropertyValueEditor CreateEditor(PropertyDescriptor propertyDescriptor, object targetObject)
        {
            var editor = new ComboBoxEditor();
            editor.Style = eDotNetBarStyle.StyleManagerControlled;
            editor.DrawMode = DrawMode.OwnerDrawFixed;
            editor.DropDownStyle = ComboBoxStyle.DropDownList;
            editor.FormattingEnabled = true;
            editor.IntegralHeight = true;
            editor.Items.AddRange((object[])Items);
            editor.DropDownWidth = DropDownWidth;
            editor.Levels = Levels;
            return editor;
        }

        internal class ComboBoxEditor : ComboBoxEx, IPropertyValueEditor
        {
            public List<Levels> Levels { get; set; } = null;

            public Font EditorFont
            {
                get
                {
                    return Font;
                }

                set
                {
                    Font = value;
                }
            }

            public bool IsEditorFocused
            {
                get
                {
                    return Focused;
                }
            }

            public object EditValue
            {
                get
                {
                    if (SelectedIndex >= 0)
                    {
                        return Levels[SelectedIndex];
                    }
                    else
                    {
                        return null;
                    }
                }

                set
                {
                    SelectedIndex = Levels.IndexOf((Levels)value);
                }
            }

            public event EventHandler EditValueChanged;

            public void FocusEditor()
            {
                Focus();
            }

            protected override void OnSelectedIndexChanged(EventArgs e)
            {
                OnEditSelectedValueChanged(e);
                base.OnSelectedIndexChanged(e);
            }

            protected override void OnSelectedItemChanged(EventArgs e)
            {
                OnEditSelectedValueChanged(e);
                base.OnSelectedItemChanged(e);
            }

            private void OnEditSelectedValueChanged(EventArgs e)
            {
                EditValueChanged?.Invoke(this, e);
            }
        }
    }

    internal class ContentSelectorEditor : PropertyValueEditor
    {
        public delegate void EditorCreateEventHandler(object sender, EditorCreateEventArgs e);

        public event EditorCreateEventHandler EditorCreated;
        public event EditorCreateEventHandler EditorCreating;

        public ContentSelectorEditor()
        {
        }

        public override IPropertyValueEditor CreateEditor(PropertyDescriptor propertyDescriptor, object targetObject)
        {
            var args = new EditorCreateEventArgs(propertyDescriptor);
            ComboBoxEditor editor;
            EditorCreating?.Invoke(this, args);
            if (args.Editor is null)
            {
                editor = new ComboBoxEditor();
                editor.Style = eDotNetBarStyle.StyleManagerControlled;
                editor.DrawMode = DrawMode.OwnerDrawFixed;
                editor.DropDownWidth = 250;
            }
            else
            {
                editor = args.Editor;
            }

            EditorCreated?.Invoke(this, new EditorCreateEventArgs(propertyDescriptor, editor));
            return editor;
        }

        public class EditorCreateEventArgs
        {
            public PropertyDescriptor PropertyDescriptor { get; private set; }
            public ComboBoxEditor Editor { get; set; }

            public EditorCreateEventArgs(PropertyDescriptor propertyDescriptor)
            {
                PropertyDescriptor = propertyDescriptor;
            }

            public EditorCreateEventArgs(PropertyDescriptor propertyDescriptor, ComboBoxEditor editor)
            {
                PropertyDescriptor = propertyDescriptor;
                Editor = editor;
            }
        }

        internal class ComboBoxEditor : ComboBoxEx, IPropertyValueEditor
        {
            public event EventHandler EditValueChanged;
            public event EventHandler NeedValues; // (sender As Object, values As Dictionary(Of String, Byte))

            private bool settingValue = false;
            private bool firstFocused = false;

            public int IntegerValueMode { get; set; } = -1;
            public TypeCode ValueType { get; set; } = TypeCode.Int32;

            public Font EditorFont
            {
                get
                {
                    return base.Font;
                }

                set
                {
                    base.Font = value;
                }
            }

            public bool IsEditorFocused
            {
                get
                {
                    return base.Focused;
                }
            }

            public object EditValue
            {
                get
                {
                    object val;
                    val = SelectedValue;
                    if (val is null)
                    {
                        if (!string.IsNullOrEmpty(base.Text))
                        {
                            if (DataSource is null && base.SelectedIndex > -1)
                            {
                                val = ((ComboItem)Items[base.SelectedIndex]).Tag;
                            }
                            else
                            {
                                val = TextValueConverter.ValueFromText(base.Text);
                            }
                        }
                        else
                        {
                            val = 0;
                        }
                    }

                    try
                    {
                        switch (ValueType)
                        {
                            case TypeCode.Int32:
                                return Conversions.ToInteger(val);
                            case TypeCode.UInt32:
                                return Conversions.ToUInteger(val);
                            case TypeCode.Byte:
                                return Conversions.ToByte(val);
                            case TypeCode.SByte:
                                return Conversions.ToSByte(val);
                            case TypeCode.Int16:
                                return Conversions.ToShort(val);
                            case TypeCode.UInt16:
                                return Conversions.ToUShort(val);
                            case TypeCode.Int64:
                                return Conversions.ToLong(val);
                            case TypeCode.UInt64:
                                return Conversions.ToULong(val);
                        }
                    }
                    catch (OverflowException) { }

                    switch (ValueType)
                    {
                        case TypeCode.Int32:
                            return 0;
                        case TypeCode.UInt32:
                            return 0U;
                        case TypeCode.Byte:
                            return (byte)0;
                        case TypeCode.SByte:
                            return (sbyte)0;
                        case TypeCode.Int16:
                            return (short)0;
                        case TypeCode.UInt16:
                            return (ushort)0;
                        case TypeCode.Int64:
                            return 0L;
                        case TypeCode.UInt64:
                            return 0UL;
                        default:
                            return 0;
                    }
                }

                set
                {
                    bool found = false;
                    settingValue = true;
                    OnNeedValues();
                    if (DataSource is null)
                    {
                        for (int i = 0, loopTo = Items.Count - 1; i <= loopTo; i++)
                        {
                            if (!found)
                            {
                                ComboItem ci = (ComboItem)Items[i];
                                if (ci.Tag == value)
                                {
                                    found = true;
                                    SelectedItem = ci;
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            if (Conversions.ToLong(value) == 0)
                            {
                                base.Text = TextValueConverter.TextFromValue(Conversions.ToLong(value), IntegerValueMode);
                                found = true;
                            }
                            else
                            {
                                SelectedValue = value;
                                SelectedValue = value;
                                if (SelectedValue is null)
                                {
                                    base.Text = TextValueConverter.TextFromValue(Conversions.ToLong(value), IntegerValueMode);
                                }

                                found = !string.IsNullOrEmpty(base.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }

                    if (!found)
                    {
                        base.Text = TextValueConverter.TextFromValue(Conversions.ToLong(value), IntegerValueMode);
                    }

                    settingValue = false;
                }
            }

            public void FocusEditor()
            {
                Focus();
            }

            protected override void OnSelectedIndexChanged(EventArgs e)
            {
                base.OnSelectedIndexChanged(e);
                OnEditSelectedValueChanged(e);
            }

            protected override void OnKeyDown(KeyEventArgs e)
            {
                base.OnKeyDown(e);
                if (e.KeyCode == Keys.Enter)
                {
                    OnEditSelectedValueChanged(e);
                }
            }

            protected override void OnLostFocus(EventArgs e)
            {
                base.OnLostFocus(e);
                OnEditSelectedValueChanged(e);
            }

            private void OnEditSelectedValueChanged(EventArgs e)
            {
                if (!settingValue)
                {
                    EditValueChanged?.Invoke(this, e);
                }
            }

            private void OnNeedValues()
            {
                NeedValues?.Invoke(this, new EventArgs());
            }

            protected override void Dispose(bool disposing)
            {
                // MyBase.Dispose(disposing)
            }
        }
    }

    internal class PropertyIntegerEditorX : PropertyValueEditor
    {
        public int MaxValue { get; set; } = int.MaxValue;
        public int MinValue { get; set; } = int.MinValue;
        public bool ShowUpDownButton { get; set; } = false;

        public override IPropertyValueEditor CreateEditor(PropertyDescriptor propertyDescriptor, object targetObject)
        {
            var editor = new IntegerEditorX() { MaxValue = MaxValue, MinValue = MinValue, ShowUpDown = ShowUpDownButton };
            editor.InputHorizontalAlignment = eHorizontalAlignment.Left;
            editor.SetValue("AutoBorderSize", 1);
            editor.Height = 14;
            editor.BackgroundStyle.Class = "";
            editor.BackColor = Color.Transparent;
            editor.AllowEmptyState = false;
            editor.FreeTextEntryToggleKey = Keys.E;
            return editor;
        }

        private class IntegerEditorX : IntegerInput, IPropertyValueEditor
        {
            public event EventHandler EditValueChanged;

            private bool isSettingValue = false;

            public Font EditorFont
            {
                get
                {
                    return base.Font;
                }

                set
                {
                    base.Font = value;
                }
            }

            public bool IsEditorFocused
            {
                get
                {
                    return base.Focused;
                }
            }

            public object EditValue
            {
                get
                {
                    return Conversions.ToShort(Value);
                }

                set
                {
                    isSettingValue = true;
                    Value = Conversions.ToInteger(value);
                    isSettingValue = false;
                }
            }

            public void FocusEditor()
            {
                Focus();
            }

            protected override void OnValueChanged(EventArgs e)
            {
                base.OnValueChanged(e);
                if (!isSettingValue)
                    EditValueChanged?.Invoke(this, e);
            }
        }
    }

    internal class TextEncodingEditor : PropertyValueEditor
    {
        public int DropDownWidth { get; set; } = 30;
        public string[] AllowedContent { get; set; }

        public TextEncodingEditor(string[] allowedContent)
        {
            AllowedContent = allowedContent;
        }

        public override IPropertyValueEditor CreateEditor(PropertyDescriptor propertyDescriptor, object targetObject)
        {
            var editor = new ComboBoxEditor();
            editor.Style = eDotNetBarStyle.StyleManagerControlled;
            editor.DrawMode = DrawMode.OwnerDrawFixed;
            editor.DropDownStyle = ComboBoxStyle.DropDownList;
            editor.FormattingEnabled = true;
            editor.IntegralHeight = true;
            editor.Items.AddRange(AllowedContent);
            editor.DropDownWidth = DropDownWidth;
            return editor;
        }

        internal class ComboBoxEditor : ComboBoxEx, IPropertyValueEditor
        {
            public Font EditorFont
            {
                get
                {
                    return base.Font;
                }

                set
                {
                    base.Font = value;
                }
            }

            public bool IsEditorFocused
            {
                get
                {
                    return base.Focused;
                }
            }

            public object EditValue
            {
                get
                {
                    if (base.SelectedIndex > -1)
                    {
                        return SelectedItem;
                    }
                    else
                    {
                        return null;
                    }
                }

                set
                {
                    SelectedItem = value;
                }
            }

            public event EventHandler EditValueChanged;

            public void FocusEditor()
            {
                Focus();
            }

            protected override void OnSelectedIndexChanged(EventArgs e)
            {
                OnEditSelectedValueChanged(e);
                base.OnSelectedIndexChanged(e);
            }

            protected override void OnSelectedItemChanged(EventArgs e)
            {
                OnEditSelectedValueChanged(e);
                base.OnSelectedItemChanged(e);
            }

            private void OnEditSelectedValueChanged(EventArgs e)
            {
                EditValueChanged?.Invoke(this, e);
            }
        }
    }
}