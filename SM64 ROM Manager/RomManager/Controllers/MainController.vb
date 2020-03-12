Imports System.IO
Imports SM64_ROM_Manager.SettingsManager
Imports SM64Lib
Imports SM64_ROM_Manager.Publics
Imports SM64_ROM_Manager.My.Resources
Imports SM64_ROM_Manager.EventArguments
Imports System.Threading
Imports DevComponents.DotNetBar
Imports SM64Lib.Exceptions
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Microsoft.WindowsAPICodePack.Dialogs.Controls
Imports System.Collections.Specialized
Imports SM64Lib.Music
Imports SM64Lib.Levels
Imports SM64Lib.Text.Profiles
Imports SM64Lib.Text
Imports SM64_ROM_Manager.LevelEditor
Imports System.Numerics
Imports SM64Lib.Levels.Script.Commands
Imports SM64_ROM_Manager.ModelConverterGUI
Imports SM64Lib.Geolayout
Imports SM64Lib.Model
Imports SM64Lib.Script
Imports SM64Lib.ObjectBanks
Imports Pilz.S3DFileParser
Imports SM64Lib.Levels.Script
Imports System.Net.NetworkInformation
Imports System.Net
Imports System.Reflection
Imports SM64Lib.Data
Imports Pilz.Reflection.PluginSystem
Imports SM64Lib.EventArguments
Imports SM64_ROM_Manager.Updating
Imports SM64_ROM_Manager.Updating.Client.GUI
Imports SM64_ROM_Manager.PatchScripts
Imports SM64Lib.Configuration
Imports SM64_ROM_Manager.UserRequests.GUI
Imports SM64_ROM_Manager.UserRequests

Public Class MainController

    'E v e n t s

    Public Event RomLoading()
    Public Event RomLoaded()
    Public Event RomMusicLoaded()
    Public Event RomLevelsLoaded()
    Public Event StatusTextChanged(e As StatusTextChangedEventArgs)
    Public Event OtherStatusInfosChanged(e As OtherStatusInfosChangedEventArgs)
    Public Event RecentFilesChanged()
    Public Event RomFileRenamed()
    Public Event RomFileDeleted()
    Public Event RomFileChanged()
    Public Event RomChangesAvailable(e As RomChangesAvaiableEventArgs)
    Public Event MusicSequenceRemoved(e As MusicSequenceEventArgs)
    Public Event MusicSequenceAdded(e As MusicSequenceEventArgs)
    Public Event MusicSequenceChanged(e As MusicSequenceEventArgs)
    Public Event RequestIsChangingTab(e As EnabledEventArgs)
    Public Event LevelSpecialItemAdded(e As SpecialItemEventArgs)
    Public Event LevelSpecialItemRemoved(e As SpecialItemEventArgs)
    Public Event LevelSpecialItemChanged(e As SpecialItemEventArgs)
    Public Event LevelAdded(e As LevelEventArgs)
    Public Event LevelRemoved(e As LevelEventArgs)
    Public Event LevelAreaAdded(e As LevelAreaEventArgs)
    Public Event LevelAreaRemoved(e As LevelAreaEventArgs)
    Public Event LevelIDChanged(e As LevelEventArgs)
    Public Event LevelCustomNameChanged(e As LevelEventArgs)
    Public Event LevelBackgroundModeChanged(e As LevelBackgroundModeChangedEventArgs)
    Public Event LevelBackgroundImageChanged(e As LevelBackgroundImageChangedEventArgs)
    Public Event LevelAreaBackgroundModeChanged(e As LevelAreaBackgroundModeChangedEventArgs)
    Public Event LevelAreaCustomObjectsCountChanged(e As LevelAreaEventArgs)
    Public Event LevelAreaScrollingTextureCountChanged(e As LevelAreaEventArgs)
    Public Event ObjectBankDataChanged()
    Public Event ErrorBecauseNoRomLoaded()

    'C o n s t a n t s

    Public Const PLUGINCODE_PLUGINMENU As String = "pluginmenu"
    Public Const UPDATE_URL As String = "https://pilzinsel64.com/pilzcloud/index.php/s/sm64rm-allupdatepackages/download?path=%2F&files=CurrentUpdates.json" '"https://pilzinsel64.com/Updates/SM64_ROM_Manager.json"

    'F i e l d s

    Private ReadOnly mainForm As MainForm
    Private ReadOnly updateClient As UpdateClient
    Private WithEvents RomManager As RomManager = Nothing
    Private _StatusText As String = String.Empty
    Private loadRecentROM As Boolean = False
    Private loadingROM As Boolean = False
    Private savingRom As Boolean = False
    Private hasRomChanged As Byte = 0
    Private WithEvents RomWatcher As FileSystemWatcher = Nothing
    Private openBinaryDatas As New List(Of BinaryData)

    'P r o p e r t i e s

    Public ReadOnly Property TextManagerController As TextManagerController
        Get
            Static tmc As TextManagerController

            If tmc Is Nothing Then
                tmc = New TextManagerController
                tmc.ForceUppercaseForActAndLevelNames = Settings.TextManager.ForceUpperCaseForActAndLevelNames
            End If

            Return tmc
        End Get
    End Property

    Public ReadOnly Property Romfile As String
        Get
            Return RomManager?.RomFile
        End Get
    End Property

    Public Property StatusText As String
        Get
            Return _StatusText
        End Get
        Set
            If String.IsNullOrEmpty(Value) Then Value = Form_Main_Resources.Status_Ready
            _StatusText = Value
            RaiseEvent StatusTextChanged(New StatusTextChangedEventArgs(_StatusText))
        End Set
    End Property

    Public ReadOnly Property HasRomManager As Boolean
        Get
            Return RomManager IsNot Nothing
        End Get
    End Property

    Public Property EnableMusicHack As Boolean
        Get
            Return RomManager.MusicList.EnableMusicHack
        End Get
        Set(value As Boolean)
            If value <> RomManager.MusicList.EnableMusicHack Then
                RomManager.MusicList.EnableMusicHack = value
                RomManager.MusicList.NeedToSaveMusicHackSettings = True
            End If
        End Set
    End Property

    Public ReadOnly Property IsLoadingRom As Boolean
        Get
            Return loadingROM
        End Get
    End Property

    'C o n s t r u c t o r

    Public Sub New()
        AddHandler TextManagerController.RequestRomManager, Sub(e) e.RomManager = RomManager
        AddHandler TextManagerController.RequestIsChangingTab, Sub(e) e.Value = IsChangingTab()
        AddHandler TextManagerController.SettingOtherStatusInfo, Sub(text, foreColor) SetOtherStatusInfos(text, foreColor)
        AddHandler TextManagerController.SettingStatusText, Sub(text) StatusText = text
        AddHandler TextManagerController.RequestStatusText, Sub(e) e.Value = StatusText
        AddHandler TextManagerController.ErrorBecauseNoRomLoaded, Sub() RaiseEvent ErrorBecauseNoRomLoaded()
    End Sub

    Public Sub New(mainForm As MainForm)
        Me.New

        Me.mainForm = mainForm

        'Do some default inits
        DoDefaultInitsAfterApplicationStartup()

        'Watch BinaryWatchers
        AddHandler BinaryData.AnyBinaryDataOpened, AddressOf HandlesBinaryDataOpened
        AddHandler BinaryData.AnyBinaryDataClosed, AddressOf HandlesBinaryDataClosed
        AddHandler BinaryData.AnyBinaryDataDisposed, AddressOf ClearUpOpenBinaryDatasAndEnableRomWatcher

        Dim appVersion As New ApplicationVersion(New Version(Application.ProductVersion), DevelopmentBuild, CInt(DevelopmentStage))
        updateClient = New UpdateClient(UPDATE_URL, appVersion, Settings.Network.MinimumUpdateChannel) With {
            .ApplicationName = Application.ProductName,
            .AutoCloseHostApplication = True,
            .AutoRestartHostApplication = True,
            .ForceClosingHostApplication = True,
            .InstallAsAdmin = Settings.Network.UseAdminRightsForUpdates,
            .UpdateWindowBaseColor = StyleManager.MetroColorGeneratorParameters.BaseColor,
            .UpdateWindowCanvasColor = StyleManager.MetroColorGeneratorParameters.CanvasColor
        }

        'Enable Auto-Save for Settings
        Settings.AutoSave = True
    End Sub

    'R o m   M a n a g e r   E v e n t s

    Private Sub RomManager_WritingNewRomVersion(sender As RomManager, e As RomVersionEventArgs) Handles RomManager.WritingNewProgramVersion
        Dim v As RomVersion = e.RomVersion

        v.Version = Assembly.GetEntryAssembly.GetName.Version
        v.DevelopmentStage = DevelopmentStage
        v.DevelopmentBuild = DevelopmentBuild

        e.RomVersion = v
    End Sub

    'P r i v a t e   F e a u t u r e s

    Private Sub SetRomMgr(rommgr As RomManager)
        RomManager = rommgr
        rommgr.TextInfoProfile = TextManagerController.MyTextProfiles.Manager.DefaultTextProfileInfo
    End Sub

    Private Async Function CanAccessUpdateServer() As Task(Of Boolean)
        Dim result As Boolean = True

        Dim request As HttpWebRequest = WebRequest.Create(UPDATE_URL)
        request.AllowAutoRedirect = False
        request.Method = "HEAD"

        Try
            Dim response As WebResponse = Await request.GetResponseAsync
            response.Close()
        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function

    Private Sub HandlesBinaryDataOpened(data As BinaryData)
        If TypeOf data.BaseStream Is FileStream AndAlso data.CanWrite Then
            openBinaryDatas.Add(data)
            DisableRomWatcher()
        End If
    End Sub

    Private Sub HandlesBinaryDataClosed(data As BinaryData)
        If openBinaryDatas.Contains(data) Then
            openBinaryDatas.Remove(data)
            ClearUpOpenBinaryDatasAndEnableRomWatcher()
        End If
    End Sub

    Private Sub ClearUpOpenBinaryDatasAndEnableRomWatcher()
        For Each d As BinaryData In openBinaryDatas.ToArray
            If Not d.CanWrite Then
                openBinaryDatas.Remove(d)
            End If
        Next

        If openBinaryDatas.Count = 0 Then
            EnableRomWatcher()
        End If
    End Sub

    'M a i n   F e a t u r e s

    Public Sub LoadPlugins()
        Dim pluginsPath As String = Path.Combine(MyDataPath, "Plugins")

        If Directory.Exists(pluginsPath) Then
            Publics.PluginManager.LoadPlugins(pluginsPath)
        End If
    End Sub

    Public Sub SetOtherStatusInfos(text As String, foreColor As Color)
        RaiseEvent OtherStatusInfosChanged(New OtherStatusInfosChangedEventArgs(text, foreColor))
    End Sub

    Public Async Function SearchForUpdates(searchHidden As Boolean) As Task(Of Boolean)
        If Await CanAccessUpdateServer() Then
            Dim gui As New UpdateClientGUI(updateClient)
            gui.UseHiddenSearch = searchHidden
            gui.UpdateInteractive(mainForm)
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub CheckCommandLineArgs()
        Dim fileToOpen As String = Nothing

        For Each arg In Environment.GetCommandLineArgs
            If arg = Application.ExecutablePath Then Continue For
            Select Case arg
                Case Else : If fileToOpen Is Nothing Then fileToOpen = arg
            End Select
        Next

        If fileToOpen IsNot Nothing Then
            Select Case Path.GetExtension(fileToOpen).ToLower
                Case ".z64"
                    OpenRom(fileToOpen)
            End Select
        End If
    End Sub

    Public Function WaitWhileSavingRom() As Task
        Dim t As New Task(
            Sub()
                Do While savingRom
                Loop
            End Sub)
        t.Start()
        Return t
    End Function

    Public Sub LaunchRom()
        General.LaunchRom(RomManager)
    End Sub

    Public Function AllowSavingRom() As Boolean
        If TextManagerController.IsTextOverLimit() Then
            MessageBoxEx.Show(Form_Main_Resources.MsgBox_TextsOverLimit, Form_Main_Resources.MsgBox_TextsOverLimit_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Public Function SaveRom() As Boolean
        If AllowSavingRom() Then
            StatusText = Form_Main_Resources.Status_SavingRom
            savingRom = True

            General.SaveRom(RomManager)

            savingRom = False
            StatusText = String.Empty

            Return True
        Else
            Return False
        End If
    End Function

    Public Function DoesRomManagerNeedToSave() As Boolean
        If RomManager Is Nothing Then
            Return False
        Else
            Return RomManager.NeedToSave
        End If
    End Function

    Public Function OpenRom() As Boolean
        Dim ret As Boolean = False
        Dim ofd_SM64RM_LoadROM As New OpenFileDialog With {
            .Filter = "SM64 ROMs (*.z64)|*.z64"
        }

        Dim lastFiles As StringCollection = Settings.RecentFiles.RecentROMs
        If lastFiles.Count > 0 Then
            ofd_SM64RM_LoadROM.InitialDirectory = Path.GetDirectoryName(lastFiles(0))
        End If

        If ofd_SM64RM_LoadROM.ShowDialog = DialogResult.OK Then
            ret = OpenRom(ofd_SM64RM_LoadROM.FileName)
        End If

        Return ret
    End Function

    Public Function OpenRom(Romfile As String) As Boolean
        Dim success As Boolean = False

        If Not loadRecentROM Then

#If Not DEBUG Then
            Try
#End If

            Dim romFileInfo As New FileInfo(Romfile)
            Dim newrommgr As New RomManager(Romfile)
            StatusText = Form_Main_Resources.Status_Checking

            If romFileInfo.Length = 8 * 1024 * 1024 Then
                If MessageBoxEx.Show(Form_Main_Resources.MsgBox_PrepaireRom, Form_Main_Resources.MsgBox_PrepaireRom_Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) <> DialogResult.OK Then
                    Throw New RomCompatiblityException("Rom Length is incompatible!")
                End If
            End If

            If Not newrommgr.CheckROM() Then
                Throw New RomCompatiblityException("Rom Check was false!")
            ElseIf newrommgr.IsSM64EditorMode Then
                Throw New RomCompatiblityException(Form_Main_Resources.Exception_RomWasUsedBySM64E)
            End If

            loadRecentROM = True

            AddRecentFile(Settings.RecentFiles.RecentROMs, Romfile)
            MergeRecentFiles(Settings.RecentFiles.RecentROMs)
            RaiseEvent RecentFilesChanged()

            SetRomMgr(newrommgr)
            LoadROM()

            CreateRomWatcherForCurrentRom()

            success = True

#If Not DEBUG Then
            Catch ex As RomCompatiblityException
                MessageBoxEx.Show(ex.Message, "Loading ROM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As ReadOnlyException
                MessageBoxEx.Show(ex.Message, "Loading ROM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBoxEx.Show(Form_Main_Resources.MsgBox_RomRemoved, Form_Main_Resources.MsgBox_RomRemoved_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
#End If

            loadRecentROM = False
            StatusText = String.Empty
        End If

        Return success
    End Function

    Public Sub LoadROM()
        loadingROM = True
        StatusText = Form_Main_Resources.Status_LoadingRom
        RaiseEvent RomLoading()

        'Load Global Object Banks
        RomManager.LoadGlobalObjectBank()

        'Load Levels
        RomManager.LoadLevels()
        RaiseEvent RomLevelsLoaded()

        'Load Music
        StatusText = Form_Main_Resources.Status_LoadingMusic
        RomManager.LoadMusic()
        RaiseEvent RomMusicLoaded()
        StatusText = String.Empty

        RaiseEvent RomLoaded()
        StatusText = String.Empty
        loadingROM = False
    End Sub

    Private Sub CreateRomWatcherForCurrentRom()
        If RomManager IsNot Nothing Then
            General.RomWatcher = New FileSystemWatcher(Path.GetDirectoryName(RomManager.RomFile), Path.GetFileName(RomManager.RomFile)) With {.EnableRaisingEvents = True, .SynchronizingObject = mainForm}
            hasRomChanged = 0
        Else
            General.RomWatcher = Nothing
        End If
        RomWatcher = General.RomWatcher
    End Sub

    Public Sub CheckRomChanged()
        If hasRomChanged = 1 Then
            Dim e As New RomChangesAvaiableEventArgs

            RaiseEvent RomChangesAvailable(e)

            If e.Mute Then
                hasRomChanged = 2
            End If
        End If
    End Sub

    Public Sub ReloadRom()
        OpenRom(RomManager.RomFile)
    End Sub

    Public Sub UpdateChecksum()
        If RomManager IsNot Nothing Then
            StatusText = "Calculating checksum ..."
            DisableRomWatcher()
            PatchClass.UpdateChecksum(RomManager.RomFile)
            EnableRomWatcher()
            StatusText = String.Empty
        End If
    End Sub

    Public Sub ConvertM64ToMidi()
        Dim ofd As New CommonOpenFileDialog
        Dim sfd As CommonSaveFileDialog
        Dim chunks As Byte = 2

        ofd.Filters.Add(New CommonFileDialogFilter("M64 Sequences", "*.m64"))
        ofd.EnsureFileExists = True

        If ofd.ShowDialog = CommonFileDialogResult.Ok Then
            sfd = New CommonSaveFileDialog
            sfd.Filters.Add(New CommonFileDialogFilter("MIDI File [Experimental]", "*.mid"))
            sfd.Controls.Add(GetMidiExportDialogControls)

            If sfd.ShowDialog() = CommonFileDialogResult.Ok Then
                'Get chunks
                Select Case CType(sfd.Controls("MidiChunksSelector"), CommonFileDialogComboBox).SelectedIndex
                    Case 0
                        chunks = 1
                    Case 1
                        chunks = 2
                End Select

                'Create midi file
                Dim fs As New FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite)

                'Convert .m64 to .midi
                Try
                    OutputMIDI.ConvertToMIDI(sfd.FileName, fs, chunks, True)
                    MessageBoxEx.Show(Form_Main_Resources.MsgBox_ConvertToMidi_Succes, Form_Main_Resources.MsgBox_ConvertToMidi_Succes_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBoxEx.Show(Form_Main_Resources.MsgBox_ConvertToMidi_Failed & vbNewLine & ex.Message, Form_Main_Resources.MsgBox_ConvertToMidi_Failed_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    fs.Close()
                End Try
            End If
        End If
    End Sub

    Public Function GetCurrentRomManager() As RomManager
        Return RomManager
    End Function

    Public Sub OpenGlobalObjectBankManager()
        If RomManager.GlobalObjectBank Is Nothing Then
            RomManager.CreateNewGlobalObjectBank()
        End If

        Dim mgr As New CustomBankManager(RomManager, RomManager.GlobalObjectBank)
        mgr.Show()
    End Sub

    Public Sub OpenPluginManager()
        Dim frm As New PluginInstallerForm
        frm.Show()
    End Sub

    Public Sub OpenHUDOptions()
        Dim frmHUD As New HUDOptionsForm(RomManager)
        frmHUD.ShowDialog()
    End Sub

    'T o o l s

    Public Sub OpenTweakViewer()
        Static addedHandlers As Boolean = False

        If Not addedHandlers Then
            AddHandler TweakViewer.TweakBeforeApply, AddressOf DisableRomWatcher
            AddHandler TweakViewer.TweakAfterApply, AddressOf EnableRomWatcher
            AddHandler TweakViewer.TweakFailedApply, AddressOf EnableRomWatcher
            addedHandlers = True
        End If

        Dim tweaks As New TweakViewer(RomManager)
        tweaks.Show()
    End Sub

    Public Sub OpenModelImporter()
        Dim frm As New ModelImporterGUI.ModelImporter
        frm.RomFile = RomManager?.RomFile
        frm.Show()
    End Sub

    Public Sub OpenTrajectoryEditor()
        Dim editor As New TrajectoryEditor(RomManager)
        editor.ShowDialog(mainForm)
    End Sub

    Public Sub OpenRgbEditor()
        Dim editor As New RGBEditor(RomManager)
        editor.Show()
    End Sub

    Public Sub OpenCoinsEditor()
        Dim frm As New Form_CoinsSettings(RomManager)
        frm.Show(mainForm)
    End Sub

    Public Sub OpenAbout()
        Dim frm As New Form_About
        frm.ShowDialog()
    End Sub

    Public Sub OpenTextConverter()
        Dim frm As New Form_SM64TextConverter
        frm.Show()
    End Sub

    Public Sub OpenStyleManager()
        Form_Stylemanager.Show()
    End Sub

    Public Sub OpenSettings()
        Dim frm As New Form_Settings
        frm.ShowDialog()
    End Sub

    Public Sub OpenApplyPPFDialog()
        Dim patcher As New ApplyPPF.ApplyPPFDialog(RomManager?.RomFile, String.Empty)
        patcher.ShowDialog(mainForm)
    End Sub

    Public Sub OpenItemBoxContentEditor()
        Dim ibce As ItemBoxContentEditor = GetFirstOpenForm(Of ItemBoxContentEditor)()

        If ibce Is Nothing Then
            ibce = New ItemBoxContentEditor(RomManager)
        End If

        ibce.Show()
    End Sub

    Public Sub OpenStarPositionEditor()
        Dim spo As StarPositionEditor = GetFirstOpenForm(Of StarPositionEditor)()

        If spo Is Nothing Then
            spo = New StarPositionEditor(RomManager)
        End If

        spo.Show()
    End Sub

    Public Sub OpenObjectBankDataEditor()
        Dim editor As New ObjectBankDataEditor(ObjectBankData)
        Dim removedObds As New List(Of Data.ObjectBankData)
        Dim changedObds As New List(Of Data.ObjectBankData)

        'Watch for removed and changed Obds
        AddHandler editor.RemovedObjectBankData, Sub(obd) removedObds.Add(obd)
        AddHandler editor.ChangedObjectBankDataCommand, Sub(obd) If Not changedObds.Contains(obd) Then changedObds.Add(obd)

        'Show Editor
        editor.ShowDialog()

        'Save Obd
        SaveObjectBankData()

        'Set removed and changed Obds in Levels to Null
        Dim setObdsToNull =
             Sub(dic As List(Of Data.ObjectBankData), remove As Boolean)
                 If RomManager IsNot Nothing Then
                     For Each lvl As Level In RomManager.Levels
                         For Each bankID As Byte In lvl.LoadedObjectBanks.Keys.ToArray
                             For Each obd As Data.ObjectBankData In dic
                                 Dim curObd As Data.ObjectBankData = lvl.GetObjectBankData(bankID)
                                 If curObd Is obd Then
                                     lvl.ChangeObjectBankData(bankID, If(remove, Nothing, curObd))
                                 End If
                             Next
                         Next
                     Next
                 End If
             End Sub
        setObdsToNull(removedObds, True)
        setObdsToNull(changedObds, False)

        'Raise events
        RaiseEvent ObjectBankDataChanged()
    End Sub

    Private Sub OpenScriptDumper(Of TCmd, eTypes)(script As BaseCommandCollection(Of TCmd, eTypes))
        Dim frm As New ScriptDumper(Of TCmd, eTypes)
        frm.Script = script
        frm.Show()
    End Sub

    Private Sub OpenCustomBankManager(customBank As CustomObjectBank, levelIndex As Integer, areaIndex As Integer, areaID As Byte)
        Dim mgr As New CustomBankManager(RomManager, customBank)

        Dim objectCountChanged = Sub() RaiseEvent LevelAreaCustomObjectsCountChanged(New LevelAreaEventArgs(levelIndex, areaIndex, areaID))
        AddHandler mgr.ObjectAdded, objectCountChanged
        AddHandler mgr.ObjectRemoved, objectCountChanged

        mgr.Show()
    End Sub

    Private Function OpenLevelSelectDialog() As LevelInfoDataTabelList.Level
        Dim frm As New LevelSelectorDialog(RomManager)

        If frm.ShowDialog = DialogResult.OK Then
            Return frm.SelectedLevel
        Else
            Return Nothing
        End If
    End Function

    Private Function OpenValueInputDialog(titel As String, input As String) As String
        Dim inputDialog As New ValueInputDialog
        inputDialog.InfoLabel.Text = titel
        inputDialog.ValueTextBox.Text = input

        If inputDialog.ShowDialog = DialogResult.OK Then
            Return inputDialog.ValueTextBox.Text
        Else
            Return Nothing
        End If
    End Function

    Public Sub OpenFeatureRequestDialog()
        Dim frm As New UserRequestDialog(UserRequestLayout.LoadFrom(Path.Combine(MyUserRequestsPath, "FeatureRequest.json")))
        frm.Show()
    End Sub

    Public Sub OpenBugReportDialog()
        Dim frm As New UserRequestDialog(UserRequestLayout.LoadFrom(Path.Combine(MyUserRequestsPath, "BugReport.json")))
        frm.Show()
    End Sub

    Public Sub OpenTranslationSubmition()
        Dim frm As New UserRequestDialog(UserRequestLayout.LoadFrom(Path.Combine(MyUserRequestsPath, "SubmitTranslation.json")))
        frm.Show()
    End Sub

    Public Sub OpenThankYouPage()
        Dim frm As New ThankYouForm
        frm.ShowDialog(mainForm)
    End Sub

    'R o m   W a t c h e r

    Private Sub RomWatcher_Changed(sender As Object, e As FileSystemEventArgs) Handles RomWatcher.Changed
        If RomManager IsNot Nothing AndAlso RomManager.RomFile = e.FullPath AndAlso hasRomChanged <> 2 Then
            hasRomChanged = 1
            RaiseEvent RomFileChanged()
        End If
    End Sub

    Private Sub RomWatcher_Renamed(sender As Object, e As RenamedEventArgs) Handles RomWatcher.Renamed
        If RomManager IsNot Nothing AndAlso e.OldFullPath = RomManager.RomFile Then
            RomManager.RomFile = e.FullPath
            RaiseEvent RomFileRenamed()
        End If
    End Sub

    Private Sub RomWatcher_Deleted(sender As Object, e As FileSystemEventArgs) Handles RomWatcher.Deleted
        If RomManager IsNot Nothing AndAlso e.FullPath = RomManager.RomFile Then
            RaiseEvent RomFileDeleted()
        End If
    End Sub

    'G e n e r a l

    Public Sub SetGameName(name As String)
        name = name.Trim
        RomManager.GameName = name
    End Sub

    Public Function GetGameNAme() As String
        Return RomManager.GameName
    End Function

    Public Function GetRomFileSize() As Double
        Return New FileInfo(RomManager.RomFile).Length / 1024 / 1024
    End Function

    Public Function IsChangingTab()
        Dim e As New EnabledEventArgs(False)
        RaiseEvent RequestIsChangingTab(e)
        Return e.Enabled
    End Function

    Public Sub CheckToOpenThankYouPage()
        Dim myVersion As New Version(Application.ProductVersion)
        If Settings.General.LastThankYouPageSeen Is Nothing OrElse Settings.General.LastThankYouPageSeen < myVersion Then
            OpenThankYouPage()
            Settings.General.LastThankYouPageSeen = myVersion
        End If
    End Sub

    'L e v e l   M a n a g e r

    Private Function GetLevelAndArea(levelIndex As Integer, Optional areaIndex As Integer = -1) As (level As Level, area As LevelArea)
        Dim lvl As Level = RomManager.Levels.ElementAtOrDefault(levelIndex)
        Dim area As LevelArea = lvl?.Areas?.ElementAtOrDefault(areaIndex)
        Return (lvl, area)
    End Function

    Private ReadOnly Property OpenAreaEditors As IEnumerable(Of Form_AreaEditor)
        Get
            Dim list As New List(Of Form_AreaEditor)

            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is Form_AreaEditor Then
                    list.Add(frm)
                End If
            Next

            Return list
        End Get
    End Property

    Private Function GetAreaEditor(level As Level)
        Return OpenAreaEditors.FirstOrDefault(Function(n) n.CLevel Is level)
    End Function

    Public Sub OpenAreaEditor(levelIndex As Integer, areaIndex As Integer)
        If levelIndex >= 0 Then
            Dim curLvl As Level = RomManager.Levels(levelIndex)
            Dim openAreaEditor As Form_AreaEditor = GetAreaEditor(curLvl)

            If openAreaEditor Is Nothing Then
                Dim curArea As LevelArea = curLvl.Areas.ElementAtOrDefault(areaIndex)
                Dim frm As New Form_AreaEditor(RomManager, curLvl, curLvl.LevelID, curArea?.AreaID)
                frm.Show()
            Else
                openAreaEditor.BringToFront()
            End If
        End If
    End Sub

    Public Sub SetUpLevelDefaultStartPosition(levelIndex As Integer)
        Dim ShowX As Boolean = False
        Dim ShowY As Boolean = False
        Dim ShowZ As Boolean = False
        Dim XVal As Integer = 0
        Dim YVal As Integer = 0
        Dim ZVal As Integer = 0
        Dim Title As String = ""
        Dim lvl As Level = RomManager.Levels(levelIndex)
        Dim dsp = lvl.GetDefaultPositionCmd

        If dsp IsNot Nothing Then
            'Edit all values
            ShowX = True : ShowY = True : ShowZ = True

            'Show current values (get from command)
            Dim curPos As Vector3 = clDefaultPosition.GetPosition(dsp)
            With curPos
                XVal = .X
                YVal = .Y
                ZVal = .Z
            End With

            'Set Titel
            Title = Form_Main_Resources.Text_StartPosition

            'Open Dialog
            Dim frm As New Form_SetUpPoint(Title, ShowX, ShowY, ShowZ, XVal, YVal, ZVal)
            If frm.ShowDialog() = DialogResult.OK Then
                'Get new values
                XVal = ValueFromText(frm.IntegerInput_X.Value)
                YVal = ValueFromText(frm.IntegerInput_Y.Value)
                ZVal = ValueFromText(frm.IntegerInput_Z.Value)

                'Set new values
                With curPos
                    .X = XVal
                    .Y = YVal
                    .Z = ZVal
                End With

                'Set new values to command
                clDefaultPosition.SetPosition(dsp, curPos)

                SetLevelscriptNeedToSave(lvl)
            End If
        End If
    End Sub

    Public Sub AddLevelAreaSpecialItem(levelIndex As Integer, areaIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
        Dim sb As New SpecialBox

        Dim method =
            Sub()
                lvl.area.SpecialBoxes.Add(sb)
                SetLevelscriptNeedToSave(lvl.level)
                RaiseEvent LevelSpecialItemAdded(New SpecialItemEventArgs(lvl.area.SpecialBoxes.IndexOf(sb), levelIndex, areaIndex))
            End Sub

        AddEditLevelAreaSpecialItem(sb, method)
    End Sub

    Public Sub EditLevelAreaSpecialItem(levelIndex As Integer, areaIndex As Integer, sbIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
        Dim sb As SpecialBox = lvl.area.SpecialBoxes(sbIndex)

        Dim method =
            Sub()
                SetLevelscriptNeedToSave(lvl.level)
                RaiseEvent LevelSpecialItemChanged(New SpecialItemEventArgs(sbIndex, levelIndex, areaIndex))
            End Sub

        AddEditLevelAreaSpecialItem(sb, method)
    End Sub

    Private Sub AddEditLevelAreaSpecialItem(sb As SpecialBox, finishMethod As Action)
        Dim frm As New Form_AddSpecialItem(sb)

        'Set what happens after the form has close
        AddHandler frm.FormClosed,
            Sub()
                Dim newType As SpecialBoxType

                If frm.DialogResult = DialogResult.OK Then
                    Select Case True
                        Case frm.CheckBoxX_Water.Checked
                            newType = SpecialBoxType.Water
                        Case frm.CheckBoxX_Mist.Checked
                            newType = SpecialBoxType.Mist
                        Case frm.CheckBoxX_ToxicHaze.Checked
                            newType = SpecialBoxType.ToxicHaze
                    End Select

                    'Reorder Positions in BoxData
                    ReorderBoxDataPositions(sb)

                    'Define new Type for SpecialBox
                    sb.Type = newType

                    'Invoke finish method
                    finishMethod()
                End If
            End Sub

        'Show the Form
        frm.Show()
    End Sub

    Public Function GetSpecialBoxInfos(levelIndex As Integer, areaIndex As Integer, sbIndex As Integer) As (boxType As SpecialBoxType, waterType As WaterType, x1 As Short, z1 As Short, x2 As Short, z2 As Short, y As Short, scale As Short, alpha As Byte, invisibleWater As Boolean)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
        Dim sb As SpecialBox = lvl.area.SpecialBoxes(sbIndex)

        Return (sb.Type, sb.WaterType, sb.X1, sb.Z1, sb.X2, sb.Z2, sb.Y, sb.Scale, sb.Alpha, sb.InvisibleWater)
    End Function

    Public Sub LoadObjectBankData()
        Static loaded As Boolean = False
        If Not loaded Then
            ObjectBankData.Load(Path.Combine(MyDataPath, "Other\Object Bank Data.json"))
            loaded = True
        End If
    End Sub

    Private Sub SaveObjectBankData()
        ObjectBankData.Save(Path.Combine(MyDataPath, "Other\Object Bank Data.json"))
    End Sub

    Public Function GetLevelsCount() As Integer
        Return RomManager.Levels.Count
    End Function

    Public Function GetUsedLevelIDs() As IEnumerable(Of UShort)
        Return RomManager.Levels.Select(Function(n) n.LevelID)
    End Function

    Public Function HasLevelCustomName(levelIndex As Integer) As String
        Dim lvl As Level = GetLevelAndArea(levelIndex).level
        Return HasLevelCustomName(lvl.LevelID)
    End Function

    Public Function HasLevelCustomName(levelID As UShort) As String
        Return Not String.IsNullOrEmpty(RomManager.RomConfig.GetLevelConfig(levelID)?.LevelName)
    End Function

    Public Function GetLevelCustomName(levelIndex As Integer) As String
        Dim lvl As Level = GetLevelAndArea(levelIndex).level
        Return GetLevelCustomName(lvl.LevelID)
    End Function

    Public Function GetLevelCustomName(levelID As UShort) As String
        Return RomManager.RomConfig.GetLevelConfig(levelID).LevelName
    End Function

    Public Sub SetLevelCustomName(levelID As UShort, newName As String)
        RomManager.RomConfig.GetLevelConfig(levelID).LevelName = newName
    End Sub

    Public Function GetLevelName(levelIndex As Integer) As String
        Dim lvl As Level = GetLevelAndArea(levelIndex).level
        Return GetLevelName(lvl.LevelID)
    End Function

    Public Function GetLevelName(levelID As UShort) As String
        Return RomManager.LevelInfoData.FirstOrDefault(Function(n) n.ID = levelID).Name
    End Function

    Public Function GetUsedLevelAreaIDs(levelIndex As UShort) As Byte()
        Return RomManager.Levels.ElementAtOrDefault(levelIndex)?.Areas?.Select(Function(n) n.AreaID).ToArray
    End Function

    Public Sub AddNewLevel()
        Dim selLvl = OpenLevelSelectDialog()

        If selLvl IsNot Nothing Then
            Dim lvl As Level = RomManager.AddLevel(selLvl.ID)
            RomManager.Levels.Last.ActSelector = selLvl.Type = LevelInfoDataTabelList.LevelTypes.Level

            SetLevelscriptNeedToSave(lvl)
            SetLevelBank0x0ENeedToSave(lvl)

            RaiseEvent LevelAdded(New LevelEventArgs(RomManager.Levels.IndexOf(lvl), lvl.LevelID))
        End If
    End Sub

    Public Sub AddNewArea(levelIndex As Integer)
        Dim curLevel As Level = GetLevelAndArea(levelIndex).level
        Dim nextid = GetNextAreaID(curLevel)

        'Convert a model
        If nextid.isAnyFree Then
            Dim areaID As Byte = If(nextid.newID, 0)
            Dim res = GetModelViaModelConverter(False, False,,,, GetKeyForConvertAreaModel(RomManager.GameName, curLevel.LevelID, areaID))

            If res IsNot Nothing Then
                'Create new area
                Dim tArea As New RMLevelArea(areaID)
                tArea.AreaModel = res?.mdl
                tArea.ScrollingTextures.AddRange(res?.mdl.Fast3DBuffer.ConvertResult.ScrollingCommands.ToArray)
                RomManager.RomConfig.GetLevelConfig(curLevel.LevelID).GetLevelAreaConfig(areaID).ScrollingNames = res?.mdl.Fast3DBuffer.ConvertResult.ScrollingNames

                'Add area to level
                curLevel.Areas.Add(tArea)

                SetLevelscriptNeedToSave(curLevel)
                SetLevelBank0x0ENeedToSave(curLevel)

                RaiseEvent LevelAreaAdded(New LevelAreaEventArgs(levelIndex, curLevel.Areas.IndexOf(tArea), tArea.AreaID))
            End If
        Else
            MessageBoxEx.Show(Form_Main_Resources.MsgBox_MaxCountAreasReached, Form_Main_Resources.MsgBox_MaxCountAreasReached_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Function GetLevelAreasCount(levelIndex As Integer) As Byte
        Return GetLevelAndArea(levelIndex, -1).level.Areas.Count
    End Function

    Public Sub RemoveLevelArea(levelIndex As Integer, areaIndex As Integer)
        If levelIndex >= 0 AndAlso areaIndex >= 0 Then
            If MessageBoxEx.Show("You are going to remove the selected area. Continue?", "Remove Area", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim lvl = GetLevelAndArea(levelIndex, areaIndex)

                lvl.level.Areas.RemoveAt(areaIndex)
                SetLevelscriptNeedToSave(lvl.level)
                SetLevelBank0x0ENeedToSave(lvl.level)

                RaiseEvent LevelAreaRemoved(New LevelAreaEventArgs(levelIndex, areaIndex, lvl.area.AreaID))
            End If
        End If
    End Sub

    Private Function GetLengthOfLevelAreas(level As Level, Optional ExcaptIndex As Integer = -1) As Long
        Dim val As Integer = 0
        Dim tIndex As Integer = 0

        For Each a As LevelArea In level.Areas
            If tIndex <> ExcaptIndex Then
                val += a.AreaModel.Length
                tIndex += 1
            End If
        Next

        Return val
    End Function

    Private Sub SetLevelscriptNeedToSave(lvl As Level)
        lvl.NeedToSaveLevelscript = True
    End Sub

    Private Sub SetLevelBank0x0ENeedToSave(lvl As Level)
        lvl.NeedToSaveBanks0E = True
    End Sub

    Public Sub SetLevelSettings(levelIndex As Integer, defStartPosDestAreaID As Byte, defStartPosDestRotation As Short, enableActSelector As Boolean, enableHardcodedCamera As Boolean, objBank0x0C As Integer, objBank0x0D As Integer, objBank0x0E As Integer, enableGlobalObjectBank As Boolean, enableShowMsg As Boolean, showMsgDialogID As Byte)
        Dim lvl As Level = GetLevelAndArea(levelIndex, -1).level

        'Default Start Position
        clDefaultPosition.SetAreaID(lvl.GetDefaultPositionCmd, defStartPosDestAreaID)
        clDefaultPosition.SetRotation(lvl.GetDefaultPositionCmd, defStartPosDestRotation)

        'Act Selector
        lvl.ActSelector = enableActSelector

        'Hardcoded Camera
        lvl.HardcodedCameraSettings = enableHardcodedCamera

        'Object Banks
        lvl.ChangeObjectBankData(&HC, ObjectBankData(CByte(&HC)).ElementAtOrDefault(objBank0x0C - 1))
        lvl.ChangeObjectBankData(&HD, ObjectBankData(CByte(&HD)).ElementAtOrDefault(objBank0x0D - 1))
        lvl.ChangeObjectBankData(&H9, ObjectBankData(CByte(&H9)).ElementAtOrDefault(If(enableGlobalObjectBank, -1, objBank0x0E - 1)))
        lvl.EnableGlobalObjectBank = enableGlobalObjectBank

        SetLevelscriptNeedToSave(lvl)
    End Sub

    Public Sub SetLevelBackgroundMode(levelIndex As Integer, mode As Integer)
        Dim lvl As Level = GetLevelAndArea(levelIndex, -1).level
        Dim image As Image = Nothing

        Select Case mode
            Case 0 ' Game Image
                lvl.Background.Enabled = True
                lvl.Background.IsCustom = False
            Case 1 'Custom Image
                lvl.Background.Enabled = True
                lvl.Background.IsCustom = True
                image = lvl.Background.GetImage
            Case 2 'Disable
                lvl.Background.Enabled = False
                lvl.Background.IsCustom = False
        End Select

        SetLevelscriptNeedToSave(lvl)
    End Sub

    Public Sub SetLevelBackgroundID(levelIndex As Integer, id As BackgroundIDs)
        Dim lvl As Level = GetLevelAndArea(levelIndex, -1).level

        lvl.Background.ID = id
        lvl.Background.Enabled = True
        lvl.Background.IsCustom = False

        SetLevelscriptNeedToSave(lvl)
    End Sub

    Public Sub SetLevelAreaBackgroundType(levelIndex As Integer, areaIndex As Integer, typ As AreaBGs)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)

        lvl.area.Background.Type = typ

        SetLevelscriptNeedToSave(lvl.level)
        RaiseEvent LevelAreaBackgroundModeChanged(New LevelAreaBackgroundModeChangedEventArgs(typ, lvl.area.Background.Color))
    End Sub

    Public Sub SetLevelAreaBackgroundColor(levelIndex As Integer, areaIndex As Integer, color As Color)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)

        lvl.area.Background.Type = AreaBGs.Color
        lvl.area.Background.Color = color

        SetLevelscriptNeedToSave(lvl.level)
    End Sub

    Public Function GetLevelAreaBackgroundInfo(levelIndex As Integer, areaIndex As Integer) As (typ As AreaBGs, color As Color)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
        Return (lvl.area.Background.Type, lvl.area.Background.Color)
    End Function

    Public Sub LoadLevelCustomBackgroundImage(levelIndex As Integer)
        Dim lvl As Level = GetLevelAndArea(levelIndex, -1).level
        Dim bg As LevelBG = lvl.Background

        Dim ofd As New OpenFileDialog
        ofd.Filter = "All supported Image files|*.png;*.jpeg;*.jpg;*.bmp;*.gif"

        If ofd.ShowDialog = DialogResult.OK Then
            Dim sImg As Stream = New MemoryStream(File.ReadAllBytes(ofd.FileName))
            Dim tBGImage As New Bitmap(sImg)

            If tBGImage.Size <> New Size(248, 248) And tBGImage.Size <> New Size(256, 256) Then
                MessageBoxEx.Show(Form_Main_Resources.MsgBox_InvalidBgImageSize, Form_Main_Resources.MsgBox_InvalidBgImageSize_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                bg.SetImage(tBGImage)
                bg.ID = BackgroundIDs.Desert
                bg.IsCustom = True
                bg.Enabled = True

                SetLevelscriptNeedToSave(lvl)
                RaiseEvent LevelBackgroundImageChanged(New LevelBackgroundImageChangedEventArgs(bg.ID, bg.GetImage))
            End If

            sImg.Close()
        End If
    End Sub

    Public Sub SaveLevelAreaSettings(levelIndex As Integer, areaIndex As Integer, terrainTypes As TerrainTypes, musicID As Byte, environmentEffects As EnvironmentEffects, cameraPrset As CameraPresets, enable2DCamera As Boolean, enableShowMsg As Boolean, showMsgDialogID As Byte)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
        Dim area As LevelArea = lvl.area

        area.TerrainType = terrainTypes
        area.BGMusic = musicID
        area.Geolayout.EnvironmentEffect = environmentEffects
        area.Geolayout.CameraPreset = cameraPrset
        area.Enable2DCamera = enable2DCamera
        area.ShowMessage.Enabled = enableShowMsg
        area.ShowMessage.DialogID = showMsgDialogID

        SetLevelscriptNeedToSave(lvl.level)
    End Sub

    Public Sub ImportLevelAreaModel(levelIndex As Integer, areaIndex As Integer, importVisualMap As Boolean, importCollision As Boolean)
        Dim levelarea = GetLevelAndArea(levelIndex, areaIndex)

        If levelarea.level IsNot Nothing AndAlso levelarea.area IsNot Nothing AndAlso RomManager IsNot Nothing Then
            Dim area As LevelArea = levelarea.area
            Dim res = GetModelViaModelConverter(,, importVisualMap, importCollision,, GetKeyForConvertAreaModel(RomManager.GameName, levelarea.level.LevelID, area.AreaID))

            If res IsNot Nothing Then
                If res?.hasCollision AndAlso res?.hasVisualMap Then
                    Dim OldAreaModel As ObjectModel = area.AreaModel
                    area.AreaModel = res?.mdl
                ElseIf res?.hasCollision Then
                    Dim OldAreaModel As ObjectModel = area.AreaModel
                    area.AreaModel.Collision = res?.mdl.Collision
                ElseIf res?.hasVisualMap Then
                    Dim OldAreaModel As ObjectModel = area.AreaModel
                    area.AreaModel = res?.mdl
                    area.AreaModel.Collision = OldAreaModel.Collision
                End If

                If res?.hasVisualMap Then
                    area.ScrollingTextures.Clear()
                    area.ScrollingTextures.AddRange(area.AreaModel.Fast3DBuffer.ConvertResult.ScrollingCommands.ToArray)
                    RomManager.RomConfig.GetLevelConfig(levelarea.level.LevelID).GetLevelAreaConfig(area.AreaID).ScrollingNames = res?.mdl.Fast3DBuffer.ConvertResult.ScrollingNames
                End If

                area.SetSegmentedBanks(RomManager)
                SetLevelBank0x0ENeedToSave(levelarea.level)
            End If
        End If
    End Sub

    Public Function GetSpecialBoxesCount(levelIndex As Integer, areaIndex As Integer) As Integer
        Dim area As LevelArea = GetLevelAndArea(levelIndex, areaIndex).area
        Return area.SpecialBoxes.Count
    End Function

    Public Sub RemoveLevelSpecialBox(levelIndex As Integer, areaIndex As Integer, sbIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)

        lvl.area.SpecialBoxes.RemoveAt(sbIndex)

        SetLevelscriptNeedToSave(lvl.level)
        RaiseEvent LevelSpecialItemRemoved(New SpecialItemEventArgs(sbIndex, levelIndex, areaIndex))
    End Sub

    Public Function DoesCameraPresetProvide2DCamera(preset As CameraPresets) As Boolean
        Return preset = &HE
    End Function

    Public Sub CopyLevelLastRomOffset(levelIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex)
        Clipboard.SetText(lvl.level.LastRomOffset.ToString("X8"))
    End Sub

    Public Sub OpenScrollingTextureEditor(levelIndex As Integer, areaIndex As Integer)
        If levelIndex > -1 AndAlso areaIndex > -1 Then
            Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
            Dim areaConf As LevelAreaConfig = RomManager.RomConfig.GetLevelConfig(lvl.level.LevelID).GetLevelAreaConfig(lvl.area.AreaID)
            Dim editor As New ScrollTexEditor(lvl.area, areaConf)

            Dim scrollTextCountChanged = Sub() RaiseEvent LevelAreaScrollingTextureCountChanged(New LevelAreaEventArgs(levelIndex, areaIndex, lvl.area.AreaID))
            Dim setNeedToSave = Sub() SetLevelscriptNeedToSave(lvl.level)

            AddHandler editor.ScrollTexAdded, scrollTextCountChanged
            AddHandler editor.ScrollTexRemoved, scrollTextCountChanged
            AddHandler editor.ScrollTexAdded, setNeedToSave
            AddHandler editor.ScrollTexRemoved, setNeedToSave
            AddHandler editor.ScrollTexChanged, setNeedToSave

            editor.Show()
        End If
    End Sub

    Public Sub OpenScriptDumperWithLevelscript(levelIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex)
        If lvl.level IsNot Nothing Then
            OpenScriptDumper(lvl.level.Levelscript)
        End If
    End Sub

    Public Sub OpenScriptDumperWithLevelAreaScript(levelIndex As Integer, areaIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
        If lvl.area IsNot Nothing Then
            OpenScriptDumper(lvl.area.Levelscript)
        End If
    End Sub

    Public Sub OpenScriptDumperWithLevelAreaGeolayoutScript(levelIndex As Integer, areaIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)
        If lvl.area IsNot Nothing Then
            OpenScriptDumper(lvl.area.Geolayout.Geolayoutscript)
        End If
    End Sub

    Public Function HasLevelBank0x19(levelIndex As Integer) As Boolean
        Dim lvl = GetLevelAndArea(levelIndex)
        Return lvl.level?.Bank0x19 IsNot Nothing
    End Function

    Public Sub OpenCustomBankManager(levelIndex As Integer, areaIndex As Integer)
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)

        If lvl.area IsNot Nothing Then
            OpenCustomBankManager(lvl.area.CustomObjects, levelIndex, areaIndex, lvl.area.AreaID)
        End If
    End Sub

    Public Async Function ExportLevelVisualMap(levelIndex As Integer, areaIndex As Integer) As Task
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)

        If lvl.area IsNot Nothing Then
            StatusText = Form_Main_Resources.Status_LoadingModel
            Dim mdl As Object3D = Await LoadAreaVisualMapAsObject3DAsync(RomManager, lvl.area)

            ExportLevelModel(levelIndex, areaIndex, mdl)
        End If
    End Function

    Public Async Function ExportLevelCollision(levelIndex As Integer, areaIndex As Integer) As Task
        Dim lvl = GetLevelAndArea(levelIndex, areaIndex)

        If lvl.area IsNot Nothing Then
            StatusText = Form_Main_Resources.Status_LoadingModel
            Dim mdl As Object3D = Await lvl.area.AreaModel.Collision.ToObject3DAsync

            ExportLevelModel(levelIndex, areaIndex, mdl)
        End If
    End Function

    Private Sub ExportLevelModel(levelIndex As Integer, areaIndex As Integer, mdl As Object3D)
        StatusText = Form_Main_Resources.Status_ExportingModel
        ExportModel(mdl, GetExporterModuleFromID(Settings.FileParser.FileExporterModule))
        StatusText = String.Empty
    End Sub

    Public Function GetLevelAreaSettings(levelIndex As Integer, areaIndex As Integer) As (terrainType As TerrainTypes, bgMusic As Byte, camPreset As CameraPresets, envEffect As EnvironmentEffects, enable2DCam As Boolean, bgType As AreaBGs, bgColor As Color, enableShowMsg As Boolean, showMsgDialogID As Byte)
        Dim area As LevelArea = GetLevelAndArea(levelIndex, areaIndex).area

        'Set Area Segmented Banks
        area.SetSegmentedBanks(RomManager)

        'Get Area Settings
        Return (area.TerrainType, area.BGMusic, area.Geolayout.CameraPreset, area.Geolayout.EnvironmentEffect, area.Enable2DCamera, area.Background.Type, area.Background.Color, area.ShowMessage.Enabled, area.ShowMessage.DialogID)
    End Function

    Public Function GetLevelAreaCustomObjectsCount(levelIndex As Integer, areaIndex As Integer) As Integer
        Dim area As LevelArea = GetLevelAndArea(levelIndex, areaIndex).area

        'Get Model Infos
        Return If(area.CustomObjects.Objects?.Count, 0)
    End Function

    Public Function GetLevelAreaScrollingTexturesCount(levelIndex As Integer, areaIndex As Integer) As Integer
        Dim area As LevelArea = GetLevelAndArea(levelIndex, areaIndex).area

        'Get Model Infos
        Return area.ScrollingTextures.Count
    End Function

    Public Sub RemoveLevel(levelIndex As Integer)
        If MessageBoxEx.Show("You are going to remove the selected level. Continue?", "Remove Area", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim infos = GetLevelAndArea(levelIndex)
            If infos.level IsNot Nothing Then
                RomManager.RemoveLevel(infos.level)
                RaiseEvent LevelRemoved(New LevelEventArgs(levelIndex, infos.level.LevelID))
            End If
        End If
    End Sub

    Public Function GetLevelID(levelIndex As Integer)
        Return GetLevelAndArea(levelIndex).level.LevelID
    End Function

    Public Function GetLevelSettings(levelIndex As Integer) As (enableActSelector As Boolean, enableHardcodedCamera As Boolean, hasDefStartPos As Boolean, defStartPosAreaID As Byte, defStartPosYRot As Short, bgMode As Integer, bgImage As Image, bgOriginal As BackgroundIDs, areasCount As Byte)
        Dim lvl As Level = GetLevelAndArea(levelIndex).level
        Dim defPosCmd As LevelscriptCommand = lvl.GetDefaultPositionCmd
        Dim bgMode As Byte
        Dim bgImage As Image = Nothing
        Dim bgOriginal As BackgroundIDs
        Dim defPosAreaID As Byte
        Dim defPosYRot As Short

        lvl.SetSegmentedBanks(RomManager)

        If Not lvl.Background.Enabled Then
            bgMode = 2
            bgOriginal = lvl.Background.ID
        ElseIf lvl.Background.IsCustom Then
            bgMode = 1
            bgImage = lvl.Background.GetImage
        Else
            bgMode = 0
        End If
        bgOriginal = lvl.Background.ID

        If defPosCmd IsNot Nothing Then
            defPosAreaID = clDefaultPosition.GetAreaID(defPosCmd)
            defPosYRot = clDefaultPosition.GetRotation(defPosCmd)
        End If

        Return (
            lvl.ActSelector,
            lvl.HardcodedCameraSettings,
            defPosCmd IsNot Nothing,
            defPosAreaID,
            defPosYRot,
            bgMode,
            bgImage,
            bgOriginal,
            lvl.Areas.Count)
    End Function

    Public Function GetLevelObjectBankDataSettings(levelIndex As Integer) As (objBank0x0C As Integer, objBank0x0D As Integer, objBank0x0E As Integer, enableGlobalObjectBank As Boolean)
        Dim lvl As Level = GetLevelAndArea(levelIndex).level
        Return (
            ObjectBankData(CByte(&HC)).IndexOf(lvl.GetObjectBankData(&HC)) + 1,
            ObjectBankData(CByte(&HD)).IndexOf(lvl.GetObjectBankData(&HD)) + 1,
            ObjectBankData(CByte(&H9)).IndexOf(lvl.GetObjectBankData(&H9)) + 1,
            lvl.EnableGlobalObjectBank)
    End Function

    Public Sub ChangeLevelID(levelIndex As Integer)
        Dim lvl As Level = GetLevelAndArea(levelIndex).level

        If lvl IsNot Nothing Then
            Dim selLvl = OpenLevelSelectDialog()
            If selLvl IsNot Nothing Then
                If RomManager.ChangeLevelID(lvl, selLvl.ID, selLvl.Type) Then
                    SetLevelscriptNeedToSave(lvl)
                End If
                RaiseEvent LevelIDChanged(New LevelEventArgs(levelIndex, lvl.LevelID))
            End If
        End If
    End Sub

    Public Sub ChangeLevelCustomName(levelIndex As Integer)
        Dim lvl As Level = GetLevelAndArea(levelIndex).level

        If lvl IsNot Nothing Then
            Dim curName As String

            If HasLevelCustomName(lvl.LevelID) Then
                curName = GetLevelCustomName(lvl.LevelID)
            Else
                curName = String.Empty
            End If

            Dim newName As String = OpenValueInputDialog("Levelname", curName)

            If newName <> curName Then
                SetLevelCustomName(lvl.LevelID, newName)
                RaiseEvent LevelCustomNameChanged(New LevelEventArgs(levelIndex, lvl.LevelID))
            End If
        End If
    End Sub

    Public Sub ImportLevel()
        ImportLevelAreaPrivate()
    End Sub

    Public Sub ImportLevelArea(levelIndex As Integer)
        Dim lvl As Level = GetLevelAndArea(levelIndex).level
        ImportLevelAreaPrivate(lvl)
    End Sub

    Private Sub ImportLevelAreaPrivate(Optional destLevel As Level = Nothing)
        Dim addAreasOnly As Boolean = destLevel IsNot Nothing
        Dim addedFuncs As New List(Of PluginFunction)
        Dim allFuncs As IEnumerable(Of PluginFunction) = Publics.PluginManager.GetFunctions("levelmanager.importlevels.getilevelmanager")

        Dim cofd As New CommonOpenFileDialog
        cofd.Filters.Add(New CommonFileDialogFilter("SM64 ROMs (*.z64)", "*.z64"))

        Dim cb As New CommonFileDialogComboBox
        cb.Items.Add(New CommonFileDialogComboBoxItem("SM64 RM/Editor"))

        For Each pf As PluginFunction In allFuncs
            If pf.Params.Count >= 1 AndAlso TypeOf pf.Params(0) Is String Then
                addedFuncs.Add(pf)
                cb.Items.Add(New CommonFileDialogComboBoxItem(pf.Params(0)))
            End If
        Next

        cofd.Controls.Add(cb)
        cb.SelectedIndex = 0

        If cofd.ShowDialog = CommonFileDialogResult.Ok Then
            Dim lvlmgr As ILevelManager = Nothing

            Select Case cb.SelectedIndex
                Case 0
                    lvlmgr = New LevelManager
                Case Else
                    lvlmgr = addedFuncs(cb.SelectedIndex - 1).InvokeGet
            End Select

            Dim frm As New ImportLevelDialog(RomManager, destLevel, cofd.FileName, lvlmgr)
            If frm.ShowDialog = DialogResult.OK Then
                If Not addAreasOnly Then
                    destLevel = frm.LevelCopy
                End If

                SetLevelscriptNeedToSave(destLevel)
                SetLevelBank0x0ENeedToSave(destLevel)

                If addAreasOnly Then
                    For Each area As LevelArea In frm.AreasCopy
                        RaiseEvent LevelAreaAdded(New LevelAreaEventArgs(RomManager.Levels.IndexOf(destLevel), destLevel.Areas.IndexOf(area), area.AreaID))
                    Next
                Else
                    RaiseEvent LevelAdded(New LevelEventArgs(RomManager.Levels.IndexOf(destLevel), destLevel.LevelID))
                End If
            End If
        End If
    End Sub

    Public Sub SetLevelBank0x19Length(levelIndex As Integer)
        Dim lvl As Level = GetLevelAndArea(levelIndex).level

        If lvl IsNot Nothing Then
            Dim frm As New ValueInputDialog
            frm.InfoLabel.Text = Form_Main_Resources.Text_NewLength & ":"
            frm.ValueTextBox.Text = TextFromValue(lvl.Bank0x19.Length)

            Dim [continue] As Boolean = True
            Dim minSize As UInteger = RomManagerSettings.DefaultLevelscriptSize

            Do While [continue]
                If frm.ShowDialog = DialogResult.OK Then
                    Dim newVal As Integer = ValueFromText(frm.ValueTextBox.Text)
                    If newVal < minSize Then
                        MessageBoxEx.Show(String.Format(Form_Main_Resources.MsgBox_InvalidBankSize, minSize.ToString("X")), Form_Main_Resources.MsgBox_InvalidBankSize_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        lvl.Bank0x19.Length = newVal
                        SetLevelscriptNeedToSave(lvl)
                        SetLevelBank0x0ENeedToSave(lvl)
                        MessageBoxEx.Show(Form_Main_Resources.MsgBox_BankSizeChangedSuccess, Form_Main_Resources.MsgBox_BankSizeChangedSuccess_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        [continue] = False
                    End If
                Else
                    [continue] = False
                End If
            Loop
        End If
    End Sub

    'M u s i c   M a n a g e r

    Private Function OpenFileDialog_SelectMusicSequenceFile() As (fileName As String, filterIndex As Integer, hasExitedWithOK As Boolean)
        Dim ofd As New OpenFileDialog With {.Filter = "M64 Sequence (*.m64)|*.m64"}
        Dim isOK As DialogResult = ofd.ShowDialog = DialogResult.OK
        Return (ofd.FileName, ofd.FilterIndex, isOK)
    End Function

    Public Sub ExtractMusicSequence(index As Integer)
        Dim curMusic As MusicSequence = GetMusicSequenceByIndex(index)
        Dim sfd As New CommonSaveFileDialog

        sfd.Filters.Add(New CommonFileDialogFilter("M64 Sequence", ".m64"))
        sfd.Filters.Add(New CommonFileDialogFilter("MIDI File", ".mid"))
        sfd.DefaultFileName = curMusic.Name
        sfd.Controls.Add(GetMidiExportDialogControls)

        AddHandler sfd.FileTypeChanged,
            Sub(sender As Object, e As EventArgs)
                Dim dialog As CommonSaveFileDialog = sender
                Dim filterIndex As Integer = dialog.SelectedFileTypeIndex
                Dim c As CommonFileDialogControl = dialog.Controls("MidiChunksSelector")
                c.Visible = filterIndex = 2
                dialog.DefaultExtension = dialog.Filters(dialog.SelectedFileTypeIndex - 1).Extensions.First
            End Sub

        If sfd.ShowDialog = DialogResult.OK Then
            StatusText = Form_Main_Resources.Status_ExportingSequence

            Select Case sfd.SelectedFileTypeIndex
                Case 1 '.m64

                    Try
                        Dim fs As New FileStream(sfd.FileName, FileMode.Create, FileAccess.Write)
                        fs.Write(curMusic.BinaryData, 0, curMusic.BinaryData.Length)
                        fs.Close()
                    Catch ex As Exception
                        MessageBoxEx.Show(Form_Main_Resources.MsgBox_ErrorSavingSequence, Global_Resources.Text_Error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Case 2 '.midi
                    Dim chunks As Byte = 2
                    Select Case CType(sfd.Controls("MidiChunksSelector"), CommonFileDialogComboBox).SelectedIndex
                        Case 0
                            chunks = 1
                        Case 1
                            chunks = 2
                    End Select

                    'Create input stream
                    Dim ms As New MemoryStream(curMusic.BinaryData)
                    ms.Position = 0

                    'Convert .m64 to .midi
                    Try
                        OutputMIDI.ConvertToMIDI(sfd.FileName, ms, chunks, True)
                    Catch ex As Exception
                        MessageBoxEx.Show(Form_Main_Resources.MsgBox_ExportToMidi_Failed & vbNewLine & ex.Message, Form_Main_Resources.MsgBox_ExportToMidi_Failed_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        ms.Close()
                    End Try

            End Select

            StatusText = ""
        End If
    End Sub

    Public Sub ReplaceMusicSequence(index As Integer)
        Dim res = OpenFileDialog_SelectMusicSequenceFile()

        If res.hasExitedWithOK Then
            StatusText = Form_Main_Resources.Status_ImportingSequence
            Dim curMusic As MusicSequence = RomManager.MusicList(index)

            ImportMusicFileToSequence(curMusic, res.fileName, res.filterIndex)

            RaiseEvent MusicSequenceChanged(New MusicSequenceEventArgs(index, curMusic))
        End If

        StatusText = String.Empty
    End Sub

    Public Sub AddNewMusicSequence()
        Select Case RomManager?.MusicList.Count
            Case 127
                If MessageBoxEx.Show(Form_Main_Resources.MsgBox_LimitSequenceCountReached, Form_Main_Resources.MsgBox_LimitSequenceCountReached_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    Return
                End If
            Case Is >= 255
                MessageBoxEx.Show(Form_Main_Resources.MsgBox_MaxSequenceCountReached, Form_Main_Resources.MsgBox_MaxSequenceCountReached_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        Dim res = OpenFileDialog_SelectMusicSequenceFile()
        If res.hasExitedWithOK Then
            Dim curMusic As MusicSequence = Nothing

            StatusText = Form_Main_Resources.Status_CreatingNewSequence
            curMusic = New MusicSequence
            RomManager.MusicList.Add(curMusic)

            ImportMusicFileToSequence(curMusic, res.fileName, res.filterIndex)

            RaiseEvent MusicSequenceAdded(New MusicSequenceEventArgs(RomManager.MusicList.IndexOf(curMusic), curMusic))
        End If

        StatusText = String.Empty
    End Sub

    Private Sub ImportMusicFileToSequence(sequence As MusicSequence, fileName As String, mode As Integer)
        Select Case mode
            Case 1
                Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
                sequence.BinaryData = New Byte(fs.Length - 1) {}
                fs.Read(sequence.BinaryData, 0, fs.Length)
                fs.Close()
        End Select

        sequence.Name = Path.GetFileNameWithoutExtension(fileName)

        sequence.InstrumentSets.Sets.Clear()
        sequence.InstrumentSets.Sets.Add(37)

        RomManager.MusicList.NeedToSaveSequences = True
        RomManager.MusicList.NeedToSaveSequenceNames = True
        RomManager.MusicList.NeedToSaveNInsts = True
    End Sub

    Public Sub RemoveMusicSequence(index As Integer)
        If index >= 0 Then
            Dim sequence As MusicSequence = GetMusicSequenceByIndex(index)

            'Remove sequence
            RomManager.MusicList.RemoveAt(index)

            'Fix Music in Levels
            For Each lvl As Level In RomManager.Levels
                For Each a As LevelArea In lvl.Areas
                    If a.BGMusic = index Then
                        Do While a.BGMusic >= RomManager.MusicList.Count
                            a.BGMusic -= 1
                        Loop
                    ElseIf a.BGMusic > index Then
                        a.BGMusic -= 1
                    End If
                Next
            Next

            RomManager.MusicList.NeedToSaveSequences = True
            RomManager.MusicList.NeedToSaveSequenceNames = True
            RomManager.MusicList.NeedToSaveNInsts = True

            RaiseEvent MusicSequenceRemoved(New MusicSequenceEventArgs(index, sequence))
        End If
    End Sub

    Public Function GetMusicSequenceByIndex(index As Integer) As MusicSequence
        Return RomManager.MusicList.ElementAtOrDefault(index)
    End Function

    Public Sub EditMusicSequenceInHexEditor(index As Integer)
        Dim sequence As MusicSequence = GetMusicSequenceByIndex(index)
        OpenHexEditor(sequence.BinaryData)
        RomManager.MusicList.NeedToSaveSequences = True
        RaiseEvent MusicSequenceChanged(New MusicSequenceEventArgs(index, sequence))
    End Sub

    Public Sub SetMusicSequenceName(index As Integer, name As String)
        Dim sequence As MusicSequence = GetMusicSequenceByIndex(index)
        name = name.Trim

        If Not String.IsNullOrEmpty(name) AndAlso sequence IsNot Nothing Then
            sequence.Name = name

            RomManager.MusicList.NeedToSaveSequenceNames = True

            RaiseEvent MusicSequenceChanged(New MusicSequenceEventArgs(index, sequence))
        End If
    End Sub

    Public Sub SetMusicSequenceInstrumentSet(index As Integer, instSet As Byte)
        Dim sequence As MusicSequence = GetMusicSequenceByIndex(index)

        If sequence IsNot Nothing Then
            sequence.InstrumentSets.Sets.Clear()
            sequence.InstrumentSets.Sets.Add(instSet)

            RomManager.MusicList.NeedToSaveNInsts = True

            RaiseEvent MusicSequenceChanged(New MusicSequenceEventArgs(index, sequence))
        End If
    End Sub

    Public Function GetMusicSeuenceCount() As Integer
        Return RomManager.MusicList.Count
    End Function

    Public Function GetMusicSequenceInfos(index As Integer) As (name As String, instSet As Byte, length As Integer)
        Dim sequence As MusicSequence = GetMusicSequenceByIndex(index)
        Return (sequence.Name, sequence.InstrumentSets.Sets(0), sequence.Lenght)
    End Function

End Class
