using global::DevComponents.Editors;
using global::SM64_ROM_Manager.ModelConverterGUI.My.Resources;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Model;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public static class PublicFunctions
    {
        public static (ObjectModel mdl, bool hasVisualMap, bool hasCollision)? GetModelViaModelConverter(bool? allowCheckingVisualMap = default, bool? allowCheckingCollision = default, bool? loadVisualMapAsDefault = default, bool? loadCollisionAsDefault = default, sbyte? forceDisplaylist = default, string inputsKey = "")
        {
            var frm = new MainModelConverter();
            if (loadVisualMapAsDefault is object)
            {
                frm.CheckBoxX_ConvertModel.Checked = loadVisualMapAsDefault == true;
            }

            if (loadCollisionAsDefault is object)
            {
                frm.CheckBoxX_ConvertCollision.Checked = loadCollisionAsDefault == true;
            }

            if (allowCheckingVisualMap is object)
            {
                frm.CheckBoxX_ConvertModel.Enabled = allowCheckingVisualMap == true;
            }

            if (allowCheckingCollision is object)
            {
                frm.CheckBoxX_ConvertCollision.Enabled = allowCheckingCollision == true;
            }

            if (forceDisplaylist is object)
            {
                frm.ForceDisplaylist = (sbyte)forceDisplaylist;
            }

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (frm.ResModel, frm.CheckBoxX_ConvertModel.Checked, frm.CheckBoxX_ConvertCollision.Checked);
            }
            else
            {
                return default;
            }
        }

        internal static ComboItem[] GetDefaultGeolayerComboItems()
        {
            return new[] { new ComboItem() { Text = $"0 - {MainModelconverter_Resources.Layer0}", Tag = DefaultGeolayers.SolidNoAntiAlias }, new ComboItem() { Text = $"1 - {MainModelconverter_Resources.Layer1}", Tag = DefaultGeolayers.Solid }, new ComboItem() { Text = $"2 - {MainModelconverter_Resources.Layer2}", Tag = DefaultGeolayers.SolidDecal }, new ComboItem() { Text = $"3 - {MainModelconverter_Resources.Layer3}", Tag = DefaultGeolayers.TranslucentDecal }, new ComboItem() { Text = $"4 - {MainModelconverter_Resources.Layer4}", Tag = DefaultGeolayers.Alpha }, new ComboItem() { Text = $"5 - {MainModelconverter_Resources.Layer5}", Tag = DefaultGeolayers.Translucent }, new ComboItem() { Text = $"6 - {MainModelconverter_Resources.Layer6}", Tag = DefaultGeolayers.TranslucentDecal2 }, new ComboItem() { Text = $"7 - {MainModelconverter_Resources.Layer7}", Tag = DefaultGeolayers.TranslucentDecal3 } };
        }
    }
}