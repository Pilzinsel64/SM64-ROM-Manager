using System;
using System.Collections.Generic;
using global::System.IO;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;

namespace SM64_ROM_Manager.UserRequests.GUI
{
    public partial class UserRequestPropertyFilesEditor
    {

        // F i e l d s

        private readonly UserRequestProperty prop;
        private readonly List<string> files = new List<string>();

        // C o n s t r u c t o r

        public UserRequestPropertyFilesEditor(UserRequestProperty prop)
        {
            InitializeComponent();
            this.prop = prop;
            MapFiles();
            RefreshList();
        }

        // F e a t u r e s

        private void MapFiles()
        {
            files.Clear();
            if (!string.IsNullOrEmpty(prop.Value))
            {
                files.AddRange(UserRequestManager.TranslateFilesStringToArray(prop.Value));
            }
        }

        private void WriteFiles()
        {
            prop.Value = UserRequestManager.TranslateFilesArrayToString(files.ToArray());
        }

        private void RefreshList()
        {
            ItemPanel_Files.BeginUpdate();
            ItemPanel_Files.Items.Clear();
            foreach (string f in files)
            {
                var btn = new ButtonItem()
                {
                    Text = Path.GetFileName(f),
                    Tag = f,
                    Image = Pilz.Win32.Internals.IconExtractor.ExtractIcon(f, true)?.ToBitmap(),
                    ButtonStyle = eButtonStyle.ImageAndText,
                    ImagePosition = eImagePosition.Left
                };
                btn.Click += (sender, e) => ItemPanel_Files.SelectedItem = (BaseItem)sender;
                ItemPanel_Files.Items.Add(btn);
            }

            ItemPanel_Files.EndUpdate();
            ItemPanel_Files.SelectedIndex = -1;
        }

        private void AddFiles()
        {
            var ofd_AddUSerRequestFiles = new OpenFileDialog() { Multiselect = true };
            if (ofd_AddUSerRequestFiles.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in ofd_AddUSerRequestFiles.FileNames)
                {
                    var fi = new FileInfo(f);
                    if (!files.Contains(f))
                    {
                        files.Add(f);
                    }
                }
            }

            WriteFiles();
            RefreshList();
        }

        private void RemoveFile()
        {
            int index = ItemPanel_Files.SelectedIndex;
            if (index >= 0)
            {
                files.RemoveAt(index);
            }

            WriteFiles();
            RefreshList();
        }

        // G u i

        private void ButtonX_Add_Click(object sender, EventArgs e)
        {
            AddFiles();
        }

        private void ButtonX_Remove_Click(object sender, EventArgs e)
        {
            RemoveFile();
        }

        private void ItemPanel_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonX_Remove.Enabled = ItemPanel_Files.SelectedIndex >= 0;
        }
    }
}