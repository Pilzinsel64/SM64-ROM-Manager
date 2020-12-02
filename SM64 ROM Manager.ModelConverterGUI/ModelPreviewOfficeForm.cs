using System;
using global::System.Drawing;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using Microsoft.VisualBasic;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN;
using global::Pilz.S3DFileParser;
using global::Pilz.UI;
using global::SM64_ROM_Manager.SettingsManager;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public partial class ModelPreviewOfficeForm
    {
        public ModelPreviewOfficeForm(Object3D obj, float scaling)
        {
            ModelPreview = new Pilz.Drawing.Drawing3D.OpenGLFactory.PreviewN.ModelPreview()
            {
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                TopLevel = false,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                Scaling = 500
            };
            this.Shown += ModelPreviewOfficeForm_Shown;
            InitializeComponent();
            modelToRender = obj;

            /* TODO ERROR: Skipped IfDirectiveTrivia */
            ModelPreview.EnableCameraControlling = true;
            /* TODO ERROR: Skipped EndIfDirectiveTrivia */
            ModelPreview.Scaling = scaling;
            ModelPreview.Size = ModelPreview.ClientSize;
            ModelPreview.Show();
            Activated += ModelPreview.HandlesOnActivated;
            Deactivate += ModelPreview.HandlesOnDeactivate;
            // AddHandler ModelPreview.Paint, Sub(sender, e) e.Graphics.DrawString("Hello World", Font, New SolidBrush(Color.Green), New PointF(10.0F, 10.0F))
            // AddHandler KeyUp, AddressOf ModelPreview.HandlesOnKeyUp
            // AddHandler KeyDown, AddressOf ModelPreview.HandlesOnKeyDown

            var argcameraMatrix = ModelPreview.CameraMatrix;
            ModelPreview.Camera.SetCameraMode(CameraMode.FLY, ref argcameraMatrix);
            ModelPreview.Camera.NeedSelectedObject += Camera_NeedSelectedObject;

            // Create Model Infos Panel (Temporary)
            ModelPreview.GLControl.Paint += (sender, e) => { if (modelToRender is object) { e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.DrawString(GetModelInfoAsString(), new Font(FontFamily.GenericSerif, 10), new SolidBrush(Color.Green), new System.Drawing.Point(10, 10)); } };

            // Create Model Infos Panel
            // poModelInfo = New PaintingObject With {
            // .Type = PaintingObjectType.Text,
            // .TextFont = New Font(Control.DefaultFont.FontFamily, 10),
            // .TextColor = Color.Green,
            // .EnableFill = False,
            // .EnableOutline = False,
            // .Text = GetModelInfoAsString(),
            // .HorizontalTextAlignment = StringAlignment.Near,
            // .Location = PointF.Empty
            // }
            // pc = New PaintingControl With {
            // .BackColor = Color.Transparent,
            // .VisibleForMouseEvents = False,
            // .AutoSingleSelection = False,
            // .AutoAreaSelection = False,
            // .AutoMoveObjects = False,
            // .AutoMultiselection = False,
            // .AutoRemoveSelection = False
            // }

            // Set clear color
            ModelPreview.ClearColor = Settings.StyleManager.AlwaysKeepBlueColors ? Color.CornflowerBlue : base.BackColor;
            Controls.Add(ModelPreview);
        }

        private Object3D modelToRender;
        private Pilz.Drawing.Drawing3D.OpenGLFactory.PreviewN.ModelPreview _ModelPreview;

        private Pilz.Drawing.Drawing3D.OpenGLFactory.PreviewN.ModelPreview ModelPreview
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ModelPreview;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ModelPreview != null)
                {
                }

                _ModelPreview = value;
                if (_ModelPreview != null)
                {
                }
            }
        }

        private string OpenModel()
        {
            var ofd = new OpenFileDialog() { Filter = "OBJ File|*.obj" };
            ofd.ShowDialog();
            return ofd.FileName;
        }

        private void Camera_NeedSelectedObject(object sender, Camera.NeedSelectedObjectEventArgs e)
        {
            e.Points = null;
        }

        private void ModelPreviewOfficeForm_Shown(object sender, EventArgs e)
        {
            ModelPreview.HandlesOnShown(sender, e);
            ModelPreview.RenderModel(ModelPreview.AddModel(modelToRender));
            ModelPreview.UpdateView();
        }

        private string GetModelInfoAsString()
        {
            long matsCount = modelToRender.Materials.Count;
            long facesCount = 0;
            long vertsCount = 0;
            long vcCount = 0;
            long uvCount = 0;
            foreach (Mesh m in modelToRender.Meshes)
            {
                vertsCount += m.Vertices.Count;
                facesCount += m.Faces.Count;
                vcCount += m.VertexColors.Count;
                uvCount += m.UVs.Count;
            }

            return string.Format(@"Materials:{0}{1}
Faces:{0}{0}{2}
Vertices:{0}{0}{3}
Vertex Colors{0}{4}
UVs:{0}{0}{5}", Constants.vbTab, matsCount, facesCount, vertsCount, vcCount, uvCount);
        }
    }
}