using System;
using DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class PackageDescriptionEditor
    {

        // C o n s t r u c t o r s

        public PackageDescriptionEditor()
        {
            InitializeComponent();

            comboBoxEx_Format.Items.AddRange(new ComboItem[]
            {
                new ComboItem { Text = "Nur Text",  Tag = UpdateNotesContentType.PlainText },
                new ComboItem { Text = "Markdown",  Tag = UpdateNotesContentType.Markdown },
                new ComboItem { Text = "HTML",      Tag = UpdateNotesContentType.HTML },
            });

            UpdateAmbientColors();
        }

        // P r o p e r t i e s

        public string Titel
        {
            get
            {
                return textBoxX1.Text;
            }
            set
            {
                textBoxX1.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return textBoxX2.Text;
            }
            set
            {
                textBoxX2.Text = value;
            }
        }

        public UpdateNotesContentType DescriptionType
        {
            get =>
                (UpdateNotesContentType)(comboBoxEx_Format.SelectedItem as ComboItem)?.Tag;
            set
            {
                foreach (ComboItem item in comboBoxEx_Format.Items)
                    if ((UpdateNotesContentType)item.Tag == value)
                        comboBoxEx_Format.SelectedItem = item;
            }
        }
    }
}