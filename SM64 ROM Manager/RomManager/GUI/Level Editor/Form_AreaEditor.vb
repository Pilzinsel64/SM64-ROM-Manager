Imports System.IO
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports OpenTK
Imports SM64Lib.Levels
Imports SM64Lib.Levels.Script, SM64Lib.Levels.Script.Commands
Imports OpenTK.Graphics.OpenGL
Imports Pilz.Drawing.Drawing3D.OpenGLFactory.RenderingN
Imports SM64Lib.Geolayout.Script.Commands
Imports System.ComponentModel
Imports Pilz.S3DFileParser
Imports SM64Lib.Model.Fast3D.DisplayLists
Imports Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN
Imports SM64_ROM_Manager.SettingsManager
Imports SM64Lib.Geolayout
Imports SM64Lib.Model
Imports SM64_ROM_Manager.ModelConverterGUI
Imports SimpleHistory
Imports System.Reflection
Imports DevComponents.Editors
Imports SM64_ROM_Manager.PropertyValueEditors
Imports SM64_ROM_Manager.Publics
Imports DevComponents.AdvTree
Imports System.Timers
Imports Newtonsoft.Json.Linq
Imports SM64Lib.Data
Imports System.Runtime.InteropServices
Imports SM64Lib.SegmentedBanking
Imports SM64Lib.N64Graphics
Imports SM64_ROM_Manager.My.Resources
Imports SM64Lib.ObjectBanks

Namespace LevelEditor

    Public Class Form_AreaEditor

#Region "Declerations"

        Friend Property CLevel As Level = Nothing
        Friend Property LastKeyLeaveTimer As Date = Date.Now
        Friend ReadOnly Property PressedKeys As New List(Of Keys)
        Friend Property SelectedList As ListViewEx = ListViewEx_Objects
        Friend Property AreaIdToLoad As Byte = 1
        Friend Property LevelID As Byte = 0
        Friend ReadOnly Property OrigObjPos As New List(Of Numerics.Vector3)
        Friend Property Rommgr As SM64Lib.RomManager = Nothing
        Friend ReadOnly Property ManagedObjects As New List(Of Managed3DObject)
        Friend ReadOnly Property ManagedWarps As New List(Of IManagedLevelscriptCommand)
        Friend ReadOnly Property ManagedSpecialBoxes As New List(Of ManagedSpecialBox)
        Friend ReadOnly Property ObjectModels As New Dictionary(Of Byte, Renderer)
        Friend ReadOnly Property SpecialBoxRenderers As New Dictionary(Of ManagedSpecialBox, Renderer)
        Friend ReadOnly Property MyObjectCombos As New ObjectComboList
        Friend ReadOnly Property ObjectModelsToParse As New Dictionary(Of Byte, Object)
        Friend ReadOnly Property MyLevelsList As New List(Of String)
        Friend ReadOnly Property KnownModelIDs As New List(Of Byte)

        'Modules
        Friend objectControlling As ObjectControlling
        Friend ogl As OpenGLManager
        Friend maps As MapManagement

        'History
        Friend history As HistoryStack = Nothing
        Friend defBindFlags As BindingFlags = BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.NonPublic
        Friend objStateBlackList As New MemberBlackList({""})
        Friend dicHistories As New Dictionary(Of LevelArea, HistoryStack)

        'Flags
        Friend finishedLoading As Boolean = False
        Friend isLoadingAreaIDs As Boolean = False
        Friend changingActs As Boolean = False
        Friend loadingObj As Boolean = False
        Friend isObjRotating As Boolean = False
        Friend isObjMoving As Boolean = False
        Friend loadingWarp As Boolean = False
        Friend rommgr_SavingRom As Boolean = False
        Friend isFullscreen As Boolean = False
        Friend waitUntilLostFocus As Boolean = False
        Friend isDeactivated As Boolean = False

        'Variables
        Friend backupWindowState As WindowState = FormWindowState.Normal
        Friend backupCurrentAreaIndex As Integer = -1
        Friend lastChangedPropertyName As String = ""

        'Components
        Friend WithEvents PropertyTree As AdvTree
        Friend bpMgr As AdvPropGrid_ObjectPropertiesHelper
        Friend WithEvents Timer_ListViewEx_Objects_SelectionChanged As New Timer With {.AutoReset = False, .SynchronizingObject = Me, .Interval = 40}

        'Delegates
        Friend Delegate Function RemoveAllObjectsWhereExpression(mobj As Managed3DObject) As Boolean

#End Region

#Region "Properties"

        Friend ReadOnly Property CArea As LevelArea
            Get
                Dim index As Integer = ComboBoxItem_Area.SelectedIndex
                If index < 0 Then
                    Return Nothing
                Else
                    Return CLevel.Areas(ComboBoxItem_Area.SelectedIndex)
                End If
            End Get
        End Property

        Friend ReadOnly Property IsStrgPressed As Boolean
            Get
                Return PressedKeys.Contains(Keys.ControlKey)
            End Get
        End Property
        Friend ReadOnly Property IsShiftPressed As Boolean
            Get
                Return PressedKeys.Contains(Keys.ShiftKey)
            End Get
        End Property

        Friend Property ObjectMoveSpeed As Single
            Get
                Return Slider_ObjMoveSpeed.Value / 100
            End Get
            Set(value As Single)
                Slider_ObjMoveSpeed.Value = value * 100
            End Set
        End Property

        Public Property DrawObjectModels As Boolean
            Get
                Return ButtonItem_DrawObjects.Checked
            End Get
            Set(value As Boolean)
                ButtonItem_DrawObjects.Checked = value
            End Set
        End Property

        Friend Property KeepObjectsOnNearestGround As Boolean
            Get
                Return ButtonX_KeepOnGround.Checked
            End Get
            Set(value As Boolean)
                ButtonX_KeepOnGround.Checked = value
            End Set
        End Property
        Friend Property KeepObjectsOnButtom As Boolean
            Get
                Return ButtonX_KeepOnButtom.Checked
            End Get
            Set(value As Boolean)
                ButtonX_KeepOnButtom.Checked = value
            End Set
        End Property
        Friend Property KeepObjectsOnTop As Boolean
            Get
                Return ButtonX_KeepOnTop.Checked
            End Get
            Set(value As Boolean)
                ButtonX_KeepOnTop.Checked = value
            End Set
        End Property
        Friend ReadOnly Property KeepObjectOnGround As Boolean
            Get
                Return KeepObjectsOnButtom OrElse KeepObjectsOnNearestGround OrElse KeepObjectsOnTop
            End Get
        End Property

        Friend ReadOnly Property Camera As Camera
            Get
                Return ogl?.Camera
            End Get
        End Property

#End Region

#Region "Initalize"

        Public Sub New(rommgr As SM64Lib.RomManager, Level As Level, LevelID As Byte, AreaID As Byte)
            'Setup some level variables
            CLevel = Level
            Me.Rommgr = rommgr
            AreaIdToLoad = AreaID
            Me.LevelID = LevelID

            'Initialize Components
            InitializeComponent()

            'Create Modules
            ogl = New OpenGLManager(Me, Panel_GLControl)
            objectControlling = New ObjectControlling(Me)
            maps = New MapManagement(Me)

            'ListViews
            ListViewEx_Objects.SetValue("DoubleBuffered", True)
            ListViewEx_Warps.SetValue("DoubleBuffered", True)
            ListViewEx_CollVertices.SetValue("DoubleBuffered", True)
            ListViewEx_ColFaces.SetValue("DoubleBuffered", True)

            'Stop drawing
            Me.SuspendLayout()

            'Setup other Components
            RibbonControl1.Expanded = Settings.AreaEditor.RibbonControlExpanded

            'Setup Form Settings
            Me.WindowState = Settings.AreaEditor.DefaultWindowMode

            'Setup some Styles
            If Settings.StyleManager.AlwaysKeepBlueColors Then
                PanelEx1.Style.BackColor1.Color = Color.LightSteelBlue
                PanelEx1.Style.BackColor2.Color = Color.LightSteelBlue
            End If

            'Add Groups to ListView Controls
            ListViewEx_Warps.Groups.AddRange({lvg_ConnectedWarps, lvg_WarpsForGame, lvg_PaintingWarps, lvg_InstantWarps})
            'ListViewEx_Objects.Groups.AddRange({lvg_Objects, lvg_MacroObjects})

            'Bring CircularProgress to front
            Me.CircularProgress1.BringToFront()

            'Init Object Properties Helper
            PropertyTree = AdvPropertyGrid1.PropertyTree
            bpMgr = New AdvPropGrid_ObjectPropertiesHelper(AdvPropertyGrid1, MyObjectCombos, NameOf(Managed3DObject.BehaviorID), "BParam")

            'Get the PropertyTree of AdvPropertyGrid1
            PropertyTree = AdvPropertyGrid1.PropertyTree

            'Update Ambient Colors
            UpdateAmbientColors()

            'Resume drawing
            Me.ResumeLayout()
        End Sub

#End Region

#Region "Form & Controls"

        Friend Sub ProgressControl(enabled As Boolean)
            Task.Run(Sub() CircularProgress1.Invoke(New ProgressControlOnInstanceHandler(AddressOf ProgressControlOnInstance), enabled))
        End Sub
        Friend Delegate Sub ProgressControlOnInstanceHandler(enabled As Boolean)
        Friend Sub ProgressControlOnInstance(enabled As Boolean)
            If enabled Then
                CircularProgress1.Start()
            Else
                CircularProgress1.Stop()
            End If
        End Sub

        Friend Sub ButtonItem10_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
            Close()
        End Sub

        Friend Sub Form_AreaEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            maps.ReleaseBuffers()
        End Sub

        Friend Async Sub Form_AreaEditor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            ogl.GLControl.Enabled = True

            LoadBehaviorInfosIfEmpty()
            LoadObjectCombosIfEmpty()
            Await LoadObjectModels()
            LoadOtherObjectCombos()
            SortObjectCombosAlphabetlicly()
            LoadComboBoxObjComboEntries()
            LoadLevelsStringList()
            LoadAreaIDs()

            SelectedList = ListViewEx_Objects

            ogl.Invalidate()
        End Sub

        Friend Sub LoadComboBoxObjComboEntries()
            Dim myObjectCombosString As New List(Of String)

            For Each c As ObjectCombo In MyObjectCombos
                myObjectCombosString.Add(c.Name)
            Next

            'Set Property Settings on AdvPropertyGrid1
            Dim propSet As New PropertySettings("ObjectCombo")
            Dim editor As New ComboBoxPropertyEditor(myObjectCombosString.ToArray)
            editor.DropDownWidth = 300
            propSet.ValueEditor = editor
            AdvPropertyGrid1.PropertySettings.Add(propSet)
        End Sub

        Friend Sub SortObjectCombosAlphabetlicly()
            Dim ordered As ObjectCombo() = MyObjectCombos.OrderBy(Function(n) n.Name).ToArray
            MyObjectCombos.Clear()
            MyObjectCombos.AddRange(ordered)
        End Sub

        Friend Sub LoadOtherObjectCombos()
            Dim modelIDsToLoad As Byte() = {0, &H96, &H95, &HA8, &HA5, &HA6, &HA7, &HA3, &H74, &H7A, &H79, &H7C, &HA4, &H90, &H91, &H94, &HA2, &HAA, &HB9, &HBA, &H8F, &H9F, &HBB, &H9C, &HA1, &H8E, &HE0, &H9E, &HA0, &H75, &H76, &H77, &H85, &H86, &H87, &H88, &HC8, &HCC, &HCB, &HD4, &HD7, &HD8, &HDB, &HCD, &H8A, &H8B, &H8C, &HC2, &HCF, &HCA, &H81, &H82, &H83, &H89, &HC0, &H84, &HBE, &HD9, &HDA, &HBC, &HC3, &HC9, &HB4, &H7F, &H80, &H78, &HDC, &HDF, &HE1}
            For Each obj As ObjectCombo In ObjectCombos.Concat(ObjectCombosCustom)
                If (modelIDsToLoad.Contains(obj.ModelID) OrElse obj.Name.Contains("[MOP")) AndAlso Not MyObjectCombos.Contains(obj) Then
                    MyObjectCombos.Add(obj)
                End If
            Next
        End Sub
        Friend Sub LoadLevelsStringList()
            MyLevelsList.Clear()
            Dim items As New List(Of ComboItem)
            Dim levels As New List(Of Levels)

            For Each lvl In Rommgr.LevelInfoData
                Dim displayName As String = $"{TextFromValue(lvl.ID, , 2)} - {lvl.Name}"
                MyLevelsList.Add(displayName)

                Dim cbitem As New ComboItem(displayName)
                cbitem.Tag = lvl
                items.Add(cbitem)

                levels.Add(lvl.ID)
            Next

            Dim propSet As New PropertySettings("DestLevelID")
            Dim editor As New LevelsEnumEditor(items.ToArray, levels)

            editor.DropDownWidth = 200
            propSet.ValueEditor = editor

            AdvPropertyGrid1.PropertySettings.Add(propSet)
        End Sub

        Friend Sub ButtonX_DropToGround_Click(sender As Object, e As EventArgs) Handles ButtonX_DropToGround.Click, ButtonItem_DropToGround.Click
            StoreObjectHistoryPoint(SelectedObjects, "Position")
            DropObjectsToGround(0)
        End Sub
        Friend Sub ButtonX_DropToTop_Click(sender As Object, e As EventArgs) Handles ButtonX_DropToTop.Click, ButtonItem_DropToTop.Click
            StoreObjectHistoryPoint(SelectedObjects, "Position")
            DropObjectsToGround(1)
        End Sub
        Friend Sub ButtonX_DropToBottom_Click(sender As Object, e As EventArgs) Handles ButtonX_DropToBottom.Click, ButtonItem_DropToBottom.Click
            StoreObjectHistoryPoint(SelectedObjects, "Position")
            DropObjectsToGround(2)
        End Sub

        Friend Sub ButtonX_KeepOnGround_CheckedChanged(sender As Object, e As EventArgs) Handles ButtonX_KeepOnGround.CheckedChanged, ButtonX_KeepOnTop.CheckedChanged, ButtonX_KeepOnButtom.CheckedChanged, ButtonItem_KeepOnButtom.CheckedChanged, ButtonItem_KeepOnTop.CheckedChanged, ButtonItem_KeepOnGround.CheckedChanged
            If sender.Checked Then
                For Each btn As ButtonX In {ButtonX_KeepOnGround, ButtonX_KeepOnTop, ButtonX_KeepOnButtom}
                    If btn IsNot sender Then btn.Checked = False
                Next

                If ({ButtonX_KeepOnGround, ButtonItem_KeepOnGround}).Contains(sender) Then
                    ButtonX_DropToGround.PerformClick()
                ElseIf ({ButtonX_KeepOnTop, ButtonItem_KeepOnTop}).Contains(sender) Then
                    ButtonX_DropToTop.PerformClick()
                ElseIf ({ButtonX_KeepOnButtom, ButtonItem_KeepOnButtom}).Contains(sender) Then
                    ButtonX_DropToBottom.PerformClick()
                End If
            End If
        End Sub

        Friend Sub Form_AreaEditor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            'Stop Circular Progress, otherwise it will crash
            CircularProgress1.Stop()

            'Save all Objects
            SaveAllObjectProperties()
            SaveAllWarpProperties()
        End Sub

        Friend Sub DockContainerItem4_Click(sender As Object, e As EventArgs) Handles DockContainerItem4.MouseUp
            If sender.Selected Then
                RibbonTabItem_Objects.Select()
            End If
        End Sub
        Friend Sub DockContainerItem1_Click(sender As Object, e As EventArgs) Handles DockContainerItem1.MouseUp
            If sender.Selected Then
                RibbonTabItem_Warps.Select()
            End If
        End Sub
        Friend Sub DockContainerItem5_Click(sender As Object, e As EventArgs) Handles DockContainerItem5.MouseUp
            If sender.Selected Then
                RibbonTabItem_Collision.Select()
            End If
        End Sub

        Friend Sub ButtonItem95_Click(sender As Object, e As EventArgs) Handles ButtonItem95.Click
            If RibbonControl1.Expanded Then
                ButtonItem95.Image = MyIcons.icons8_expand_arrow_16px
                RibbonControl1.Expanded = False
            Else
                ButtonItem95.Image = MyIcons.icons8_collapse_arrow_16px
                RibbonControl1.Expanded = True
            End If
            Settings.AreaEditor.RibbonControlExpanded = RibbonControl1.Expanded
        End Sub

        Friend Sub RibbonControl1_SelectedRibbonTabChanged(sender As Object, e As EventArgs) Handles RibbonControl1.SelectedRibbonTabChanged
            Dim srti As RibbonTabItem = RibbonControl1.SelectedRibbonTabItem

            Select Case True
                Case srti.Equals(RibbonTabItem_Objects)

                    SelectedList = ListViewEx_Objects
                    DockContainerItem4.Selected = True

                Case srti.Equals(RibbonTabItem_Warps)

                    SelectedList = ListViewEx_Warps
                    DockContainerItem1.Selected = True

                Case srti.Equals(RibbonTabItem_Collision)

                    If maps.IsCollisionMapNothing Then
                        maps.LoadAreaCollisionAsObject3D()
                    End If
                    maps.LoadCollisionLists()
                    DockContainerItem5.Selected = True

                Case Else : Return

            End Select

            PanelDockContainer10.DockContainerItem.Selected = True
        End Sub

        Friend Sub Form_AreaEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            If isDeactivated Then
                maps.CheckAndLoadNew()
                isDeactivated = False
            End If
        End Sub

        Friend Sub Form_AreaEditor_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
            isDeactivated = True
        End Sub

#End Region

#Region "Camera & Movements"

        Friend Sub AdvPropertyGrid1_RefreshPropertyValues()
            Try
                AdvPropertyGrid1.RefreshPropertyValues()
            Catch ex As Exception
            End Try
        End Sub

#End Region

#Region "Model"

        Private Async Function LoadObjectModels() As Task 'Friend Async Function LoadObjectModels() As Task
            ObjectModels.Clear()

            'Parse root level script
            Dim lvlScriptMain As New Levelscript
            lvlScriptMain.Read(Rommgr, Rommgr.GetSegBank(&H15).BankAddress, LevelscriptCommandTypes.x1E)
            Await ParseLevelscriptAndLoadModels(lvlScriptMain)

            'Parse level script
            Await ParseLevelscriptAndLoadModels(CLevel.Levelscript)

            'Load global objects
            If Rommgr.HasGlobalObjectBank AndAlso CLevel.EnableGlobalObjectBank Then
                Rommgr.GenerateGlobalObjectBank()
                Await LoadCustomObjectBankModels(Rommgr.GlobalObjectBank)
            End If
        End Function

        Private Async Function LoadCustomObjectBankModels(objBank As CustomObjectBank) As Task
            For Each obj As CustomObject In objBank.Objects
                If Not ObjectModels.ContainsKey(obj.ModelID) Then
                    Await LoadCustomObjectBankModel(obj)
                End If
            Next
        End Function

        Private Async Function LoadCustomObjectBankModel(obj As CustomObject) As Task
            Dim mdl As New Object3D

            For Each gp As Geopointer In obj.Geolayout.Geopointers
                Await LoadDisplaylist(gp, mdl)
            Next

            AddObject3DWithRendererIfNotNull(mdl, obj.ModelID)
        End Function

        Private Async Function LoadDisplaylist(pointer As Geopointer, mdl As Object3D) As Task
            Dim dl As New DisplayList
            Await dl.TryFromStreamAsync(pointer, Rommgr, Nothing)
            Await dl.TryToObject3DAsync(mdl, Rommgr, Nothing)
        End Function

        Private Sub AddObject3DWithRendererIfNotNull(mdl As Object3D, modelID As Byte)
            If mdl.Meshes.Count > 0 Then
                Dim rndr As New Renderer(mdl)
                ObjectModels.Add(modelID, rndr)
            End If
        End Sub

        Private Async Function ParseGeolayoutAndLoadModels(glscript As Script.Geolayoutscript, modelID As Byte) As Task
            Dim mdlScale As Numerics.Vector3 = Numerics.Vector3.One
            Dim mdlScaleNodeIndex As Integer = -1
            Dim nodeIndex As Integer = 0
            Dim mdl As New Object3D

            For Each gmd As Script.GeolayoutCommand In glscript
                Select Case gmd.CommandType
                    Case Script.GeolayoutCommandTypes.LoadDisplaylist
                        Dim geolayer As Byte = cgLoadDisplayList.GetDrawingLayer(gmd)
                        Dim segAddr As Integer = cgLoadDisplayList.GetSegGeopointer(gmd)

                        If segAddr > 0 Then
                            Await LoadDisplaylist(New Geopointer(geolayer, segAddr, mdlScale, Numerics.Vector3.Zero), mdl)
                        End If

                    Case Script.GeolayoutCommandTypes.LoadDisplaylistWithOffset
                        Dim geolayer As Byte = cgLoadDisplayListWithOffset.GetDrawingLayer(gmd)
                        Dim segAddr As Integer = cgLoadDisplayListWithOffset.GetSegGeopointer(gmd)

                        If segAddr > 0 Then
                            Dim geop As New Geopointer(geolayer, segAddr, mdlScale, cgLoadDisplayListWithOffset.GetOffset(gmd))
                            Await LoadDisplaylist(geop, mdl)
                        End If

                    Case Script.GeolayoutCommandTypes.Scale2
                        gmd.Position = 4
                        Dim scale As UInteger = gmd.ReadUInt32
                        mdlScale = New Numerics.Vector3(scale / 65536.0!)
                        mdlScaleNodeIndex = nodeIndex

                    Case Script.GeolayoutCommandTypes.StartOfNode
                        nodeIndex += 1

                    Case Script.GeolayoutCommandTypes.EndOfNode
                        nodeIndex -= 1

                End Select

                If mdlScaleNodeIndex > -1 AndAlso mdlScaleNodeIndex > nodeIndex Then
                    mdlScaleNodeIndex = -1
                    mdlScale = Numerics.Vector3.One
                End If
            Next

            AddObject3DWithRendererIfNotNull(mdl, modelID)
        End Function

        Private Async Function ParseLevelscriptAndLoadModels(lvlscript As Levelscript) As Task
            For Each cmd As LevelscriptCommand In lvlscript
                Select Case cmd.CommandType
                    Case LevelscriptCommandTypes.LoadPolygonWithGeo
                        Dim modelID As Byte = clLoadPolygonWithGeo.GetModelID(cmd)
                        Dim segPointer As Integer = clLoadPolygonWithGeo.GetSegAddress(cmd)
                        Dim segID As Byte = segPointer >> 24

                        AddObjectCombosToMyObjectCombos(modelID)
                        If Not KnownModelIDs.Contains(modelID) Then KnownModelIDs.Add(modelID)

                        Dim seg As SegmentedBank = Rommgr.GetSegBank(segID)
                        If segID <> 0 AndAlso seg IsNot Nothing AndAlso Not ObjectModels.ContainsKey(modelID) Then

                            Dim glscript As New Script.Geolayoutscript
                            glscript.Read(Rommgr, segPointer)
                            Await ParseGeolayoutAndLoadModels(glscript, modelID)
                            glscript.Close()
                        End If

                    Case LevelscriptCommandTypes.LoadPolygonWithoutGeo
                        Dim modelID As Byte = clLoadPolygonWithoutGeo.GetModelID(cmd)
                        Dim segPointer As Integer = clLoadPolygonWithoutGeo.GetSegAddress(cmd)
                        Dim layer As Integer = clLoadPolygonWithoutGeo.GetDrawingLayer(cmd)
                        Dim segID As Byte = segPointer >> 24

                        AddObjectCombosToMyObjectCombos(modelID)
                        If Not KnownModelIDs.Contains(modelID) Then KnownModelIDs.Add(modelID)

                        Dim seg As SegmentedBank = Rommgr.GetSegBank(segID)
                        If segID <> 0 AndAlso seg IsNot Nothing AndAlso Not ObjectModels.ContainsKey(modelID) Then
                            Dim mdl = New Object3D

                            Await LoadDisplaylist(New Geopointer(layer, segPointer), mdl)

                            Dim rndr As New Renderer(mdl)
                            ObjectModels.Add(modelID, rndr)
                        End If

                    Case LevelscriptCommandTypes.PaintingWarp
                        '...

                    Case LevelscriptCommandTypes.JumpToSegAddr
                        Dim bankAddr As Integer = clJumpToSegAddr.GetSegJumpAddr(cmd)
                        Dim segID As Byte = bankAddr >> 24

                        Dim seg As SegmentedBank = Rommgr.GetSegBank(segID)
                        If segID <> 0 AndAlso seg IsNot Nothing Then
                            Dim scrpt As New Levelscript
                            scrpt.Read(Rommgr, bankAddr, LevelscriptCommandTypes.JumpBack)
                            Await ParseLevelscriptAndLoadModels(scrpt)
                        End If

                    Case LevelscriptCommandTypes.LoadRomToRam, LevelscriptCommandTypes.x1A, LevelscriptCommandTypes.x18
                        Dim segID As Byte = clLoadRomToRam.GetSegmentedID(cmd)
                        Dim segg As SegmentedBank = Rommgr.GetSegBank(segID)
                        If segg Is Nothing Then
                            Dim seg As New SegmentedBank
                            seg.BankID = segID
                            seg.RomStart = clLoadRomToRam.GetRomStart(cmd)
                            seg.RomEnd = clLoadRomToRam.GetRomEnd(cmd)
                            If cmd.CommandType = LevelscriptCommandTypes.x1A Then seg.MakeAsMIO0()
                            Rommgr.SetSegBank(seg)
                        End If

                End Select
            Next
        End Function

        Friend Sub AddObjectCombosToMyObjectCombos(modelID As Byte)
            For Each obj As ObjectCombo In ObjectCombos.Concat(ObjectCombosCustom)
                If obj.ModelID = modelID AndAlso Not MyObjectCombos.Contains(obj) Then
                    MyObjectCombos.Add(obj)
                End If
            Next
        End Sub

#End Region

#Region "General"

        Friend Sub ButtonItem_SaveRom_Click(sender As Object, e As EventArgs) Handles ButtonItem_SaveRom.Click
            SaveAllObjectProperties()
            SaveAllWarpProperties()

            ProgressControl(True)
            Application.DoEvents()
            rommgr_SavingRom = True

            SaveRom(Rommgr)

            rommgr_SavingRom = False
            ProgressControl(False)
        End Sub

        Friend Async Sub ButtonItem_LaunchROM_Click(sender As Object, e As EventArgs) Handles ButtonItem_LaunchROM.Click
            Await WaitWhileSavingRom()
            LaunchRom(Rommgr)
        End Sub

        Friend Function WaitWhileSavingRom() As Task
            Dim t As New Task(Sub()
                                  Do While rommgr_SavingRom
                                  Loop
                              End Sub)
            t.Start()
            Return t
        End Function

        'Public Sub SetCameraMode(mode As CameraMode)
        '    Camera.SetCameraMode(mode, camMtx)
        '    'camera.updateMatrix(camMtx)
        '    Invalidate()
        'End Sub
        'Public Sub SetCameraMode(mode As CameraMode, look As LookDirection)
        '    camera.SetCameraMode(mode, camMtx)
        '    camera.setCameraMode_LookDirection(look, camMtx)
        '    'camera.updateMatrix(camMtx)
        '    ogl.Invalidate()
        'End Sub
        Public Function GetCamerMode() As CameraMode
            Return Camera.CamMode
        End Function

#End Region

#Region "Features"

#Region "Copy & Paste"

        Friend Sub ButtonItem_Copy_Click(sender As Object, e As EventArgs) Handles ButtonX_WarpsCopy.Click, ButtonItem_ObjectsCopy.Click, ButtonItem6.Click, ButtonItem9.Click
            CopySelection()
        End Sub

        Friend Sub PasteObjectDefault(sender As Object, e As EventArgs) Handles ButtonItem_PasteObjDefault.Click, ButtonItem_PasteObjCombo.Click, ButtonItem_PasteObjRot.Click, ButtonItem_PasteObjPos.Click, ButtonItem_PasteObjBParams.Click, ButtonItem_PasteObjActs.Click, ButtonItem_PasteObjBehavID.Click, ButtonItem_PasteObjModelID.Click, ButtonItem37.Click
            Dim isDefault As Boolean = sender Is ButtonItem_PasteObjDefault OrElse sender Is ButtonItem37
            PasteSelection(New PasteObjectSettings With {
                       .DataFormat = "sm64lvlcmdobj3d",
                       .PasteBehavID = isDefault OrElse sender Is ButtonItem_PasteObjCombo OrElse sender Is ButtonItem_PasteObjBehavID,
                       .PasteActs = isDefault OrElse sender Is ButtonItem_PasteObjActs,
                       .PasteBParams = isDefault OrElse sender Is ButtonItem_PasteObjBParams,
                       .PasteModelID = isDefault OrElse sender Is ButtonItem_PasteObjCombo OrElse sender Is ButtonItem_PasteObjModelID,
                       .PastePosition = isDefault OrElse sender Is ButtonItem_PasteObjPos,
                       .PasteRotation = isDefault OrElse sender Is ButtonItem_PasteObjRot
                       })
        End Sub

        Friend Sub PasteWarpDefault(sender As Object, e As EventArgs) Handles ButtonItem_PasteWarpDefault.Click, ButtonX_PasteWarpDefault.Click, ButtonItem_PasteWarpDestWarp.Click, ButtonItem_PasteWarpDestLevel.Click, ButtonItem_PasteWarpDestArea.Click, ButtonItem5.Click
            Dim isDefault As Boolean = sender Is ButtonItem_PasteWarpDefault OrElse sender Is ButtonItem5
            PasteSelection(New PasteWarpSettings With {
                       .DataFormat = "sm64lvlcmdconnectwarp",
                       .PasteDestArea = isDefault OrElse sender Is ButtonItem_PasteWarpDestArea,
                       .PasteDestLevel = isDefault OrElse sender Is ButtonItem_PasteWarpDestLevel,
                       .PasteDestWarp = isDefault OrElse sender Is ButtonItem_PasteWarpDestWarp
                       })
        End Sub

        Friend Sub CopySelection()
            Dim cmds As New List(Of String)
            Dim format As String = ""

            Dim lastCmds As IntPtr() = Nothing

            For Each item As ListViewItem In SelectedList.SelectedItems
                Dim cmd As LevelscriptCommand = Nothing

                Select Case True
                    Case EditObjects
                        Dim obj As Managed3DObject = CType(item.Tag, Managed3DObject)
                        obj.SaveProperties()
                        cmd = obj.Command
                        format = "sm64lvlcmdobj3d"
                    Case EditWarps
                        Dim warp As IManagedLevelscriptCommand = CType(item.Tag, IManagedLevelscriptCommand)
                        If TypeOf warp Is ManagedWarp Then
                            warp.SaveProperties()
                            cmd = warp.Command
                            format = "sm64lvlcmdconnectwarp"
                        End If
                End Select

                If cmd IsNot Nothing Then
                    cmds.Add(Convert.ToBase64String(cmd.ToArray))
                End If
            Next

            'Set content to clipboard
            Clipboard.SetData(format, cmds.ToArray)
        End Sub

        Friend Sub PasteSelection(pasteSettings As PasteSettings)
            If Clipboard.ContainsData(pasteSettings.DataFormat) Then
                Dim cmds As String() = Clipboard.GetData(pasteSettings.DataFormat)

                Dim selItems As ListView.SelectedListViewItemCollection
                Dim indexListToUse As ListViewEx = Nothing
                Dim cmdListToUse As List(Of LevelscriptCommand) = Nothing
                Select Case pasteSettings.GetType
                    Case GetType(PasteObjectSettings)
                        indexListToUse = ListViewEx_Objects
                        cmdListToUse = CArea.Objects
                    Case GetType(PasteWarpSettings)
                        indexListToUse = ListViewEx_Warps
                        cmdListToUse = CArea.Warps
                End Select

                selItems = indexListToUse.SelectedItems

                If selItems.Count > 0 Then
                    Dim curCmdIndex As Integer = 0
                    Dim curCmd2Index As Integer = 0

                    Do While selItems.Count > curCmd2Index
                        Dim curCmd1 As LevelscriptCommand
                        Dim curCmd2 As New LevelscriptCommand(Convert.FromBase64String(cmds(curCmdIndex)))

                        If curCmd2 IsNot Nothing Then
                            Select Case pasteSettings.GetType
                                Case GetType(PasteObjectSettings)

                                    Dim mobj As Managed3DObject = selItems(curCmd2Index).Tag
                                    curCmd1 = mobj.Command
                                    mobj.SaveProperties()

                                    With CType(pasteSettings, PasteObjectSettings)
                                        If .PasteModelID Then clNormal3DObject.SetModelID(curCmd1, clNormal3DObject.GetModelID(curCmd2))
                                        If .PasteBehavID Then clNormal3DObject.SetSegBehaviorAddr(curCmd1, clNormal3DObject.GetSegBehaviorAddr(curCmd2))
                                        If .PasteBParams Then clNormal3DObject.SetParams(curCmd1, clNormal3DObject.GetParams(curCmd2))
                                        If .PasteActs Then clNormal3DObject.SetActs(curCmd1, clNormal3DObject.GetActs(curCmd2))
                                        If .PastePosition Then clNormal3DObject.SetPosition(curCmd1, clNormal3DObject.GetPosition(curCmd2))
                                        If .PasteRotation Then clNormal3DObject.SetRotation(curCmd1, clNormal3DObject.GetRotation(curCmd2))
                                    End With

                                    mobj.LoadProperties()

                                Case GetType(PasteWarpSettings)

                                    Dim mwarp As IManagedLevelscriptCommand = selItems(curCmd2Index).Tag
                                    curCmd1 = mwarp.Command
                                    mwarp.SaveProperties()

                                    If TypeOf mwarp Is ManagedWarp Then
                                        With CType(pasteSettings, PasteWarpSettings)
                                            If .PasteDestLevel Then clWarp.SetDestinationLevelID(curCmd1, clWarp.GetDestinationLevelID(curCmd2))
                                            If .PasteDestArea Then clWarp.SetDestinationAreaID(curCmd1, clWarp.GetDestinationAreaID(curCmd2))
                                            If .PasteDestWarp Then clWarp.SetDestinationWarpID(curCmd1, clWarp.GetDestinationWarpID(curCmd2))
                                        End With
                                    End If

                                    mwarp.LoadProperties()

                            End Select

                            'Close temp command
                            curCmd2.Close()
                        End If

                        curCmdIndex += 1
                        curCmd2Index += 1

                        If curCmdIndex = cmds.Length Then
                            If curCmdIndex >= indexListToUse.SelectedIndices.Count Then
                                Exit Do
                            Else
                                curCmdIndex = 0
                            End If
                        End If
                    Loop
                End If

                Select Case pasteSettings.GetType
                    Case GetType(PasteObjectSettings)
                        UpdateObjectListViewItems()
                        AdvPropertyGrid1_RefreshPropertyValues()
                        ogl.UpdateOrbitCamera()
                    Case GetType(PasteWarpSettings)
                        UpdateWarpListViewItem()
                        AdvPropertyGrid1_RefreshPropertyValues()
                End Select
            End If
        End Sub

        Friend Class PasteSettings
            Public Property DataFormat As String = ""
        End Class

        Friend Class PasteObjectSettings
            Inherits PasteSettings

            Public Property PasteModelID As Boolean = False
            Public Property PasteBehavID As Boolean = False
            Public Property PasteBParams As Boolean = False
            Public Property PasteActs As Boolean = False
            Public Property PastePosition As Boolean = False
            Public Property PasteRotation As Boolean = False
        End Class

        Friend Class PasteWarpSettings
            Inherits PasteSettings

            Public Property PasteDestLevel As Boolean = False
            Public Property PasteDestArea As Boolean = False
            Public Property PasteDestWarp As Boolean = False
        End Class

#Region "Clear Clipboard"

        Friend Sub ButtonItem44_Click(sender As Object, e As EventArgs) Handles ButtonItem44.Click, ButtonItem81.Click
            Clipboard.Clear()
        End Sub

#End Region

#End Region

#Region "History"

        Friend Function StoreHistoryPoint(miUndo As MethodInfo, miRedo As MethodInfo, param As Object()) As HistoryPoint
            Return StoreHistoryPoint(miUndo, miRedo, param, param)
        End Function
        Friend Function StoreHistoryPoint(obj As Object, miUndo As MethodInfo, miRedo As MethodInfo, param As Object()) As HistoryPoint
            Return StoreHistoryPoint(obj, miUndo, miRedo, param, param)
        End Function
        Friend Function StoreHistoryPoint(miUndo As MethodInfo, miRedo As MethodInfo, paramUndo As Object(), paramRedo As Object()) As HistoryPoint
            Return StoreHistoryPoint(Nothing, miUndo, miRedo, paramUndo, paramRedo)
        End Function
        Friend Function StoreHistoryPoint(obj As Object, miUndo As MethodInfo, miRedo As MethodInfo, paramUndo As Object(), paramRedo As Object()) As HistoryPoint
            Dim act As New ObjectAction(obj, miUndo, miRedo, paramUndo, paramUndo)
            Return StoreHistoryPoint(act)
        End Function
        Friend Function StoreHistoryPoint(ParamArray actions As ObjectAction()) As HistoryPoint
            Dim hp As New HistoryPoint
            hp.Entries.AddRange(actions)
            history.Store(hp)
            Return hp
        End Function

        Friend Sub StoreObjectHistoryPointUsingFocus(objs As Object(), ParamArray whitelist As String())
            If Not waitUntilLostFocus Then
                waitUntilLostFocus = True
                StoreObjectHistoryPoint(objs, whitelist)
            End If
        End Sub
        Friend Sub StoreObjectHistoryPoint(objs As Object(), ParamArray whitelist As String())
            Dim hps As New List(Of HistoryPoint)

            For Each obj As Object In objs
                hps.Add(HistoryPoint.FromObject(obj, ObjectValueType.Property, defBindFlags, True, whitelist))
            Next

            If objs.Count > 0 Then
                Dim hp As HistoryPoint = HistoryPoint.Concat(hps.ToArray)
                If hp.Entries.Any Then
                    history.Store(hp)
                End If
            End If
        End Sub

        Friend Sub ButtonItem_Undo_Click(sender As Object, e As EventArgs) Handles ButtonItem_Undo.Click
            history.Undo()
            RefreshAfterHistoryAction()
        End Sub
        Friend Sub ButtonItem_Redo_Click(sender As Object, e As EventArgs) Handles ButtonItem_Redo.Click
            history.Redo()
            RefreshAfterHistoryAction()
        End Sub
        Friend Sub RefreshAfterHistoryAction()
            Me.SuspendLayout()
            UpdateObjectListViewItems()
            UpdateWarpListViewItem()
            AdvPropertyGrid1_RefreshPropertyValues()
            ogl.UpdateOrbitCamera()
            Me.ResumeLayout()
            ogl.Invalidate()
        End Sub

#End Region

#Region "Screenshot"

        Friend Sub ButtonItem22_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
            If ogl.CurrentModelDrawMod = ModelDrawMod.VisualMap Then

                Dim sfd As New SaveFileDialog With {.Filter = "PNG File (*.png)|*.png|BMP File (*.bmp)|*.bmp|GIF File (*.gif)|*.gif|JPEG File (*.jpeg)|*.jpeg"}
                If sfd.ShowDialog = DialogResult.OK Then
                    ogl.SaveScreenshot(sfd.FileName)
                End If

            Else
                'MessageBoxEx.Show("Please select the Visual Map and try again.", "Not Visual Map selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ShowToastnotification(Panel_GLControl, "Please select the Visual Map and try again.", eToastGlowColor.Red)
            End If
        End Sub

#End Region

#Region "Fullscreen"

        Friend Sub ButtonItem2_CheckedChanged(sender As Object, e As EventArgs) Handles ButtonItem2.CheckedChanged
            Me.SuspendLayout()

            Select Case ButtonItem2.Checked
                Case True
                    isFullscreen = True
                    TopMost = True
                    ButtonItem2.Text = "Disable Fullscreen"
                    FormBorderStyle = FormBorderStyle.None
                    backupWindowState = WindowState
                    WindowState = FormWindowState.Maximized
                    RibbonControl1.CaptionVisible = False
                    RibbonControl1.Height -= 28
                Case False
                    isFullscreen = False
                    TopMost = False
                    ButtonItem2.Text = "Enable Fullscreen"
                    FormBorderStyle = FormBorderStyle.Sizable
                    WindowState = backupWindowState
                    RibbonControl1.Height += 28
                    RibbonControl1.CaptionVisible = True
            End Select

            Me.ResumeLayout()
        End Sub

#End Region

#End Region

#Region "Lists"

        Friend lvg_ConnectedWarps As New ListViewGroup With {.Header = "Connected Warps"}
        Friend lvg_WarpsForGame As New ListViewGroup With {.Header = "Warps for Game"}
        Friend lvg_PaintingWarps As New ListViewGroup With {.Header = "Painting Warps"}
        Friend lvg_InstantWarps As New ListViewGroup With {.Header = "Instant Warps"}
        'Friend lvg_Objects As New ListViewGroup With {.Header = "3D Objects"}
        'Friend lvg_MacroObjects As New ListViewGroup With {.Header = "Macro 3D Objects"}

        Friend Sub LoadAreaIDs()
            isLoadingAreaIDs = True
            ComboBoxItem_Area.Items.Clear()
            Dim indexToSelect As Byte = 0
            For Each a As LevelArea In CLevel.Areas
                ComboBoxItem_Area.Items.Add(New ComboItem() With {.Text = $"Area {a.AreaID}", .Tag = a})
                If a.AreaID = AreaIdToLoad Then indexToSelect = CLevel.Areas.IndexOf(a)
            Next
            isLoadingAreaIDs = False
            ComboBoxItem_Area.SelectedIndex = indexToSelect
        End Sub
        Friend Sub LoadObjectLists()
            ListViewEx_Objects.SuspendLayout()

            ListViewEx_Objects.Items.Clear()
            ManagedObjects.Clear()

            Dim i As Integer = 0
            For Each objj In CArea.Objects
                Dim objNew As New Managed3DObject(objj, MyObjectCombos)
                ManagedObjects.Add(objNew)
                Dim lvi As New ListViewItem
                lvi.Tag = objNew
                lvi.SubItems.Add(New ListViewItem.ListViewSubItem)
                SetObjectPropertiesToListViewItem(lvi, objNew, i)
                ListViewEx_Objects.Items.Add(lvi)
                i += 1
            Next

            'Select first Item
            SelectItemAtIndexInList(ListViewEx_Objects, 0, True)

            ListViewEx_Objects.ResumeLayout()
        End Sub
        Friend Sub SelectItemAtIndexInList(list As ListViewEx, index As Integer, deselectAllOtherItems As Boolean)
            For i As Integer = 0 To list.Items.Count - 1
                If i = index Then
                    list.Items(i).Selected = True
                    list.EnsureVisible(i)
                ElseIf deselectAllOtherItems Then
                    list.Items(i).Selected = False
                End If
            Next
        End Sub
        Friend Sub LoadWarpsLists()
            ListViewEx_Warps.SuspendLayout()

            ListViewEx_Warps.Items.Clear()
            ManagedWarps.Clear()

            Dim allWarps As New List(Of LevelscriptCommand)
            Dim gameWarpsStart, gameWarpCount As Integer

            allWarps.AddRange(CArea.Warps)
            gameWarpsStart = allWarps.Count
            gameWarpCount = CArea.WarpsForGame.Count
            allWarps.AddRange(CArea.WarpsForGame)

            For Each warp As LevelscriptCommand In allWarps
                Dim warpNew As IManagedLevelscriptCommand = Nothing
                Dim lvi As New ListViewItem With {.Tag = warpNew}

                'Set the ListViewGroup for the ListViewItem
                Select Case warp.CommandType
                    Case LevelscriptCommandTypes.ConnectedWarp
                        Dim warpIndex As Integer = allWarps.IndexOf(warp)
                        If warpIndex >= gameWarpsStart AndAlso warpIndex <= gameWarpsStart + gameWarpCount Then
                            lvi.Group = lvg_WarpsForGame
                        Else
                            lvi.Group = lvg_ConnectedWarps
                        End If
                        warpNew = New ManagedWarp(warp)
                    Case LevelscriptCommandTypes.PaintingWarp
                        lvi.Group = lvg_PaintingWarps
                        warpNew = New ManagedWarp(warp)
                    Case LevelscriptCommandTypes.InstantWarp
                        warpNew = New ManagedInstantWarp(warp)
                End Select

                'Set managed Warp as Tag
                lvi.Tag = warpNew

                'Add enought SubItems to ListviewItem
                For i As Integer = 2 To 4
                    lvi.SubItems.Add(New ListViewItem.ListViewSubItem)
                Next

                'Set all Properties as Text to the SubItems
                SetWarpPropertiesToListViewItem(lvi, warpNew)

                ManagedWarps.Add(warpNew)
                ListViewEx_Warps.Items.Add(lvi)
            Next

            'Select first Item
            If ListViewEx_Warps.Items.Count > 0 Then
                With ListViewEx_Warps.Items(0)
                    .Selected = True
                End With
            End If

            ListViewEx_Warps.ResumeLayout()
        End Sub
        Friend Sub SetWarpPropertiesToListViewItem(ByRef lvi As ListViewItem, iwarp As IManagedLevelscriptCommand)
            If TypeOf iwarp Is ManagedWarp Then
                Dim warp As ManagedWarp = iwarp

                Dim destLevel = Rommgr.LevelInfoData.FirstOrDefault(Function(n) n.ID = warp.DestLevelID)
                lvi.SubItems(0).Text = WarpIDToString(warp.WarpID)
                lvi.SubItems(1).Text = $"{destLevel?.TypeString}-{destLevel?.Number}"
                lvi.SubItems(2).Text = TextFromValue(warp.DestAreaID)
                lvi.SubItems(3).Text = TextFromValue(warp.DestWarpID)

                Dim colorToUse As Color
                Try
                    colorToUse = GetColorOfWarpDestinationValidationResult(warp)
                Catch ex As Exception
                    colorToUse = Nothing
                End Try
                For Each subitem As ListViewItem.ListViewSubItem In lvi.SubItems
                    subitem.ForeColor = colorToUse
                Next

            ElseIf TypeOf iwarp Is ManagedInstantWarp Then
                Dim warp As ManagedInstantWarp = iwarp

                lvi.SubItems(0).Text = String.Empty
                lvi.SubItems(1).Text = ValueFromText(warp.CollisionType)
                lvi.SubItems(2).Text = ValueFromText(warp.DestAreaID)
                lvi.SubItems(3).Text = String.Empty

            End If
        End Sub
        Friend Sub SetObjectPropertiesToListViewItem(ByRef lvi As ListViewItem, obj As Managed3DObject, Optional objIndex As Integer = -1)
            If objIndex > -1 Then lvi.SubItems(0).Text = objIndex + 1
            Dim combo = MyObjectCombos.GetObjectComboOfObject(obj)
            Dim txt As String = ""

            If combo Is Nothing OrElse combo Is ObjectComboList.UnknownCombo Then
                txt = TextFromValue(obj.BehaviorID) & " - " & TextFromValue(obj.ModelID)
            Else
                txt = combo.Name
            End If

            lvi.SubItems(1).Text = txt
        End Sub
        Friend Function WarpIDToString(id As Byte) As String
            Select Case id
                Case 241
                    Return "Failure"
                Case 240
                    Return "Success"
                Case Else
                    Return TextFromValue(id)
            End Select
        End Function

        Friend Sub DeselectAllListViewItems(ListView As ListViewEx)
            ListView.SuspendLayout()
            For Each item As ListViewItem In ListView.Items
                item.Focused = False
                item.Selected = False
            Next
            ListView.ResumeLayout()
        End Sub

        Friend Sub ListViewEx_Objects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewEx_Objects.SelectedIndexChanged
            With Timer_ListViewEx_Objects_SelectionChanged
                If .Enabled Then
                    .Stop()
                End If
                .Start()
            End With
        End Sub
        Friend Sub Timer_ListViewEx_Objects_SelectionChanged_Elapsed(sender As Object, e As ElapsedEventArgs) Handles Timer_ListViewEx_Objects_SelectionChanged.Elapsed
            If Not loadingObj AndAlso SelectedObject IsNot Nothing Then
                SelectObjects(SelectedObjects)
                ShowObjectProperties()
                If objectControlling.WasInOrbitMode Then ogl.SetCameraMode(CameraMode.ORBIT)
            End If
            PanelDockContainer10.DockContainerItem.Selected = True
        End Sub

        Friend Sub ListViewEx_Warps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewEx_Warps.SelectedIndexChanged
            Dim selectedIndexes = ListViewEx_Warps.SelectedIndices
            If selectedIndexes.Count > 0 Then
                ShowWarpProterties()
                PanelDockContainer10.DockContainerItem.Selected = True
            End If
        End Sub

        Friend ReadOnly Property SelectedObject As Managed3DObject
            Get
                If ListViewEx_Objects.SelectedIndices.Count = 0 Then Return Nothing
                Return ListViewEx_Objects.SelectedItems(0).Tag
            End Get
        End Property
        Friend ReadOnly Property SelectedObjects As Managed3DObject()
            Get
                If ListViewEx_Objects.SelectedIndices.Count = 0 Then Return {}
                Dim objs As New List(Of Managed3DObject)
                For Each item As ListViewItem In ListViewEx_Objects.SelectedItems
                    objs.Add(item.Tag)
                Next
                Return objs.ToArray
            End Get
        End Property

        Friend Sub SelectObject(obj As Managed3DObject, Optional DeselectAllObjects As Boolean = True)
            SelectObjects({obj}, DeselectAllObjects)
        End Sub
        Friend Sub SelectObjects(objs() As Managed3DObject, Optional DeselectAllObjects As Boolean = True)
            If DeselectAllObjects Then Me.DeselectAllObjects(False)

            For Each obj As Managed3DObject In objs
                If obj IsNot Nothing Then
                    obj.IsSelected = True
                End If
            Next

            ogl.UpdateOrbitCamera()
            ogl.Invalidate()
            ogl.Update()
        End Sub
        Friend Sub DeselectAllObjects(Optional UpdateGLAndCamera As Boolean = True)
            For Each obj As Managed3DObject In ManagedObjects
                obj.IsSelected = False
            Next

            If UpdateGLAndCamera Then
                ogl.UpdateOrbitCamera()
                ogl.Invalidate()
                ogl.Update()
            End If
        End Sub
        Friend Sub ToogleObjectSelection(obj As Managed3DObject)
            obj.IsSelected = Not obj.IsSelected

            With ListViewEx_Objects.Items(ManagedObjects.IndexOf(obj))
                .Selected = Not .Selected
            End With

            ogl.UpdateOrbitCamera()
            ogl.Invalidate()
            ogl.Update()
        End Sub

        Friend ReadOnly Property SelectedWarp As IManagedLevelscriptCommand
            Get
                If ListViewEx_Warps.SelectedIndices.Count = 0 Then Return Nothing
                Return ListViewEx_Warps.SelectedItems(0).Tag
            End Get
        End Property
        Friend ReadOnly Property SelectedWarps As IManagedLevelscriptCommand()
            Get
                If ListViewEx_Warps.SelectedIndices.Count = 0 Then Return {}
                Dim objs As New List(Of IManagedLevelscriptCommand)
                For Each item As ListViewItem In ListViewEx_Warps.SelectedItems
                    objs.Add(item.Tag)
                Next
                Return objs.ToArray
            End Get
        End Property

        Friend Sub ListViewEx_ColFaces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewEx_ColFaces.SelectedIndexChanged
            Dim selectedIndexes = ListViewEx_ColFaces.SelectedIndices
            If selectedIndexes.Count > 0 Then
                ShowColFaceProperties()
                PanelDockContainer10.DockContainerItem.Selected = True
            End If
        End Sub

        Friend ReadOnly Property SelectedColFace As Face
            Get
                If ListViewEx_ColFaces.SelectedIndices.Count = 0 Then Return Nothing
                Return ListViewEx_ColFaces.SelectedItems(0).Tag
            End Get
        End Property
        Friend ReadOnly Property SelectedColFaces As Face()
            Get
                If ListViewEx_ColFaces.SelectedIndices.Count = 0 Then Return {}
                Dim objs As New List(Of Face)
                For Each item As ListViewItem In ListViewEx_ColFaces.SelectedItems
                    objs.Add(item.Tag)
                Next
                Return objs.ToArray
            End Get
        End Property

        Friend Sub SelectColFace(face As Face)
            SelectColFaces({face})
        End Sub
        Friend Sub SelectColFaces(faces() As Face, Optional DeselectAllFaces As Boolean = True)
            If DeselectAllFaces Then DeselectAllObjects(False)

            For Each f As Face In faces
                If f IsNot Nothing Then
                    maps.rndrCollisionMap.SelectedElements.Add(f)
                End If
            Next

            ogl.UpdateOrbitCamera()
            ogl.Invalidate()
            ogl.Update()
        End Sub
        Friend Sub DeselectAllFaces(Optional UpdateGLAndCamera As Boolean = True)
            For Each f As Face In maps.rndrCollisionMap.SelectedElements.OfType(Of Face)
                maps.rndrCollisionMap.SelectedElements.Remove(f)
            Next

            If UpdateGLAndCamera Then
                ogl.UpdateOrbitCamera()
                ogl.Invalidate()
                ogl.Update()
            End If
        End Sub
        Friend Sub ToogleColFaceSelection(face As Face)
            If maps.rndrCollisionMap.SelectedElements.Contains(face) Then
                maps.rndrCollisionMap.SelectedElements.Remove(face)
            Else
                maps.rndrCollisionMap.SelectedElements.Add(face)
            End If

            With ListViewEx_Objects.Items(maps.cCollisionMap.Meshes(0).Faces.IndexOf(face))
                .Selected = Not .Selected
            End With

            ogl.UpdateOrbitCamera()
            ogl.Invalidate()
            ogl.Update()
        End Sub

        Friend Sub ListViewEx_Objects_Click(sender As Object, e As EventArgs) Handles ListViewEx_Warps.Click, ListViewEx_Objects.Click, ListViewEx_CollVertices.Click, ListViewEx_ColFaces.Click
            SelectedList = sender
        End Sub

        Friend ReadOnly Property EditCollision As Boolean
            Get
                Return EditCollisionVertices OrElse EditCollisionFaces
            End Get
        End Property
        Friend ReadOnly Property EditCollisionVertices As Boolean
            Get
                Return SelectedList Is ListViewEx_CollVertices
            End Get
        End Property
        Friend ReadOnly Property EditCollisionFaces As Boolean
            Get
                Return SelectedList Is ListViewEx_ColFaces
            End Get
        End Property
        Friend ReadOnly Property EditObjects As Boolean
            Get
                Return SelectedList Is ListViewEx_Objects
            End Get
        End Property
        Friend ReadOnly Property EditWarps As Boolean
            Get
                Return SelectedList Is ListViewEx_Warps
            End Get
        End Property
        Friend ReadOnly Property EditWarpsDefault As Boolean
            Get
                Return ListViewEx_Warps.SelectedIndices().Count > 0 AndAlso IsGroupWarpDefault(ListViewEx_Warps.SelectedItems(0))
            End Get
        End Property
        Friend Function IsGroupWarpDefault(item As ListViewItem) As Boolean
            Return item.Group Is lvg_ConnectedWarps
        End Function
        Friend ReadOnly Property EditWarpsForGame As Boolean
            Get
                Return ListViewEx_Warps.SelectedIndices().Count > 0 AndAlso IsGroupWarpForGame(ListViewEx_Warps.SelectedItems(0))
            End Get
        End Property
        Friend Function IsGroupWarpForGame(item As ListViewItem) As Boolean
            Return item.Group Is lvg_WarpsForGame
        End Function

        Friend Sub ListViewEx_Objects_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewEx_Objects.MouseClick
            If e.Button = MouseButtons.Right Then
                ButtonItem_CM_Objects.Popup(Cursor.Position)
            End If
        End Sub
        Friend Sub ListViewEx_Warps_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewEx_Warps.MouseClick
            If e.Button = MouseButtons.Right Then
                ButtonItem1_CM_Warps.Popup(Cursor.Position)
            End If
        End Sub

        Friend Sub LoadSpecailBoxList()
            ManagedSpecialBoxes.Clear()

            For Each sp As SpecialBox In CArea.SpecialBoxes
                Dim msp As New ManagedSpecialBox(sp)
                ManagedSpecialBoxes.Add(msp)
            Next
        End Sub

#End Region

#Region "Area"

        Friend Sub SwitchCurrentArea()
            If Not isLoadingAreaIDs Then

                If Not dicHistories.ContainsKey(CArea) Then
                    Dim hs As New HistoryStack
                    dicHistories.Add(CArea, hs)
                    history = hs
                Else
                    history = dicHistories(CArea)
                End If
                backupCurrentAreaIndex = ComboBoxItem_Area.SelectedIndex

                SaveAllObjectProperties()
                SaveAllWarpProperties()

                maps.cCollisionMap = Nothing
                maps.cVisualMap = Nothing
                maps.LoadAreaModel()

                LoadObjectLists()
                LoadWarpsLists()
                LoadSpecailBoxList()

                If Settings.AreaEditor.DefaultCameraMode = CameraMode.ORBIT Then
                    ButtonItem_CamOrbit.RaiseClick()
                Else
                    ButtonItem_CamFly.RaiseClick()
                End If

            End If
        End Sub
        Friend Sub ComboBoxEx_Area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxItem_Area.SelectedIndexChanged
            SwitchCurrentArea()
        End Sub

        Friend Sub ButtonItem47_Click(sender As Object, e As EventArgs) Handles ButtonItem47.Click
            ButtonItem_ImportModel.RaiseClick()
        End Sub
        Friend Sub ButtonItem_ImportModel_Click(sender As Object, e As EventArgs) Handles ButtonItem_ImportModel.Click, ButtonItem_ImportCollision.Click, ButtonItem_ImportVisualMap.Click, ButtonItem85.Click
            maps.ImportAreaModel(sender Is ButtonItem_ImportModel OrElse sender Is ButtonItem_ImportVisualMap,
                                 sender Is ButtonItem_ImportModel OrElse sender Is ButtonItem_ImportCollision OrElse sender Is ButtonItem85,
                                 GetKeyForConvertAreaModel(Rommgr.GameName, CLevel.LevelID, CArea.AreaID))
        End Sub

        Friend Sub ButtonItem_AddArea_Click(sender As Object, e As EventArgs) Handles ButtonItem_AddArea.Click
            Dim ReamingIDs As New List(Of Byte)({&H1, &H2, &H3, &H4, &H5, &H6, &H7, &H0})
            For Each a As LevelArea In CLevel.Areas
                ReamingIDs.Remove(a.AreaID)
            Next
            If ReamingIDs.Count = 0 Then
                'MessageBoxEx.Show("The maximum count of Areas per Level is 8.", "Maximum reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ShowToastnotification(Panel_GLControl, "The maximum amount of areas per level is 8.", eToastGlowColor.Red)
                ButtonItem_AddArea.Enabled = False
                Return
            End If

            Dim newAreaID As Byte = ReamingIDs(0)
            Dim tArea As New RMLevelArea(newAreaID)
            Dim res = GetModelViaModelConverter(False, False,,,, GetKeyForConvertAreaModel(Rommgr.GameName, CLevel.LevelID, newAreaID))

            If res IsNot Nothing Then
                tArea.AreaModel = res?.mdl
                CLevel.Areas.Add(tArea)
                AreaIdToLoad = tArea.AreaID
                LoadAreaIDs()
            End If
        End Sub

        Friend Sub ButtonItem_RemoveArea_Click(sender As Object, e As EventArgs) Handles ButtonItem_RemoveArea.Click
            Dim index = CLevel.Areas.IndexOf(CArea)
            If index < 0 Then Return

            CLevel.Areas.RemoveAt(index)

            ButtonItem_AddArea.Enabled = True
            If CLevel.Areas.Count = 0 Then
                Me.Close()
            Else
                AreaIdToLoad = If(index < CLevel.Areas.Count, CLevel.Areas(index).AreaID, CLevel.Areas.Last.AreaID)
                LoadAreaIDs()
            End If
        End Sub

#End Region

#Region "Render Settings"

        Friend Sub SomeButtonItems_Click(sender As Object, e As EventArgs) Handles ButtonItem_ViewColMap.Click, ButtonItem_ViewVisualMap.Click, ButtonItem_DrawOutline.Click, ButtonItem_DrawFill.Click, ButtonItem_DrawObjects.Click, ButtonItem_DrawBackfaces.Click
            'Application.DoEvents()
            ogl?.Invalidate()
        End Sub

        Friend Sub ButtonItem_DrawBackfaces_CheckChanged(sender As Object, e As EventArgs) Handles ButtonItem_DrawBackfaces.CheckedChanged
            If sender.Checked Then
                GL.Disable(EnableCap.CullFace)
            Else
                GL.Enable(EnableCap.CullFace)
            End If
        End Sub

        Friend Sub ViewModeButtonItems_CheckChanged(sender As Object, e As EventArgs) Handles ButtonItem_ViewVisualMap.CheckedChanged, ButtonItem_ViewColMap.CheckedChanged
            If sender.Checked Then
                For Each btn As CheckBoxItem In {ButtonItem_ViewVisualMap, ButtonItem_ViewColMap}
                    If btn IsNot sender Then btn.Checked = False
                Next
                If sender Is ButtonItem_ViewColMap Then
                    ButtonItem_DrawOutline.Checked = True
                End If
                If CLevel IsNot Nothing AndAlso CArea IsNot Nothing Then maps.LoadAreaModel()
                ogl?.Invalidate()
            End If
        End Sub

#End Region

#Region "Level"

#Region "Default Start Position"

        Friend Sub ButtonItem84_Click(sender As Object, e As EventArgs) Handles ButtonItem84.Click
            Dim selobj As Managed3DObject = SelectedObject
            SetDefaultPosition(selobj.Position, selobj.Rotation.Y)
        End Sub

        Friend Sub SetDefaultPosition(pos As Numerics.Vector3, rotY As Single)
            Dim cmd2D As LevelscriptCommand = CLevel.GetDefaultPositionCmd
            clDefaultPosition.SetPosition(cmd2D, pos)
            clDefaultPosition.SetRotation(cmd2D, rotY)
            clDefaultPosition.SetAreaID(cmd2D, CArea.AreaID)
        End Sub

#End Region

#End Region

#Region "Objects"

        Friend Sub SetObjectsToPropertyGrid(objs As Object())
            AdvPropertyGrid1.SuspendLayout()
            AdvPropertyGrid1.SelectedObjects = objs
            AdvPropertyGrid1.UpdateAmbientColors()
            AdvPropertyGrid1.ResumeLayout()
            UpdateBParamNames()
            AdvPropertyGrid1_RefreshPropertyValues()
        End Sub

        Friend Sub ShowObjectProperties()
            SetObjectsToPropertyGrid(SelectedObjects)

            'If SelectedObject Is Nothing Then Return
            'loadingObj = True
            'Panel_ObjectSettings.SuspendLayout()

            ''Selected Object
            'Dim sObj = SelectedObject

            ''Acts
            'SetEnableStateOnStarSymbolBox(SymbolBox_Act1, sObj.Act1)
            'SetEnableStateOnStarSymbolBox(SymbolBox_Act2, sObj.Act2)
            'SetEnableStateOnStarSymbolBox(SymbolBox_Act3, sObj.Act3)
            'SetEnableStateOnStarSymbolBox(SymbolBox_Act4, sObj.Act4)
            'SetEnableStateOnStarSymbolBox(SymbolBox_Act5, sObj.Act5)
            'SetEnableStateOnStarSymbolBox(SymbolBox_Act6, sObj.Act6)
            'CheckAllActs()

            ''Position
            'IntegerInput_ObjPosX.Value = sObj.Position.X
            'IntegerInput_ObjPosY.Value = sObj.Position.Y
            'IntegerInput_ObjPosZ.Value = sObj.Position.Z

            ''Rotation
            'IntegerInput_ObjRotX.Value = sObj.Rotation.X
            'IntegerInput_ObjRotY.Value = sObj.Rotation.Y
            'IntegerInput_ObjRotZ.Value = sObj.Rotation.Z

            ''Model-ID
            'ComboBoxEx_ObjModelID.Text = TextFromValue(sObj.ModelID)

            ''Behavior-ID
            'ComboBoxEx_ObjBehavID.Text = TextFromValue(sObj.BehaviorID, If(Settings.General.IntegerValueMode >= 1, Settings.General.IntegerValueMode, 1))

            ''B. Params
            'ComboBoxEx_ObjBParam1.Text = TextFromValue(sObj.BParam1)
            'ComboBoxEx_ObjBParam2.Text = TextFromValue(sObj.BParam2)
            'ComboBoxEx_ObjBParam3.Text = TextFromValue(sObj.BParam3)
            'ComboBoxEx_ObjBParam4.Text = TextFromValue(sObj.BParam4)

            ''Object Combo
            'Dim objCombo As ObjectCombo  = myObjectCombos.GetObjectComboOfObject(sObj)
            'ComboBoxEx_ObjCombo.SelectedIndex = myObjectCombos.IndexOf(objCombo)

            ''B. Param Infos
            'LoadBParamInfo(objCombo)

            ''B. Param ComboBox Lists
            'ReloadBParamComboBoxes()

            'Panel_ObjectSettings.ResumeLayout()
            'loadingObj = False
        End Sub

        Friend Sub UpdateObjectListViewItems()
            If ListViewEx_Objects.Items.Count > 0 Then
                Dim cIndex As Integer = 0
                For Each item As ListViewItem In ListViewEx_Objects.Items
                    SetObjectPropertiesToListViewItem(item, ManagedObjects(ListViewEx_Objects.Items.IndexOf(item)), cIndex)
                    cIndex += 1
                Next
            End If
        End Sub

        Friend Sub SaveAllObjectProperties()
            For Each obj As Managed3DObject In ManagedObjects
                obj.SaveProperties()
            Next
        End Sub

        Friend Sub SaveSelectedObjectProperties()
            For Each obj As Managed3DObject In SelectedObjects
                obj.SaveProperties()
            Next
        End Sub

        Friend Sub ButtonItem_CopyObjCmdAsHex_Click(sender As Object, e As EventArgs) Handles ButtonItem_CopyObjCmdAsHex.Click, ButtonItem_CopyWarpCmdAsHex.Click
            Dim bytes As New List(Of Byte)
            Dim txt As String = ""

            For Each obj As Object In AdvPropertyGrid1.SelectedObjects
                Dim prop As PropertyInfo = obj.GetType.GetProperty("Command")
                If prop IsNot Nothing Then
                    bytes.AddRange(CType(prop.GetValue(obj), LevelscriptCommand).ToArray())
                End If
            Next

            For Each b As Byte In bytes
                txt &= " " & b.ToString("X2")
            Next

            Clipboard.SetText(txt.TrimStart(" "))
        End Sub

        Friend Sub ButtonItem_ObjectsEditorCmd_Click(sender As Object, e As EventArgs) Handles ButtonItem_ObjectsEditorCmd.Click
            Dim cmd As LevelscriptCommand = SelectedObject?.Command
            If cmd IsNot Nothing Then
                OpenHexEditor(cmd)
            End If
        End Sub

        Friend Sub ButtonItem33_Click(sender As Object, e As EventArgs) Handles ButtonItem33.Click
            Dim obj As Managed3DObject = SelectedObject
            Dim exists As Boolean = False

            For Each objCombo As ObjectCombo In ObjectCombos.Concat(ObjectCombosCustom)
                If obj.ModelID = objCombo.ModelID AndAlso obj.BehaviorID = objCombo.BehaviorAddress Then
                    exists = True
                End If
            Next

            If exists Then
                'MessageBoxEx.Show("There already exists at least one object combo with the same Model ID and the same Behavior Address.", "Duplicate Object Combos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ShowToastnotification(Panel_GLControl, "An object combo with the same Model ID and Behavior Address already exists!", eToastGlowColor.Green, 12000)
            Else
                Dim dialog As New StringInputDialog
                dialog.Titel = "New Object Combo Name"
                If dialog.ShowDialog = DialogResult.OK Then
                    Dim combo As New ObjectCombo
                    combo.BehaviorAddress = obj.BehaviorID
                    combo.ModelID = obj.ModelID
                    combo.Name = dialog.Value.Trim
                    ObjectCombosCustom.Add(combo)
                    SaveObjectCombos()
                    'MessageBoxEx.Show("Object Combo has been added successfully.<br/>The Object Combo will appear in the object combo list after you re-opend the Level Editor.", "Object Combo added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowToastnotification(Panel_GLControl, "Object Combo has been added successfully.<br/>The Object Combo will appear in the Object Combo list after you re-open the Level Editor.", eToastGlowColor.Green, 12000)
                End If
            End If
        End Sub

#Region "Object Position"

        Friend Sub Slider_ObjMoveSpeed_ValueChanged(sender As Object, e As EventArgs) Handles Slider_ObjMoveSpeed.ValueChanged
            Slider_ObjMoveSpeed.Text = $"Object Move Speed: {Slider_ObjMoveSpeed.Value}%"
        End Sub

        Friend Sub PictureBox_ObjCntr_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox_ObjCntrWheel.MouseDown, PictureBox_ObjCntrCross.MouseDown
            isObjMoving = True
        End Sub
        Friend Sub PictureBox_ObjCntr_MouseUp(sender As Object, e As EventArgs) Handles PictureBox_ObjCntrCross.MouseUp, PictureBox_ObjCntrWheel.MouseUp
            isObjMoving = False
        End Sub

        Friend Sub ChangeCamMode(sender As Object, e As EventArgs) Handles ButtonItem_CamTop.Click, ButtonItem_CamRight.Click, ButtonItem_CamOrbit.Click, ButtonItem_CamLeft.Click, ButtonItem_CamFront.Click, ButtonItem_CamFly.Click, ButtonItem_CamButtom.Click, ButtonItem_CamBack.Click
            Select Case True
                Case sender.Equals(ButtonItem_CamFly)
                    ogl.SetCameraMode(CameraMode.FLY)
                Case sender.Equals(ButtonItem_CamOrbit)
                    ogl.SetCameraMode(CameraMode.ORBIT)
                Case sender.Equals(ButtonItem_CamTop)
                    ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Top)
                Case sender.Equals(ButtonItem_CamButtom)
                    ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Bottom)
                Case sender.Equals(ButtonItem_CamFront)
                    ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Front)
                Case sender.Equals(ButtonItem_CamLeft)
                    ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Left)
                Case sender.Equals(ButtonItem_CamRight)
                    ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Right)
                Case sender.Equals(ButtonItem_CamBack)
                    ogl.SetCameraMode(CameraMode.LOOK_DIRECTION, LookDirection.Back)
            End Select
            ButtonX_CamMode.Text = sender.Text
        End Sub
        Friend Sub Slider_CamMoveSpeed_ValueChanged(sender As Object, e As EventArgs) Handles Slider_CamMoveSpeed.ValueChanged
            Dim camSpeed As Integer = Slider_CamMoveSpeed.Value
            Dim cam As Camera = Camera

            If cam IsNot Nothing Then
                cam.CamSpeedMultiplier = camSpeed / 100
            End If

            Slider_CamMoveSpeed.Text = $"Camera Move Speed: {Slider_CamMoveSpeed.Value}%"
        End Sub
        Friend Sub ButtonX_SetObjMoveSpeed(sender As Object, e As EventArgs) Handles ButtonX4.Click, ButtonX3.Click, ButtonX2.Click, ButtonX1.Click
            Slider_ObjMoveSpeed.Value = sender.Text.Replace("%", "")
        End Sub
        Friend Sub ButtonX_SetCamMoveSpeed(sender As Object, e As EventArgs) Handles ButtonX8.Click, ButtonX7.Click, ButtonX6.Click, ButtonX5.Click
            Slider_CamMoveSpeed.Value = sender.Text.Replace("%", "")
        End Sub

        Friend Sub KeepObjectsOnGround()
            Select Case True
                Case KeepObjectsOnNearestGround
                    DropObjectsToGround(0)
                Case KeepObjectsOnTop
                    DropObjectsToGround(1)
                Case KeepObjectsOnButtom
                    DropObjectsToGround(2)
            End Select
        End Sub

        Friend Sub DropObjectsToGround(mode As Byte)
            If EditObjects Then
                For Each obj As Managed3DObject In SelectedObjects
                    Dim oldPos As Numerics.Vector3 = obj.Position

                    Dim newY As Single = oldPos.Y
                    Select Case mode
                        Case 0
                            newY = CArea.AreaModel.Collision.DropToNearesGround(oldPos)
                        Case 1
                            newY = CArea.AreaModel.Collision.DropToTop(oldPos)
                        Case 2
                            newY = CArea.AreaModel.Collision.DropToButtom(oldPos)
                    End Select

                    Dim newPos As New Numerics.Vector3(oldPos.X, newY, oldPos.Z)
                    obj.Position = newPos

                    AdvPropertyGrid1_RefreshPropertyValues()
                Next

                ogl.UpdateOrbitCamera()
                ogl.Invalidate()
            End If
        End Sub

        Friend Sub IntegerInput_ObjRotX_Click(sender As Object, e As EventArgs)
            waitUntilLostFocus = False
        End Sub
        Friend Sub IntegerInput_ObjRotX_KeyPress(sender As Object, e As Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                waitUntilLostFocus = False
            End If
        End Sub

#End Region

#Region "Object Rotation"
        Friend Sub PictureBox_ObjRot_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox_ObjRotWheel.MouseDown, PictureBox_ObjRotCross.MouseDown
            isObjRotating = True
        End Sub
        Friend Sub PictureBox_ObjRot_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox_ObjRotWheel.MouseUp, PictureBox_ObjRotCross.MouseUp
            isObjRotating = False
        End Sub
#End Region

#Region "Model-ID & Behavior-ID"

        Friend Sub CheckObjCombo()
            Dim objcombo = MyObjectCombos.FirstOrDefault(Function(n) n.ModelID = SelectedObject.ModelID AndAlso n.BehaviorAddress = SelectedObject.BehaviorID)
            If objcombo Is Nothing Then Return

            For Each index As Integer In ListViewEx_Objects.SelectedIndices
                ListViewEx_Objects.Items(index).SubItems(1).Text = objcombo.Name
            Next
        End Sub

        Friend Sub ChangeObjectComboWithDialog()
            Dim objs As Managed3DObject() = SelectedObjects

            If objs.Any Then
                Dim dialog As New InformationListDialog(InformationListDialog.EditModes.EnableObjComboTab, MyObjectCombos)
                dialog.SelectedObjectCombo = MyObjectCombos.GetObjectComboOfObject(objs.First)

                If dialog.ShowDialog = DialogResult.OK Then
                    'Store History Point
                    StoreObjectHistoryPoint(objs, NameOf(Managed3DObject.ModelID), NameOf(Managed3DObject.BehaviorID))

                    'Change Object Combo by Name
                    For Each obj As Managed3DObject In SelectedObjects
                        obj.ObjectCombo = dialog.SelectedObjectCombo.Name
                    Next

                    UpdateObjectListViewItems()
                    AdvPropertyGrid1.RefreshPropertyValues()
                End If
            End If
        End Sub

        Friend Sub ChangeBehaviorWithDialog()
            Dim objs As Managed3DObject() = SelectedObjects

            If objs.Any Then
                Dim dialog As New InformationListDialog(InformationListDialog.EditModes.EnableBehavTab)
                dialog.SelectedBehavior = BehaviorInfos.GetByBehaviorAddress(objs.First.BehaviorID)

                If dialog.ShowDialog = DialogResult.OK Then
                    'Store History Point
                    StoreObjectHistoryPoint(objs, NameOf(Managed3DObject.BehaviorID))

                    'Change Object Combo by Name
                    For Each obj As Managed3DObject In SelectedObjects
                        obj.BehaviorID = dialog.SelectedBehavior.BehaviorAddress
                    Next

                    UpdateObjectListViewItems()
                    AdvPropertyGrid1.RefreshPropertyValues()
                End If
            End If
        End Sub

        Friend Sub ButtonItem_ChangeObjectCombo_Click(sender As Object, e As EventArgs) Handles ButtonItem_ChangeObjectCombo.Click, ButtonItem31.Click
            ChangeObjectComboWithDialog()
        End Sub

        Friend Sub ButtonItem30_Click(sender As Object, e As EventArgs) Handles ButtonItem30.Click, ButtonItem32.Click
            ChangeBehaviorWithDialog()
        End Sub

        Friend Sub RibbonBar27_DialogLauncherMouseDown(sender As Object, e As MouseEventArgs) Handles RibbonBar27.DialogLauncherMouseDown
            Dim dialog As New InformationListDialog(InformationListDialog.EditModes.Editable Or InformationListDialog.EditModes.EnableBehavTab Or InformationListDialog.EditModes.EnableObjComboTab)
            dialog.ShowDialog()

            'Reload Lists ...
            '...
        End Sub

#End Region

#Region "Add/Remove/Restore Objects"

        Friend Sub ButtonX_ObjectsAdd_Click(sender As Object, e As EventArgs) Handles ButtonX_ObjectsAdd.Click, ButtonItem43.Click, ButtonItem42.Click, ButtonItem41.Click, ButtonItem40.Click, ButtonItem39.Click, ButtonItem38.Click
            Dim newobjects As New List(Of Managed3DObject)
            Dim newlvis As New List(Of ListViewItem)
            Dim objcount As Integer = 0
            If Not Integer.TryParse(sender.Text, objcount) Then objcount = 1

            For i As Integer = 1 To objcount

                Dim newObjCmd As New LevelscriptCommand(LevelArea.DefaultNormal3DObject)
                CArea.Objects.Add(newObjCmd)

                Dim newObj As New Managed3DObject(newObjCmd, MyObjectCombos)
                ManagedObjects.Add(newObj)
                newobjects.Add(newObj)

                Dim lvi As New ListViewItem
                lvi.Tag = newObj
                lvi.SubItems.Add(New ListViewItem.ListViewSubItem)
                SetObjectPropertiesToListViewItem(lvi, newObj, ListViewEx_Objects.Items.Count)
                ListViewEx_Objects.Items.Add(lvi)
                newlvis.Add(lvi)

            Next

            'Store History Point
            StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes("RemoveObjects"),
                          AreaEditorHistoryFunctions.Methodes("AddObjects"),
                          {CArea, ManagedObjects, newobjects, ListViewEx_Objects.Items, newlvis})

            ogl.Invalidate()
        End Sub

        Friend Sub ResetObjToDefault(sender As Object, e As EventArgs) Handles ButtonItem_ResetObjToDefault.Click, ButtonItem64.Click
            Dim oldObjects As New List(Of Managed3DObject)
            Dim newObjects As New List(Of Managed3DObject)
            Dim indicies As New List(Of Integer)

            For Each index As Integer In ListViewEx_Objects.SelectedIndices

                Dim newObj As New LevelscriptCommand(LevelArea.DefaultNormal3DObject)
                Dim new3DObj As New Managed3DObject(newObj, MyObjectCombos)

                CArea.Objects(index) = newObj
                ManagedObjects(index) = new3DObj

                oldObjects.Add(ManagedObjects(index))
                newObjects.Add(new3DObj)
                indicies.Add(index)

            Next

            'Store History Point
            StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes("RevertObjects"),
                          AreaEditorHistoryFunctions.Methodes("RevertObjects"),
                          {CArea, ManagedObjects, indicies, oldObjects},
                          {CArea, ManagedObjects, indicies, newObjects})

            UpdateObjectListViewItems()
            ShowObjectProperties()
        End Sub

        Friend Sub RemoveSelectedObjects(sender As Object, e As EventArgs) Handles ButtonItem_ObjectsRemove.Click, ButtonItem65.Click
            If SelectedObject IsNot Nothing Then
                Dim indices(ListViewEx_Objects.SelectedIndices.Count - 1) As Integer
                ListViewEx_Objects.SelectedIndices.CopyTo(indices, 0)

                RemoveObjects(indices)
            End If
        End Sub

        Friend Sub RemoveAllEmptyObjects(sender As Object, e As EventArgs) Handles ButtonItem27.Click
            RemoveAllObjectsWhere(Function(mobj) mobj.BehaviorID = &H13000000 AndAlso mobj.ModelID = 0)
        End Sub

        Friend Sub RemoveAllUnusedObjects(sender As Object, e As EventArgs) Handles ButtonItem28.Click
            RemoveAllObjectsWhere(Function(mobj) Not (mobj.Act1 Or mobj.Act2 Or mobj.Act3 Or mobj.Act4 Or mobj.Act5 Or mobj.Act6))
        End Sub

        Friend Sub RemoveAllObjectsWhere(func As RemoveAllObjectsWhereExpression)
            Dim indices As New List(Of Integer)

            For i As Integer = 0 To CArea.Objects.Count - 1
                Dim mobj As Managed3DObject = ManagedObjects(i)
                If func.Invoke(mobj) Then
                    indices.Add(i)
                End If
            Next

            If indices.Any Then
                RemoveObjects(indices.ToArray)
            End If
        End Sub

        Friend Sub RemoveObjects(indices As Integer())
            Dim removedObjs As New Dictionary(Of Integer, Managed3DObject)
            Dim removedlvis As New Dictionary(Of Integer, ListViewItem)
            Dim removedCmds As New Dictionary(Of Integer, LevelscriptCommand)

            For Each index As Integer In indices.OrderByDescending(Function(n) n)
                Dim mobj As Managed3DObject = ManagedObjects(index)
                Dim lvi As ListViewItem = ListViewEx_Objects.Items(index)

                ManagedObjects.Remove(mobj)
                CArea.Objects.RemoveAt(index)
                ListViewEx_Objects.Items.Remove(lvi)

                removedObjs.Add(index, mobj)
                removedCmds.Add(index, mobj.Command)
                removedlvis.Add(index, lvi)
            Next

            'Store History Point
            StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes("InsertObjects"),
                          AreaEditorHistoryFunctions.Methodes("RemoveAtObjects"),
                          {CArea, ManagedObjects, ListViewEx_Objects.Items, removedObjs, removedlvis, removedCmds})

            UpdateObjectListViewItems()
            ogl.Invalidate()
        End Sub

#End Region

#Region "Object Model"

        Friend Sub ButtonItem23_Click(sender As Object, e As EventArgs) Handles ButtonItem_ExportObjectModel.Click, ButtonItem68.Click
            Dim modelID As Byte = SelectedObject.ModelID
            If ObjectModels.ContainsKey(modelID) Then
                ExportModel(ObjectModels(modelID).Model, Settings.FileParser.FileExporterModule)
            Else
                MessageBoxEx.Show("The Model wasn't found.", "Export Object Model", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

#End Region

#End Region

#Region "Warps"

        Friend Sub ShowWarpProterties()
            SetObjectsToPropertyGrid(SelectedWarps)
        End Sub

        Friend Sub UpdateWarpListViewItem()
            If ListViewEx_Warps.SelectedItems.Count > 0 Then
                For Each item As ListViewItem In ListViewEx_Warps.SelectedItems
                    If item.Selected Then
                        Dim cWarp As IManagedLevelscriptCommand = item.Tag
                        SetWarpPropertiesToListViewItem(item, cWarp)
                    End If
                Next
            End If
        End Sub

        Friend Sub SaveAllWarpProperties()
            For Each warp As IManagedLevelscriptCommand In ManagedWarps
                warp.SaveProperties()
            Next
        End Sub
        Friend Sub SaveSelectedWarpProperties()
            For Each warp As IManagedLevelscriptCommand In SelectedWarps
                warp.SaveProperties()
            Next
        End Sub

        Friend Sub ButtonX_WarpsEditCmd_Click(sender As Object, e As EventArgs) Handles ButtonX_WarpsEditCmd.Click
            Dim cmd As LevelscriptCommand = SelectedWarp?.Command
            If cmd IsNot Nothing Then
                OpenHexEditor(cmd)
            End If
        End Sub

#Region "Checking Destination Warp"

        Friend Function IsWarpDestinationValid(warp As ManagedWarp) As WarpDestinationValidationResult
            Dim myWarpObjCombos As ObjectCombo() = MyObjectCombos.Where(Function(n) n.Name.ToLower.Contains("warp")).ToArray
            Dim found As Byte = 0
            Dim foundLevel As Boolean = False

            'For Each obj As Managed3DObject In managedObjects
            '    If myWarpObjCombos.Where(Function(n) n.BehaviorID = obj.BehaviorID).Count > 0 _
            '        AndAlso obj.BParam2 = warp.DestWarpID Then
            '        found += 1
            '    End If
            '    If found = 0 Then
            '        Return WarpDestinationValidationResult.WarpSourceNotFound
            '    ElseIf found > 1 Then
            '        Return WarpDestinationValidationResult.WarpSourceUsedMultipleTimes
            '    Else
            '        foundLevel = True
            '        Exit For
            '    End If
            'Next

            'If found = 0 Then
            '    For Each level As Level In rommgr.Levels
            '        If Not foundLevel AndAlso level IsNot cLevel Then
            '            For Each area As LevelArea In level.Areas
            '                For Each obj As LevelscriptCommand In area.Objects
            '                    Dim behavID As Integer = clNormal3DObject.GetSegBehaviorAddr(obj)
            '                    If myWarpObjCombos.Where(Function(n) n.BehaviorID = behavID).Count > 0 _
            '                                    AndAlso clNormal3DObject.GetParams(obj).BParam2 = warp.DestWarpID Then
            '                        found += 1
            '                    End If
            '                Next
            '                If found = 0 Then
            '                    Return WarpDestinationValidationResult.WarpSourceNotFound
            '                ElseIf found > 1 Then
            '                    Return WarpDestinationValidationResult.WarpSourceUsedMultipleTimes
            '                Else
            '                    foundLevel = True
            '                    Exit For
            '                End If
            '            Next
            '        End If
            '    Next
            'End If

            Dim lvl As Level = Rommgr.Levels.FirstOrDefault(Function(n) n.LevelID = warp.DestLevelID)
            If lvl IsNot Nothing Then
                For Each area As LevelArea In lvl.Areas
                    If area.AreaID = warp.DestAreaID Then
                        found = 0
                        For Each cmd As LevelscriptCommand In area.Warps
                            If clWarp.GetWarpID(cmd) = warp.DestWarpID Then
                                found += 1
                            End If
                        Next
                        If found = 0 Then
                            Return WarpDestinationValidationResult.WarpDestNotFound
                        ElseIf found = 1 Then
                            found = 0
                            If lvl Is CLevel Then
                                For Each obj As Managed3DObject In ManagedObjects
                                    If myWarpObjCombos.Where(Function(n) n.BehaviorAddress = obj.BehaviorID).Count > 0 _
                                    AndAlso obj.BParam2 = warp.DestWarpID Then
                                        found += 1
                                    End If
                                Next
                            Else
                                For Each obj As LevelscriptCommand In area.Objects
                                    Dim behavID As Integer = clNormal3DObject.GetSegBehaviorAddr(obj)
                                    If myWarpObjCombos.Where(Function(n) n.BehaviorAddress = behavID).Count > 0 _
                                    AndAlso clNormal3DObject.GetParams(obj).BParam2 = warp.DestWarpID Then
                                        found += 1
                                    End If
                                Next
                            End If
                            If found = 0 Then
                                Return WarpDestinationValidationResult.WarpDestNotUsed
                            ElseIf found = 1 Then
                                Return WarpDestinationValidationResult.WarpFoundInCustomLevel
                            Else
                                Return WarpDestinationValidationResult.WarpDestUsedMultipleTimes
                            End If
                        Else
                            Return WarpDestinationValidationResult.DuplicatedWarpIDsAtDestination
                        End If
                    End If
                Next
                Return WarpDestinationValidationResult.AreaNotFound
            Else
                Return WarpDestinationValidationResult.LevelNotFound
            End If
        End Function

        Friend Function GetColorOfWarpDestinationValidationResult(warp As IManagedLevelscriptCommand) As Color
            If ({LevelscriptCommandTypes.PaintingWarp, LevelscriptCommandTypes.ConnectedWarp}).Contains(warp.Command.CommandType) Then
                Select Case IsWarpDestinationValid(warp)
                    Case WarpDestinationValidationResult.DuplicatedWarpIDsAtDestination, WarpDestinationValidationResult.WarpDestUsedMultipleTimes, WarpDestinationValidationResult.WarpSourceUsedMultipleTimes
                        Return Color.FromArgb(-4754112)
                    Case WarpDestinationValidationResult.WarpFoundInCustomLevel
                        Return Color.FromArgb(-9073592)
                    Case WarpDestinationValidationResult.AreaNotFound, WarpDestinationValidationResult.WarpDestNotFound, WarpDestinationValidationResult.WarpDestNotUsed
                        Return Color.FromArgb(-7324615)
                End Select
            End If
            Return Nothing
        End Function

        Friend Enum WarpDestinationValidationResult
            WarpFoundInCustomLevel
            DuplicatedWarpIDsAtDestination
            LevelNotFound
            AreaNotFound
            WarpDestNotFound
            WarpDestNotUsed
            WarpDestUsedMultipleTimes
            WarpSourceUsedMultipleTimes
            WarpSourceNotFound
        End Enum

#End Region

#Region "Add/Remove Warps"

        Friend Sub ButtonX_WarpsAddConnectedWarp_Click(sender As Object, e As EventArgs) Handles ButtonX_WarpsAddConnectedWarp.Click, ButtonX_WarpsAdd.Click
            AddWarps(1, LevelscriptCommandTypes.ConnectedWarp)
        End Sub
        Friend Sub ButtonX_WarpsAddPaintingWarp_Click(sender As Object, e As EventArgs) Handles ButtonX_WarpsAddPaintingWarp.Click
            AddWarps(1, LevelscriptCommandTypes.PaintingWarp)
        End Sub
        Friend Sub ButtonItem_WarpsAddInstantWarp_Click(sender As Object, e As EventArgs) Handles ButtonItem_WarpsAddInstantWarp.Click
            AddWarps(1, LevelscriptCommandTypes.InstantWarp)
        End Sub

        Friend Sub AddWarps(count As Integer, type As LevelscriptCommandTypes)
            If WarpTools.GetWarpsCountInLevel(CLevel) >= Byte.MaxValue Then
                ShowToastnotification(Panel_GLControl, "The maximum amount of warps per level has been reached. It is not possible to add more warps.", eToastGlowColor.Red)
            Else
                Dim newWarp As LevelscriptCommand = Nothing
                Dim newManagedWarp As IManagedLevelscriptCommand = Nothing

                Dim lvi As New ListViewItem
                For i As Integer = 2 To 4
                    lvi.SubItems.Add(New ListViewItem.ListViewSubItem)
                Next

                Select Case type
                    Case LevelscriptCommandTypes.ConnectedWarp
                        newWarp = New LevelscriptCommand({&H26, &H8, WarpTools.GetNextUnusedWarpID(CArea), LevelID, CArea.AreaID, &H0, &H0, &H0})
                        newManagedWarp = New ManagedWarp(newWarp)
                        lvi.Group = lvg_ConnectedWarps
                    Case LevelscriptCommandTypes.PaintingWarp
                        newWarp = New LevelscriptCommand({&H27, &H8, WarpTools.GetNextUnusedWarpID(CArea), LevelID, CArea.AreaID, &H0, &H0, &H0})
                        newManagedWarp = New ManagedWarp(newWarp)
                        lvi.Group = lvg_PaintingWarps
                    Case LevelscriptCommandTypes.InstantWarp
                        newWarp = New LevelscriptCommand({&H28, &HC, &H1B, CArea.AreaID, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0})
                        newManagedWarp = New ManagedInstantWarp(newWarp)
                        lvi.Group = lvg_InstantWarps
                    Case Else
                        Return
                End Select

                'Set managed warp as Tag of ListViewItem
                lvi.Tag = newManagedWarp

                CArea.Warps.Add(newWarp)
                ManagedWarps.Add(newManagedWarp)

                SetWarpPropertiesToListViewItem(lvi, newManagedWarp)
                ListViewEx_Warps.Items.Add(lvi)

                'Store History Point
                Dim dicGroups As New Dictionary(Of ListViewItem, ListViewGroup)
                dicGroups.Add(lvi, lvi.Group)
                StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes("RemoveWarps"),
                              AreaEditorHistoryFunctions.Methodes("AddWarps"),
                              {CArea, ManagedWarps, ({newManagedWarp}), ListViewEx_Warps.Items, ({lvi}), dicGroups})
            End If
        End Sub

        Friend Sub ButtonX_WarpsRemove_Click(sender As Object, e As EventArgs) Handles ButtonX_WarpsRemove.Click, ButtonItem23.Click
            If SelectedWarp IsNot Nothing Then

                Dim removedWarps As New Dictionary(Of Integer, IManagedLevelscriptCommand)
                Dim removedlvis As New Dictionary(Of Integer, ListViewItem)
                Dim removedCmds As New Dictionary(Of Integer, LevelscriptCommand)
                Dim dicGroups As New Dictionary(Of ListViewItem, ListViewGroup)

                Dim indices(ListViewEx_Warps.SelectedIndices.Count - 1) As Integer
                ListViewEx_Warps.SelectedIndices.CopyTo(indices, 0)
                indices = indices.OrderByDescending(Function(n) n).ToArray

                For Each index As Integer In indices
                    Dim curItem As ListViewItem = ListViewEx_Warps.Items(index)

                    If curItem.Group IsNot lvg_WarpsForGame Then

                        Dim mwarp As IManagedLevelscriptCommand = curItem.Tag
                        Dim cmd As LevelscriptCommand = mwarp.Command
                        Dim lvg As ListViewGroup = curItem.Group

                        Dim cmdIndex As Integer = CArea.Warps.IndexOf(cmd)
                        Dim mwarpIndex As Integer = ManagedWarps.IndexOf(mwarp)

                        removedWarps.Add(mwarpIndex, mwarp)
                        removedlvis.Add(index, curItem)
                        removedCmds.Add(cmdIndex, cmd)
                        dicGroups.Add(curItem, lvg)

                    End If
                Next

                For Each kvp As KeyValuePair(Of Integer, IManagedLevelscriptCommand) In removedWarps.OrderByDescending(Function(n) n.Key)
                    ManagedWarps.Remove(kvp.Value)
                Next
                For Each kvp As KeyValuePair(Of Integer, LevelscriptCommand) In removedCmds.OrderBy(Function(n) n.Key)
                    CArea.Warps.Remove(kvp.Value)
                Next
                For Each kvp As KeyValuePair(Of Integer, ListViewItem) In removedlvis.OrderBy(Function(n) n.Key)
                    ListViewEx_Warps.Items.Remove(kvp.Value)
                Next

                'Store History Point
                StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes("InsertWarps"),
                              AreaEditorHistoryFunctions.Methodes("RemoveAtWarps"),
                              {CArea, ManagedWarps, ListViewEx_Warps.Items, removedWarps, removedlvis, removedCmds, dicGroups})

            End If
        End Sub

#End Region

#Region "Tools"

        Friend Sub SetPauseMenuWarp()
            Dim warp As IManagedLevelscriptCommand = SelectedWarp
            If warp IsNot Nothing Then
                Dim lid, aid, wid As Short
                Dim err As Boolean = False

                If TypeOf warp Is ManagedWarp Then
                    lid = CLevel.LevelID
                    aid = CArea.AreaID
                    wid = CType(warp, ManagedWarp).WarpID
                Else
                    err = True
                End If

                If Not err Then
                    PatchClass.Open(Rommgr.GetBinaryRom(FileAccess.ReadWrite))
                    PatchClass.SetPauseMenuWarp(lid, aid, wid)
                    PatchClass.Close()
                    UpdateChecksum(Rommgr.RomFile)

                    ShowToastnotification(Panel_GLControl, "Pause Menu Warp set successfully", eToastGlowColor.Green)
                Else
                    ShowToastnotification(Panel_GLControl, "An error occurred while setting the Pause Menu Warp", eToastGlowColor.Red)
                End If
            End If
        End Sub

        Friend Sub ButtonItem29_Click(sender As Object, e As EventArgs) Handles ButtonItem29.Click
            SetPauseMenuWarp()
        End Sub

#End Region

#End Region

#Region "Collision Faces"

        Private Sub ShowColFaceProperties()

            SetObjectsToPropertyGrid(SelectedColFaces)
        End Sub

#End Region

#Region "AdvPropertyGrid1"

        Private Sub UpdateBParamNames()
            Dim obj As Managed3DObject = SelectedObject
            If obj IsNot Nothing Then
                Dim info As BehaviorInfo = BehaviorInfos.GetByBehaviorAddress(obj.BehaviorID)
                For i As Byte = 1 To 4
                    Dim n As Node = AdvPropertyGrid1.GetPropertyNode($"BParam{i}")
                    If n IsNot Nothing Then
                        Dim param As BehaviorInfo.BParam = info?.GetValue($"BParam{i}")
                        If param IsNot Nothing AndAlso param.Name <> "" Then
                            n.Text = param.Name
                            n.TagString = param.Name
                        Else
                            n.Text = $"Behavior Param {i}"
                            n.TagString = n.Text
                        End If
                    End If
                Next
            End If
        End Sub

        Friend Sub AdvPropertyGrid1_PropertyValueChanged(sender As Object, e As PropertyChangedEventArgs) Handles AdvPropertyGrid1.PropertyValueChanged
            Select Case e.PropertyName
                Case "AllActs", "Act1", "Act2", "Act3", "Act4", "Act5", "Act6"
                    AdvPropertyGrid1_RefreshPropertyValues()

                Case "Rotation", "Position"

                    ogl.UpdateOrbitCamera()
                    ogl.Invalidate()

                Case "ObjectCombo", "ModelID", "BehaviorID"

                    CheckObjCombo()
                    UpdateBParamNames()
                    AdvPropertyGrid1_RefreshPropertyValues()
                    ogl.UpdateOrbitCamera()
                    ogl.Invalidate()

            End Select

            UpdateObjectListViewItems()
            UpdateWarpListViewItem()
            ogl.UpdateOrbitCamera()
            ogl.Invalidate()
        End Sub

        Friend Sub AdvPropertyGrid1_PropertyValueChanging(sender As Object, e As PropertyValueChangingEventArgs) Handles AdvPropertyGrid1.PropertyValueChanging
            lastChangedPropertyName = e.PropertyName

            Select Case e.PropertyName
                Case "ObjectCombo", "ModelID", "BehaviorID"
                    StoreObjectHistoryPoint(AdvPropertyGrid1.SelectedObjects, {"ModelID", "BehaviorID"})
                Case Else
                    StoreObjectHistoryPoint(AdvPropertyGrid1.SelectedObjects, e.PropertyName)
            End Select
        End Sub

        Friend Sub AdvPropertyGrid1_PropertyTree_Paint(sender As Object, e As PaintEventArgs) Handles PropertyTree.Paint
            'Property names keep reverting back to their attribute-defined values when the property is selected.
            'This is the ugly workaround
            For i As Byte = 1 To 4
                Dim n As Node = AdvPropertyGrid1.GetPropertyNode($"BParam{i}")
                If n IsNot Nothing AndAlso n.TagString <> "" AndAlso n.TagString <> n.Text Then
                    n.Text = n.TagString
                End If
            Next
        End Sub

        'Friend Sub ProvideBParamContentList(sender As ContentSelectorEditor.ComboBoxEditor, e As EventArgs)
        '    Dim obj As Managed3DObject = SelectedObject
        '    Dim i As Byte

        '    If sender.Tag IsNot obj Then
        '        If sender Is bpMgr.CbEditorBParam1 Then
        '            i = 1
        '        ElseIf sender Is bpMgr.CbEditorBParam2 Then
        '            i = 2
        '        Else
        '            i = 0
        '        End If

        '        If i > 0 Then
        '            Dim info As BehaviorInfoList.BehaviorInfo = BehaviorInfos.GetByBehaviorAddress(obj.BehaviorID)
        '            If info IsNot Nothing Then
        '                Dim param As BehaviorInfoList.BParam = info.GetValue($"BParam{i}")

        '                sender.Items.Clear()

        '                If param IsNot Nothing Then
        '                    For Each kvp As KeyValuePair(Of String, Byte) In param.Values
        '                        Dim ci As New ComboItem
        '                        ci.Text = kvp.Key
        '                        ci.Tag = kvp.Value
        '                        sender.Items.Add(ci)
        '                    Next
        '                End If
        '            End If
        '        End If

        '        sender.Tag = obj
        '    End If
        'End Sub

        Friend Sub ButtonX_CamMode_Click(sender As Object, e As EventArgs) Handles ButtonX_CamMode.Click

        End Sub

#End Region

#Region "Collision"

#Region "Death Floor"

        Friend Sub ButtonItem8_Click(sender As Object, e As EventArgs) Handles ButtonItem8.Click
            Dim input As New Form_SetUpPoint("Death Floor Height", False, True, False, 0, 0, 0)
            If input.ShowDialog = DialogResult.OK Then
                Dim height As Short = input.IntegerInput_Y.Value
                AddDeathFloorAt(height)
            End If
        End Sub

        Friend Sub ButtonItem4_Click(sender As Object, e As EventArgs) Handles ButtonItem4.Click
            RemoveCollisionTrianglesWithCollisionType(&HA)
            maps.ReloadCollisionInOpenGL()
        End Sub

        Friend Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click
            Dim input As New ValueInputDialog With {.Text = "Remove faces"}
            input.InfoLabel.Text = "Collision type:"
            input.ValueTextBox.Text = 0
            If input.ShowDialog = DialogResult.OK Then
                Dim typ As Short = ValueFromText(input.ValueTextBox.Text)
                RemoveCollisionTrianglesWithCollisionType(typ)
            End If
        End Sub

        Friend Sub AddDeathFloorAt(height As Short)
            'Create vertices
            Dim v1 As New Collision.Vertex
            Dim v2 As New Collision.Vertex
            Dim v3 As New Collision.Vertex
            Dim v4 As New Collision.Vertex

            'Create faces
            Dim f1 As New Collision.Triangle
            Dim f2 As New Collision.Triangle

            'Build faces
            f1.Vertices(0) = v4
            f1.Vertices(1) = v1
            f1.Vertices(2) = v2

            f2.Vertices(0) = v4
            f2.Vertices(1) = v2
            f2.Vertices(2) = v3

            'Set collision to death floor
            f1.CollisionType = &HA
            f2.CollisionType = &HA

            'Set coordinates to vertices

            v1.X = Short.MaxValue
            v1.Z = Short.MaxValue
            v1.Y = height

            v2.X = Short.MaxValue
            v2.Z = Short.MinValue
            v2.Y = height

            v3.X = Short.MinValue
            v3.Z = Short.MinValue
            v3.Y = height

            v4.X = Short.MinValue
            v4.Z = Short.MaxValue
            v4.Y = height

            'Create collections
            Dim vs As Collision.Vertex() = {v1, v2, v3, v4}
            Dim ts As Collision.Triangle() = {f1, f2}

            'Add vertices
            CArea.AreaModel.Collision.Mesh.Vertices.AddRange(vs)

            'Add faces
            CArea.AreaModel.Collision.Mesh.Triangles.AddRange(ts)

            'Store history point
            StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes(NameOf(AreaEditorHistoryFunctions.RemoveFromCollision)),
                              AreaEditorHistoryFunctions.Methodes(NameOf(AreaEditorHistoryFunctions.AddToCollision)),
                              {Me, CArea.AreaModel.Collision.Mesh.Vertices, vs, CArea.AreaModel.Collision.Mesh.Triangles, ts})

            maps.ReloadCollisionInOpenGL()
        End Sub

        Friend Function IsVertexUsedInSM64Collision(v As Collision.Vertex) As Boolean
            For Each t As Collision.Triangle In CArea.AreaModel.Collision.Mesh.Triangles
                For Each vv As Collision.Vertex In t.Vertices
                    If vv Is v Then
                        Return True
                    End If
                Next
            Next
            Return False
        End Function

        Friend Sub RemoveCollisionTrianglesWithCollisionType(colType As Byte)
            Dim vs As New List(Of Collision.Vertex)
            Dim ts As New List(Of Collision.Triangle)

            'Remove faces
            For Each t As Collision.Triangle In CArea.AreaModel.Collision.Mesh.Triangles.ToArray
                If t.CollisionType = colType Then
                    ts.Add(t)
                    CArea.AreaModel.Collision.Mesh.Triangles.Remove(t)
                End If
            Next

            'Remove unused vertices
            For Each t As Collision.Triangle In ts
                For Each v As Collision.Vertex In t.Vertices
                    If Not IsVertexUsedInSM64Collision(v) Then
                        vs.Add(v)
                        CArea.AreaModel.Collision.Mesh.Vertices.Remove(v)
                    End If
                Next
            Next

            'Store history point
            If ts.Any Then
                StoreHistoryPoint(AreaEditorHistoryFunctions.Methodes(NameOf(AreaEditorHistoryFunctions.AddToCollision)),
                                  AreaEditorHistoryFunctions.Methodes(NameOf(AreaEditorHistoryFunctions.RemoveFromCollision)),
                                  {Me, CArea.AreaModel.Collision.Mesh.Vertices, vs.ToArray, CArea.AreaModel.Collision.Mesh.Triangles, ts.ToArray})
            End If

            maps.ReloadCollisionInOpenGL()
        End Sub

#End Region

#End Region

#Region "External Tools"

        Friend Sub ButtonItem34_Click(sender As Object, e As EventArgs) Handles ButtonItem34.Click
            'Texture Editor
            OpenTextureEditor()
        End Sub

        Private Sub ButtonItem36_Click(sender As Object, e As EventArgs) Handles ButtonItem36.Click
            'Area Model Textures
            '...
        End Sub

        Private Sub ButtonItem35_Click(sender As Object, e As EventArgs) Handles ButtonItem35.Click
            'Object Model Textures
            '...
        End Sub

        Friend Function LoadOtherTexturesCategories() As IEnumerable(Of TextureEditor.TextureCategory)
            'Load json for other textures
            Dim ot As JObject = JObject.Parse(File.ReadAllText(Path.Combine(MyDataPath, "Other\Other Textures.json")))
            Dim jblocks = ot("Blocks").ToObject(Of TextureBlocksJsonClass())
            Dim addresses = ot("Levelscripts to load").ToObject(Of String())
            Dim categories As New List(Of TextureEditor.TextureCategory)
            Dim catLevelTextures As New TextureEditor.TextureCategory With {.Name = "Level Textures"}

            'Read Textures
            Dim catOtherTextures As New TextureEditor.TextureCategory With {.Name = "Other Textures"}
            Dim data = Rommgr.GetBinaryRom(FileAccess.Read)
            Dim alreadyLoadedSegs As New Dictionary(Of Byte, SegmentedBank)
            Dim alreadyLoadedLevelscripts As New List(Of Integer)

            For Each jb As TextureBlocksJsonClass In jblocks
                Dim block As New TextureEditor.TextureBlock
                block.Name = jb.Name

                For Each jt As TextureInfosJsonClass In jb.Textures
                    Dim m As New Material
                    Dim segAddr As Integer = Convert.ToInt32(jt.FromSegmentAddress, 16)
                    Dim seg As SegmentedBank = Nothing
                    Dim bmp As New Bitmap(CInt(jt.Width), CInt(jt.Height))
                    Dim texFormat As N64Codec = [Enum].Parse(GetType(N64Codec), jt.Format, True)
                    Dim bytesCount As Integer = N64Graphics.PixelsToBytes(texFormat, bmp.Width * bmp.Height)
                    Dim loadLvlscript As Integer = If(String.IsNullOrEmpty(jt.LoadLvlscript), -1, Convert.ToInt32(jt.LoadLvlscript, 16))
                    Dim bankID As Byte = segAddr >> 24

                    'Get segmented
                    If loadLvlscript > -1 Then
                        If Not alreadyLoadedLevelscripts.Contains(loadLvlscript) Then
                            Dim script As New Levelscript
                            Dim endcmd As LevelscriptCommandTypes
                            Select Case loadLvlscript
                                Case &H269EA0
                                    endcmd = LevelscriptCommandTypes.x1D
                                Case &H454AE8
                                    endcmd = LevelscriptCommandTypes.LoadRomToRam
                                Case Else
                                    endcmd = LevelscriptCommandTypes.EndOfLevel
                            End Select
                            script.Read(Rommgr, loadLvlscript, endcmd, alreadyLoadedSegs, False)
                            alreadyLoadedLevelscripts.Add(loadLvlscript)
                        End If
                        If alreadyLoadedSegs.ContainsKey(bankID) Then
                            seg = alreadyLoadedSegs(bankID)
                        End If
                    End If
                    If seg Is Nothing Then
                        seg = Rommgr.GetSegBank(bankID)
                    End If

                    'Read texture data
                    Dim imgdata As Byte()
                    Dim isMIO0 As Boolean = seg?.IsMIO0
                    If isMIO0 Then
                        seg.ReadDataIfNull(data.BaseStream)
                        seg.Data.Position = seg.BankOffsetFromSegAddr(segAddr)
                        Dim bindata As New BinaryStreamData(seg.Data)
                        imgdata = bindata.Read(bytesCount)
                    Else
                        data.Position = seg.SegToRomAddr(segAddr)
                        imgdata = data.Read(bytesCount)
                    End If

                    'Render Texture
                    Dim g = Drawing.Graphics.FromImage(bmp)
                    N64Graphics.RenderTexture(g, imgdata, Nothing, 0, bmp.Width, bmp.Height, 1, texFormat, N64IMode.AlphaCopyIntensity)

                    'Set image
                    m.Image = bmp

                    'Set Tag
                    m.Tag = New Conversion.Fast3DParsing.TextureLoadedInfos(jt.Name, texFormat, segAddr, -1, seg.SegToRomAddr(segAddr), -1, bmp.Size, isMIO0)

                    block.Textures.Add(m)
                Next

                catOtherTextures.Blocks.Add(block)
            Next

            data.Close()
            categories.Add(catOtherTextures)

            'Add all area model textures
            If maps.cVisualMap IsNot Nothing Then
                Dim block As New TextureEditor.TextureBlock
                block.Name = "Area Model"

                For Each kvp In maps.cVisualMap.Materials
                    If kvp.Value.Image IsNot Nothing Then
                        block.Textures.Add(kvp.Value)
                    End If
                Next

                catLevelTextures.Blocks.Add(block)
            End If

            'Add all other textures
            If ObjectModels.Any Then
                Dim block As New TextureEditor.TextureBlock
                block.Name = "Object Models"

                For Each kvpp In ObjectModels
                    For Each kvp In kvpp.Value.Model.Materials
                        If kvp.Value.Image IsNot Nothing Then
                            block.Textures.Add(kvp.Value)
                        End If
                    Next
                Next

                catLevelTextures.Blocks.Add(block)
            End If

            If catLevelTextures.Blocks.Any Then
                categories.Add(catLevelTextures)
            End If

            Return categories
        End Function

        Friend Sub OpenTextureEditor()
            'Load other textures and create categories
            Dim otherTextures_Categories As IEnumerable(Of TextureEditor.TextureCategory) = LoadOtherTexturesCategories()

            'Take texture snapshot
            Dim dic As Dictionary(Of Material, Image) = maps.TakeSnapshotOfCurrentModelTextures()

            'Open Texture Editor
            Dim frm As New TextureEditor(Rommgr, otherTextures_Categories.ToArray)

            'Update textures
            AddHandler frm.TextureReplaced,
                Sub()
                    maps.UpdateTexturesOfCurrentModel(dic)
                    dic = maps.TakeSnapshotOfCurrentModelTextures
                End Sub

            'Show the editor
            frm.Show()
        End Sub

        Private Sub PictureBox_ObjCntr_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox_ObjCntrWheel.MouseUp, PictureBox_ObjCntrCross.MouseUp

        End Sub

#End Region

    End Class

End Namespace
