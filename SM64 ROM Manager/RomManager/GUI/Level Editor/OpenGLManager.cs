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

        private GLControl _GLControl1;
        private GLControl GLControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GLControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GLControl1 != null)
                {
                    _GLControl1.Load -= glControl1_Load;
                    _GLControl1.Paint -= GlControl1_Paint;
                    _GLControl1.Resize -= glControl1_Resize;
                    _GLControl1.MouseWheel -= glControl1_Wheel;
                    _GLControl1.MouseDown -= glControl1_MouseDown;
                    _GLControl1.MouseUp -= glControl1_MouseUp;
                    _GLControl1.MouseLeave -= glControl1_MouseUp;
                    _GLControl1.MouseMove -= glControl1_MouseMove;
                    _GLControl1.KeyDown -= ModelPreview_KeyDown;
                }

                _GLControl1 = value;
                if (_GLControl1 != null)
                {
                    _GLControl1.Load += glControl1_Load;
                    _GLControl1.Paint += GlControl1_Paint;
                    _GLControl1.Resize += glControl1_Resize;
                    _GLControl1.MouseWheel += glControl1_Wheel;
                    _GLControl1.MouseDown += glControl1_MouseDown;
                    _GLControl1.MouseUp += glControl1_MouseUp;
                    _GLControl1.MouseLeave += glControl1_MouseUp;
                    _GLControl1.MouseMove += glControl1_MouseMove;
                    _GLControl1.KeyDown += ModelPreview_KeyDown;
                }
            }
        }

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
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RenderTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RenderTimer != null)
                {

                    /* TODO ERROR: Skipped IfDirectiveTrivia */
                    _RenderTimer.Elapsed -= CompositionTarget_Rendering;
                }

                _RenderTimer = value;
                if (_RenderTimer != null)
                {
                    _RenderTimer.Elapsed += CompositionTarget_Rendering;
                }
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
            GLControl1 = new GLControl();
            CameraPrivate = new Camera();
            RenderTimer = new System.Timers.Timer(20);
            Main = (Form_AreaEditor)targetForm;
            TargetControl = targetControl;
            Main.KeyUp += ModelPreview_KeyUp;
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

        public GLControl GLControl
        {
            get
            {
                return GLControl1;
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
            GLControl1.BackColor = Color.Black;
            GLControl1.Location = new System.Drawing.Point(0, 0);
            GLControl1.MinimumSize = new Size(600, 120);
            GLControl1.Name = "glControl1";
            GLControl1.Size = new Size(880, 538);
            GLControl1.TabIndex = 0;
            GLControl1.TabStop = false;
            GLControl1.VSync = true;
            GLControl1.Dock = DockStyle.Fill;
            TargetControl.Controls.Add(GLControl1);
            GLControl1.CreateControl();
            GLControl1.Enabled = false;
            UpdateProjMatrix(false);
            Camera.UpdateMatrix(ref camMtx);
        }

        public void Invalidate()
        {
            GLControl1.Invalidate();
        }

        public void Update()
        {
            GLControl1.Invalidate();
        }

        public void MakeCurrent()
        {
            GLControl1.MakeCurrent();
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

        private void glControl1_Load(object sender, EventArgs e)
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

        private void GlControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!Main.isDeactivated)
            {
                GL.ClearColor(Settings.StyleManager.AlwaysKeepBlueColors ? Color.CornflowerBlue : Main.BackColor);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
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
                GLControl1.SwapBuffers();
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
            DrawAllObjects(DrawBoundingBox: false);
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
            var bmp = new Bitmap(GLControl1.Width, GLControl1.Height);

            // Lock Bits & Get Bitmap Data
            var bmpdata = bmp.LockBits(new Rectangle(0, 0, GLControl1.Size.Width, GLControl1.Size.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Get Screenshot
            GL.ReadPixels(0, 0, GLControl1.Size.Width, GLControl1.Size.Height, PixelFormat.Bgr, PixelType.UnsignedByte, bmpdata.Scan0);

            // Unlook Bits
            bmp.UnlockBits(bmpdata);

            // Rotate at Y
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return bmp;
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            GLControl1.Context.Update(GLControl1.WindowInfo);
            GL.Viewport(0, 0, GLControl1.Width, GLControl1.Height);
            UpdateProjMatrix();
        }

        public void UpdateProjMatrix(bool update = true)
        {
            ProjMatrix = Matrix4.CreatePerspectiveFieldOfView(FOV, (float)(GLControl1.Width / (double)GLControl1.Height), 100.0F, 100000.0F);
            if (update) Update();
        }

        private void glControl1_Wheel(object sender, MouseEventArgs e)
        {
            Camera.ResetMouseStuff();
            Camera.UpdateCameraMatrixWithScrollWheel((int)(e.Delta * (Main.IsShiftPressed ? 3.5F : 1.5F)), ref camMtx);
            savedCamPos = Camera.Position;
            GLControl1.Invalidate();
        }

        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            savedCamPos = Camera.Position;
            if (e.Button == MouseButtons.Right)
            {
                SelectViaGLControl(e.X, e.Y);
                GLControl1.Invalidate();
            }
        }

        private void glControl1_MouseUp(object sender, EventArgs e)
        {
            Camera.ResetMouseStuff();
            isMouseDown = false;
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && e.Button == MouseButtons.Left)
            {
                if (Main.IsShiftPressed)
                {
                    Camera.UpdateCameraOffsetWithMouse(savedCamPos, e.X, e.Y, GLControl1.Width, GLControl1.Height, ref camMtx);
                }
                else
                {
                    Camera.UpdateCameraMatrixWithMouse(e.X, e.Y, ref camMtx);
                }

                GLControl1.Invalidate();
            }
        }

        private void ModelPreview_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Main.PressedKeys.Contains(e.KeyCode))
                Main.PressedKeys.Add(e.KeyCode);
        }

        private void ModelPreview_KeyUp(object sender, KeyEventArgs e)
        {
            Main.LastKeyLeaveTimer = DateTime.Now;
            if (Main.PressedKeys.Contains(e.KeyCode))
                Main.PressedKeys.Remove(e.KeyCode);
        }

        private void CompositionTarget_Rendering(object sender, System.Timers.ElapsedEventArgs e)
        {
            // If Not Main.isDeactivated Then
            // GLControl1.Invalidate()
            // End If
            // Application.DoEvents()
            MoveCameraViaWASDQE();
        }
        /* TODO ERROR: Skipped EndIfDirectiveTrivia */
        private void MoveCameraViaWASDQE()
        {
            int moveSpeed = Convert.ToInt32(Math.Round((Main.IsShiftPressed ? 60 : 30) * Camera.CamSpeedMultiplier, 0));
            bool allowCamMove = !(isMouseDown && Main.IsShiftPressed);
            foreach (Keys k in Main.PressedKeys.ToArray())
            {
                if (allowCamMove)
                {
                    // camera.resetMouseStuff()

                    switch (k)
                    {
                        case Keys.W:
                            {
                                // camera.Move(moveSpeed, moveSpeed, camMtx)
                                Camera.UpdateCameraMatrixWithScrollWheel(moveSpeed, ref camMtx);
                                savedCamPos = Camera.Position;
                                break;
                            }

                        case Keys.S:
                            {
                                // camera.Move(-moveSpeed, -moveSpeed, camMtx)
                                Camera.UpdateCameraMatrixWithScrollWheel(-moveSpeed, ref camMtx);
                                savedCamPos = Camera.Position;
                                break;
                            }

                        case Keys.A:
                            {
                                // camera.Move(-moveSpeed, 0, camMtx)
                                Camera.UpdateCameraOffsetDirectly(-moveSpeed, 0, ref camMtx);
                                break;
                            }

                        case Keys.D:
                            {
                                // camera.Move(moveSpeed, 0, camMtx)
                                Camera.UpdateCameraOffsetDirectly(moveSpeed, 0, ref camMtx);
                                break;
                            }

                        case Keys.E:
                            {
                                // camera.Move(0, -moveSpeed, camMtx)
                                Camera.UpdateCameraOffsetDirectly(0, -moveSpeed, ref camMtx);
                                break;
                            }

                        case Keys.Q:
                            {
                                // camera.Move(0, moveSpeed, camMtx)
                                Camera.UpdateCameraOffsetDirectly(0, moveSpeed, ref camMtx);
                                break;
                            }
                    }

                    // savedCamPos = camera.Position
                }
            }
        }

        public void SelectViaGLControl(int mx, int my)
        {
            int h = GLControl1.Height;
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
                        Main.SelectItemAtIndexInList(Main.ListViewEx_Objects, newIndex, true);
                    }
                    break;
            }
        }

        internal void DrawAllObjects(bool drawPicking = false, bool DrawBoundingBox = true)
        {
            int index = 0;

            foreach (Managed3DObject n in Main.ManagedObjects)
            {
                Renderer objModel = null;
                Color? col;
                var otherMdls = new List<Renderer>();

                if (Main.DrawObjectModels && Main.ObjectModels.ContainsKey(n.ModelID))
                    objModel = Main.ObjectModels[n.ModelID];
                else if (Main.DrawDirectionArrow)
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

                n.Draw(FaceDrawMode, objModel, otherMdls, col, drawPicking, DrawBoundingBox);
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
            GLControl1.Invoke(new Action(() => GLControl1.Invalidate()));
        }
    }

    public enum ModelDrawMod
    {
        VisualMap,
        Collision
    }
}