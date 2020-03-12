Imports System.Text.RegularExpressions
Imports System.IO
Imports IniParser, IniParser.Model
Imports DevComponents.DotNetBar
Imports Newtonsoft.Json.Linq
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.Editors
Imports System.Windows.Forms
Imports System.Runtime.CompilerServices
Imports OfficeOpenXml
Imports System.Globalization
Imports System.Threading
Imports SM64_ROM_Manager.SettingsManager
Imports System.Reflection
Imports Pilz.S3DFileParser
Imports SM64Lib.Levels
Imports System.Security.Cryptography.X509Certificates
Imports System.Net
Imports System.Net.Security
Imports drsPwEnc

Public Module General

    Private ReadOnly crypter As New drsPwEnc.drsPwEnc

    Public ReadOnly Property DisplayListCommandsWithPointerList As Byte() = {&H1, &H3, &H4, &H6, &HFD}
    Public ReadOnly Property ActSelectorDefaultValues As Byte() = New Byte() {False, False, False, True, True, False, True, True, True, True, True, True, True, True, True, False, False, False, False, False, False, True, True, True, False, False, False, False, False, False, False, False, False, False, False}
    Public ReadOnly Property PluginManager As New Pilz.Reflection.PluginSystem.PluginManager

    Public Declare Sub SetDPIAware Lib "user32.dll" Alias "SetProcessDPIAware" ()

    Public ReadOnly Property MyDataPath As String
        Get
            Static p As String = String.Empty

            If String.IsNullOrEmpty(p) Then
                p = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly.Location), "Data")
            End If

            Return p
        End Get
    End Property

    Public ReadOnly Property MyToolsPath As String
        Get
            Static p As String = String.Empty

            If String.IsNullOrEmpty(p) Then
                p = Path.Combine(MyDataPath, "Tools")
            End If

            Return p
        End Get
    End Property

    Public ReadOnly Property MyTweaksPath As String
        Get
            Static p As String = String.Empty

            If String.IsNullOrEmpty(p) Then
                p = Path.Combine(MyDataPath, "Tweaks")
            End If

            Return p
        End Get
    End Property

    Public ReadOnly Property MyPluginsPath As String
        Get
            Static p As String = String.Empty

            If String.IsNullOrEmpty(p) Then
                p = Path.Combine(MyDataPath, "Plugins")
            End If

            Return p
        End Get
    End Property

    Public ReadOnly Property MyUserRequestsPath As String
        Get
            Static p As String = String.Empty

            If String.IsNullOrEmpty(p) Then
                p = Path.Combine(MyDataPath, "UserRequests")
            End If

            Return p
        End Get
    End Property

    Public ReadOnly Property MyImporterPresetsPath As String
        Get
            Static p As String = String.Empty

            If String.IsNullOrEmpty(p) Then
                p = Path.Combine(MyDataPath, "Importer Presets")
            End If

            Return p
        End Get
    End Property

    Public ReadOnly Property IsDebugging As Boolean
        Get
            Return Debugger.IsAttached
        End Get
    End Property

    Public ReadOnly Property IsDesigneTime As Boolean
        Get
            Return System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime
        End Get
    End Property

    Public ReadOnly Property SurfaceData As ExcelWorkbook
        Get
            Static _SurfaceData As New ExcelPackage(New FileInfo(MyDataPath & "\Other\Surface Data.xlsx"))
            Return _SurfaceData.Workbook
        End Get
    End Property

    Public ReadOnly Property OtherData As ExcelWorkbook
        Get
            Static _OtherData As New ExcelPackage(New FileInfo(MyDataPath & "\Other\Other Data.xlsx"))
            Return _OtherData.Workbook
        End Get
    End Property

    Public Sub SetSM64LibFilePathConfigs()
        Dim config = SM64Lib.FilePathsConfiguration.DefaultConfiguration
        config.SetFilePath("rn64crc.exe", Path.Combine(MyDataPath, "Tools\rn64crc.exe"))
        config.SetFilePath("Apply 3D Coins.ppf", Path.Combine(MyDataPath, "Patchs\3D-Coins\Apply 3D Coins.ppf"))
        config.SetFilePath("Remove 3D Coins.ppf", Path.Combine(MyDataPath, "Patchs\3D-Coins\Remove 3D Coins.ppf"))
        config.SetFilePath("ApplyPPF3.exe", Path.Combine(MyDataPath, "Tools\ApplyPPF3.exe"))
        config.SetFilePath("Level Tabel.json", Path.Combine(MyDataPath, "Other\Level Tabel.json"))
        config.SetFilePath("Update-Patches.json", Path.Combine(MyDataPath, "Patchs\Update-Patches\Update-Patches.json"))
        config.SetFilePath("Update Patches Folder", Path.Combine(MyDataPath, "Patchs\Update-Patches"))
        config.SetFilePath("Text Profiles.json", Path.Combine(MyDataPath, "Text Manager\Profiles.json"))
        config.SetFilePath("SM64_ROM_Manager.ppf", Path.Combine(MyDataPath, "Patchs\SM64_ROM_Manager.ppf"))
        config.SetFilePath("sm64extend.exe", Path.Combine(MyDataPath, "Tools\sm64extend.exe"))
        config.SetFilePath("Original Level Pointers.bin", Path.Combine(MyDataPath, "Other\Original Level Pointers.bin"))
    End Sub

#If RelMono Then
    Private Sub SetServerCertificateValidationCallback()
        ServicePointManager.ServerCertificateValidationCallback = AddressOf MyRemoteCertificateValidationCallback
    End Sub

    Private Function MyRemoteCertificateValidationCallback(sender As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean
        Dim isOk As Boolean = True
        ' If there are errors in the certificate chain, look at each error to determine the cause.
        If sslPolicyErrors <> SslPolicyErrors.None Then
            For i As Integer = 0 To chain.ChainStatus.Length - 1
                If chain.ChainStatus(i).Status <> X509ChainStatusFlags.RevocationStatusUnknown Then
                    chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain
                    chain.ChainPolicy.RevocationMode = X509RevocationMode.Online
                    chain.ChainPolicy.UrlRetrievalTimeout = New TimeSpan(0, 1, 0)
                    chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags
                    Dim chainIsValid As Boolean = chain.Build(CType(certificate, X509Certificate2))
                    If Not chainIsValid Then
                        isOk = False
                    End If
                End If
            Next i
        End If
        Return isOk
    End Function
#End If

    Public Sub SetDefaultProxyAuthentification()
        If Not String.IsNullOrEmpty(Settings.Network.ProxyUsername) OrElse Not String.IsNullOrEmpty(Settings.Network.ProxyPasswordEncrypted) Then
            WebRequest.DefaultWebProxy.Credentials =
                New NetworkCredential(Settings.Network.ProxyUsername,
                                      If(String.IsNullOrEmpty(Settings.Network.ProxyPasswordEncrypted), String.Empty, crypter.DecryptData(Settings.Network.ProxyPasswordEncrypted)))
        Else
            WebRequest.DefaultWebProxy.Credentials = Nothing
        End If
    End Sub

    Public Sub DoDefaultInitsAfterApplicationStartup()
#If RelMono Then
        'Set server certification validation callback
        SetServerCertificateValidationCallback()
#End If

        'Load Settings
        Settings.SettingsConfigFilePath = Path.Combine(MyDataPath, "Settings.json")

        'Set proxy settings
        SetDefaultProxyAuthentification()

        'Set Style
        SetVisualTheme()

        'Set language
        SetCurrentLanguageCulture(Settings.General.Language)

        'Set File Path Config
        SetSM64LibFilePathConfigs()

        'Set paths to Assimp-Libs
        AssimpModule.AssimpLoader.PathToAssimpLib32 = Path.Combine(MyDataPath, "Lib\Assimp32.dll")
        AssimpModule.AssimpLoader.PathToAssimpLib64 = Path.Combine(MyDataPath, "Lib\Assimp64.dll")

        'Do waiting auto jobs
        ExecuteStartupJobsToDo()
        AddHandler Settings.MySettingsManager.AutoSavingSettings, AddressOf ExecuteExitJobsToDo
    End Sub

    Public Sub SetCurrentLanguageCulture(cultureName As String)
        Dim culture As CultureInfo

        If String.IsNullOrEmpty(cultureName) Then
            culture = Thread.CurrentThread.CurrentCulture
            If culture.Name = Thread.CurrentThread.CurrentCulture.Name Then
                culture = Nothing
            End If
        Else
            culture = New CultureInfo(cultureName)
        End If

        If culture IsNot Nothing Then
            'Change on current Thread
            'Thread.CurrentThread.CurrentCulture = culture
            Thread.CurrentThread.CurrentUICulture = culture

            'Change for all new threads
            'CultureInfo.DefaultThreadCurrentCulture = culture
            CultureInfo.DefaultThreadCurrentUICulture = culture
        End If
    End Sub

    ''' <param name="mode">0 = Loader; 1 = Exporter</param>
    Public Function GetExtensionFilter(strmodul As String, mode As Byte) As String
        Dim modul As File3DLoaderModule = If(mode = 0, GetLoaderModuleFromID(strmodul), GetExporterModuleFromID(strmodul))
        Return GetExtensionFilter(modul)
    End Function

    Public Function GetExtensionFilter(modul As File3DLoaderModule) As String
        Dim combiFormats As String = ""
        Dim splittedFormats As String = ""

        For Each kvp In modul.SupportedFormats
            If combiFormats <> "" Then
                combiFormats &= ";"
            End If
            combiFormats &= "*." & kvp.Key

            If splittedFormats <> "" Then
                splittedFormats &= "|"
            End If

            splittedFormats &= $"{kvp.Value} (*.{kvp.Key})|*.{kvp.Key}"
        Next

        Return $"All supported files|{combiFormats}|{splittedFormats}"
    End Function

    Public Function KeepDegreesWithin360(value As Short) As Short
        If value < 0 Then
            Return 360 + (value Mod -360)
        Else
            Return value Mod 360
        End If
    End Function

    Public Sub DisableAmbientColor(c As Control, types() As Type, state As eAmbientSettings)
        Dim abm As New StyleManagerAmbient
        If types.Contains(c.GetType) Then
            abm.SetEnableAmbientSettings(c, state)
        End If
        For Each cc As Control In c.Controls
            DisableAmbientColor(cc, types, eAmbientSettings.BackColor)
        Next
    End Sub

    Public Function CompareTwoByteArrays(arr1() As Byte, arr2() As Byte) As Boolean
        If arr2.Count <> arr1.Count Then Return False

        For i As Integer = 0 To arr1.Count - 1
            If arr1(i) <> arr2(i) Then Return False
        Next

        Return True
    End Function

    Public Sub ShowToastnotification(Parent As Control, Text As String, Color As eToastGlowColor, Optional Timeout As Integer = 5000)
        'ToastNotification.ToastBackColor = Drawing.Color.LightGray
        'ToastNotification.ToastForeColor = Drawing.Color.Black
        ToastNotification.Show(Parent, Text, Nothing, Timeout, Color)
    End Sub

    Public Function GetLevelIndexFromID(LevelID As Byte) As Byte
        Select Case LevelID
            Case &H4 : Return 0
            Case &H5 : Return 1
            Case &H6 : Return 2
            Case &H7 : Return 3
            Case &H8 : Return 4
            Case &H9 : Return 5
            Case &HA : Return 6
            Case &HB : Return 7
            Case &HC : Return 8
            Case &HD : Return 9
            Case &HE : Return 10
            Case &HF : Return 11
            Case &H10 : Return 12
            Case &H11 : Return 13
            Case &H12 : Return 14
            Case &H13 : Return 15
            Case &H14 : Return 16
            Case &H15 : Return 17
            Case &H16 : Return 18
            Case &H17 : Return 19
            Case &H18 : Return 20
            Case &H19 : Return 21
            Case &H1A : Return 22
            Case &H1B : Return 23
            Case &H1C : Return 24
            Case &H1D : Return 25
            Case &H1E : Return 26
            Case &H1F : Return 27
            Case &H21 : Return 28
            Case &H22 : Return 29
            Case &H24 : Return 30
            Case Else : Return 5
        End Select
    End Function
    Public Function GetLevelIDFromIndex(LevelID As Byte) As Byte
        Select Case LevelID
            Case 0 : Return &H4
            Case 1 : Return &H5
            Case 2 : Return &H6
            Case 3 : Return &H7
            Case 4 : Return &H8
            Case 5 : Return &H9
            Case 6 : Return &HA
            Case 7 : Return &HB
            Case 8 : Return &HC
            Case 9 : Return &HD
            Case 10 : Return &HE
            Case 11 : Return &HF
            Case 12 : Return &H10
            Case 13 : Return &H11
            Case 14 : Return &H12
            Case 15 : Return &H13
            Case 16 : Return &H14
            Case 17 : Return &H15
            Case 18 : Return &H16
            Case 19 : Return &H17
            Case 20 : Return &H18
            Case 21 : Return &H19
            Case 22 : Return &H1A
            Case 23 : Return &H1B
            Case 24 : Return &H1C
            Case 25 : Return &H1D
            Case 26 : Return &H1E
            Case 27 : Return &H1F
            Case 28 : Return &H21
            Case 29 : Return &H22
            Case 30 : Return &H24
            Case Else : Return 5
        End Select
    End Function

    Public Function TrimString(str As String) As String
        Dim str1 As String
        Try
            str1 = (New Regex("^[ \t]+|[ \t]+$", RegexOptions.IgnoreCase)).Replace(str, "")
        Catch exception As Exception
            exception.ToString()
            str1 = str
        End Try
        Return str1
    End Function

    Public Function HexRoundUp1(value As Integer) As Integer
        Do
            If Hex(value).EndsWith("0") Then Exit Do 'Or Hex(value).EndsWith("8")
            value += 1
        Loop
        Return value
    End Function
    Public Sub HexRoundUp2(ByRef value As Integer)
        Do
            If Hex(value).EndsWith("0") Then Exit Do 'Or Hex(value).EndsWith("8")
            value += 1
        Loop
    End Sub

    Public Function GetNextAreaID(lvl As Level) As (newID As Byte?, isAnyFree As Boolean)
        Dim newID As Byte? = Nothing
        Dim isAnyFree As Boolean = False

        'Check for left area IDs
        For i As Integer = 0 To Byte.MaxValue
            If newID Is Nothing Then
                Dim areaID As Byte = i

                If Not lvl.Areas.Where(Function(n) n.AreaID = areaID).Any Then
                    If areaID <> 0 Then
                        newID = areaID
                    End If

                    isAnyFree = True
                End If
            End If
        Next

        Return (newID, isAnyFree)
    End Function

    Public Function GetAllFreeAreaIDs(lvl As Level) As Stack(Of Byte)
        Dim ids As New Stack(Of Byte)

        Dim addAreaIfNotUsed =
            Sub(areaID As Byte)
                If Not lvl.Areas.Where(Function(n) n.AreaID = areaID).Any Then
                    ids.Push(areaID)
                End If
            End Sub
        addAreaIfNotUsed(0)
        For i As Integer = Byte.MaxValue To 1 Step -1
            addAreaIfNotUsed(i)
        Next

        Return ids
    End Function

    Public Class Bits
        Shared Function ByteToBitArray(b As Byte) As Byte()
            Dim bitarray As New BitArray({b})
            Dim temp(0 To bitarray.Length - 1) As Byte
            For i As Integer = 0 To bitarray.Length - 1
                temp(i) = bitarray(i)
            Next
            Dim tindex As Integer = 0
            Dim temp2(0 To temp.Count - 1) As Byte
            For i As Integer = temp.Length - 1 To 0 Step -1
                temp2(tindex) = temp(i)
                tindex += 1
            Next
            Return temp2
        End Function
        Shared Function ByteToBoolArray(b As Byte) As Boolean()
            Dim bitarray As New BitArray({b})
            Dim temp(0 To bitarray.Length - 1) As Boolean
            For i As Integer = 0 To bitarray.Length - 1
                temp(i) = Convert.ToBoolean(bitarray(i))
            Next
            Dim tindex As Integer = 0
            Dim temp2(0 To temp.Count - 1) As Boolean
            For i As Integer = temp.Length - 1 To 0 Step -1
                temp2(tindex) = temp(i)
                tindex += 1
            Next
            Return temp2
        End Function

        Shared Function ArrayToByte(ba() As Byte) As Byte
            'ODER: BitArray.ToByte()

            Dim endval As Byte = 0
            Dim index As Integer = ba.Count - 1
            For Each bit In ba
                endval += bit * (2 ^ index)
                index -= 1
            Next
            Return endval
        End Function
        Shared Function ArrayToByte(ba() As Boolean) As Byte
            'ODER: BitArray.ToByte()

            Dim endval As Byte = 0
            Dim index As Integer = ba.Count - 1
            For Each bit In ba
                endval += If(bit, 1, 0) * (2 ^ index)
                index -= 1
            Next
            Return endval
        End Function

        Shared Function SetInByte(b As Byte, index As Integer, value As Byte) As Byte
            Dim temp = ByteToBitArray(b)
            temp(index) = value
            Return ArrayToByte(temp)
        End Function
        Shared Function SetInByte(b As Byte, index As Integer, value As Boolean) As Byte
            Dim temp = ByteToBoolArray(b)
            temp(index) = value
            Return ArrayToByte(temp)
        End Function

        Shared Function GetBitOfByte(b As Byte, index As Integer) As Byte
            Return ByteToBitArray(b)(index)
        End Function
        Shared Function GetBoolOfByte(b As Byte, index As Integer) As Boolean
            Return ByteToBoolArray(b)(index)
        End Function
    End Class

End Module
