using System;
using System.Drawing;
using Color = System.Drawing.Color;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using global::OpenTK;
using global::OpenTK.Graphics.OpenGL;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.RenderingN;
using global::Pilz.S3DFileParser;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.Levels;
using Image = System.Drawing.Image;
using Bitmap = System.Drawing.Bitmap;
using System.Collections.Generic;
using System.Linq;
using OpenTK.Mathematics;
using System.Windows.Forms.Integration;
using OpenTK.Wpf;
using Keyboard = OpenTK3.Input.Keyboard;
using Key = OpenTK3.Input.Key;
using System.Windows.Input;

namespace SM64_ROM_Manager.LevelEditor
{
    public class OpenGLManager
    {
        private Form_AreaEditor _Main;
        private Form_AreaEditor Main
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Main;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Main != null)
                {
                }

                _Main = value;
                if (_Main != null)
                {
                }
            }
        }

        private Control _TargetControl;
        private Control TargetControl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TargetControl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TargetControl != null)
                {
                }

                _TargetControl = value;
                if (_TargetControl != null)
                {
                }
            }
        }

        private GLWpfControl GLControl1;
        private ElementHost GLControlHost;

        private Camera _CameraPrivate;
        private Camera CameraPrivate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CameraPrivate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CameraPrivate != null)
                {
                    _CameraPrivate.PerspectiveChanged -= CameraPrivate_PerspectiveChanged;
                }

                _CameraPrivate = value;
                if (_CameraPrivate != null)
                {
                    _CameraPrivate.PerspectiveChanged += CameraPrivate_PerspectiveChanged;
                }
            }
        }

        private System.Timers.Timer _RenderTimer;
        private System.Timers.Timer RenderTimer
        {
            get
            {
                return _RenderTimer;
            }
            set
            {
                if (_RenderTimer != null)
                    _RenderTimer.Elapsed -= CompositionTarget_Rendering;
                _RenderTimer = value;
                if (_RenderTimer != null)
                    _RenderTimer.Elapsed += CompositionTarget_Rendering;
            }
        }
        
        internal Matrix4 ProjMatrix = default;
        internal float FOV { get; set; } = 1.048F;
        internal Matrix4 camMtx = Matrix4.Identity;
        internal Vector3 savedCamPos = new Vector3();
        internal bool isMouseDown = false;
        internal float curScale = 1.0F;

        private Renderer rndrDirectionArrow = null;

        public OpenGLManager(Form targetForm) : this(targetForm, targetForm)
        {
        }

        public OpenGLManager(Form targetForm, Control targetControl)
        {
            GLControl1 = new GLWpfControl();
            CameraPrivate = new Camera();
            RenderTimer = new System.Timers.Timer(20);
            Main = (Form_AreaEditor)targetForm;
            TargetControl = targetControl;
            Main.KeyUp += ModelPreview_KeyUp;
            Main.KeyDown += ModelPreview_KeyDown;
            InitializeGLControl();

            RenderTimer.SynchronizingObject = null;
            RenderTimer.Start();
        }

        private MapManagement Maps
        {
            get
            {
                return Main.maps;
            }
        }

        public Camera Camera
        {
            get
            {
                return CameraPrivate;
            }
        }

        public ModelDrawMod CurrentModelDrawMod
        {
            get
            {
                switch (true)
                {
                    case object _ when Main.ButtonItem_ViewColMap.Checked:
                        {
                            return ModelDrawMod.Collision;
                        }

                    case object _ when Main.ButtonItem_ViewVisualMap.Checked:
                        {
                            return ModelDrawMod.VisualMap;
                        }

                    default:
                        {
                            return default;
                        }
                }
            }
        }

        public ElementHost GLControl
        {
            get
            {
                return GLControlHost;
            }
        }

        internal RenderMode FaceDrawMode
        {
            get
            {
                var val = RenderMode.None;
                if (Main.ButtonItem_DrawOutline.Checked)
                    val = val | RenderMode.Outline;
                if (Main.ButtonItem_DrawFill.Checked)
                    val = val | RenderMode.Fill;
                return val;
            }

            set
            {
                Main.ButtonItem_DrawOutline.Checked = (value & RenderMode.Outline) == RenderMode.Outline;
                Main.ButtonItem_DrawFill.Checked = (value & RenderMode.Fill) == RenderMode.Fill;
            }
        }

        private void InitializeGLControl()
        {
            GLControl1 = new GLWpfControl();
            
            GLControlHost = new ElementHost();
            GLControlHost.Location = new System.Drawing.Point(0, 0);
            GLControlHost.MinimumSize = new Size(600, 120);
            GLControlHost.Name = "glControl1";
            GLControlHost.Size = new Size(880, 538);
            GLControlHost.TabIndex = 0;
            GLControlHost.TabStop = false;
            //GLControl1.VSync = true;
            GLControlHost.Dock = DockStyle.Fill;
            GLControlHost.Enabled = false;

            GLControl1.Ready += glControl1_Load;
            GLControl1.Render += GlControl1_Paint;

            GLControlHost.Resize += glControl1_Resize;
            GLControl1.MouseWheel += glControl1_Wheel;
            GLControl1.MouseDown += glControl1_MouseDown;
            GLControl1.MouseUp += glControl1_MouseUp;
            GLControl1.MouseLeave += glControl1_MouseUp;
            GLControl1.MouseMove += glControl1_MouseMove;

            var controlSettings = new GLWpfControlSettings()
            {
                //MajorVersion = 4,
                //MinorVersion = 3,
                RenderContinuously = false,
                GraphicsProfile = OpenTK.Windowing.Common.ContextProfile.Compatability
            };
            GLControl1.Start(controlSettings);

            GLControlHost.Child = GLControl1;
            TargetControl.Controls.Add(GLControlHost);

            UpdateProjMatrix(false);
            Camera.UpdateMatrix(ref camMtx);
        }

        public void Invalidate()
        {
            GLControl1.InvalidateVisual();
            GLControlHost.Invalidate();
        }

        public void Update()
        {
            //GLControl1.InvalidateVisual();
        }

        public void MakeCurrent()
        {
            //GLControl1.MakeCurrent();
        }

        public void ChangeViewMode()
        {
            if (GLControl1 is object)
            {
                UpdateProjMatrix();
            }
        }

        public void UpdateOrbitCamera()
        {
            if (Camera.IsOrbitCamera())
            {
                Camera.UpdateOrbitCamera(ref camMtx);
            }
        }

        public void SetCameraMode(CameraMode mode, LookDirection look)
        {
            Camera.SetCameraMode(mode, ref camMtx);
            Camera.SetCameraMode_LookDirection(look, ref camMtx);
            // camera.updateMatrix(camMtx)
            Main.objectControlling.WasInOrbitMode = false;
            Invalidate();
        }

        public void SetCameraMode(CameraMode mode)
        {
            Camera.SetCameraMode(mode, ref camMtx);
            Main.objectControlling.WasInOrbitMode = false;
            Invalidate();
        }

        private void glControl1_Load(/*object sender, EventArgs e*/)
        {
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.AlphaTest);
            GL.AlphaFunc(AlphaFunction.Gequal, 0.5F);
            GL.Enable(EnableCap.CullFace);
        }

        private void GlControl1_Paint(TimeSpan span)
        {
            if (!Main.isDeactivated)
            {
                GL.ClearColor(Settings.StyleManager.AlwaysKeepBlueColors ? Color.CornflowerBlue : Main.BackColor);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.LoadIdentity();
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadMatrix(ref ProjMatrix);
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadMatrix(ref camMtx);

                // DrawSpecialBoxes()

                var switchExpr = CurrentModelDrawMod;
                switch (switchExpr)
                {
                    case ModelDrawMod.Collision:
                        if (Maps.rndrCollisionMap is object)
                            Maps.rndrCollisionMap?.DrawModel(FaceDrawMode);
                        break;

                    case ModelDrawMod.VisualMap:
                        if (Maps.rndrVisualMap is object)
                            Maps.rndrVisualMap?.DrawModel(FaceDrawMode);
                        break;
                }

                DrawAllObjects();

                GL.End();
                GL.Finish();
                //GLControl1.SwapBuffers();
            }
        }

        public void SaveScreenshot(string fileName)
        {
            GL.ClearColor(Color.CornflowerBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref ProjMatrix);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref camMtx);
            DrawAllObjects(drawBoundingBox: false, drawArrow: false);
            if (Maps.rndrVisualMap is object)
            {
                Maps.rndrVisualMap?.DrawModel(RenderMode.Fill);
            }

            var img = TakeScreenshotOfGL();
            img.Save(fileName);
        }

        internal Image TakeScreenshotOfGL()
        {
            // Create new Bitmap
            var bmp = new Bitmap(GLControlHost.Width, GLControlHost.Height);

            // Lock Bits & Get Bitmap Data
            var bmpdata = bmp.LockBits(new Rectangle(0, 0, GLControlHost.Size.Width, GLControlHost.Size.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Get Screenshot
            GL.ReadPixels(0, 0, GLControlHost.Size.Width, GLControlHost.Size.Height, PixelFormat.Bgr, PixelType.UnsignedByte, bmpdata.Scan0);

            // Unlook Bits
            bmp.UnlockBits(bmpdata);

            // Rotate at Y
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return bmp;
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            //GLControl1.Context.Update(GLControl1.WindowInfo);
            GL.Viewport(0, 0, GLControlHost.Width, GLControlHost.Height);
            UpdateProjMatrix();
        }

        public void UpdateProjMatrix(bool update = true)
        {
            ProjMatrix = Matrix4.CreatePerspectiveFieldOfView(FOV, (float)(GLControlHost.Width / (double)GLControlHost.Height), 100.0F, 100000.0F);
            if (update) Invalidate();
        }

        private void glControl1_Wheel(object sender, MouseWheelEventArgs e)
        {
            Camera.ResetMouseStuff();
            Camera.UpdateCameraMatrixWithScrollWheel((int)(e.Delta * (Main.IsShiftPressed ? 3.5F : 1.5F)), ref camMtx);
            savedCamPos = Camera.Position;
            Invalidate();
        }

        private void glControl1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = true;
            savedCamPos = Camera.Position;
            if (e.RightButton == MouseButtonState.Pressed)
            {
                var pos = e.GetPosition(GLControl1);
                SelectViaGLControl((int)pos.X, (int)pos.Y);
                Invalidate();
            }
        }

        private void glControl1_MouseUp(object sender, EventArgs e)
        {
            Camera.ResetMouseStuff();
            isMouseDown = false;
        }

        private void glControl1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (isMouseDown && e.LeftButton == MouseButtonState.Pressed)
            {
                var pos = e.GetPosition(GLControl1);
                if (Main.IsShiftPressed)
                {
                    Camera.UpdateCameraOffsetWithMouse(savedCamPos, (int)pos.X, (int)pos.Y, GLControlHost.Width, GLControlHost.Height, ref camMtx);
                }
                else
                {
                    Camera.UpdateCameraMatrixWithMouse((int)pos.X, (int)pos.Y, ref camMtx);
                }

                Invalidate();
            }
        }

        private void ModelPreview_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

        private void ModelPreview_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Main.LastKeyLeaveTimer = DateTime.Now;
        }

        private void CompositionTarget_Rendering(object sender, System.Timers.ElapsedEventArgs e)
        {
            Main.objectControlling.SlideMoveObjects();
            Main.objectControlling.SlideRotateObjects();
            MoveCameraViaWASDQE();
        }

        private bool MoveCameraViaWASDQE()
        {
            int moveSpeed = Convert.ToInt32(Math.Round((Main.IsShiftPressed ? 60 : 30) * Camera.CamSpeedMultiplier, 0));
            bool allowCamMove = !(isMouseDown && Main.IsShiftPressed);
            bool movedCam = false;

            if (allowCamMove)
            {
                var state = Keyboard.GetState();
                switch (true)
                {
                    case object _ when state.IsKeyDown(Key.W):
                        Camera.UpdateCameraMatrixWithScrollWheel(moveSpeed, ref camMtx);
                        savedCamPos = Camera.Position;
                        movedCam = true;
                        break;
                    case object _ when state.IsKeyDown(Key.S):
                        Camera.UpdateCameraMatrixWithScrollWheel(-moveSpeed, ref camMtx);
                        savedCamPos = Camera.Position;
                        movedCam = true;
                        break;
                    case object _ when state.IsKeyDown(Key.A):
                        Camera.UpdateCameraOffsetDirectly(moveSpeed, 0, ref camMtx);
                        movedCam = true;
                        break;
                    case object _ when state.IsKeyDown(Key.D):
                        Camera.UpdateCameraOffsetDirectly(-moveSpeed, 0, ref camMtx);
                        movedCam = true;
                        break;
                    case object _ when state.IsKeyDown(Key.E):
                        Camera.UpdateCameraOffsetDirectly(0, moveSpeed, ref camMtx);
                        movedCam = true;
                        break;
                    case object _ when state.IsKeyDown(Key.Q):
                        Camera.UpdateCameraOffsetDirectly(0, -moveSpeed, ref camMtx);
                        movedCam = true;
                        break;
                }
            }

            return movedCam;
        }

        public void SelectViaGLControl(int mx, int my)
        {
            int h = GLControlHost.Height;
            GL.ClearColor(1.0F, 1.0F, 1.0F, 1.0F);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref ProjMatrix);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref camMtx);

            // Draw everything
            DrawAllObjects(true);
            if (CurrentModelDrawMod == ModelDrawMod.Collision)
            {
                // Maps.rndrCollisionMap?.DrawFacePicking()
            }

            var pixels = new byte[4];
            GL.ReadPixels(mx, h - my, 1, 1, PixelFormat.Rgba, PixelType.UnsignedByte, pixels);
            pixels = new byte[] { pixels[3], pixels[0], pixels[1], pixels[2] };
            int pixel = Conversions.ToInteger(pixels[0]) << 24 | Conversions.ToInteger(pixels[1]) << 16 | Conversions.ToInteger(pixels[2]) << 8 | pixels[3];
            int pixid = pixel >> 28;
            int pixval = pixel & 0xFFFFFFF;
            switch (pixid) // pixels(0) >> 4
            {
                case 1: // Object
                    int newIndex = pixval; // (CInt(pixels(2)) << 8) Or pixels(3)
                    if (Main.IsStrgPressed)
                    {
                        Main.ToogleObjectSelection(Main.ManagedObjects[newIndex]);
                    }
                    else
                    {
                        Main.SelectItemAtIndexInList(newIndex, true);
                    }
                    break;
            }
        }

        internal void DrawAllObjects(bool drawPicking = false, bool drawBoundingBox = true, bool drawArrow = true)
        {
            int index = 0;

            foreach (Managed3DObject n in Main.ManagedObjects)
            {
                Renderer objModel = null;
                Color? col;
                var otherMdls = new List<Renderer>();

                if (Main.DrawObjectModels && Main.ObjectModels.ContainsKey(n.ModelID))
                    objModel = Main.ObjectModels[n.ModelID];
                else if (Main.DrawDirectionArrow && drawArrow)
                    otherMdls.Add(Main.ObjectModels[0]);

                if (objModel is object && !objModel.HasRendered)
                    objModel.RenderModel();

                foreach (var mdl in otherMdls)
                {
                    if (!mdl.HasRendered)
                        mdl.RenderModel();
                }

                if (drawPicking)
                    col = Color.FromArgb(0x10000000 | index);
                else
                    col = default;

                n.Draw(FaceDrawMode, objModel, otherMdls, col, drawPicking, drawBoundingBox);
                index += 1;
            }
        }

        internal void DrawSpecialBoxes()
        {
            foreach (ManagedSpecialBox sp in Main.ManagedSpecialBoxes)
            {
                Renderer rndr = null;
                if (Main.SpecialBoxRenderers.ContainsKey(sp))
                {
                    rndr = Main.SpecialBoxRenderers[sp];
                }
                else
                {
                    var spm = new Object3D();
                    GetModelFromSpecialBox(sp.SpecialBox, spm);
                    rndr = new Renderer(spm);
                    Main.SpecialBoxRenderers.Add(sp, rndr);
                    rndr.RenderModel();
                }

                rndr?.DrawModel(FaceDrawMode);
            }
        }

        private void GetModelFromSpecialBox(SpecialBox sp, Object3D obj)
        {
            var mat = new Material() { Color = Color.Blue, Opacity = 0.25F };
            var m = new Mesh();
            var uv = new UV();
            var p1 = new Pilz.S3DFileParser.Point() { Vertex = new Vertex() { X = sp.X1, Z = sp.Z1, Y = sp.Y } };
            var p2 = new Pilz.S3DFileParser.Point() { Vertex = new Vertex() { X = sp.X1, Z = sp.Z2, Y = sp.Y } };
            var p3 = new Pilz.S3DFileParser.Point() { Vertex = new Vertex() { X = sp.X2, Z = sp.Z2, Y = sp.Y } };
            var p4 = new Pilz.S3DFileParser.Point() { Vertex = new Vertex() { X = sp.X2, Z = sp.Z1, Y = sp.Y } };
            var f1 = new Face() { Material = mat };
            var f2 = new Face() { Material = mat };
            f1.Points.AddRange(new[] { p1, p2, p3 });
            f2.Points.AddRange(new[] { p1, p3, p4 });
            obj.Materials.Add(string.Empty, mat);
            m.Vertices.AddRange(new[] { p1.Vertex, p2.Vertex, p3.Vertex, p4.Vertex });
            m.UVs.Add(uv);
            m.Faces.AddRange(new[] { f1, f2 });
            obj.Meshes.Add(m);
        }

        private void CameraPrivate_PerspectiveChanged(object sender, EventArgs e)
        {
            GLControlHost.Invoke(new Action(() => Invalidate()));
        }

        internal void StopTimer()
        {
            RenderTimer.Stop();
        }
    }

    public enum ModelDrawMod
    {
        VisualMap,
        Collision
    }
}