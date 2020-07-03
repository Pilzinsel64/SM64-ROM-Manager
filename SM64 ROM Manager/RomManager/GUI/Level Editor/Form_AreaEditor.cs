using System;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Data;
using System.Drawing;
using global::System.IO;
using System.Linq;
using global::System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using global::System.Timers;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using global::OpenTK;
using global::OpenTK.Graphics.OpenGL;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.RenderingN;
using global::Pilz.S3DFileParser;
using global::SimpleHistory;
using global::SM64_ROM_Manager.ModelConverterGUI;
using global::SM64_ROM_Manager.My.Resources;
using global::SM64_ROM_Manager.PropertyValueEditors;
using global::SM64_ROM_Manager.Publics;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.Data;
using global::SM64Lib.Geolayout;
using global::SM64Lib.Geolayout.Script.Commands;
using global::SM64Lib.Levels;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Levels.Script.Commands;
using global::SM64Lib.Model.Fast3D.DisplayLists;
using global::SM64Lib.N64Graphics;
using global::SM64Lib.SegmentedBanking;
using SM64Lib.TextValueConverter;
using Z.Collections.Extensions;
using Z.Core.Extensions;
using SM64Lib.Geolayout.Script;
using SM64Lib.Model.Fast3D.DisplayLists.Script;
using Color = System.Drawing.Color;
using Bitmap = System.Drawing.Bitmap;
using SM64Lib.Objects.ModelBanks;
using SM64Lib.Objects.ObjectBanks;

namespace SM64_ROM_Manager.LevelEditor
{
    public partial class Form_AreaEditor
    {

        internal Level CLevel { get; set; } = null;
        internal DateTime LastKeyLeaveTimer { get; set; } = DateTime.Now;
        internal List<Keys> PressedKeys { get; private set; } = new List<Keys>();
        internal ListViewEx SelectedList { get; set; }
        internal byte AreaIdToLoad { get; set; } = 1;
        internal byte LevelID { get; set; } = 0;
        internal List<System.Numerics.Vector3> OrigObjPos { get; private set; } = new List<System.Numerics.Vector3>();
        internal SM64Lib.RomManager Rommgr { get; set; } = null;
        internal List<Managed3DObject> ManagedObjects { get; private set; } = new List<Managed3DObject>();
        internal List<IManagedLevelscriptCommand> ManagedWarps { get; private set; } = new List<IManagedLevelscriptCommand>();
        internal List<ManagedSpecialBox> ManagedSpecialBoxes { get; private set; } = new List<ManagedSpecialBox>();
        internal Dictionary<byte, Renderer> ObjectModels { get; private set; } = new Dictionary<byte, Renderer>();
        internal Dictionary<ManagedSpecialBox, Renderer> SpecialBoxRenderers { get; private set; } = new Dictionary<ManagedSpecialBox, Renderer>();
        internal ObjectComboList MyObjectCombos { get; private set; } = new ObjectComboList();
        internal ObjectComboList CustomObjectsObjectCombos { get; } = new ObjectComboList();
        internal BehaviorInfoList MyBehaviorInfos { get; private set; } = new BehaviorInfoList();
        internal Dictionary<byte, object> ObjectModelsToParse { get; private set; } = new Dictionary<byte, object>();
        internal List<string> MyLevelsList { get; private set; } = new List<string>();
        internal List<byte> KnownModelIDs { get; private set; } = new List<byte>();
        internal Dictionary<byte, Geolayoutscript> GeolayoutScriptDumps { get; private set; } = new Dictionary<byte, Geolayoutscript>();
        internal Dictionary<byte, DisplayListScript[]> ObjectDisplaylistScriptDumps { get; private set; } = new Dictionary<byte, DisplayListScript[]>();
        internal Dictionary<byte, DisplayListScript[]> AreaDisplaylistScriptDumps { get; private set; } = new Dictionary<byte, DisplayListScript[]>();

        // Modules
        internal ObjectControlling objectControlling;
        internal OpenGLManager ogl;
        internal MapManagement maps;

        // History
        internal HistoryStack history = null;
        internal BindingFlags defBindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        internal MemberBlackList objStateBlackList = new MemberBlackList(new[] { "" });
        internal Dictionary<LevelArea, HistoryStack> dicHistories = new Dictionary<LevelArea, HistoryStack>();

        // Flags
        internal bool finishedLoading = false;
        internal bool isLoadingAreaIDs = false;
        internal bool changingActs = false;
        internal bool loadingObj = false;
        internal bool isObjRotating = false;
        internal bool isObjMoving = false;
        internal bool loadingWarp = false;
        internal bool rommgr_SavingRom = false;
        internal bool isFullscreen = false;
        internal bool waitUntilLostFocus = false;
        internal bool isDeactivated = false;
        internal bool hasClosed = false;

        // Variables
        internal WindowState backupWindowState = (WindowState)FormWindowState.Normal;
        internal int backupCurrentAreaIndex = -1;
        internal string lastChangedPropertyName = "";
        internal DisplayList[] lastlyLoadedDisplaylists = null;

        // Delegates
        internal delegate bool RemoveAllObjectsWhereExpression(Managed3DObject mobj);

        // Components
        private AdvTree _PropertyTree;
        internal AdvTree PropertyTree
        {
            get
            {
                return _PropertyTree;
            }
            set
            {
                if (_PropertyTree != null)
                {
                    _PropertyTree.Paint -= AdvPropertyGrid1_PropertyTree_Paint;
                }

                _PropertyTree = value;
                if (_PropertyTree != null)
                {
                    _PropertyTree.Paint += AdvPropertyGrid1_PropertyTree_Paint;
                }
            }
        }

        internal AdvPropGrid_ObjectPropertiesHelper bpMgr;

        private System.Timers.Timer _Timer_ListViewEx_Objects_SelectionChanged;
        internal System.Timers.Timer Timer_ListViewEx_Objects_SelectionChanged
        {
            get
            {
                return _Timer_ListViewEx_Objects_SelectionChanged;
            }
            set
            {
                if (_Timer_ListViewEx_Objects_SelectionChanged != null)
                {
                    _Timer_ListViewEx_Objects_SelectionChanged.Elapsed -= Timer_ListViewEx_Objects_SelectionChanged_Elapsed;
                }

                _Timer_ListViewEx_Objects_SelectionChanged = value;
                if (_Timer_ListViewEx_Objects_SelectionChanged != null)
                {
                    _Timer_ListViewEx_Objects_SelectionChanged.Elapsed += Timer_ListViewEx_Objects_SelectionChanged_Elapsed;
                }
            }
        }

        internal LevelArea CArea
        {
            get
            {
                int index = ComboBoxItem_Area.SelectedIndex;
                if (index < 0)
                {
                    return null;
                }
                else
                {
                    return CLevel.Areas[index];
                }
            }
        }

        internal bool IsStrgPressed
        {
            get
            {
                return PressedKeys.Contains(Keys.ControlKey);
            }
        }

        internal bool IsShiftPressed
        {
            get
            {
                return PressedKeys.Contains(Keys.ShiftKey);
            }
        }

        internal float ObjectMoveSpeed
        {
            get
            {
                return (float)(Slider_ObjMoveSpeed.Value / (double)100);
            }

            set
            {
                Slider_ObjMoveSpeed.Value = (int)(value * 100);
            }
        }

        public bool DrawObjectModels
        {
            get
            {
                return ButtonItem_DrawObjects.Checked;
            }

            set
            {
                ButtonItem_DrawObjects.Checked = value;
            }
        }

        internal bool DrawDirectionArrow { get; set; } = true;

        internal bool KeepObjectsOnNearestGround
        {
            get
            {
                return ButtonX_KeepOnGround.Checked;
            }

            set
            {
                ButtonX_KeepOnGround.Checked = value;
            }
        }

        internal bool KeepObjectsOnButtom
        {
            get
            {
                return ButtonX_KeepOnButtom.Checked;
            }

            set
            {
                ButtonX_KeepOnButtom.Checked = value;
            }
        }

        internal bool KeepObjectsOnTop
        {
            get
            {
                return ButtonX_KeepOnTop.Checked;
            }

            set
            {
                ButtonX_KeepOnTop.Checked = value;
            }
        }

        internal bool KeepObjectOnGround
        {
            get
            {
                return KeepObjectsOnButtom || KeepObjectsOnNearestGround || KeepObjectsOnTop;
            }
        }

        internal Camera Camera
        {
            get
            {
                return ogl?.Camera;
            }
        }

        internal void ProgressControl(bool enabled)
        {
            Task.Run(() => CircularProgress1.Invoke(new ProgressControlOnInstanceHandler(ProgressControlOnInstance), enabled));
        }

        internal delegate void ProgressControlOnInstanceHandler(bool enabled);

        internal void ProgressControlOnInstance(bool enabled)
        {
            if (enabled)
            {
                CircularProgress1.Start();
            }
            else
            {
                CircularProgress1.Stop();
            }
        }

        private ObjectComboList allObjectCombos = new ObjectComboList();
        internal ObjectComboList AllObjectCombos
        {
            get
            {
                if (!allObjectCombos.Any())
                {
                    allObjectCombos.AddRange(General.ObjectCombos);
                    allObjectCombos.AddRange(General.ObjectCombosCustom);
                    allObjectCombos.AddRange(BuildObjectCombos(Rommgr.CustomObjects));
                }
                return allObjectCombos;
            }
        }

        public Form_AreaEditor(SM64Lib.RomManager rommgr, Level Level, byte LevelID, byte AreaID)
        {
            Timer_ListViewEx_Objects_SelectionChanged = new System.Timers.Timer() { AutoReset = false, SynchronizingObject = this, Interval = 40 };

            // Setup some level variables
            CLevel = Level;
            Rommgr = rommgr;
            AreaIdToLoad = AreaID;
            this.LevelID = LevelID;

            // Initialize Components
            InitializeComponent();
            SelectedList = ListViewEx_Objects;
            
            // Create Modules
            ogl = new OpenGLManager(this, Panel_GLControl);
            objectControlling = new ObjectControlling(this);
            maps = new MapManagement(this);

            // ListViews
            ListViewEx_Objects.SetValue("DoubleBuffered", true);
            ListViewEx_Warps.SetValue("DoubleBuffered", true);

            // Stop drawing
            SuspendLayout();

            // Setup other Components
            RibbonControl1.Expanded = Settings.AreaEditor.RibbonControlExpanded;

            // Setup Form Settings
            WindowState = Settings.AreaEditor.DefaultWindowMode;

            // Setup some Styles
            if (Settings.StyleManager.AlwaysKeepBlueColors && !Settings.StyleManager.IsDarkTheme())
            {
                PanelEx1.Style.BackColor1.Color = Color.LightSteelBlue;
                PanelEx1.Style.BackColor2.Color = Color.LightSteelBlue;
            }

            // Add Groups to ListView Controls
            ListViewEx_Warps.Groups.AddRange(new[] { lvg_ConnectedWarps, lvg_WarpsForGame, lvg_PaintingWarps, lvg_InstantWarps });
            // ListViewEx_Objects.Groups.AddRange({lvg_Objects, lvg_MacroObjects})

            // Bring CircularProgress to front
            CircularProgress1.BringToFront();

            // Init Object Properties Helper
            PropertyTree = AdvPropertyGrid1.PropertyTree;
            bpMgr = new AdvPropGrid_ObjectPropertiesHelper(AdvPropertyGrid1, MyObjectCombos, MyBehaviorInfos, nameof(Managed3DObject.BehaviorID), "BParam");

            // Get the PropertyTree of AdvPropertyGrid1
            PropertyTree = AdvPropertyGrid1.PropertyTree;

            // Update Ambient Colors
            base.UpdateAmbientColors();

            // Resume drawing
            ResumeLayout();

            RibbonControl1.AutoSyncSize();

            // Add event to remember loaded area displaylist dumps
            General.LoadedAreaVisualMapDisplayLists += General_LoadedAreaVisualMapDisplayLists;
        }

        private void General_LoadedAreaVisualMapDisplayLists(DisplayList[] dls)
        {
            lastlyLoadedDisplaylists = dls;
        }

        internal void ButtonItem10_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal async void Form_AreaEditor_Shown(object sender, EventArgs e)
        {
            ogl.GLControl.Enabled = true;
            General.LoadBehaviorInfosIfEmpty();
            General.LoadObjectCombosIfEmpty();
            await LoadObjectModels();
            LoadOtherObjectCombos();
            LoadOtherBehaviorInfos();
            SortObjectCombosAlphabetlicly();
            LoadComboBoxObjComboEntries();
            LoadLevelsStringList();
            LoadAreaIDs();
            SelectedList = ListViewEx_Objects;
            ogl.Invalidate();
        }

        internal void LoadComboBoxObjComboEntries()
        {
            bpMgr.LoadComboBoxObjComboEntries(MyObjectCombos);
        }

        internal void SortObjectCombosAlphabetlicly()
        {
            var ordered = MyObjectCombos.OrderBy(n => n.Name).ToArray();
            MyObjectCombos.Clear();
            MyObjectCombos.AddRange(ordered);
        }

        internal void LoadOtherObjectCombos()
        {
            var modelIDsToLoad = new[] { 0, 0x96, 0x95, 0xA8, 0xA5, 0xA6, 0xA7, 0xA3, 0x74, 0x7A, 0x79, 0x7C, 0xA4, 0x90, 0x91, 0x94, 0xA2, 0xAA, 0xB9, 0xBA, 0x8F, 0x9F, 0xBB, 0x9C, 0xA1, 0x8E, 0xE0, 0x9E, 0xA0, 0x75, 0x76, 0x77, 0x85, 0x86, 0x87, 0x88, 0xC8, 0xCC, 0xCB, 0xD4, 0xD7, 0xD8, 0xDB, 0xCD, 0x8A, 0x8B, 0x8C, 0xC2, 0xCF, 0xCA, 0x81, 0x82, 0x83, 0x89, 0xC0, 0x84, 0xBE, 0xD9, 0xDA, 0xBC, 0xC3, 0xC9, 0xB4, 0x7F, 0x80, 0x78, 0xDC, 0xDF, 0xE1 };
            foreach (ObjectCombo obj in General.ObjectCombos.Concat(General.ObjectCombosCustom))
            {
                if ((modelIDsToLoad.Contains(obj.ModelID) || obj.Name.Contains("[MOP")) && !MyObjectCombos.Contains(obj))
                    MyObjectCombos.Add(obj);
            }
            MyObjectCombos.AddRange(BuildObjectCombos(Rommgr.CustomObjects));
        }

        internal void LoadOtherBehaviorInfos()
        {
            MyBehaviorInfos.AddRange(General.BehaviorInfos.Concat(General.BehaviorInfosCustom));
            MyBehaviorInfos.AddRange(BuildBehaviorInfos(Rommgr.CustomObjects));
        }

        internal ObjectComboList BuildObjectCombos(CustomObjectCollection customObjectCollection)
        {
            if (!CustomObjectsObjectCombos.Any() && customObjectCollection?.CustomObjects is object)
            {
                foreach (var customObject in customObjectCollection.CustomObjects)
                {
                    // Create Object Combo
                    var combo = new ObjectCombo
                    {
                        Name = customObject.Name,
                        BehaviorAddress = (uint)customObject.BehaviorProps.BehaviorAddress,
                        ModelID = customObject.ModelProps.ModelID
                    };

                    // Copy B. Params
                    void cpBPToCombo(SM64Lib.Behaviors.BehaviorParamInfo source, ObjectCombo.BParam destination)
                    {
                        if (source is object && destination is object)
                        {
                            destination.Name = source.Name;
                            destination.Description = source.Description;
                        }
                    }
                    if (!customObject.BehaviorProps.UseCustomAddress && customObject.BehaviorProps.Behavior is object)
                    {
                        cpBPToCombo(customObject.BehaviorProps.Behavior.ParamsInfo?.Param1, combo.BParam1);
                        cpBPToCombo(customObject.BehaviorProps.Behavior.ParamsInfo?.Param2, combo.BParam2);
                        cpBPToCombo(customObject.BehaviorProps.Behavior.ParamsInfo?.Param3, combo.BParam3);
                        cpBPToCombo(customObject.BehaviorProps.Behavior.ParamsInfo?.Param4, combo.BParam4);
                    }

                    // Add to List
                    CustomObjectsObjectCombos.Add(combo);
                }
            }

            return CustomObjectsObjectCombos;
        }

        internal static BehaviorInfoList BuildBehaviorInfos(CustomObjectCollection customObjectCollection)
        {
            var list = new BehaviorInfoList();

            if (customObjectCollection?.CustomObjects is object)
            {
                foreach (var customObject in customObjectCollection.CustomObjects)
                {
                    if (!customObject.BehaviorProps.UseCustomAddress && customObject.BehaviorProps.Behavior is object)
                    {
                        // Create Behavior Info
                        var behavInfo = new BehaviorInfo
                        {
                            Name = customObject.BehaviorProps.Behavior.Name,
                            BehaviorAddress = (uint)customObject.BehaviorProps.BehaviorAddress
                        };

                        // Copy B. Params
                        void cpBPToBehavior(SM64Lib.Behaviors.BehaviorParamInfo source, BehaviorInfo.BParam destination)
                        {
                            if (source is object && destination is object)
                            {
                                destination.Name = source.Name;
                                foreach (var srcVals in source.Values)
                                {
                                    destination.Values.Add(new BehaviorInfo.BParamValue
                                    {
                                        Name = srcVals.Name,
                                        Value = srcVals.Value
                                    });
                                }
                            }
                        }
                        cpBPToBehavior(customObject.BehaviorProps.Behavior.ParamsInfo?.Param1, behavInfo.BParam1);
                        cpBPToBehavior(customObject.BehaviorProps.Behavior.ParamsInfo?.Param2, behavInfo.BParam2);
                        cpBPToBehavior(customObject.BehaviorProps.Behavior.ParamsInfo?.Param3, behavInfo.BParam3);
                        cpBPToBehavior(customObject.BehaviorProps.Behavior.ParamsInfo?.Param4, behavInfo.BParam4);

                        // Add to List
                        list.Add(behavInfo);
                    }
                }
            }

            return list;
        }

        internal void LoadLevelsStringList()
        {
            MyLevelsList.Clear();
            var items = new List<ComboItem>();
            var levels = new List<Levels>();
            foreach (var lvl in Rommgr.LevelInfoData)
            {
                string displayName = $"{TextValueConverter.TextFromValue(lvl.ID, charCount: 2)} - {lvl.Name}";
                MyLevelsList.Add(displayName);
                var cbitem = new ComboItem(displayName);
                cbitem.Tag = lvl;
                items.Add(cbitem);
                levels.Add((Levels)lvl.ID);
            }

            var propSet = new PropertySettings("DestLevelID");
            var editor = new LevelsEnumEditor(items.ToArray(), levels);
            editor.DropDownWidth = 200;
            propSet.ValueEditor = editor;
            AdvPropertyGrid1.PropertySettings.Add(propSet);
        }

        internal void ButtonX_DropToGround_Click(object sender, EventArgs e)
        {
            StoreObjectHistoryPoint(SelectedObjects, "Position");
            DropObjectsToGround(0);
        }

        internal void ButtonX_DropToTop_Click(object sender, EventArgs e)
        {
            StoreObjectHistoryPoint(SelectedObjects, "Position");
            DropObjectsToGround(1);
        }

        internal void ButtonX_DropToBottom_Click(object sender, EventArgs e)
        {
            StoreObjectHistoryPoint(SelectedObjects, "Position");
            DropObjectsToGround(2);
        }

        internal void ButtonX_KeepOnGround_CheckedChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(((ButtonX)sender).Checked))
            {
                foreach (ButtonX btn in new[] { ButtonX_KeepOnGround, ButtonX_KeepOnTop, ButtonX_KeepOnButtom })
                {
                    if (btn != sender)
                        btn.Checked = false;
                }

                if ((new object[] { ButtonX_KeepOnGround, ButtonItem_KeepOnGround }).Contains(sender))
                {
                    ButtonX_DropToGround.PerformClick();
                }
                else if ((new object[] { ButtonX_KeepOnTop, ButtonItem_KeepOnTop }).Contains(sender))
                {
                    ButtonX_DropToTop.PerformClick();
                }
                else if ((new object[] { ButtonX_KeepOnButtom, ButtonItem_KeepOnButtom }).Contains(sender))
                {
                    ButtonX_DropToBottom.PerformClick();
                }
            }
        }

        internal void Form_AreaEditor_Closing(object sender, CancelEventArgs e)
        {
            // Stop Circular Progress, otherwise it will crash
            CircularProgress1.Stop();

            // Save all Objects
            SaveAllObjectProperties();
            SaveAllWarpProperties();

            General.LoadedAreaVisualMapDisplayLists -= General_LoadedAreaVisualMapDisplayLists;

            maps.ReleaseBuffers();

            GeolayoutScriptDumps.ForEach((n) => n.Value.Close());
            ObjectDisplaylistScriptDumps.ForEach((m) => m.Value.ForEach((n) => n.Close()));
            AreaDisplaylistScriptDumps.ForEach((m) => m.Value.ForEach((n) => n.Close()));

            hasClosed = true;
        }

        internal void DockContainerItem4_Click(object sender, EventArgs e)
        {
            if (((DockContainerItem)sender).Selected)
            {
                RibbonTabItem_Objects.Select();
            }
        }

        internal void DockContainerItem1_Click(object sender, EventArgs e)
        {
            if (((DockContainerItem)sender).Selected)
            {
                RibbonTabItem_Warps.Select();
            }
        }

        internal void DockContainerItem5_Click(object sender, EventArgs e)
        {
            if (((DockContainerItem)sender).Selected)
            {
                RibbonTabItem_Collision.Select();
            }
        }

        internal void ButtonItem95_Click(object sender, EventArgs e)
        {
            if (RibbonControl1.Expanded)
            {
                ButtonItem95.Image = MyIcons.icons8_expand_arrow_16px;
                RibbonControl1.Expanded = false;
            }
            else
            {
                ButtonItem95.Image = MyIcons.icons8_collapse_arrow_16px;
                RibbonControl1.Expanded = true;
            }

            Settings.AreaEditor.RibbonControlExpanded = RibbonControl1.Expanded;
        }

        internal void RibbonControl1_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            var srti = RibbonControl1.SelectedRibbonTabItem;
            switch (true)
            {
                case object _ when srti.Equals(RibbonTabItem_Objects):
                    {
                        SelectedList = ListViewEx_Objects;
                        DockContainerItem4.Selected = true;
                        break;
                    }

                case object _ when srti.Equals(RibbonTabItem_Warps):
                    {
                        SelectedList = ListViewEx_Warps;
                        DockContainerItem1.Selected = true;
                        break;
                    }

                default:
                    {
                        return;
                    }
            }

            PanelDockContainer10.DockContainerItem.Selected = true;
        }

        internal void Form_AreaEditor_Activated(object sender, EventArgs e)
        {
            if (isDeactivated)
            {
                isDeactivated = false;
                maps.CheckAndLoadNew();
            }
        }

        internal void Form_AreaEditor_Deactivate(object sender, EventArgs e)
        {
            isDeactivated = true;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void AdvPropertyGrid1_RefreshPropertyValues()
        {
            try
            {
                AdvPropertyGrid1.RefreshPropertyValues();
            }
            catch (Exception ex)
            {
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private async Task LoadObjectModels()
        {
            ObjectModels.Clear();

            // Parse root level script
            await ParseLevelscriptAndLoadModels(LoadMainLevelscript(Rommgr));

            // Parse level script
            await ParseLevelscriptAndLoadModels(CLevel.Levelscript);

            // Load global objects
            if (Rommgr.HasGlobalObjectBank && CLevel.EnableGlobalObjectBank)
            {
                Rommgr.GenerateGlobalObjectBank();
                await LoadCustomObjectBankModels(Rommgr.GlobalModelBank);
            }

            // Load local objects
            if (CLevel.EnableLocalObjectBank && CLevel.LocalObjectBank.Models.Any())
            {
                await LoadCustomObjectBankModels(CLevel.LocalObjectBank);
            }

            // Additional Editor Models
            await LoadAdditionalEditorModels();
        }

        private async Task LoadAdditionalEditorModels()
        {
            var loaderModule = File3DLoaderModule.LoaderModules.FirstOrDefault(n => n.Name == "Assimp");
            var loaderOptions = new LoaderOptions()
            {
                LoadMaterials = true,
                UpAxis = UpAxis.Y
            };

            // Load Model ID 0
            var mdlDirectionArrow = await loaderModule.InvokeAsync(Path.Combine(Publics.General.MyDataPath, @"Area Editor\Models\Direction Arrow.fbx"), loaderOptions);
            mdlDirectionArrow.ScaleModel(100f);
            AddObject3DWithRendererIfNotNull(mdlDirectionArrow, 0);
        }

        public static Levelscript LoadMainLevelscript(SM64Lib.RomManager Rommgr)
        {
            var lvlScriptMain = new Levelscript();
            lvlScriptMain.Read(Rommgr, Rommgr.GetSegBank(0x15).BankAddress, LevelscriptCommandTypes.x1E);
            return lvlScriptMain;
        }

        private async Task LoadCustomObjectBankModels(CustomModelBank objBank)
        {
            foreach (CustomModel obj in objBank.Models)
            {
                if (!ObjectModels.ContainsKey(obj.ModelID))
                {
                    await LoadCustomObjectBankModel(obj);
                }
            }
        }

        private async Task LoadCustomObjectBankModel(CustomModel obj)
        {
            var mdl = new Object3D();
            var data = new BinaryStreamData(obj.Model.Fast3DBuffer);
            foreach (Geopointer gp in obj.Geolayout.Geopointers)
                await LoadDisplaylist(data, gp, mdl);
            AddObject3DWithRendererIfNotNull(mdl, obj.ModelID);
        }

        private async Task<DisplayList> LoadDisplaylist(Geopointer pointer, Object3D mdl)
        {
            var dl = new DisplayList();
            await dl.TryFromStreamAsync(pointer, Rommgr, default);
            await dl.TryToObject3DAsync(mdl, Rommgr, default);
            return dl;
        }

        private async Task<DisplayList> LoadDisplaylist(BinaryData data, Geopointer pointer, Object3D mdl)
        {
            var dl = new DisplayList();
            await dl.TryFromStreamAsync(pointer, Rommgr, default);
            await dl.TryToObject3DAsync(mdl, Rommgr, default);
            return dl;
        }

        private void AddObject3DWithRendererIfNotNull(Object3D mdl, byte modelID)
        {
            if (mdl.Meshes.Any())
            {
                var rndr = new Renderer(mdl);
                ObjectModels.AddOrUpdate(modelID, rndr);
            }
        }

        private async Task ParseGeolayoutAndLoadModels(Geolayoutscript glscript, byte modelID)
        {
            var mdlScale = System.Numerics.Vector3.One;
            int mdlScaleNodeIndex = -1;
            int nodeIndex = 0;
            var mdl = new Object3D();
            var dls = new List<DisplayList>();
            var offsets = new Stack<System.Numerics.Vector3>();
            var curTotalOffset = System.Numerics.Vector3.Zero;
            offsets.Push(curTotalOffset);

            foreach (GeolayoutCommand fegmd in glscript)
            {
                var gmd = fegmd;
                switch (gmd.CommandType)
                {
                    case GeolayoutCommandTypes.LoadDisplaylist:
                        {
                            byte geolayer = cgLoadDisplayList.GetDrawingLayer(ref gmd);
                            int segAddr = cgLoadDisplayList.GetSegGeopointer(ref gmd);
                            if (segAddr > 0)
                                dls.Add(await LoadDisplaylist(new Geopointer(geolayer, segAddr, mdlScale, curTotalOffset), mdl));
                            break;
                        }
                    case GeolayoutCommandTypes.LoadDisplaylistWithOffset:
                        {
                            byte geolayer = cgLoadDisplayListWithOffset.GetDrawingLayer(ref gmd);
                            int segAddr = Conversions.ToInteger(cgLoadDisplayListWithOffset.GetSegGeopointer(ref gmd));
                            var localOffset = cgLoadDisplayListWithOffset.GetOffset(ref gmd);
                            if (segAddr > 0)
                            {
                                var geop = new Geopointer(geolayer, segAddr, mdlScale, localOffset + curTotalOffset);
                                dls.Add(await LoadDisplaylist(geop, mdl));
                            }
                            else
                                curTotalOffset += localOffset;
                            break;
                        }
                    case GeolayoutCommandTypes.Scale2:
                        {
                            gmd.Position = 4;
                            uint scale = gmd.ReadUInt32();
                            mdlScale = new System.Numerics.Vector3(scale / 65536.0F);
                            mdlScaleNodeIndex = nodeIndex;
                            break;
                        }
                    case GeolayoutCommandTypes.StartOfNode:
                        nodeIndex += 1;
                        offsets.Push(curTotalOffset);
                        break;
                    case GeolayoutCommandTypes.EndOfNode:
                        nodeIndex -= 1;
                        if (offsets.Any())
                            curTotalOffset = offsets.Pop();
                        break;
                    case GeolayoutCommandTypes.x10:
                        curTotalOffset += cgLoadDisplayListWithOffset.GetOffset(ref gmd);
                        break;
                }

                if (mdlScaleNodeIndex > -1 && mdlScaleNodeIndex > nodeIndex)
                {
                    mdlScaleNodeIndex = -1;
                    mdlScale = System.Numerics.Vector3.One;
                }
            }

            if (dls.Any())
                ObjectDisplaylistScriptDumps.AddOrUpdate(modelID, dls.Select((n) => n.Script).ToArray());

            AddObject3DWithRendererIfNotNull(mdl, modelID);
        }

        public static async Task ParseLevelscriptAndLoadSegmentedBanks(SM64Lib.RomManager Rommgr, Levelscript lvlscript)
        {
            foreach (LevelscriptCommand cmd in lvlscript)
            {
                var switchExpr = cmd.CommandType;
                switch (switchExpr)
                {
                    case LevelscriptCommandTypes.JumpToSegAddr:
                        var scrpt = ParseLevelscriptCommandGetLevelscriptToJump(Rommgr, cmd);
                        await ParseLevelscriptAndLoadSegmentedBanks(Rommgr, scrpt);
                        break;
                    case LevelscriptCommandTypes.LoadRomToRam:
                    case LevelscriptCommandTypes.x1A:
                    case LevelscriptCommandTypes.x18:
                        ParseLevelscriptCommandLoadSegBank(Rommgr, cmd);
                        break;
                }
            }
        }

        private static Levelscript ParseLevelscriptCommandGetLevelscriptToJump(SM64Lib.RomManager Rommgr, LevelscriptCommand cmd)
        {
            int bankAddr = clJumpToSegAddr.GetSegJumpAddr(cmd);
            byte segID = Conversions.ToByte(bankAddr >> 24);
            var seg = Rommgr.GetSegBank(segID);
            var scrpt = new Levelscript();
            if (segID != 0 && seg is object)
                scrpt.Read(Rommgr, bankAddr, LevelscriptCommandTypes.JumpBack);
            return scrpt;
        }

        private static void ParseLevelscriptCommandLoadSegBank(SM64Lib.RomManager Rommgr, LevelscriptCommand cmd)
        {
            byte segID = clLoadRomToRam.GetSegmentedID(cmd);
            var segg = Rommgr.GetSegBank(segID);
            if (segg is null)
            {
                var seg = new SegmentedBank();
                seg.BankID = segID;
                seg.RomStart = clLoadRomToRam.GetRomStart(cmd);
                seg.RomEnd = clLoadRomToRam.GetRomEnd(cmd);
                if (cmd.CommandType == LevelscriptCommandTypes.x1A)
                    seg.MakeAsMIO0();
                Rommgr.SetSegBank(seg);
            }
        }

        private async Task ParseLevelscriptAndLoadModels(Levelscript lvlscript)
        {
            foreach (LevelscriptCommand cmd in lvlscript)
            {
                var switchExpr = cmd.CommandType;
                switch (switchExpr)
                {
                    case LevelscriptCommandTypes.LoadPolygonWithGeo:
                        {
                            byte modelID = clLoadPolygonWithGeo.GetModelID(cmd);
                            int segPointer = clLoadPolygonWithGeo.GetSegAddress(cmd);
                            byte segID = Conversions.ToByte(segPointer >> 24);
                            AddObjectCombosToMyObjectCombos(modelID);
                            if (!KnownModelIDs.Contains(modelID))
                                KnownModelIDs.Add(modelID);
                            var seg = Rommgr.GetSegBank(segID);
                            if (segID != 0 && seg is object)
                            {
                                var glscript = new Geolayoutscript();
                                glscript.Read(Rommgr, segPointer);
                                await ParseGeolayoutAndLoadModels(glscript, modelID);
                                GeolayoutScriptDumps.AddOrUpdate(modelID, glscript);
                            }
                            break;
                        }
                    case LevelscriptCommandTypes.LoadPolygonWithoutGeo:
                        {
                            byte modelID = clLoadPolygonWithGeo.GetModelID(cmd);
                            int segPointer = clLoadPolygonWithGeo.GetSegAddress(cmd);
                            int layer = clLoadPolygonWithoutGeo.GetDrawingLayer(cmd);
                            byte segID = Conversions.ToByte(segPointer >> 24);
                            AddObjectCombosToMyObjectCombos(modelID);
                            if (!KnownModelIDs.Contains(modelID))
                                KnownModelIDs.Add(modelID);
                            var seg = Rommgr.GetSegBank(segID);
                            if (segID != 0 && seg is object)
                            {
                                var mdl = new Object3D();
                                await LoadDisplaylist(new Geopointer(Conversions.ToByte(layer), segPointer), mdl);
                                var rndr = new Renderer(mdl);
                                ObjectModels.AddOrUpdate(modelID, rndr);
                            }
                            break;
                        }
                    case LevelscriptCommandTypes.PaintingWarp:
                        break;
                    case LevelscriptCommandTypes.JumpToSegAddr:
                        var scrpt = ParseLevelscriptCommandGetLevelscriptToJump(Rommgr, cmd);
                        await ParseLevelscriptAndLoadModels(scrpt);
                        break;
                    case LevelscriptCommandTypes.LoadRomToRam:
                    case LevelscriptCommandTypes.x1A:
                    case LevelscriptCommandTypes.x18:
                        ParseLevelscriptCommandLoadSegBank(Rommgr, cmd);
                        break;
                }
            }
        }

        internal void AddObjectCombosToMyObjectCombos(byte modelID)
        {
            foreach (ObjectCombo obj in General.ObjectCombos.Concat(General.ObjectCombosCustom))
            {
                if (obj.ModelID == modelID && !MyObjectCombos.Contains(obj))
                {
                    MyObjectCombos.Add(obj);
                }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem_SaveRom_Click(object sender, EventArgs e)
        {
            SaveAllObjectProperties();
            SaveAllWarpProperties();
            ProgressControl(true);
            Application.DoEvents();
            rommgr_SavingRom = true;
            General.SaveRom(Rommgr);
            rommgr_SavingRom = false;
            ProgressControl(false);
        }

        internal async void ButtonItem_LaunchROM_Click(object sender, EventArgs e)
        {
            await WaitWhileSavingRom();
            General.LaunchRom(Rommgr);
        }

        internal Task WaitWhileSavingRom()
        {
            var t = new Task(() => { while (rommgr_SavingRom) { } });
            t.Start();
            return t;
        }

        // Public Sub SetCameraMode(mode As CameraMode)
        // Camera.SetCameraMode(mode, camMtx)
        // 'camera.updateMatrix(camMtx)
        // Invalidate()
        // End Sub
        // Public Sub SetCameraMode(mode As CameraMode, look As LookDirection)
        // camera.SetCameraMode(mode, camMtx)
        // camera.setCameraMode_LookDirection(look, camMtx)
        // 'camera.updateMatrix(camMtx)
        // ogl.Invalidate()
        // End Sub
        public CameraMode GetCamerMode()
        {
            return Camera.CamMode;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem_Copy_Click(object sender, EventArgs e)
        {
            CopySelection();
        }

        internal void PasteObjectDefault(object sender, EventArgs e)
        {
            bool isDefault = sender == ButtonItem_PasteObjDefault || sender == ButtonItem37;
            PasteSelection(new PasteObjectSettings()
            {
                DataFormat = "sm64lvlcmdobj3d",
                PasteBehavID = isDefault || sender == ButtonItem_PasteObjCombo || sender == ButtonItem_PasteObjBehavID,
                PasteActs = isDefault || sender == ButtonItem_PasteObjActs,
                PasteBParams = isDefault || sender == ButtonItem_PasteObjBParams,
                PasteModelID = isDefault || sender == ButtonItem_PasteObjCombo || sender == ButtonItem_PasteObjModelID,
                PastePosition = isDefault || sender == ButtonItem_PasteObjPos,
                PasteRotation = isDefault || sender == ButtonItem_PasteObjRot
            });
        }

        internal void PasteWarpDefault(object sender, EventArgs e)
        {
            bool isDefault = sender == ButtonItem_PasteWarpDefault || sender == ButtonItem5;
            PasteSelection(new PasteWarpSettings()
            {
                DataFormat = "sm64lvlcmdconnectwarp",
                PasteDestArea = isDefault || sender == ButtonItem_PasteWarpDestArea,
                PasteDestLevel = isDefault || sender == ButtonItem_PasteWarpDestLevel,
                PasteDestWarp = isDefault || sender == ButtonItem_PasteWarpDestWarp
            });
        }

        internal void CopySelection()
        {
            var cmds = new List<string>();
            string format = "";
            IntPtr[] lastCmds = null;
            foreach (ListViewItem item in SelectedList.SelectedItems)
            {
                LevelscriptCommand cmd = null;
                switch (true)
                {
                    case object _ when EditObjects:
                        {
                            Managed3DObject obj = (Managed3DObject)item.Tag;
                            obj.SaveProperties();
                            cmd = obj.Command;
                            format = "sm64lvlcmdobj3d";
                            break;
                        }

                    case object _ when EditWarps:
                        {
                            IManagedLevelscriptCommand warp = (IManagedLevelscriptCommand)item.Tag;
                            if (warp is ManagedWarp)
                            {
                                warp.SaveProperties();
                                cmd = warp.Command;
                                format = "sm64lvlcmdconnectwarp";
                            }

                            break;
                        }
                }

                if (cmd is object)
                {
                    cmds.Add(Convert.ToBase64String(cmd.ToArray()));
                }
            }

            // Set content to clipboard
            Clipboard.SetData(format, cmds.ToArray());
        }

        internal void PasteSelection(PasteSettings pasteSettings)
        {
            if (Clipboard.ContainsData(pasteSettings.DataFormat))
            {
                string[] cmds = (string[])Clipboard.GetData(pasteSettings.DataFormat);
                ListView.SelectedListViewItemCollection selItems;
                ListViewEx indexListToUse = null;
                List<LevelscriptCommand> cmdListToUse = null;
                var switchExpr = pasteSettings.GetType();
                switch (switchExpr)
                {
                    case var @case when @case == typeof(PasteObjectSettings):
                        {
                            indexListToUse = ListViewEx_Objects;
                            cmdListToUse = CArea.Objects;
                            break;
                        }

                    case var case1 when case1 == typeof(PasteWarpSettings):
                        {
                            indexListToUse = ListViewEx_Warps;
                            cmdListToUse = CArea.Warps;
                            break;
                        }
                }

                selItems = indexListToUse.SelectedItems;
                if (selItems.Count > 0)
                {
                    int curCmdIndex = 0;
                    int curCmd2Index = 0;
                    while (selItems.Count > curCmd2Index)
                    {
                        LevelscriptCommand curCmd1;
                        var curCmd2 = new LevelscriptCommand(Convert.FromBase64String(cmds[curCmdIndex]));
                        if (curCmd2 is object)
                        {
                            var switchExpr1 = pasteSettings.GetType();
                            switch (switchExpr1)
                            {
                                case var case2 when case2 == typeof(PasteObjectSettings):
                                    {
                                        Managed3DObject mobj = (Managed3DObject)selItems[curCmd2Index].Tag;
                                        curCmd1 = mobj.Command;
                                        mobj.SaveProperties();
                                        {
                                            var withBlock = (PasteObjectSettings)pasteSettings;
                                            if (withBlock.PasteModelID)
                                                clNormal3DObject.SetModelID(curCmd1, clNormal3DObject.GetModelID(curCmd2));
                                            if (withBlock.PasteBehavID)
                                                clNormal3DObject.SetSegBehaviorAddr(curCmd1, clNormal3DObject.GetSegBehaviorAddr(curCmd2));
                                            if (withBlock.PasteBParams)
                                                clNormal3DObject.SetParams(curCmd1, clNormal3DObject.GetParams(curCmd2));
                                            if (withBlock.PasteActs)
                                                clNormal3DObject.SetActs(curCmd1, clNormal3DObject.GetActs(curCmd2));
                                            if (withBlock.PastePosition)
                                                clNormal3DObject.SetPosition(curCmd1, clNormal3DObject.GetPosition(curCmd2));
                                            if (withBlock.PasteRotation)
                                                clNormal3DObject.SetRotation(curCmd1, clNormal3DObject.GetRotation(curCmd2));
                                        }

                                        mobj.LoadProperties();
                                        break;
                                    }

                                case var case3 when case3 == typeof(PasteWarpSettings):
                                    {
                                        IManagedLevelscriptCommand mwarp = (IManagedLevelscriptCommand)selItems[curCmd2Index].Tag;
                                        curCmd1 = mwarp.Command;
                                        mwarp.SaveProperties();
                                        if (mwarp is ManagedWarp)
                                        {
                                            {
                                                var withBlock1 = (PasteWarpSettings)pasteSettings;
                                                if (withBlock1.PasteDestLevel)
                                                    clWarp.SetDestinationLevelID(curCmd1, clWarp.GetDestinationLevelID(curCmd2));
                                                if (withBlock1.PasteDestArea)
                                                    clWarp.SetDestinationAreaID(curCmd1, clWarp.GetDestinationAreaID(curCmd2));
                                                if (withBlock1.PasteDestWarp)
                                                    clWarp.SetDestinationWarpID(curCmd1, clWarp.GetDestinationWarpID(curCmd2));
                                            }
                                        }

                                        mwarp.LoadProperties();
                                        break;
                                    }
                            }

                            // Close temp command
                            curCmd2.Close();
                        }

                        curCmdIndex += 1;
                        curCmd2Index += 1;
                        if (curCmdIndex == cmds.Length)
                        {
                            if (curCmdIndex >= indexListToUse.SelectedIndices.Count)
                            {
                                break;
                            }
                            else
                            {
                                curCmdIndex = 0;
                            }
                        }
                    }
                }

                var switchExpr2 = pasteSettings.GetType();
                switch (switchExpr2)
                {
                    case var case4 when case4 == typeof(PasteObjectSettings):
                        {
                            UpdateObjectListViewItems();
                            AdvPropertyGrid1_RefreshPropertyValues();
                            ogl.UpdateOrbitCamera();
                            break;
                        }

                    case var case5 when case5 == typeof(PasteWarpSettings):
                        {
                            UpdateWarpListViewItem();
                            AdvPropertyGrid1_RefreshPropertyValues();
                            break;
                        }
                }
            }
        }

        internal class PasteSettings
        {
            public string DataFormat { get; set; } = "";
        }

        internal class PasteObjectSettings : PasteSettings
        {
            public bool PasteModelID { get; set; } = false;
            public bool PasteBehavID { get; set; } = false;
            public bool PasteBParams { get; set; } = false;
            public bool PasteActs { get; set; } = false;
            public bool PastePosition { get; set; } = false;
            public bool PasteRotation { get; set; } = false;
        }

        internal class PasteWarpSettings : PasteSettings
        {
            public bool PasteDestLevel { get; set; } = false;
            public bool PasteDestArea { get; set; } = false;
            public bool PasteDestWarp { get; set; } = false;
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem44_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal HistoryPoint StoreHistoryPoint(MethodInfo miUndo, MethodInfo miRedo, object[] param)
        {
            return StoreHistoryPoint(miUndo, miRedo, param, param);
        }

        internal HistoryPoint StoreHistoryPoint(object obj, MethodInfo miUndo, MethodInfo miRedo, object[] param)
        {
            return StoreHistoryPoint(obj, miUndo, miRedo, param, param);
        }

        internal HistoryPoint StoreHistoryPoint(MethodInfo miUndo, MethodInfo miRedo, object[] paramUndo, object[] paramRedo)
        {
            return StoreHistoryPoint(null, miUndo, miRedo, paramUndo, paramRedo);
        }

        internal HistoryPoint StoreHistoryPoint(object obj, MethodInfo miUndo, MethodInfo miRedo, object[] paramUndo, object[] paramRedo)
        {
            var act = new ObjectAction(obj, miUndo, miRedo, paramUndo, paramUndo);
            return StoreHistoryPoint(act);
        }

        internal HistoryPoint StoreHistoryPoint(params ObjectAction[] actions)
        {
            var hp = new HistoryPoint();
            hp.Entries.AddRange(actions);
            history.Store(hp);
            return hp;
        }

        internal void StoreObjectHistoryPointUsingFocus(object[] objs, params string[] whitelist)
        {
            if (!waitUntilLostFocus)
            {
                waitUntilLostFocus = true;
                StoreObjectHistoryPoint(objs, whitelist);
            }
        }

        internal void StoreObjectHistoryPoint(object[] objs, params string[] whitelist)
        {
            var hps = new List<HistoryPoint>();
            foreach (object obj in objs)
                hps.Add(HistoryPoint.FromObject(obj, ObjectValueType.Property, defBindFlags, true, whitelist));
            if (objs.Count() > 0)
            {
                var hp = HistoryPoint.Concat(hps.ToArray());
                if (hp.Entries.Any())
                {
                    history.Store(hp);
                }
            }
        }

        internal void ButtonItem_Undo_Click(object sender, EventArgs e)
        {
            history.Undo();
            RefreshAfterHistoryAction();
        }

        internal void ButtonItem_Redo_Click(object sender, EventArgs e)
        {
            history.Redo();
            RefreshAfterHistoryAction();
        }

        internal void RefreshAfterHistoryAction()
        {
            SuspendLayout();
            UpdateObjectListViewItems();
            UpdateWarpListViewItem();
            AdvPropertyGrid1_RefreshPropertyValues();
            ogl.UpdateOrbitCamera();
            ResumeLayout();
            ogl.Invalidate();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem22_Click(object sender, EventArgs e)
        {
            if (ogl.CurrentModelDrawMod == ModelDrawMod.VisualMap)
            {
                var sfd = new SaveFileDialog() { Filter = "PNG File (*.png)|*.png|BMP File (*.bmp)|*.bmp|GIF File (*.gif)|*.gif|JPEG File (*.jpeg)|*.jpeg" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ogl.SaveScreenshot(sfd.FileName);
                }
            }
            else
            {
                // MessageBoxEx.Show("Please select the Visual Map and try again.", "Not Visual Map selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Publics.General.ShowToastnotification(Panel_GLControl, "Please select the Visual Map and try again.", eToastGlowColor.Red);
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem2_CheckedChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            var switchExpr = ButtonItem2.Checked;
            switch (switchExpr)
            {
                case true:
                    {
                        isFullscreen = true;
                        TopMost = true;
                        ButtonItem2.Text = "Disable Fullscreen";
                        FormBorderStyle = FormBorderStyle.None;
                        backupWindowState = (WindowState)WindowState;
                        WindowState = FormWindowState.Maximized;
                        RibbonControl1.CaptionVisible = false;
                        RibbonControl1.Height -= 28;
                        break;
                    }

                case false:
                    {
                        isFullscreen = false;
                        TopMost = false;
                        ButtonItem2.Text = "Enable Fullscreen";
                        FormBorderStyle = FormBorderStyle.Sizable;
                        WindowState = (FormWindowState)backupWindowState;
                        RibbonControl1.Height += 28;
                        RibbonControl1.CaptionVisible = true;
                        break;
                    }
            }

            ResumeLayout();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal ListViewGroup lvg_ConnectedWarps = new ListViewGroup() { Header = "Connected Warps" };
        internal ListViewGroup lvg_WarpsForGame = new ListViewGroup() { Header = "Warps for Game" };
        internal ListViewGroup lvg_PaintingWarps = new ListViewGroup() { Header = "Painting Warps" };
        internal ListViewGroup lvg_InstantWarps = new ListViewGroup() { Header = "Instant Warps" };
        // Friend lvg_Objects As New ListViewGroup With {.Header = "3D Objects"}
        // Friend lvg_MacroObjects As New ListViewGroup With {.Header = "Macro 3D Objects"}

        internal void LoadAreaIDs()
        {
            isLoadingAreaIDs = true;
            ComboBoxItem_Area.Items.Clear();
            byte indexToSelect = 0;
            foreach (LevelArea a in CLevel.Areas)
            {
                ComboBoxItem_Area.Items.Add(new ComboItem() { Text = $"Area {a.AreaID}", Tag = a });
                if (a.AreaID == AreaIdToLoad)
                    indexToSelect = Conversions.ToByte(CLevel.Areas.IndexOf(a));
            }

            isLoadingAreaIDs = false;
            ComboBoxItem_Area.SelectedIndex = indexToSelect;
        }

        internal void LoadObjectLists()
        {
            ListViewEx_Objects.SuspendLayout();
            ListViewEx_Objects.Items.Clear();
            ManagedObjects.Clear();
            int i = 0;
            foreach (var objj in CArea.Objects)
            {
                var objNew = new Managed3DObject(objj, AllObjectCombos);
                ManagedObjects.Add(objNew);
                var lvi = new ListViewItem();
                lvi.Tag = objNew;
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem());
                SetObjectPropertiesToListViewItem(ref lvi, objNew, i);
                ListViewEx_Objects.Items.Add(lvi);
                i += 1;
            }

            // Select first Item
            SelectItemAtIndexInList(ListViewEx_Objects, 0, true);
            ListViewEx_Objects.ResumeLayout();
        }

        internal void SelectItemsInList(ListViewEx list, ListViewItem[] items, bool deselectAllOtherItems)
        {
            list.SuspendLayout();

            if (deselectAllOtherItems)
                foreach (ListViewItem item in list.SelectedItems)
                    item.Selected = false;

            foreach (var item in items)
                item.Selected = true;

            items.LastOrDefault()?.EnsureVisible();

            list.ResumeLayout();
        }

        internal void SelectItemAtIndexInList(ListViewEx list, int index, bool deselectAllOtherItems)
        {
            for (int i = 0, loopTo = list.Items.Count - 1; i <= loopTo; i++)
            {
                if (i == index)
                {
                    list.Items[i].Selected = true;
                    list.EnsureVisible(i);
                }
                else if (deselectAllOtherItems)
                {
                    list.Items[i].Selected = false;
                }
            }
        }

        internal void LoadWarpsLists()
        {
            ListViewEx_Warps.SuspendLayout();
            ListViewEx_Warps.Items.Clear();
            ManagedWarps.Clear();
            var allWarps = new List<LevelscriptCommand>();
            int gameWarpsStart, gameWarpCount;
            allWarps.AddRange(CArea.Warps);
            gameWarpsStart = allWarps.Count;
            gameWarpCount = CArea.WarpsForGame.Count;
            allWarps.AddRange(CArea.WarpsForGame);
            foreach (LevelscriptCommand warp in allWarps)
            {
                IManagedLevelscriptCommand warpNew = null;
                var lvi = new ListViewItem() { Tag = warpNew };

                // Set the ListViewGroup for the ListViewItem
                var switchExpr = warp.CommandType;
                switch (switchExpr)
                {
                    case LevelscriptCommandTypes.ConnectedWarp:
                        {
                            int warpIndex = allWarps.IndexOf(warp);
                            if (warpIndex >= gameWarpsStart && warpIndex <= gameWarpsStart + gameWarpCount)
                            {
                                lvi.Group = lvg_WarpsForGame;
                            }
                            else
                            {
                                lvi.Group = lvg_ConnectedWarps;
                            }

                            warpNew = new ManagedWarp(warp);
                            break;
                        }

                    case LevelscriptCommandTypes.PaintingWarp:
                        {
                            lvi.Group = lvg_PaintingWarps;
                            warpNew = new ManagedWarp(warp);
                            break;
                        }

                    case LevelscriptCommandTypes.InstantWarp:
                        {
                            warpNew = new ManagedInstantWarp(warp);
                            break;
                        }
                }

                // Set managed Warp as Tag
                lvi.Tag = warpNew;

                // Add enought SubItems to ListviewItem
                for (int i = 2; i <= 4; i++)
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem());

                // Set all Properties as Text to the SubItems
                SetWarpPropertiesToListViewItem(ref lvi, warpNew);
                ManagedWarps.Add(warpNew);
                ListViewEx_Warps.Items.Add(lvi);
            }

            // Select first Item
            if (ListViewEx_Warps.Items.Count > 0)
            {
                {
                    var withBlock = ListViewEx_Warps.Items[0];
                    withBlock.Selected = true;
                }
            }

            ListViewEx_Warps.ResumeLayout();
        }

        internal void SetWarpPropertiesToListViewItem(ref ListViewItem lvi, IManagedLevelscriptCommand iwarp)
        {
            if (iwarp is ManagedWarp)
            {
                ManagedWarp warp = (ManagedWarp)iwarp;
                var destLevel = Rommgr.LevelInfoData.FirstOrDefault(n => n.ID == (ushort)warp.DestLevelID);
                lvi.SubItems[0].Text = WarpIDToString(warp.WarpID);
                lvi.SubItems[1].Text = $"{destLevel?.TypeString}-{destLevel?.Number}";
                lvi.SubItems[2].Text = TextValueConverter.TextFromValue(warp.DestAreaID);
                lvi.SubItems[3].Text = TextValueConverter.TextFromValue(warp.DestWarpID);
                Color colorToUse;
                try
                {
                    colorToUse = GetColorOfWarpDestinationValidationResult(warp);
                }
                catch (Exception ex)
                {
                    colorToUse = default;
                }

                foreach (ListViewItem.ListViewSubItem subitem in lvi.SubItems)
                    subitem.ForeColor = colorToUse;
            }
            else if (iwarp is ManagedInstantWarp)
            {
                ManagedInstantWarp warp = (ManagedInstantWarp)iwarp;
                lvi.SubItems[0].Text = string.Empty;
                lvi.SubItems[1].Text = Conversions.ToString(TextValueConverter.ValueFromText(Conversions.ToString(warp.CollisionType)));
                lvi.SubItems[2].Text = Conversions.ToString(TextValueConverter.ValueFromText(Conversions.ToString(warp.DestAreaID)));
                lvi.SubItems[3].Text = string.Empty;
            }
        }

        internal void SetObjectPropertiesToListViewItem(ref ListViewItem lvi, Managed3DObject obj, int objIndex = -1)
        {
            if (objIndex > -1)
                lvi.SubItems[0].Text = Conversions.ToString(objIndex + 1);
            var combo = AllObjectCombos.GetObjectComboOfObject(obj);
            string txt = "";
            if (combo is null || combo == ObjectComboList.UnknownCombo)
            {
                txt = TextValueConverter.TextFromValue(obj.BehaviorID) + " - " + TextValueConverter.TextFromValue(obj.ModelID);
            }
            else
            {
                txt = combo.Name;
            }

            lvi.SubItems[1].Text = txt;
        }

        internal string WarpIDToString(byte id)
        {
            switch (id)
            {
                case 241:
                    {
                        return "Failure";
                    }

                case 240:
                    {
                        return "Success";
                    }

                default:
                    {
                        return TextValueConverter.TextFromValue(id);
                    }
            }
        }

        internal void DeselectAllListViewItems(ListViewEx ListView)
        {
            ListView.SuspendLayout();
            foreach (ListViewItem item in ListView.Items)
            {
                item.Focused = false;
                item.Selected = false;
            }

            ListView.ResumeLayout();
        }

        internal void ListViewEx_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                var withBlock = Timer_ListViewEx_Objects_SelectionChanged;
                if (withBlock.Enabled)
                {
                    withBlock.Stop();
                }

                withBlock.Start();
            }
        }

        internal void Timer_ListViewEx_Objects_SelectionChanged_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!loadingObj && SelectedObject is object)
            {
                SelectObjects(SelectedObjects);
                ShowObjectProperties();
                if (objectControlling.WasInOrbitMode)
                    ogl.SetCameraMode(CameraMode.ORBIT);
            }

            PanelDockContainer10.DockContainerItem.Selected = true;
        }

        internal void ListViewEx_Warps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndexes = ListViewEx_Warps.SelectedIndices;
            if (selectedIndexes.Count > 0)
            {
                ShowWarpProterties();
                PanelDockContainer10.DockContainerItem.Selected = true;
            }
        }

        internal Managed3DObject SelectedObject
        {
            get
            {
                if (ListViewEx_Objects.SelectedIndices.Count == 0)
                    return null;
                return (Managed3DObject)ListViewEx_Objects.SelectedItems[0].Tag;
            }
        }

        internal Managed3DObject[] SelectedObjects
        {
            get
            {
                if (ListViewEx_Objects.SelectedIndices.Count == 0)
                    return Array.Empty<Managed3DObject>();
                var objs = new List<Managed3DObject>();
                foreach (ListViewItem item in ListViewEx_Objects.SelectedItems)
                    objs.Add((Managed3DObject)item.Tag);
                return objs.ToArray();
            }
        }

        internal void SelectObject(Managed3DObject obj, bool DeselectAllObjects = true)
        {
            SelectObjects(new[] { obj }, DeselectAllObjects);
        }

        internal void SelectObjects(Managed3DObject[] objs, bool DeselectAllObjects = true)
        {
            if (DeselectAllObjects)
                this.DeselectAllObjects(false);

            foreach (Managed3DObject obj in objs)
            {
                if (obj is object)
                    obj.IsSelected = true;
            }

            ogl.UpdateOrbitCamera();
            ogl.Invalidate();
            ogl.Update();
        }

        internal void DeselectAllObjects(bool UpdateGLAndCamera = true)
        {
            foreach (Managed3DObject obj in ManagedObjects)
                obj.IsSelected = false;

            if (UpdateGLAndCamera)
            {
                ogl.UpdateOrbitCamera();
                ogl.Invalidate();
                ogl.Update();
            }
        }

        internal void ToogleObjectSelection(Managed3DObject obj)
        {
            obj.IsSelected = !obj.IsSelected;
            {
                var withBlock = ListViewEx_Objects.Items[ManagedObjects.IndexOf(obj)];
                withBlock.Selected = !withBlock.Selected;
            }

            ogl.UpdateOrbitCamera();
            ogl.Invalidate();
            ogl.Update();
        }

        internal IManagedLevelscriptCommand SelectedWarp
        {
            get
            {
                if (ListViewEx_Warps.SelectedIndices.Count == 0)
                    return null;
                return (IManagedLevelscriptCommand)ListViewEx_Warps.SelectedItems[0].Tag;
            }
        }

        internal IManagedLevelscriptCommand[] SelectedWarps
        {
            get
            {
                if (ListViewEx_Warps.SelectedIndices.Count == 0)
                    return Array.Empty<IManagedLevelscriptCommand>();
                var objs = new List<IManagedLevelscriptCommand>();
                foreach (ListViewItem item in ListViewEx_Warps.SelectedItems)
                    objs.Add((IManagedLevelscriptCommand)item.Tag);
                return objs.ToArray();
            }
        }

        internal void DeselectAllFaces(bool UpdateGLAndCamera = true)
        {
            foreach (Face f in maps.rndrCollisionMap.SelectedElements.OfType<Face>())
                maps.rndrCollisionMap.SelectedElements.Remove(f);
            if (UpdateGLAndCamera)
            {
                ogl.UpdateOrbitCamera();
                ogl.Invalidate();
                ogl.Update();
            }
        }

        internal void ListViewEx_Objects_Click(object sender, EventArgs e)
        {
            SelectedList = (ListViewEx)sender;
        }

        internal bool EditObjects
        {
            get
            {
                return SelectedList == ListViewEx_Objects;
            }
        }

        internal bool EditWarps
        {
            get
            {
                return SelectedList == ListViewEx_Warps;
            }
        }

        internal bool EditWarpsDefault
        {
            get
            {
                return ListViewEx_Warps.SelectedIndices.Count > 0 && IsGroupWarpDefault(ListViewEx_Warps.SelectedItems[0]);
            }
        }

        internal bool IsGroupWarpDefault(ListViewItem item)
        {
            return item.Group == lvg_ConnectedWarps;
        }

        internal bool EditWarpsForGame
        {
            get
            {
                return ListViewEx_Warps.SelectedIndices.Count > 0 && IsGroupWarpForGame(ListViewEx_Warps.SelectedItems[0]);
            }
        }

        internal bool IsGroupWarpForGame(ListViewItem item)
        {
            return item.Group == lvg_WarpsForGame;
        }

        internal void ListViewEx_Objects_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ButtonItem_CM_Objects.Popup(Cursor.Position);
            }
        }

        internal void ListViewEx_Warps_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ButtonItem1_CM_Warps.Popup(Cursor.Position);
            }
        }

        internal void LoadSpecailBoxList()
        {
            ManagedSpecialBoxes.Clear();
            foreach (SpecialBox sp in CArea.SpecialBoxes)
            {
                var msp = new ManagedSpecialBox(sp);
                ManagedSpecialBoxes.Add(msp);
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void SwitchCurrentArea()
        {
            if (!isLoadingAreaIDs)
            {
                if (!dicHistories.ContainsKey(CArea))
                {
                    var hs = new HistoryStack();
                    dicHistories.Add(CArea, hs);
                    history = hs;
                }
                else
                {
                    history = dicHistories[CArea];
                }

                backupCurrentAreaIndex = ComboBoxItem_Area.SelectedIndex;
                SaveAllObjectProperties();
                SaveAllWarpProperties();
                maps.cCollisionMap = null;
                maps.cVisualMap = null;
                maps.LoadAreaModel();
                AreaDisplaylistScriptDumps.AddOrUpdate(CArea.AreaID, lastlyLoadedDisplaylists.Select((n) => n.Script).ToArray());
                LoadObjectLists();
                LoadWarpsLists();
                LoadSpecailBoxList();
                if (Settings.AreaEditor.DefaultCameraMode == CameraMode.ORBIT)
                {
                    ButtonItem_CamOrbit.RaiseClick();
                }
                else
                {
                    ButtonItem_CamFly.RaiseClick();
                }
            }
        }

        internal void ComboBoxEx_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchCurrentArea();
        }

        internal void ButtonItem47_Click(object sender, EventArgs e)
        {
            ButtonItem_ImportModel.RaiseClick();
        }

        internal void ButtonItem_ImportModel_Click(object sender, EventArgs e)
        {
            maps.ImportAreaModel(sender == ButtonItem_ImportModel || sender == ButtonItem_ImportVisualMap, sender == ButtonItem_ImportModel || sender == ButtonItem_ImportCollision || sender == ButtonItem85, General.GetKeyForConvertAreaModel(Rommgr.GameName, Conversions.ToShort(CLevel.LevelID), CArea.AreaID));
        }

        internal void ButtonItem_AddArea_Click(object sender, EventArgs e)
        {
            var newID = Publics.General.GetNextAreaID(CLevel);

            if (newID.isAnyFree)
            {
                var tArea = new RMLevelArea((byte)newID.newID);
                var res = PublicFunctions.GetModelViaModelConverter(false, false, inputsKey: General.GetKeyForConvertAreaModel(Rommgr.GameName, Conversions.ToShort(CLevel.LevelID), (byte)newID.newID));
                if (res is object)
                {
                    tArea.AreaModel = res?.mdl;
                    CLevel.Areas.Add(tArea);
                    AreaIdToLoad = tArea.AreaID;
                    LoadAreaIDs();
                }
            }
            else
                MessageBoxEx.Show(Form_Main_Resources.MsgBox_MaxCountAreasReached, Form_Main_Resources.MsgBox_MaxCountAreasReached_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal void ButtonItem_RemoveArea_Click(object sender, EventArgs e)
        {
            int index = CLevel.Areas.IndexOf(CArea);
            if (index < 0)
                return;
            CLevel.Areas.RemoveAt(index);
            ButtonItem_AddArea.Enabled = true;
            if (CLevel.Areas.Count == 0)
            {
                Close();
            }
            else
            {
                AreaIdToLoad = index < CLevel.Areas.Count ? CLevel.Areas[index].AreaID : CLevel.Areas.Last().AreaID;
                LoadAreaIDs();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void SomeButtonItems_Click(object sender, EventArgs e)
        {
            // Application.DoEvents()
            ogl?.Invalidate();
        }

        internal void ButtonItem_DrawBackfaces_CheckChanged(object sender, EventArgs e)
        {
            if (((CheckBoxItem)sender).Checked)
            {
                GL.Disable(EnableCap.CullFace);
            }
            else
            {
                GL.Enable(EnableCap.CullFace);
            }
        }

        internal void ViewModeButtonItems_CheckChanged(object sender, EventArgs e)
        {
            if (((CheckBoxItem)sender).Checked)
            {
                foreach (CheckBoxItem btn in new[] { ButtonItem_ViewVisualMap, ButtonItem_ViewColMap })
                {
                    if (btn != sender)
                        btn.Checked = false;
                }

                if (sender == ButtonItem_ViewColMap)
                {
                    ButtonItem_DrawOutline.Checked = true;
                }

                if (CLevel is object && CArea is object)
                    maps.LoadAreaModel();
                ogl?.Invalidate();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem84_Click(object sender, EventArgs e)
        {
            var selobj = SelectedObject;
            SetDefaultPosition(selobj.Position, selobj.Rotation.Y);
        }

        internal void SetDefaultPosition(System.Numerics.Vector3 pos, float rotY)
        {
            var cmd2D = CLevel.GetDefaultPositionCmd();
            clDefaultPosition.SetPosition(cmd2D, pos);
            clDefaultPosition.SetRotation(cmd2D, Conversions.ToShort(rotY));
            clDefaultPosition.SetAreaID(cmd2D, CArea.AreaID);
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void SetObjectsToPropertyGrid(object[] objs)
        {
            AdvPropertyGrid1.SuspendLayout();
            AdvPropertyGrid1.SelectedObjects = objs;
            AdvPropertyGrid1.UpdateAmbientColors();
            AdvPropertyGrid1.ResumeLayout();
            UpdateBParamNames();
            AdvPropertyGrid1_RefreshPropertyValues();
        }

        internal void ShowObjectProperties()
        {
            SetObjectsToPropertyGrid(SelectedObjects);

            // If SelectedObject Is Nothing Then Return
            // loadingObj = True
            // Panel_ObjectSettings.SuspendLayout()

            // 'Selected Object
            // Dim sObj = SelectedObject

            // 'Acts
            // SetEnableStateOnStarSymbolBox(SymbolBox_Act1, sObj.Act1)
            // SetEnableStateOnStarSymbolBox(SymbolBox_Act2, sObj.Act2)
            // SetEnableStateOnStarSymbolBox(SymbolBox_Act3, sObj.Act3)
            // SetEnableStateOnStarSymbolBox(SymbolBox_Act4, sObj.Act4)
            // SetEnableStateOnStarSymbolBox(SymbolBox_Act5, sObj.Act5)
            // SetEnableStateOnStarSymbolBox(SymbolBox_Act6, sObj.Act6)
            // CheckAllActs()

            // 'Position
            // IntegerInput_ObjPosX.Value = sObj.Position.X
            // IntegerInput_ObjPosY.Value = sObj.Position.Y
            // IntegerInput_ObjPosZ.Value = sObj.Position.Z

            // 'Rotation
            // IntegerInput_ObjRotX.Value = sObj.Rotation.X
            // IntegerInput_ObjRotY.Value = sObj.Rotation.Y
            // IntegerInput_ObjRotZ.Value = sObj.Rotation.Z

            // 'Model-ID
            // ComboBoxEx_ObjModelID.Text = TextFromValue(sObj.ModelID)

            // 'Behavior-ID
            // ComboBoxEx_ObjBehavID.Text = TextFromValue(sObj.BehaviorID, If(Settings.General.IntegerValueMode >= 1, Settings.General.IntegerValueMode, 1))

            // 'B. Params
            // ComboBoxEx_ObjBParam1.Text = TextFromValue(sObj.BParam1)
            // ComboBoxEx_ObjBParam2.Text = TextFromValue(sObj.BParam2)
            // ComboBoxEx_ObjBParam3.Text = TextFromValue(sObj.BParam3)
            // ComboBoxEx_ObjBParam4.Text = TextFromValue(sObj.BParam4)

            // 'Object Combo
            // Dim objCombo As ObjectCombo  = myObjectCombos.GetObjectComboOfObject(sObj)
            // ComboBoxEx_ObjCombo.SelectedIndex = myObjectCombos.IndexOf(objCombo)

            // 'B. Param Infos
            // LoadBParamInfo(objCombo)

            // 'B. Param ComboBox Lists
            // ReloadBParamComboBoxes()

            // Panel_ObjectSettings.ResumeLayout()
            // loadingObj = False
        }

        internal void UpdateObjectListViewItems()
        {
            if (ListViewEx_Objects.Items.Count > 0)
            {
                int cIndex = 0;
                foreach (ListViewItem feitem in ListViewEx_Objects.Items)
                {
                    var item = feitem;
                    SetObjectPropertiesToListViewItem(ref item, ManagedObjects[ListViewEx_Objects.Items.IndexOf(item)], cIndex);
                    cIndex += 1;
                }
            }
        }

        internal void SaveAllObjectProperties()
        {
            foreach (Managed3DObject obj in ManagedObjects)
                obj.SaveProperties();
        }

        internal void SaveSelectedObjectProperties()
        {
            foreach (Managed3DObject obj in SelectedObjects)
                obj.SaveProperties();
        }

        internal void ButtonItem_CopyObjCmdAsHex_Click(object sender, EventArgs e)
        {
            var bytes = new List<byte>();
            string txt = "";
            foreach (object obj in AdvPropertyGrid1.SelectedObjects)
            {
                var prop = obj.GetType().GetProperty("Command");
                if (prop is object)
                {
                    bytes.AddRange(((LevelscriptCommand)prop.GetValue(obj)).ToArray());
                }
            }

            foreach (byte b in bytes)
                txt += " " + b.ToString("X2");
            Clipboard.SetText(txt.TrimStart(' '));
        }

        internal void ButtonItem_ObjectsEditorCmd_Click(object sender, EventArgs e)
        {
            var cmd = SelectedObject?.Command;
            if (cmd is object)
            {
                General.OpenHexEditor(cmd);
            }
        }

        internal void ButtonItem33_Click(object sender, EventArgs e)
        {
            var obj = SelectedObject;
            bool exists = false;
            foreach (ObjectCombo objCombo in General.ObjectCombos.Concat(General.ObjectCombosCustom))
            {
                if (obj.ModelID == objCombo.ModelID && obj.BehaviorID == objCombo.BehaviorAddress)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                // MessageBoxEx.Show("There already exists at least one object combo with the same Model ID and the same Behavior Address.", "Duplicate Object Combos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Publics.General.ShowToastnotification(Panel_GLControl, "An object combo with the same Model ID and Behavior Address already exists!", eToastGlowColor.Green, 12000);
            }
            else
            {
                var dialog = new StringInputDialog();
                dialog.Titel = "New Object Combo Name";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var combo = new ObjectCombo();
                    combo.BehaviorAddress = obj.BehaviorID;
                    combo.ModelID = obj.ModelID;
                    combo.Name = dialog.Value.Trim();
                    General.ObjectCombosCustom.Add(combo);
                    General.SaveObjectCombos();
                    // MessageBoxEx.Show("Object Combo has been added successfully.<br/>The Object Combo will appear in the object combo list after you re-opend the Level Editor.", "Object Combo added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Publics.General.ShowToastnotification(Panel_GLControl, "Object Combo has been added successfully.<br/>The Object Combo will appear in the Object Combo list after you re-open the Level Editor.", eToastGlowColor.Green, 12000);
                }
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void Slider_ObjMoveSpeed_ValueChanged(object sender, EventArgs e)
        {
            Slider_ObjMoveSpeed.Text = $"Object Move Speed: {Slider_ObjMoveSpeed.Value}%";
        }

        internal void PictureBox_ObjCntr_MouseDown(object sender, MouseEventArgs e)
        {
            isObjMoving = true;
        }

        internal void PictureBox_ObjCntr_MouseUp(object sender, EventArgs e)
        {
            isObjMoving = false;
        }

        internal void ChangeCamMode(object sender, EventArgs e)
        {
            switch (true)
            {
                case object _ when sender.Equals(ButtonItem_CamFly):
                    {
                        ogl.SetCameraMode(CameraMode.FLY);
                        break;
                    }

                case object _ when sender.Equals(ButtonItem_CamOrbit):
                    {
                        ogl.SetCameraMode(CameraMode.ORBIT);
                        break;
                    }

                case object _ when sender.Equals(ButtonItem_CamTop):
                    {
                        ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Top);
                        break;
                    }

                case object _ when sender.Equals(ButtonItem_CamButtom):
                    {
                        ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Bottom);
                        break;
                    }

                case object _ when sender.Equals(ButtonItem_CamFront):
                    {
                        ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Front);
                        break;
                    }

                case object _ when sender.Equals(ButtonItem_CamLeft):
                    {
                        ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Left);
                        break;
                    }

                case object _ when sender.Equals(ButtonItem_CamRight):
                    {
                        ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Right);
                        break;
                    }

                case object _ when sender.Equals(ButtonItem_CamBack):
                    {
                        ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Back);
                        break;
                    }
            }

            ButtonX_CamMode.Text = Conversions.ToString(((BaseItem)sender).Text);
        }

        internal void Slider_CamMoveSpeed_ValueChanged(object sender, EventArgs e)
        {
            int camSpeed = Slider_CamMoveSpeed.Value;
            var cam = Camera;
            if (cam is object)
            {
                cam.CamSpeedMultiplier = (float)(camSpeed / (double)100);
            }

            Slider_CamMoveSpeed.Text = $"Camera Move Speed: {Slider_CamMoveSpeed.Value}%";
        }

        internal void ButtonX_SetObjMoveSpeed(object sender, EventArgs e)
        {
            Slider_ObjMoveSpeed.Value = Conversions.ToInteger(((ButtonX)sender).Text.Replace("%", ""));
        }

        internal void ButtonX_SetCamMoveSpeed(object sender, EventArgs e)
        {
            Slider_CamMoveSpeed.Value = Conversions.ToInteger(((ButtonX)sender).Text.Replace("%", ""));
        }

        internal void KeepObjectsOnGround()
        {
            switch (true)
            {
                case object _ when KeepObjectsOnNearestGround:
                    {
                        DropObjectsToGround(0);
                        break;
                    }

                case object _ when KeepObjectsOnTop:
                    {
                        DropObjectsToGround(1);
                        break;
                    }

                case object _ when KeepObjectsOnButtom:
                    {
                        DropObjectsToGround(2);
                        break;
                    }
            }
        }

        internal void DropObjectsToGround(byte mode)
        {
            if (EditObjects)
            {
                foreach (Managed3DObject obj in SelectedObjects)
                {
                    var oldPos = obj.Position;
                    float newY = oldPos.Y;
                    switch (mode)
                    {
                        case 0:
                            {
                                newY = CArea.AreaModel.Collision.DropToNearesGround(oldPos);
                                break;
                            }

                        case 1:
                            {
                                newY = CArea.AreaModel.Collision.DropToTop(oldPos);
                                break;
                            }

                        case 2:
                            {
                                newY = CArea.AreaModel.Collision.DropToButtom(oldPos);
                                break;
                            }
                    }

                    var newPos = new System.Numerics.Vector3(oldPos.X, newY, oldPos.Z);
                    obj.Position = newPos;
                    AdvPropertyGrid1_RefreshPropertyValues();
                }

                ogl.UpdateOrbitCamera();
                ogl.Invalidate();
            }
        }

        internal void IntegerInput_ObjRotX_Click(object sender, EventArgs e)
        {
            waitUntilLostFocus = false;
        }

        internal void IntegerInput_ObjRotX_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                waitUntilLostFocus = false;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void PictureBox_ObjRot_MouseDown(object sender, MouseEventArgs e)
        {
            isObjRotating = true;
        }

        internal void PictureBox_ObjRot_MouseUp(object sender, MouseEventArgs e)
        {
            isObjRotating = false;
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void CheckObjCombo()
        {
            var objcombo = MyObjectCombos.FirstOrDefault(n => n.ModelID == SelectedObject.ModelID && n.BehaviorAddress == SelectedObject.BehaviorID);
            if (objcombo is null)
                return;
            foreach (int index in ListViewEx_Objects.SelectedIndices)
                ListViewEx_Objects.Items[index].SubItems[1].Text = objcombo.Name;
        }

        internal void ChangeObjectComboWithDialog()
        {
            var objs = SelectedObjects;
            if (objs.Any())
            {
                var dialog = new InformationListDialog(InformationListDialog.EditModes.EnableObjComboTab, MyObjectCombos, null);
                dialog.SelectedObjectCombo = MyObjectCombos.GetObjectComboOfObject(objs.First());
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Store History Point
                    StoreObjectHistoryPoint(objs, nameof(Managed3DObject.ModelID), nameof(Managed3DObject.BehaviorID));

                    // Change Object Combo by Name
                    foreach (Managed3DObject obj in SelectedObjects)
                        obj.ObjectCombo = dialog.SelectedObjectCombo;

                    UpdateObjectListViewItems();
                    ShowObjectProperties();
                }
            }
        }

        internal void ChangeBehaviorWithDialog()
        {
            var objs = SelectedObjects;
            if (objs.Any())
            {
                var dialog = new InformationListDialog(InformationListDialog.EditModes.EnableBehavTab, null, MyBehaviorInfos);
                dialog.SelectedBehavior = MyBehaviorInfos.GetByBehaviorAddress(objs.First().BehaviorID);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Store History Point
                    StoreObjectHistoryPoint(objs, nameof(Managed3DObject.BehaviorID));

                    // Change Object Combo by Name
                    foreach (Managed3DObject obj in SelectedObjects)
                        obj.BehaviorID = dialog.SelectedBehavior.BehaviorAddress;

                    UpdateObjectListViewItems();
                    ShowObjectProperties();
                }
            }
        }

        internal void ButtonItem_ChangeObjectCombo_Click(object sender, EventArgs e)
        {
            ChangeObjectComboWithDialog();
        }

        internal void ButtonItem30_Click(object sender, EventArgs e)
        {
            ChangeBehaviorWithDialog();
        }

        internal void RibbonBar27_DialogLauncherMouseDown(object sender, MouseEventArgs e)
        {
            var dialog = new InformationListDialog(InformationListDialog.EditModes.Editable | InformationListDialog.EditModes.EnableBehavTab | InformationListDialog.EditModes.EnableObjComboTab);
            dialog.ShowDialog();

            // Reload Lists ...
            // ...
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonX_ObjectsAdd_Click(object sender, EventArgs e)
        {
            var newobjects = new List<Managed3DObject>();
            var newlvis = new List<ListViewItem>();
            int objcount = 0;

            if (!int.TryParse(((BaseItem)sender).Text, out objcount))
                objcount = 1;

            for (int i = 1, loopTo = objcount; i <= loopTo; i++)
            {
                var newObjCmd = new LevelscriptCommand(LevelArea.DefaultNormal3DObject);
                CArea.Objects.Add(newObjCmd);
                var newObj = new Managed3DObject(newObjCmd, AllObjectCombos);
                ManagedObjects.Add(newObj);
                newobjects.Add(newObj);
                var lvi = new ListViewItem();
                lvi.Tag = newObj;
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem());
                SetObjectPropertiesToListViewItem(ref lvi, newObj, ListViewEx_Objects.Items.Count);
                ListViewEx_Objects.Items.Add(lvi);
                newlvis.Add(lvi);
            }

            // Store History Point
            this.StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes["RemoveObjects"], AreaEditorHistoryFunctions.Methodes["AddObjects"], new object[] { CArea, ManagedObjects, newobjects, ListViewEx_Objects.Items, newlvis });
            ogl.Invalidate();

            if (newlvis.Any())
                SelectItemsInList(ListViewEx_Objects, newlvis.ToArray(), true);
        }
        
        internal void ResetObjToDefault(object sender, EventArgs e)
        {
            var oldObjects = new List<Managed3DObject>();
            var newObjects = new List<Managed3DObject>();
            var indicies = new List<int>();
            foreach (int index in ListViewEx_Objects.SelectedIndices)
            {
                var newObj = new LevelscriptCommand(LevelArea.DefaultNormal3DObject);
                var new3DObj = new Managed3DObject(newObj, AllObjectCombos);
                CArea.Objects[index] = newObj;
                ManagedObjects[index] = new3DObj;
                oldObjects.Add(ManagedObjects[index]);
                newObjects.Add(new3DObj);
                indicies.Add(index);
            }

            // Store History Point
            this.StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes["RevertObjects"], AreaEditorHistoryFunctions.Methodes["RevertObjects"], new object[] { CArea, ManagedObjects, indicies, oldObjects }, new object[] { CArea, ManagedObjects, indicies, newObjects });
            UpdateObjectListViewItems();
            ShowObjectProperties();
        }

        internal void RemoveSelectedObjects(object sender, EventArgs e)
        {
            if (SelectedObject is object)
            {
                var indices = new int[ListViewEx_Objects.SelectedIndices.Count];
                ListViewEx_Objects.SelectedIndices.CopyTo(indices, 0);
                RemoveObjects(indices);
            }
        }

        internal void RemoveAllEmptyObjects(object sender, EventArgs e)
        {
            RemoveAllObjectsWhere(mobj => mobj.BehaviorID == (long)0x13000000 && mobj.ModelID == 0);
        }

        internal void RemoveAllUnusedObjects(object sender, EventArgs e)
        {
            RemoveAllObjectsWhere(mobj => !(mobj.Act1 | mobj.Act2 | mobj.Act3 | mobj.Act4 | mobj.Act5 | mobj.Act6));
        }

        internal void RemoveAllObjectsWhere(RemoveAllObjectsWhereExpression func)
        {
            var indices = new List<int>();
            for (int i = 0, loopTo = CArea.Objects.Count - 1; i <= loopTo; i++)
            {
                var mobj = ManagedObjects[i];
                if (func.Invoke(mobj))
                {
                    indices.Add(i);
                }
            }

            if (indices.Any())
            {
                RemoveObjects(indices.ToArray());
            }
        }

        internal void RemoveObjects(int[] indices)
        {
            var removedObjs = new Dictionary<int, Managed3DObject>();
            var removedlvis = new Dictionary<int, ListViewItem>();
            var removedCmds = new Dictionary<int, LevelscriptCommand>();
            foreach (int index in indices.OrderByDescending(n => n))
            {
                var mobj = ManagedObjects[index];
                var lvi = ListViewEx_Objects.Items[index];
                ManagedObjects.Remove(mobj);
                CArea.Objects.RemoveAt(index);
                ListViewEx_Objects.Items.Remove(lvi);
                removedObjs.Add(index, mobj);
                removedCmds.Add(index, mobj.Command);
                removedlvis.Add(index, lvi);
            }

            // Store History Point
            this.StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes["InsertObjects"], AreaEditorHistoryFunctions.Methodes["RemoveAtObjects"], new object[] { CArea, ManagedObjects, ListViewEx_Objects.Items, removedObjs, removedlvis, removedCmds });
            UpdateObjectListViewItems();
            ogl.Invalidate();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem23_Click(object sender, EventArgs e)
        {
            byte modelID = SelectedObject.ModelID;
            if (ObjectModels.ContainsKey(modelID))
            {
                Publics.Publics.ExportModel(ObjectModels[modelID].Model, Settings.FileParser.FileExporterModule);
            }
            else
            {
                MessageBoxEx.Show("The Model wasn't found.", "Export Object Model", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ShowWarpProterties()
        {
            SetObjectsToPropertyGrid(SelectedWarps);
        }

        internal void UpdateWarpListViewItem()
        {
            if (ListViewEx_Warps.SelectedItems.Count > 0)
            {
                foreach (ListViewItem feitem in ListViewEx_Warps.SelectedItems)
                {
                    var item = feitem;
                    if (item.Selected)
                    {
                        IManagedLevelscriptCommand cWarp = (IManagedLevelscriptCommand)item.Tag;
                        SetWarpPropertiesToListViewItem(ref item, cWarp);
                    }
                }
            }
        }

        internal void SaveAllWarpProperties()
        {
            foreach (IManagedLevelscriptCommand warp in ManagedWarps)
                warp.SaveProperties();
        }

        internal void SaveSelectedWarpProperties()
        {
            foreach (IManagedLevelscriptCommand warp in SelectedWarps)
                warp.SaveProperties();
        }

        internal void ButtonX_WarpsEditCmd_Click(object sender, EventArgs e)
        {
            var cmd = SelectedWarp?.Command;
            if (cmd is object)
            {
                General.OpenHexEditor(cmd);
            }
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal WarpDestinationValidationResult IsWarpDestinationValid(ManagedWarp warp)
        {
            var myWarpObjCombos = MyObjectCombos.Where(n => n.Name.ToLower().Contains("warp")).ToArray();
            byte found = 0;
            bool foundLevel = false;

            // For Each obj As Managed3DObject In managedObjects
            // If myWarpObjCombos.Where(Function(n) n.BehaviorID = obj.BehaviorID).Count > 0 _
            // AndAlso obj.BParam2 = warp.DestWarpID Then
            // found += 1
            // End If
            // If found = 0 Then
            // Return WarpDestinationValidationResult.WarpSourceNotFound
            // ElseIf found > 1 Then
            // Return WarpDestinationValidationResult.WarpSourceUsedMultipleTimes
            // Else
            // foundLevel = True
            // Exit For
            // End If
            // Next

            // If found = 0 Then
            // For Each level As Level In rommgr.Levels
            // If Not foundLevel AndAlso level IsNot cLevel Then
            // For Each area As LevelArea In level.Areas
            // For Each obj As LevelscriptCommand In area.Objects
            // Dim behavID As Integer = clNormal3DObject.GetSegBehaviorAddr(obj)
            // If myWarpObjCombos.Where(Function(n) n.BehaviorID = behavID).Count > 0 _
            // AndAlso clNormal3DObject.GetParams(obj).BParam2 = warp.DestWarpID Then
            // found += 1
            // End If
            // Next
            // If found = 0 Then
            // Return WarpDestinationValidationResult.WarpSourceNotFound
            // ElseIf found > 1 Then
            // Return WarpDestinationValidationResult.WarpSourceUsedMultipleTimes
            // Else
            // foundLevel = True
            // Exit For
            // End If
            // Next
            // End If
            // Next
            // End If

            var lvl = Rommgr.Levels.FirstOrDefault(n => n.LevelID == (ushort)warp.DestLevelID);
            if (lvl is object)
            {
                foreach (LevelArea area in lvl.Areas)
                {
                    if (area.AreaID == warp.DestAreaID)
                    {
                        found = 0;
                        foreach (LevelscriptCommand cmd in area.Warps)
                        {
                            if (clWarp.GetWarpID(cmd) == warp.DestWarpID)
                            {
                                found += 1;
                            }
                        }

                        if (found == 0)
                        {
                            return WarpDestinationValidationResult.WarpDestNotFound;
                        }
                        else if (found == 1)
                        {
                            found = 0;
                            if (lvl == CLevel)
                            {
                                foreach (Managed3DObject obj in ManagedObjects)
                                {
                                    if (myWarpObjCombos.Where(n => n.BehaviorAddress == obj.BehaviorID).Count() > 0 && obj.BParam2 == warp.DestWarpID)
                                    {
                                        found += 1;
                                    }
                                }
                            }
                            else
                            {
                                foreach (LevelscriptCommand obj in area.Objects)
                                {
                                    int behavID = Conversions.ToInteger(clNormal3DObject.GetSegBehaviorAddr(obj));
                                    if (myWarpObjCombos.Where(n => n.BehaviorAddress == behavID).Count() > 0 && clNormal3DObject.GetParams(obj).BParam2 == warp.DestWarpID)
                                    {
                                        found += 1;
                                    }
                                }
                            }

                            if (found == 0)
                            {
                                return WarpDestinationValidationResult.WarpDestNotUsed;
                            }
                            else if (found == 1)
                            {
                                return WarpDestinationValidationResult.WarpFoundInCustomLevel;
                            }
                            else
                            {
                                return WarpDestinationValidationResult.WarpDestUsedMultipleTimes;
                            }
                        }
                        else
                        {
                            return WarpDestinationValidationResult.DuplicatedWarpIDsAtDestination;
                        }
                    }
                }

                return WarpDestinationValidationResult.AreaNotFound;
            }
            else
            {
                return WarpDestinationValidationResult.LevelNotFound;
            }
        }

        internal Color GetColorOfWarpDestinationValidationResult(IManagedLevelscriptCommand warp)
        {
            if ((new[] { LevelscriptCommandTypes.PaintingWarp, LevelscriptCommandTypes.ConnectedWarp }).Contains(warp.Command.CommandType))
            {
                var switchExpr = IsWarpDestinationValid((ManagedWarp)warp);
                switch (switchExpr)
                {
                    case WarpDestinationValidationResult.DuplicatedWarpIDsAtDestination:
                    case WarpDestinationValidationResult.WarpDestUsedMultipleTimes:
                    case WarpDestinationValidationResult.WarpSourceUsedMultipleTimes:
                        {
                            return Color.FromArgb(-4754112);
                        }

                    case WarpDestinationValidationResult.WarpFoundInCustomLevel:
                        {
                            return Color.FromArgb(-9073592);
                        }

                    case WarpDestinationValidationResult.AreaNotFound:
                    case WarpDestinationValidationResult.WarpDestNotFound:
                    case WarpDestinationValidationResult.WarpDestNotUsed:
                        {
                            return Color.FromArgb(-7324615);
                        }
                }
            }

            return default;
        }

        internal enum WarpDestinationValidationResult
        {
            WarpFoundInCustomLevel,
            DuplicatedWarpIDsAtDestination,
            LevelNotFound,
            AreaNotFound,
            WarpDestNotFound,
            WarpDestNotUsed,
            WarpDestUsedMultipleTimes,
            WarpSourceUsedMultipleTimes,
            WarpSourceNotFound
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonX_WarpsAddConnectedWarp_Click(object sender, EventArgs e)
        {
            AddWarps(1, LevelscriptCommandTypes.ConnectedWarp);
        }

        internal void ButtonX_WarpsAddPaintingWarp_Click(object sender, EventArgs e)
        {
            AddWarps(1, LevelscriptCommandTypes.PaintingWarp);
        }

        internal void ButtonItem_WarpsAddInstantWarp_Click(object sender, EventArgs e)
        {
            AddWarps(1, LevelscriptCommandTypes.InstantWarp);
        }

        internal void AddWarps(int count, LevelscriptCommandTypes type)
        {
            if (WarpTools.GetWarpsCountInLevel(CLevel) >= byte.MaxValue)
            {
                Publics.General.ShowToastnotification(Panel_GLControl, "The maximum amount of warps per level has been reached. It is not possible to add more warps.", eToastGlowColor.Red);
            }
            else
            {
                LevelscriptCommand newWarp = null;
                IManagedLevelscriptCommand newManagedWarp = null;
                var lvi = new ListViewItem();

                for (int i = 2; i <= 4; i++)
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem());

                switch (type)
                {
                    case LevelscriptCommandTypes.ConnectedWarp:
                        {
                            newWarp = new LevelscriptCommand(new byte[] { 0x26, 0x8, WarpTools.GetNextUnusedWarpID(CArea), LevelID, CArea.AreaID, 0x0, 0x0, 0x0 });
                            newManagedWarp = new ManagedWarp(newWarp);
                            lvi.Group = lvg_ConnectedWarps;
                            break;
                        }

                    case LevelscriptCommandTypes.PaintingWarp:
                        {
                            newWarp = new LevelscriptCommand(new byte[] { 0x27, 0x8, WarpTools.GetNextUnusedWarpID(CArea), LevelID, CArea.AreaID, 0x0, 0x0, 0x0 });
                            newManagedWarp = new ManagedWarp(newWarp);
                            lvi.Group = lvg_PaintingWarps;
                            break;
                        }

                    case LevelscriptCommandTypes.InstantWarp:
                        {
                            newWarp = new LevelscriptCommand(new byte[] { 0x28, 0xC, 0x1B, CArea.AreaID, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 });
                            newManagedWarp = new ManagedInstantWarp(newWarp);
                            lvi.Group = lvg_InstantWarps;
                            break;
                        }

                    default:
                        {
                            return;
                        }
                }

                // Set managed warp as Tag of ListViewItem
                lvi.Tag = newManagedWarp;
                CArea.Warps.Add(newWarp);
                ManagedWarps.Add(newManagedWarp);
                SetWarpPropertiesToListViewItem(ref lvi, newManagedWarp);
                ListViewEx_Warps.Items.Add(lvi);

                // Store History Point
                var dicGroups = new Dictionary<ListViewItem, ListViewGroup>();
                dicGroups.Add(lvi, lvi.Group);
                this.StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes["RemoveWarps"], AreaEditorHistoryFunctions.Methodes["AddWarps"], new object[] { CArea, ManagedWarps, new[] { newManagedWarp }, ListViewEx_Warps.Items, new[] { lvi }, dicGroups });

                if (newWarp is object)
                    SelectItemsInList(ListViewEx_Warps, new[] { lvi }, true);
            }
        }

        internal void ButtonX_WarpsRemove_Click(object sender, EventArgs e)
        {
            if (SelectedWarp is object)
            {
                var removedWarps = new Dictionary<int, IManagedLevelscriptCommand>();
                var removedlvis = new Dictionary<int, ListViewItem>();
                var removedCmds = new Dictionary<int, LevelscriptCommand>();
                var dicGroups = new Dictionary<ListViewItem, ListViewGroup>();
                var indices = new int[ListViewEx_Warps.SelectedIndices.Count];
                ListViewEx_Warps.SelectedIndices.CopyTo(indices, 0);
                indices = indices.OrderByDescending(n => n).ToArray();
                foreach (int index in indices)
                {
                    var curItem = ListViewEx_Warps.Items[index];
                    if (curItem.Group != lvg_WarpsForGame)
                    {
                        IManagedLevelscriptCommand mwarp = (IManagedLevelscriptCommand)curItem.Tag;
                        var cmd = mwarp.Command;
                        var lvg = curItem.Group;
                        int cmdIndex = CArea.Warps.IndexOf(cmd);
                        int mwarpIndex = ManagedWarps.IndexOf(mwarp);
                        removedWarps.Add(mwarpIndex, mwarp);
                        removedlvis.Add(index, curItem);
                        removedCmds.Add(cmdIndex, cmd);
                        dicGroups.Add(curItem, lvg);
                    }
                }

                foreach (KeyValuePair<int, IManagedLevelscriptCommand> kvp in removedWarps.OrderByDescending(n => n.Key))
                    ManagedWarps.Remove(kvp.Value);
                foreach (KeyValuePair<int, LevelscriptCommand> kvp in removedCmds.OrderBy(n => n.Key))
                    CArea.Warps.Remove(kvp.Value);
                foreach (KeyValuePair<int, ListViewItem> kvp in removedlvis.OrderBy(n => n.Key))
                    ListViewEx_Warps.Items.Remove(kvp.Value);

                // Store History Point
                this.StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes["InsertWarps"], AreaEditorHistoryFunctions.Methodes["RemoveAtWarps"], new object[] { CArea, ManagedWarps, ListViewEx_Warps.Items, removedWarps, removedlvis, removedCmds, dicGroups });
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void SetPauseMenuWarp()
        {
            var warp = SelectedWarp;
            if (warp is object)
            {
                short lid = default, aid = default, wid = default;
                bool err = false;
                if (warp is ManagedWarp)
                {
                    lid = Conversions.ToShort(CLevel.LevelID);
                    aid = CArea.AreaID;
                    wid = ((ManagedWarp)warp).WarpID;
                }
                else
                {
                    err = true;
                }

                if (!err)
                {
                    General.PatchClass.Open(Rommgr.GetBinaryRom(FileAccess.ReadWrite));
                    General.PatchClass.SetPauseMenuWarp(lid, aid, wid);
                    General.PatchClass.Close();
                    General.UpdateChecksum(Rommgr.RomFile);
                    Publics.General.ShowToastnotification(Panel_GLControl, "Pause Menu Warp set successfully", eToastGlowColor.Green);
                }
                else
                {
                    Publics.General.ShowToastnotification(Panel_GLControl, "An error occurred while setting the Pause Menu Warp", eToastGlowColor.Red);
                }
            }
        }

        internal void ButtonItem29_Click(object sender, EventArgs e)
        {
            SetPauseMenuWarp();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private void UpdateBParamNames()
        {
            var obj = SelectedObject;
            if (obj is object)
            {
                var info = MyBehaviorInfos.GetByBehaviorAddress(obj.BehaviorID);
                for (byte i = 1; i <= 4; i++)
                {
                    Node n = AdvPropertyGrid1.GetPropertyNode($"BParam{i}");
                    if (n is object)
                    {
                        BehaviorInfo.BParam param = (BehaviorInfo.BParam)info?.GetValue($"BParam{i}");
                        if (param is object && !string.IsNullOrEmpty(param.Name))
                        {
                            n.Text = param.Name;
                            n.TagString = param.Name;
                        }
                        else
                        {
                            n.Text = $"Behavior Param {i}";
                            n.TagString = n.Text;
                        }
                    }
                }
            }
        }

        internal void AdvPropertyGrid1_PropertyValueChanged(object sender, PropertyChangedEventArgs e)
        {
            var switchExpr = e.PropertyName;
            switch (switchExpr)
            {
                case nameof(Managed3DObject.AllActs):
                case nameof(Managed3DObject.Act1):
                case nameof(Managed3DObject.Act2):
                case nameof(Managed3DObject.Act3):
                case nameof(Managed3DObject.Act4):
                case nameof(Managed3DObject.Act5):
                case nameof(Managed3DObject.Act6):
                    AdvPropertyGrid1_RefreshPropertyValues();
                    break;
                case nameof(Managed3DObject.Rotation):
                case nameof(Managed3DObject.Position):
                    ogl.UpdateOrbitCamera();
                    ogl.Invalidate();
                    break;
                case nameof(Managed3DObject.ObjectComboID):
                case nameof(Managed3DObject.ModelID):
                case nameof(Managed3DObject.BehaviorID):
                    CheckObjCombo();
                    UpdateBParamNames();
                    AdvPropertyGrid1_RefreshPropertyValues();
                    ogl.UpdateOrbitCamera();
                    ogl.Invalidate();
                    break;
            }

            UpdateObjectListViewItems();
            UpdateWarpListViewItem();
            ogl.UpdateOrbitCamera();
            ogl.Invalidate();
        }

        internal void AdvPropertyGrid1_PropertyValueChanging(object sender, PropertyValueChangingEventArgs e)
        {
            lastChangedPropertyName = e.PropertyName;
            var switchExpr = e.PropertyName;
            switch (switchExpr)
            {
                case nameof(Managed3DObject.ObjectComboID):
                case nameof(Managed3DObject.ModelID):
                case nameof(Managed3DObject.BehaviorID):
                    StoreObjectHistoryPoint(AdvPropertyGrid1.SelectedObjects, new[] { "ModelID", "BehaviorID" });
                    break;
                default:
                    StoreObjectHistoryPoint(AdvPropertyGrid1.SelectedObjects, e.PropertyName);
                    break;
            }
        }

        internal void AdvPropertyGrid1_PropertyTree_Paint(object sender, PaintEventArgs e)
        {
            // Property names keep reverting back to their attribute-defined values when the property is selected.
            // This is the ugly workaround
            for (byte i = 1; i <= 4; i++)
            {
                Node n = AdvPropertyGrid1.GetPropertyNode($"BParam{i}");
                if (n is object && !string.IsNullOrEmpty(n.TagString) && (n.TagString ?? "") != (n.Text ?? ""))
                {
                    n.Text = n.TagString;
                }
            }
        }

        internal void ButtonX_CamMode_Click(object sender, EventArgs e)
        {
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem8_Click(object sender, EventArgs e)
        {
            AddDeathFloor(true);
        }

        private void ButtonItem_ButtonItem_AddDeathFloorWithExtBounds_Click(object sender, EventArgs e)
        {
            AddDeathFloor(false);
        }

        internal void ButtonItem4_Click(object sender, EventArgs e)
        {
            RemoveCollisionTrianglesWithCollisionType(0xA);
            maps.ReloadCollisionInOpenGL();
        }

        internal void ButtonItem11_Click(object sender, EventArgs e)
        {
            var input = new ValueInputDialog() { Text = "Remove faces" };
            input.InfoLabel.Text = "Collision type:";
            input.ValueTextBox.Text = Conversions.ToString(0);
            if (input.ShowDialog() == DialogResult.OK)
            {
                short typ = Conversions.ToShort(TextValueConverter.ValueFromText(input.ValueTextBox.Text));
                RemoveCollisionTrianglesWithCollisionType(Conversions.ToByte(typ));
            }
        }

        internal void AddDeathFloor(bool vanillaBounds)
        {
            var input = new Form_SetUpPoint("Death Floor Height", false, true, false, 0, 0, 0);
            if (input.ShowDialog() == DialogResult.OK)
            {
                short height = Conversions.ToShort(input.IntegerInput_Y.Value);
                AddDeathFloorAt(height, vanillaBounds);
            }
        }

        internal void AddDeathFloorAt(short height, bool vanillaBounds)
        {
            // Create vertices
            var v1 = new SM64Lib.Model.Collision.Vertex();
            var v2 = new SM64Lib.Model.Collision.Vertex();
            var v3 = new SM64Lib.Model.Collision.Vertex();
            var v4 = new SM64Lib.Model.Collision.Vertex();

            // Create faces
            var f1 = new SM64Lib.Model.Collision.Triangle();
            var f2 = new SM64Lib.Model.Collision.Triangle();

            // Build faces
            f1.Vertices[0] = v4;
            f1.Vertices[1] = v1;
            f1.Vertices[2] = v2;
            f2.Vertices[0] = v4;
            f2.Vertices[1] = v2;
            f2.Vertices[2] = v3;

            // Set collision to death floor
            f1.CollisionType = 0xA;
            f2.CollisionType = 0xA;

            // Set coordinates to vertices
            var minVal = vanillaBounds ? (short)-8192 : short.MinValue;
            var maxVal = vanillaBounds ? (short)8192 : short.MaxValue;
            v1.X = maxVal;
            v1.Z = maxVal;
            v1.Y = height;
            v2.X = maxVal;
            v2.Z = minVal;
            v2.Y = height;
            v3.X = minVal;
            v3.Z = minVal;
            v3.Y = height;
            v4.X = minVal;
            v4.Z = maxVal;
            v4.Y = height;

            // Create collections
            var vs = new[] { v1, v2, v3, v4 };
            var ts = new[] { f1, f2 };

            // Add vertices
            CArea.AreaModel.Collision.Mesh.Vertices.AddRange(vs);

            // Add faces
            CArea.AreaModel.Collision.Mesh.Triangles.AddRange(ts);

            // Store history point
            this.StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes[nameof(AreaEditorHistoryFunctions.RemoveFromCollision)], AreaEditorHistoryFunctions.Methodes[nameof(AreaEditorHistoryFunctions.AddToCollision)], new object[] { this, CArea.AreaModel.Collision.Mesh.Vertices, vs, CArea.AreaModel.Collision.Mesh.Triangles, ts });
            maps.ReloadCollisionInOpenGL();
        }

        internal bool IsVertexUsedInSM64Collision(SM64Lib.Model.Collision.Vertex v)
        {
            foreach (SM64Lib.Model.Collision.Triangle t in CArea.AreaModel.Collision.Mesh.Triangles)
            {
                foreach (SM64Lib.Model.Collision.Vertex vv in t.Vertices)
                {
                    if (vv == v)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        internal void RemoveCollisionTrianglesWithCollisionType(byte colType)
        {
            var vs = new List<SM64Lib.Model.Collision.Vertex>();
            var ts = new List<SM64Lib.Model.Collision.Triangle>();

            // Remove faces
            foreach (SM64Lib.Model.Collision.Triangle t in CArea.AreaModel.Collision.Mesh.Triangles.ToArray())
            {
                if (t.CollisionType == colType)
                {
                    ts.Add(t);
                    CArea.AreaModel.Collision.Mesh.Triangles.Remove(t);
                }
            }

            // Remove unused vertices
            foreach (SM64Lib.Model.Collision.Triangle t in ts)
            {
                foreach (SM64Lib.Model.Collision.Vertex v in t.Vertices)
                {
                    if (!IsVertexUsedInSM64Collision(v))
                    {
                        vs.Add(v);
                        CArea.AreaModel.Collision.Mesh.Vertices.Remove(v);
                    }
                }
            }

            // Store history point
            if (ts.Any())
            {
                this.StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes[nameof(AreaEditorHistoryFunctions.AddToCollision)], AreaEditorHistoryFunctions.Methodes[nameof(AreaEditorHistoryFunctions.RemoveFromCollision)], new object[] { this, CArea.AreaModel.Collision.Mesh.Vertices, vs.ToArray(), CArea.AreaModel.Collision.Mesh.Triangles, ts.ToArray() });
            }

            maps.ReloadCollisionInOpenGL();
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        internal void ButtonItem34_Click(object sender, EventArgs e)
        {
            // Texture Editor
            OpenTextureEditor();
        }

        private void ButtonItem36_Click(object sender, EventArgs e)
        {
            // Area Model Textures
            // ...
        }

        private void ButtonItem35_Click(object sender, EventArgs e)
        {
            // Object Model Textures
            // ...
        }

        internal IEnumerable<TextureEditor.TextureCategory> LoadOtherTexturesCategories()
        {
            // Load json for other textures
            var categories = new List<TextureEditor.TextureCategory>();
            var catLevelTextures = new TextureEditor.TextureCategory() { Name = "Level Textures" };

            // Read Other Textures
            categories.Add(GetOtherTexturesCategorie(Rommgr));

            // Add all area model textures
            if (maps.cVisualMap is object)
            {
                var block = new TextureEditor.TextureBlock();
                block.Name = "Area Model";
                foreach (var kvp in maps.cVisualMap.Materials)
                {
                    if (kvp.Value.Image is object)
                        block.Textures.Add(kvp.Value);
                }

                catLevelTextures.Blocks.Add(block);
            }

            // Add all other textures
            if (ObjectModels.Any())
            {
                var addedTextureAddresses = new List<int>();
                var block = new TextureEditor.TextureBlock();
                block.Name = "Object Models";
                foreach (var kvpp in ObjectModels)
                {
                    foreach (var kvp in kvpp.Value.Model.Materials)
                    {
                        if (kvp.Value.Image is object)
                        {
                            var info = kvp.Value.Tag as SM64Lib.Model.Conversion.Fast3DParsing.TextureLoadedInfos;
                            var hasInfo = info is object;
                            if (!hasInfo || !addedTextureAddresses.Contains(info.TextureRomAddress))
                            {
                                block.Textures.AddIfNotContains(kvp.Value);
                                if (hasInfo) addedTextureAddresses.Add(info.TextureRomAddress);
                            }
                        }
                    }
                }

                catLevelTextures.Blocks.Add(block);
            }

            if (catLevelTextures.Blocks.Any())
                categories.Add(catLevelTextures);

            return categories;
        }

        internal static TextureEditor.TextureCategory GetOtherTexturesCategorie(SM64Lib.RomManager Rommgr)
        {
            // Load json for other textures
            var ot = JObject.Parse(File.ReadAllText(Path.Combine(Publics.General.MyDataPath, @"Other\Other Textures.json")));
            var jblocks = ot["Blocks"].ToObject<TextureBlocksJsonClass[]>();

            // Read Textures
            var catOtherTextures = new TextureEditor.TextureCategory() { Name = "Other Textures" };
            var data = Rommgr.GetBinaryRom(FileAccess.Read);
            var alreadyLoadedSegs = new Dictionary<byte, SegmentedBank>();
            var alreadyLoadedLevelscripts = new List<int>();
            foreach (TextureBlocksJsonClass jb in jblocks)
            {
                var block = new TextureEditor.TextureBlock();
                block.Name = jb.Name;
                foreach (TextureInfosJsonClass jt in jb.Textures)
                {
                    var m = new Material();
                    int segAddr = Convert.ToInt32(jt.FromSegmentAddress, 16);
                    SegmentedBank seg = null;
                    var bmp = new Bitmap(Conversions.ToInteger(jt.Width), Conversions.ToInteger(jt.Height));
                    N64Codec texFormat = (N64Codec)Enum.Parse(typeof(N64Codec), jt.Format, true);
                    int bytesCount = N64Graphics.PixelsToBytes(texFormat, bmp.Width * bmp.Height);
                    int loadLvlscript = string.IsNullOrEmpty(jt.LoadLvlscript) ? -1 : Convert.ToInt32(jt.LoadLvlscript, 16);
                    byte bankID = Conversions.ToByte(segAddr >> 24);

                    // Get segmented
                    if (loadLvlscript > -1)
                    {
                        if (!alreadyLoadedLevelscripts.Contains(loadLvlscript))
                        {
                            var script = new Levelscript();
                            LevelscriptCommandTypes endcmd;
                            switch (loadLvlscript)
                            {
                                case 0x269EA0:
                                    {
                                        endcmd = LevelscriptCommandTypes.x1D;
                                        break;
                                    }

                                case 0x454AE8:
                                    {
                                        endcmd = LevelscriptCommandTypes.LoadRomToRam;
                                        break;
                                    }

                                default:
                                    {
                                        endcmd = LevelscriptCommandTypes.EndOfLevel;
                                        break;
                                    }
                            }

                            script.Read(Rommgr, loadLvlscript, endcmd, alreadyLoadedSegs, false);
                            alreadyLoadedLevelscripts.Add(loadLvlscript);
                        }

                        if (alreadyLoadedSegs.ContainsKey(bankID))
                        {
                            seg = alreadyLoadedSegs[bankID];
                        }
                    }

                    if (seg is null)
                    {
                        seg = Rommgr.GetSegBank(bankID);
                    }

                    // Read texture data
                    byte[] imgdata;
                    bool isMIO0 = seg?.IsMIO0 == true;
                    if (isMIO0)
                    {
                        seg.ReadDataIfNull(data.BaseStream);
                        seg.Data.Position = seg.BankOffsetFromSegAddr(segAddr);
                        var bindata = new BinaryStreamData(seg.Data);
                        imgdata = bindata.Read(bytesCount);
                    }
                    else
                    {
                        data.Position = seg.SegToRomAddr(segAddr);
                        imgdata = data.Read(bytesCount);
                    }

                    // Render Texture
                    var g = Graphics.FromImage(bmp);
                    N64Graphics.RenderTexture(g, imgdata, null, 0, bmp.Width, bmp.Height, 1, texFormat, N64IMode.AlphaCopyIntensity);

                    // Set image
                    m.Image = bmp;

                    // Set Tag
                    m.Tag = new SM64Lib.Model.Conversion.Fast3DParsing.TextureLoadedInfos(jt.Name, texFormat, segAddr, -1, seg.SegToRomAddr(segAddr), -1, bmp.Size, isMIO0);
                    block.Textures.Add(m);
                }

                catOtherTextures.Blocks.Add(block);
            }

            data.Close();
            return catOtherTextures;
        }

        internal void OpenTextureEditor()
        {
            // Load other textures and create categories
            var otherTextures_Categories = LoadOtherTexturesCategories();

            // Take texture snapshot
            var dic = maps.TakeSnapshotOfCurrentModelTextures();

            // Open Texture Editor
            var frm = new TextureEditor(Rommgr, otherTextures_Categories.ToArray());

            // Update textures
            frm.TextureReplaced += (_, __) =>
            {
                maps.UpdateTexturesOfCurrentModel(dic);
                dic = maps.TakeSnapshotOfCurrentModelTextures();
            };

            // Show the editor
            frm.Show();
        }

        private void PictureBox_ObjCntr_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void ButtonItem_GeolayoutScriptDumps_Click(object sender, EventArgs e)
        {
            var frm = new FormScriptDumps();

            foreach (var area in CLevel.Areas)
                frm.AddAreaGeolayoutScript(area.AreaID, area.Geolayout.Geolayoutscript);

            foreach (var kvp in GeolayoutScriptDumps)
                frm.AddObjectGeolayoutScript(kvp.Key, kvp.Value);

            foreach (var kvp in AreaDisplaylistScriptDumps)
                frm.AddAreaDisplaylistScripts(kvp.Key, kvp.Value);

            foreach (var kvp in ObjectDisplaylistScriptDumps)
                frm.AddObjectDisplaylistScripts(kvp.Key, kvp.Value);

            frm.Show();
        }
    }
}