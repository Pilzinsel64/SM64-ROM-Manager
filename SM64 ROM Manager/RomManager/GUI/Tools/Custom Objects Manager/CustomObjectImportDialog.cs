using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using SM64Lib;
using SM64Lib.Behaviors;
using SM64Lib.Configuration;
using SM64Lib.Objects.ModelBanks;
using SM64Lib.Objects.ObjectBanks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class CustomObjectImportDialog : OfficeForm
    {
        private readonly RomManager romManager;
        private readonly Dictionary<string, CustomObjectImport> imports;
        public Behavior Behavior { get; set; } = null;

        public CustomObjectImportDialog(RomManager romManager, Dictionary<string, CustomObjectImport> imports)
        {
            General.LoadBehaviorInfosIfEmpty(romManager);
            this.romManager = romManager;
            this.imports = imports;
            InitializeComponent();
            UpdateAmbientColors();
        }

        private void LoadList()
        {
            foreach (var kvp in imports)
            {
                foreach (var customObject in kvp.Value.Data.CustomObjects)
                {
                    flowLayoutPanel1.Controls.Add(
                        new CustomObjectImportPropsEditor(customObject, kvp.Value, romManager)
                        {
                            BackColor = Color.Transparent,
                            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
                            Width = flowLayoutPanel1.Width - 24
                        });
                }
            }
        }

        private void CustomModelSelector_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
