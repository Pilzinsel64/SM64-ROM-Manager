using global::System.IO;
using global::System.Windows.Forms;
using global::Pilz.Configuration;

namespace SM64_ROM_Manager.SettingsManager
{
    public class Settings
    {
        private static bool enableAutoSave = false;
        private static SettingsManager<SettingsStruc> managerInstance;

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static SettingsStruc Instance
        {
            get
            {
                if (managerInstance is null)
                {
                    managerInstance = new SettingsManager<SettingsStruc>(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Data\Settings.json"), enableAutoSave);
                }

                return managerInstance.Instance;
            }
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static SettingsManager<SettingsStruc> MySettingsManager
        {
            get
            {
                return managerInstance;
            }
        }

        public static bool AutoSave
        {
            get
            {
                return enableAutoSave;
            }

            set
            {
                enableAutoSave = value;
                if (managerInstance is object)
                {
                    managerInstance.AutoSaveOnExit = value;
                }
            }
        }

        public static string SettingsConfigFilePath
        {
            get
            {
                return Instance.SettingsManager.ConfigFilePath;
            }

            set
            {
                Instance.SettingsManager.ConfigFilePath = value;
            }
        }

        public static void SaveSettings()
        {
            Instance.SettingsManager.Save();
        }

        public static void ResetSettings()
        {
            Instance.ResetValues();
        }

        public static AreaEditorSettingsStruc AreaEditor
        {
            get
            {
                return Instance.AreaEditor;
            }
        }

        public static GeneralSettingsStruc General
        {
            get
            {
                return Instance.General;
            }
        }

        public static StyleManagerSettingsStruc StyleManager
        {
            get
            {
                return Instance.StyleManager;
            }
        }

        public static FileParserSettingsStruc FileParser
        {
            get
            {
                return Instance.FileParser;
            }
        }

        public static RecentFilesSettingsStruc RecentFiles
        {
            get
            {
                return Instance.RecentFiles;
            }
        }

        public static ModelConverterSettingsStruc ModelConverter
        {
            get
            {
                return Instance.ModelConverter;
            }
        }

        public static JobsToDoStruc JobsToDo
        {
            get
            {
                return Instance.JobsToDo;
            }
        }

        public static TextManagerSettingsStruc TextManager
        {
            get
            {
                return Instance.TextManager;
            }
        }

        public static NetworkSettingsStruc Network
        {
            get
            {
                return Instance.Network;
            }
        }

        public static WindowSettingsStruc WindowSettings
        {
            get
            {
                return Instance.WindowSettings;
            }
        }

        public static LevelManagerSettingsStruc LevelManager
        {
            get => Instance.LevelManager;
        }

    }
}