Imports DevComponents.DotNetBar
Imports Pilz.S3DFileParser
Imports SM64Lib
Imports SM64Lib.ObjectBanks

Public Class CustomBankManager

    'E v e n t s

    Public Event ObjectAdded As EventHandler
    Public Event ObjectRemoved As EventHandler

    'P r i v a t e   M e m b e r s

    Private rommgr As RomManager
    Private objBank As CustomObjectBank
    Private curObj As CustomObject = Nothing
    Private ReadOnly knownVisualMaps As New Dictionary(Of Model.Fast3D.Fast3DBuffer, Object)
    Private ReadOnly knownCollisionMaps As New Dictionary(Of Model.Collision.CollisionMap, Object)

    'P r i v a t e   P r o p e r t i e s

    Private WriteOnly Property LayoutGroups_Enabled As Boolean
        Set
            TextBoxX_ModelID.Enabled = Value
            TextBoxX_Name.Enabled = Value
            LabelX_CollisionPointerDestinationsCount.Enabled = Value
            ButtonX_EditCollisionPointerDestinations.Enabled = Value
            ButtonX_ImportModel.Enabled = Value
            ButtonX_RemoveObject.Enabled = Value
        End Set
    End Property

    'C o n s t r u c t o r s

    Public Sub New(rommgr As RomManager, objBank As CustomObjectBank)
        InitializeComponent()
        UpdateAmbientColors
        LayoutGroups_Enabled = False
        Me.rommgr = rommgr
        Me.objBank = objBank
    End Sub

    'F e a t u r e s

    Private Sub LoadList()
        ItemListBox1.SuspendLayout()
        ItemListBox1.Items.Clear()

        For Each obj As CustomObject In objBank.Objects
            AddItemToList(obj)
        Next

        ItemListBox1.ResumeLayout()
        ItemListBox1.Refresh()
    End Sub

    Private Function TextForButtonItem(obj As CustomObject) As String
        Dim txt As String = $"Model-ID: {TextFromValue(obj.ModelID,, 3)}"

        If Not String.IsNullOrEmpty(obj.Config.Name) Then
            txt &= $" - {obj.Config.Name}"
        End If

        Return txt
    End Function

    Private Function AddItemToList(obj As CustomObject) As ButtonItem
        Dim item As New ButtonItem With {
            .Text = TextForButtonItem(obj),
            .Tag = obj
        }

        AddHandler item.CheckedChanged, Sub(sender As ButtonItem, e As EventArgs) If sender.Checked Then LoadCustomObject(sender.Tag)
        AddHandler item.MouseUp,
            Sub(sender, e)
                If e.Button = MouseButtons.Right Then
                    Dim hasCollision As Boolean = obj.Model.Collision IsNot Nothing
                    ButtonItem_ImportCollision.Enabled = hasCollision
                    ButtonItem_RemoveCollision.Enabled = hasCollision
                    ButtonItem_ShowCollision.Enabled = hasCollision
                    ButtonItem_CopyCollisionPointer.Enabled = hasCollision
                    CM_Object.Popup(Cursor.Position)
                End If
            End Sub

        ItemListBox1.Items.Add(item)

        Return item
    End Function

    Private Sub LoadCustomObject(obj As CustomObject)
        curObj = obj
        LayoutGroups_Enabled = True
        TextBoxX_ModelID.Text = TextFromValue(obj.ModelID)
        TextBoxX_Name.Text = obj.Config.Name
        LabelX_CollisionPointerDestinationsCount.Text = obj.Config.CollisionPointerDestinations.Count
    End Sub

    Private Sub CreateCustomObject()
        Dim obj As New CustomObject
        Dim item As ButtonItem

        If ImportNewModel(obj) Then
            objBank.Objects.Add(obj)
            item = AddItemToList(obj)
            item.RaiseClick()
            RaiseEvent ObjectAdded(Me, New EventArgs)
        End If
    End Sub

    Private Function ImportNewModel(obj As CustomObject, Optional checkVisualMap As Boolean = True, Optional checkCollision As Boolean = True) As Boolean
        If obj IsNot Nothing Then
            Dim resMdl = ModelConverterGUI.GetModelViaModelConverter(obj.Model IsNot Nothing,
                                                                     True,
                                                                     checkVisualMap OrElse obj.Model Is Nothing,
                                                                     checkCollision)

            If resMdl IsNot Nothing Then
                If obj.Model Is Nothing OrElse (resMdl?.hasCollision AndAlso resMdl?.hasVisualMap) Then
                    obj.Model = resMdl?.mdl
                    RemoveKnownMaps(obj)
                ElseIf resMdl?.hasCollision Then
                    RemoveKnownCollisionMap(obj)
                    obj.Model.Collision = resMdl?.mdl.Collision
                ElseIf resMdl?.hasVisualMap Then
                    RemoveKnownVisualMap(obj)
                    obj.Model.Fast3DBuffer = resMdl?.mdl.Fast3DBuffer
                End If
                Return True
            End If
        End If

        Return False
    End Function

    Private Sub RemoveCollision(curObj As CustomObject)
        curObj.Model.Collision = Nothing
    End Sub

    Private Sub RemoveKnownVisualMap(curObj As CustomObject)
        knownVisualMaps.RemoveIfContainsKey(curObj.Model.Fast3DBuffer)
    End Sub

    Private Sub RemoveKnownCollisionMap(curObj As CustomObject)
        If curObj.Model.Collision IsNot Nothing Then
            knownCollisionMaps.RemoveIfContainsKey(curObj.Model.Collision)
        End If
    End Sub

    Private Sub RemoveKnownMaps(curObj As CustomObject)
        RemoveKnownVisualMap(curObj)
        RemoveKnownCollisionMap(curObj)
    End Sub

    Private Sub RemoveCurObject()
        RemoveKnownMaps(curObj)
        objBank.Objects.Remove(curObj)

        Dim itr As New List(Of BaseItem)
        For Each item As ButtonItem In ItemListBox1.Items
            If item.Tag Is curObj Then
                itr.Add(item)
            End If
        Next
        For Each item In itr
            ItemListBox1.Items.Remove(item)
        Next

        LayoutGroups_Enabled = False
        curObj = Nothing

        RaiseEvent ObjectRemoved(Me, New EventArgs)
    End Sub

    Private Sub UpdateButtonItems()
        Dim selItem As ButtonItem = ItemListBox1.SelectedItem
        Dim updateItem =
            Sub(btn As ButtonItem)
                If btn IsNot Nothing Then
                    btn.Text = TextForButtonItem(btn.Tag)
                End If
            End Sub

        If selItem IsNot Nothing Then
            updateItem(selItem)
        Else
            For Each btn As ButtonItem In ItemListBox1.Items
                updateItem(btn)
            Next
        End If

        ItemListBox1.Refresh()
    End Sub

    Private Sub ShowModel(obj As Object3D)
        Dim preview As New ModelConverterGUI.ModelPreviewOfficeForm(obj, 1)
        preview.Show()
    End Sub

    Private Sub ShowVisualMap(customObj As CustomObject)
        Dim obj As Object3D
        Dim key As Model.Fast3D.Fast3DBuffer = customObj.Model.Fast3DBuffer

        If knownVisualMaps.ContainsKey(key) Then
            obj = knownVisualMaps(key)
        Else
            obj = LoadVisualMapAsObject3D(rommgr, curObj.Model.Fast3DBuffer)
            knownVisualMaps.Add(key, obj)
        End If

        ShowModel(obj)
    End Sub

    Private Sub ShowCollision(customObj As CustomObject)
        Dim obj As Object3D
        Dim key As Model.Collision.CollisionMap = customObj.Model.Collision

        If knownCollisionMaps.ContainsKey(key) Then
            obj = knownCollisionMaps(key)
        Else
            obj = curObj.Model.Collision.ToObject3D
            knownCollisionMaps.Add(key, obj)
        End If

        ShowModel(obj)
    End Sub

    Private Sub CopyCollisionPointer(customObj As CustomObject)
        Clipboard.SetText(TextFromValue(customObj.CollisionPointer))
    End Sub

    'G U I

    Private Sub CustomBankManager_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadList()
    End Sub

    Private Sub TextBoxX_ModelID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX_ModelID.TextChanged
        Try
            curObj.ModelID = ValueFromText(TextBoxX_ModelID.Text)
            UpdateButtonItems()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxX_Name_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX_Name.TextChanged
        Try
            curObj.Config.Name = TextBoxX_Name.Text.Trim
            UpdateButtonItems()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonX_EditCollisionPointerDestinations_Click(sender As Object, e As EventArgs) Handles ButtonX_EditCollisionPointerDestinations.Click
        Dim editor As New AddressListEditor With {
            .AddressList = curObj.Config.CollisionPointerDestinations
        }
        editor.ShowDialog()
        LoadCustomObject(curObj)
    End Sub

    Private Sub ButtonItem_RemoveObject_Click(sender As Object, e As EventArgs) Handles ButtonX_RemoveObject.Click, ButtonItem_RemoveObject.Click
        If MessageBoxEx.Show("Do you realy want to remove this custom object? You will not be able to restore it.", "Remove Custom Object", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            RemoveCurObject()
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX_CreateNewObject.Click
        CreateCustomObject()
    End Sub

    Private Sub ButtonItem_ShowVisualMap_Click(sender As Object, e As EventArgs) Handles ButtonItem_ShowVisualMap.Click
        ShowVisualMap(curObj)
    End Sub

    Private Sub ButtonItem_ShowCollision_Click(sender As Object, e As EventArgs) Handles ButtonItem_ShowCollision.Click
        ShowCollision(curObj)
    End Sub

    Private Sub ButtonItem_ImportModell_Click(sender As Object, e As EventArgs) Handles ButtonItem_ImportModell.Click, ButtonX_ImportModel.Click
        ImportNewModel(curObj)
    End Sub

    Private Sub ButtonItem_ImportVisualMap_Click(sender As Object, e As EventArgs) Handles ButtonItem_ImportVisualMap.Click
        ImportNewModel(curObj,, False)
    End Sub

    Private Sub ButtonItem_ImportCollision_Click(sender As Object, e As EventArgs) Handles ButtonItem_ImportCollision.Click
        ImportNewModel(curObj, False)
    End Sub

    Private Sub ButtonItem_RemoveCollision_Click(sender As Object, e As EventArgs) Handles ButtonItem_RemoveCollision.Click
        RemoveCollision(curObj)
    End Sub

    Private Sub ButtonItem_CopyCollisionPointer_Click(sender As Object, e As EventArgs) Handles ButtonItem_CopyCollisionPointer.Click
        CopyCollisionPointer(curObj)
    End Sub
End Class
