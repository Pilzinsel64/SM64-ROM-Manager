using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
        [JsonConverter(typeof(VersionConverter))]
        [JsonProperty(nameof(LastThankYouPageSeen) + "2")]
        public Version LastThankYouPageSeen { get; set; }
        public RecalcChecksumBehavior RecalcChecksumBehavior { get; set; }
        public bool UseInternalBrowser { get; set; }
        public bool OpenThankYouFormAfterUpdates { get; set; }

        public void ResetValues()
        {
            IntegerValueMode = 0;
            EmulatorPath = string.Empty;
            ActionIfUpdatePatches = System.Windows.Forms.DialogResult.None;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            if (HexEditMode is null)
                HexEditMode = new HexEditModeStruc();
            HexEditMode.ResetValues();
            Language = string.Empty;
            RomChangedNotification = NotificationMode.Popup;
            LastThankYouPageSeen = null;
            RecalcChecksumBehavior = RecalcChecksumBehavior.Always;
            UseInternalBrowser = true;
            OpenThankYouFormAfterUpdates = true;
        }
    }
}