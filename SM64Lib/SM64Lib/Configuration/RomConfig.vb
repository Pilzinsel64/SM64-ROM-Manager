Imports System.IO
Imports Newtonsoft.Json.Linq

Namespace Configuration

    Public Class RomConfig

        Public ReadOnly Property LevelConfigs As New Dictionary(Of Byte, LevelConfig)
        Public ReadOnly Property GlobalObjectBankConfig As New ObjectBankConfig
        Public ReadOnly Property MusicConfig As New MusicConfiguration
        Public Property SelectedTextProfileInfo As String = String.Empty

        Public Function GetLevelConfig(levelID As UShort) As LevelConfig
            If LevelConfigs.ContainsKey(levelID) Then
                Return LevelConfigs(levelID)
            Else
                Dim conf As New LevelConfig
                LevelConfigs.Add(levelID, conf)
                Return conf
            End If
        End Function

        Public Shared Function Load(filePath As String) As RomConfig
            Return JObject.Parse(File.ReadAllText(filePath)).ToObject(Of RomConfig)
        End Function

        Public Sub Save(filePath As String)
            File.WriteAllText(filePath, JObject.FromObject(Me).ToString)
        End Sub

    End Class

End Namespace
