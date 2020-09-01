using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.EventArguments;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64Lib.Levels;
using global::SM64Lib.Objects.ObjectBanks.Data;
using SM64Lib.TextValueConverter;
using System.Linq;

namespace SM64_ROM_Manager
{
    public partial class Tab_LevelManager
    {
        // F l a g s

        private bool LM_LoadingAreaList = false;
        private bool LM_SavingRom = false;
        private bool LM_LoadingArea = false;
        private bool LM_LoadingLevel = false;

        // F i e l d s

        // W i t h E v e n t s

        private MainController _Controller;
        private ObjectBankSelectorBox _ObjectBankSelectorBox_C;
        private ObjectBankSelectorBox _ObjectBankSelectorBox_D;
        private ObjectBankSelectorBox _ObjectBankSelectorBox_9;

        public MainController Controller
        {
            get
            {
                return _Controller;
            }
            set
            {
                if (_Controller != null)
                {

                    // C o n t r o l l e r   E v e n t s

                    _Controller.RomLoaded -= Controller_RomLoaded;
                    _Controller.MusicSequenceAdded -= Controller_MusicSequenceAdded;
                    _Controller.MusicSequenceChanged -= Controller_MusicSequenceChanged;
                    _Controller.MusicSequenceRemoved -= Controller_MusicSequenceRemoved;
                    _Controller.RomMusicLoaded -= Controller_RomMusicLoaded;
                    _Controller.LevelSpecialItemAdded -= Controller_LevelSpecialItemAdded;
                    _Controller.LevelSpecialItemRemoved -= Controller_LevelSpecialItemRemoved;
                    _Controller.LevelSpecialItemChanged -= Controller_LevelSpecialItemChanged;
                    _Controller.LevelAdded -= Controller_LevelAdded;
                    _Controller.LevelBackgroundModeChanged -= Controller_LevelBackgroundModeChanged;
                    _Controller.LevelAreaBackgroundModeChanged -= Controller_LevelAreaBackgroundModeChanged;
                    _Controller.LevelBackgroundImageChanged -= Controller_LevelBackgroundImageChanged;
                    _Controller.LevelRemoved -= Controller_LevelRemoved;
                    _Controller.LevelIDChanged -= Controller_LevelIDAndCustomNameChanged;
                    _Controller.LevelCustomNameChanged -= Controller_LevelIDAndCustomNameChanged;
                    _Controller.LevelAreaAdded -= Controller_LevelAreaAdded;
                    _Controller.LevelAreaRemoved -= Controller_LevelAreaRemoved;
                    _Controller.LevelAreaScrollingTextureCountChanged -= Controller_LevelAreaScrollingTextureCountChanged;
                    _Controller.ObjectBankDataChanged -= Controller_ObjectBankDataChanged;
                    _Controller.LevelAreaIDChanged -= Controller_LevelAreaIDChanged;
                }

                _Controller = value;
                if (_Controller != null)
                {
                    _Controller.RomLoaded += Controller_RomLoaded;
                    _Controller.MusicSequenceAdded += Controller_MusicSequenceAdded;
                    _Controller.MusicSequenceChanged += Controller_MusicSequenceChanged;
                    _Controller.MusicSequenceRemoved += Controller_MusicSequenceRemoved;
                    _Controller.RomMusicLoaded += Controller_RomMusicLoaded;
                    _Controller.LevelSpecialItemAdded += Controller_LevelSpecialItemAdded;
                    _Controller.LevelSpecialItemRemoved += Controller_LevelSpecialItemRemoved;
                    _Controller.LevelSpecialItemChanged += Controller_LevelSpecialItemChanged;
                    _Controller.LevelAdded += Controller_LevelAdded;
                    _Controller.LevelBackgroundModeChanged += Controller_LevelBackgroundModeChanged;
                    _Controller.LevelAreaBackgroundModeChanged += Controller_LevelAreaBackgroundModeChanged;
                    _Controller.LevelBackgroundImageChanged += Controller_LevelBackgroundImageChanged;
                    _Controller.LevelRemoved += Controller_LevelRemoved;
                    _Controller.LevelIDChanged += Controller_LevelIDAndCustomNameChanged;
                    _Controller.LevelCustomNameChanged += Controller_LevelIDAndCustomNameChanged;
                    _Controller.LevelAreaAdded += Controller_LevelAreaAdded;
                    _Controller.LevelAreaRemoved += Controller_LevelAreaRemoved;
                    _Controller.LevelAreaScrollingTextureCountChanged += Controller_LevelAreaScrollingTextureCountChanged;
                    _Controller.LevelAreaIDChanged += Controller_LevelAreaIDChanged;
                }
            }
        }

        private ObjectBankSelectorBox ObjectBankSelectorBox_C
        {
            get
            {
                return _ObjectBankSelectorBox_C;
            }
            set
            {
                if (_ObjectBankSelectorBox_C != null)
                {
                    _ObjectBankSelectorBox_C.SelectedComboIndexChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                    _ObjectBankSelectorBox_C.SelectedComboIndexChanged -= LM_UpdateObjectBankList;
                }

                _ObjectBankSelectorBox_C = value;
                if (_ObjectBankSelectorBox_C != null)
                {
                    _ObjectBankSelectorBox_C.SelectedComboIndexChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                    _ObjectBankSelectorBox_C.SelectedComboIndexChanged += LM_UpdateObjectBankList;
                }
            }
        }

        private ObjectBankSelectorBox ObjectBankSelectorBox_D
        {
            get
            {
                return _ObjectBankSelectorBox_D;
            }
            set
            {
                if (_ObjectBankSelectorBox_D != null)
                {
                    _ObjectBankSelectorBox_D.SelectedComboIndexChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                    _ObjectBankSelectorBox_D.SelectedComboIndexChanged -= LM_UpdateObjectBankList;
                }

                _ObjectBankSelectorBox_D = value;
                if (_ObjectBankSelectorBox_D != null)
                {
                    _ObjectBankSelectorBox_D.SelectedComboIndexChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                    _ObjectBankSelectorBox_D.SelectedComboIndexChanged += LM_UpdateObjectBankList;
                }
            }
        }

        private ObjectBankSelectorBox ObjectBankSelectorBox_9
        {
            get
            {
                return _ObjectBankSelectorBox_9;
            }
            set
            {
                if (_ObjectBankSelectorBox_9 != null)
                {
                    _ObjectBankSelectorBox_9.SelectedComboIndexChanged -= (_, __) => Controls_HandleToSaveLevelSettings();
                    _ObjectBankSelectorBox_9.SelectedComboIndexChanged -= LM_UpdateObjectBankList;
                }

                _ObjectBankSelectorBox_9 = value;
                if (_ObjectBankSelectorBox_9 != null)
                {
                    _ObjectBankSelectorBox_9.SelectedComboIndexChanged += (_, __) => Controls_HandleToSaveLevelSettings();
                    _ObjectBankSelectorBox_9.SelectedComboIndexChanged += LM_UpdateObjectBankList;
                }
            }
        }

        // P r o p e r t i e s

        private (int levelIndex, int areaIndex) CurrentIndicies
        {
            get
            {
                return (CurrentLevelIndex, CurrentAreaIndex);
            }
        }

        private int CurrentAreaIndex
        {
            get
            {
                return ListBoxAdv_LM_Areas.SelectedIndex;
            }
        }

        private int CurrentLevelIndex
        {
            get
            {
                return ListBoxAdv_LM_Levels.SelectedIndex;
            }
        }

        private bool AllowSavingLevelSettings
        {
            get
            {
                return !(Controller == null || Controller.IsLoadingRom) && !LM_LoadingLevel && CurrentLevelIndex > -1;
            }
        }

        private bool AllowSavingAreaSettings
        {
            get
            {
                return AllowSavingLevelSettings && !LM_LoadingAreaList && !LM_LoadingArea && CurrentAreaIndex > -1;
            }
        }

        private int CurrentSpecialBoxIndex
        {
            get
            {
                var indicies = ListViewEx_LM_Specials.SelectedIndices;
                if (indicies.Count > 0)
                {
                    return indicies[0];
                }
                else
                {
                    return -1;
                }
            }
        }

        private void Controller_RomLoaded()
        {
            LoadObjectBankListBoxEntries();
            LoadLevelList();
        }

        private void Controller_MusicSequenceAdded(MusicSequenceEventArgs e)
        {
            AddSequenceToList(e.Index);
        }

        private void Controller_MusicSequenceChanged(MusicSequenceEventArgs e)
        {
            UpdateSequenceInList(e.Index);
        }

        private void Controller_MusicSequenceRemoved(MusicSequenceEventArgs e)
        {
            RemoveSequenceFromList(e.Index);
        }

        private void Controller_RomMusicLoaded()
        {
            LoadSequenceList();
        }

        private void Controller_LevelSpecialItemAdded(SpecialItemEventArgs e)
        {
            if (e.AreaIndex == CurrentAreaIndex)
            {
                AddSpecialItemToList(e.LevelIndex, e.AreaIndex, e.ItemIndex, true);
            }
        }

        private void Controller_LevelSpecialItemRemoved(SpecialItemEventArgs e)
        {
            RemoveSpecialItemFromList(e.ItemIndex);
        }

        private void Controller_LevelSpecialItemChanged(SpecialItemEventArgs e)
        {
            if (e.AreaIndex == CurrentAreaIndex)
            {
                UpdateSpecialBoxItem(e);
            }
        }

        private void Controller_LevelAdded(LevelEventArgs e)
        {
            AddLevelToList(e.LevelID);
        }

        private void Controller_LevelBackgroundModeChanged(LevelBackgroundModeChangedEventArgs e)
        {
            HandleBackgroundModeChange(e);
        }

        private void Controller_LevelAreaBackgroundModeChanged(LevelAreaBackgroundModeChangedEventArgs e)
        {
            if (e.BackgroundType == AreaBGs.Color)
            {
                LoadAreaBackgroundColor(e.BackgroundColor);
            }
        }

        private void Controller_LevelBackgroundImageChanged(LevelBackgroundImageChangedEventArgs e)
        {
            PictureBox_BGImage.Image = e.BackgroundImage;
        }

        private void Controller_LevelRemoved(LevelEventArgs e)
        {
            RemoveLevelFromList(e.LevelIndex);
        }

        private void Controller_LevelIDAndCustomNameChanged(LevelEventArgs e)
        {
            UpdateLevelItemInList(e.LevelIndex, e.LevelID);
        }

        private void Controller_LevelAreaAdded(LevelAreaEventArgs e)
        {
            AddAreaToList(Conversions.ToByte(e.AreaIndex));
        }

        private void Controller_LevelAreaRemoved(LevelAreaEventArgs e)
        {
            RemoveAreaFromList(e.AreaIndex);
        }

        private void Controller_LevelAreaScrollingTextureCountChanged(LevelAreaEventArgs e)
        {
            if (CurrentLevelIndex == e.LevelIndex && CurrentAreaIndex == e.AreaIndex)
            {
                LoadScrollTexCount();
            }
        }

        private void Controller_ObjectBankDataChanged()
        {
            LoadObjectBankListBoxEntries();
        }

        private void Controller_LevelAreaIDChanged(LevelAreaEventArgs e)
        {
            UpdateLevelAreaButton(e.LevelIndex, e.AreaIndex, e.AreaID);
        }

        // C o n s t r u c t o r

        public Tab_LevelManager()
        {
            ObjectBankSelectorBox_C = new ObjectBankSelectorBox() { Dock = DockStyle.Fill, ContentLabelText = "Content of Bank 0xC" };
            ObjectBankSelectorBox_D = new ObjectBankSelectorBox() { Dock = DockStyle.Fill, ContentLabelText = "Content of Bank 0xD" };
            ObjectBankSelectorBox_9 = new ObjectBankSelectorBox() { Dock = DockStyle.Fill, ContentLabelText = "Content of Bank 0x9" };

            InitializeComponent();
            SwitchButton_UseGlobalObjectBank.Enabled = true;

            // Add ObjectBankSelectorBoxes
            TableLayoutPanel_ObjectBankSelectorBoxes.Controls.Add(ObjectBankSelectorBox_C, 0, 0);
            TableLayoutPanel_ObjectBankSelectorBoxes.Controls.Add(ObjectBankSelectorBox_D, 1, 0);
            TableLayoutPanel_ObjectBankSelectorBoxes.Controls.Add(ObjectBankSelectorBox_9, 2, 0);

            var reverbLevels = Enum.GetValues(typeof(AreaReverbLevel));
            Slider_AreaReverbLevel.Maximum = reverbLevels.Length - 1;
        }

        // F e a t u r e s   &   G U I

        private void LoadSequenceList()
        {
            // Remember old Index
            int IndexBefore = ComboBox_LM_Music.SelectedIndex;

            // Clear Items
            ComboBox_LM_Music.Items.Clear();

            // Add new items
            for (int i = 0, loopTo = Controller.GetMusicSeuenceCount() - 1; i <= loopTo; i++)
                AddSequenceToList(i);
            if (IndexBefore < 0)
                IndexBefore = 1;
            if (ComboBox_LM_Music.Items.Count > IndexBefore)
            {
                ComboBox_LM_Music.SelectedIndex = IndexBefore;
                ComboBox_LM_Music.SelectedIndex = IndexBefore;
            }
            else if (ComboBox_LM_Music.Items.Count > 1)
            {
                ComboBox_LM_Music.SelectedIndex = 1;
            }
        }

        private void RemoveSequenceFromList(int index)
        {
            ComboBox_LM_Music.Items.RemoveAt(index);
        }

        private void AddSequenceToList(int index)
        {
            var item = new ComboItem();
            UpdateSequenceInList(index, item);
            ComboBox_LM_Music.Items.Insert(index, item);
        }

        private void UpdateSequenceInList(int index)
        {
            UpdateSequenceInList(index, (ComboItem)ComboBox_LM_Music.Items[index]);
        }

        private void UpdateSequenceInList(int index, ComboItem item)
        {
            var infos = Controller.GetMusicSequenceInfos(index);
            string tName = $"{TextValueConverter.TextFromValue(index, charCount: 2)} - {infos.name}";
            item.Text = tName;
        }

        private void AddSpecialItemToList(int levelIndex, int areaIndex, int itemIndex, bool refreshAndVisible)
        {
            var lvi = new ListViewItem();
            for (int i = 0; i <= 7; i++)
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem());
            lvi.Text = Conversions.ToString(ListViewEx_LM_Specials.Items.Count + 1);
            SetSpecialBoxDataToItem(levelIndex, areaIndex, itemIndex, lvi);
            ListViewEx_LM_Specials.Items.Add(lvi);
            if (refreshAndVisible)
            {
                lvi.EnsureVisible();
            }
        }

        private void UpdateSpecialBoxItem(SpecialItemEventArgs e)
        {
            foreach (ListViewItem lvi in ListViewEx_LM_Specials.Items)
            {
                if ((int)lvi.Tag == e.ItemIndex)
                {
                    SetSpecialBoxDataToItem(e.LevelIndex, e.AreaIndex, e.ItemIndex, lvi);
                }
            }
        }

        private void RemoveSpecialItemFromList(int itemIndex)
        {
            var toRemove = new List<ListViewItem>();
            foreach (ListViewItem lvi in ListViewEx_LM_Specials.Items)
            {
                if ((int)lvi.Tag == itemIndex)
                    toRemove.Add(lvi);
                else if ((int)lvi.Tag > itemIndex)
                    lvi.Tag = (int)lvi.Tag - 1;
            }

            toRemove.ForEach(n => ListViewEx_LM_Specials.Items.Remove(n));
        }

        private void SetSpecialBoxDataToItem(int levelIndex, int areaIndex, int itemIndex, ListViewItem lvi)
        {
            var sd = Controller.GetSpecialBoxInfos(levelIndex, areaIndex, itemIndex);
            lvi.Tag = itemIndex;
            lvi.SubItems[1].Text = sd.boxType.ToString();
            lvi.SubItems[2].Text = Conversions.ToString(sd.x1);
            lvi.SubItems[3].Text = Conversions.ToString(sd.z1);
            lvi.SubItems[4].Text = Conversions.ToString(sd.x2);
            lvi.SubItems[5].Text = Conversions.ToString(sd.z2);
            lvi.SubItems[6].Text = Conversions.ToString(sd.y);
            lvi.SubItems[7].Text = sd.boxType == SpecialBoxType.Water ? sd.invisibleWater ? Form_Main_Resources.Text_Invisible : sd.waterType.ToString() : "-";
        }

        internal void LoadObjectBankListBoxEntries()
        {
            var data = Controller.GetObjectBankData();

            void load(ObjectBankSelectorBox sb, byte number)
            {
                sb.ComboItems.Clear();
                sb.ComboItems.Add(Form_Main_Resources.Text_Disabled);

                foreach (var s in data[Conversions.ToInteger(number)])
                {
                    var cb = new ComboItem
                    {
                        Text = s.Name,
                        Tag = s
                    };
                    sb.ComboItems.Add(cb);
                }

                LoadLevelObjectBankDataSettings(CurrentLevelIndex);
            };
            load(ObjectBankSelectorBox_C, 1);
            load(ObjectBankSelectorBox_D, 2);
            load(ObjectBankSelectorBox_9, 3);
        }

        private void LoadLevelList()
        {
            var levelIDs = Controller.GetUsedLevelIDs();

            // Clear Items
            ListBoxAdv_LM_Levels.Items.Clear();

            // Load all Levels
            foreach (ushort lvlID in levelIDs)
            {
                var btn = new ButtonItem() { Text = GetLevelDisplayName(lvlID) };

                // Add event to popup 'More'
                btn.MouseUp += (sender, e) => { if (e.Button == MouseButtons.Right) ButtonX_LM_LevelsMore.Popup(Cursor.Position); };

                // Add item
                ListBoxAdv_LM_Levels.Items.Add(btn);
            }

            // Refresh
            ListBoxAdv_LM_Levels.Refresh();
        }

        private string GetLevelDisplayName(ushort lvlID)
        {
            string lvlName;
            if (Conversions.ToBoolean(Controller.HasLevelCustomName(lvlID)))
            {
                lvlName = Controller.GetLevelCustomName(lvlID);
            }
            else
            {
                lvlName = Controller.GetLevelName(lvlID);
            }

            return lvlName;
        }

        private void UpdateLevelItemInList(int levelIndex, ushort levelID)
        {
            ButtonItem item = (ButtonItem)ListBoxAdv_LM_Levels.Items[levelIndex];
            item.Text = GetLevelDisplayName(levelID);
            ListBoxAdv_LM_Levels.Refresh();
        }

        private void LoadAreaList(int selectAreaIndex)
        {
            LM_LoadingAreaList = true;

            // Clear all Items
            ListBoxAdv_LM_Areas.Items.Clear();

            // Load all Areas
            var areaIDs = Controller.GetUsedLevelAreaIDs(Conversions.ToUShort(CurrentLevelIndex));
            foreach (byte areaID in areaIDs)
            {
                var btn = new ButtonItem();
                UpdateLevelAreaButton(btn, areaID);

                // Add event to popup 'More'
                btn.MouseUp += (sender, e) => { if (e.Button == MouseButtons.Right) Button_LM_AreaEditor.Popup(Cursor.Position); };

                // Add item
                ListBoxAdv_LM_Areas.Items.Add(btn);
            }

            // Refresh
            ListBoxAdv_LM_Areas.Refresh();

            // Check if can add more areas
            Button_LM_AddArea.Enabled = Controller.GetLevelAreasCount(CurrentLevelIndex) < byte.MaxValue;
            LM_LoadingAreaList = false;

            // Select first item, if possible
            if (areaIDs.Length > selectAreaIndex)
            {
                var selItem = ListBoxAdv_LM_Areas.Items[selectAreaIndex];
                ListBoxAdv_LM_Areas.SelectedItem = selItem;
                ListBoxAdv_LM_Areas.EnsureVisible(selItem);
            }
            else
            {
                ListBoxAdv_LM_Areas.SelectedItem = null;
                ListBoxAdv_LM_Areas.SelectedItem = null;
            }
        }

        private void UpdateLevelAreaButton(ButtonItem btn, byte areaID)
        {
            btn.Text = Form_Main_Resources.Text_Area + " " + Conversions.ToString(areaID);
        }

        private void UpdateLevelAreaButton(int levelIndex, int areaIndex, byte newAreaID)
        {
            if (CurrentLevelIndex == levelIndex)
            {
                var btn = (ButtonItem)ListBoxAdv_LM_Areas.Items[areaIndex];
                UpdateLevelAreaButton(btn, newAreaID);
                ListBoxAdv_LM_Areas.Refresh();
            }
        }

        private void AddLevelToList(ushort levelID)
        {
            var btn = new ButtonItem()
            {
                Checked = false,
                Text = Controller.GetLevelName(levelID)
            };
            ListBoxAdv_LM_Levels.Items.Add(btn);
            ListBoxAdv_LM_Levels.Refresh();
            ListBoxAdv_LM_Levels.SelectedItem = btn;
            ListBoxAdv_LM_Levels.EnsureVisible(btn);
        }

        private void AddAreaToList(byte areaIndex)
        {
            LoadAreaList(areaIndex);
        }

        private void RemoveAreaFromList(int areaIndex)
        {
            LoadAreaList(Math.Max(areaIndex - 1, 0));
            if (Controller.GetLevelAreasCount(CurrentLevelIndex) == 0)
            {
                TabControl_LM_Area.Enabled = false;
            }
        }

        private void EditLevelInList(ushort levelID, int levelIndex)
        {
            ButtonItem btn = (ButtonItem)ListBoxAdv_LM_Levels.Items[levelIndex];
            btn.Text = Controller.GetLevelName(levelID);
            ListBoxAdv_LM_Levels.Refresh();
        }

        private void SaveLevelSettings()
        {
            if (AllowSavingLevelSettings)
            {
                Controller.SetLevelSettings(CurrentLevelIndex, Conversions.ToByte(NUD_LM_DefaultPositionAreaID.Value), Conversions.ToShort(NUD_LM_DefaultPositionYRotation.Value), SwitchButton_LM_ActSelector.Value, SwitchButton_LM_HardcodedCameraSettings.Value, ObjectBankSelectorBox_C.SelectedComboIndex, ObjectBankSelectorBox_D.SelectedComboIndex, ObjectBankSelectorBox_9.SelectedComboIndex, SwitchButton_UseGlobalObjectBank.Value, SwitchButton_UseLocalObjectBank.Value, SwitchButton_LM_ShowMsgEnabled.Value, Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_LM_ShowMsgID.Text)));
            }
        }

        private void LoadAreaBackgroundColor(Color color)
        {
            ColorPickerButton_LM_BackgroundColor.Visible = true;
            ColorPickerButton_LM_BackgroundColor.SelectedColor = color;
        }

        private void HandleBackgroundModeChange(LevelBackgroundModeChangedEventArgs e)
        {
            SuspendLayout();
            ComboBox_LM_LevelBG.Visible = false;
            Button_LM_LoadLevelBG.Visible = false;
            PictureBox_BGImage.Image = null;
            var switchExpr = e.BackgroundMode;
            switch (switchExpr)
            {
                case 0: // Game Image
                    {
                        ComboBox_LM_LevelBG.Visible = true;
                        if (e.BackgroundID != SM64Lib.Geolayout.BackgroundIDs.Custom)
                        {
                            ComboBox_LM_LevelBG.SelectedIndex = General.GetBackgroundIndexOfID(e.BackgroundID);
                        }
                        else
                        {
                            ComboBox_LM_LevelBG.SelectedIndex = General.GetBackgroundIndexOfID(SM64Lib.Geolayout.BackgroundIDs.Ocean);
                        }

                        break;
                    }

                case 1: // Custom Image
                    {
                        Button_LM_LoadLevelBG.Visible = true;
                        PictureBox_BGImage.Image = e.BackgroundImage;
                        break;
                    }

                case 2: // Disable
                    {
                        break;
                    }
            }

            ResumeLayout();
        }

        private void SaveAreaSettings()
        {
            if (AllowSavingAreaSettings)
            {
                Controller.SaveLevelAreaSettings(
                    CurrentLevelIndex,
                    CurrentAreaIndex,
                    (SM64Lib.Geolayout.TerrainTypes)ComboBox_LM_TerrainTyp.SelectedIndex,
                    Conversions.ToByte(ComboBox_LM_Music.SelectedIndex),
                    General.GetEnvironmentTypeOfIndex(ComboBox_LM_EnvironmentEffects.SelectedIndex),
                    General.GetCameraPresetTypeOfIndex(ComboBox_LM_CameraPreset.SelectedIndex),
                    CheckBoxX_LM_Enable2DCamera.Value, SwitchButton_LM_ShowMsgEnabled.Value,
                    Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_LM_ShowMsgID.Text)),
                    (AreaReverbLevel)Enum.GetValues(typeof(AreaReverbLevel)).GetValue(Slider_AreaReverbLevel.Value));
                
            }
        }

        private void UpdateSpecialItemsList()
        {
            ListViewEx_LM_Specials.SuspendLayout();

            // Clear everything
            ListViewEx_LM_Specials.Items.Clear();

            // List all special boxes
            for (int sbIndex = 0, loopTo = Controller.GetSpecialBoxesCount(CurrentLevelIndex, CurrentAreaIndex) - 1; sbIndex <= loopTo; sbIndex++)
                AddSpecialItemToList(CurrentLevelIndex, CurrentAreaIndex, sbIndex, false);
            ListViewEx_LM_Specials.ResumeLayout();
            ListViewEx_LM_Specials.Refresh();
        }

        private void RemoveLevelFromList(int levelIndex)
        {
            LM_LoadingLevel = true;
            ListBoxAdv_LM_Levels.Items.RemoveAt(levelIndex);
            LM_LoadingLevel = false;
            ListBoxAdv_LM_Levels.Refresh();
            LoadLevelSettings(-1);
        }

        private void LoadAreaSettings(int levelIndex, int areaIndex)
        {
            var item = ListBoxAdv_LM_Areas.SelectedItem;
            bool skip = item is null;
            TabControl_LM_Area.Enabled = !skip;
            Button_LM_RemoveArea.Enabled = !skip;
            Button_LM_AreaEditor.Enabled = !skip;
            if (!Controller.IsLoadingRom && !LM_LoadingLevel && !LM_LoadingAreaList && !skip)
            {
                var infos = Controller.GetLevelAreaSettings(levelIndex, areaIndex);
                LM_LoadingArea = true;

                // Load Area Settings
                ComboBox_LM_TerrainTyp.SelectedIndex = (int)infos.terrainType;
                ComboBox_LM_Music.SelectedIndex = Math.Min(ComboBox_LM_Music.Items.Count - 1, infos.bgMusic);
                ComboBox_LM_CameraPreset.SelectedIndex = General.GetCameraPresetIndexOfType(infos.camPreset);
                ComboBox_LM_EnvironmentEffects.SelectedIndex = General.GetEnvironmentIndexOfType(infos.envEffect);

                // Load 2D-Camera Settings
                CheckBoxX_LM_Enable2DCamera.Value = infos.enable2DCam;

                // Area Background
                var switchExpr = infos.bgType;
                switch (switchExpr)
                {
                    case AreaBGs.Levelbackground:
                        {
                            ComboBoxEx_LM_AreaBG.SelectedIndex = 0;
                            break;
                        }

                    case AreaBGs.Color:
                        {
                            ComboBoxEx_LM_AreaBG.SelectedIndex = 1;
                            ColorPickerButton_LM_BackgroundColor.SelectedColor = infos.bgColor;
                            break;
                        }
                }

                UpdateAreaBackgroundControlsVisible((int)infos.bgType);

                // Load Show Message
                SwitchButton_LM_ShowMsgEnabled.Value = infos.enableShowMsg;
                TextBoxX_LM_ShowMsgID.Text = TextValueConverter.TextFromValue(infos.showMsgDialogID);
                UpdateShowMsgControlsVisible(infos.enableShowMsg);

                // Area Reverb
                var reverbLevels = Enum.GetValues(typeof(AreaReverbLevel));
                for (int iReverbLevel = 0; iReverbLevel < reverbLevels.Length; iReverbLevel++)
                {
                    var reverbLevel = (AreaReverbLevel)reverbLevels.GetValue(iReverbLevel);
                    if (reverbLevel == infos.reverbLevel)
                        Slider_AreaReverbLevel.Value = iReverbLevel;
                }
                Slider_AreaReverbLevel.Enabled = infos.areaID >= 1 && infos.areaID <= 3;

                // Model Infos
                LoadScrollTexCount();
                UpdateSpecialItemsList();
                LM_LoadingArea = false;
            }
        }

        private void LoadScrollTexCount()
        {
            LabelX_Area_CountOfTexAnimations.Text = Conversions.ToString(Controller.GetLevelAreaScrollingTexturesCount(CurrentLevelIndex, CurrentAreaIndex));
        }

        private void LoadLevelSettings(int levelIndex)
        {
            TabControl_LM_Level.Enabled = levelIndex >= 0;
            TabControl_LM_Level.Enabled = levelIndex >= 0; // Yes, a second time! Otherwise id doesn't work for no reason.
            if (!LM_LoadingLevel)
            {
                if (levelIndex < 0 || ListBoxAdv_LM_Levels.Items.Count == 0 || Controller.IsLoadingRom)
                {
                    TabControl_LM_Level.Enabled = false;
                    TabControl_LM_Area.Enabled = false;
                    GroupBox_LM_Areas.Enabled = false;
                    ButtonX_LM_LevelsMore.Enabled = false;
                    ListBoxAdv_LM_Areas.Items.Clear();
                }
                else if (!Controller.IsLoadingRom)
                {
                    LM_LoadingLevel = true;
                    Controller.StatusText = Form_Main_Resources.Status_LoadingLevel;
                    var info = Controller.GetLevelSettings(levelIndex);

                    // Load Levelsettings
                    LoadLevelObjectBankDataSettings(levelIndex);
                    SwitchButton_LM_ActSelector.Value = info.enableActSelector;
                    SwitchButton_LM_HardcodedCameraSettings.Value = info.enableHardcodedCamera;

                    // Default Start Psoition
                    if (info.hasDefStartPos)
                    {
                        NUD_LM_DefaultPositionAreaID.Value = info.defStartPosAreaID;
                        NUD_LM_DefaultPositionYRotation.Value = info.defStartPosYRot;
                    }

                    // Load Level Bachground
                    ComboBoxEx_LM_BGMode.SelectedIndex = info.bgMode;
                    UpdateBackgroundControlsVisible(info.bgMode);
                    PictureBox_BGImage.Image = info.bgImage;
                    if (info.bgMode != 1 && info.bgOriginal != SM64Lib.Geolayout.BackgroundIDs.Custom)
                        ComboBox_LM_LevelBG.SelectedIndex = General.GetBackgroundIndexOfID(info.bgOriginal);

                    // Load Level Name
                    LabelX_TargetLevel.Text = Controller.GetLevelName(levelIndex);
                    Button_LM_AddArea.Enabled = info.areasCount != 8;
                    Controller.StatusText = string.Empty;
                    LM_LoadingLevel = false;
                    LoadAreaList(0);
                    TabControl_LM_Level.Enabled = true;
                    GroupBox_LM_Areas.Enabled = true;
                    ButtonX_LM_LevelsMore.Enabled = true;
                }
            }
        }

        private void LoadLevelObjectBankDataSettings(int levelIndex)
        {
            if (levelIndex >= 0)
            {
                var info = Controller.GetLevelObjectBankDataSettings(levelIndex);
                bool wasLoadingLevel = LM_LoadingLevel;
                LM_LoadingLevel = true;
                ObjectBankSelectorBox_C.SelectedComboIndex = info.objBank0x0C;
                ObjectBankSelectorBox_D.SelectedComboIndex = info.objBank0x0D;
                ObjectBankSelectorBox_9.SelectedComboIndex = info.objBank0x0E;
                SwitchButton_UseGlobalObjectBank.Value = info.enableGlobalObjectBank;
                SwitchButton_UseLocalObjectBank.Value = info.enableLocalObjectBank;
                LM_LoadingLevel = wasLoadingLevel;
            }
        }

        private void UpdateBackgroundControlsVisible(int bgMode)
        {
            ComboBox_LM_LevelBG.Visible = bgMode == 0;
            Button_LM_LoadLevelBG.Visible = bgMode == 1;
            PictureBox_BGImage.Visible = bgMode == 1;
        }

        private void UpdateAreaBackgroundControlsVisible(int bgMode)
        {
            ColorPickerButton_LM_BackgroundColor.Visible = bgMode == 1;
        }

        private void UpdateShowMsgControlsVisible(bool enable)
        {
            TextBoxX_LM_ShowMsgID.Visible = enable;
            LabelX9.Visible = enable;
        }

        private void Button_LM_AddNewLevel_Click()
        {
            Controller.AddNewLevel();
        }

        private void Button_LM_AddArea_Click()
        {
            Controller.AddNewArea(CurrentLevelIndex);
        }

        private void Button_LM_RemoveArea_Click()
        {
            Controller.RemoveLevelArea(CurrentLevelIndex, CurrentAreaIndex);
        }

        private void Controls_HandleToSaveLevelSettings()
        {
            SaveLevelSettings();
        }

        private void SwitchButton_UseCustomObjectBank_ValueChanged(object sender, EventArgs e)
        {
            ObjectBankSelectorBox_9.Enabled = !SwitchButton_UseGlobalObjectBank.Value && !SwitchButton_UseLocalObjectBank.Value;
            ButtonX_ManageLocalObjects.Visible = SwitchButton_UseLocalObjectBank.Value;
            Controls_HandleToSaveLevelSettings();
        }

        private void LM_SaveGameBackground()
        {
            if (AllowSavingLevelSettings)
            {
                Controller.SetLevelBackgroundID(CurrentLevelIndex, General.GetBackgroundIDOfIndex(ComboBox_LM_LevelBG.SelectedIndex));
            }
        }

        private void ComboBoxEx_LM_BGMode_SelectedIndexChanged()
        {
            if (AllowSavingLevelSettings)
            {
                int curMode = ComboBoxEx_LM_BGMode.SelectedIndex;
                Controller.SetLevelBackgroundMode(CurrentLevelIndex, curMode);
                UpdateBackgroundControlsVisible(curMode);
            }
        }

        private void ComboBoxEx_LM_AreaBG_SelectedIndexChanged()
        {
            if (AllowSavingAreaSettings)
            {
                int bgMode = ComboBoxEx_LM_AreaBG.SelectedIndex;
                Controller.SetLevelAreaBackgroundType(CurrentLevelIndex, CurrentAreaIndex, (AreaBGs)bgMode);
                UpdateAreaBackgroundControlsVisible(bgMode);
            }
        }

        private void LM_SaveAreaBackgorund()
        {
            if (AllowSavingAreaSettings)
            {
                Controller.SetLevelAreaBackgroundColor(CurrentLevelIndex, CurrentAreaIndex, ColorPickerButton_LM_BackgroundColor.SelectedColor);
            }
        }

        private void LM_LoadCustomBackground()
        {
            Controller.LoadLevelCustomBackgroundImage(CurrentLevelIndex);
        }

        private void Controls_HandleToSaveAreaSettings()
        {
            SaveAreaSettings();
        }

        private void LM_ImportModel(object sender, EventArgs e)
        {
            Controller.ImportLevelAreaModel(CurrentLevelIndex, CurrentAreaIndex, sender == Button_ImportModel || sender == ButtonX_ImportVisualMap, sender == Button_ImportModel || sender == ButtonX_ImportCollision);
        }

        private void LM_UpdateObjectBankList(object sender, EventArgs e)
        {
            int Index = 1;
            ObjectBankData obdData = null;
            int SelectedIndex = 0;
            void setValues(ObjectBankSelectorBox obsbox)
            {
                SelectedIndex = obsbox.SelectedComboIndex;
                obdData = (ObjectBankData)(obsbox.SelectedComboItem as ComboItem)?.Tag;
                obsbox.ContentItems.Clear();
            };
            var switchExpr = sender.GetHashCode();
            switch (switchExpr)
            {
                case var @case when @case == ObjectBankSelectorBox_C.GetHashCode():
                    {
                        setValues(ObjectBankSelectorBox_C);
                        Index = 1;
                        break;
                    }

                case var case1 when case1 == ObjectBankSelectorBox_D.GetHashCode():
                    {
                        setValues(ObjectBankSelectorBox_D);
                        Index = 2;
                        break;
                    }

                case var case2 when case2 == ObjectBankSelectorBox_9.GetHashCode():
                    {
                        setValues(ObjectBankSelectorBox_9);
                        Index = 3;
                        break;
                    }
            }

            if (SelectedIndex >= 1)
            {
                foreach (string n in obdData.Objects)
                {
                    var switchExpr1 = sender.GetHashCode();
                    switch (switchExpr1)
                    {
                        case var case3 when case3 == ObjectBankSelectorBox_C.GetHashCode():
                            {
                                ObjectBankSelectorBox_C.ContentItems.Add(new LabelItem() { Text = n });
                                break;
                            }

                        case var case4 when case4 == ObjectBankSelectorBox_D.GetHashCode():
                            {
                                ObjectBankSelectorBox_D.ContentItems.Add(new LabelItem() { Text = n });
                                break;
                            }

                        case var case5 when case5 == ObjectBankSelectorBox_9.GetHashCode():
                            {
                                ObjectBankSelectorBox_9.ContentItems.Add(new LabelItem() { Text = n });
                                break;
                            }
                    }
                }
            }

            ObjectBankSelectorBox_C.Refresh();
            ObjectBankSelectorBox_D.Refresh();
            ObjectBankSelectorBox_9.Refresh();
        }

        private void Button_LM_AddEditSpecial_Click(object sender, EventArgs e)
        {
            if (!LM_LoadingLevel)
            {
                if (sender == Button_LM_EditSpecial)
                {
                    Controller.EditLevelAreaSpecialItem(CurrentLevelIndex, CurrentAreaIndex, CurrentSpecialBoxIndex);
                }
                else if (sender == Button_LM_AddSpecial)
                {
                    Controller.AddLevelAreaSpecialItem(CurrentLevelIndex, CurrentAreaIndex);
                }
            }
        }

        private void Button_LM_RemoveSpecial_Click(object sender, EventArgs e)
        {
            if (!LM_LoadingLevel)
            {
                Controller.RemoveLevelSpecialBox(CurrentLevelIndex, CurrentAreaIndex, CurrentSpecialBoxIndex);
            }
        }

        private void ListViewEx_LM_Specials_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isNull = CurrentSpecialBoxIndex == -1;
            Button_LM_EditSpecial.Enabled = !isNull;
            Button_LM_RemoveSpecial.Enabled = !isNull;
        }

        private void ComboBox_LM_CameraPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsE = Controller.DoesCameraPresetProvide2DCamera((SM64Lib.Geolayout.CameraPresets)(ComboBox_LM_CameraPreset.SelectedIndex + 1));
            CheckBoxX_LM_Enable2DCamera.Visible = IsE;
            if (!IsE)
                CheckBoxX_LM_Enable2DCamera.Value = false;
            SaveAreaSettings();
        }

        private void LM_OpenAreaEditor()
        {
            if (!LM_SavingRom)
            {
                Controller.OpenAreaEditor(CurrentLevelIndex, CurrentAreaIndex);
            }
        }

        private void Button_LM_SetUpOffsetModelPosition_Click(object sender, EventArgs e)
        {
            Controller.SetUpLevelDefaultStartPosition(CurrentLevelIndex);
        }

        private void ListBoxAdv_LM_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAreaSettings(CurrentLevelIndex, CurrentAreaIndex);
        }

        private void ListBoxAdv_LM_Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLevelSettings(CurrentLevelIndex);
        }

        private void ButtonItem19_Click(object sender, EventArgs e)
        {
            Controller.RemoveLevel(CurrentLevelIndex);
        }

        private void ButtonItem20_Click(object sender, EventArgs e)
        {
            Controller.ChangeLevelID(CurrentLevelIndex);
        }

        private void ButtonItem21_Click(object sender, EventArgs e)
        {
            Controller.CopyLevelLastRomOffset(CurrentLevelIndex);
        }

        private async void ButtonItem_ExportVisualMap_Click(object sender, EventArgs e)
        {
            if (AllowSavingAreaSettings)
            {
                await Controller.ExportLevelVisualMap(CurrentLevelIndex, CurrentAreaIndex);
            }
        }

        private async void ButtonItem_ExportCollisionMap_Click(object sender, EventArgs e)
        {
            if (AllowSavingAreaSettings)
            {
                await Controller.ExportLevelCollision(CurrentLevelIndex, CurrentAreaIndex);
            }
        }

        private void SwitchButton_LM_ShowMsgEnabled_ValueChanged(object sender, EventArgs e)
        {
            bool enabled = SwitchButton_LM_ShowMsgEnabled.Value;
            UpdateShowMsgControlsVisible(enabled);
            SaveAreaSettings();
        }

        private void TextBoxX_LM_ShowMsgID_TextChanged(object sender, EventArgs e)
        {
            SaveAreaSettings();
        }

        private void ButtonItem15_Click(object sender, EventArgs e)
        {
            Controller.OpenScriptDumperWithLevelscript(CurrentLevelIndex);
        }

        private void ButtonX_LM_ScrollTexEditor_Click(object sender, EventArgs e)
        {
            Controller.OpenScrollingTextureEditor(CurrentLevelIndex, CurrentAreaIndex);
        }

        private void ButtonItem26_Click(object sender, EventArgs e)
        {
            Controller.ImportLevel();
        }

        private void ListBoxAdv_LM_Levels_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            if (!LM_SavingRom)
            {
                Controller.OpenAreaEditor(CurrentLevelIndex, CurrentAreaIndex);
            }
        }

        private void ButtonItem24_Click(object sender, EventArgs e)
        {
            Controller.SetLevelBank0x19Length(CurrentLevelIndex);
        }

        private void ButtonX_LM_LevelsMore_PopupOpen(object sender, EventArgs e)
        {
            ButtonItem24.Visible = Controller.HasLevelBank0x19(CurrentLevelIndex);
        }

        private void ButtonItem_EditAreaLevelScript_Click(object sender, EventArgs e)
        {
            Controller.OpenScriptDumperWithLevelAreaScript(CurrentLevelIndex, CurrentAreaIndex);
        }

        private void ButtonItem2_EditGeolayoutScript_Click(object sender, EventArgs e)
        {
            Controller.OpenScriptDumperWithLevelAreaGeolayoutScript(CurrentLevelIndex, CurrentAreaIndex);
        }

        private void ButtonItem_ImportArea_Click(object sender, EventArgs e)
        {
            Controller.ImportLevelArea(CurrentLevelIndex);
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            Controller.ChangeLevelCustomName(CurrentLevelIndex);
        }

        private void GroupBox_LM_Areas_EnabledChanged(object sender, EventArgs e)
        {
            GroupBox_LM_Areas.InvalidateNonClient();
        }

        private void Button_LM_AddNewLevel_Click(object sender, EventArgs e) => Button_LM_AddNewLevel_Click();
        private void Button_LM_AddArea_Click(object sender, EventArgs e) => Button_LM_AddArea_Click();
        private void Button_LM_RemoveArea_Click(object sender, EventArgs e) => Button_LM_RemoveArea_Click();
        private void Controls_HandleToSaveLevelSettings(object sender, EventArgs e) => Controls_HandleToSaveLevelSettings();
        private void LM_SaveGameBackground(object sender, EventArgs e) => LM_SaveGameBackground();
        private void ComboBoxEx_LM_BGMode_SelectedIndexChanged(object sender, EventArgs e) => ComboBoxEx_LM_BGMode_SelectedIndexChanged();
        private void ComboBoxEx_LM_AreaBG_SelectedIndexChanged(object sender, EventArgs e) => ComboBoxEx_LM_AreaBG_SelectedIndexChanged();
        private void LM_SaveAreaBackgorund(object sender, EventArgs e) => LM_SaveAreaBackgorund();
        private void LM_LoadCustomBackground(object sender, EventArgs e) => LM_LoadCustomBackground();
        private void Controls_HandleToSaveAreaSettings(object sender, EventArgs e) => Controls_HandleToSaveAreaSettings();
        private void LM_OpenAreaEditor(object sender, EventArgs e) => LM_OpenAreaEditor();

        private void ButtonX_ManageLocalObjects_Click(object sender, EventArgs e)
        {
            Controller.OpenLocalObjectBankManager(CurrentLevelIndex);
        }

        private void ButtonX_EditFast3D_Click(object sender, EventArgs e)
        {
            Controller.OpenHexEditorForFast3DBuffer(CurrentLevelIndex, CurrentAreaIndex);
        }

        private void Slider_AreaReverbLevel_ValueChanged(object sender, EventArgs e)
        {
            SaveAreaSettings();

            var levels = Enum.GetValues(typeof(AreaReverbLevel));
            var index = Slider_AreaReverbLevel.Value;
            Slider_AreaReverbLevel.Text = $"{index}";
        }

        private void ButtonItem_ChangeAreaID_Click(object sender, EventArgs e)
        {
            var input = new ValueInputDialog();
            input.ValueTextBox.Text = TextValueConverter.TextFromValue(Controller.GetLevelAreaID(CurrentLevelIndex, CurrentAreaIndex));

            if (input.ShowDialog() == DialogResult.OK)
            {
                if (!Controller.ChangeAreaID(CurrentLevelIndex, CurrentAreaIndex, (byte)TextValueConverter.ValueFromText(input.ValueTextBox.Text)))
                    MessageBoxEx.Show(this, Form_Main_Resources.MsgBox_ChangeAreaID, Form_Main_Resources.MsgBox_ChangeAreaID_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}