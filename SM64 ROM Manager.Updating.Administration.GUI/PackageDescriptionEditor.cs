using System;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.Updating.Administration.GUI
{
    public partial class PackageDescriptionEditor
    {

        // C o n s t r u c t o r s

        public PackageDescriptionEditor()
        {
            InitializeComponent();
        }

        // P r o p e r t i e s

        public string Titel
        {
            get
            {
                return textBoxX1.Text;
            }
            set
            {
                textBoxX1.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return textBoxX2.Text;
            }
            set
            {
                textBoxX2.Text = value;
            }
        }
    }
}