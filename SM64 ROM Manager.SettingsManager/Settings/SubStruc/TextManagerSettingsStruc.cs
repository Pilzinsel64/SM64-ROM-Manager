
namespace SM64_ROM_Manager.SettingsManager
{
    public class TextManagerSettingsStruc
    {
        public bool ForceUpperCaseForActAndLevelNames { get; set; }
        public bool AutoDetectStartEndQuotationMarks { get; set; }
        public bool AutoFocusEditorTextBox { get; set; }

        public void ResetValues()
        {
            ForceUpperCaseForActAndLevelNames = true;
            AutoDetectStartEndQuotationMarks = true;
            AutoFocusEditorTextBox = false;
        }
    }
}