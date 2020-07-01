using System;
using System.Windows.Forms;
using global::DevComponents.DotNetBar.Metro.ColorTables;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.SettingsManager;
using DevComponents.DotNetBar.Controls;

namespace SM64_ROM_Manager
{
    public partial class Form_Stylemanager
    {
        public Form_Stylemanager()
        {
            base.Load += Form_Stylemanager_Load;
            this.Closed += Form_Stylemanager_Closed;

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            base.UpdateAmbientColors();
        }

        private bool isLoading = true;

        private void Form_Stylemanager_Load(object sender, EventArgs e)
        {
            ComboBoxEx1.Items.Clear();
            var themes = new[] { StyleManagerSettingsStruc.VisualThemeLight, StyleManagerSettingsStruc.VisualThemeGray, StyleManagerSettingsStruc.VisualThemeDark }; // MetroColorGeneratorParameters.GetAllPredefinedThemes
            var myTheme = Settings.StyleManager.MetroColorParams;
            ComboItem ciToSelect = null;
            foreach (var s in themes)
            {
                var item = new ComboItem();
                item.Text = s.ThemeName;
                item.Tag = s;
                if (myTheme.CanvasColor.ToArgb() == s.CanvasColor.ToArgb() && myTheme.BaseColor.ToArgb() == s.BaseColor.ToArgb())
                {
                    ciToSelect = item;
                }

                ComboBoxEx1.Items.Add(item);
            }

            if (ciToSelect is object)
            {
                ComboBoxEx1.SelectedItem = ciToSelect;
            }
            else if (ComboBoxEx1.Items.Count > 0)
            {
                ComboBoxEx1.SelectedIndex = 0;
            }

            if (Settings.StyleManager.UseSystemTheme)
            {
                CheckBoxX1.Checked = true;
            }
            else
            {
                CheckBoxX2.Checked = true;
            }

            CheckBoxX_KeepEditorControlBarBlue.Checked = Settings.StyleManager.AlwaysKeepBlueColors;
            isLoading = false;
        }

        private void ComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            MetroColorGeneratorParameters newTheme = (MetroColorGeneratorParameters)((ComboItem)ComboBoxEx1.SelectedItem).Tag;
            Settings.StyleManager.MetroColorParams = newTheme;
            Settings.StyleManager.UseSystemTheme = CheckBoxX1.Checked;
            Publics.Publics.SetVisualTheme();
            foreach (Form frm in Application.OpenForms)
            {
                frm.UpdateAmbientColors();
                frm.Refresh();
            }
        }

        private void CheckBoxX_KeepEditorControlBarBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            Settings.StyleManager.AlwaysKeepBlueColors = ((CheckBoxX)sender).Checked;
        }

        private void Form_Stylemanager_Closed(object sender, EventArgs e)
        {
            Settings.SaveSettings();
        }

        private void CheckBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxEx1.Enabled = CheckBoxX2.Checked;
        }
    }
}