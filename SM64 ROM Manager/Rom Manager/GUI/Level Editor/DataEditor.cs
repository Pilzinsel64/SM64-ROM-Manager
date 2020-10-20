using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.LevelEditor
{
    public partial class DataEditor : OfficeForm
    {
        // E n u m s

        private enum ViewMode
        {
            Objects,
            Warps
        }

        // F i e l d s

        private readonly ResourceManager resources = new ResourceManager(typeof(DataEditor));

        // C l a s s e s

        private class ColumnConfig
        {
            public string Name { get; set; }
            public bool IsResourceName { get; set; }
            public bool ReadOnly { get; set; }
        }

        // F i e l d s

        private bool enableEdit = false;
        private Dictionary<ViewMode, ColumnConfig[]> columnConfigs = null;

        // C o n s t r u s c t o r

        public DataEditor()
        {
            InitializeComponent();
            LoadColumnConfig();
        }

        // F e a t u r e s

        private void LoadColumnConfig()
        {
            columnConfigs = JsonConvert.DeserializeObject<Dictionary<ViewMode, ColumnConfig[]>>(string.Empty);
        }

        private void SwitchView(ViewMode viewMode)
        {
            // Disable edit
            enableEdit = false;
            superGridControl1.SuspendLayout();

            // Clear grid
            superGridControl1.PrimaryGrid.Rows.Clear();

            // Build new grid
            BuildGrid(viewMode);

            // Load items to grid
            LoadGrid(viewMode);

            // Enable edit
            superGridControl1.ResumeLayout();
            enableEdit = true;
        }

        private void BuildGrid(ViewMode viewMode)
        {
            var configs = columnConfigs[viewMode];

            // Clear columns
            superGridControl1.PrimaryGrid.Columns.Clear();

            // Add new columns
            foreach (var config in configs)
            {
                // Get name
                var name = config.Name;

                // Load translation from resources
                if (config.IsResourceName)
                    name = resources.GetString($"GridRow_{viewMode}_{config.Name}");

                var column = new GridColumn(name)
                {
                    ReadOnly = config.ReadOnly
                };
            }
        }

        private void LoadGrid(ViewMode viewMode)
        {

        }

        // G u i

        private void CheckBoxItem_Objects_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxItem_Warps_Click(object sender, EventArgs e)
        {

        }
    }
}
