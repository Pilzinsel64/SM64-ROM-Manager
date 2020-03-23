
namespace SM64_ROM_Manager.SettingsManager
{
    public class ModelConverterSettingsStruc
    {
        public bool UseLegacyCollisionDescriptions { get; set; }

        public void ResetValues()
        {
            UseLegacyCollisionDescriptions = false;
        }
    }
}