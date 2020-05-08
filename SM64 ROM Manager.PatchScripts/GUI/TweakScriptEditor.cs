using System;
using global::System.CodeDom.Compiler;
using global::System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using global::System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using global::FastColoredTextBoxNS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib;
using System.Threading.Tasks;
using SM64Lib.Patching;
using Pilz.IO;

namespace SM64_ROM_Manager.PatchScripts
{
    public partial class TweakScriptEditor
    {

        // F i e l d s

        private ObjectCatalog frmObjectCatalog = null;
        private PatchScript script;
        private PatchScript tempScript = new PatchScript();
        private RomManager rommgr;
        private EmbeddedFilesContainer filesContainer;
        private bool ntsScript = false;
        private bool ntsDescription = false;
        private bool ntsName = false;
        private bool ntsType = false;
        private bool ntsReferences = false;
        private bool runInTestMode = true;

        // P r o p e r t i e s

        public bool WantToSave = false;

        public bool NeedToSave
        {
            get
            {
                return ntsScript || ntsDescription || ntsName || ntsType || ntsReferences;
            }
        }

        private FastColoredTextBox _CodeEditor;
        private FastColoredTextBox CodeEditor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CodeEditor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CodeEditor != null)
                {
                    _CodeEditor.TextChanged -= AnyTextChanged;
                }

                _CodeEditor = value;
                if (_CodeEditor != null)
                {
                    _CodeEditor.TextChanged += AnyTextChanged;
                }
            }
        }

        // C o n s t r u c t o r s

        public TweakScriptEditor(PatchScript script, RomManager rommgr) : this(script, rommgr, null)
        {
        }

        public TweakScriptEditor(PatchScript script, RomManager rommgr, EmbeddedFilesContainer filesContainer)
        {
            this.filesContainer = filesContainer;

            // G u i
            base.Load += TweakScriptEditor_Load;
            base.FormClosing += TweakScriptEditor_FormClosing;
            this.rommgr = rommgr;
            this.script = script;

            // Create Temp Script
            CopyScript(script, tempScript);
            SuspendLayout();
            InitializeComponent();
            CodeEditor = new FastColoredTextBox();
            CodeEditor.Language = Language.Custom;
            CodeEditor.Dock = DockStyle.Fill;
            CodeEditor.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(CodeEditor);
            LayoutControlItem4.Visible = false;
            layoutControlItem5.Visible = false;
            base.UpdateAmbientColors();
            ResumeLayout(false);
        }

        // F e a t u r e s

        private void CopyScript(PatchScript source, PatchScript dest)
        {
            dest.Description = source.Description;
            dest.Name = source.Name;
            dest.Script = source.Script;
            dest.Type = source.Type;
            dest.References.Clear();
            foreach (string @ref in source.References)
                dest.References.Add(@ref);
        }

        private void ChangeCurScriptType(Language lang, ScriptType typ)
        {
            CodeEditor.Language = lang;
            tempScript.Type = typ;
            ntsType = true;
        }

        private void LoadReferences()
        {
            foreach (string @ref in tempScript.References)
            {
                ItemListBox1.Items.Add(new ButtonItem() { Text = @ref });
                ntsReferences = true;
            }

            ItemListBox1.Refresh();
        }

        private void AddReference(string txt)
        {
            if (!string.IsNullOrEmpty(txt))
            {
                tempScript.References.Add(txt);
                ItemListBox1.Items.Add(new ButtonItem() { Text = txt });
            }
        }

        private void RemoveReference(int index)
        {
            if (index > -1)
            {
                ItemListBox1.Items.RemoveAt(index);
                tempScript.References.RemoveAt(index);
                ntsReferences = true;
            }
        }

        private void LoadEmbeddedFiles()
        {
            if (filesContainer is object)
            {
                ListViewEx_EmbeddedFiles.BeginUpdate();
                ListViewEx_EmbeddedFiles.Items.Clear();

                foreach (var fileName in filesContainer.AllFileNames)
                {
                    var item =
                    ListViewEx_EmbeddedFiles.Items.Add(
                        new ListViewItem(fileName)
                        {
                            Tag = fileName
                        });
                }

                ListViewEx_EmbeddedFiles.EndUpdate();
            }
        }

        private async Task AddEmbeddedFile(string filePath)
        {
            var fileName = Path.GetFileName(filePath);

            if (!filesContainer.HasFile(fileName) || MessageBoxEx.Show(this, "The file you are adding does already exist. If you continue the existing embedded file gets overwritten. Do you want to continue?", "Overwrite embedded file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (await filesContainer.AddFileAsync(fileName, filePath))
                    LoadEmbeddedFiles();
            }
        }

        private void RemoveEmbeddedFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
                filesContainer.RemoveFile(fileName);
        }

        private string GetSelectedEmbeddedFile()
        {
            var fileName = string.Empty;

            foreach (ListViewItem item in ListViewEx_EmbeddedFiles.SelectedItems)
            {
                if (string.IsNullOrEmpty(fileName) && item.Tag is string && !string.IsNullOrEmpty((string)item.Tag))
                    fileName = (string)item.Tag;
            }

            return fileName;
        }

        private void LoadAllData()
        {
            TextBoxX_ScriptName.Text = tempScript.Name;
            TextBoxX_ScriptDescription.Text = tempScript.Description;
            var switchExpr = tempScript.Type;
            switch (switchExpr)
            {
                case ScriptType.TweakScript:
                    {
                        CheckBoxX_TweakScript.Checked = true;
                        break;
                    }

                case ScriptType.VisualBasic:
                    {
                        CheckBoxX_VBScript.Checked = true;
                        break;
                    }

                case ScriptType.CSharp:
                    {
                        CheckBoxX_CSharpScript.Checked = true;
                        break;
                    }

                case ScriptType.Armips:
                    {
                        CheckBoxX_ArmipsScript.Checked = true;
                        break;
                    }
            }

            CodeEditor.Text = tempScript.Script;
            ntsScript = false;
            ntsName = false;
            ntsDescription = false;
            ntsType = false;
            LoadReferences();
            LoadEmbeddedFiles();
        }

        private void SaveAllData()
        {
            SaveTempScript();
            CopyScript(tempScript, script);
        }

        private void SaveTempScript()
        {
            tempScript.Name = TextBoxX_ScriptName.Text.Trim();
            tempScript.Description = TextBoxX_ScriptDescription.Text;
            tempScript.Script = CodeEditor.Text;
        }

        private void LoadDefaultScript(ScriptType typ)
        {
            switch (typ)
            {
                case ScriptType.CSharp:
                    {
                        CheckBoxX_CSharpScript.Checked = true;
                        CodeEditor.Text = @"using System;
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
";
                        break;
                    }

                case ScriptType.VisualBasic:
                    {
                        CheckBoxX_VBScript.Checked = true;
                        CodeEditor.Text = @"Imports Microsoft.VisualBasic
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
";
                        break;
                    }
            }
        }

        private void SaveToFile()
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Textfile (*.txt)|*.txt|VB code file (*.vb)|*.vb|C# code file(*.cs)|*.cs|ASM files (*.asm)|*.asm";
            switch (true)
            {
                case object _ when CheckBoxX_TweakScript.Checked:
                    {
                        sfd.FilterIndex = 1;
                        break;
                    }

                case object _ when CheckBoxX_VBScript.Checked:
                    {
                        sfd.FilterIndex = 2;
                        break;
                    }

                case object _ when CheckBoxX_CSharpScript.Checked:
                    {
                        sfd.FilterIndex = 3;
                        break;
                    }

                case object _ when CheckBoxX_ArmipsScript.Checked:
                    {
                        sfd.FilterIndex = 4;
                        break;
                    }
            }

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, CodeEditor.Text);
            }
        }

        private void LoadFromFile()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "All supported files (*.txt, *.vb, *.cs)|*.txt;*.vb;*.cs|Text File (*.txt)|*.txt|VB code file (*.vb)|*.vb|C# Code File(*.cs)|*.cs";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var switchExpr = Path.GetExtension(ofd.FileName).ToLower();
                switch (switchExpr)
                {
                    case ".vb":
                        {
                            CheckBoxX_VBScript.Checked = true;
                            break;
                        }

                    case ".cs":
                        {
                            CheckBoxX_CSharpScript.Checked = true;
                            break;
                        }

                    case ".asm":
                        {
                            CheckBoxX_ArmipsScript.Checked = true;
                            break;
                        }

                    default:
                        {
                            CheckBoxX_TweakScript.Checked = true;
                            break;
                        }
                }

                CodeEditor.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void TestScript()
        {
            var mgr = new PatchingManager();
            var res = mgr.CompileScript(tempScript, Publics.General.GetAdditionalReferencedAssemblied());
            string msg = "";
            eTaskDialogIcon icon;
            string title;
            if (res.Errors.HasErrors)
            {
                title = "Script contains errors";
                icon = eTaskDialogIcon.Delete;
            }
            else
            {
                title = "Script is OK";
                if (res.Errors.HasWarnings)
                {
                    icon = eTaskDialogIcon.Exclamation;
                }
                else
                {
                    icon = eTaskDialogIcon.Information;
                }
            }

            foreach (CompilerError er in res.Errors)
            {
                if (!string.IsNullOrEmpty(msg))
                {
                    msg += Constants.vbNewLine + Constants.vbNewLine;
                }

                if (er.IsWarning)
                {
                    msg += "WARNING";
                }
                else
                {
                    msg += "ERROR";
                }

                msg += " Code: " + er.ErrorNumber;
                msg += " Line: " + Conversions.ToString(er.Line);
                msg += Constants.vbNewLine + er.ErrorText;
            }

            TaskDialog.Show("Compiler Result", icon, title, msg, eTaskDialogButton.Ok);
        }

        private void RunScript()
        {
            RomManager myRommgr;
            if (runInTestMode)
            {
                // Use copy of cur rom file
                string copyFile = Path.Combine(Path.GetDirectoryName(rommgr.RomFile), Path.GetFileNameWithoutExtension(rommgr.RomFile) + ".temp" + Path.GetExtension(rommgr.RomFile));
                File.Copy(rommgr.RomFile, copyFile, true);
                myRommgr = new RomManager(copyFile);
            }
            else
            {
                // Use current rom file
                myRommgr = rommgr;
            }

            // Save temp script
            SaveTempScript();

            // Patch
            TweakViewer.PatchScript(this, tempScript, null, myRommgr);
        }

        private void TweakScriptEditor_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void CheckBoxX_ScriptChange_CheckedChanged(object osender, EventArgs e)
        {
            var sender = osender as CheckBoxX;

            if (sender.Checked && CodeEditor is object)
            {
                if (sender == CheckBoxX_TweakScript)
                {
                    ChangeCurScriptType(Language.Custom, ScriptType.TweakScript);
                }
                else if (sender == CheckBoxX_CSharpScript)
                {
                    ChangeCurScriptType(Language.CSharp, ScriptType.CSharp);
                }
                else if (sender == CheckBoxX_VBScript)
                {
                    ChangeCurScriptType(Language.VB, ScriptType.VisualBasic);
                }
                else if (sender == CheckBoxX_ArmipsScript)
                {
                    ChangeCurScriptType(Language.Custom, ScriptType.Armips);
                }
            }

            bool isDotNet = CheckBoxX_CSharpScript.Checked || CheckBoxX_VBScript.Checked;
            LayoutControlItem4.Visible = isDotNet;
            layoutControlItem5.Visible = isDotNet && filesContainer is object;
            ButtonItem_CheckForErrors.Enabled = isDotNet;
        }

        private void TweakScriptEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!new[] { CloseReason.ApplicationExitCall, CloseReason.WindowsShutDown, CloseReason.TaskManagerClosing }.Contains(e.CloseReason))
            {
                if (NeedToSave)
                {
                    var switchExpr = MessageBoxEx.Show("Do you want to save your changes?", "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (switchExpr)
                    {
                        case DialogResult.Yes:
                            SaveAllData();
                            WantToSave = true;
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            string txt = TextBoxX_ReferenceName.Text.Trim();
            AddReference(txt);
            ItemListBox1.Refresh();
        }

        private void ItemListBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            ButtonItem btnItem = (ButtonItem)ItemListBox1.SelectedItem;
            if (btnItem is object)
            {
                TextBoxX_ReferenceName.Text = btnItem.Text;
            }
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            int selIndex = ItemListBox1.SelectedIndex;
            RemoveReference(selIndex);
            ItemListBox1.Refresh();
        }

        private void ButtonItem7_Click(object sender, EventArgs e)
        {
            var csender = sender as Control;
            if (csender.Parent.Tag is FastColoredTextBox)
            {
                ((FastColoredTextBox)csender.Parent.Tag).Redo();
            }
        }

        private void ButtonItem1_Click(object sender, EventArgs e)
        {
            LoadDefaultScript(ScriptType.VisualBasic);
        }

        private void ButtonItem2_Click(object sender, EventArgs e)
        {
            LoadDefaultScript(ScriptType.CSharp);
        }

        private void ButtonItem3_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void ButtonItem4_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void ButtonX5_Click(object sender, EventArgs e)
        {
            SaveAllData();
            TestScript();
        }

        private void AnyTextChanged(object sender, EventArgs e)
        {
            ntsName = true;
        }

        private void ButtonItem_RunInTestMode_CheckedChanged(object osender, EventArgs e)
        {
            var sender = osender as ButtonItem;
            runInTestMode = sender.Checked;
        }

        private void ButtonX_RunScript_Click(object sender, EventArgs e)
        {
            RunScript();
        }

        private void ButtonX_ShowObjectCatalog_Click(object sender, EventArgs e)
        {
            if (frmObjectCatalog is null)
            {
                frmObjectCatalog = new ObjectCatalog();
                frmObjectCatalog.FormClosing += (object ssender, FormClosingEventArgs ee) => frmObjectCatalog = null;
            }

            frmObjectCatalog.Show();
        }

        private async void ButtonX_AddEmbeddedFile_Click(object sender, EventArgs e)
        {
            var ofd_LoadEmbeddedFile = new OpenFileDialog();
            if (ofd_LoadEmbeddedFile.ShowDialog(this) == DialogResult.OK)
                await AddEmbeddedFile(ofd_LoadEmbeddedFile.FileName);
        }

        private void ButtonX_RemoveEmbeddedFile_Click(object sender, EventArgs e)
        {
            RemoveEmbeddedFile(GetSelectedEmbeddedFile());
        }
    }
}