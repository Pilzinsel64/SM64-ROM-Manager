using DevComponents.DotNetBar;
using SM64Lib;
using SM64Lib.TextValueConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.Plugins.RomConfigEditor
{
    public partial class RomConfigEditor : OfficeForm
    {
        RomManager romManager;

        public RomConfigEditor(RomManager romManager)
        {
            this.romManager = romManager;
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var id = (byte)TextValueConverter.ValueFromText(textBoxX1.Text);
            if (!romManager.RomConfig.CollisionBaseConfig.CollisionTypesWithParams.Contains(id))
            {
                romManager.RomConfig.CollisionBaseConfig.CollisionTypesWithParams.Add(id);
                LoadColTypesWithParams();
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (itemPanel1.SelectedItem is object)
            {
                var id = (byte)((ButtonItem)itemPanel1.SelectedItem).Tag;
                if (romManager.RomConfig.CollisionBaseConfig.CollisionTypesWithParams.Contains(id))
                {
                    romManager.RomConfig.CollisionBaseConfig.CollisionTypesWithParams.Remove(id);
                    LoadColTypesWithParams();
                }
            }
        }

        private void itemPanel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RomConfigEditor_Load(object sender, EventArgs e)
        {
            LoadColTypesWithParams();
        }

        private void LoadColTypesWithParams()
        {
            itemPanel1.SuspendLayout();
            itemPanel1.Items.Clear();
            foreach (var type in romManager.RomConfig.CollisionBaseConfig.CollisionTypesWithParams)
            {
                var btn = new ButtonItem
                {
                    Text = type.ToString("X2"),
                    Tag = type,
                    AutoCheckOnClick = true
                };
                itemPanel1.Items.Add(btn);
            }
            itemPanel1.ResumeLayout();
            itemPanel1.Refresh();
        }
    }
}
