namespace SM64_ROM_Manager.SettingsManager
{
    public class HexEditModeStruc
    {
        public HexEditModes Mode { get; set; }
        public string CustomPath { get; set; }

        public void ResetValues()
        {
            Mode = HexEditModes.None;
            CustomPath = string.Empty;
        }
    }
}