using System;
using global::System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.My.Resources;

namespace SM64_ROM_Manager
{
    public partial class Tab_General
    {
        public Tab_General()
        {
            InitializeComponent();
        }

        // F i e l d s

        private MainController _Controller;

        public MainController Controller
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Controller;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Controller != null)
                {

                    // C o n t r o l l e r   E v e n t s

                    _Controller.RomLoading -= Controller_RomLoading;
                    _Controller.RomLoaded -= Controller_RomLoaded;
                }

                _Controller = value;
                if (_Controller != null)
                {
                    _Controller.RomLoading += Controller_RomLoading;
                    _Controller.RomLoaded += Controller_RomLoaded;
                }
            }
        }

        private void Controller_RomLoading()
        {
            TextBoxX_G_GameName.ReadOnly = true;
            TextBoxX_G_GameName.Text = Controller.GetGameNAme();
            TextBoxX_G_GameName.ReadOnly = false;
            LabelX_G_Filesize.Text = string.Format("{0} Megabyte", Conversions.ToInteger(Controller.GetRomFileSize()));
        }

        private void Controller_RomLoaded()
        {
            LabelX_G_Filename.Text = Path.GetFileName(Controller.Romfile);
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