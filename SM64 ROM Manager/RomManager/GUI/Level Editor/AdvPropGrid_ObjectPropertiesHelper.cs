using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using global::DevComponents.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.PropertyValueEditors;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.TextValueConverter;
using System.Linq;

namespace SM64_ROM_Manager.LevelEditor
{
    internal class AdvPropGrid_ObjectPropertiesHelper
    {
        public AdvPropGrid_ObjectPropertiesHelper(AdvPropertyGrid advPropGrid, ObjectComboList objComboList, BehaviorInfoList behaviors, string behaviorPropName, string bParamPropName)
        {
            CbEditorBParam1 = null;
            CbEditorBParam2 = null;
            CbEditorBParam3 = null;
            CbEditorBParam4 = null;
            CbEditorBehavAddr = null;
            AdvPropertyGrid1 = advPropGrid;
            myObjectCombos = objComboList;
            myBehaviors = behaviors;
            this.behaviorPropName = behaviorPropName;
            this.bParamPropName = bParamPropName;
            General.LoadBehaviorInfosIfEmpty();
            General.LoadObjectCombosIfEmpty();
            LoadComboBoxObjComboEntries(objComboList);
            
            // Add B. Param Editors to Property Grid
            var bpeditor = new ContentSelectorEditor();
            bpeditor.EditorCreated += ContentSelectorEditor_EditorCreated;
            bpeditor.EditorCreating += ContentSelectorEditor_EditorCreating;
            var bp1PropSet = new PropertySettings(bParamPropName + Conversions.ToString(1));
            var bp2PropSet = new PropertySettings(bParamPropName + Conversions.ToString(2));
            var bp3PropSet = new PropertySettings(bParamPropName + Conversions.ToString(3));
            var bp4PropSet = new PropertySettings(bParamPropName + Conversions.ToString(4));
            bp1PropSet.ValueEditor = bpeditor;
            bp2PropSet.ValueEditor = bpeditor;
            bp3PropSet.ValueEditor = bpeditor;
            bp4PropSet.ValueEditor = bpeditor;
            AdvPropertyGrid1.PropertySettings.Add(bp1PropSet);
            AdvPropertyGrid1.PropertySettings.Add(bp2PropSet);
            AdvPropertyGrid1.PropertySettings.Add(bp3PropSet);
            AdvPropertyGrid1.PropertySettings.Add(bp4PropSet);

            // Add Behavior Address Editor to Property Grid
            var behavaddreditor = new ContentSelectorEditor();
            behavaddreditor.EditorCreating += ContentSelectorEditor_EditorCreating;
            behavaddreditor.EditorCreated += ContentSelectorEditor_EditorCreated;
            var behavaddrPropSet = new PropertySettings(behaviorPropName);
            behavaddrPropSet.ValueEditor = behavaddreditor;
            AdvPropertyGrid1.PropertySettings.Add(behavaddrPropSet);

            // Add Position/Rotation Editors (NumberInputEditor for Increment/Decrement)
            foreach (string l in new[] { "X", "Y", "Z" })
            {
                foreach (string e in new[] { "Position", "Rotation" })
                {
                    var xyzeditor = new PropertyIntegerEditorX() { ShowUpDownButton = true, MinValue = short.MinValue, MaxValue = short.MaxValue };
                    var xyzPropSet = new PropertySettings(e + l);
                    xyzPropSet.ValueEditor = xyzeditor;
                    AdvPropertyGrid1.PropertySettings.Add(xyzPropSet);
                }
            }
        }

        private string behaviorPropName, bParamPropName;
        private bool hasFirstFocued = false;
        private readonly Dictionary<string, EventHandler> registredHandlers = new Dictionary<string, EventHandler>();
        private ObjectComboList myObjectCombos;
        private readonly BehaviorInfoList myBehaviors;
        private AdvPropertyGrid _AdvPropertyGrid1;

        private AdvPropertyGrid AdvPropertyGrid1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AdvPropertyGrid1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.ConvertFromStringToPropertyValue -= AdvPropertyGrid1_ConvertFromStringToPropertyValue;
                    _AdvPropertyGrid1.ConvertPropertyValueToString -= AdvPropertyGrid1_ConvertPropertyValueToString;
                    _AdvPropertyGrid1.PropertiesLoaded -= AdvPropertyGrid1_PropertiesLoaded;
                }

                _AdvPropertyGrid1 = value;
                if (_AdvPropertyGrid1 != null)
                {
                    _AdvPropertyGrid1.ConvertFromStringToPropertyValue += AdvPropertyGrid1_ConvertFromStringToPropertyValue;
                    _AdvPropertyGrid1.ConvertPropertyValueToString += AdvPropertyGrid1_ConvertPropertyValueToString;
                    _AdvPropertyGrid1.PropertiesLoaded += AdvPropertyGrid1_PropertiesLoaded;
                }
            }
        }

        private ContentSelectorEditor.ComboBoxEditor _CbEditorBParam1;

        internal ContentSelectorEditor.ComboBoxEditor CbEditorBParam1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CbEditorBParam1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CbEditorBParam1 != null)
                {
                    _CbEditorBParam1.DataColumnCreated -= CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam1.NeedValues -= ProvideBParamContentList;
                }

                _CbEditorBParam1 = value;
                if (_CbEditorBParam1 != null)
                {
                    _CbEditorBParam1.DataColumnCreated += CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam1.NeedValues += ProvideBParamContentList;
                }
            }
        }

        private ContentSelectorEditor.ComboBoxEditor _CbEditorBParam2;

        internal ContentSelectorEditor.ComboBoxEditor CbEditorBParam2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CbEditorBParam2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CbEditorBParam2 != null)
                {
                    _CbEditorBParam2.DataColumnCreated -= CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam2.NeedValues -= ProvideBParamContentList;
                }

                _CbEditorBParam2 = value;
                if (_CbEditorBParam2 != null)
                {
                    _CbEditorBParam2.DataColumnCreated += CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam2.NeedValues += ProvideBParamContentList;
                }
            }
        }

        private ContentSelectorEditor.ComboBoxEditor _CbEditorBParam3;

        internal ContentSelectorEditor.ComboBoxEditor CbEditorBParam3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CbEditorBParam3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CbEditorBParam3 != null)
                {
                    _CbEditorBParam3.DataColumnCreated -= CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam3.NeedValues -= ProvideBParamContentList;
                }

                _CbEditorBParam3 = value;
                if (_CbEditorBParam3 != null)
                {
                    _CbEditorBParam3.DataColumnCreated += CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam3.NeedValues += ProvideBParamContentList;
                }
            }
        }

        private ContentSelectorEditor.ComboBoxEditor _CbEditorBParam4;

        internal ContentSelectorEditor.ComboBoxEditor CbEditorBParam4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CbEditorBParam4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CbEditorBParam4 != null)
                {
                    _CbEditorBParam4.DataColumnCreated -= CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam4.NeedValues -= ProvideBParamContentList;
                }

                _CbEditorBParam4 = value;
                if (_CbEditorBParam4 != null)
                {
                    _CbEditorBParam4.DataColumnCreated += CbEditorBehavAddr_DataColumnCreated;
                    _CbEditorBParam4.NeedValues += ProvideBParamContentList;
                }
            }
        }

        private ContentSelectorEditor.ComboBoxEditor _CbEditorBehavAddr;

        internal ContentSelectorEditor.ComboBoxEditor CbEditorBehavAddr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CbEditorBehavAddr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CbEditorBehavAddr != null)
                {
                    _CbEditorBehavAddr.DataColumnCreated -= CbEditorBehavAddr_DataColumnCreated;
                }

                _CbEditorBehavAddr = value;
                if (_CbEditorBehavAddr != null)
                {
                    _CbEditorBehavAddr.DataColumnCreated += CbEditorBehavAddr_DataColumnCreated;
                }
            }
        }

        private uint CurBehavAddr
        {
            get
            {
                if (CbEditorBehavAddr is object)
                {
                    return Conversions.ToUInteger(CbEditorBehavAddr.EditValue);
                }

                return 0;
            }
        }

        public void LoadComboBoxObjComboEntries(ObjectComboList objComboList)
        {
            myObjectCombos = objComboList;
            
            // Remove old property settings
            foreach (var ps in AdvPropertyGrid1.PropertySettings.ToArray())
            {
                if (ps.PropertyName == nameof(Managed3DObject.ObjectCombo) || ps.PropertyName == nameof(Managed3DObject.ObjectComboID))
                    AdvPropertyGrid1.PropertySettings.Remove(ps);
            }

            // Set property settings for ObjectCombo
            AdvPropertyGrid1.PropertySettings.Add(new PropertySettings(nameof(Managed3DObject.ObjectCombo))
            {
                Visible = false
            });

            // Set property settings for ObjectComboIndex
            var propSet = new PropertySettings(nameof(Managed3DObject.ObjectComboID));
            var items = objComboList.Select(n => new ComboItem { Text = n.Name, Tag = n.ID.ID }).ToArray();
            var editor = new ComboBoxPropertyEditor(items);
            editor.DropDownWidth = 300;
            editor.SelectedType = SelectedTypes.SelectedComboItem;
            propSet.ValueEditor = editor;
            AdvPropertyGrid1.PropertySettings.Add(propSet);
        }

        public void RegisterEditorHandler(string cbe, EventHandler handler)
        {
            registredHandlers.Add(cbe, handler);
        }

        private void FlushEditorHandlers()
        {
            var canBeRemoved = new List<string>();
            foreach (KeyValuePair<string, EventHandler> kvp in registredHandlers)
            {
                ContentSelectorEditor.ComboBoxEditor editor;
                var switchExpr = kvp.Key;
                switch (switchExpr)
                {
                    case nameof(CbEditorBParam1):
                        editor = CbEditorBParam1;
                        break;

                    case nameof(CbEditorBParam2):
                        editor = CbEditorBParam2;
                        break;

                    case nameof(CbEditorBParam3):
                        editor = CbEditorBParam3;
                        break;

                    case nameof(CbEditorBParam4):
                        editor = CbEditorBParam4;
                        break;

                    default:
                        {
                            editor = null;
                            break;
                        }
                }

                if (editor is object)
                {
                    editor.NeedValues += kvp.Value;
                }
            }

            foreach (string k in canBeRemoved)
                registredHandlers.Remove(k);
        }

        private void ContentSelectorEditor_EditorCreated(object sender, ContentSelectorEditor.EditorCreateEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.Name.ToString();
            switch (switchExpr)
            {
                case var @case when @case == bParamPropName + Conversions.ToString(1):
                    {
                        if (CbEditorBParam1 != e.Editor)
                        {
                            CbEditorBParam1 = e.Editor;
                            CbEditorBParam1.ValueType = TypeCode.Byte;
                            CbEditorBParam1.DisplayMember = nameof(BehaviorInfo.BParamValue.ValueText);
                            CbEditorBParam1.ValueMember = nameof(BehaviorInfo.BParamValue.Value);
                            CbEditorBParam1.DropDownColumns = nameof(BehaviorInfo.BParamValue.ValueText) + "," + nameof(BehaviorInfo.BParamValue.Name);
                            CbEditorBParam1.DropDownColumnsHeaders = $"Value{Constants.vbNewLine}Name";
                            CbEditorBParam1.DropDownHeight = 300;
                            CbEditorBParam1.DropDownWidth = 200;
                        }

                        break;
                    }

                case var case1 when case1 == bParamPropName + Conversions.ToString(2):
                    {
                        if (CbEditorBParam2 != e.Editor)
                        {
                            CbEditorBParam2 = e.Editor;
                            CbEditorBParam2.ValueType = TypeCode.Byte;
                            CbEditorBParam2.DisplayMember = nameof(BehaviorInfo.BParamValue.ValueText);
                            CbEditorBParam2.ValueMember = nameof(BehaviorInfo.BParamValue.Value);
                            CbEditorBParam2.DropDownColumns = nameof(BehaviorInfo.BParamValue.ValueText) + "," + nameof(BehaviorInfo.BParamValue.Name);
                            CbEditorBParam2.DropDownColumnsHeaders = $"Value{Constants.vbNewLine}Name";
                            CbEditorBParam2.DropDownHeight = 300;
                            CbEditorBParam2.DropDownWidth = 200;
                        }

                        break;
                    }

                case var case3 when case3 == bParamPropName + Conversions.ToString(3):
                    {
                        if (CbEditorBParam3 != e.Editor)
                        {
                            CbEditorBParam3 = e.Editor;
                            CbEditorBParam3.ValueType = TypeCode.Byte;
                            CbEditorBParam3.DisplayMember = nameof(BehaviorInfo.BParamValue.ValueText);
                            CbEditorBParam3.ValueMember = nameof(BehaviorInfo.BParamValue.Value);
                            CbEditorBParam3.DropDownColumns = nameof(BehaviorInfo.BParamValue.ValueText) + "," + nameof(BehaviorInfo.BParamValue.Name);
                            CbEditorBParam3.DropDownColumnsHeaders = $"Value{Constants.vbNewLine}Name";
                            CbEditorBParam3.DropDownHeight = 300;
                            CbEditorBParam3.DropDownWidth = 200;
                        }

                        break;
                    }

                case var case4 when case4 == bParamPropName + Conversions.ToString(4):
                    {
                        if (CbEditorBParam4 != e.Editor)
                        {
                            CbEditorBParam4 = e.Editor;
                            CbEditorBParam4.ValueType = TypeCode.Byte;
                            CbEditorBParam4.DisplayMember = nameof(BehaviorInfo.BParamValue.ValueText);
                            CbEditorBParam4.ValueMember = nameof(BehaviorInfo.BParamValue.Value);
                            CbEditorBParam4.DropDownColumns = nameof(BehaviorInfo.BParamValue.ValueText) + "," + nameof(BehaviorInfo.BParamValue.Name);
                            CbEditorBParam4.DropDownColumnsHeaders = $"Value{Constants.vbNewLine}Name";
                            CbEditorBParam4.DropDownHeight = 300;
                            CbEditorBParam4.DropDownWidth = 200;
                        }

                        break;
                    }

                case var case2 when case2 == behaviorPropName:
                    {
                        if (CbEditorBehavAddr != e.Editor)
                        {
                            CbEditorBehavAddr = e.Editor;
                            CbEditorBehavAddr.ValueType = TypeCode.UInt32;
                            CbEditorBehavAddr.IntegerValueMode = Math.Max(Settings.General.IntegerValueMode, 1);
                            CbEditorBehavAddr.DisplayMember = nameof(BehaviorInfo.BehaviorAddressText);
                            CbEditorBehavAddr.ValueMember = nameof(BehaviorInfo.BehaviorAddress);
                            CbEditorBehavAddr.DropDownColumns = nameof(BehaviorInfo.BehaviorAddressText) + "," + nameof(BehaviorInfo.Name);
                            CbEditorBehavAddr.DropDownColumnsHeaders = $"Address{Constants.vbNewLine}Name";
                            CbEditorBehavAddr.DropDownHeight = 400;
                            CbEditorBehavAddr.DropDownWidth = 300;
                            CbEditorBehavAddr.DataSource = myBehaviors;
                            // CbEditorBehavAddr.MultiColumnDisplayControl.Columns(0).AutoSize()
                            // LoadBehaviorAddressesList()
                        }

                        break;
                    }
            }

            FlushEditorHandlers();
        }

        private void ContentSelectorEditor_EditorCreating(object sender, ContentSelectorEditor.EditorCreateEventArgs e)
        {
            var switchExpr = e.PropertyDescriptor.Name;
            switch (switchExpr)
            {
                case var @case when @case == bParamPropName + Conversions.ToString(1):
                    if (CbEditorBParam1 is object)
                        e.Editor = CbEditorBParam1;
                    break;

                case var case1 when case1 == bParamPropName + Conversions.ToString(2):
                    if (CbEditorBParam2 is object)
                        e.Editor = CbEditorBParam2;
                    break;

                case var @case3 when @case3 == bParamPropName + Conversions.ToString(3):
                    if (CbEditorBParam3 is object)
                        e.Editor = CbEditorBParam3;
                    break;

                case var case4 when case4 == bParamPropName + Conversions.ToString(4):
                    if (CbEditorBParam4 is object)
                        e.Editor = CbEditorBParam4;
                    break;

                case var case2 when case2 == behaviorPropName:
                    {
                        if (CbEditorBehavAddr is object)
                        {
                            e.Editor = CbEditorBehavAddr;
                        }

                        break;
                    }
            }
        }

        private void AdvPropertyGrid1_ConvertFromStringToPropertyValue(object sender, ConvertValueEventArgs e)
        {
            bool isConverted = true;
            var switchExpr = e.PropertyDescriptor.PropertyType;
            switch (switchExpr)
            {
                case var @case when @case == typeof(bool):
                    if ((e.StringValue ?? "") == "Yes")
                        e.TypedValue = true;
                    else
                        e.TypedValue = false;
                    break;
                case var case1 when case1 == typeof(byte):
                    e.TypedValue = Conversions.ToByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                    break;
                case var case2 when case2 == typeof(sbyte):
                    e.TypedValue = Conversions.ToSByte(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                    break;
                case var case3 when case3 == typeof(short):
                    e.TypedValue = Conversions.ToShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                    break;
                case var case4 when case4 == typeof(ushort):
                    e.TypedValue = Conversions.ToUShort(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                    break;
                case var case5 when case5 == typeof(int):
                    e.TypedValue = Conversions.ToInteger(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                    break;
                case var case6 when case6 == typeof(uint):
                    e.TypedValue = Conversions.ToUInteger(TextValueConverter.ValueFromText(e.StringValue.Trim()));
                    break;
                case var case7 when case7 == typeof(float):
                    e.TypedValue = Conversions.ToSingle(e.StringValue.Trim());
                    break;
                case var case8 when case8 == typeof(double):
                    e.TypedValue = Conversions.ToDouble(e.StringValue.Trim());
                    break;
                case var case9 when case9 == typeof(decimal):
                    e.TypedValue = Conversions.ToDecimal(e.StringValue.Trim());
                    break;
                default:
                    isConverted = false;
                    break;
            }

            e.IsConverted = isConverted;
        }

        private void AdvPropertyGrid1_ConvertPropertyValueToString(object sender, ConvertValueEventArgs e)
        {
            if (!e.IsConverted && !e.PropertyName.StartsWith(bParamPropName))
            {
                var switchExpr = e.PropertyDescriptor.PropertyType;
                switch (switchExpr)
                {
                    case var @case when @case == typeof(bool):
                        if (Conversions.ToBoolean(e.TypedValue))
                            e.StringValue = "Yes";
                        else
                            e.StringValue = "No";
                        e.IsConverted = true;
                        break;
                    case var case1 when case1 == typeof(byte):
                    case var case2 when case2 == typeof(sbyte):
                    case var case3 when case3 == typeof(short):
                    case var case4 when case4 == typeof(ushort):
                    case var case5 when case5 == typeof(int):
                    case var case6 when case6 == typeof(uint):
                        if ((e.PropertyName ?? "") == (behaviorPropName ?? ""))
                        {
                        }
                        else if (LikeOperator.LikeString(e.PropertyName, "Position?", CompareMethod.Binary) || LikeOperator.LikeString(e.PropertyName, "Rotation?", CompareMethod.Binary))
                        {
                            e.StringValue = Conversions.ToString(e.TypedValue);
                            e.IsConverted = true;
                        }
                        else
                        {
                            e.StringValue = TextValueConverter.TextFromValue(Conversions.ToLong(e.TypedValue));
                            e.IsConverted = true;
                        }
                        break;
                }
            }
        }

        private void AdvPropertyGrid1_PropertiesLoaded(object sender, EventArgs e)
        {
            if (!hasFirstFocued)
            {
                if (CbEditorBParam1 is object && CbEditorBParam2 is object && CbEditorBParam3 is object && CbEditorBParam4 is object)
                {
                    // CbEditorBParam1.Focus()
                    // CbEditorBParam2.Focus()
                    // CbEditorBParam3.Focus()
                    // CbEditorBParam4.Focus()
                    hasFirstFocued = true;
                }
            }
        }

        private void CbEditorBehavAddr_DataColumnCreated(object sender, DataColumnEventArgs e)
        {
            e.ColumnHeader.Width.AutoSize = true;
        }

        private void ProvideBParamContentList(object osender, EventArgs e)
        {
            var sender = osender as ContentSelectorEditor.ComboBoxEditor;            
            uint addr = CurBehavAddr;
            string bpname = "";

            if (sender.Tag == null || (uint)sender.Tag != addr)
            {
                if (sender == CbEditorBParam1)
                    bpname = bParamPropName + Conversions.ToString(1);
                else if (sender == CbEditorBParam2)
                    bpname = bParamPropName + Conversions.ToString(2);
                else if (sender == CbEditorBParam3)
                    bpname = bParamPropName + Conversions.ToString(3);
                else if (sender == CbEditorBParam4)
                    bpname = bParamPropName + Conversions.ToString(4);

                if (!string.IsNullOrEmpty(bpname))
                {
                    var info = myBehaviors.GetByBehaviorAddress(addr);
                    if (info is object)
                    {
                        BehaviorInfo.BParam param = (BehaviorInfo.BParam)info.GetValue(bpname);
                        if (param is object)
                        {
                            // sender.DataSource = Nothing
                            sender.DataSource = param.Values;
                        }
                    }
                }

                sender.Tag = addr;
            }
        }
    }
}