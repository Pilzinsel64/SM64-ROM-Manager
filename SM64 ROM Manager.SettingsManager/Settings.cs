using global::System.IO;
using global::System.Windows.Forms;
using global::Pilz.Configuration;

namespace SM64_ROM_Manager.SettingsManager
{
    public class Settings
    {
        private static string settingsFilePath = string.Empty;
        private static bool enableAutoSave = false;
        private static SettingsManager<SettingsStruc> managerInstance;
        private static bool hasInstance = false;

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static SettingsStruc Instance
        {
            get
            {
                if (string.IsNullOrEmpty(settingsFilePath))
                    throw new FileNotFoundException("Settings file not setted up!");

                if (!hasInstance)
                {
                    managerInstance = new SettingsManager<SettingsStruc>(settingsFilePath, enableAutoSave);
                    hasInstance = true;
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
                return hasInstance ? Instance.SettingsManager.ConfigFilePath : settingsFilePath;
            }

            set
            {
                if (hasInstance)
                    Instance.SettingsManager.ConfigFilePath = value;
                else
                    settingsFilePath = value;
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