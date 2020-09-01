using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.ProgressUpdater
{
    public partial class PasteFromDocument : OfficeForm
    {
        private Settings settings;

        public Image DocumentImage { get; private set; }

        public PasteFromDocument(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
            UpdateAmbientColors();
        }

        private void ButtonX_Paste_Click(object sender, EventArgs e)
        {
            BaseItem selectedItem = null;
            foreach (BaseItem item in itemPanel1.Items)
            {
                if (selectedItem == null && item is CheckBoxItem && ((CheckBoxItem)item).Checked)
                    selectedItem = item;
            }

            if (selectedItem?.Tag is object)
            {
                var md = (string)selectedItem.Tag;
                DocumentImage = MarkdownHelper.GetAsImage(md);
                DialogResult = DialogResult.OK;
            }
        }

        private async void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            var url = textBoxX1.Text.Trim();
            settings.UpcommingVersionsDownloadURL = url;
            if (!string.IsNullOrEmpty(url))
                await GetNewItems(url);
        }

        private async Task GetNewItems(string url)
        {
            var mdDocStr = await DownloadString(url);
            if (!string.IsNullOrEmpty(mdDocStr))
            {
                itemPanel1.SuspendLayout();
                itemPanel1.Items.Clear();

                foreach (var kvp in MarkdownHelper.SplitToVersions(mdDocStr))
                {
                    var item = new CheckBoxItem
                    {
                        Text = kvp.Key,
                        Tag = kvp.Value,
                        CheckBoxStyle = eCheckBoxStyle.RadioButton
                    };

                    item.DoubleClick += ButtonX_Paste_Click;

                    itemPanel1.Items.Add(item);
                }

                itemPanel1.ResumeLayout();
                itemPanel1.Refresh();

                if (itemPanel1.Items.Count != 0)
                    ((CheckBoxItem)itemPanel1.Items[0]).Checked = true;
            }
        }

        private static async Task<string> DownloadString(string url)
        {
            var wc = new WebClient();
            var res = await wc.DownloadStringTaskAsync(url);
            wc.Dispose();
            return res;
        }

        private void PasteFromDocument_Load(object sender, EventArgs e)
        {
            textBoxX1.Text = settings.UpcommingVersionsDownloadURL;
        }
    }
}
