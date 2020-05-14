using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.WindowsAPICodePack.Dialogs;
using SM64Lib;
using SM64Lib.Objects.ObjectBanks;
using static SM64Lib.TextValueConverter.TextValueConverter;
using Z.Collections.Extensions;
using System.Linq;
using System.IO;
using Timer = System.Timers.Timer;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using SM64_ROM_Manager.PatchScripts;
using Pilz.IO;
using SM64Lib.Patching;

namespace SM64_ROM_Manager
{
    public partial class CustomObjectsManager : OfficeForm
    {
        // C o n s t a n t s

        private const string FILTER_CUSTOM_OBJECT_NAMES = "Custom Objects";
        private const string FILTER_CUSTOM_OBJECT_EXTENSIONS = ".rmobj";

        // F i e l d s

        private readonly CustomObjectCollection customObjectCollection;
        private readonly RomManager rommgr;
        private CustomObject customObject = null;
        private bool isLoadingProps = false;
        private Timer Timer_PropsChanged;
        private EmbeddedFilesContainer export_EmbeddedFiles = null;
        private PatchScript export_Script = null;

        // C o n s t r u c t o r

        public CustomObjectsManager(CustomObjectCollection collection, RomManager rommgr)
        {
            if (rommgr is object)
            {
                this.rommgr = rommgr;
                rommgr.AfterRomSave += Rommgr_AfterRomSave;
            }
            customObjectCollection = collection;

            // Components
            InitializeComponent();
            UpdateAmbientColors();
            layoutControl1.Enabled = false;
            TextBoxX_BehavAddr.Enabled = false;
            TextBoxX_ModelID.Enabled = false;
            ButtonItem_DeleteObject.Enabled = false;
            buttonItem_Export.Enabled = false;

            // Props-Timer
            Timer_PropsChanged = new Timer(1000) { SynchronizingObject = this, AutoReset = false };
            Timer_PropsChanged.Elapsed += Timer_PropsChanged_Elapsed;
        }

        // R o m M a n a g e r   E v e n t s

        private void Rommgr_AfterRomSave(RomManager sender, EventArgs e)
        {
            UpdateAllNodes();
        }

        // O t h e r   E v e n t s

        private void Timer_PropsChanged_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateNode(customObject);
        }

        private void Frm_ImportPatchClicked(CustomObjectImport import)
        {
            ImportObjects(new Dictionary<string, CustomObjectImport>() { { import.Name, import } });
        }

        // F e a t u r e s

        private void LoadObjects()
        {
            AdvTree_Objs.BeginUpdate();
            AdvTree_Objs.Nodes.Clear();

            foreach (var cobj in customObjectCollection.CustomObjects)
                AdvTree_Objs.Nodes.Add(GetNode(cobj));

            AdvTree_Objs.EndUpdate();
        }

        private Node GetNode(CustomObject cobj)
        {
            var n = new Node()
            {
                Tag = cobj
            };
            n.Cells.Add(new Cell());
            n.Cells.Add(new Cell());
            UpdateNode(n);
            return n;
        }

        private void UpdateAllNodes()
        {
            AdvTree_Objs.BeginUpdate();
            updateNodes(AdvTree_Objs.Nodes);
            AdvTree_Objs.EndUpdate();

            void updateNodes(NodeCollection collection)
            {
                foreach (Node n in collection)
                {
                    UpdateNode(n);
                    updateNodes(n.Nodes);
                }
            }
        }

        private void UpdateNode(Node n)
        {
            if (n?.Tag is CustomObject)
            {
                var cobj = (CustomObject)n.Tag;
                n.Text = cobj.Name;
                n.Cells[1].Text = TextFromValue(cobj.ModelProps.ModelID);
                n.Cells[2].Text = TextFromValue(cobj.BehaviorProps.BehaviorAddress);
            }
        }

        private void UpdateNode(CustomObject cobj)
        {
            UpdateNode(FindNode(cobj));
        }

        private Node FindNode(CustomObject cobj)
        {
            Node n = null;

            foreach (Node nn in AdvTree_Objs.Nodes)
            {
                if (n == null && nn.Tag == cobj)
                    n = nn;
            }

            return n;
        }

        private void SelectNode(Node n)
        {
            AdvTree_Objs.SelectedNode = n;
            n?.EnsureVisible();
        }

        private void LoadObjectProps()
        {
            var isObject = customObject != null;
            layoutControl1.Enabled = isObject;
            buttonItem_Export.Enabled = isObject;
            ButtonItem_DeleteObject.Enabled = isObject;

            if (isObject)
            {
                isLoadingProps = true;

                CheckBoxX_BehavBank.Checked = false;
                CheckBoxX_BehavCustom.Checked = false;
                CheckBoxX_NoModel.Checked = false;
                CheckBoxX_CustomModel.Checked = false;
                CheckBoxX_CustomModelID.Checked = false;

                // General
                TextBoxX_Name.Text = customObject.Name;
                TextBoxX_Description.Text = customObject.Description;
                CheckBoxX_UseColPtrForBehav.Checked = customObject.BehaviorProps.UseCollisionPointerOfModel;

                // Behavior Props
                if (customObject.BehaviorProps.UseCustomAddress)
                {
                    CheckBoxX_BehavCustom.Checked = true;
                    TextBoxX_BehavAddr.Text = TextFromValue(customObject.BehaviorProps.BehaviorAddress);
                }
                else
                    CheckBoxX_BehavBank.Checked = true;

                // Model Props
                if (customObject.ModelProps.UseCustomModelID)
                {
                    if (customObject.ModelProps.ModelID == 0)
                        CheckBoxX_NoModel.Checked = true;
                    else
                        CheckBoxX_CustomModelID.Checked = true;
                    TextBoxX_ModelID.Text = TextFromValue(customObject.ModelProps.ModelID);
                }
                else
                    CheckBoxX_CustomModel.Checked = true;

                isLoadingProps = false;
            }
        }

        private void SaveObjectProps()
        {
            if (!isLoadingProps && customObject is object)
            {
                Timer_PropsChanged.Stop();

                customObject.Name = TextBoxX_Name.Text.Trim();
                customObject.Description = TextBoxX_Description.Text.Trim();
                customObject.BehaviorProps.UseCollisionPointerOfModel = CheckBoxX_UseColPtrForBehav.Checked;

                if (CheckBoxX_BehavCustom.Checked)
                    customObject.BehaviorProps.BehaviorAddress = ValueFromText(TextBoxX_BehavAddr.Text);

                if (CheckBoxX_NoModel.Checked)
                    customObject.ModelProps.ModelID = 0;
                else if (CheckBoxX_CustomModelID.Checked)
                    customObject.ModelProps.ModelID = (byte)ValueFromText(TextBoxX_ModelID.Text);

                Timer_PropsChanged.Start();
            }
        }

        private IEnumerable<CustomObject> GetSelectedCustomObjects()
        {
            var cobjs = new List<CustomObject>();

            foreach (Node n in AdvTree_Objs.SelectedNodes)
            {
                if (n.Tag is CustomObject)
                    cobjs.Add((CustomObject)n.Tag);
            }

            return cobjs;
        }

        private void ExportObjects(string filePath, bool multiExport, string exportName)
        {
            var objs = GetSelectedCustomObjects();
            var options = new CustomObjectExportOptions
            {
                ExportName = exportName,
                EmbeddedFiles = export_EmbeddedFiles,
                Script = export_Script
            };

            if (multiExport)
            {
                foreach (var obj in objs)
                {
                    var myFilePath = Path.Combine(filePath, obj.Name + ".rmobj");
                    CustomObjectCollection.Export(myFilePath, obj, options);
                }
            }
            else
                CustomObjectCollection.Export(filePath, objs.ToArray(), options);
        }

        private bool IsMultiselect()
        {
            return AdvTree_Objs.SelectedNodes.Count > 1;
        }

        private void ImportObjects(string[] filePaths)
        {
            var imports = new Dictionary<string, CustomObjectImport>();

            foreach (var filePath in filePaths)
            {
                var import = CustomObjectCollection.LoadImport(filePath);
                import.Decompress();
                imports.Add(Path.GetFileNameWithoutExtension(filePath), import);
            }

            ImportObjects(imports);
        }

        private void ImportObjects(Dictionary<string, CustomObjectImport> imports)
        {
            if (imports.Any())
            {
                foreach (var kvpImport in imports)
                {
                    foreach (var kvpMdl in kvpImport.Value.Data.CustomModels)
                        kvpImport.Value.DestModelBanks.Add(kvpMdl.Key, rommgr.GlobalModelBank);
                    kvpImport.Value.DestBehaviorBank = rommgr.GlobalBehaviorBank;
                    kvpImport.Value.DestCustomAsmBank = rommgr.GlobalCustomAsmBank;
                }

                var frm = new CustomObjectImportDialog(rommgr, imports);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    foreach (var import in imports.Values)
                        customObjectCollection.Import(import);
                    rommgr.CalculateGlobalBehaviorBankAddresses();
                    LoadObjects();
                }
            }
        }

        private bool SelectCustomModelFromBank()
        {
            var frm = new CustomModelSelector(rommgr)
            {
                Model = customObject.ModelProps.Model
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                customObject.ModelProps.UseCustomModelID = false;
                customObject.ModelProps.Model = frm.Model;
                UpdateNode(customObject);
                LoadObjectProps();
                return true;
            }
            else
                return false;
        }

        private bool SelectFromBehaviorBank()
        {
            var frm = new CustomBehaviorSelector(rommgr)
            {
                Behavior = customObject.BehaviorProps.Behavior
            };

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                customObject.BehaviorProps.UseCustomAddress = false;
                customObject.BehaviorProps.Behavior = frm.Behavior;
                UpdateNode(customObject);
                LoadObjectProps();
                return true;
            }
            else
                return false;
        }

        // G u i

        private void ButtonItem_NewObject_Click(object sender, EventArgs e)
        {
            var obj = new CustomObject
            {
                Name = "New Object"
            };
            obj.ID.Generate();
            customObjectCollection.CustomObjects.Add(obj);

            var n = GetNode(obj);
            AdvTree_Objs.Nodes.Add(n);
            SelectNode(n);
        }

        private void ButtonItem_ImportFromFile_Click(object sender, EventArgs e)
        {
            var ofd_SM64RM_ExportCustomObjectToFile = new OpenFileDialog
            {
                Filter = $"{FILTER_CUSTOM_OBJECT_NAMES} (*{FILTER_CUSTOM_OBJECT_EXTENSIONS})|*{FILTER_CUSTOM_OBJECT_EXTENSIONS}",
                Multiselect = true
            };

            if (ofd_SM64RM_ExportCustomObjectToFile.ShowDialog() == DialogResult.OK)
                ImportObjects(ofd_SM64RM_ExportCustomObjectToFile.FileNames);
        }

        private void ButtonItem_ImportFromDatabase_Click(object sender, EventArgs e)
        {
            var frm = new CustomObjectsDatabaseViewer();
            frm.ImportClicked += Frm_ImportPatchClicked;
            frm.Show();
        }

        private void ButtonItem_DeleteObject_Click(object sender, EventArgs e)
        {
            var customObject = this.customObject;
            var refs = CustomObjectReferences.Find(new[] { customObject }, rommgr);
            var needReloadList = refs.ReferenceObjects.Any();
            var allowRemove = true;
            var allowRemoveReferences = false;

            if (refs.HasReferences)
            {
                var response = MessageBoxEx.Show(this, "The object you want to remove has some references. Do you also want to remove all referenced Behaviors, Custom ASM Codes, Custom Models and Custom Objects?", "Delete Custom Object References", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (response)
                {
                    case DialogResult.Cancel:
                        allowRemove = false;
                        break;
                    case DialogResult.Yes:
                        allowRemoveReferences = true;
                        break;
                }
            }

            if (allowRemove)
            {
                if (!needReloadList)
                {
                    var n = FindNode(customObject);
                    if (n is object)
                        n.Remove();
                }

                customObjectCollection.CustomObjects.RemoveIfContains(customObject);

                if (refs.HasReferences && allowRemoveReferences)
                    refs.DeleteReferences(rommgr);

                customObject = null;
                LoadObjectProps();

                if (refs.HasReferences && allowRemoveReferences)
                    LoadObjects();
            }
        }

        private void ButtonItem_ExportToFile_Click(object sender, EventArgs e)
        {
            var isMultiselect = IsMultiselect();
            CommonFileDialog sfd_SM64RM_ExportCustomObjectToFile;
            var tbxName = new CommonFileDialogTextBox("rmobj.name", customObject.Name);
            var btnAddScript = new CommonFileDialogButton("rmobj.script", "Setup Script") { IsProminent = true };

            btnAddScript.Click += BtnAddScript_Click;
            export_EmbeddedFiles = new EmbeddedFilesContainer();
            export_Script = new PatchScript();

            if (isMultiselect && MessageBoxEx.Show(this, "You are going to export multiple custom objects. Do you want to save all objects to one single file (Yes) or do you want to save every single object to one file (No)?", "Export Custom Objects", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                sfd_SM64RM_ExportCustomObjectToFile = new CommonOpenFileDialog() { IsFolderPicker = true };
            else
            {
                isMultiselect = false;
                sfd_SM64RM_ExportCustomObjectToFile = new CommonSaveFileDialog() { DefaultExtension = FILTER_CUSTOM_OBJECT_EXTENSIONS };
                sfd_SM64RM_ExportCustomObjectToFile.Filters.Add(new CommonFileDialogFilter(FILTER_CUSTOM_OBJECT_NAMES, FILTER_CUSTOM_OBJECT_EXTENSIONS));
            }

            sfd_SM64RM_ExportCustomObjectToFile.Controls.Add(tbxName);
            sfd_SM64RM_ExportCustomObjectToFile.Controls.Add(btnAddScript);

            if (sfd_SM64RM_ExportCustomObjectToFile.ShowDialog(Handle) == CommonFileDialogResult.Ok)
                ExportObjects(sfd_SM64RM_ExportCustomObjectToFile.FileName, isMultiselect, tbxName.Text);
        }

        private void BtnAddScript_Click(object sender, EventArgs e)
        {
            if (export_EmbeddedFiles is object && export_Script is object)
            {
                var editor = new TweakScriptEditor(export_Script, rommgr, export_EmbeddedFiles);
                editor.ShowDialog(this);
            }
        }

        private void ButtonItem_UploadToDatabase_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxX_Name_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void TextBoxX_BehavAddr_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void ButtonX_SelectFromBehavBank_Click(object sender, EventArgs e)
        {
            SelectFromBehaviorBank();
        }

        private void TextBoxX_ModelID_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void ButtonX_SelectCustomModelFromBank_Click(object sender, EventArgs e)
        {
            SelectCustomModelFromBank();
        }

        private void CheckBoxX_BehavCustom_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = CheckBoxX_BehavCustom.Checked;
            TextBoxX_BehavAddr.Enabled = isChecked;

            if (isChecked)
                CheckBoxX_BehavBank.Checked = false;

            if (!isLoadingProps && customObject is object && isChecked)
            {
                customObject.BehaviorProps.UseCustomAddress = true;
                customObject.BehaviorProps.Behavior = null;
                UpdateNode(customObject);
                LoadObjectProps();
            }
        }

        private void CheckBoxX_NoModel_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = CheckBoxX_NoModel.Checked;

            if (isChecked)
            {
                CheckBoxX_CustomModel.Checked = false;
                CheckBoxX_CustomModelID.Checked = false;
            }

            if (!isLoadingProps && customObject is object && isChecked)
            {
                customObject.ModelProps.UseCustomModelID = true;
                customObject.ModelProps.ModelID = 0;
                customObject.ModelProps.Model = null;
                UpdateNode(customObject);
            }
        }

        private void CheckBoxX_CustomModelID_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = CheckBoxX_CustomModelID.Checked;
            TextBoxX_ModelID.Enabled = isChecked;

            if (isChecked)
            {
                CheckBoxX_CustomModel.Checked = false;
                CheckBoxX_NoModel.Checked = false;
            }

            if (!isLoadingProps && customObject is object && isChecked)
            {
                customObject.ModelProps.UseCustomModelID = true;
                customObject.ModelProps.Model = null;
                UpdateNode(customObject);
            }
        }

        private void CheckBoxX_UseColPtrForBehav_CheckedChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void AdvTree_Objs_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            customObject = e.Node?.Tag as CustomObject;
            LoadObjectProps();
        }

        private void CheckBoxX_CustomModel_Click(object sender, EventArgs e)
        {
            if (CheckBoxX_CustomModel.Checked)
            {
                CheckBoxX_CustomModelID.Checked = false;
                CheckBoxX_NoModel.Checked = false;
            }
        }

        private void CheckBoxX_BehavBank_Click(object sender, EventArgs e)
        {
            if (CheckBoxX_BehavBank.Checked)
                CheckBoxX_BehavCustom.Checked = false;
        }

        private void TextBoxX_Description_TextChanged(object sender, EventArgs e)
        {
            SaveObjectProps();
        }

        private void CheckBoxX_BehavBank_CheckedChanging(object sender, DevComponents.DotNetBar.Controls.CheckBoxXChangeEventArgs e)
        {
            if (!isLoadingProps && e.EventSource != eEventSource.Code)
                e.Cancel = e.NewChecked.Checked || !SelectFromBehaviorBank();
        }

        private void CheckBoxX_CustomModel_CheckedChanging(object sender, DevComponents.DotNetBar.Controls.CheckBoxXChangeEventArgs e)
        {
            if (!isLoadingProps && e.EventSource != eEventSource.Code)
                e.Cancel = e.NewChecked.Checked || !SelectCustomModelFromBank();
        }

        private void CustomObjectsManager_Load(object sender, EventArgs e)
        {
            LoadObjects();
        }

        private void CustomObjectsManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            rommgr.AfterRomSave -= Rommgr_AfterRomSave;
        }

        private void CheckBoxX_CheckingChanging(object sender, DevComponents.DotNetBar.Controls.CheckBoxXChangeEventArgs e)
        {
            e.Cancel = !isLoadingProps && e.EventSource != eEventSource.Code && e.NewChecked.Checked;
        }
    }
}