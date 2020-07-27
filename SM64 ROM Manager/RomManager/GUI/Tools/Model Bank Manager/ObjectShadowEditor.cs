using DevComponents.DotNetBar;
using DevComponents.Editors;
using SM64Lib.Geolayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class ObjectShadowEditor : OfficeForm
    {
        public ObjectShadow ObjectShadow { get; private set; }

        public ObjectShadowEditor(ObjectShadow shadow)
        {
            ObjectShadow = shadow;
            InitializeComponent();
            ComboBoxEx_Type.ValueMember = nameof(Tag);

            // Add values to combobox
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.Circle_9Verts), Tag = ObjectShadowType.Circle_9Verts });
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.Circle_4Verts), Tag = ObjectShadowType.Circle_4Verts });
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.Circle_4Verts_Flat_Unused), Tag = ObjectShadowType.Circle_4Verts_Flat_Unused });
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.SquarePermanent), Tag = ObjectShadowType.SquarePermanent });
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.SquareScaleable), Tag = ObjectShadowType.SquareScaleable });
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.SquareTooglable), Tag = ObjectShadowType.SquareTooglable });
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.RectangleHardcodedOffset), Tag = ObjectShadowType.RectangleHardcodedOffset });
            ComboBoxEx_Type.Items.Add(new ComboItem { Text = nameof(ObjectShadowType.CirclePlayer), Tag = ObjectShadowType.CirclePlayer });
        }

        private void LoadProps()
        {
            ComboBoxEx_Type.SelectedValue = ObjectShadow.Type;
            IntegerInput_Diameter.Value = ObjectShadow.Scale;
            IntegerInput_Opacity.Value = ObjectShadow.Solidity;
        }

        private void SaveProps()
        {
            ObjectShadow.Type = (ObjectShadowType)ComboBoxEx_Type.SelectedValue;
            ObjectShadow.Scale = (short)IntegerInput_Diameter.Value;
            ObjectShadow.Solidity = (byte)IntegerInput_Opacity.Value;
        }

        private void ButtonX_Save_Click(object sender, EventArgs e)
        {
            SaveProps();
        }

        private void ObjectShadowEditor_Load(object sender, EventArgs e)
        {
            LoadProps();
        }
    }
}
