using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager.SettingsManager
{
    public class WindowSettings
    {
        public bool IsDefault { get; private set; } = false;
        public FormWindowState State { get; private set; }
        public Point Location { get; private set; }
        public Size Size { get; set; }

        public void SaveState(Form form)
        {
            var state = form.WindowState;
            if (state != FormWindowState.Minimized)
            {
                State = state;
                if (State != FormWindowState.Maximized)
                {
                    Location = form.Location;
                    Size = form.Size;
                }
                IsDefault = false;
            }
        }

        public void ApplyState(Form form)
        {
            if (!IsDefault)
            {
                form.WindowState = State;
                if (State != FormWindowState.Maximized)
                {
                    form.Location = Location;
                    form.Size = Size;
                }
            }
        }
    }
}
