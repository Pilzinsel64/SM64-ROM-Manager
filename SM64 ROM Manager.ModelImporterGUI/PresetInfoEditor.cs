
namespace SM64_ROM_Manager.ModelImporterGUI
{
    public partial class InfoEditor
    {
        public InfoEditor()
        {
            InitializeComponent();
            base.UpdateAmbientColors();
        }

        public string Titel
        {
            get
            {
                return TextBoxX1.Text;
            }

            set
            {
                TextBoxX1.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return TextBoxX2.Text;
            }

            set
            {
                TextBoxX2.Text = value;
            }
        }
    }
}