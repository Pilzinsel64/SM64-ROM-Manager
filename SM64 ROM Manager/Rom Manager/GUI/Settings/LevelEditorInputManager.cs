using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic.CompilerServices;
using global::SharpDX.DirectInput;
using Z.Collections.Extensions;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public partial class LevelEditorInputManager
    {
        public LevelEditorInputManager()
        {
            Timer = new Timer() { Interval = 1 };

            // Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent();

            // Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            StyleManager.UpdateAmbientColors(this);
        }

        private Timer _Timer;

        private Timer Timer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer != null)
                {
                    _Timer.Tick -= (_, __) => Timer_Tick();
                }

                _Timer = value;
                if (_Timer != null)
                {
                    _Timer.Tick += (_, __) => Timer_Tick();
                }
            }
        }

        private DirectInput DInput = new DirectInput();
        private DeviceInstance[] allDevices = Array.Empty<DeviceInstance>();
        private Joystick curPad = null;
        private TextBoxX focuesTextBox = null;
        private LevelEditorInputProfile curProfile = null;

        private void TextBoxX_LostFocus_TextChanged(object sender, EventArgs e)
        {
            Timer.Stop();
            focuesTextBox = null;
        }

        private void TextBoxX_Click(object sender, EventArgs e)
        {
            if (curPad is object && curProfile is object)
            {
                focuesTextBox = (TextBoxX)sender;
                Timer.Start();
            }
        }

        private void Timer_Tick()
        {
            if (curPad is object)
            {
                var state = new JoystickState();
                curPad.Poll();
                curPad.GetCurrentState(ref state);
                for (int i = 0, loopTo = state.Buttons.Length - 1; i <= loopTo; i++)
                {
                    if (state.Buttons[i] && focuesTextBox is object)
                    {
                        focuesTextBox.Text = "Button " + Conversions.ToString(i);
                    }
                }

                for (int i = 0, loopTo1 = state.PointOfViewControllers.Length - 1; i <= loopTo1; i++)
                {
                    if (focuesTextBox is object)
                    {
                        int val = state.PointOfViewControllers[i];
                        if (val > -1)
                            focuesTextBox.Text = "Point " + Conversions.ToString(i) + " " + Conversions.ToString(val);
                    }
                }

                for (int i = 0, loopTo2 = state.Sliders.Length - 1; i <= loopTo2; i++)
                {
                    if (focuesTextBox is object)
                    {
                        int val = state.Sliders[i];
                        if (val > 0)
                            focuesTextBox.Text = "Slider " + Conversions.ToString(i) + " +";
                        if (val < 0)
                            focuesTextBox.Text = "Slider " + Conversions.ToString(i) + " -";
                    }
                }

                for (int i = 0, loopTo3 = state.AccelerationSliders.Length - 1; i <= loopTo3; i++)
                {
                    if (focuesTextBox is object)
                    {
                        int val = state.AccelerationSliders[i];
                        if (val > 0)
                            focuesTextBox.Text = "ASlider " + Conversions.ToString(i) + " +";
                        if (val < 0)
                            focuesTextBox.Text = "ASlider " + Conversions.ToString(i) + " -";
                    }
                }

                for (int i = 0, loopTo4 = state.ForceSliders.Length - 1; i <= loopTo4; i++)
                {
                    if (focuesTextBox is object)
                    {
                        int val = state.ForceSliders[i];
                        if (val > 0)
                            focuesTextBox.Text = "FSlider " + Conversions.ToString(i) + " +";
                        if (val < 0)
                            focuesTextBox.Text = "FSlider " + Conversions.ToString(i) + " -";
                    }
                }

                for (int i = 0, loopTo5 = state.VelocitySliders.Length - 1; i <= loopTo5; i++)
                {
                    if (focuesTextBox is object)
                    {
                        int val = state.VelocitySliders[i];
                        if (val > 0)
                            focuesTextBox.Text = "VSlider " + Conversions.ToString(i) + " +";
                        if (val < 0)
                            focuesTextBox.Text = "VSlider " + Conversions.ToString(i) + " -";
                    }
                }

                if (focuesTextBox is object)
                {
                    if (state.X > 0)
                        focuesTextBox.Text = "X +";
                    if (state.X < 0)
                        focuesTextBox.Text = "X -";
                }

                if (focuesTextBox is object)
                {
                    if (state.Y > 0)
                        focuesTextBox.Text = "Y +";
                    if (state.Y < 0)
                        focuesTextBox.Text = "Y -";
                }

                if (focuesTextBox is object)
                {
                    if (state.Z > 0)
                        focuesTextBox.Text = "Z +";
                    if (state.Z < 0)
                        focuesTextBox.Text = "Z -";
                }

                if (focuesTextBox is object)
                {
                    if (state.AccelerationX > 0)
                        focuesTextBox.Text = "AX +";
                    if (state.AccelerationX < 0)
                        focuesTextBox.Text = "AX -";
                }

                if (focuesTextBox is object)
                {
                    if (state.AccelerationY > 0)
                        focuesTextBox.Text = "AY +";
                    if (state.AccelerationY < 0)
                        focuesTextBox.Text = "AY -";
                }

                if (focuesTextBox is object)
                {
                    if (state.AccelerationZ > 0)
                        focuesTextBox.Text = "AZ +";
                    if (state.AccelerationZ < 0)
                        focuesTextBox.Text = "AZ -";
                }

                if (focuesTextBox is object)
                {
                    if (state.AngularAccelerationX > 0)
                        focuesTextBox.Text = "AAX +";
                    if (state.AngularAccelerationX < 0)
                        focuesTextBox.Text = "AAX -";
                }

                if (focuesTextBox is object)
                {
                    if (state.AngularAccelerationY > 0)
                        focuesTextBox.Text = "AAY +";
                    if (state.AngularAccelerationY < 0)
                        focuesTextBox.Text = "AAY -";
                }

                if (focuesTextBox is object)
                {
                    if (state.AngularAccelerationZ > 0)
                        focuesTextBox.Text = "AAZ +";
                    if (state.AngularAccelerationZ < 0)
                        focuesTextBox.Text = "AAZ -";
                }

                if (focuesTextBox is object)
                {
                    if (state.ForceX > 0)
                        focuesTextBox.Text = "FX +";
                    if (state.ForceX < 0)
                        focuesTextBox.Text = "FX -";
                }

                if (focuesTextBox is object)
                {
                    if (state.ForceY > 0)
                        focuesTextBox.Text = "FY +";
                    if (state.ForceY < 0)
                        focuesTextBox.Text = "FY -";
                }

                if (focuesTextBox is object)
                {
                    if (state.ForceZ > 0)
                        focuesTextBox.Text = "FZ +";
                    if (state.ForceZ < 0)
                        focuesTextBox.Text = "FZ -";
                }

                if (focuesTextBox is object)
                {
                    if (state.RotationX > 0)
                        focuesTextBox.Text = "RX +";
                    if (state.RotationX < 0)
                        focuesTextBox.Text = "RX -";
                }

                if (focuesTextBox is object)
                {
                    if (state.RotationY > 0)
                        focuesTextBox.Text = "RY +";
                    if (state.RotationY < 0)
                        focuesTextBox.Text = "RY -";
                }

                if (focuesTextBox is object)
                {
                    if (state.RotationZ > 0)
                        focuesTextBox.Text = "RZ +";
                    if (state.RotationZ < 0)
                        focuesTextBox.Text = "RZ -";
                }

                if (focuesTextBox is object)
                {
                    if (state.TorqueX > 0)
                        focuesTextBox.Text = "TX +";
                    if (state.TorqueX < 0)
                        focuesTextBox.Text = "TX -";
                }

                if (focuesTextBox is object)
                {
                    if (state.TorqueY > 0)
                        focuesTextBox.Text = "TY +";
                    if (state.TorqueY < 0)
                        focuesTextBox.Text = "TY -";
                }

                if (focuesTextBox is object)
                {
                    if (state.TorqueZ > 0)
                        focuesTextBox.Text = "TZ +";
                    if (state.TorqueZ < 0)
                        focuesTextBox.Text = "TZ -";
                }

                if (focuesTextBox is object)
                {
                    if (state.VelocityX > 0)
                        focuesTextBox.Text = "VX +";
                    if (state.VelocityX < 0)
                        focuesTextBox.Text = "VX -";
                }

                if (focuesTextBox is object)
                {
                    if (state.VelocityY > 0)
                        focuesTextBox.Text = "VY +";
                    if (state.VelocityY < 0)
                        focuesTextBox.Text = "VY -";
                }

                if (focuesTextBox is object)
                {
                    if (state.VelocityZ > 0)
                        focuesTextBox.Text = "VZ +";
                    if (state.VelocityZ < 0)
                        focuesTextBox.Text = "VZ -";
                }
            }
        }

        private void LevelEditorInputManager_Shown(object sender, EventArgs e)
        {
            // Load Control Pads
            LoadPads();

            // Load Profile
            LoadProfile(Publics.General.MyDataPath + @"\Area Editor\Controller Profile.json");
        }

        private void LoadPads()
        {
            allDevices = DInput.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly).ToArray();
            ComboBoxEx1.Items.Clear();
            foreach (DeviceInstance d in allDevices)
                ComboBoxEx1.Items.Add(d.InstanceName);
        }

        private void ComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ComboBoxEx1.SelectedIndex;
            if (index < 0)
                return;
            curPad = new Joystick(DInput, allDevices[index].InstanceGuid);
            foreach (DeviceObjectInstance doi in curPad.GetObjects(DeviceObjectTypeFlags.Axis))
                curPad.GetObjectPropertiesById(doi.ObjectId).Range = new InputRange(-5000, 5000);
            curPad.Properties.AxisMode = DeviceAxisMode.Absolute;
            curPad.SetCooperativeLevel(Handle, CooperativeLevel.NonExclusive | CooperativeLevel.Background);
            curPad.Acquire();
            if (curProfile is object)
                curProfile.ControllerInstanceGuid = allDevices[index].InstanceGuid;
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            LoadPads();
        }

        public static LevelEditorInputProfile[] LoadProfiles(string path)
        {
            var profs = new List<LevelEditorInputProfile>();
            foreach (string f in System.IO.Directory.GetFiles(path, "*.json"))
                profs.Add(LevelEditorInputProfile.Load(f));
            return profs.ToArray();
        }

        public static InputControl GetInputControlFromString(string str)
        {
            var input = new InputControl();
            var p = str.Split(" ");
            var switchExpr = p[0];
            switch (switchExpr)
            {
                case "Button":
                        input.InputKey = InputKeys.Buttons;
                        input.KeyIndex = Convert.ToInt32(p[1]);
                        break;
                case "Point":
                        input.InputKey = InputKeys.PointOfViewControllers;
                        input.KeyIndex = Convert.ToInt32(p[1]);
                        input.Value = p[2];
                        break;
                case "Slider":
                        input.InputKey = InputKeys.Sliders;
                        input.KeyIndex = Convert.ToInt32(p[1]);
                        break;
                case "ASlider":
                        input.InputKey = InputKeys.AccelerationSliders;
                        input.KeyIndex = Convert.ToInt32(p[1]);
                        break;
                case "FSlider":
                        input.InputKey = InputKeys.ForceSliders;
                        input.KeyIndex = Convert.ToInt32(p[1]);
                        break;
                case "VSlider":
                        input.InputKey = InputKeys.VelocitySliders;
                        input.KeyIndex = Convert.ToInt32(p[1]);
                        break;
                case "X":
                        input.InputKey = InputKeys.X;
                        input.Value = p[1];
                        break;
                case "Y":
                        input.InputKey = InputKeys.Y;
                        input.Value = p[1];
                        break;
                case "Z":
                        input.InputKey = InputKeys.Z;
                        input.Value = p[1];
                        break;
                case "AX":
                        input.InputKey = InputKeys.AccelerationX;
                        input.Value = p[1];
                        break;
                case "AY":
                        input.InputKey = InputKeys.AccelerationY;
                        input.Value = p[1];
                        break;
                case "AZ":
                        input.InputKey = InputKeys.AccelerationZ;
                        input.Value = p[1];
                        break;
                case "AAX":
                        input.InputKey = InputKeys.AngularAccelerationX;
                        input.Value = p[1];
                        break;
                case "AAY":
                        input.InputKey = InputKeys.AngularAccelerationY;
                        input.Value = p[1];
                        break;
                case "AAZ":
                        input.InputKey = InputKeys.AngularAccelerationZ;
                        input.Value = p[1];
                        break;
                case "FX":
                        input.InputKey = InputKeys.ForceX;
                        input.Value = p[1];
                        break;
                case "FY":
                        input.InputKey = InputKeys.ForceY;
                        input.Value = p[1];
                        break;
                case "FZ":
                        input.InputKey = InputKeys.ForceZ;
                        input.Value = p[1];
                        break;
                case "RX":
                        input.InputKey = InputKeys.RotationX;
                        input.Value = p[1];
                        break;
                case "RY":
                        input.InputKey = InputKeys.RotationY;
                        input.Value = p[1];
                        break;
                case "RZ":
                        input.InputKey = InputKeys.RotationZ;
                        input.Value = p[1];
                        break;
                case "TX":
                        input.InputKey = InputKeys.TorqueX;
                        input.Value = p[1];
                        break;
                case "TY":
                        input.InputKey = InputKeys.TorqueY;
                        input.Value = p[1];
                        break;
                case "TZ":
                        input.InputKey = InputKeys.TorqueZ;
                        input.Value = p[1];
                        break;
                case "VX":
                        input.InputKey = InputKeys.VelocityX;
                        input.Value = p[1];
                        break;
                case "VY":
                        input.InputKey = InputKeys.VelocityY;
                        input.Value = p[1];
                        break;
                case "VZ":
                        input.InputKey = InputKeys.VelocityZ;
                        input.Value = p[1];
                        break;
            }

            return input;
        }

        public static string GetStringFromInputControl(InputControl input)
        {
            string str = "";
            if (input.InputKey is null && input.KeyIndex is null && input.Value is null) return "";

            switch (input.InputKey)
            {
                case var @case when @case == InputKeys.Buttons:
                    {
                        return $"Button {input.KeyIndex}";
                    }

                case var case1 when case1 == InputKeys.PointOfViewControllers:
                    {
                        return $"Point {input.KeyIndex} {input.Value}";
                    }

                case var case2 when case2 == InputKeys.Sliders:
                    {
                        return $"Slider {input.KeyIndex}";
                    }

                case var case3 when case3 == InputKeys.AccelerationSliders:
                    {
                        return $"ASlider {input.KeyIndex}";
                    }

                case var case4 when case4 == InputKeys.ForceSliders:
                    {
                        return $"FSlider {input.KeyIndex}";
                    }

                case var case5 when case5 == InputKeys.VelocitySliders:
                    {
                        return $"VSlider {input.KeyIndex}";
                    }

                case var case6 when case6 == InputKeys.X:
                    {
                        return $"X {input.Value}";
                    }

                case var case7 when case7 == InputKeys.Y:
                    {
                        return $"Y {input.Value}";
                    }

                case var case8 when case8 == InputKeys.Z:
                    {
                        return $"Z {input.Value}";
                    }

                case var case9 when case9 == InputKeys.AccelerationX:
                    {
                        return $"AX {input.Value}";
                    }

                case var case10 when case10 == InputKeys.AccelerationY:
                    {
                        return $"AY {input.Value}";
                    }

                case var case11 when case11 == InputKeys.AccelerationZ:
                    {
                        return $"AZ {input.Value}";
                    }

                case var case12 when case12 == InputKeys.AngularAccelerationX:
                    {
                        return $"AAX {input.Value}";
                    }

                case var case13 when case13 == InputKeys.AngularAccelerationY:
                    {
                        return $"AAY {input.Value}";
                    }

                case var case14 when case14 == InputKeys.AngularAccelerationZ:
                    {
                        return $"AAZ {input.Value}";
                    }

                case var case15 when case15 == InputKeys.ForceX:
                    {
                        return $"FX {input.Value}";
                    }

                case var case16 when case16 == InputKeys.ForceY:
                    {
                        return $"FY {input.Value}";
                    }

                case var case17 when case17 == InputKeys.ForceZ:
                    {
                        return $"FZ {input.Value}";
                    }

                case var case18 when case18 == InputKeys.RotationX:
                    {
                        return $"RX {input.Value}";
                    }

                case var case19 when case19 == InputKeys.RotationY:
                    {
                        return $"RY {input.Value}";
                    }

                case var case20 when case20 == InputKeys.RotationZ:
                    {
                        return $"RZ {input.Value}";
                    }

                case var case21 when case21 == InputKeys.TorqueX:
                    {
                        return $"TX {input.Value}";
                    }

                case var case22 when case22 == InputKeys.TorqueY:
                    {
                        return $"TY {input.Value}";
                    }

                case var case23 when case23 == InputKeys.TorqueZ:
                    {
                        return $"TZ {input.Value}";
                    }

                case var case24 when case24 == InputKeys.VelocityX:
                    {
                        return $"VX {input.Value}";
                    }

                case var case25 when case25 == InputKeys.VelocityY:
                    {
                        return $"VY {input.Value}";
                    }

                case var case26 when case26 == InputKeys.VelocityZ:
                    {
                        return $"VZ {input.Value}";
                    }
            }

            return str;
        }

        private void TextBoxX_CamMoveLeft_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["CamMoveLeft"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_CamMoveRight_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["CamMoveRight"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_CamMoveFordward_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["CamMoveFordward"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_CamMoveBackward_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["CamMoveBackward"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_CamMoveUp_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["CamMoveUp"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_CamMoveDown_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["CamMoveDown"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_ObjMoveLeft_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["ObjMoveLeft"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_ObjMoveRight_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["ObjMoveRight"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_ObjMoveFordward_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["ObjMoveFordward"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_ObjMoveBackward_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["ObjMoveBackward"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_ObjMoveUp_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["ObjMoveUp"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_ObjMoveDown_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["ObjMoveDown"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_LastObj_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["LastObj"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_NextObj_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["NextObj"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_TopToGround_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["DropToGround"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_LastArea_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["LastArea"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void TextBoxX_NextArea_TextChanged(object sender, EventArgs e)
        {
            if (curProfile is object)
                curProfile["NextArea"] = GetInputControlFromString(((TextBoxX)sender).Text);
        }

        private void LoadProfile(string fileName)
        {
            Timer.Stop();
            curProfile = null;
            var p = !string.IsNullOrEmpty(fileName) && System.IO.File.Exists(fileName) ? LevelEditorInputProfile.Load(fileName) : new LevelEditorInputProfile();
            TextBoxX_CamMoveLeft.Text = GetStringFromInputControl(p["CamMoveLeft"]);
            TextBoxX_CamMoveRight.Text = GetStringFromInputControl(p["CamMoveRight"]);
            TextBoxX_CamMoveUp.Text = GetStringFromInputControl(p["CamMoveUp"]);
            TextBoxX_CamMoveDown.Text = GetStringFromInputControl(p["CamMoveDown"]);
            TextBoxX_CamMoveFordward.Text = GetStringFromInputControl(p["CamMoveFordward"]);
            TextBoxX_CamMoveBackward.Text = GetStringFromInputControl(p["CamMoveBackward"]);
            TextBoxX_ObjMoveLeft.Text = GetStringFromInputControl(p["ObjMoveLeft"]);
            TextBoxX_ObjMoveRight.Text = GetStringFromInputControl(p["ObjMoveRight"]);
            TextBoxX_ObjMoveUp.Text = GetStringFromInputControl(p["ObjMoveUp"]);
            TextBoxX_ObjMoveDown.Text = GetStringFromInputControl(p["ObjMoveDown"]);
            TextBoxX_ObjMoveFordward.Text = GetStringFromInputControl(p["ObjMoveFordward"]);
            TextBoxX_ObjMoveBackward.Text = GetStringFromInputControl(p["ObjMoveBackward"]);
            TextBoxX_LastObj.Text = GetStringFromInputControl(p["LastObj"]);
            TextBoxX_NextObj.Text = GetStringFromInputControl(p["NextObj"]);
            TextBoxX_DropToGround.Text = GetStringFromInputControl(p["DropToGround"]);
            TextBoxX_LastArea.Text = GetStringFromInputControl(p["LastArea"]);
            TextBoxX_NextArea.Text = GetStringFromInputControl(p["NextArea"]);
            try
            {
                var tguid = allDevices.FirstOrDefault(n => Publics.General.CompareTwoByteArrays(n.InstanceGuid.ToByteArray(), p.ControllerInstanceGuid.ToByteArray()));
                if (tguid is object)
                {
                    ComboBoxEx1.SelectedIndex = Array.IndexOf(allDevices, tguid);
                }
            }
            catch (Exception ex)
            {
            }

            curProfile = p;
        }

        private void LevelEditorInputManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop Timer
            Timer.Stop();

            // Save Profile
            curProfile.Save(Publics.General.MyDataPath + @"\Area Editor\Controller Profile.json");
        }

        private void ButtonX5_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "JSON Files (*.json)|*.json" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                curProfile.Save(sfd.FileName);
            }
        }

        private void ButtonX6_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "JSON Files (*.json)|*.json" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadProfile(ofd.FileName);
            }
        }
    }
}