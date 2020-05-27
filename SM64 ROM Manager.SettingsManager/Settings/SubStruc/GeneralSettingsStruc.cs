using SM64Lib;
using System;

namespace SM64_ROM_Manager.SettingsManager
{
    public class GeneralSettingsStruc
    {
        public int IntegerValueMode { get; set; }
        public string EmulatorPath { get; set; }
        public System.Windows.Forms.DialogResult ActionIfUpdatePatches { get; set; }
        public System.Windows.Forms.AutoScaleMode AutoScaleMode { get; set; }
        public HexEditModeStruc HexEditMode { get; set; }
        public string Language { get; set; }
        public NotificationMode RomChangedNotification { get; set; }
        public Version LastThankYouPageSeen { get; set; }
        public RecalcChecksumBehavior RecalcChecksumBehavior { get; set; }

        public void ResetValues()
        {
            IntegerValueMode = 0;
            EmulatorPath = "";
            ActionIfUpdatePatches = System.Windows.Forms.DialogResult.None;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            if (HexEditMode is null)
                HexEditMode = new HexEditModeStruc();
            HexEditMode.ResetValues();
            Language = string.Empty;
            RomChangedNotification = NotificationMode.Popup;
            LastThankYouPageSeen = null;
            RecalcChecksumBehavior = RecalcChecksumBehavior.Always;
        }
    }
}