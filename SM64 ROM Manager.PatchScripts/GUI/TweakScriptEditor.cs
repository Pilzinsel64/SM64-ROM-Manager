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
using SM64_ROM_Manager.PatchScripts.LangRes;
using System.Reflection;
using TaskDialog = DevComponents.DotNetBar.TaskDialog;

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
        private bool loadingData = false;

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
            CodeEditor.Visible = true;

            // Execute color change
            string script = CodeEditor.Text;
            CodeEditor.Text = string.Empty;
            CodeEditor.Text = script;
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

            if (!filesContainer.HasFile(fileName) || MessageBoxEx.Show(this, TweaksGUILangRes.MsgBox_EmbeddedFileAlreadyExists, TweaksGUILangRes.MsgBox_EmbeddedFileAlreadyExists_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (await filesContainer.AddFileAsync(fileName, filePath))
                {
                    LoadEmbeddedFiles();
                    LoadEmbeddedFileSelectorBox(true);
                }
            }
        }

        private void RemoveEmbeddedFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                filesContainer.RemoveFile(fileName);
                LoadEmbeddedFileSelectorBox(true);
            }
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

        private void LoadEmbeddedFileSelectorBox(bool checkIfScriptTypeIsValid = false)
        {
            itemPanel_SelectEmbeddedFile.Items.Clear();

            bool IsScriptTypeValid()
                => new ScriptType[] { ScriptType.BPS, ScriptType.IPS, ScriptType.PPF, ScriptType.DynamicLinkLibrary }.Contains(tempScript.Type);

            string GetExtension()
            {
                switch (tempScript.Type)
                {
                    case ScriptType.BPS:
                        return ".bps";
                    case ScriptType.IPS:
                        return ".ips";
                    case ScriptType.PPF:
                        return ".ppf";
                    case ScriptType.DynamicLinkLibrary:
                        return ".dll";
                    default:
                        return string.Empty;
                }
            }

            if (filesContainer is object && (!checkIfScriptTypeIsValid || IsScriptTypeValid()))
            {
                var infos = PatchFileInformations.Get(tempScript);

                foreach (var fileName in filesContainer.AllFileNames)
                {
                    if (Path.GetExtension(fileName) == GetExtension())
                    {
                        var cbi = new CheckBoxItem
                        {
                            CheckBoxStyle = eCheckBoxStyle.RadioButton,
                            Text = fileName,
                            Tag = fileName
                        };

                        if (infos.PatchFileName == fileName)
                            cbi.Checked = true;

                        cbi.CheckedChanged += (s, e) =>
                        {
                            if (cbi.Checked)
                            {
                                SaveTempScript();
                                if (tempScript.Type == ScriptType.DynamicLinkLibrary)
                                {
                                    var myInfos = PatchFileInformations.Get(tempScript);
                                    var myStream = (MemoryStream)filesContainer.GetStream(myInfos.PatchFileName);
                                    var rawData = myStream.ToArray();
                                    myStream.Close();
                                    var semdialog = new ObjectCatalog(BindingFlags.Static, new Assembly[] { Assembly.ReflectionOnlyLoad(rawData) }, true, MemberTypes.Method);
                                    if (semdialog.ShowDialog(this) == DialogResult.OK)
                                    {
                                        if (semdialog.CurrentMemberInfo is MethodInfo)
                                        {
                                            var mi = (MethodInfo)semdialog.CurrentMemberInfo;
                                            myInfos.ClassPath = mi.GetType().FullName;
                                            myInfos.MethodName = mi.Name;
                                            myInfos.Set(tempScript);
                                        }
                                    }
                                }
                            }
                        };

                        itemPanel_SelectEmbeddedFile.Items.Add(cbi);
                    }
                }

                itemPanel_SelectEmbeddedFile.Visible = true;
                itemPanel_SelectEmbeddedFile.Refresh();
            }
        }

        private void LoadAllData()
        {
            loadingData = true;

            TextBoxX_ScriptName.Text = tempScript.Name;
            TextBoxX_ScriptDescription.Text = tempScript.Description;
            CheckBoxX_AllowRevert.Checked = tempScript.AllowRevert;

            var switchExpr = tempScript.Type;
            switch (tempScript.Type)
            {
                case ScriptType.TweakScript:
                    CheckBoxX_TweakScript.Checked = true;
                    break;
                case ScriptType.VisualBasic:
                    CheckBoxX_VBScript.Checked = true;
                    break;
                case ScriptType.CSharp:
                    CheckBoxX_CSharpScript.Checked = true;
                    break;
                case ScriptType.Armips:
                    CheckBoxX_ArmipsScript.Checked = true;
                    break;
                case ScriptType.BPS:
                    checkBoxX_BPSPatch.Checked = true;
                    break;
                case ScriptType.IPS:
                    checkBoxX_IPSPatch.Checked = true;
                    break;
                case ScriptType.PPF:
                    checkBoxX_PPFPatch.Checked = true;
                    break;
                case ScriptType.DynamicLinkLibrary:
                    checkBoxX_DLL.Checked = true;
                    break;
            }

            itemPanel_SelectEmbeddedFile.Visible = false;
            CodeEditor.Visible = false;

            switch (tempScript.Type)
            {
                case ScriptType.TweakScript:
                    ChangeCurScriptType(Language.Custom, tempScript.Type);
                    CodeEditor.Text = tempScript.Script;
                    break;
                case ScriptType.VisualBasic:
                    ChangeCurScriptType(Language.VB, tempScript.Type);
                    CodeEditor.Text = tempScript.Script;
                    break;
                case ScriptType.CSharp:
                    ChangeCurScriptType(Language.CSharp, tempScript.Type);
                    CodeEditor.Text = tempScript.Script;
                    break;
                case ScriptType.Armips:
                    ChangeCurScriptType(Language.Custom, tempScript.Type);
                    CodeEditor.Text = tempScript.Script;
                    break;
                case ScriptType.BPS:
                case ScriptType.IPS:
                case ScriptType.PPF:
                case ScriptType.DynamicLinkLibrary:
                    LoadEmbeddedFileSelectorBox();
                    break;
            }

            ntsScript = false;
            ntsName = false;
            ntsDescription = false;
            ntsType = false;

            LoadReferences();
            LoadEmbeddedFiles();

            loadingData = false;
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

            switch (tempScript.Type)
            {
                case ScriptType.TweakScript:
                case ScriptType.VisualBasic:
                case ScriptType.CSharp:
                case ScriptType.Armips:
                    tempScript.Script = CodeEditor.Text;
                    break;
                case ScriptType.BPS:
                case ScriptType.IPS:
                case ScriptType.PPF:
                case ScriptType.DynamicLinkLibrary:
                    {
                        var fileName = string.Empty;

                        foreach (var item in itemPanel_SelectEmbeddedFile.Items)
                        {
                            if (item is CheckBoxItem && ((CheckBoxItem)item).Checked)
                                fileName = ((CheckBoxItem)item).Tag as string;
                        }

                        new PatchFileInformations
                        {
                            PatchFileName = fileName
                        }
                        .Set(tempScript);
                    }
                    break;
            }
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
            string msg = string.Empty;
            eTaskDialogIcon icon;
            string title;
            if (res.Errors.HasErrors)
            {
                title = TweaksGUILangRes.MsgBox_CompilerResult_ScriptContainsError_Title;
                icon = eTaskDialogIcon.Delete;
            }
            else
            {
                title = TweaksGUILangRes.MsgBox_CompilerResult_ScriptIsOK_Title;
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
                    msg += TweaksGUILangRes.Text_WARNING;
                }
                else
                {
                    msg += TweaksGUILangRes.MsgBox_ErrorWhileExecutingScript;
                }

                msg += $" {TweaksGUILangRes.Text_Code}: " + er.ErrorNumber;
                msg += $" {TweaksGUILangRes.Text_Line}: " + Conversions.ToString(er.Line);
                msg += Constants.vbNewLine + er.ErrorText;
            }
            
            TaskDialog.Show(TweaksGUILangRes.MsgBox_CompilerResult_Header, icon, title, msg, eTaskDialogButton.Ok);
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
            if (!loadingData)
            {
                var sender = osender as CheckBoxX;
                
                CodeEditor.Visible = false;
                itemPanel_SelectEmbeddedFile.Visible = false;

                if (sender.Checked && CodeEditor is object)
                {
                    if (sender == CheckBoxX_TweakScript)
                        ChangeCurScriptType(Language.Custom, ScriptType.TweakScript);
                    else if (sender == CheckBoxX_CSharpScript)
                        ChangeCurScriptType(Language.CSharp, ScriptType.CSharp);
                    else if (sender == CheckBoxX_VBScript)
                        ChangeCurScriptType(Language.VB, ScriptType.VisualBasic);
                    else if (sender == CheckBoxX_ArmipsScript)
                        ChangeCurScriptType(Language.Custom, ScriptType.Armips);
                    else if (sender == checkBoxX_BPSPatch)
                    {
                        tempScript.Type = ScriptType.BPS;
                        LoadEmbeddedFileSelectorBox();
                    }
                    else if (sender == checkBoxX_IPSPatch)
                    {
                        tempScript.Type = ScriptType.IPS;
                        LoadEmbeddedFileSelectorBox();
                    }
                    else if (sender == checkBoxX_PPFPatch)
                    {
                        tempScript.Type = ScriptType.PPF;
                        LoadEmbeddedFileSelectorBox();
                    }
                    else if (sender == checkBoxX_DLL)
                    {
                        tempScript.Type = ScriptType.DynamicLinkLibrary;
                        LoadEmbeddedFileSelectorBox();
                    }
                }
            }

            bool isDotNet = CheckBoxX_CSharpScript.Checked || CheckBoxX_VBScript.Checked;
            bool isPatch = checkBoxX_BPSPatch.Checked || checkBoxX_IPSPatch.Checked || checkBoxX_PPFPatch.Checked;
            bool isDLL = checkBoxX_DLL.Checked;
            LayoutControlItem4.Visible = isDotNet;
            layoutControlItem5.Visible = (isDotNet || isPatch || isDLL) && filesContainer is object;
            ButtonItem_CheckForErrors.Enabled = isDotNet;
        }

        private void TweakScriptEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!new[] { CloseReason.ApplicationExitCall, CloseReason.WindowsShutDown, CloseReason.TaskManagerClosing }.Contains(e.CloseReason))
            {
                if (NeedToSave)
                {
                    var switchExpr = MessageBoxEx.Show(TweaksGUILangRes.MsgBox_SaveChanges, TweaksGUILangRes.MsgBox_SaveChanges_Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
            ntsScript = true;
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
                frmObjectCatalog = new ObjectCatalog(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, new Assembly[] { typeof(RomManager).Assembly }, false, MemberTypes.All);
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

        private void CheckBoxX_AllowRevert_CheckedChanged(object sender, EventArgs e)
        {
            tempScript.AllowRevert = CheckBoxX_AllowRevert.Checked;
        }

        private void ItemPanel_SelectEmbeddedFile_ItemClick(object sender, EventArgs e)
        {
        }
    }
}