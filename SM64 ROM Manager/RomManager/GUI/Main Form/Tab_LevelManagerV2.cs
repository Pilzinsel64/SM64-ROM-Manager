using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.AdvTree;

namespace SM64_ROM_Manager.GUI.Main_Form
{
    public partial class Tab_LevelManagerV2 : UserControl
    {
        // F i e l d s

        private MainController controller;
        private ObjectBankSelectorBox objectBankSelectorBox_C;
        private ObjectBankSelectorBox objectBankSelectorBox_D;
        private ObjectBankSelectorBox objectBankSelectorBox_9;

        private bool loadingAreaList = false;
        private bool savingRom = false;
        private bool loadingArea = false;
        private bool loadingLevel = false;

        Node nCustomLevels;
        Node nVanillaLevels;

        // C o n s t r u c t o r

        public Tab_LevelManagerV2()
        {
            // Init GUI
            InitializeComponent();

            // Init nodes
            nCustomLevels = new Node("Custom Levels");
            nVanillaLevels = new Node("Vanilla Levels");
            LevelsTree.Nodes.AddRange(new[] { nCustomLevels/*, nVanillaLevels*/ });
        }

        // P r o p e r t i e s

        // F e a t u r e s

        // G u i
    }
}
