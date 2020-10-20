﻿using System;
using global::System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.My.Resources;
using DevComponents.DotNetBar.Validator;
using System.Collections.Generic;
using System.Drawing;

namespace SM64_ROM_Manager
{
    public partial class Tab_General
    {

        // F i e l d s

        private MainController _Controller;
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
                    _Controller.RomLoading -= Controller_RomLoading;
                    _Controller.RomLoaded -= Controller_RomLoaded;
                    _Controller.RomSaved -= Controller_RomSaved;
                }

                _Controller = value;
                if (_Controller != null)
                {
                    _Controller.RomLoading += Controller_RomLoading;
                    _Controller.RomLoaded += Controller_RomLoaded;
                    _Controller.RomSaved += Controller_RomSaved;
                }
            }
        }

        // C o n s t r u c t o r

        public Tab_General()
        {
            InitializeComponent();
            ItemPanel_RecentFiles.Height = 534;
            microChart1.DataPoints.Clear();
        }

        // C o n t r o l l e r   E v e n t s

        private void Controller_RomLoaded()
        {
            LabelX_G_Filename.Text = Path.GetFileName(Controller.Romfile);
            LoadRomConfigInfos();
            LoadRomSpaceInfo();
        }

        private void Controller_RomLoading()
        {
            TextBoxX_G_GameName.ReadOnly = true;
            TextBoxX_G_GameName.Text = Controller.GetGameName();
            TextBoxX_G_GameName.ReadOnly = false;
            LabelX_G_Filesize.Text = string.Format("{0} Megabyte", Conversions.ToInteger(Controller.GetRomFileSize()));
        }

        private void Controller_RomSaved()
        {
            LoadRomConfigInfos();
            LoadRomSpaceInfo();
        }

        // F e a t u r e s

        private void LoadRomConfigInfos()
        {
            var res = Controller.GetRomConfigInfo();
            labelX_RomConfigFilepath.Text = res.fileName;

            if (res.available)
            {
                labelX_RomConfigStatus.Text = "Available";
                pictureBox_RomConfigStatus.Image = MyIcons.icons8_checkmark_16px_1;
                highlighter1.SetHighlightColor(groupPanel1, eHighlightColor.None);
            }
            else
            {
                labelX_RomConfigStatus.Text = "Missing";
                pictureBox_RomConfigStatus.Image = MyIcons.icons8_delete_sign_16px;
                highlighter1.SetHighlightColor(groupPanel1, eHighlightColor.Red);
            }
        }

        private void LoadRomSpaceInfo()
        {
            var info = Controller.GetRomSpaceInfo();

            microChart1.PieChartStyle.SliceColors.Clear();
            microChart1.PieChartStyle.SliceColors.AddRange(new Color[] {
                Color.IndianRed,
                Color.Violet,
                Color.DarkBlue,
                Color.Brown,
                Color.DarkOliveGreen
            });

            microChart1.DataPoints = new List<double>() {
                info.UsedLevelsSpace,
                info.UsedMusicSpace,
                info.UsedGlobalModelsSpace,
                info.UsedGlobalBehaviorSpace,
                info.FreeSpace
            };

            microChart1.DataPointTooltips = new List<string>() {
                $"Levels ({info.UsedLevelsSpace * 100 / info.MaxAvailableSpace}%)",
                $"Music ({info.UsedMusicSpace * 100 / info.MaxAvailableSpace}%)",
                $"Global Model Bank ({info.UsedGlobalModelsSpace * 100 / info.MaxAvailableSpace}%)",
                $"Global Behavior Bank ({info.UsedGlobalBehaviorSpace * 100 / info.MaxAvailableSpace}%)",
                $"Free Space ({info.FreeSpace * 100 / info.MaxAvailableSpace}%)"
            };
        }

        // G u i

        private void Button_G_SaveGameName_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.SetGameName(TextBoxX_G_GameName.Text);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(Form_Main_Resources.MsgBox_GameNameHasInvalidChars, Global_Resources.Text_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Button_G_SaveGameName.Enabled = false;
        }

        private void TextBoxX_G_GameName_TextChanged(object sender, EventArgs e)
        {
            if (!TextBoxX_G_GameName.ReadOnly & Controller.HasRomManager)
            {
                Button_G_SaveGameName.Enabled = true;
            }
        }
    }
}