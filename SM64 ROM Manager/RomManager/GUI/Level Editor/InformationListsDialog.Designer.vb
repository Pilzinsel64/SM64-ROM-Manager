Namespace LevelEditor

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class InformationListDialog
        Inherits DevComponents.DotNetBar.OfficeForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformationListDialog))
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.ButtonX_CancelSearch = New DevComponents.DotNetBar.ButtonX()
            Me.ItemList = New SM64_ROM_Manager.Publics.Controls.ItemListBox()
            Me.TextBoxX_Search = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.AdvPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.TabStrip1 = New DevComponents.DotNetBar.TabStrip()
            Me.TabItem_ObjectCombos = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.TabItem_Behaviors = New DevComponents.DotNetBar.TabItem(Me.components)
            Me.Bar1 = New DevComponents.DotNetBar.Bar()
            Me.ButtonItem_Add = New DevComponents.DotNetBar.ButtonItem()
            Me.ButtonItem_Remove = New DevComponents.DotNetBar.ButtonItem()
            Me.ButtonItem_SaveAll = New DevComponents.DotNetBar.ButtonItem()
            Me.ButtonItem_ReloadList = New DevComponents.DotNetBar.ButtonItem()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'SplitContainer1
            '
            resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonX_CancelSearch)
            Me.SplitContainer1.Panel1.Controls.Add(Me.ItemList)
            Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxX_Search)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.AdvPropertyGrid1)
            '
            'ButtonX_CancelSearch
            '
            Me.ButtonX_CancelSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            resources.ApplyResources(Me.ButtonX_CancelSearch, "ButtonX_CancelSearch")
            Me.ButtonX_CancelSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
            Me.ButtonX_CancelSearch.FocusCuesEnabled = False
            Me.ButtonX_CancelSearch.Name = "ButtonX_CancelSearch"
            Me.ButtonX_CancelSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX_CancelSearch.Symbol = "57676"
            Me.ButtonX_CancelSearch.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
            Me.ButtonX_CancelSearch.SymbolSize = 12.0!
            '
            'ItemList
            '
            resources.ApplyResources(Me.ItemList, "ItemList")
            '
            '
            '
            Me.ItemList.BackgroundStyle.Class = "ItemPanel"
            Me.ItemList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ItemList.ContainerControlProcessDialogKey = True
            Me.ItemList.DragDropSupport = True
            Me.ItemList.FitButtonsToContainerWidth = True
            Me.ItemList.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.ItemList.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.ItemList.Name = "ItemList"
            Me.ItemList.ReserveLeftSpace = False
            Me.ItemList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            '
            'TextBoxX_Search
            '
            Me.TextBoxX_Search.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.TextBoxX_Search.Border.Class = "TextBoxBorder"
            Me.TextBoxX_Search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.TextBoxX_Search.DisabledBackColor = System.Drawing.Color.White
            resources.ApplyResources(Me.TextBoxX_Search, "TextBoxX_Search")
            Me.TextBoxX_Search.ForeColor = System.Drawing.Color.Black
            Me.TextBoxX_Search.Name = "TextBoxX_Search"
            Me.TextBoxX_Search.PreventEnterBeep = True
            Me.TextBoxX_Search.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
            '
            'AdvPropertyGrid1
            '
            resources.ApplyResources(Me.AdvPropertyGrid1, "AdvPropertyGrid1")
            Me.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke
            Me.AdvPropertyGrid1.Name = "AdvPropertyGrid1"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.SplitContainer1)
            Me.Panel1.Controls.Add(Me.TabStrip1)
            Me.Panel1.Controls.Add(Me.Bar1)
            resources.ApplyResources(Me.Panel1, "Panel1")
            Me.Panel1.Name = "Panel1"
            '
            'TabStrip1
            '
            Me.TabStrip1.AutoSelectAttachedControl = True
            Me.TabStrip1.CanReorderTabs = True
            Me.TabStrip1.CloseButtonVisible = True
            Me.TabStrip1.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.TabStrip1, "TabStrip1")
            Me.TabStrip1.ForeColor = System.Drawing.Color.Black
            Me.TabStrip1.Name = "TabStrip1"
            Me.TabStrip1.SelectedTab = Me.TabItem_ObjectCombos
            Me.TabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
            Me.TabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
            Me.TabStrip1.Tabs.Add(Me.TabItem_ObjectCombos)
            Me.TabStrip1.Tabs.Add(Me.TabItem_Behaviors)
            '
            'TabItem_ObjectCombos
            '
            Me.TabItem_ObjectCombos.Name = "TabItem_ObjectCombos"
            resources.ApplyResources(Me.TabItem_ObjectCombos, "TabItem_ObjectCombos")
            '
            'TabItem_Behaviors
            '
            Me.TabItem_Behaviors.Name = "TabItem_Behaviors"
            resources.ApplyResources(Me.TabItem_Behaviors, "TabItem_Behaviors")
            '
            'Bar1
            '
            Me.Bar1.AntiAlias = True
            resources.ApplyResources(Me.Bar1, "Bar1")
            Me.Bar1.DockOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
            Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
            Me.Bar1.IsMaximized = False
            Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_Add, Me.ButtonItem_Remove, Me.ButtonItem_SaveAll, Me.ButtonItem_ReloadList})
            Me.Bar1.Name = "Bar1"
            Me.Bar1.RoundCorners = False
            Me.Bar1.Stretch = True
            Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.Bar1.TabStop = False
            '
            'ButtonItem_Add
            '
            Me.ButtonItem_Add.Image = Global.SM64_ROM_Manager.My.Resources.MyOldIcons.Add_16px
            Me.ButtonItem_Add.Name = "ButtonItem_Add"
            resources.ApplyResources(Me.ButtonItem_Add, "ButtonItem_Add")
            '
            'ButtonItem_Remove
            '
            Me.ButtonItem_Remove.Image = Global.SM64_ROM_Manager.My.Resources.MyOldIcons.Remove_16px
            Me.ButtonItem_Remove.Name = "ButtonItem_Remove"
            resources.ApplyResources(Me.ButtonItem_Remove, "ButtonItem_Remove")
            '
            'ButtonItem_SaveAll
            '
            Me.ButtonItem_SaveAll.Image = Global.SM64_ROM_Manager.My.Resources.MyOldIcons.SaveAll_16px1
            Me.ButtonItem_SaveAll.ImageFixedSize = New System.Drawing.Size(16, 16)
            Me.ButtonItem_SaveAll.Name = "ButtonItem_SaveAll"
            resources.ApplyResources(Me.ButtonItem_SaveAll, "ButtonItem_SaveAll")
            '
            'ButtonItem_ReloadList
            '
            Me.ButtonItem_ReloadList.Image = Global.SM64_ROM_Manager.My.Resources.MyOldIcons.Refresh_16px
            Me.ButtonItem_ReloadList.Name = "ButtonItem_ReloadList"
            resources.ApplyResources(Me.ButtonItem_ReloadList, "ButtonItem_ReloadList")
            '
            'InformationListDialog
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Name = "InformationListDialog"
            Me.ShowIcon = False
            Me.TopLeftCornerSize = 0
            Me.TopRightCornerSize = 0
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
        Friend WithEvents ButtonItem_Add As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ButtonItem_SaveAll As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ButtonItem_Remove As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents TabStrip1 As DevComponents.DotNetBar.TabStrip
        Friend WithEvents TabItem_ObjectCombos As DevComponents.DotNetBar.TabItem
        Friend WithEvents TabItem_Behaviors As DevComponents.DotNetBar.TabItem
        Friend WithEvents Panel1 As Panel
        Friend WithEvents SplitContainer1 As SplitContainer
        Friend WithEvents ItemList As Publics.Controls.ItemListBox
        Friend WithEvents TextBoxX_Search As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents ButtonX_CancelSearch As DevComponents.DotNetBar.ButtonX
        Friend WithEvents AdvPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
        Friend WithEvents ButtonItem_ReloadList As DevComponents.DotNetBar.ButtonItem
    End Class

End Namespace
