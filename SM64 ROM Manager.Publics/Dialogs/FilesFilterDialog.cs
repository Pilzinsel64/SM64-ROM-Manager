using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Publics
{
    public partial class FilesFilterDialog
    {
        private string _Filter = "";

        public FilesFilterDialog()
        {

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            base.UpdateAmbientColors();
        }

        public string Filter
        {
            get
            {
                return _Filter;
            }

            set
            {
                if ((_Filter ?? "") != (value ?? ""))
                {
                    _Filter = value;
                    ParseFilter();
                }
            }
        }

        public int FilterIndex
        {
            get
            {
                return ComboBoxEx1.SelectedIndex + 1;
            }

            set
            {
                ComboBoxEx1.SelectedIndex = value - 1;
            }
        }

        public string FileExtension
        {
            get
            {
                ComboItem ci = (ComboItem)ComboBoxEx1.SelectedItem;
                return Conversions.ToString(ci.Tag);
            }
        }

        private void ParseFilter()
        {
            var splitted = _Filter.Split('|');
            ComboBoxEx1.Items.Clear();
            for (int i = 0, loopTo = splitted.Length - 1; i <= loopTo; i += 2)
            {
                var ci = new ComboItem()
                {
                    Text = splitted[i],
                    Tag = splitted[i + 1]
                };
                ComboBoxEx1.Items.Add(ci);
            }

            if (ComboBoxEx1.Items.Count > 0)
            {
                FilterIndex = 1;
            }
        }
    }
}