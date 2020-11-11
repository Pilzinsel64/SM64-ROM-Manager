using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.AdvTree;
using SM64Lib.Levels;
using SM64Lib.TextValueConverter;
using System.Linq;
using DevComponents.Editors;
using SM64_ROM_Manager.EventArguments;
using DevComponents.DotNetBar;
using SM64Lib.Objects.ObjectBanks.Data;
using Microsoft.VisualBasic.CompilerServices;
using SM64_ROM_Manager.My.Resources;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public partial class Tab_LevelManagerV2 : UserControl
    {
        // F i e l d s

        private ObjectBankSelectorBox objectBankSelectorBox_C;
        private ObjectBankSelectorBox objectBankSelectorBox_D;
        private ObjectBankSelectorBox objectBankSelectorBox_9;

        private bool loadingAreaList = false;
        private bool savingRom = false;
        private bool loadingArea = false;
        private bool loadingLevel = false;

        Node nCustomLevels;
        Node nVanillaLevels;

        private MainController _Controller;

        // C o n s t r u c t o r

        public Tab_LevelManagerV2()
        {
            objectBankSelectorBox_C = new ObjectBankSelectorBox() { Dock = DockStyle.Fill, ContentLabelText = "Content of Bank 0xC" };
            objectBankSelectorBox_D = new ObjectBankSelectorBox() { Dock = DockStyle.Fill, ContentLabelText = "Content of Bank 0xD" };
            objectBankSelectorBox_9 = new ObjectBankSelectorBox() { Dock = DockStyle.Fill, ContentLabelText = "Content of Bank 0x9" };
            objectBankSelectorBox_C.SelectedComboIndexChanged += ObjectBankSelectorBox_SelectedComboIndexChanged;
            objectBankSelectorBox_D.SelectedComboIndexChanged += ObjectBankSelectorBox_SelectedComboIndexChanged;
            objectBankSelectorBox_9.SelectedComboIndexChanged += ObjectBankSelectorBox_SelectedComboIndexChanged;

            // Init GUI
            InitializeComponent();
            SwitchButton_UseGlobalObjectBank.Enabled = true;

            // Add ObjectBankSelectorBoxes
            TableLayoutPanel_ObjectBankSelectorBoxes.Controls.Add(objectBankSelectorBox_C, 0, 0);
            TableLayoutPanel_ObjectBankSelectorBoxes.Controls.Add(objectBankSelectorBox_D, 1, 0);
            TableLayoutPanel_ObjectBankSelectorBoxes.Controls.Add(objectBankSelectorBox_9, 2, 0);

            var reverbLevels = Enum.GetValues(typeof(AreaReverbLevel));
            Slider_AreaReverbLevel.Maximum = reverbLevels.Length - 1;

            // Init nodes
            nCustomLevels = new Node("Custom Levels")
            {
                Expanded = true
            };
            nVanillaLevels = new Node("Vanilla Levels")
            {
                Expanded = true
            };
            LevelsTree.Nodes.AddRange(new[] { nCustomLevels/*, nVanillaLevels*/ });

            // Add some event handlers
            SwitchButton_LM_ActSelector.ValueChanged += Controls_HandleToSaveLevelSettings;
            SwitchButton_LM_HardcodedCameraSettings.ValueChanged += Controls_HandleToSaveLevelSettings;
            NUD_LM_DefaultPositionYRotation.ValueChanged += Controls_HandleToSaveLevelSettings;
            NUD_LM_DefaultPositionAreaID.ValueChanged += Controls_HandleToSaveLevelSettings;
            CheckBoxX_LM_Enable2DCamera.ValueChanged += Controls_HandleToSaveAreaSettings;
            ComboBox_LM_Music.SelectedIndexChanged += Controls_HandleToSaveAreaSettings;
            ComboBox_LM_TerrainTyp.SelectedIndexChanged += Controls_HandleToSaveAreaSettings;
            ComboBox_LM_EnvironmentEffects.SelectedIndexChanged += Controls_HandleToSaveAreaSettings;

            LoadCurrentSelection(true);
        }

        // P r o p e r t i e s

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
                var n = LevelsTree.SelectedNode;
                int selIndex;

                if (n?.Tag is object && (int)n.Tag == 1)
                    selIndex = n.Index;
                else
                    selIndex = -1;

                return selIndex;
            }
        }

        private int CurrentLevelIndex
        {
            get
            {
                var n = LevelsTree.SelectedNode;
                int selIndex = -1;

                if (n?.Tag is object)
                {
                    if ((int)n.Tag == 0)
                        selIndex = n.Index;
                    else if ((int)n.Tag == 1)
                        selIndex = n.Parent.Index;
                }

                return selIndex;
            }
        }

        private bool AllowSavingLevelSettings
        {
            get
            {
                return !(Controller == null || Controller.IsLoadingRom) && !loadingLevel && CurrentLevelIndex > -1;
            }
        }

        private bool AllowSavingAreaSettings
        {
            get
            {
                return AllowSavingLevelSettings && !loadingAreaList && !loadingArea && CurrentAreaIndex > -1;
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

        // C o n t r o l l e r   E v e n t s

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
            AddAreaToList(e.LevelIndex, Conversions.ToByte(e.AreaIndex));
        }

        private void Controller_LevelAreaRemoved(LevelAreaEventArgs e)
        {
            RemoveAreaFromList(e.LevelIndex, e.AreaIndex);
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
            UpdateLevelAreaNode(e.LevelIndex, e.AreaIndex, e.AreaID);
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
            load(objectBankSelectorBox_C, 1);
            load(objectBankSelectorBox_D, 2);
            load(objectBankSelectorBox_9, 3);
        }

        private void LoadLevelList()
        {
            var levelIDs = Controller.GetUsedLevelIDs().ToArray();

            // Clear Items
            LevelsTree.BeginUpdate();
            nCustomLevels.Nodes.Clear();

            // Load all Levels
            foreach (ushort lvlID in levelIDs)
            {
                var n = new Node(GetLevelDisplayName(lvlID))
                {
                    Tag = 0
                };

                // Load areas
                LoadAreaList(n, levelIDs.IndexOf(lvlID));

                // Add item
                nCustomLevels.Nodes.Add(n);
            }

            // Refresh
            LevelsTree.EndUpdate();
        }

        private void LoadAreaList(Node nLevel, int levelIndex)
        {
            var areaIDs = Controller.GetUsedLevelAreaIDs((ushort)levelIndex);
            foreach (byte areaID in areaIDs)
            {
                var n = new Node(Form_Main_Resources.Text_Area + " " + areaID.ToString())
                {
                    Tag = 1
                };

                // Add item
                nLevel.Nodes.Add(n);
            }
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
            var n = nCustomLevels.Nodes[levelIndex];
            n.Text = GetLevelDisplayName(levelID);
            LevelsTree.Refresh();
        }

        private void UpdateLevelAreaNode(Node n, byte areaID)
        {
            n.Text = Form_Main_Resources.Text_Area + " " + Conversions.ToString(areaID);
        }

        private void UpdateLevelAreaNode(int levelIndex, int areaIndex, byte newAreaID)
        {
            if (CurrentLevelIndex == levelIndex)
            {
                var n = nCustomLevels.Nodes[areaIndex];
                UpdateLevelAreaNode(n, newAreaID);
                LevelsTree.Refresh();
            }
        }

        private void AddLevelToList(ushort levelID)
        {
            var n = new Node(Controller.GetLevelName(levelID))
            {
                Tag = 0
            };
            nCustomLevels.Nodes.Add(n);
            LevelsTree.SelectedNode = n;
            n.EnsureVisible();
        }

        private void AddAreaToList(int levelIndex, byte areaIndex)
        {
            var id = Controller.GetLevelAreaID(levelIndex, areaIndex);
            var n = new Node(Form_Main_Resources.Text_Area + " " + areaIndex.ToString())
            {
                Tag = 1
            };
            var parentNode = nCustomLevels.Nodes[levelIndex];
            parentNode.Nodes.Add(n);
            parentNode.Expanded = true;
            LevelsTree.SelectedNode = n;
        }

        private void RemoveAreaFromList(int levelIndex, int areaIndex)
        {
            nCustomLevels.Nodes[levelIndex].Nodes.RemoveAt(areaIndex);
        }

        private void EditLevelInList(ushort levelID, int levelIndex)
        {
            Node n = nCustomLevels.Nodes[levelIndex];
            n.Text = Controller.GetLevelName(levelID);
            LevelsTree.Refresh();
        }

        private void SaveLevelSettings()
        {
            if (AllowSavingLevelSettings)
            {
                Controller.SetLevelSettings(CurrentLevelIndex, Conversions.ToByte(NUD_LM_DefaultPositionAreaID.Value), Conversions.ToShort(NUD_LM_DefaultPositionYRotation.Value), SwitchButton_LM_ActSelector.Value, SwitchButton_LM_HardcodedCameraSettings.Value, objectBankSelectorBox_C.SelectedComboIndex, objectBankSelectorBox_D.SelectedComboIndex, objectBankSelectorBox_9.SelectedComboIndex, SwitchButton_UseGlobalObjectBank.Value, SwitchButton_UseLocalObjectBank.Value, SwitchButton_LM_ShowMsgEnabled.Value, Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_LM_ShowMsgID.Text)));
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
                    (AreaReverbLevel)Enum.GetValues(typeof(AreaReverbLevel)).GetValue(Slider_AreaReverbLevel.Value),
                    (short)RangeSlider_CameraFrustrum.Value.Min, (short)RangeSlider_CameraFrustrum.Value.Max);

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
            loadingLevel = true;
            nCustomLevels.Nodes.RemoveAt(levelIndex);
            loadingLevel = false;
        }

        private void LoadAreaSettings(int levelIndex, int areaIndex)
        {
            var item = nCustomLevels.Nodes[levelIndex].Nodes[areaIndex];
            bool skip = item is null;

            if (!Controller.IsLoadingRom && !loadingLevel && !loadingAreaList && !skip)
            {
                var infos = Controller.GetLevelAreaSettings(levelIndex, areaIndex);
                loadingArea = true;

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

                // Camera Frustrum
                RangeSlider_CameraFrustrum.Value = new RangeValue(infos.cameraFrustrumNear, infos.cameraFrustrumFar);

                // Model Infos
                LoadScrollTexCount();
                UpdateSpecialItemsList();
                loadingArea = false;
            }
        }

        private void LoadScrollTexCount()
        {
            LabelX_Area_CountOfTexAnimations.Text = Conversions.ToString(Controller.GetLevelAreaScrollingTexturesCount(CurrentLevelIndex, CurrentAreaIndex));
        }

        private void LoadLevelSettings(int levelIndex)
        {
            if (!loadingLevel && !Controller.IsLoadingRom && levelIndex != -1)
            {
                loadingLevel = true;
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
                Controller.StatusText = string.Empty;
                loadingLevel = false;
            }
        }

        private void LoadLevelObjectBankDataSettings(int levelIndex)
        {
            if (levelIndex >= 0)
            {
                var info = Controller.GetLevelObjectBankDataSettings(levelIndex);
                bool wasLoadingLevel = loadingLevel;
                loadingLevel = true;
                objectBankSelectorBox_C.SelectedComboIndex = info.objBank0x0C;
                objectBankSelectorBox_D.SelectedComboIndex = info.objBank0x0D;
                objectBankSelectorBox_9.SelectedComboIndex = info.objBank0x0E;
                SwitchButton_UseGlobalObjectBank.Value = info.enableGlobalObjectBank;
                SwitchButton_UseLocalObjectBank.Value = info.enableLocalObjectBank;
                loadingLevel = wasLoadingLevel;
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
            objectBankSelectorBox_9.Enabled = !SwitchButton_UseGlobalObjectBank.Value && !SwitchButton_UseLocalObjectBank.Value;
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
                case var @case when @case == objectBankSelectorBox_C.GetHashCode():
                    {
                        setValues(objectBankSelectorBox_C);
                        Index = 1;
                        break;
                    }

                case var case1 when case1 == objectBankSelectorBox_D.GetHashCode():
                    {
                        setValues(objectBankSelectorBox_D);
                        Index = 2;
                        break;
                    }

                case var case2 when case2 == objectBankSelectorBox_9.GetHashCode():
                    {
                        setValues(objectBankSelectorBox_9);
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
                        case var case3 when case3 == objectBankSelectorBox_C.GetHashCode():
                            {
                                objectBankSelectorBox_C.ContentItems.Add(new LabelItem() { Text = n });
                                break;
                            }

                        case var case4 when case4 == objectBankSelectorBox_D.GetHashCode():
                            {
                                objectBankSelectorBox_D.ContentItems.Add(new LabelItem() { Text = n });
                                break;
                            }

                        case var case5 when case5 == objectBankSelectorBox_9.GetHashCode():
                            {
                                objectBankSelectorBox_9.ContentItems.Add(new LabelItem() { Text = n });
                                break;
                            }
                    }
                }
            }

            objectBankSelectorBox_C.Refresh();
            objectBankSelectorBox_D.Refresh();
            objectBankSelectorBox_9.Refresh();
        }

        private void Button_LM_AddEditSpecial_Click(object sender, EventArgs e)
        {
            if (!loadingLevel)
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
            if (!loadingLevel)
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
            if (!savingRom)
            {
                var curLevelIndex = CurrentLevelIndex;
                var curAreaIndex = CurrentAreaIndex;
                if (curAreaIndex == -1)
                {
                    var usedIDs = Controller.GetLevelAreasCount((ushort)curLevelIndex);
                    if (usedIDs > 0)
                        curAreaIndex = 0;
                }
                Controller.OpenAreaEditor(curLevelIndex, curAreaIndex);
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
            if (!savingRom)
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
            ButtonItem_LevelTools_ChangeSizeOfBank0x19.Visible = Controller.HasLevelBank0x19(CurrentLevelIndex);
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

        private void Button_LM_AddNewLevel_Click(object sender, EventArgs e) => Button_LM_AddNewLevel_Click();
        private void Button_LM_AddArea_Click(object sender, EventArgs e) => Button_LM_AddArea_Click();
        private void Button_LM_RemoveArea_Click(object sender, EventArgs e) => Button_LM_RemoveArea_Click();
        private void Controls_HandleToSaveLevelSettings(object sender, EventArgs e) => Controls_HandleToSaveLevelSettings();
        private void LM_SaveGameBackground(object sender, EventArgs e) => LM_SaveGameBackground();
        private void ComboBoxEx_LM_BGMode_SelectedIndexChanged(object sender, EventArgs e) => ComboBoxEx_LM_BGMode_SelectedIndexChanged();
        private void ComboBoxEx_LM_AreaBG_SelectedIndexChanged(object sender, EventArgs e) => ComboBoxEx_LM_AreaBG_SelectedIndexChanged();
        private void LM_SaveAreaBackgorund(object sender, EventArgs e) => LM_SaveAreaBackgorund();
        private void LM_LoadCustomBackground(object sender, EventArgs e) => LM_LoadCustomBackground();
        private void Controls_HandleToSaveAreaSettings(object sender, EventArgs e)
        {
            Controls_HandleToSaveAreaSettings();

            if (sender == CheckBoxX_LM_Enable2DCamera && !Controller.CanUse2DCamera())
                MessageBoxEx.Show(this, Form_Main_Resources.MsgBox_No2DCameraPatched, Form_Main_Resources.MsgBox_No2DCameraPatched_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
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

        private void RangeSlider_CameraFrustrum_ValueChanged(object sender, EventArgs e)
        {
            SaveAreaSettings();
        }

        private void ButtonItem_ExportArea_Click(object sender, EventArgs e)
        {
            ExportLevelOrArea(false);
        }

        private void ButtonItem_ExportLevel_Click(object sender, EventArgs e)
        {
            ExportLevelOrArea(true);
        }

        private void ExportLevelOrArea(bool levelOnly)
        {
            var res = Controller.OpenExportLevelFileDialog(levelOnly);

            switch (res.mode)
            {
                case 1: // Export full level
                    Controller.ExportLevel(res.filePath, res.compression, CurrentLevelIndex);
                    break;
                case 2: // Export full area
                    Controller.ExportLevelArea(res.filePath, res.compression, CurrentLevelIndex, CurrentAreaIndex);
                    break;
                case 3: // Export objects
                    Controller.ExportLevelAreaObjects(res.filePath, res.compression, CurrentLevelIndex, CurrentAreaIndex);
                    break;
                case 4: // Export warps
                    Controller.ExportLevelAreaWarps(res.filePath, res.compression, CurrentLevelIndex, CurrentAreaIndex);
                    break;
            }
        }

        private void ObjectBankSelectorBox_SelectedComboIndexChanged(object sender, EventArgs e)
        {
            Controls_HandleToSaveLevelSettings();
            LM_UpdateObjectBankList(sender, e);
        }

        private void LevelsTree_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            LoadCurrentSelection();
        }

        private void LoadCurrentSelection(bool forceLoadingNothing = false)
        {
            bool menuItemsEnabled = false;
            
            if (!forceLoadingNothing)
            {
                var indices = CurrentIndicies;

                panel_Tools.SuspendLayout();

                if (indices.areaIndex != -1 && indices.levelIndex != -1)
                {
                    LoadAreaSettings(indices.levelIndex, indices.areaIndex);
                    EnableTabControl(TabControl_AreaProperties);
                    menuItemsEnabled = true;
                }
                else
                {
                    var isNull = indices.levelIndex == -1;
                    LoadLevelSettings(indices.levelIndex);
                    EnableTabControl(isNull ? null : TabControl_LM_Level);
                    menuItemsEnabled = !isNull;
                }
            }

            ButtonItem_OpenLevelEditor.Enabled = menuItemsEnabled;
            ButtonItem_RemoveItem.Enabled = menuItemsEnabled;
            ButtonItem_ExportLevelArea.Enabled = menuItemsEnabled;
            buttonItem1.Enabled = menuItemsEnabled;
            ButtonItem_AreaTools_AddArea.Enabled = menuItemsEnabled;
            ButtonItem_AreaTools_ImportArea.Enabled = menuItemsEnabled;

            bar1.Refresh();
            panel_Tools.ResumeLayout();
        }

        private void EnableTabControl(DevComponents.DotNetBar.TabControl tabControl)
        {
            // Disable all tab controls
            TabControl_LM_Level.Visible = false;
            TabControl_AreaProperties.Visible = false;

            // Enable given tab control
            if (tabControl is object)
            {
                tabControl.Dock = DockStyle.Fill;
                tabControl.Visible = true;
            }
        }

        private void ButtonItem_RemoveItem_Click(object sender, EventArgs e)
        {
            if (CurrentAreaIndex != -1)
                Button_LM_RemoveArea_Click(sender, e);
            else if (CurrentLevelIndex != -1)
                ButtonItem19_Click(sender, e);
        }

        private void ButtonItem_ExportLevelArea_Click(object sender, EventArgs e)
        {
            if (CurrentAreaIndex != -1)
                ButtonItem_ExportArea_Click(sender, e);
            else if (CurrentLevelIndex != -1)
                ButtonItem_ExportLevel_Click(sender, e);
        }
    }
}
