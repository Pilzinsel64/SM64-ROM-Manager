using System;
using System.Collections.Generic;
using System.Linq;
using global::Newtonsoft.Json;

namespace SM64_ROM_Manager
{
    public partial class LevelEditorInputManager
    {
        [Serializable]
        public class LevelEditorInputProfile
        {

            // Public Property ProfileName As String
            public Dictionary<string, InputControl> Controls { get; private set; } = new Dictionary<string, InputControl>();

            private byte[] _ControllerInstanceGuid = Array.Empty<byte>();

            public Guid ControllerInstanceGuid
            {
                get
                {
                    if (_ControllerInstanceGuid.Count() == 0)
                        return default;
                    return new Guid(_ControllerInstanceGuid);
                }

                set
                {
                    _ControllerInstanceGuid = value.ToByteArray();
                }
            }

            public InputControl this[string name]
            {
                get
                {
                    if (!Controls.ContainsKey(name))
                    {
                        Controls.Add(name, new InputControl());
                    }

                    return Controls[name];
                }

                set
                {
                    if (!Controls.ContainsKey(name))
                    {
                        Controls.Add(name, value);
                    }
                    else
                    {
                        Controls[name] = value;
                    }
                }
            }

            public void ClearProfile()
            {
                Controls.Clear();
            }

            public void Save(string fileName)
            {
                System.IO.File.WriteAllText(fileName, JsonConvert.SerializeObject(this));
            }

            public static LevelEditorInputProfile Load(string fileName)
            {
                return JsonConvert.DeserializeObject<LevelEditorInputProfile>(System.IO.File.ReadAllText(fileName));
            }
        }

        [Serializable]
        public class InputControl
        {
            public InputKeys? InputKey { get; set; } = default;
            public int? KeyIndex { get; set; } = default;
            public object Value { get; set; } = null;
        }

        [Serializable]
        public enum ControllerTypes : byte
        {
            Keyboard,
            DirectInput
        }

        [Serializable]
        public enum InputKeys : byte
        {
            // Uses Index

            Buttons,                 // Button index       'Default: False
            AccelerationSliders,     // ASlider index      'Default: 0
            ForceSliders,            // FSlider index      'Default: 0
            PointOfViewControllers,  // Point index        'Default: -1
            Sliders,                 // Slider index       'Default: 0
            VelocitySliders,         // VSlider index      'Default: 0

            // Don't uses Index

            AccelerationX,           // AX                 'Default: 0
            AccelerationY,           // AY                 'Default: 0
            AccelerationZ,           // AZ                 'Default: 0
            AngularAccelerationX,    // AAX                'Default: 0
            AngularAccelerationY,    // AAY                'Default: 0
            AngularAccelerationZ,    // AAZ                'Default: 0
            ForceX,                  // FX                 'Default: 0
            ForceY,                  // FY                 'Default: 0
            ForceZ,                  // FZ                 'Default: 0
            RotationX,               // RX                 'Default: 0
            RotationY,               // RY                 'Default: 0
            RotationZ,               // RZ                 'Default: 0
            TorqueX,                 // TX                 'Default: 0
            TorqueY,                 // TY                 'Default: 0
            TorqueZ,                 // TZ                 'Default: 0
            VelocityX,               // VX                 'Default: 0
            VelocityY,               // VY                 'Default: 0
            VelocityZ,               // VZ                 'Default: 0
            X,                       // X                  'Default: 0
            Y,                       // Y                  'Default: 0
            Z                       // Z                  'Default: 0
        }
    }
}