Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TweakScriptEditor
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TweakScriptEditor))
        Me.TextBoxX_ScriptDescription = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX_ScriptName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CheckBoxX_TweakScript = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxX_CSharpScript = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX_VBScript = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ItemListBox1 = New SM64_ROM_Manager.Publics.Controls.ItemListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_ReferenceName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LayoutControl1 = New DevComponents.DotNetBar.Layout.LayoutControl()
        Me.LayoutControlItem1 = New DevComponents.DotNetBar.Layout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevComponents.DotNetBar.Layout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevComponents.DotNetBar.Layout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevComponents.DotNetBar.Layout.LayoutControlItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_NewTemplate = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_SaveToFile = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_LoadFromFile = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_RunInTestMode = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_CheckForErrors = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_ShowObjectCatalog = New DevComponents.DotNetBar.ButtonItem()
        Me.CheckBoxX_ArmipsScript = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.LayoutControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxX_ScriptDescription
        '
        Me.TextBoxX_ScriptDescription.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_ScriptDescription.Border.Class = "TextBoxBorder"
        Me.TextBoxX_ScriptDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_ScriptDescription.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_ScriptDescription.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.TextBoxX_ScriptDescription, "TextBoxX_ScriptDescription")
        Me.TextBoxX_ScriptDescription.Name = "TextBoxX_ScriptDescription"
        Me.TextBoxX_ScriptDescription.PreventEnterBeep = True
        '
        'TextBoxX_ScriptName
        '
        Me.TextBoxX_ScriptName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_ScriptName.Border.Class = "TextBoxBorder"
        Me.TextBoxX_ScriptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_ScriptName.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_ScriptName.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.TextBoxX_ScriptName, "TextBoxX_ScriptName")
        Me.TextBoxX_ScriptName.Name = "TextBoxX_ScriptName"
        Me.TextBoxX_ScriptName.PreventEnterBeep = True
        '
        'CheckBoxX_TweakScript
        '
        '
        '
        '
        Me.CheckBoxX_TweakScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX_TweakScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX_TweakScript.Checked = True
        Me.CheckBoxX_TweakScript.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxX_TweakScript.CheckValue = "Y"
        Me.CheckBoxX_TweakScript.FocusCuesEnabled = False
        resources.ApplyResources(Me.CheckBoxX_TweakScript, "CheckBoxX_TweakScript")
        Me.CheckBoxX_TweakScript.Name = "CheckBoxX_TweakScript"
        Me.CheckBoxX_TweakScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.CheckBoxX_ArmipsScript)
        Me.Panel1.Controls.Add(Me.CheckBoxX_CSharpScript)
        Me.Panel1.Controls.Add(Me.CheckBoxX_VBScript)
        Me.Panel1.Controls.Add(Me.CheckBoxX_TweakScript)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'CheckBoxX_CSharpScript
        '
        '
        '
        '
        Me.CheckBoxX_CSharpScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX_CSharpScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX_CSharpScript.FocusCuesEnabled = False
        resources.ApplyResources(Me.CheckBoxX_CSharpScript, "CheckBoxX_CSharpScript")
        Me.CheckBoxX_CSharpScript.Name = "CheckBoxX_CSharpScript"
        Me.CheckBoxX_CSharpScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'CheckBoxX_VBScript
        '
        '
        '
        '
        Me.CheckBoxX_VBScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX_VBScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX_VBScript.FocusCuesEnabled = False
        resources.ApplyResources(Me.CheckBoxX_VBScript, "CheckBoxX_VBScript")
        Me.CheckBoxX_VBScript.Name = "CheckBoxX_VBScript"
        Me.CheckBoxX_VBScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'ItemListBox1
        '
        resources.ApplyResources(Me.ItemListBox1, "ItemListBox1")
        '
        '
        '
        Me.ItemListBox1.BackgroundStyle.Class = "ItemPanel"
        Me.ItemListBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemListBox1.ContainerControlProcessDialogKey = True
        Me.ItemListBox1.DragDropSupport = True
        Me.ItemListBox1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemListBox1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ItemListBox1.Name = "ItemListBox1"
        Me.ItemListBox1.ReserveLeftSpace = False
        Me.ItemListBox1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel3.Controls.Add(Me.ItemListBox1)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonX3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonX4, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxX_ReferenceName, 0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.FocusCuesEnabled = False
        resources.ApplyResources(Me.ButtonX3, "ButtonX3")
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = "57669"
        Me.ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX3.SymbolSize = 12.0!
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.ButtonX4, "ButtonX4")
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.FocusCuesEnabled = False
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.Symbol = "57676"
        Me.ButtonX4.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX4.SymbolSize = 12.0!
        '
        'TextBoxX_ReferenceName
        '
        resources.ApplyResources(Me.TextBoxX_ReferenceName, "TextBoxX_ReferenceName")
        Me.TextBoxX_ReferenceName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_ReferenceName.Border.Class = "TextBoxBorder"
        Me.TextBoxX_ReferenceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_ReferenceName.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_ReferenceName.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_ReferenceName.Name = "TextBoxX_ReferenceName"
        Me.TextBoxX_ReferenceName.PreventEnterBeep = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControl1.Controls.Add(Me.TextBoxX_ScriptName)
        Me.LayoutControl1.Controls.Add(Me.TextBoxX_ScriptDescription)
        Me.LayoutControl1.Controls.Add(Me.Panel1)
        Me.LayoutControl1.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.LayoutControl1, "LayoutControl1")
        Me.LayoutControl1.Name = "LayoutControl1"
        '
        '
        '
        Me.LayoutControl1.RootGroup.Items.AddRange(New DevComponents.DotNetBar.Layout.LayoutItemBase() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextBoxX_ScriptName
        Me.LayoutControlItem1.Height = 45
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(120, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        resources.ApplyResources(Me.LayoutControlItem1, "LayoutControlItem1")
        Me.LayoutControlItem1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top
        Me.LayoutControlItem1.Width = 100
        Me.LayoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextBoxX_ScriptDescription
        Me.LayoutControlItem2.Height = 200
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(120, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        resources.ApplyResources(Me.LayoutControlItem2, "LayoutControlItem2")
        Me.LayoutControlItem2.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top
        Me.LayoutControlItem2.Width = 100
        Me.LayoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Panel1
        Me.LayoutControlItem3.Height = 48
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(64, 18)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        resources.ApplyResources(Me.LayoutControlItem3, "LayoutControlItem3")
        Me.LayoutControlItem3.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top
        Me.LayoutControlItem3.Width = 100
        Me.LayoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Panel3
        Me.LayoutControlItem4.Height = 100
        Me.LayoutControlItem4.HeightType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(64, 18)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        resources.ApplyResources(Me.LayoutControlItem4, "LayoutControlItem4")
        Me.LayoutControlItem4.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top
        Me.LayoutControlItem4.Width = 100
        Me.LayoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.LayoutControl1)
        Me.Panel4.Controls.Add(Me.Panel2)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Bar1
        '
        resources.ApplyResources(Me.Bar1, "Bar1")
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar1.AntiAlias = True
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.MenuBar
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5, Me.ButtonItem4, Me.ButtonItem_ShowObjectCatalog})
        Me.Bar1.MenuBar = True
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabStop = False
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_NewTemplate, Me.ButtonItem_SaveToFile, Me.ButtonItem_LoadFromFile})
        resources.ApplyResources(Me.ButtonItem5, "ButtonItem5")
        '
        'ButtonItem_NewTemplate
        '
        Me.ButtonItem_NewTemplate.Name = "ButtonItem_NewTemplate"
        Me.ButtonItem_NewTemplate.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2})
        resources.ApplyResources(Me.ButtonItem_NewTemplate, "ButtonItem_NewTemplate")
        '
        'ButtonItem1
        '
        Me.ButtonItem1.GlobalItem = False
        Me.ButtonItem1.Name = "ButtonItem1"
        resources.ApplyResources(Me.ButtonItem1, "ButtonItem1")
        '
        'ButtonItem2
        '
        Me.ButtonItem2.GlobalItem = False
        Me.ButtonItem2.Name = "ButtonItem2"
        resources.ApplyResources(Me.ButtonItem2, "ButtonItem2")
        '
        'ButtonItem_SaveToFile
        '
        Me.ButtonItem_SaveToFile.BeginGroup = True
        Me.ButtonItem_SaveToFile.GlobalItem = False
        Me.ButtonItem_SaveToFile.Image = Global.SM64_ROM_Manager.PatchScripts.MyIcons.icons8_save_16px_1
        Me.ButtonItem_SaveToFile.Name = "ButtonItem_SaveToFile"
        resources.ApplyResources(Me.ButtonItem_SaveToFile, "ButtonItem_SaveToFile")
        '
        'ButtonItem_LoadFromFile
        '
        Me.ButtonItem_LoadFromFile.GlobalItem = False
        Me.ButtonItem_LoadFromFile.Image = Global.SM64_ROM_Manager.PatchScripts.MyIcons.icons8_open_folder_16px_1
        Me.ButtonItem_LoadFromFile.Name = "ButtonItem_LoadFromFile"
        resources.ApplyResources(Me.ButtonItem_LoadFromFile, "ButtonItem_LoadFromFile")
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3, Me.ButtonItem_RunInTestMode, Me.ButtonItem_CheckForErrors})
        resources.ApplyResources(Me.ButtonItem4, "ButtonItem4")
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Image = Global.SM64_ROM_Manager.PatchScripts.MyIcons.icons8_play_16px
        Me.ButtonItem3.Name = "ButtonItem3"
        resources.ApplyResources(Me.ButtonItem3, "ButtonItem3")
        '
        'ButtonItem_RunInTestMode
        '
        Me.ButtonItem_RunInTestMode.AutoCheckOnClick = True
        Me.ButtonItem_RunInTestMode.Checked = True
        Me.ButtonItem_RunInTestMode.GlobalItem = False
        Me.ButtonItem_RunInTestMode.Name = "ButtonItem_RunInTestMode"
        resources.ApplyResources(Me.ButtonItem_RunInTestMode, "ButtonItem_RunInTestMode")
        '
        'ButtonItem_CheckForErrors
        '
        Me.ButtonItem_CheckForErrors.BeginGroup = True
        Me.ButtonItem_CheckForErrors.Name = "ButtonItem_CheckForErrors"
        resources.ApplyResources(Me.ButtonItem_CheckForErrors, "ButtonItem_CheckForErrors")
        '
        'ButtonItem_ShowObjectCatalog
        '
        Me.ButtonItem_ShowObjectCatalog.Name = "ButtonItem_ShowObjectCatalog"
        resources.ApplyResources(Me.ButtonItem_ShowObjectCatalog, "ButtonItem_ShowObjectCatalog")
        '
        'CheckBoxX_ArmipsScript
        '
        '
        '
        '
        Me.CheckBoxX_ArmipsScript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX_ArmipsScript.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX_ArmipsScript.FocusCuesEnabled = False
        resources.ApplyResources(Me.CheckBoxX_ArmipsScript, "CheckBoxX_ArmipsScript")
        Me.CheckBoxX_ArmipsScript.Name = "CheckBoxX_ArmipsScript"
        Me.CheckBoxX_ArmipsScript.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'TweakScriptEditor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Bar1)
        Me.Name = "TweakScriptEditor"
        Me.TopLeftCornerSize = 0
        Me.TopRightCornerSize = 0
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.LayoutControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents TextBoxX_ScriptDescription As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents TextBoxX_ScriptName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CheckBoxX_TweakScript As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxX_CSharpScript As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX_VBScript As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItemListBox1 As SM64_ROM_Manager.Publics.Controls.ItemListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBoxX_ReferenceName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LayoutControl1 As DevComponents.DotNetBar.Layout.LayoutControl
    Friend WithEvents LayoutControlItem1 As DevComponents.DotNetBar.Layout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevComponents.DotNetBar.Layout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevComponents.DotNetBar.Layout.LayoutControlItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LayoutControlItem4 As DevComponents.DotNetBar.Layout.LayoutControlItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_NewTemplate As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_SaveToFile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_LoadFromFile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_CheckForErrors As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_RunInTestMode As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_ShowObjectCatalog As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CheckBoxX_ArmipsScript As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
