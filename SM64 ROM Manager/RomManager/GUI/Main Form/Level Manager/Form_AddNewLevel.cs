using System;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib;

namespace SM64_ROM_Manager
{
    public partial class LevelSelectorDialog
    {
        public LevelSelectorDialog(RomManager rommgr)
        {
            base.Load += AddNewLevel_Load;
            InitializeComponent();
            base.UpdateAmbientColors();
            this.rommgr = rommgr;
        }

        private RomManager rommgr = null;
        private bool FinishedLoading = false;
        private SM64Lib.Levels.LevelInfoDataTabelList lidtable = new SM64Lib.Levels.LevelInfoDataTabelList();

        public SM64Lib.Levels.LevelInfoDataTabelList.Level SelectedLevel
        {
            get
            {
                return lidtable[ComboBox_Level.SelectedIndex];
            }
        }

        private void AddNewLevel_Load(object sender, EventArgs e)
        {
            if (FinishedLoading)
                return;
            LoadAddLevel();
            ComboBox_Level.SelectedIndex = 0;
            FinishedLoading = true;
        }

        private void LoadAddLevel()
        {
            foreach (var e in rommgr.LevelInfoData)
            {
                if (rommgr.Levels.Where(n => n.LevelID == e.ID).Count() == 0)
                {
                    lidtable.Add(e);
                }
            }

            {
                var withBlock = ComboBox_Level.Items;
                withBlock.Clear();
                foreach (var lid in lidtable)
                    withBlock.Add((lid.Type == SM64Lib.Levels.LevelInfoDataTabelList.LevelTypes.Level ? Conversions.ToInteger(lid.Number).ToString("00") + " - " : "") + lid.Name);
            }
        }
    }
}