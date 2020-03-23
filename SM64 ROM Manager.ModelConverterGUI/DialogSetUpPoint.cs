using global::System.Drawing;
using global::DevComponents.DotNetBar;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public partial class DialogSetUpPoint
    {
        public DialogSetUpPoint(string Title, bool ShowX, bool ShowY, bool ShowZ, int XValue, int YValue, int ZValue)
        {
            InitializeComponent();
            StyleManager.UpdateAmbientColors(this);
            Text = Title;
            int CurrentYPosition = 12;
            int CurrentWith = 164;
            if (ShowX)
            {
                LabelX_X.Visible = true;
                LabelX_X.Location = new Point(LabelX_X.Location.X, CurrentYPosition);
                IntegerInput_X.Visible = true;
                IntegerInput_X.Location = new Point(IntegerInput_X.Location.X, CurrentYPosition);
                IntegerInput_X.Value = XValue;
                CurrentYPosition += 26;
            }
            else
            {
                CurrentWith -= 26;
            }

            if (ShowY)
            {
                LabelX_Y.Visible = true;
                LabelX_Y.Location = new Point(LabelX_Y.Location.X, CurrentYPosition);
                IntegerInput_Y.Visible = true;
                IntegerInput_Y.Location = new Point(IntegerInput_Y.Location.X, CurrentYPosition);
                IntegerInput_Y.Value = YValue;
                CurrentYPosition += 26;
            }
            else
            {
                CurrentWith -= 26;
            }

            if (ShowX)
            {
                LabelX_Z.Visible = true;
                LabelX_Z.Location = new Point(LabelX_Z.Location.X, CurrentYPosition);
                IntegerInput_Z.Visible = true;
                IntegerInput_Z.Location = new Point(IntegerInput_Z.Location.X, CurrentYPosition);
                IntegerInput_Z.Value = ZValue;
                CurrentYPosition += 26;
            }
            else
            {
                CurrentWith -= 26;
            }

            CurrentYPosition += 3;
            Button_Okay.Location = new Point(Button_Okay.Location.X, CurrentYPosition);
            Button_Cancle.Location = new Point(Button_Cancle.Location.X, CurrentYPosition);
            Size = new Size(Size.Width, CurrentWith);
        }
    }
}