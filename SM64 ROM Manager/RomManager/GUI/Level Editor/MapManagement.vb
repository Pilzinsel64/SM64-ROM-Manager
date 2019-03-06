﻿Imports System.IO
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports OpenTK
Imports TextValueConverter
Imports SM64Lib.Levels
Imports SM64Lib.Levels.Script, SM64Lib.Levels.Script.Commands
Imports OpenTK.Graphics.OpenGL
Imports OpenGLFactory.RenderingN
Imports SM64Lib.Geolayout.Script.Commands
Imports System.ComponentModel
Imports S3DFileParser
Imports SM64Lib.Model.Fast3D.DisplayLists
Imports OpenGLFactory.CameraN
Imports SM64_ROM_Manager.SettingsManager
Imports SM64Lib.Geolayout
Imports SM64Lib.Model
Imports ModelConverterGUI
Imports SimpleHistory
Imports System.Reflection
Imports DevComponents.Editors
Imports SM64_ROM_Manager.PropertyValueEditors
Imports Publics
Imports DevComponents.AdvTree
Imports System.Timers
Imports Newtonsoft.Json.Linq
Imports SM64Lib.Data

Namespace LevelEditor

    Public Class MapManagement

        Private WithEvents Main As Form_AreaEditor

        Private hashVisualMap As Integer = 0
        Private hashCollisionMap As Integer = 0
        Friend cVisualMap As Object3D = Nothing
        Friend cCollisionMap As Object3D = Nothing
        Friend rndrVisualMap As Renderer = Nothing
        Friend rndrCollisionMap As Renderer = Nothing

        Public Sub New(main As Form_AreaEditor)
            Me.Main = main

            AddHandler main.ButtonItem_ExportCollision.Click, AddressOf ButtonItem_ExportCollision_Click
            AddHandler main.ButtonItem86.Click, AddressOf ButtonItem_ExportCollision_Click
            AddHandler main.ButtonItem_ExportVisualMap.Click, AddressOf ButtonItem_ExportVisualMap_Click
        End Sub

        Private ReadOnly Property Ogl As OpenGLManager
            Get
                Return Main.ogl
            End Get
        End Property

        Private ReadOnly Property Maps As MapManagement
            Get
                Return Main.maps
            End Get
        End Property

        Private ReadOnly Property ObjectControlling As ObjectControlling
            Get
                Return Main.objectControlling
            End Get
        End Property

        Public ReadOnly Property IsCollisionMapNothing
            Get
                Return cCollisionMap Is Nothing
            End Get
        End Property

        Friend Sub ReleaseBuffers()
            For Each kvp As KeyValuePair(Of Byte, Renderer) In Main.objectModels
                kvp.Value.ReleaseBuffers()
            Next

            rndrVisualMap?.ReleaseBuffers()
            rndrCollisionMap?.ReleaseBuffers()
        End Sub

        Friend Sub CheckAndLoadNew()
            ogl.MakeCurrent()
            Dim loadAreaIDs As Boolean = False

            If Main.cArea Is Nothing Then
                loadAreaIDs = True
            End If

            If Main.cLevel.Areas.Count <> Main.ComboBoxItem_Area.Items.Count Then
                loadAreaIDs = True
            Else
                For Each ci As ComboItem In Main.ComboBoxItem_Area.Items
                    If Not Main.cLevel.Areas.Contains(ci.Tag) Then
                        loadAreaIDs = True
                    End If
                Next
            End If

            If loadAreaIDs Then
                Main.LoadAreaIDs()
            Else
                Dim loadAreaMdl As Boolean = False
                If hashCollisionMap <> Main.cArea.AreaModel.Collision.GetHashCode Then
                    hashCollisionMap = 0
                    cCollisionMap = Nothing
                    If ogl.CurrentModelDrawMod = ModelDrawMod.Collision Then
                        loadAreaMdl = True
                    End If
                End If
                If hashVisualMap <> Main.cArea.AreaModel.Fast3DBuffer.GetBuffer.GetHashCode Then
                    hashVisualMap = 0
                    cVisualMap = Nothing
                    If ogl.CurrentModelDrawMod = ModelDrawMod.VisualMap Then
                        loadAreaMdl = True
                    End If
                End If
                If loadAreaMdl Then
                    maps.LoadAreaModel()
                End If
            End If
        End Sub

        Friend Sub LoadAreaModel()
            LoadAreaModel(ogl.CurrentModelDrawMod)
        End Sub

        Friend Sub LoadAreaModel(modelMode As ModelDrawMod)
            If Main.cArea IsNot Nothing Then
                Main.ProgressControl(True)

                Select Case modelMode
                    Case ModelDrawMod.Collision
                        If cCollisionMap Is Nothing Then
                            LoadAreaCollisionAsObject3D()
                            rndrCollisionMap?.ReleaseBuffers()
                            rndrCollisionMap = Nothing
                        End If
                        If rndrCollisionMap Is Nothing Then
                            rndrCollisionMap = New Renderer(cCollisionMap)
                            rndrCollisionMap.RenderModel()
                            LoadCollisionLists()
                        End If
                    Case ModelDrawMod.VisualMap
                        If cVisualMap Is Nothing Then
                            LoadAreaVisualMapAsObject3D()
                            rndrVisualMap?.ReleaseBuffers()
                            rndrVisualMap = Nothing
                        End If
                        If rndrVisualMap Is Nothing Then
                            rndrVisualMap = New Renderer(cVisualMap)
                            rndrVisualMap.RenderModel()
                        End If
                End Select
                ogl.Invalidate()

                Main.ProgressControl(False)

                'Console.WriteLine("Done!")
            End If
        End Sub

        Friend Sub LoadAreaCollisionAsObject3D()
            hashCollisionMap = Main.cArea.AreaModel.Collision.GetHashCode
            cCollisionMap = AwaitOnUI(Main.cArea.AreaModel.Collision.ToObject3DAsync)
        End Sub

        Friend Sub LoadAreaVisualMapAsObject3D()
            hashVisualMap = Main.cArea.AreaModel.Fast3DBuffer.GetBuffer.GetHashCode
            cVisualMap = AwaitOnUI(LoadAreaVisualMapAsObject3DAsync(Main.rommgr, Main.cArea))
        End Sub

        Public Sub LoadCollisionLists()
            Main.ListViewEx_ColFaces.SuspendLayout()
            Main.ListViewEx_CollVertices.SuspendLayout()

            Main.ListViewEx_ColFaces.Items.Clear()
            Main.ListViewEx_CollVertices.Items.Clear()

            If Main.cArea.AreaModel.Collision IsNot Nothing Then
                Dim vertCounter As Integer = 0
                Dim faceCounter As Integer = 0

                For Each mesh As Mesh In cCollisionMap.Meshes
                    Dim lvg_verts As New ListViewGroup

                    For Each vert As Vertex In mesh.Vertices
                        Dim lvi As New ListViewItem(vertCounter)
                        lvi.SubItems.Add(vert.X.ToString)
                        lvi.SubItems.Add(vert.Y.ToString)
                        lvi.SubItems.Add(vert.Z.ToString)
                        lvi.Tag = vert
                        lvi.Group = lvg_verts
                        Main.ListViewEx_CollVertices.Items.Add(lvi)
                        vertCounter += 1
                    Next

                    Dim lvg_faces As New ListViewGroup
                    Dim vertsCountBefore As Integer = vertCounter - mesh.Vertices.Count

                    For Each f As Face In mesh.Faces
                        Dim lvi As New ListViewItem(faceCounter)
                        For Each p As Point In f.Points
                            lvi.SubItems.Add(mesh.Vertices.IndexOf(p.Vertex) + vertsCountBefore)
                        Next
                        lvi.SubItems.Add(f.Tag.ToString)
                        lvi.Tag = f
                        lvi.Group = lvg_faces
                        Main.ListViewEx_ColFaces.Items.Add(lvi)
                        faceCounter += 1
                    Next
                Next
            End If

            Main.ListViewEx_ColFaces.ResumeLayout()
            Main.ListViewEx_CollVertices.ResumeLayout()
        End Sub

        Friend Sub ButtonItem_ExportCollision_Click(sender As Object, e As EventArgs)
            If Main.cArea.AreaModel.Collision IsNot Nothing Then
                LoadAreaModel(ModelDrawMod.Collision)
                ExportModel(rndrCollisionMap.Model, Settings.FileParser.FileExporterModule)
            End If
        End Sub

        Friend Sub ButtonItem_ExportVisualMap_Click(sender As Object, e As EventArgs)
            If Main.cArea.AreaModel.Fast3DBuffer IsNot Nothing Then
                LoadAreaModel(ModelDrawMod.VisualMap)
                ExportModel(rndrVisualMap.Model, Settings.FileParser.FileExporterModule)
            End If
        End Sub

        Friend Sub UpdateTexturesOfCurrentModel(snapshot As Dictionary(Of Material, Image))
            If cVisualMap IsNot Nothing AndAlso maps.rndrVisualMap IsNot Nothing Then
                For Each kvp In snapshot
                    If kvp.Value IsNot kvp.Key.Image Then
                        rndrVisualMap.UpdateTexture(kvp.Value, kvp.Key.Image)
                    End If
                Next
                Ogl.Invalidate()
            End If
        End Sub

        Friend Function TakeSnapshotOfCurrentModelTextures() As Dictionary(Of Material, Image)
            Dim dic As New Dictionary(Of Material, Image)

            If cVisualMap IsNot Nothing Then
                For Each kvp In cVisualMap.Materials
                    Dim img As Image = kvp.Value.Image
                    If img IsNot Nothing Then
                        dic.Add(kvp.Value, img)
                    End If
                Next
            End If

            Return dic
        End Function

        Public Sub ImportAreaModel(convertModel As Boolean, convertCollision As Boolean)
            Dim frm As New MainModelConverter
            frm.CheckBoxX_ConvertModel.Checked = convertModel
            frm.CheckBoxX_ConvertCollision.Checked = convertCollision

            With Main.cArea

                If frm.ShowDialog() <> DialogResult.OK Then
                    ogl.MakeCurrent()
                    Return
                End If

                ogl.MakeCurrent()
                Main.SuspendLayout()

                Dim hp As HistoryPoint = Nothing
                Dim OldAreaModel As ObjectModel = .AreaModel

                If frm.CheckBoxX_ConvertCollision.Checked AndAlso frm.CheckBoxX_ConvertModel.Checked Then

                    hp = HistoryPoint.FromObject(CObj(Me), ObjectValueType.Field, New MemberWhiteList({"rndrVisualMap", "cVisualMap", "rndrCollisionMap", "cCollisionMap"}), BindingFlags.Instance Or BindingFlags.NonPublic)
                    Dim os As New ObjectState
                    os.Object = Main.cArea
                    os.ValueToPatch = .AreaModel
                    os.MemberFlags = BindingFlags.Instance Or BindingFlags.Public
                    os.MemberType = ObjectValueType.Property
                    os.MemberName = "AreaModel"
                    hp.States.Add(os)

                    .AreaModel = frm.ResModel
                    .AreaModel.Collision.SpecialBoxes = OldAreaModel.Collision.SpecialBoxes
                    cVisualMap = Nothing
                    cCollisionMap = Nothing

                ElseIf frm.CheckBoxX_ConvertCollision.Checked Then

                    hp = HistoryPoint.FromObject(CObj(Me), ObjectValueType.Field, New MemberWhiteList({"rndrCollisionMap", "cCollisionMap"}), BindingFlags.Instance Or BindingFlags.NonPublic)
                    Dim os As New ObjectState
                    os.Object = Main.cArea.AreaModel
                    os.ValueToPatch = .AreaModel.Collision
                    os.MemberFlags = BindingFlags.Instance Or BindingFlags.Public
                    os.MemberType = ObjectValueType.Property
                    os.MemberName = "Collision"
                    hp.States.Add(os)

                    .AreaModel.Collision = frm.ResModel.Collision
                    .AreaModel.Collision.SpecialBoxes = OldAreaModel.Collision.SpecialBoxes
                    cCollisionMap = Nothing

                ElseIf frm.CheckBoxX_ConvertModel.Checked Then

                    hp = HistoryPoint.FromObject(CObj(Me), ObjectValueType.Field, New MemberWhiteList({"rndrVisualMap", "cVisualMap"}), BindingFlags.Instance Or BindingFlags.NonPublic)
                    Dim os As New ObjectState
                    os.Object = Main.cArea.AreaModel
                    os.ValueToPatch = .AreaModel.Fast3DBuffer
                    os.MemberFlags = BindingFlags.Instance Or BindingFlags.Public
                    os.MemberType = ObjectValueType.Property
                    os.MemberName = "Fast3DBuffer"
                    hp.States.Add(os)

                    .AreaModel = frm.ResModel
                    .AreaModel.Collision = OldAreaModel.Collision
                    cVisualMap = Nothing

                End If

                If frm.CheckBoxX_ConvertModel.Checked Then
                    .ScrollingTextures.Clear()
                    .ScrollingTextures.AddRange(.AreaModel.Fast3DBuffer.ConvertResult.ScrollingCommands.ToArray)
                End If

                If hp IsNot Nothing AndAlso (hp.States.Count > 0 OrElse hp.Actions.Count > 0) Then
                    Main.history.Store(hp)
                End If

            End With

            Main.cArea.SetSegmentedBanks(Main.rommgr)
            LoadAreaModel()

            Main.ResumeLayout()
        End Sub

        Friend Sub ReloadCollisionInOpenGL()
            cCollisionMap = Nothing
            LoadAreaModel()
        End Sub

    End Class

End Namespace