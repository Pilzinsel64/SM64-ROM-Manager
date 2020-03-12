Imports DevComponents.DotNetBar
Imports SM64Lib
Imports SM64Lib.Levels

Public Class ImportLevelDialog

    Private rommgr As RomManager
    Private openrom As RomManager = Nothing
    Private addAreasOnly As Boolean
    Private destLevel As Level = Nothing
    Private openrompath As String
    Private lvlmgr As ILevelManager

    Public ReadOnly Property LevelCopy As Level = Nothing
    Public ReadOnly Property AreasCopy As LevelArea() = Nothing

    Public Sub New(rommgr As RomManager, destLevel As Level, romPath As String, lvlmgr As ILevelManager)
        InitializeComponent()
        UpdateAmbientColors
        Me.rommgr = rommgr
        Me.destLevel = destLevel
        addAreasOnly = destLevel IsNot Nothing
        openrompath = romPath
        Me.lvlmgr = lvlmgr
    End Sub

    Public Async Function LoadROM() As Task(Of Boolean)
        Dim mgr As New RomManager(openrompath, lvlmgr)
        If mgr.CheckROM() Then
            openrom = mgr
            LabelX_Romfile.Text = IO.Path.GetFileName(mgr.RomFile)
            Enabled = False
            CircularProgress1.Start()
            Await Task.Run(Sub() mgr.LoadLevels())
            CircularProgress1.Stop()
            Enabled = True
            LoadLevels()
            Return True
        Else
            MessageBoxEx.Show("This ROM can't be used.", "Invalid ROM file", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Sub LoadLevels()
        ItemListBox_Levels.Items.Clear()

        If openrom IsNot Nothing Then
            For Each lvl As Level In openrom.Levels
                Dim lid As LevelInfoDataTabelList.Level = rommgr.LevelInfoData.GetByLevelID(lvl.LevelID)
                Dim btn As New ButtonItem With {
                    .Text = If(lid.Type = LevelInfoDataTabelList.LevelTypes.Level, CByte(lid.Number).ToString("00") & " - ", "") & lid.Name,
                    .Tag = lvl
                }
                ItemListBox_Levels.Items.Add(btn)
            Next
        End If

        If ItemListBox_Levels.Items.Count > 0 Then
            ItemListBox_Levels.SelectedIndex = 0
        End If

        ItemListBox_Levels.Refresh()
    End Sub

    Private Function GetSelectedLevel() As Level
        Dim selItem As ButtonItem = ItemListBox_Levels.SelectedItem
        Dim lvl As Level = selItem?.Tag
        Return lvl
    End Function

    Private Sub ButtonX_Import_Click(sender As Object, e As EventArgs) Handles ButtonX_Import.Click
        Dim lvl As Level = GetSelectedLevel()
        Dim levelinfo As LevelInfoDataTabelList.Level

        If lvl IsNot Nothing Then
            Dim newLvl As Level
            Dim copySM64EArea =
                Sub(a As LevelArea, newArea As LevelArea)
                    newArea.Background.Type = a.Background.Type
                    newArea.Background.Color = a.Background.Color
                    'newArea.BGMusic = a.BGMusic
                    newArea.TerrainType = a.TerrainType
                    newArea.Objects.AddRange(a.Objects.ToArray)
                    newArea.Warps.AddRange(a.Warps.ToArray)
                    newArea.WarpsForGame.AddRange(a.WarpsForGame.ToArray)
                    newArea.AreaModel = a.AreaModel
                End Sub

            If addAreasOnly Then
                Dim areasToAsdd As New List(Of LevelArea)
                Dim availableAreaIDs As Stack(Of Byte)

                newLvl = destLevel

                'Get all available area ids
                availableAreaIDs = Publics.GetAllFreeAreaIDs(destLevel)

                'Get selected Areas
                Dim areasToCopy As New List(Of LevelArea)
                For Each item As CheckBoxItem In ItemPanel_Areas.Items
                    If TypeOf item.Tag Is LevelArea AndAlso item.Checked Then
                        areasToCopy.Add(item.Tag)
                    End If
                Next

                If availableAreaIDs.Count >= areasToCopy.Count Then
                    'Copy areas
                    For Each area As LevelArea In areasToCopy
                        If openrom.IsSM64EditorMode Then
                            Dim newArea As New SM64ELevelArea(availableAreaIDs.Pop)
                            copySM64EArea(area, newArea)
                            area = newArea
                        Else
                            area.AreaID = availableAreaIDs.Pop
                        End If

                        areasToAsdd.Add(area)
                    Next

                    'Add areas
                    newLvl.Areas.AddRange(areasToAsdd)
                    _AreasCopy = areasToAsdd.ToArray

                    'Close Window
                    DialogResult = DialogResult.OK
                ElseIf Not areasToCopy.Any Then
                    MessageBoxEx.Show("You haven't selected any area to copy.", "No area selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBoxEx.Show("You have to many areas selected. The destination level hasn't enough free area slots.", "To many areas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Dim selector As New LevelSelectorDialog(rommgr)
                If selector.ShowDialog = DialogResult.OK Then
                    levelinfo = selector.SelectedLevel

                    Select Case openrom.IsSM64EditorMode
                        Case True

                            'Create mew Level
                            newLvl = New RMLevel(levelinfo.ID, levelinfo.Index)

                            'Create new Areas & Copy Area Data
                            For Each a As LevelArea In lvl.Areas
                                Dim newArea As New RMLevelArea(a.AreaID, newLvl.LevelID, False, False)
                                copySM64EArea(a, newArea)
                                newLvl.Areas.Add(newArea)
                            Next

                            'Copy Level Data
                            newLvl.Background.Enabled = lvl.Background.Enabled
                            newLvl.Background.ID = lvl.Background.ID
                            newLvl.Background.ImageData = lvl.Background.ImageData
                            newLvl.Background.IsCustom = lvl.Background.IsCustom
                            newLvl.HardcodedCameraSettings = lvl.HardcodedCameraSettings
                            newLvl.ActSelector = lvl.ActSelector

                        Case False

                            newLvl = lvl
                            newLvl.LevelID = levelinfo.ID

                        Case Else

                            newLvl = Nothing

                    End Select

                    If newLvl IsNot Nothing Then
                        'Add Level
                        rommgr.Levels.Add(newLvl)
                        _LevelCopy = newLvl

                        'Close Window
                        DialogResult = DialogResult.OK
                    Else
                        MessageBoxEx.Show("The level can't be added.", "Add Level", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ItemListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemListBox_Levels.SelectedIndexChanged
        ButtonX_Import.Enabled = ItemListBox_Levels.SelectedIndex > -1
    End Sub

    Private Sub ItemListBox_Levels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemListBox_Levels.SelectedIndexChanged
        Dim enableListBox As Boolean = False
        Dim lvl As Level = GetSelectedLevel()

        ItemPanel_Areas.SuspendLayout()
        ItemPanel_Areas.Items.Clear()

        If lvl IsNot Nothing Then
            For Each area As LevelArea In lvl.Areas
                Dim item As New CheckBoxItem With {
                    .Tag = area,
                    .Text = "Area " & area.AreaID,
                    .Checked = True
                }
                ItemPanel_Areas.Items.Add(item)
            Next

            If addAreasOnly Then
                enableListBox = True
            End If
        End If

        ItemPanel_Areas.ResumeLayout(False)
        ItemPanel_Areas.Refresh()
        ItemPanel_Areas.Enabled = enableListBox
    End Sub

    Private Async Sub ImportLevelDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not Await LoadROM() Then
            DialogResult = DialogResult.Abort
        End If
    End Sub

End Class
