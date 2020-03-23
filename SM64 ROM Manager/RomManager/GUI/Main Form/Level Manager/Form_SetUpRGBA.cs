using global::DevComponents.DotNetBar;

namespace SM64_ROM_Manager
{
    public partial class Form_SetUpRGBA
    {
        public Form_SetUpRGBA()
        {

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            StyleManager.UpdateAmbientColors(this);
        }
    }
}