using System;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class ApplicationVersionInput
    {

        // C o n s t r u c t o r s

        public ApplicationVersionInput()
        {
            InitializeComponent();

            // Init Channel-ComboBox
            ComboBoxEx_Channel.Items.Add(new ComboItem() { Text = My.Resources.UpdatingAdministrationLangRes.Channel_Stable, Tag = Channels.Stable });
            ComboBoxEx_Channel.Items.Add(new ComboItem() { Text = My.Resources.UpdatingAdministrationLangRes.Channel_PreRelease, Tag = Channels.PreRelease });
            ComboBoxEx_Channel.Items.Add(new ComboItem() { Text = My.Resources.UpdatingAdministrationLangRes.Channel_Beta, Tag = Channels.Beta });
            ComboBoxEx_Channel.Items.Add(new ComboItem() { Text = My.Resources.UpdatingAdministrationLangRes.Channel_Alpha, Tag = Channels.Alpha });
            ComboBoxEx_Channel.SelectedIndex = 0;
        }

        // P r o p e r t i e s

        public string VersionName
        {
            get
            {
                return TextBoxX_VersionName.Text;
            }

            set
            {
                TextBoxX_VersionName.Text = value;
            }
        }

        public Version Version
        {
            get
            {
                return new Version(TextBoxX_Version.Text.Trim());
            }

            set
            {
                TextBoxX_Version.Text = value.ToString();
            }
        }

        public Channels Channel
        {
            get
            {
                return (Channels)((ComboItem)ComboBoxEx_Channel.SelectedItem).Tag;
            }

            set
            {
                foreach (ComboItem ci in ComboBoxEx_Channel.Items)
                {
                    if ((Channels)ci.Tag == value)
                    {
                        ComboBoxEx_Channel.SelectedItem = ci;
                    }
                }
            }
        }

        public uint Build
        {
            get
            {
                return Conversions.ToUInteger(IntegerInput_Build.Value);
            }

            set
            {
                IntegerInput_Build.Value = Conversions.ToInteger(value);
            }
        }
    }
}