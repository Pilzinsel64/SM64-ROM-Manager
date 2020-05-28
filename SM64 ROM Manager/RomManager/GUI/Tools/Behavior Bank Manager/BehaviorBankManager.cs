using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;
using SM64_ROM_Manager.My.Resources;
using SM64Lib;
using SM64Lib.ASM;
using SM64Lib.Behaviors;
using SM64Lib.Behaviors.Script;
using SM64Lib.Data;
using Z.Collections.Extensions;
using static SM64Lib.TextValueConverter.TextValueConverter;
using Timer = System.Timers.Timer;

namespace SM64_ROM_Manager
{
    public partial class BehaviorBankManager : OfficeForm
    {
        // D e f a u l t   N o d e s

        private Node nBehavVanilla = new Node("Vanilla") { Expanded = true };
        private Node nBehavCustom = new Node("Custom") { Expanded = true };

        // F i e l d s

        private readonly RomManager rommgr;
        private BehaviorBank bank;
        private Behavior curBehav = null;
        private CustomAsmAreaLinkOptions curAsmLinkOption = null;
        private bool loadingBehavior = false;
        private bool loadingCustomAsmLinkOptions = false;
        private Timer Timer_PropsChanged;

        // C o n s t r u c t o r

        public BehaviorBankManager(BehaviorBank bank, RomManager rommgr)
        {
            this.bank = bank;
            
            // Add rom manager events
            if (rommgr is object)
            {
                rommgr.AfterRomSave += Rommgr_AfterRomSave;
                this.rommgr = rommgr;
            }

            // Load behavior infos
            General.LoadBehaviorInfosIfEmpty();

            // Components
            InitializeComponent();
            UpdateAmbientColors();
            StyleManager.UpdateAmbientColors(RichTextBoxEx_Script);
            TabControl_Behav.Enabled = false;
            ButtonItem_DisableGlobaleBehaviorBank.Visible = IsEditingGlobalBehaviorBank();
            ButtonItem_Advanced.Visible = ButtonItem_Advanced.VisibleSubItems != 0;

            // Default Nodes
            AdvTree_Behaviors.Nodes.AddRange(new[] { nBehavCustom, nBehavVanilla });

            // Props-Timer
            Timer_PropsChanged = new Timer(1000) { SynchronizingObject = this, AutoReset = false };
            Timer_PropsChanged.Elapsed += Timer_PropsChanged_Elapsed;
        }

        // P r o p e r t i e s

        private bool IsEditScript
        {
            get => TabControl_Behav.SelectedTab == TabItem_BehavScript;
        }

        private bool IsEditProps
        {
            get => TabControl_Behav.SelectedTab == TabItem_BehavProps;
        }

        // R o m M a n a g e r   E v e n t s

        private void Rommgr_AfterRomSave(RomManager sender, EventArgs e)
        {
            UpdateAllNodes(false);
            LoadBehavior();
        }

        // T i m e r   E v e n t s

        private void Timer_PropsChanged_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (curBehav is object)
                UpdateNode(curBehav);
        }

        // F e a t u r e s

        private void LoadBehaviors(bool vanilla)
        {
            NodeCollection nodes = GetNodeCollection(vanilla);

            if (nodes is object)
            {
                AdvTree_Behaviors.BeginUpdate();
                nodes.Clear();

                foreach (var behav in bank.Behaviors)
                {
                    if (behav.Config.IsVanilla == vanilla)
                        nodes.Add(GetNode(behav));
                }

                AdvTree_Behaviors.EndUpdate();
            }
        }

        private NodeCollection GetNodeCollection(bool vanilla)
        {
            NodeCollection nodes = null;

            switch (vanilla)
            {
                case true:
                    nodes = nBehavVanilla.Nodes;
                    break;
                case false:
                    nodes = nBehavCustom.Nodes;
                    break;
            }

            return nodes;
        }

        private Node GetNode(Behavior behav)
        {
            var n = new Node()
            {
                Tag = behav
            };

            n.Cells.Add(new Cell() { Name = "segaddr" });
            UpdateNode(n);

            return n;
        }

        private Node FindNode(Behavior behav)
        {
            Node n = null;
            NodeCollection nodes = GetNodeCollection(behav.Config.IsVanilla);

            if (nodes is object)
            {
                foreach (Node node in nodes)
                {
                    if (n == null && node.Tag == behav)
                        n = node;
                }
            }

            return n;
        }

        private void UpdateNode(Behavior behav)
        {
            Node n = FindNode(behav);
            if (n is object)
                UpdateNode(n);
        }

        private void UpdateNode(Node n)
        {
            if (n is object && n.Tag is Behavior)
            {
                var behav = (Behavior)n.Tag;
                string txt;

                if (!string.IsNullOrEmpty(behav.Config.Name))
                    txt = behav.Config.Name;
                else
                {
                    var info = General.BehaviorInfos.GetByBehaviorAddress((uint)behav.Config.BankAddress);
                    var infoCustom = General.BehaviorInfosCustom.GetByBehaviorAddress((uint)behav.Config.BankAddress);

                    if (infoCustom is object)
                        txt = infoCustom.Name;
                    else if (info is object)
                        txt = info.Name;
                    else
                        txt = "Unnamed";
                }

                n.Text = txt;
                n.Cells["segaddr"].Text = TextFromValue(behav.Config.BankAddress);
            }
        }

        private void UpdateAllNodes(bool vanilla)
        {
            var nodes = GetNodeCollection(vanilla);

            if (nodes is object)
            {
                foreach (Node n in nodes)
                    UpdateNode(n);
            }
        }

        private void LoadBehavior()
        {
            var isBehav = curBehav is object;
            TabControl_Behav.Enabled = isBehav;

            if (isBehav)
            {
                loadingBehavior = true;

                if (IsEditProps)
                {
                    TextBoxX_BehavName.Text = curBehav.Config.Name;
                    checkBoxX_BehavEnableColPtr.Checked = curBehav.EnableCollisionPointer;
                    textBoxX_BehavColPtr.Text = TextFromValue(curBehav.CollisionPointer);
                    ButtonX_EditParamInfos.Enabled = !curBehav.Config.IsVanilla;
                    LoadCustomAsmLinkOptionsList();
                }
                else if (IsEditScript)
                {
                    curBehav.TakeoverSettingsToScript();
                    RichTextBoxEx_Script.Text = GetScriptAsString(curBehav.Script);
                }

                ButtonItem_RemoveBehav.Enabled = !curBehav.Config.IsVanilla;
                bar1.Refresh();

                loadingBehavior = false;
            }
        }

        private static string GetScriptAsString(Behaviorscript script)
        {
            var sw = new StringWriter();
            
            for (int i = 0; i < script.Count; i++)
            {
                var cmd = (BehaviorscriptCommand)script[i];
                
                if (i > 0)
                    sw.WriteLine();

                byte[] cmdArr = cmd.ToArray();
                for (int i1 = 0; i1 < cmdArr.Length; i1++)
                {
                    if (i1 > 0) sw.Write(" ");
                    sw.Write(cmdArr[i1].ToString("X2"));
                }
            }

            return sw.ToString();
        }

        private static bool BuildScriptWithString(Behavior behav, string str)
        {
            var success = true;
            var scriptBytes = new List<byte>();

            // Get all single bytes
            using (var sr = new StringReader(str))
            {
                while (success && sr.Peek() != -1)
                {
                    var line = sr.ReadLine();
                    var bytes = line?.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (bytes is object && bytes.Any())
                    {
                        foreach (var @byte in bytes)
                        {
                            var @byteTrimed = @byte.Trim();
                            if (!string.IsNullOrEmpty(@byteTrimed))
                            {
                                if (byte.TryParse(@byteTrimed, System.Globalization.NumberStyles.HexNumber, null, out var b))
                                    scriptBytes.Add(b);
                                else
                                    success = false;
                            }
                        }
                    }
                }
            }

            if (success && scriptBytes.Count % 4 == 0 && (!behav.Config.IsVanilla || behav.Config.FixedLength >= scriptBytes.Count))
            {
                // Read script
                using (var scriptData = new BinaryStreamData(new MemoryStream(scriptBytes.ToArray())))
                    success = behav.Script.Read(scriptData, 0);
            }
            else
                success = false;

            return success;
        }

        private void SaveBehaviorProps()
        {
            if (!loadingBehavior)
            {
                curBehav.Config.Name = TextBoxX_BehavName.Text.Trim();
                curBehav.CollisionPointer = ValueFromText(textBoxX_BehavColPtr.Text);
                curBehav.EnableCollisionPointer = checkBoxX_BehavEnableColPtr.Checked;
                rommgr.CalculateGlobalBehaviorBankAddresses();
                Timer_PropsChanged.Stop(); Timer_PropsChanged.Start();
            }
        }

        private bool SaveBehaviorScript()
        {
            var res = false;
            if (!loadingBehavior)
            {
                res = BuildScriptWithString(curBehav, RichTextBoxEx_Script.Text);
                if (res)
                {
                    rommgr.CalculateGlobalBehaviorBankAddresses();
                    curBehav.ParseScript();
                }
            }
            return res;
        }

        private void RemoveBehavior(Behavior behav)
        {
            Node n = FindNode(behav);

            if (n is object)
            {
                n.Remove();
                bank.Behaviors.RemoveIfContains(behav);
                rommgr.CalculateGlobalBehaviorBankAddresses();
                if (curBehav == behav) curBehav = null;
            }

            
        }

        private void AddNewBehavior(BehaviorCreationTypes type)
        {
            // Create behavior
            var behav = new Behavior(type);
            behav.Config.ID.Generate();
            bank.Behaviors.Add(behav);
            rommgr.CalculateGlobalBehaviorBankAddresses();

            // Create Node
            var n = GetNode(behav);
            nBehavCustom.Nodes.Add(n);
            n.EnsureVisible();
            AdvTree_Behaviors.SelectedNode = n;
        }

        private void LoadCustomAsmLinkOptionsList()
        {
            ListViewEx_CustomAsmFunctions.BeginUpdate();
            ListViewEx_CustomAsmFunctions.Items.Clear();

            foreach (var link in curBehav.Config.CustomAsmLinks)
                ListViewEx_CustomAsmFunctions.Items.Add(GetCustomAsmLinkOptionsItem(link));

            ListViewEx_CustomAsmFunctions.EndUpdate();

            curAsmLinkOption = null;
            LoadCustomAsmLinkOptions();
        }

        private ListViewItem GetCustomAsmLinkOptionsItem(CustomAsmAreaLinkOptions link)
        {
            var item = new ListViewItem
            {
                Tag = link
            };
            item.SubItems.Add(new ListViewItem.ListViewSubItem());
            UpdateCustomAsmLinkOptionsItem(item);
            return item;
        }

        private ListViewItem FindCustomAsmLinkOptionsItem(CustomAsmAreaLinkOptions link)
        {
            ListViewItem item = null;

            foreach (ListViewItem iitem in ListViewEx_CustomAsmFunctions.Items)
            {
                if (iitem.Tag == link)
                    item = iitem;
            }

            return item;
        }

        private void UpdateCustomAsmLinkOptionsItem(CustomAsmAreaLinkOptions link)
        {
            UpdateCustomAsmLinkOptionsItem(FindCustomAsmLinkOptionsItem(link));
        }

        private void UpdateCustomAsmLinkOptionsItem(ListViewItem item)
        {
            if (item?.Tag is CustomAsmAreaLinkOptions link)
            {
                item.SubItems[0].Text = link.CustomAsm.Config.Name;
                item.SubItems[1].Text = link.Loop.ToString();
            }
        }

        private void LoadCustomAsmLinkOptions()
        {
            bool isNotNull = curAsmLinkOption is object;

            ButtonX_LoopCustomAsmFunction.Enabled = isNotNull;
            ButtonX_RemoveCustomAsmFunction.Enabled = isNotNull;

            if (isNotNull)
            {
                loadingCustomAsmLinkOptions = true;
                ButtonX_LoopCustomAsmFunction.Checked = curAsmLinkOption.Loop;
                loadingCustomAsmLinkOptions = false;
            }
        }

        private void SaveCustomAsmLinkOptions()
        {
            if (!loadingCustomAsmLinkOptions && curAsmLinkOption is object)
            {
                curAsmLinkOption.Loop = ButtonX_LoopCustomAsmFunction.Checked;
                UpdateCustomAsmLinkOptionsItem(curAsmLinkOption);
            }
        }

        private void AddCustomAsmLinkOptions(CustomAsmArea asm)
        {
            if (curBehav is object)
            {
                // Add link options
                var link = new CustomAsmAreaLinkOptions
                {
                    CustomAsm = asm
                };
                curBehav.Config.CustomAsmLinks.Add(link);

                // Add item
                var item = GetCustomAsmLinkOptionsItem(link);
                ListViewEx_CustomAsmFunctions.Items.Add(item);
                foreach (ListViewItem selitem in ListViewEx_CustomAsmFunctions.SelectedItems)
                    selitem.Selected = false;
                item.Selected = true;
                item.EnsureVisible();
            }
        }

        private void RemoveCustomAsmLinkOptions(CustomAsmAreaLinkOptions link)
        {
            // Remove item
            var item = FindCustomAsmLinkOptionsItem(link);
            if (item is object)
                ListViewEx_CustomAsmFunctions.Items.Remove(item);

            // Remove link options
            curBehav?.Config.CustomAsmLinks.RemoveIfContains(link);
        }

        private bool IsEditingGlobalBehaviorBank()
            => rommgr is object && rommgr.GlobalBehaviorBank == bank;

        private void DisableGlobalBehaviorBank()
            => rommgr.DisableGlobalBehaviorBank();

        // G U I

        private void BehaviorBankManager_Shown(object sender, EventArgs e)
        {
            LoadBehaviors(true);
            LoadBehaviors(false);
        }

        private void AdvTree_Behaviors_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            if (e.Node?.Tag is Behavior)
                curBehav = (Behavior)e.Node.Tag;
            else
                curBehav = null;
            LoadBehavior();
            highlighter_Script.SetHighlightColor(RichTextBoxEx_Script, eHighlightColor.None);
        }

        private void TabControl_Behav_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            LoadBehavior();
        }

        private void TabControl_Behav_SelectedTabChanging(object sender, TabStripTabChangingEventArgs e)
        {
        }

        private void ButtonX_SaveScript_Click(object sender, EventArgs e)
        {
            bool res = SaveBehaviorScript();
            highlighter_Script.SetHighlightColor(RichTextBoxEx_Script, res ? eHighlightColor.None : eHighlightColor.Red);
            if (!res)
                MessageBoxEx.Show(this, BehaviorBankManagerLangRes.Msg_ErrorCompilingScript, BehaviorBankManagerLangRes.Msg_ErrorCompilingScriptTitel, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CheckBoxX_BehavEnableColPtr_CheckedChanged(object sender, EventArgs e)
        {
            textBoxX_BehavColPtr.Enabled = checkBoxX_BehavEnableColPtr.Checked;
            SaveBehaviorProps();
        }

        private void TextBoxX_BehavColPtr_TextChanged(object sender, EventArgs e)
        {
            SaveBehaviorProps();
        }

        private void TextBoxX_BehavName_TextChanged(object sender, EventArgs e)
        {
            SaveBehaviorProps();
        }

        private void ButtonItem_RemoveBehav_Click(object sender, EventArgs e)
        {
            if (curBehav is object && !curBehav.Config.IsVanilla && MessageBoxEx.Show(this, BehaviorBankManagerLangRes.Msg_RemoveBehavior, BehaviorBankManagerLangRes.Msg_RemoveBehaviorTitel, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                RemoveBehavior(curBehav);
        }

        private void ButtonItem_NewBehav_SolidObject_Click(object sender, EventArgs e)
        {
            AddNewBehavior(BehaviorCreationTypes.SolidObject);
        }

        private void RichTextBoxEx_Script_GotFocus(object sender, EventArgs e)
        {
            ButtonX_SaveScript.Shortcuts.Add(eShortcut.CtrlS);
        }

        private void RichTextBoxEx_Script_LostFocus(object sender, EventArgs e)
        {
            ButtonX_SaveScript.Shortcuts.Remove(eShortcut.CtrlS);
        }

        private void BehaviorBankManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            rommgr.AfterRomSave -= Rommgr_AfterRomSave;
        }

        private void ListViewEx_CustomAsmFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItems = ListViewEx_CustomAsmFunctions.SelectedItems;
            if (selItems.Count > 0)
                curAsmLinkOption = selItems[0].Tag as CustomAsmAreaLinkOptions;
            else
                curAsmLinkOption = null;

            LoadCustomAsmLinkOptions();
        }

        private void ButtonX_AddCustomAsmFunction_Click(object sender, EventArgs e)
        {
            var selector = new CustomAsmCodeSelector(rommgr);
            if (selector.ShowDialog(this) == DialogResult.OK)
                AddCustomAsmLinkOptions(selector.AsmArea);
        }

        private void ButtonX_RemoveCustomAsmFunction_Click(object sender, EventArgs e)
        {
            RemoveCustomAsmLinkOptions(curAsmLinkOption);
        }

        private void ButtonX_LoopCustomAsmFunction_CheckedChanged(object sender, EventArgs e)
        {
            SaveCustomAsmLinkOptions();
        }

        private void ButtonX_EditParamInfos_Click(object sender, EventArgs e)
        {
            new BehaviorParameterInfoEditor(curBehav.Config.ParamsInfo).ShowDialog(this);
        }

        private void ButtonItem_DisableGlobaleBehaviorBank_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show(this, BehaviorBankManagerLangRes.Msg_DisableGlobalBehaviorBank, BehaviorBankManagerLangRes.Msg_DisableGlobalBehaviorBank_Titel, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DisableGlobalBehaviorBank();
                Close();
            }
        }
    }
}