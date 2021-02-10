using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib;
using global::SM64Lib.Levels;

namespace SM64_ROM_Manager
{
    public partial class ImportLevelDialog
    {

        private RomManager rommgr;
        private RomManager openrom = null;
        private bool addAreasOnly;
        private Level destLevel = null;
        private string openrompath;
        private ILevelManager lvlmgr;
        /// <summary>
        /// Possible modes:
        /// 0 = Import from ROM
        /// 1 = Import from level export
        /// </summary>
        private int importMode;

        public Level LevelCopy { get; private set; } = null;
        public LevelArea[] AreasCopy { get; private set; } = null;

        /// <summary>
        /// Imports a level/area from a ROM file interactively.
        /// </summary>
        /// <param name="rommgr">The destinated ROM Manager where the level/areas should be added.</param>
        /// <param name="destLevel">The destinated level where the areas should be added. Leave NULL if you want to import whole levels only.</param>
        /// <param name="romPath">The path to the ROM file to import from.</param>
        /// <param name="lvlmgr">A level manager to use for loading the levels from ROM.</param>
        public ImportLevelDialog(RomManager rommgr, Level destLevel, string romPath, ILevelManager lvlmgr) : this(rommgr, destLevel, romPath, 0)
        {
            this.lvlmgr = lvlmgr;
        }

        /// <summary>
        /// Imports a level/Area from a level export file interactively.
        /// </summary>
        /// <param name="rommgr">The destinated ROM Manager where the level/areas should be added.</param>
        /// <param name="destLevel">The destinated level where the areas should be added.</param>
        /// <param name="exportPath">The path to the level export file to import from.</param>
        public ImportLevelDialog(RomManager rommgr, Level destLevel, string exportPath) : this(rommgr, destLevel, exportPath, 1)
        {
        }

        /// <summary>
        /// Imports a level/Area from a level export file interactively.
        /// </summary>
        /// <param name="rommgr">The destinated ROM Manager where the level/areas should be added.</param>
        /// <param name="exportPath">The path to the level export file to import from.</param>
        public ImportLevelDialog(RomManager rommgr, string exportPath) : this(rommgr, null, exportPath, 1)
        {
        }

        private ImportLevelDialog(RomManager rommgr, Level destLevel, string filePath, int mode)
        {
            this.Shown += ImportLevelDialog_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();

            this.rommgr = rommgr;
            this.destLevel = destLevel;
            addAreasOnly = destLevel is object;

            openrompath = filePath;
            importMode = mode;
        }

        public async Task<bool> LoadList()
        {
            bool res;

            switch (importMode)
            {
                case 0:
                    res = await LoadROM();
                    break;
                case 1:
                    res = await LoadLevelExport();
                    break;
                default:
                    res = false;
                    break;
            }

            return res;
        }

        public async Task<bool> LoadROM()
        {
            var mgr = new RomManager(openrompath, lvlmgr);
            Publics.Publics.LoadLegacyObjectBankData(mgr);
            if (mgr.CheckROM(true))
            {
                openrom = mgr;
                LabelX_Romfile.Text = System.IO.Path.GetFileName(mgr.RomFile);
                Enabled = false;
                CircularProgress1.Start();
                await Task.Run(() => mgr.LoadLevels());
                CircularProgress1.Stop();
                Enabled = true;
                LoadLevelsFromROM();
                return true;
            }
            else
            {
                MessageBoxEx.Show("This ROM can't be used.", "Invalid ROM file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadLevelsFromROM()
        {
            ItemListBox_Levels.Items.Clear();
            if (openrom is object)
            {
                foreach (Level lvl in openrom.Levels)
                    AddLevelItemToList(lvl);
            }

            if (ItemListBox_Levels.Items.Count > 0)
            {
                ItemListBox_Levels.SelectedIndex = 0;
            }

            ItemListBox_Levels.Refresh();
        }

        private async Task<bool> LoadLevelExport()
        {
            LevelExport export = null;

            await Task.Run(() =>
            {
                export = LevelExport.ReadFromFile(openrompath);
            });

            var isValid = export?.Content is object && (export.ContentType == LevelExportContentType.Level || (export.ContentType == LevelExportContentType.Area && addAreasOnly));

            if (isValid)
                LoadLevelsFromLevelExport(export);

            return isValid;
        }

        private void LoadLevelsFromLevelExport(LevelExport levelExport)
        {
            ItemListBox_Levels.Items.Clear();

            if (levelExport.ContentType == LevelExportContentType.Level)
            {
                var levels = levelExport.Content as List<Level> ?? new List<Level> { };
                foreach (Level lvl in levels)
                    AddLevelItemToList(lvl);
            }
            else if (levelExport.ContentType == LevelExportContentType.Area)
            {
                var btn = new ButtonItem()
                {
                    Text = "Undefined Level",
                    Tag = levelExport.Content
                };
                ItemListBox_Levels.Items.Add(btn);
            }

            if (ItemListBox_Levels.Items.Count > 0)
                ItemListBox_Levels.SelectedIndex = 0;

            ItemListBox_Levels.Refresh();
        }

        private void AddLevelItemToList(Level lvl)
        {
            var lid = rommgr.LevelInfoData.GetByLevelID(lvl.LevelID);
            var btn = new ButtonItem()
            {
                Text = (lid.Type == LevelInfoDataTabelList.LevelTypes.Level ? Conversions.ToByte(lid.Number).ToString("00") + " - " : "") + lid.Name,
                Tag = lvl
            };
            ItemListBox_Levels.Items.Add(btn);
        }

        private object GetSelectedLevel()
        {
            ButtonItem selItem = (ButtonItem)ItemListBox_Levels.SelectedItem;
            var lvl = selItem?.Tag;
            return lvl;
        }

        private void ButtonX_Import_Click(object sender, EventArgs e)
        {
            var content = GetSelectedLevel();
            if (content is object)
            {
                Level newLvl;

                void copySM64EArea(LevelArea a, LevelArea newArea)
                {
                    newArea.Background.Type = a.Background.Type;
                    newArea.Background.Color = a.Background.Color;
                    // newArea.BGMusic = a.BGMusic
                    newArea.TerrainType = a.TerrainType;
                    newArea.Objects.AddRange(a.Objects.ToArray());
                    newArea.Warps.AddRange(a.Warps.ToArray());
                    newArea.WarpsForGame.AddRange(a.WarpsForGame.ToArray());
                    newArea.AreaModel = a.AreaModel;
                };

                if (addAreasOnly)
                {
                    var areasToAsdd = new List<LevelArea>();
                    Stack<byte> availableAreaIDs;
                    newLvl = destLevel;

                    // Get all available area ids
                    availableAreaIDs = Publics.General.GetAllFreeAreaIDs(destLevel);

                    // Get selected Areas
                    var areasToCopy = new List<LevelArea>();
                    foreach (CheckBoxItem item in ItemPanel_Areas.Items)
                    {
                        if (item.Tag is LevelArea && item.Checked)
                            areasToCopy.Add((LevelArea)item.Tag);
                    }

                    if (availableAreaIDs.Count >= areasToCopy.Count)
                    {
                        // Copy areas
                        foreach (LevelArea fearea in areasToCopy)
                        {
                            LevelArea area = fearea;
                            if (openrom is object && openrom.IsSM64EditorMode)
                            {
                                var newArea = new SM64ELevelArea(availableAreaIDs.Pop());
                                copySM64EArea(area, newArea);
                                area = newArea;
                            }
                            else
                                area.AreaID = availableAreaIDs.Pop();

                            areasToAsdd.Add(area);
                        }

                        // Add areas
                        newLvl.Areas.AddRange(areasToAsdd);
                        AreasCopy = areasToAsdd.ToArray();

                        // Close Window
                        DialogResult = DialogResult.OK;
                    }
                    else if (!areasToCopy.Any())
                        MessageBoxEx.Show("You haven't selected any area to copy.", "No area selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBoxEx.Show("You have to many areas selected. The destination level hasn't enough free area slots.", "To many areas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (content is Level)
                {
                    var lvl = (Level)content;
                    LevelInfoDataTabelList.Level levelinfo;

                    var selector = new LevelSelectorDialog(rommgr);
                    if (selector.ShowDialog() == DialogResult.OK)
                    {
                        levelinfo = selector.SelectedLevel;

                        switch (openrom is object && openrom.IsSM64EditorMode)
                        {
                            case true:
                                {
                                    // Create mew Level
                                    newLvl = new RMLevel(levelinfo.ID, levelinfo.Index, rommgr);

                                    // Create new Areas & Copy Area Data
                                    foreach (LevelArea a in lvl.Areas)
                                    {
                                        var newArea = new RMLevelArea(a.AreaID, Conversions.ToByte(newLvl.LevelID), false, false);
                                        copySM64EArea(a, newArea);
                                        newLvl.Areas.Add(newArea);
                                    }

                                    // Copy Level Data
                                    newLvl.Background.Enabled = lvl.Background.Enabled;
                                    newLvl.Background.ID = lvl.Background.ID;
                                    newLvl.Background.ImageData = lvl.Background.ImageData;
                                    newLvl.Background.IsCustom = lvl.Background.IsCustom;
                                    newLvl.HardcodedCameraSettings = lvl.HardcodedCameraSettings;
                                    newLvl.ActSelector = lvl.ActSelector;
                                    break;
                                }
                            case false:
                                newLvl = lvl;
                                newLvl.RomManager = rommgr;
                                newLvl.LevelID = levelinfo.ID;
                                break;
                            default:
                                newLvl = null;
                                break;
                        }

                        if (newLvl is object)
                        {
                            // Add Level
                            rommgr.Levels.Add(newLvl);
                            LevelCopy = newLvl;

                            // Close Window
                            DialogResult = DialogResult.OK;
                        }
                        else
                            MessageBoxEx.Show("The level can't be added.", "Add Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ItemListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonX_Import.Enabled = ItemListBox_Levels.SelectedIndex > -1;
        }

        private void ItemListBox_Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableListBox = false;
            var content = GetSelectedLevel();
            ItemPanel_Areas.SuspendLayout();
            ItemPanel_Areas.Items.Clear();

            if (content is object)
            {
                var areas = new List<LevelArea>();
                if (content is Level)
                    areas.AddRange(((Level)content).Areas);
                else if (content is List<LevelArea>)
                    areas.AddRange((List<LevelArea>)content);

                foreach (LevelArea area in areas)
                {
                    var item = new CheckBoxItem()
                    {
                        Tag = area,
                        Text = "Area " + Conversions.ToString(area.AreaID),
                        Checked = true
                    };
                    ItemPanel_Areas.Items.Add(item);
                }

                if (addAreasOnly)
                    enableListBox = true;
            }

            ItemPanel_Areas.ResumeLayout(false);
            ItemPanel_Areas.Refresh();
            ItemPanel_Areas.Enabled = enableListBox;
        }

        private async void ImportLevelDialog_Shown(object sender, EventArgs e)
        {
            if (!await LoadList())
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}