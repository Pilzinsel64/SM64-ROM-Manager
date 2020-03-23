
namespace SM64_ROM_Manager.PatchScripts
{
    public partial class TweakProfileEditor
    {
        public TweakProfileEditor()
        {

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
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