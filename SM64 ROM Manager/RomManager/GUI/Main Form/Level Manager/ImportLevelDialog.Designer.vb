<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportLevelDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportLevelDialog))
        Me.ButtonX_Import = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX_Romfile = New DevComponents.DotNetBar.LabelX()
        Me.ItemListBox_Levels = New SM64_ROM_Manager.Publics.Controls.ItemListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ItemPanel_Areas = New DevComponents.DotNetBar.ItemPanel()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.ItemListBox_Levels.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX_Import
        '
        Me.ButtonX_Import.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX_Import.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX_Import.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonX_Import.Enabled = False
        Me.ButtonX_Import.FocusCuesEnabled = False
        Me.ButtonX_Import.Location = New System.Drawing.Point(271, 3)
        Me.ButtonX_Import.Name = "ButtonX_Import"
        Me.ButtonX_Import.Size = New System.Drawing.Size(110, 23)
        Me.ButtonX_Import.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX_Import.TabIndex = 2
        Me.ButtonX_Import.Text = "Import"
        '
        'LabelX_Romfile
        '
        '
        '
        '
        Me.LabelX_Romfile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX_Romfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX_Romfile.Location = New System.Drawing.Point(3, 3)
        Me.LabelX_Romfile.Name = "LabelX_Romfile"
        Me.LabelX_Romfile.Size = New System.Drawing.Size(262, 23)
        Me.LabelX_Romfile.TabIndex = 3
        Me.LabelX_Romfile.Text = "Please open a ROM file!"
        '
        'ItemListBox_Levels
        '
        Me.ItemListBox_Levels.AutoScroll = True
        '
        '
        '
        Me.ItemListBox_Levels.BackgroundStyle.Class = "ItemPanel"
        Me.ItemListBox_Levels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemListBox_Levels.ContainerControlProcessDialogKey = True
        Me.ItemListBox_Levels.Controls.Add(Me.CircularProgress1)
        Me.ItemListBox_Levels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemListBox_Levels.DragDropSupport = True
        Me.ItemListBox_Levels.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemListBox_Levels.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ItemListBox_Levels.Location = New System.Drawing.Point(3, 32)
        Me.ItemListBox_Levels.Name = "ItemListBox_Levels"
        Me.ItemListBox_Levels.ReserveLeftSpace = False
        Me.ItemListBox_Levels.Size = New System.Drawing.Size(262, 226)
        Me.ItemListBox_Levels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ItemListBox_Levels.TabIndex = 1
        Me.ItemListBox_Levels.Text = "ItemListBox1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX_Import, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX_Romfile, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ItemListBox_Levels, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ItemPanel_Areas, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 261)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'ItemPanel_Areas
        '
        Me.ItemPanel_Areas.AutoScroll = True
        '
        '
        '
        Me.ItemPanel_Areas.BackgroundStyle.Class = "ItemPanel"
        Me.ItemPanel_Areas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanel_Areas.ContainerControlProcessDialogKey = True
        Me.ItemPanel_Areas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemPanel_Areas.DragDropSupport = True
        Me.ItemPanel_Areas.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemPanel_Areas.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ItemPanel_Areas.Location = New System.Drawing.Point(271, 32)
        Me.ItemPanel_Areas.Name = "ItemPanel_Areas"
        Me.ItemPanel_Areas.ReserveLeftSpace = False
        Me.ItemPanel_Areas.Size = New System.Drawing.Size(110, 226)
        Me.ItemPanel_Areas.TabIndex = 4
        Me.ItemPanel_Areas.Text = "ItemPanel1"
        '
        'CircularProgress1
        '
        Me.CircularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CircularProgress1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(94, 76)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress1.SetVisibleStateOnStart = True
        Me.CircularProgress1.SetVisibleStateOnStop = True
        Me.CircularProgress1.Size = New System.Drawing.Size(75, 75)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 9
        '
        'ImportLevelDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ImportLevelDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Levels"
        Me.TopLeftCornerSize = 0
        Me.TopRightCornerSize = 0
        Me.ItemListBox_Levels.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemListBox_Levels As Publics.Controls.ItemListBox
    Friend WithEvents ButtonX_Import As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX_Romfile As DevComponents.DotNetBar.LabelX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ItemPanel_Areas As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
End Class
