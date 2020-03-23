using System;
using System.Runtime.CompilerServices;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.EventArguments;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class Tab_MusicManager
    {
        public Tab_MusicManager()
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

                    _Controller.MusicSequenceRemoved -= Controller_MusicSequenceRemoved;
                    _Controller.MusicSequenceChanged -= Controller_MusicSequenceChanged;
                    _Controller.MusicSequenceAdded -= Controller_MusicSequenceAdded;
                    _Controller.RomMusicLoaded -= Controller_RomMusicLoaded;
                }

                _Controller = value;
                if (_Controller != null)
                {
                    _Controller.MusicSequenceRemoved += Controller_MusicSequenceRemoved;
                    _Controller.MusicSequenceChanged += Controller_MusicSequenceChanged;
                    _Controller.MusicSequenceAdded += Controller_MusicSequenceAdded;
                    _Controller.RomMusicLoaded += Controller_RomMusicLoaded;
                }
            }
        }

        // P r o p e r t i e s

        private int SelectedSequenceIndex
        {
            get
            {
                return ListBoxAdv_MS_MusicSequences.SelectedIndex;
            }
        }

        private void Controller_MusicSequenceRemoved(MusicSequenceEventArgs e)
        {
            RemoveSequenceFromList(e.Index);
        }

        private void Controller_MusicSequenceChanged(MusicSequenceEventArgs e)
        {
            UpdateSequenceInList(e.Index);
            if (e.Index == SelectedSequenceIndex)
            {
                LoadCurrentSequence(e.Index);
            }
        }

        private void Controller_MusicSequenceAdded(MusicSequenceEventArgs e)
        {
            AddSequenceToList(e.Index, true);
        }

        private void Controller_RomMusicLoaded()
        {
            LoadSequenceList();
        }

        // G u i

        private void LoadSequenceList()
        {
            TextBoxX_MS_Sequencename.ReadOnly = true;
            ListBoxAdv_MS_MusicSequences.SuspendLayout();

            // Remember old Index
            int IndexBefore = SelectedSequenceIndex;

            // Clear Items
            ListBoxAdv_MS_MusicSequences.Items.Clear();

            // Add new items
            for (int i = 0, loopTo = Controller.GetMusicSeuenceCount() - 1; i <= loopTo; i++)
                AddSequenceToList(i, false);
            ListBoxAdv_MS_MusicSequences.ResumeLayout();
            ListBoxAdv_MS_MusicSequences.Refresh();
            SwitchButton_MS_OverwriteSizeRestrictions.Value = Controller.EnableMusicHack;
            TextBoxX_MS_Sequencename.ReadOnly = false;
            if (IndexBefore < 0)
                IndexBefore = 1;
            if (ListBoxAdv_MS_MusicSequences.Items.Count > IndexBefore)
            {
                ListBoxAdv_MS_MusicSequences.SelectedIndex = IndexBefore;
                ListBoxAdv_MS_MusicSequences.SelectedIndex = IndexBefore;
            }
            else if (ListBoxAdv_MS_MusicSequences.Items.Count > 1)
            {
                ListBoxAdv_MS_MusicSequences.SelectedIndex = 1;
            }
        }

        private void RemoveSequenceFromList(int index)
        {
            ListBoxAdv_MS_MusicSequences.Items.RemoveAt(index);
            ListBoxAdv_MS_MusicSequences.Refresh();
            if (index > 0)
            {
                ListBoxAdv_MS_MusicSequences.SelectedItem = ListBoxAdv_MS_MusicSequences.Items[index - 1];
            }
        }

        private void LoadCurrentSequence(int index)
        {
            int cIndex = index;
            bool IsNoIndex = cIndex < 0;
            bool IsIndex0 = cIndex == 0;
            GroupBox_MS_SelectedSequence.Enabled = !IsIndex0;
            GroupBox_MS_SeqProperties.Enabled = !IsIndex0;
            ButtonX_MS_RemoveSequence.Enabled = !IsIndex0;

            // Load Sequence Informations
            if (!IsNoIndex)
            {
                int tID = ListBoxAdv_MS_MusicSequences.SelectedIndex;
                var info = Controller.GetMusicSequenceInfos(index);
                TextBoxX_MS_Sequencename.ReadOnly = true;
                TextBoxX_MS_Sequencename.Text = info.name;
                LabelX_MS_SequenceID.Text = string.Format("{0}", TextValueConverter.TextFromValue(tID));
                LabelX_MS_SeqSize.Text = string.Format("{0} Bytes", TextValueConverter.TextFromValue(info.length));
                ComboBox_MS_NInst.SelectedIndex = info.instSet;
                TextBoxX_MS_Sequencename.ReadOnly = false;
            }
        }

        private void AddSequenceToList(int index, bool refreshAndSelect)
        {
            var btnItem = new ButtonItem();
            UpdateSequenceInList(index, btnItem);
            ListBoxAdv_MS_MusicSequences.Items.Insert(index, btnItem);
            if (refreshAndSelect)
            {
                ListBoxAdv_MS_MusicSequences.Refresh();
                ListBoxAdv_MS_MusicSequences.EnsureVisible(btnItem);
            }
        }

        private void UpdateSequenceInList(int index)
        {
            UpdateSequenceInList(index, (ButtonItem)ListBoxAdv_MS_MusicSequences.Items[index]);
            ListBoxAdv_MS_MusicSequences.Refresh();
        }

        private void UpdateSequenceInList(int index, ButtonItem buttonItem)
        {
            var infos = Controller.GetMusicSequenceInfos(index);
            string tName = $"{TextValueConverter.TextFromValue(index, charCount: 2)} - {infos.name}";
            buttonItem.Text = tName;
        }

        private void ListBoxAdv_MS_MusicSequences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TextBoxX_MS_Sequencename.ReadOnly)
            {
                LoadCurrentSequence(SelectedSequenceIndex);
            }
        }

        private void MusicSettings_SequenceNameChanged(object sender, EventArgs e)
        {
            if (!TextBoxX_MS_Sequencename.ReadOnly)
            {
                Controller.SetMusicSequenceName(SelectedSequenceIndex, TextBoxX_MS_Sequencename.Text);
            }
        }

        private void ComboBox_MS_NInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!TextBoxX_MS_Sequencename.ReadOnly)
            {
                Controller.SetMusicSequenceInstrumentSet(SelectedSequenceIndex, Conversions.ToByte(ComboBox_MS_NInst.SelectedIndex));
            }
        }

        private void SwitchButton_MS_OverwriteSizeRestrictions_ValueChanged(object sender, EventArgs e)
        {
            if (!TextBoxX_MS_Sequencename.ReadOnly)
            {
                Controller.EnableMusicHack = SwitchButton_MS_OverwriteSizeRestrictions.Value;
            }
        }

        private void Button_MS_ReplaceSequence_Click(object sender, EventArgs e)
        {
            Controller.ReplaceMusicSequence(SelectedSequenceIndex);
        }

        private void ButtonX_MS_AddSequence_Click(object sender, EventArgs e)
        {
            Controller.AddNewMusicSequence();
        }

        private void Button_MS_ExtractSequence_Click(object sender, EventArgs e)
        {
            Controller.ExtractMusicSequence(SelectedSequenceIndex);
        }

        private void ButtonX_MS_RemoveSequence_Click(object sender, EventArgs e)
        {
            Controller.RemoveMusicSequence(SelectedSequenceIndex);
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            Controller.EditMusicSequenceInHexEditor(SelectedSequenceIndex);
        }
    }
}