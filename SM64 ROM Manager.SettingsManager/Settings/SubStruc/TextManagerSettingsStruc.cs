
namespace SM64_ROM_Manager.SettingsManager
{
    public class TextManagerSettingsStruc
    {
        public bool ForceUpperCaseForActAndLevelNames { get; set; }

        public void ResetValues()
        {
            ForceUpperCaseForActAndLevelNames = true;
        }
    }
}