using global::Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN;

namespace SM64_ROM_Manager.SettingsManager
{
    public class AreaEditorSettingsStruc
    {
        public CameraMode DefaultCameraMode { get; set; }
        public System.Windows.Forms.FormWindowState DefaultWindowMode { get; set; }
        public bool RibbonControlExpanded { get; set; }

        public void ResetValues()
        {
            DefaultCameraMode = CameraMode.ORBIT;
            DefaultWindowMode = System.Windows.Forms.FormWindowState.Normal;
            RibbonControlExpanded = true;
        }
    }
}