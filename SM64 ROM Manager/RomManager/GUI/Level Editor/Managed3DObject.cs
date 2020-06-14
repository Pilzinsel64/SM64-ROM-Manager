using global::System.ComponentModel;
using global::System.Drawing;
using System.Linq;
using global::System.Numerics;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.RenderingN;
using global::SM64_ROM_Manager.LevelEditor;
using global::SM64Lib.Data.System;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using System.Collections;
using System.Collections.Generic;

namespace SM64_ROM_Manager
{
    [DefaultProperty("AllActs")]
    public class Managed3DObject : ICameraPoint, IManagedLevelscriptCommand
    {
        [Browsable(false)]
        public LevelscriptCommand Command { get; private set; } = null;

        [Browsable(false)]
        private ObjectComboList myObjectCombos;

        [ReadOnly(true)]
        [Category("Address")]
        [DisplayName("Rom Address")]
        public int RomAddress
        {
            get
            {
                return Command.RomAddress;
            }
        }

        [ReadOnly(true)]
        [Category("Address")]
        [DisplayName("Bank Address")]
        public int BankAddress
        {
            get
            {
                return Command.BankAddress;
            }
        }

        [DisplayName("Object Combo")]
        [Category("Object Combo")]
        [Description("Indicates the combination of Model ID and Behavior ID.")]
        public string ObjectCombo
        {
            get
            {
                return myObjectCombos.GetObjectComboOfObject(this).Name;
            }

            set
            {
                var oc = myObjectCombos.FirstOrDefault(n => (n.Name ?? "") == (value ?? ""));
                if (oc is object)
                {
                    ModelID = oc.ModelID;
                    BehaviorID = oc.BehaviorAddress;
                }

                // Enable this object if it isn't enabled
                if (!AnyActs)
                    AllActs = true;
            }
        }

        [DisplayName("Act 1")]
        [Category("Acts")]
        [Description("If set to yes, the object will be visible if you select star 1.")]
        public bool Act1 { get; set; }
        [DisplayName("Act 2")]
        [Category("Acts")]
        [Description("If set to yes, the object will be visible if you select star 2.")]
        public bool Act2 { get; set; }
        [DisplayName("Act 3")]
        [Category("Acts")]
        [Description("If set to yes, the object will be visible if you select star 3.")]
        public bool Act3 { get; set; }
        [DisplayName("Act 4")]
        [Category("Acts")]
        [Description("If set to yes, the object will be visible if you select star 4.")]
        public bool Act4 { get; set; }
        [DisplayName("Act 5")]
        [Category("Acts")]
        [Description("If set to yes, the object will be visible if you select star 5.")]
        public bool Act5 { get; set; }
        [DisplayName("Act 6")]
        [Category("Acts")]
        [Description("If set to yes, the object will be visible if you select star 6.")]
        public bool Act6 { get; set; }

        [DisplayName("All Acts")]
        [Category("Acts")]
        [Description("If set to yes, the object will always be visible.")]
        public bool AllActs
        {
            get
            {
                return Act1 && Act2 && Act3 && Act4 && Act5 && !Act6;
            }

            set
            {
                Act1 = value;
                Act2 = value;
                Act3 = value;
                Act4 = value;
                Act5 = value;
                Act6 = false;
            }
        }

        [Browsable(false)]
        public bool AnyActs
        {
            get
            {
                return Act1 || Act2 || Act3 || Act4 || Act5 || Act6;
            }
        }

        [DisplayName("Model ID")]
        [Category("Model")]
        [Description("Indicates what model the object has.")]
        public byte ModelID { get; set; }
        [DisplayName("Behavior Address")]
        [Category("Behavior")]
        [Description("Indicates what behavior the object has.")]
        public uint BehaviorID { get; set; }
        [DisplayName("Behavior Param 1")]
        [Category("Behavior")]
        [Description("The first parameter for the behavior.")]
        public byte BParam1 { get; set; }
        [DisplayName("Behavior Param 2")]
        [Category("Behavior")]
        [Description("The second parameter for the behavior.")]
        public byte BParam2 { get; set; }
        [DisplayName("Behavior Param 3")]
        [Category("Behavior")]
        [Description("The third parameter for the nehavior.")]
        public byte BParam3 { get; set; }
        [DisplayName("Behavior Param 4")]
        [Category("Behavior")]
        [Description("The fourth parameter for the behavior.")]
        public byte BParam4 { get; set; }
        [Browsable(false)]
        public bool IsSelected { get; set; } = false;

        // <DisplayName("Position")>
        // <Category("Position & Rotation")>
        // <Description("The position of the Object.")>
        // <TypeConverter(GetType(Vector3Converter))>
        [Browsable(false)]
        public Vector3 Position { get; set; }

        // <DisplayName("Rotation")>
        // <Category("Position & Rotation")>
        // <Description("The rotation of the Object.")>
        // <TypeConverter(GetType(Vector3Converter))>
        [Browsable(false)]
        public Vector3 Rotation { get; set; }

        [DisplayName("X Position")]
        [Category("Position")]
        [Description("The position on the X-axis.")]
        public short PositionX
        {
            get
            {
                return Conversions.ToShort(Position.X);
            }

            set
            {
                Position = new Vector3(value, Position.Y, Position.Z);
            }
        }

        [DisplayName("Y Position")]
        [Category("Position")]
        [Description("The position on the Y-axis.")]
        public short PositionY
        {
            get
            {
                return Conversions.ToShort(Position.Y);
            }

            set
            {
                Position = new Vector3(Position.X, value, Position.Z);
            }
        }

        [DisplayName("Z Position")]
        [Category("Position")]
        [Description("The position on the Z-axis.")]
        public short PositionZ
        {
            get
            {
                return Conversions.ToShort(Position.Z);
            }

            set
            {
                Position = new Vector3(Position.X, Position.Y, value);
            }
        }

        [DisplayName("X Rotation")]
        [Category("Rotation")]
        [Description("The rotation on the X-axis.")]
        public short RotationX
        {
            get
            {
                return Conversions.ToShort(Rotation.X);
            }

            set
            {
                Rotation = new Vector3(value, Rotation.Y, Rotation.Z);
            }
        }

        [DisplayName("Y Rotation")]
        [Category("Rotation")]
        [Description("The rotation on the Y-axis.")]
        public short RotationY
        {
            get
            {
                return Conversions.ToShort(Rotation.Y);
            }

            set
            {
                Rotation = new Vector3(Rotation.X, value, Rotation.Z);
            }
        }

        [DisplayName("Z Rotation")]
        [Category("Rotation")]
        [Description("The rotation on the Z-axis.")]
        public short RotationZ
        {
            get
            {
                return Conversions.ToShort(Rotation.Z);
            }

            set
            {
                Rotation = new Vector3(Rotation.X, Rotation.Y, value);
            }
        }

        public Managed3DObject(LevelscriptCommand cmd, ObjectComboList comboList)
        {
            Command = cmd;
            myObjectCombos = comboList;
            LoadProperties();
        }

        public void LoadProperties()
        {
            // Acts
            var acts = Bits.ByteToBoolArray(clNormal3DObject.GetActs(Command));
            Act1 = acts[7];
            Act2 = acts[6];
            Act3 = acts[5];
            Act4 = acts[4];
            Act5 = acts[3];
            Act6 = acts[2];

            // Position
            Position = clNormal3DObject.GetPosition(Command);

            // Rotation
            Rotation = clNormal3DObject.GetRotation(Command);

            // Model-ID
            ModelID = clNormal3DObject.GetModelID(Command);

            // Behavior-ID
            BehaviorID = clNormal3DObject.GetSegBehaviorAddr(Command);

            // B. Params
            var bParams = clNormal3DObject.GetParams(Command);
            BParam1 = bParams.BParam1;
            BParam2 = bParams.BParam2;
            BParam3 = bParams.BParam3;
            BParam4 = bParams.BParam4;
        }

        public void SaveProperties()
        {
            SaveProperties(Command);
        }

        public void SaveProperties(LevelscriptCommand Command)
        {
            // Acts
            var acts = new[] { false, false, false, false, false, false, false, false };
            acts[7] = Act1;
            acts[6] = Act2;
            acts[5] = Act3;
            acts[4] = Act4;
            acts[3] = Act5;
            acts[2] = Act6;
            clNormal3DObject.SetActs(Command, Bits.ArrayToByte(acts));

            // Position
            clNormal3DObject.SetPosition(Command, Position);

            // Rotation
            clNormal3DObject.SetRotation(Command, Rotation);

            // Model-ID
            clNormal3DObject.SetModelID(Command, ModelID);

            // Behavior-ID
            clNormal3DObject.SetSegBehaviorAddr(Command, BehaviorID);

            // B. Params
            var bParams = new ObjBParams();
            bParams.BParam1 = BParam1;
            bParams.BParam2 = BParam2;
            bParams.BParam3 = BParam3;
            bParams.BParam4 = BParam4;
            clNormal3DObject.SetParams(Command, bParams);
        }

        public void Draw(RenderMode mode, Renderer ModelRenderer = null, IEnumerable<Renderer> otherModelRenderer = null, Color? col = default, bool DrawSolid = false, bool DrawBoundingBox = true)
        {
            var scale = Vector3.One;
            if (IsSelected)
                scale = new Vector3(1.001F, 1.001F, 1.001F);
            var rotation = new Quaternion() { X = Rotation.X, Y = Rotation.Y, Z = Rotation.Z, W = 1.0F };
            var position = new Vector3(Position.X, Position.Y, Position.Z);
            var boundOff = new Vector3(25.0F, 25.0F, 25.0F);
            Color colorToUse = (Color)(col is object ? col : IsSelected ? Color.Yellow : Color.Red);

            void drawMdl(Renderer rndr) =>
                rndr.DrawModel(mode, new OpenTK.Vector3(Position.X, Position.Y, Position.Z), new OpenTK.Quaternion(Rotation.X, Rotation.Y, Rotation.Z, 1.0F), OpenTK.Vector3.One);

            if (ModelRenderer is object)
                drawMdl(ModelRenderer);

            foreach (var rdnr in otherModelRenderer)
                drawMdl(rdnr);

            if (DrawBoundingBox)
            {
                Vector3 upper, lower;

                if (ModelRenderer is object && ModelID != 0)
                {
                    var md = ModelRenderer.Model.GetBoundaries();
                    upper = md.Upper + boundOff;
                    lower = md.Lower - boundOff;
                }
                else
                {
                    upper = new Vector3(150.0F, 150.0F, 150.0F);
                    lower = new Vector3(-150.0F, -150.0F, -150.0F);
                }

                if (DrawSolid)
                    BoundingBox.DrawSolid(scale, rotation, position, colorToUse, upper, lower);
                else
                    BoundingBox.Draw(scale, rotation, position, colorToUse, upper, lower);
            }
        }
    }
}