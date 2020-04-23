using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM64Lib.Objects.ObjectBanks;
using SM64Lib;
using static SM64Lib.TextValueConverter.TextValueConverter;
using Z.Collections.Extensions;

namespace SM64_ROM_Manager
{
    public partial class CustomObjectImportPropsEditor : UserControl
    {
        private readonly CustomObject customObject;
        private readonly CustomObjectImport import;
        private readonly RomManager rommgr;
        private readonly bool hasInit = false;

        public CustomObjectImportPropsEditor(CustomObject customObject, CustomObjectImport import, RomManager rommgr)
        {
            this.customObject = customObject;
            this.import = import;
            this.rommgr = rommgr;

            InitializeComponent();

            TextBoxX_Name.Text = customObject.Name;
            if (!customObject.ModelProps.UseCustomModelID && customObject.ModelProps.Model is object && import.CustomModels.ContainsKey(customObject.ModelProps.Model))
                TextBoxX_ModelID.Text = TextFromValue(import.CustomModels[customObject.ModelProps.Model].ModelID);
            else
            {
                foreach (Control control in Controls)
                {
                    if (control.Tag == "mdl")
                        control.Visible = false;
                }
                TextBoxX_Name.Left = Left - 3;
            }

            hasInit = true;
        }

        private void TextBoxX_ModelID_TextChanged(object sender, EventArgs e)
        {
            if (hasInit)
                import.CustomModels[customObject.ModelProps.Model].ModelID = (byte)ValueFromText(TextBoxX_ModelID.Text);
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            var frm = new CustomModelSelector(rommgr);

            if (!import.DestModelBanks.TryGetValue(customObject.ModelProps.Model, out var destMdl))
                destMdl = null;
            frm.SetAsBankPicker(destMdl);

            if (frm.ShowDialog() == DialogResult.OK)
                import.DestModelBanks.AddOrUpdate(customObject.ModelProps.Model, frm.SelectedBank);
        }

        private void TextBoxX_Name_TextChanged(object sender, EventArgs e)
        {
            if (hasInit)
                customObject.Name = TextBoxX_Name.Text.Trim();
        }

        private void CheckBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = checkBoxX1.Checked;

            panel1.Enabled = isChecked;

            if (isChecked)
                import.IgnoreCustomObjects.RemoveIfContains(customObject);
            else
                import.IgnoreCustomObjects.AddIfNotContains(customObject);
        }
    }
}
