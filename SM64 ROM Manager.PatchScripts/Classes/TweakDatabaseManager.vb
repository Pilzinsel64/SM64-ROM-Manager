Imports System.IO
Imports System.Net
Imports WebDav

Public Class TweakDatabaseManager

    Private Shared ReadOnly crypter As New drsPwEnc.drsPwEnc

    Public ReadOnly Property Preferences As TweakDatabasePreferences

    Public Sub New(pref As TweakDatabasePreferences)
        Preferences = pref
    End Sub

    Private Function CreateClient(t As TweakDatabaseLoginTypes) As WebDavClient
        Static dicClients As New Dictionary(Of TweakDatabaseLoginTypes, WebDavClient)

        If Not dicClients.ContainsKey(t) Then
            Dim login As TweakDatabaseLoginPreferences = Preferences.Logins(t)
            Dim params As New WebDavClientParams With {
                .BaseAddress = New Uri(login.Link),
                .Credentials = New NetworkCredential(login.Username, login.Password)
            }
            dicClients.Add(t, New WebDavClient(params))
        End If

        Return dicClients(t)
    End Function

    Public Async Function CheckForUpdates(localPath As String) As Task(Of IEnumerable(Of TweakDatabaseSyncFile))
        Dim client As WebDavClient = CreateClient(TweakDatabaseLoginTypes.ReadOnlyAll)
        Dim syncFiles As New List(Of TweakDatabaseSyncFile)
        Dim checkOutFolder As Func(Of String, Task) = Nothing
        Dim resTopFolder As WebDavResource = Nothing
        Dim checkedFiles As New List(Of String)
        Dim responseSuccessfull As Boolean = False

        checkOutFolder =
            Async Function(remotePath As String) As Task
                Dim response As PropfindResponse = Await client.Propfind(remotePath)

                If resTopFolder Is Nothing AndAlso response.IsSuccessful AndAlso response.Resources.Any Then
                    resTopFolder = response.Resources(0)
                    responseSuccessfull = True
                End If

                If responseSuccessfull AndAlso response.Resources.Count > 1 Then
                    For i As Integer = 1 To response.Resources.Count - 1
                        Dim res As WebDavResource = response.Resources(i)
                        Dim isFolder As Boolean = res.Uri.EndsWith("/")

                        If isFolder Then
                            Await checkOutFolder(res.Uri)
                        Else
                            Dim syncAction As TweakDatabaseSyncAction? = Nothing
                            Dim localFile As String = String.Empty
                            Dim remoteFile As String = String.Empty

                            'Get remote file path
                            remoteFile = res.Uri

                            'Get local file path
                            localFile = Path.Combine(localPath, Uri.UnescapeDataString(res.Uri.Substring(resTopFolder.Uri.Length)).Replace("/", "\"))

                            'Check action
                            If File.Exists(localFile) Then
                                If File.GetLastWriteTime(localFile) < res.LastModifiedDate Then
                                    syncAction = TweakDatabaseSyncAction.UpdatedFile
                                End If
                            Else
                                syncAction = TweakDatabaseSyncAction.NewFile
                            End If

                            'Add to list
                            checkedFiles.Add(localFile)
                            If syncAction IsNot Nothing Then
                                syncFiles.Add(New TweakDatabaseSyncFile(syncAction, localFile, remoteFile))
                            End If
                        End If
                    Next
                End If
            End Function

        'Check for new & updated files
        Await checkOutFolder(Preferences.CategoryPaths(TweakDatabaseCategories.Reviewed))

        'Find all old files to remove
        If responseSuccessfull Then
            Dim allLocalFiles As String() = Directory.GetFiles(localPath, "*", SearchOption.AllDirectories)
            For Each lf As String In allLocalFiles
                Dim isKnown As Boolean = False

                For Each checkedFile As String In checkedFiles
                    If Not isKnown AndAlso checkedFile = lf Then
                        isKnown = True
                    End If
                Next

                If Not isKnown Then
                    syncFiles.Add(New TweakDatabaseSyncFile(TweakDatabaseSyncAction.RemovedFile, lf, String.Empty))
                End If
            Next
        End If

        Return syncFiles
    End Function

    Public Async Function Update(syncFiles As IEnumerable(Of TweakDatabaseSyncFile)) As Task
        Dim client As WebDavClient = CreateClient(TweakDatabaseLoginTypes.ReadOnlyAll)

        For Each syncFile As TweakDatabaseSyncFile In syncFiles
            If syncFile.SyncAction = TweakDatabaseSyncAction.UpdatedFile OrElse syncFile.SyncAction = TweakDatabaseSyncAction.RemovedFile Then
                File.Delete(syncFile.LocalFile)
            End If

            If syncFile.SyncAction = TweakDatabaseSyncAction.UpdatedFile OrElse syncFile.SyncAction = TweakDatabaseSyncAction.NewFile Then
                Dim response As WebDavStreamResponse = Await client.GetProcessedFile(syncFile.RemoteFile)
                Dim dirParent As New DirectoryInfo(Path.GetDirectoryName(syncFile.LocalFile))

                If Not dirParent.Exists Then
                    dirParent.Create()
                End If

                Dim fs As New FileStream(syncFile.LocalFile, FileMode.Create, FileAccess.Write)
                response.Stream.CopyTo(fs)
                fs.Close()
            End If
        Next
    End Function

    Public Async Function Upload(fileName As String) As Task(Of Boolean)
        Dim client As WebDavClient = CreateClient(TweakDatabaseLoginTypes.UserUploads)
        Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
        Dim result As WebDavResponse = Await client.PutFile(Path.GetFileName(fileName), fs)

        fs.Close()

        Return result.IsSuccessful
    End Function

End Class
