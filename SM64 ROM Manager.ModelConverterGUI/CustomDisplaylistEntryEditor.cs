using System;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Model.Conversion.Fast3DWriting;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public partial class CustomDisplaylistEntryEditor
    {

        // E v e n t s

        public event RemoveButtonClickedEventHandler RemoveButtonClicked;

        public delegate void RemoveButtonClickedEventHandler(CustomDisplaylistEntryEditor sender);

        // F i e l d s   &   A u t o m a t i c   P r o p e r t i e s

        private bool isLoading = true;

        public DisplaylistProps Props { get; private set; }

        // P r o p e r t i e s

        private int SelectedID
        {
            get
            {
                return IntegerInput_ID.Value;
            }

            set
            {
                IntegerInput_ID.Value = value;
            }
        }

        private DefaultGeolayers SelectedLayer
        {
            get
            {
                return (DefaultGeolayers)((ComboItem)ComboBoxEx_Layer.SelectedItem).Tag;
            }

            set
            {
                foreach (ComboItem item in ComboBoxEx_Layer.Items)
                {
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(item.Tag, value, false))
                    {
                        ComboBoxEx_Layer.SelectedItem = item;
                    }
                }
            }
        }

        // C o n s t r u c t o r

        public CustomDisplaylistEntryEditor(DisplaylistProps props)
        {
            Props = props;
            InitializeComponent();
            StyleManager.UpdateAmbientColors(this);
            ComboBoxEx_Layer.Items.AddRange(PublicFunctions.GetDefaultGeolayerComboItems());
            LoadProps();
            isLoading = false;
        }

        // F e a t u r e s

        private void LoadProps()
        {
            SelectedLayer = Props.Layer;
            SelectedID = Props.ID;
        }

        // G U I

        private void ComboBoxEx_Layer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                Props.Layer = SelectedLayer;
            }
        }

        private void IntegerInput_ID_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                Props.ID = SelectedID;
            }
        }

        private void ButtonX_Remove_Click(object sender, EventArgs e)
        {
            RemoveButtonClicked?.Invoke(this);
        }
    }
}