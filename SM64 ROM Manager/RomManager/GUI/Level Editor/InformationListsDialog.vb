Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar

Namespace LevelEditor

    Public Class InformationListDialog

        Private avaiableCombos As ObjectComboList = Nothing
        Private editMode As EditModes
        Private finishedLoading As Boolean = False
        Private ReadOnly objComboListItems As New List(Of BaseItem)
        Private ReadOnly behavListItems As New List(Of BaseItem)

        'E N U M S

        Public Enum EditModes
            Editable = 1
            EnableObjComboTab = 2
            EnableBehavTab = 4
        End Enum

        Public Enum ItemsType
            ObjCombos
            Behavs
        End Enum

        'C O N S T R U C T O R S

        Public Sub New(editMode As EditModes)
            InitializeComponent()
            SetUpPropertyGrid()
            Me.editMode = editMode
            LoadObjectCombosIfEmpty()
            LoadBehaviorInfosIfEmpty()
            SetUI()
            TextBoxX_Search.Select()
            UpdateAmbientColors
        End Sub

        Public Sub New(editMode As EditModes, avaiableCombos As ObjectComboList)
            Me.New(editMode)
            Me.avaiableCombos = avaiableCombos
        End Sub

        'P R O P E R T I E S

        Private ReadOnly Property EnableEdit As Boolean
            Get
                Return (editMode And EditModes.Editable) = EditModes.Editable
            End Get
        End Property

        Public ReadOnly Property EnableObjCombos As Boolean
            Get
                Return (editMode And EditModes.EnableObjComboTab) = EditModes.EnableObjComboTab
            End Get
        End Property

        Public ReadOnly Property EnableBehavs As Boolean
            Get
                Return (editMode And EditModes.EnableBehavTab) = EditModes.EnableBehavTab
            End Get
        End Property

        Public Property SelectedObjectCombo As ObjectCombo
            Get
                If CurrentItemsType = ItemsType.ObjCombos Then
                    Return ItemList.SelectedItem?.Tag
                Else
                    Return Nothing
                End If
            End Get
            Set
                If CurrentItemsType = ItemsType.ObjCombos Then
                    Dim hasFound As Boolean = False
                    For Each item As BaseItem In objComboListItems
                        If TypeOf item?.Tag Is ObjectCombo AndAlso Not hasFound AndAlso item.Tag Is Value Then
                            ItemList.SelectedItem = item
                            ItemList.EnsureVisible(item)
                            ItemList.Refresh()
                            hasFound = True
                        End If
                    Next
                End If
            End Set
        End Property

        Public Property SelectedBehavior As BehaviorInfo
            Get
                If CurrentItemsType = ItemsType.Behavs Then
                    Return ItemList.SelectedItem?.Tag
                Else
                    Return Nothing
                End If
            End Get
            Set
                If CurrentItemsType = ItemsType.Behavs Then
                    Dim hasFound As Boolean = False
                    For Each item As BaseItem In behavListItems
                        If TypeOf item?.Tag Is BehaviorInfo AndAlso Not hasFound AndAlso item.Tag Is Value Then
                            ItemList.SelectedItem = item
                            ItemList.EnsureVisible(item)
                            ItemList.Refresh()
                            hasFound = True
                        End If
                    Next
                End If
            End Set
        End Property

        Public ReadOnly Property CurrentItemsType As ItemsType
            Get
                If TabStrip1.SelectedTab Is TabItem_ObjectCombos Then
                    Return ItemsType.ObjCombos
                ElseIf TabStrip1.SelectedTab Is TabItem_Behaviors Then
                    Return ItemsType.Behavs
                Else
                    Return Nothing
                End If
            End Get
        End Property

        Private ReadOnly Property CurrentObjectList As IEnumerable
            Get
                Select Case CurrentItemsType
                    Case ItemsType.ObjCombos
                        Return ObjectCombos
                    Case ItemsType.Behavs
                        Return BehaviorInfos
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        Private ReadOnly Property CurrentCustomObjectList As IList
            Get
                Select Case CurrentItemsType
                    Case ItemsType.ObjCombos
                        Return ObjectCombosCustom
                    Case ItemsType.Behavs
                        Return BehaviorInfosCustom
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        Private ReadOnly Property CurrentItemsList As List(Of BaseItem)
            Get
                Select Case CurrentItemsType
                    Case ItemsType.ObjCombos
                        Return objComboListItems
                    Case ItemsType.Behavs
                        Return behavListItems
                    Case Else
                        Return Nothing
                End Select
            End Get
        End Property

        'F U N C T I O N S

        Private Sub SetUpPropertyGrid()
            'Make B. Params expandable
            For i As Integer = 1 To 4
                Dim propset As New PropertySettings
                propset.DisplayName = "Param " & i
                propset.PropertyName = "BParam" & i
                propset.TypeConverter = New ExpandableObjectConverter
                AdvPropertyGrid1.PropertySettings.Add(propset)
            Next

            'Set Property Display Names
            Dim dic As New Dictionary(Of String, String) From {
                {"BehaviorAddress", "Behavior Address"},
                {"ModelAddress", "Model Address"},
                {"ObjectCombo.ModelID", "Model ID"}
            }
            For Each kvp In dic
                Dim propset As New PropertySettings
                propset.PropertyName = kvp.Key
                propset.DisplayName = kvp.Value
                AdvPropertyGrid1.PropertySettings.Add(propset)
            Next

            'Hide "BehaviorAddressText" Property
            If True Then
                Dim propset As New PropertySettings
                propset.PropertyName = NameOf(BehaviorInfo.BehaviorAddressText)
                propset.Visible = False
                AdvPropertyGrid1.PropertySettings.Add(propset)
            End If

            'Add handler for Node created
            AddHandler AdvPropertyGrid1.PropertyTree.NodeMouseUp, AddressOf SetBParamValueText
            AddHandler AdvPropertyGrid1.PropertyTree.AfterNodeSelect, AddressOf SetBParamValueText
            AddHandler AdvPropertyGrid1.PropertiesLoaded, AddressOf SetNodeValueReadOnly
        End Sub

        Private Sub SetUI()
            Bar1.Visible = EnableEdit

            TabItem_Behaviors.Visible = EnableBehavs
            TabItem_ObjectCombos.Visible = EnableObjCombos

            Select Case True
                Case EnableObjCombos
                    TabStrip1.SelectedTab = TabItem_ObjectCombos
                Case EnableBehavs
                    TabStrip1.SelectedTab = TabItem_Behaviors
            End Select
        End Sub

        Private Sub LoadItems()
            If CurrentItemsList.Any Then
                'List Items
                ListItems()
            Else
                'Load items
                LoadNewItems()
            End If
        End Sub

        Private Sub LoadNewItems()
            Dim itemsList As List(Of BaseItem) = CurrentItemsList

            'Create & Add Items to Item List
            'itemsList.Add(New LabelItem With {.Text = "Default Objects:", .FontBold = True, .ForeColor = Color.FromArgb(&HFF2B5DA8), .BeginGroup = False})
            For Each obj As Object In CurrentObjectList
                itemsList.Add(GetItemFrom(obj))
            Next
            'itemsList.Add(New LabelItem With {.Text = "User Defined Objects:", .FontBold = True, .ForeColor = Color.FromArgb(&HFF2B5DA8), .BeginGroup = False})
            For Each obj As Object In CurrentCustomObjectList
                itemsList.Add(GetItemFrom(obj))
            Next

            'List Items
            ListItems()
        End Sub

        Private Function GetItemFrom(obj As Object) As ButtonItem
            If TypeOf obj Is ObjectCombo Then
                Return GetItemFromObjCombo(obj)
            ElseIf TypeOf obj Is BehaviorInfo Then
                Return GetItemFromBehav(obj)
            Else
                Return Nothing
            End If
        End Function

        Private Function GetItemFromObjCombo(obj As ObjectCombo) As ButtonItem
            Return New ButtonItem With {
                .Text = GetItemTextFromObjCombo(obj),
                .Tag = obj,
                .ForeColor = If(avaiableCombos?.Contains(obj), Color.DarkGreen, Nothing)}
        End Function

        Private Function GetItemFromBehav(obj As BehaviorInfo) As ButtonItem
            Return New ButtonItem With {
                .Text = GetItemTextFromBehav(obj),
                .Tag = obj}
        End Function

        Private Function GetItemTextFrom(obj As Object) As String
            If TypeOf obj Is ObjectCombo Then
                Return GetItemTextFromObjCombo(obj)
            ElseIf TypeOf obj Is BehaviorInfo Then
                Return GetItemTextFromBehav(obj)
            Else
                Return String.Empty
            End If
        End Function

        Private Function GetItemTextFromObjCombo(obj As ObjectCombo) As String
            Return obj.Name
        End Function

        Private Function GetItemTextFromBehav(obj As BehaviorInfo) As String
            Return $"{obj.BehaviorAddressText} - {obj.Name}"
        End Function

        Private Sub ListItems()
            If ItemList.Tag Is Nothing OrElse ItemList.Tag <> CurrentItemsType Then
                ListNewItems()
            End If
        End Sub

        Private Sub ListNewItems()
            ListNewItems(String.Empty)
        End Sub

        Private Sub ListNewItems(filter As String)
            ItemList.SuspendLayout()
            filter = filter.Trim

            'Clear all items
            ItemList.Items.Clear()

            'Set current items type to list
            ItemList.Tag = CurrentItemsType

            'List Items
            If String.IsNullOrEmpty(filter) Then
                'List all Items
                ItemList.Items.AddRange(CurrentItemsList.ToArray)
            Else
                'Get Filter
                Dim filters As String() = GetFiltersFromFilter(filter, " "c)

                'Filter & List Items
                For Each btn As BaseItem In CurrentItemsList
                    Dim allowAdd As Boolean = False

                    If TypeOf btn Is ButtonItem AndAlso btn.Tag IsNot Nothing Then
                        'Check if Item equals Filter
                        For Each f As String In filters
                            If Not allowAdd AndAlso EqualsFilterIn(filter, btn.Tag) Then
                                allowAdd = True
                            End If
                        Next
                    ElseIf TypeOf btn Is LabelItem Then
                        'Label Items that defines the groups are allowed
                        allowAdd = True
                    End If

                    'Add Item
                    If allowAdd Then
                        ItemList.Items.Add(btn)
                    End If
                Next
            End If

            'Select first Item
            If ItemList.Items.Count > 0 Then _
                ItemList.SelectedIndex = 0

            'Reset Modified-Flag for Search Box
            TextBoxX_Search.Modified = False

            ItemList.ResumeLayout()
            ItemList.Refresh()
            ItemList.RecalcLayout()
        End Sub

        Private Function EqualsFilterIn(filter As String, obj As Object) As Boolean
            If TypeOf obj Is ObjectCombo Then
                Return EqualsFilterInObjectCombo(filter, obj)
            ElseIf TypeOf obj Is BehaviorInfo Then
                Return EqualsFilterInBehaviorInfo(filter, obj)
            Else
                Return False
            End If
        End Function

        Private Function EqualsFilterInObjectCombo(filter As String, obj As ObjectCombo) As Boolean
            Return obj.Name.ToLower.Contains(filter) OrElse TextFromValue(obj.BehaviorAddress).ToLower.Contains(filter) OrElse TextFromValue(obj.ModelAddress).ToLower.Contains(filter)
        End Function

        Private Function EqualsFilterInBehaviorInfo(filter As String, obj As BehaviorInfo) As Boolean
            Return obj.Name.ToLower.Contains(filter) OrElse TextFromValue(obj.BehaviorAddress).ToLower.Contains(filter)
        End Function

        Private Sub AddNewItem()
            'Create Object Combo
            Dim objCombo As Object = Nothing
            Select Case CurrentItemsType
                Case ItemsType.ObjCombos
                    objCombo = New ObjectCombo
                Case ItemsType.Behavs
                    objCombo = New BehaviorInfo
            End Select

            'Add new Object Combo
            CurrentCustomObjectList.Add(objCombo)

            'Create new Item
            Dim item As BaseItem = GetItemFrom(objCombo)

            'Add new Item
            CurrentItemsList.Add(item)
            ItemList.SuspendLayout()
            ItemList.Items.Add(item)
            ItemList.SelectedItem = item
            ItemList.ResumeLayout()
            ItemList.Refresh()
            ItemList.EnsureVisible(item)
        End Sub

        Private Sub RemoveItem()
            Dim item As BaseItem = ItemList.SelectedItem
            Dim objCombo As Object
            Dim index As Integer

            If item IsNot Nothing Then
                objCombo = item.Tag
                index = ItemList.SelectedIndex

                'Remove Item
                ItemList.Items.Remove(item)
                ItemList.ResumeLayout()
                ItemList.Refresh()
                CurrentItemsList.Remove(item)

                'Remove Object Combo
                CurrentCustomObjectList.Remove(objCombo)

                'Select other item in list
                SelectItemAt(index)

                ItemList.Refresh()
            End If
        End Sub

        Private Sub ShowItemProperties()
            Dim selItem As BaseItem = ItemList.SelectedItem
            AdvPropertyGrid1.SelectedObject = selItem?.Tag
            ButtonItem_Remove.Enabled = selItem?.Tag IsNot Nothing AndAlso CurrentCustomObjectList.Contains(selItem.Tag)
        End Sub

        Private Sub UpdateItemText(btn As BaseItem)
            btn.Text = GetItemTextFrom(btn.Tag)
            ItemList.Refresh()
        End Sub

        'F O R M   C O N T R O L S

        Private Sub SelectItemAt(index As Integer)
            Do While ItemList.Items.Count <= index AndAlso index > -1
                index -= 1
            Loop
            If index > -1 Then
                ItemList.SelectedItem = ItemList.Items(index)
                ItemList.EnsureVisible(ItemList.SelectedItem)
            End If
        End Sub

        Private Sub SetBParamValueText()
            For i As Integer = 1 To 4
                Dim n As PropertyNode = AdvPropertyGrid1.GetPropertyNode("BParam" & i)
                If n IsNot Nothing Then
                    If n.Cells.Count >= 2 Then
                        n.Cells(1).TextMarkupEnabled = True
                        n.Cells(1).Text = "<i>(Expand...)</i>"
                    End If
                End If
            Next
        End Sub

        Private Sub SetNodeValueReadOnly(sender As Object, e As EventArgs)
            If Not EnableEdit Then
                For Each n As Node In AdvPropertyGrid1.PropertyTree.Nodes(0).Nodes
                    If TypeOf n Is PropertyNode Then
                        Dim prop As PropertyNode = n
                        prop.IsReadOnly = True
                    End If
                Next
            End If
        End Sub

        Private Sub ItemListBox1_ItemDoubleClick(sender As Object, e As MouseEventArgs) Handles ItemList.ItemDoubleClick
            If Not EnableEdit Then
                DialogResult = DialogResult.OK
            End If
        End Sub

        Private Sub ItemList_SelectedItemChanged(sender As Object, e As EventArgs) Handles ItemList.SelectedItemChanged
            ShowItemProperties()
        End Sub

        Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem_Add.Click
            AddNewItem()
        End Sub

        Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem_Remove.Click
            RemoveItem()
        End Sub

        Private Sub TextBoxX_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX_Search.KeyDown
            If e.KeyCode = Keys.Enter AndAlso TextBoxX_Search.Modified Then
                ListNewItems(TextBoxX_Search.Text)
            End If
        End Sub

        Private Sub ButtonX_CancelSearch_Click(sender As Object, e As EventArgs) Handles ButtonX_CancelSearch.Click
            Dim wasEmpty As Boolean = String.IsNullOrEmpty(TextBoxX_Search.Text.Trim)
            TextBoxX_Search.Text = String.Empty
            If Not wasEmpty Then ListNewItems()
        End Sub

        Private Sub TabStrip1_SelectedTabChanged(sender As Object, e As TabStripTabChangedEventArgs) Handles TabStrip1.SelectedTabChanged
            Text = e.NewTab.Text
            TextBoxX_Search.Text = String.Empty
            TextBoxX_Search.Modified = False
            LoadItems()
        End Sub

        Private Sub AdvPropertyGrid1_ConvertPropertyValueToString(sender As Object, e As ConvertValueEventArgs) Handles AdvPropertyGrid1.ConvertPropertyValueToString
            Select Case e.PropertyDescriptor.PropertyType
                Case GetType(System.Byte), GetType(SByte), GetType(Int16), GetType(UInt16), GetType(Int32), GetType(UInt32)
                    e.StringValue = TextFromValue(e.TypedValue)
                    e.IsConverted = True
            End Select
        End Sub

        Private Sub AdvPropertyGrid1_ConvertFromStringToPropertyValue(sender As Object, e As ConvertValueEventArgs) Handles AdvPropertyGrid1.ConvertFromStringToPropertyValue
            Select Case e.PropertyDescriptor.PropertyType
                Case GetType(System.Byte)
                    e.TypedValue = CByte(ValueFromText(e.StringValue.Trim))
                    e.IsConverted = True
                Case GetType(System.SByte)
                    e.TypedValue = CSByte(ValueFromText(e.StringValue.Trim))
                    e.IsConverted = True
                Case GetType(Int16)
                    e.TypedValue = CShort(ValueFromText(e.StringValue.Trim))
                    e.IsConverted = True
                Case GetType(UInt16)
                    e.TypedValue = CUShort(ValueFromText(e.StringValue.Trim))
                    e.IsConverted = True
                Case GetType(Int32)
                    e.TypedValue = CInt(ValueFromText(e.StringValue.Trim))
                    e.IsConverted = True
                Case GetType(UInt32)
                    e.TypedValue = CUInt(ValueFromText(e.StringValue.Trim))
                    e.IsConverted = True
                Case GetType(System.Single)
                    e.TypedValue = CSng(e.StringValue.Trim)
                    e.IsConverted = True
                Case GetType(System.Double)
                    e.TypedValue = CDbl(e.StringValue.Trim)
                    e.IsConverted = True
                Case GetType(System.Decimal)
                    e.TypedValue = CDec(e.StringValue.Trim)
                    e.IsConverted = True
            End Select
        End Sub

        Private Sub AdvPropertyGrid1_PropertyValueChanged(sender As Object, e As PropertyChangedEventArgs) Handles AdvPropertyGrid1.PropertyValueChanged
            If e.PropertyName = "Name" Then
                Dim selItem As BaseItem = ItemList.SelectedItem
                If TypeOf selItem Is ButtonItem AndAlso selItem.Tag IsNot Nothing Then
                    UpdateItemText(selItem)
                End If
            End If
        End Sub

        Private Sub ButtonItem_SaveAll_Click(sender As Object, e As EventArgs) Handles ButtonItem_SaveAll.Click
            SaveObjectCombos()
            SaveBehaviorInfos()
        End Sub

        Private Sub ButtonItem_ReloadList_Click(sender As Object, e As EventArgs) Handles ButtonItem_ReloadList.Click
            Select Case CurrentItemsType
                Case ItemsType.ObjCombos
                    LoadObjectCombos()
                    LoadNewItems()
                Case ItemsType.Behavs
                    LoadBehaviorInfos()
                    LoadNewItems()
            End Select
        End Sub

        Private Sub AdvPropertyGrid1_PropertiesLoaded(sender As Object, e As EventArgs) Handles AdvPropertyGrid1.PropertiesLoaded, AdvPropertyGrid1.PropertyChanged, AdvPropertyGrid1.PropertyValueChanged, AdvPropertyGrid1.ValidatePropertyValue
            SetBParamValueText()
        End Sub

    End Class

End Namespace
