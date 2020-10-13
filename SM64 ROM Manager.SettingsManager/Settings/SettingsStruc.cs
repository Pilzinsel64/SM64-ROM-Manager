using global::Pilz.Configuration;

namespace SM64_ROM_Manager.SettingsManager
{
    public class SettingsStruc : SettingsBase
    {
        public AreaEditorSettingsStruc AreaEditor { get; set; }
        public GeneralSettingsStruc General { get; set; }
        public StyleManagerSettingsStruc StyleManager { get; set; }
        public FileParserSettingsStruc FileParser { get; set; }
        public RecentFilesSettingsStruc RecentFiles { get; set; }
        public ModelConverterSettingsStruc ModelConverter { get; set; }
        public JobsToDoStruc JobsToDo { get; set; }
        public TextManagerSettingsStruc TextManager { get; set; }
        public NetworkSettingsStruc Network { get; set; }
        public WindowSettingsStruc WindowSettings { get; set; }
        public LevelManagerSettingsStruc LevelManager { get; set; }

        public override void ResetValues()
        {
            if (AreaEditor is null)
                AreaEditor = new AreaEditorSettingsStruc();
            AreaEditor.ResetValues();
            if (General is null)
                General = new GeneralSettingsStruc();
            General.ResetValues();
            if (StyleManager is null)
                StyleManager = new StyleManagerSettingsStruc();
            StyleManager.ResetValues();
            if (FileParser is null)
                FileParser = new FileParserSettingsStruc();
            FileParser.ResetValues();
            if (RecentFiles is null)
                RecentFiles = new RecentFilesSettingsStruc();
            RecentFiles.ResetValues();
            if (ModelConverter is null)
                ModelConverter = new ModelConverterSettingsStruc();
            ModelConverter.ResetValues();
            if (JobsToDo is null)
                JobsToDo = new JobsToDoStruc();
            JobsToDo.Clear();
            if (TextManager is null)
                TextManager = new TextManagerSettingsStruc();
            TextManager.ResetValues();
            if (Network is null)
                Network = new NetworkSettingsStruc();
            Network.ResetValues();
            if (WindowSettings is null)
                WindowSettings = new WindowSettingsStruc();
            WindowSettings.ResetValues();
            if (LevelManager is null)
                LevelManager = new LevelManagerSettingsStruc();
            LevelManager.ResetValues();
        }
    }
}