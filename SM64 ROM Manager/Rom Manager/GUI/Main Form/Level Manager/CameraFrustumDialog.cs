using DevComponents.DotNetBar;
using SM64Lib.Geolayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager
{
    public partial class CameraFrustumDialog : OfficeForm
    {
        private CameraFrustrum cameraFrustrum;

        public CameraFrustumDialog(CameraFrustrum cameraFrustrum)
        {
            this.cameraFrustrum = cameraFrustrum;
            InitializeComponent();
            UpdateAmbientColors();
            LoadVals();
        }

        private void LoadVals()
        {
            textBoxX_Near.Text = TextValueConverter.TextFromValue(cameraFrustrum.CameraNear);
            textBoxX_Far.Text = TextValueConverter.TextFromValue(cameraFrustrum.CameraFar);
        }

        private void SaveVals()
        {
            cameraFrustrum.CameraNear = (short)TextValueConverter.ValueFromText(textBoxX_Near.Text);
            cameraFrustrum.CameraFar = (short)TextValueConverter.ValueFromText(textBoxX_Far.Text);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            SaveVals();
            DialogResult = DialogResult.OK;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
        }
    }
}
