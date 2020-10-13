using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class Tab_LevelManagerUniversal : UserControl
    {
        private MainController _controller;
        private Control content = null;

        public Tab_LevelManagerUniversal()
        {
            InitializeComponent();
        }

        public MainController Controller
        {
            get => _controller;
            set
            {
                _controller = value;
                SetController();
            }
        }

        private void SetController()
        {
            if (content is Tab_LevelManager)
                ((Tab_LevelManager)content).Controller = Controller;
            else if (content is Tab_LevelManagerV2)
                ((Tab_LevelManagerV2)content).Controller = Controller;
        }

        public void InitialiseTab(bool useNewGui = false)
        {
            Controls.Clear();

            if (useNewGui)
                content = new Tab_LevelManagerV2();
            else
                content = new Tab_LevelManager();

            content.Dock = DockStyle.Fill;
            SetController();

            Controls.Add(content);
        }
    }
}
