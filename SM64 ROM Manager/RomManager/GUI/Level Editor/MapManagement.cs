using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using global::System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.RenderingN;
using global::Pilz.S3DFileParser;
using global::SimpleHistory;
using global::SM64_ROM_Manager.ModelConverterGUI;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.Levels;

namespace SM64_ROM_Manager.LevelEditor
{
    public class MapManagement
    {
        private Form_AreaEditor _Main;

        private Form_AreaEditor Main
        {
            get
            {
                return _Main;
            }
            set
            {
                _Main = value;
            }
        }

        private int hashVisualMap = 0;
        private int hashCollisionMap = 0;
        internal Object3D cVisualMap = null;
        internal Object3D cCollisionMap = null;
        internal Renderer rndrVisualMap = null;
        internal Renderer rndrCollisionMap = null;

        public MapManagement(Form_AreaEditor main)
        {
            Main = main;
            main.ButtonItem_ExportCollision.Click += ButtonItem_ExportCollision_Click;
            main.ButtonItem86.Click += ButtonItem_ExportCollision_Click;
            main.ButtonItem_ExportVisualMap.Click += ButtonItem_ExportVisualMap_Click;
        }

        private OpenGLManager Ogl
        {
            get
            {
                return Main.ogl;
            }
        }

        private MapManagement Maps
        {
            get
            {
                return Main.maps;
            }
        }

        private ObjectControlling ObjectControlling
        {
            get
            {
                return Main.objectControlling;
            }
        }

        public bool IsCollisionMapNothing
        {
            get
            {
                return cCollisionMap is null;
            }
        }

        internal void ReleaseBuffers()
        {
            foreach (KeyValuePair<byte, Renderer> kvp in Main.ObjectModels)
                kvp.Value.ReleaseBuffers();
            rndrVisualMap?.ReleaseBuffers();
            rndrCollisionMap?.ReleaseBuffers();
        }

        internal void CheckAndLoadNew()
        {
            Ogl.MakeCurrent();
            bool loadAreaIDs = false;
            if (Main.CArea is null)
            {
                loadAreaIDs = true;
            }

            if (Main.CLevel.Areas.Count != Main.ComboBoxItem_Area.Items.Count)
            {
                loadAreaIDs = true;
            }
            else
            {
                foreach (ComboItem ci in Main.ComboBoxItem_Area.Items)
                {
                    if (!Main.CLevel.Areas.Contains((LevelArea)ci.Tag))
                    {
                        loadAreaIDs = true;
                    }
                }
            }

            if (loadAreaIDs)
            {
                Main.LoadAreaIDs();
            }
            else
            {
                bool loadAreaMdl = false;
                if (hashCollisionMap != Main.CArea.AreaModel.Collision.GetHashCode())
                {
                    hashCollisionMap = 0;
                    cCollisionMap = null;
                    if (Ogl.CurrentModelDrawMod == ModelDrawMod.Collision)
                    {
                        loadAreaMdl = true;
                    }
                }

                if (hashVisualMap != Main.CArea.AreaModel.Fast3DBuffer.GetBuffer().GetHashCode())
                {
                    hashVisualMap = 0;
                    cVisualMap = null;
                    if (Ogl.CurrentModelDrawMod == ModelDrawMod.VisualMap)
                    {
                        loadAreaMdl = true;
                    }
                }

                if (loadAreaMdl)
                {
                    Maps.LoadAreaModel();
                }
            }
        }

        internal void LoadAreaModel()
        {
            LoadAreaModel(Ogl.CurrentModelDrawMod);
        }

        internal void LoadAreaModel(ModelDrawMod modelMode)
        {
            if (Main.CArea is object)
            {
                Main.ProgressControl(true);
                switch (modelMode)
                {
                    case ModelDrawMod.Collision:
                        {
                            if (cCollisionMap is null)
                            {
                                LoadAreaCollisionAsObject3D();
                                rndrCollisionMap?.ReleaseBuffers();
                                rndrCollisionMap = null;
                            }

                            if (rndrCollisionMap is null)
                            {
                                rndrCollisionMap = new Renderer(cCollisionMap);
                                rndrCollisionMap.RenderModel();
                            }

                            break;
                        }

                    case ModelDrawMod.VisualMap:
                        {
                            if (cVisualMap is null)
                            {
                                LoadAreaVisualMapAsObject3D();
                                rndrVisualMap?.ReleaseBuffers();
                                rndrVisualMap = null;
                            }

                            if (rndrVisualMap is null)
                            {
                                rndrVisualMap = new Renderer(cVisualMap);
                                rndrVisualMap.RenderModel();
                            }

                            break;
                        }
                }

                Ogl.Invalidate();
                Main.ProgressControl(false);

                // Console.WriteLine("Done!")
            }
        }

        internal void LoadAreaCollisionAsObject3D()
        {
            hashCollisionMap = Main.CArea.AreaModel.Collision.GetHashCode();
            cCollisionMap = (Object3D)General.AwaitOnUI(Main.CArea.AreaModel.Collision.ToObject3DAsync());
        }

        internal void LoadAreaVisualMapAsObject3D()
        {
            hashVisualMap = Main.CArea.AreaModel.Fast3DBuffer.GetBuffer().GetHashCode();
            cVisualMap = (Object3D)General.AwaitOnUI(General.LoadAreaVisualMapAsObject3DAsync(Main.Rommgr, Main.CArea));
        }

        internal void ButtonItem_ExportCollision_Click(object sender, EventArgs e)
        {
            if (Main.CArea.AreaModel.Collision is object)
            {
                LoadAreaModel(ModelDrawMod.Collision);
                Publics.Publics.ExportModel(rndrCollisionMap.Model, Settings.FileParser.FileExporterModule);
            }
        }

        internal void ButtonItem_ExportVisualMap_Click(object sender, EventArgs e)
        {
            if (Main.CArea.AreaModel.Fast3DBuffer is object)
            {
                LoadAreaModel(ModelDrawMod.VisualMap);
                Publics.Publics.ExportModel(rndrVisualMap.Model, Settings.FileParser.FileExporterModule);
            }
        }

        internal void UpdateTexturesOfCurrentModel(Dictionary<Material, Image> snapshot)
        {
            if (cVisualMap is object && Maps.rndrVisualMap is object)
            {
                foreach (var kvp in snapshot)
                {
                    if (kvp.Value != kvp.Key.Image)
                    {
                        rndrVisualMap.UpdateTexture(kvp.Value, kvp.Key.Image);
                    }
                }

                Ogl.Invalidate();
            }
        }

        internal Dictionary<Material, Image> TakeSnapshotOfCurrentModelTextures()
        {
            var dic = new Dictionary<Material, Image>();
            if (cVisualMap is object)
            {
                foreach (var kvp in cVisualMap.Materials)
                {
                    var img = kvp.Value.Image;
                    if (img is object)
                    {
                        dic.Add(kvp.Value, img);
                    }
                }
            }

            return dic;
        }

        public void ImportAreaModel(bool convertModel, bool convertCollision, string inputKey)
        {
            var res = PublicFunctions.GetModelViaModelConverter(loadVisualMapAsDefault: convertModel, loadCollisionAsDefault: convertCollision, inputsKey: inputKey);
            if (res is object)
            {
                Ogl.MakeCurrent();
                Main.SuspendLayout();
                {
                    var withBlock = Main.CArea;
                    HistoryPoint hp = null;
                    var OldAreaModel = withBlock.AreaModel;
                    if (res.Value.hasCollision && res.Value.hasVisualMap == true)
                    {
                        hp = HistoryPoint.FromObject(this, ObjectValueType.Field, new MemberWhiteList(new[] { "rndrVisualMap", "cVisualMap", "rndrCollisionMap", "cCollisionMap" }), BindingFlags.Instance | BindingFlags.NonPublic);
                        var os = new ObjectState();
                        os.Object = Main.CArea;
                        os.ValueToPatch = withBlock.AreaModel;
                        os.MemberFlags = BindingFlags.Instance | BindingFlags.Public;
                        os.MemberType = ObjectValueType.Property;
                        os.MemberName = "AreaModel";
                        hp.Entries.Add(os);
                        withBlock.AreaModel = res?.mdl;
                        withBlock.AreaModel.Collision.SpecialBoxes = OldAreaModel.Collision.SpecialBoxes;
                        cVisualMap = null;
                        cCollisionMap = null;
                    }
                    else if (res.Value.hasCollision == true)
                    {
                        hp = HistoryPoint.FromObject(this, ObjectValueType.Field, new MemberWhiteList(new[] { "rndrCollisionMap", "cCollisionMap" }), BindingFlags.Instance | BindingFlags.NonPublic);
                        var os = new ObjectState();
                        os.Object = Main.CArea.AreaModel;
                        os.ValueToPatch = withBlock.AreaModel.Collision;
                        os.MemberFlags = BindingFlags.Instance | BindingFlags.Public;
                        os.MemberType = ObjectValueType.Property;
                        os.MemberName = "Collision";
                        hp.Entries.Add(os);
                        withBlock.AreaModel.Collision = res?.mdl.Collision;
                        withBlock.AreaModel.Collision.SpecialBoxes = OldAreaModel.Collision.SpecialBoxes;
                        cCollisionMap = null;
                    }
                    else if (res.Value.hasVisualMap == true)
                    {
                        hp = HistoryPoint.FromObject(this, ObjectValueType.Field, new MemberWhiteList(new[] { "rndrVisualMap", "cVisualMap" }), BindingFlags.Instance | BindingFlags.NonPublic);
                        var os = new ObjectState();
                        os.Object = Main.CArea.AreaModel;
                        os.ValueToPatch = withBlock.AreaModel.Fast3DBuffer;
                        os.MemberFlags = BindingFlags.Instance | BindingFlags.Public;
                        os.MemberType = ObjectValueType.Property;
                        os.MemberName = "Fast3DBuffer";
                        hp.Entries.Add(os);
                        withBlock.AreaModel = res?.mdl;
                        withBlock.AreaModel.Collision = OldAreaModel.Collision;
                        cVisualMap = null;
                    }

                    if (res.Value.hasVisualMap == true)
                    {
                        withBlock.ScrollingTextures.Clear();
                        withBlock.ScrollingTextures.AddRange(withBlock.AreaModel.Fast3DBuffer.ConvertResult.ScrollingCommands.ToArray());
                        Main.Rommgr.RomConfig.GetLevelConfig(Main.CLevel.LevelID).GetLevelAreaConfig(withBlock.AreaID).ScrollingNames = res?.mdl.Fast3DBuffer.ConvertResult.ScrollingNames;
                    }

                    if (hp != null && hp.Entries.Any())
                    {
                        Main.history.Store(hp);
                    }
                }

                Main.CArea.SetSegmentedBanks(Main.Rommgr);
                LoadAreaModel();
                Main.ResumeLayout();
            }
            else
            {
                Ogl.MakeCurrent();
            }
        }

        internal void ReloadCollisionInOpenGL()
        {
            cCollisionMap = null;
            LoadAreaModel();
        }
    }
}