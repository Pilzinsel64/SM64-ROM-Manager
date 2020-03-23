using global::DevComponents.DotNetBar;
using global::SM64_ROM_Manager.Updating.Client.GUI.My.Resources;

namespace SM64_ROM_Manager.Updating.Client.GUI
{
    public partial class SimpleActionDialog
    {
        public SimpleActionDialog()
        {
            InitializeComponent();
            StyleManager.UpdateAmbientColors(this);
            SetCurrentState(UpdateStatus.Waiting);
        }

        public void SetCurrentState(UpdateStatus curAction)
        {
            SetCurrentStateInternal(curAction, -1);
        }

        public void SetCurrentState(UpdateStatus curAction, int progress)
        {
            SetCurrentStateInternal(curAction, progress);
        }

        private void SetCurrentStateInternal(UpdateStatus curAction, int progress)
        {
            switch (curAction)
            {
                case UpdateStatus.Waiting:
                    {
                        LabelX_Progress.Text = UpdatingClientGuiLangRes.SimpleActions_Waiting;
                        break;
                    }

                case UpdateStatus.Searching:
                    {
                        LabelX_Progress.Text = UpdatingClientGuiLangRes.SimpleActions_Searching;
                        break;
                    }

                case UpdateStatus.DownloadingInstaller:
                    {
                        LabelX_Progress.Text = UpdatingClientGuiLangRes.SimpleActions_DownloadingInstaller;
                        break;
                    }

                case UpdateStatus.DownloadingPackage:
                    {
                        LabelX_Progress.Text = UpdatingClientGuiLangRes.SimpleActions_DownloadingPackage;
                        break;
                    }

                case UpdateStatus.StartingInstaller:
                    {
                        LabelX_Progress.Text = UpdatingClientGuiLangRes.SimpleActions_DownloadingInstaller;
                        break;
                    }
            }

            if (progress == -1)
            {
                ProgressBarX_Progress.ProgressType = eProgressItemType.Marquee;
            }
            else
            {
                ProgressBarX_Progress.ProgressType = eProgressItemType.Standard;
                ProgressBarX_Progress.Value = progress;
            }
        }
    }
}