Imports System.CodeDom.Compiler
Imports System.IO
Imports System.Windows.Forms
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports FastColoredTextBoxNS
Imports SM64Lib

Public Class TweakScriptEditor

    'F i e l d s

    Private WithEvents CodeEditor As FastColoredTextBox
    Private script As PatchScript
    Private tempScript As New PatchScript
    Private rommgr As RomManager
    Private ntsScript As Boolean = False
    Private ntsDescription As Boolean = False
    Private ntsName As Boolean = False
    Private ntsType As Boolean = False
    Private ntsReferences As Boolean = False
    Private runInTestMode As Boolean = True

    'P r o p e r t i e s

    Public ReadOnly Property NeedToSave As Boolean
        Get
            Return ntsScript OrElse ntsDescription OrElse ntsName OrElse ntsType OrElse ntsReferences
        End Get
    End Property

    'C o n s t r u c t o r s

    Public Sub New(script As PatchScript, rommgr As RomManager)
        Me.rommgr = rommgr
        Me.script = script

        'Create Temp Script
        CopyScript(script, tempScript)

        Me.SuspendLayout()

        InitializeComponent()

        CodeEditor = New FastColoredTextBox
        CodeEditor.Language = Language.Custom
        CodeEditor.Dock = DockStyle.Fill
        CodeEditor.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(CodeEditor)

        UpdateAmbientColors
        Me.ResumeLayout(False)
    End Sub

    'F e a t u r e s

    Private Sub CopyScript(source As PatchScript, dest As PatchScript)
        dest.Description = source.Description
        dest.Name = source.Name
        dest.Script = source.Script
        dest.Type = source.Type

        dest.References.Clear()
        For Each ref As String In source.References
            dest.References.Add(ref)
        Next
    End Sub

    Private Sub ChangeCurScriptType(lang As Language, typ As ScriptType)
        CodeEditor.Language = lang
        tempScript.Type = typ
        ntsType = True
    End Sub

    Private Sub LoadReferences()
        For Each ref As String In tempScript.References
            ItemListBox1.Items.Add(New ButtonItem With {.Text = ref})
            ntsReferences = True
        Next

        ItemListBox1.Refresh()
    End Sub

    Private Sub AddReference(txt As String)
        If Not String.IsNullOrEmpty(txt) Then
            tempScript.References.Add(txt)
            ItemListBox1.Items.Add(New ButtonItem With {.Text = txt})
        End If
    End Sub

    Private Sub RemoveReference(index As Integer)
        If index > -1 Then
            ItemListBox1.Items.RemoveAt(index)
            tempScript.References.RemoveAt(index)
            ntsReferences = True
        End If
    End Sub

    Private Sub LoadAllData()
        TextBoxX_ScriptName.Text = tempScript.Name
        TextBoxX_ScriptDescription.Text = tempScript.Description

        Select Case tempScript.Type
            Case ScriptType.TweakScript
                CheckBoxX_TweakScript.Checked = True
            Case ScriptType.VisualBasic
                CheckBoxX_VBScript.Checked = True
            Case ScriptType.CSharp
                CheckBoxX_CSharpScript.Checked = True
            Case ScriptType.Armips
                CheckBoxX_ArmipsScript.Checked = True
        End Select

        CodeEditor.Text = tempScript.Script

        ntsScript = False
        ntsName = False
        ntsDescription = False
        ntsType = False

        LoadReferences()
    End Sub

    Private Sub SaveAllData()
        SaveTempScript()
        CopyScript(tempScript, script)
    End Sub

    Private Sub SaveTempScript()
        tempScript.Name = TextBoxX_ScriptName.Text.Trim
        tempScript.Description = TextBoxX_ScriptDescription.Text
        tempScript.Script = CodeEditor.Text
    End Sub

    Private Sub LoadDefaultScript(typ As ScriptType)
        Select Case typ
            Case ScriptType.CSharp
                CheckBoxX_CSharpScript.Checked = True
                CodeEditor.Text =
                   "using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SM64Lib;

class Script
{

    static void Main(IReadOnlyDictionary<string, object> pars)
    {
        
    }

}
"
            Case ScriptType.VisualBasic
                CheckBoxX_VBScript.Checked = True
                CodeEditor.Text =
                   "Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports SM64Lib

Module Script

    Sub Main(params as IReadOnlyDictionary(Of String, Object))
        
    End Sub

End Module
"
        End Select
    End Sub

    Private Sub SaveToFile()
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Textfile (*.txt)|*.txt|VB code file (*.vb)|*.vb|C# code file(*.cs)|*.cs|ASM files (*.asm)|*.asm"

        Select Case True
            Case CheckBoxX_TweakScript.Checked
                sfd.FilterIndex = 1
            Case CheckBoxX_VBScript.Checked
                sfd.FilterIndex = 2
            Case CheckBoxX_CSharpScript.Checked
                sfd.FilterIndex = 3
            Case CheckBoxX_ArmipsScript.Checked
                sfd.FilterIndex = 4
        End Select

        If sfd.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllText(sfd.FileName, CodeEditor.Text)
        End If
    End Sub

    Private Sub LoadFromFile()
        Dim ofd As New OpenFileDialog
        ofd.Filter = "All supported files (*.txt, *.vb, *.cs)|*.txt;*.vb;*.cs|Text File (*.txt)|*.txt|VB code file (*.vb)|*.vb|C# Code File(*.cs)|*.cs"

        If ofd.ShowDialog = DialogResult.OK Then
            Select Case IO.Path.GetExtension(ofd.FileName).ToLower
                Case ".vb"
                    CheckBoxX_VBScript.Checked = True
                Case ".cs"
                    CheckBoxX_CSharpScript.Checked = True
                Case ".asm"
                    CheckBoxX_ArmipsScript.Checked = True
                Case Else
                    CheckBoxX_TweakScript.Checked = True
            End Select

            CodeEditor.Text = IO.File.ReadAllText(ofd.FileName)
        End If
    End Sub

    Private Sub TestScript()
        Dim mgr As New PatchingManager
        Dim res As CompilerResults = mgr.CompileScript(tempScript)

        Dim msg As String = ""
        Dim icon As eTaskDialogIcon
        Dim title As String

        If res.Errors.HasErrors Then
            title = "Script contains errors"
            icon = eTaskDialogIcon.Delete
        Else
            title = "Script is OK"
            If res.Errors.HasWarnings Then
                icon = eTaskDialogIcon.Exclamation
            Else
                icon = eTaskDialogIcon.Information
            End If
        End If

        For Each er As CompilerError In res.Errors
            If msg <> "" Then
                msg &= vbNewLine & vbNewLine
            End If

            If er.IsWarning Then
                msg &= "WARNING"
            Else
                msg &= "ERROR"
            End If

            msg &= " Code: " & er.ErrorNumber
            msg &= " Line: " & er.Line
            msg &= vbNewLine & er.ErrorText
        Next

        TaskDialog.Show("Compiler Result", icon, title, msg, eTaskDialogButton.Ok)
    End Sub

    Private Sub RunScript()
        Dim myRommgr As RomManager

        If runInTestMode Then
            'Use copy of cur rom file
            Dim copyFile As String = Path.Combine(Path.GetDirectoryName(rommgr.RomFile), Path.GetFileNameWithoutExtension(rommgr.RomFile) & ".temp" & Path.GetExtension(rommgr.RomFile))
            File.Copy(rommgr.RomFile, copyFile, True)
            myRommgr = New RomManager(copyFile)
        Else
            'Use current rom file
            myRommgr = rommgr
        End If

        'Save temp script
        SaveTempScript()

        'Patch
        TweakViewer.PatchScript(Me, tempScript, Nothing, myRommgr)
    End Sub

    'G u i

    Private Sub TweakScriptEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllData()
    End Sub

    Private Sub CheckBoxX_ScriptChange_CheckedChanged(sender As CheckBoxX, e As EventArgs) Handles CheckBoxX_TweakScript.CheckedChanged, CheckBoxX_CSharpScript.CheckedChanged, CheckBoxX_VBScript.CheckedChanged, CheckBoxX_ArmipsScript.CheckedChanged
        If sender.Checked AndAlso CodeEditor IsNot Nothing Then
            If sender Is CheckBoxX_TweakScript Then
                ChangeCurScriptType(Language.Custom, ScriptType.TweakScript)
            ElseIf sender Is CheckBoxX_CSharpScript Then
                ChangeCurScriptType(Language.CSharp, ScriptType.CSharp)
            ElseIf sender Is CheckBoxX_VBScript Then
                ChangeCurScriptType(Language.VB, ScriptType.VisualBasic)
            ElseIf sender Is CheckBoxX_ArmipsScript Then
                ChangeCurScriptType(Language.Custom, ScriptType.Armips)
            End If
        End If

        Dim isDotNet As Boolean = CheckBoxX_CSharpScript.Checked OrElse CheckBoxX_VBScript.Checked
        LayoutControlItem4.Visible = isDotNet
        ButtonItem_CheckForErrors.Enabled = isDotNet
    End Sub

    Private Sub TweakScriptEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not {CloseReason.ApplicationExitCall, CloseReason.WindowsShutDown, CloseReason.TaskManagerClosing}.Contains(e.CloseReason) Then
            Select Case MessageBoxEx.Show("Do you want to save your changes?", "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    SaveAllData()
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Dim txt As String = TextBoxX_ReferenceName.Text.Trim
        AddReference(txt)
        ItemListBox1.Refresh()
    End Sub

    Private Sub ItemListBox1_SelectedItemChanged(sender As Object, e As EventArgs) Handles ItemListBox1.SelectedItemChanged
        Dim btnItem As ButtonItem = ItemListBox1.SelectedItem

        If btnItem IsNot Nothing Then
            TextBoxX_ReferenceName.Text = btnItem.Text
        End If
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Dim selIndex As Integer = ItemListBox1.SelectedIndex
        RemoveReference(selIndex)
        ItemListBox1.Refresh()
    End Sub

    Private Sub ButtonItem7_Click(sender As Object, e As EventArgs)
        If TypeOf sender.Parent.Tag Is FastColoredTextBox Then
            sender.Parent.Tag.Redo()
        End If
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        LoadDefaultScript(ScriptType.VisualBasic)
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        LoadDefaultScript(ScriptType.CSharp)
    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem_SaveToFile.Click
        SaveToFile()
    End Sub

    Private Sub ButtonItem4_Click(sender As Object, e As EventArgs) Handles ButtonItem_LoadFromFile.Click
        LoadFromFile()
    End Sub

    Private Sub ButtonX5_Click(sender As Object, e As EventArgs) Handles ButtonItem_CheckForErrors.Click
        SaveAllData()
        TestScript()
    End Sub

    Private Sub AnyTextChanged(sender As Object, e As EventArgs) Handles TextBoxX_ScriptName.TextChanged, TextBoxX_ScriptDescription.TextChanged, CodeEditor.TextChanged
        ntsName = True
    End Sub

    Private Sub ButtonItem_RunInTestMode_CheckedChanged(sender As ButtonItem, e As EventArgs) Handles ButtonItem_RunInTestMode.CheckedChanged
        runInTestMode = sender.Checked
    End Sub

    Private Sub ButtonX_RunScript_Click(sender As Object, e As EventArgs)
        RunScript()
    End Sub

    Private Sub ButtonX_ShowObjectCatalog_Click(sender As Object, e As EventArgs) Handles ButtonItem_ShowObjectCatalog.Click, ButtonItem_ShowObjectCatalog.Click
        Static frm As ObjectCatalog
        If frm Is Nothing Then
            frm = New ObjectCatalog
            AddHandler frm.FormClosing, Sub() frm = Nothing
        End If
        frm.Show()
    End Sub

End Class
