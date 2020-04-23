using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using global::DevComponents.AdvTree;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.SettingsManager;
using global::SM64Lib.Objects.ObjectBanks.Data;
using SM64Lib.TextValueConverter;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public partial class ObjectBankDataEditor
    {

        // C o n s t r u c t o r

        public ObjectBankDataEditor(ObjectBankDataListCollection obdListCollection)
        {

            // G U I

            this.Shown += ObjectBankDataEditor_Shown;
            ObdListCollection = obdListCollection;

            // Create GUI
            InitializeComponent();
            base.UpdateAmbientColors();
        }

        // E v e n t s

        public event ChangedObjectBankDataCommandEventHandler ChangedObjectBankDataCommand;

        public delegate void ChangedObjectBankDataCommandEventHandler(ObjectBankData obd);

        public event RemovedObjectBankDataEventHandler RemovedObjectBankData;

        public delegate void RemovedObjectBankDataEventHandler(ObjectBankData obd);

        // A u t o m a t i c   P r o p e r t i e s

        public ObjectBankDataListCollection ObdListCollection { get; private set; }

        // F e a t u r e s

        private void BeginTreeUpdate()
        {
            ObdTree.BeginUpdate();
        }

        private void EndTreeUpdate()
        {
            ObdTree.EndUpdate();
        }

        private Node GetSelectedNode()
        {
            return ObdTree.SelectedNode;
        }

        private void ListEverything()
        {
            BeginTreeUpdate();
            ObdTree.Nodes.Clear();
            var nRoot = new Node()
            {
                Text = "Object Bank Data Collection",
                Name = "nRoot",
                Tag = ObdListCollection
            };
            nRoot.Expand();
            foreach (KeyValuePair<byte, ObjectBankDataList> kvp in ObdListCollection)
            {
                var nObdList = new Node()
                {
                    Text = TextValueConverter.TextFromValue(kvp.Key),
                    Tag = kvp,
                    ContextMenu = ButtonItem_CM_ObdList
                };

                // Data
                foreach (ObjectBankData obd in kvp.Value)
                {
                    var nObd = GetNodeFromObd(obd);
                    nObdList.Nodes.Add(nObd);
                }

                nObdList.Expand();
                nRoot.Nodes.Add(nObdList);
            }

            ObdTree.Nodes.Add(nRoot);
            EndTreeUpdate();
        }

        private void AddObjsToNode(Node nObjs, ObjectBankData obd)
        {
            for (int i = 0, loopTo = obd.Objects.Count - 1; i <= loopTo; i++)
            {
                string name = obd.Objects[i];
                var nObj = GetNodeFromObj(name, i, obd);
                nObjs.Nodes.Add(nObj);
            }
        }

        private void AddCmdsToNode(Node nCmds, ObjectBankData obd)
        {
            foreach (ObjectBankDataCommand cmd in obd.Commands)
            {
                var nCmd = GetNodeFromCmd(cmd);
                nCmds.Nodes.Add(nCmd);
            }
        }

        private Node GetNodeFromObd(ObjectBankData obd)
        {
            var nObd = new Node()
            {
                Text = obd.Name,
                Tag = obd,
                ContextMenu = ButtonItem_CM_Obd
            };

            // Object Names
            var nObjs = new Node()
            {
                Text = "Objects",
                Name = "nObjs",
                ContextMenu = ButtonItem_CM_Objs,
                Tag = obd
            };
            AddObjsToNode(nObjs, obd);
            nObd.Nodes.Add(nObjs);

            // Commands
            var nCmds = new Node()
            {
                Text = "Commands",
                Name = "nCmds",
                ContextMenu = ButtonItem_CM_Cmds,
                Tag = obd
            };
            AddCmdsToNode(nCmds, obd);
            nObd.Nodes.Add(nCmds);
            return nObd;
        }

        private Node GetNodeFromObj(string name, int index, ObjectBankData obd)
        {
            var nObj = new Node()
            {
                Text = name,
                Tag = new object[] { obd, index },
                ContextMenu = ButtonItem_CM_Obj
            };
            return nObj;
        }

        private Node GetNodeFromCmd(ObjectBankDataCommand cmd)
        {
            var nCmd = new Node()
            {
                Text = $"<font face=\"Consolas\">{SM64Lib.General.CommandByteArrayToString(cmd.Command)}</font>",
                Tag = cmd,
                ContextMenu = ButtonItem_CM_Cmd
            };
            nCmd.NodeDoubleClick += this.CmdNodeDoubleClick;
            return nCmd;
        }

        private void RemoveObdList(Node nObdList)
        {
            var nRoot = nObdList.Parent;
            KeyValuePair<byte, ObjectBankDataList> kvp = (KeyValuePair<byte, ObjectBankDataList>)nObdList.Tag;
            ObjectBankDataListCollection obdListCollection = (ObjectBankDataListCollection)nRoot.Tag;

            // Remove list
            obdListCollection.Remove(kvp.Key);

            // Remove node
            BeginTreeUpdate();
            nRoot.Nodes.Remove(nObdList);
            EndTreeUpdate();
        }

        private void AddObd(Node nObdList)
        {
            var input = new ValueInputDialog();
            input.ValueTextBox.Text = "New Object Bank Data";
            if (input.ShowDialog() == DialogResult.OK)
            {
                ObjectBankDataList obdList = ((KeyValuePair<byte, ObjectBankDataList>)nObdList.Tag).Value;
                string name = input.ValueTextBox.Text.Trim();
                var obd = new ObjectBankData(name);
                var nObd = GetNodeFromObd(obd);

                // Add object
                obdList.Add(obd);

                // Add node
                BeginTreeUpdate();
                nObdList.Nodes.Add(nObd);
                nObdList.Expand();
                EndTreeUpdate();
            }
        }

        private void RemoveObd(Node nObd)
        {
            var nObdList = nObd.Parent;
            KeyValuePair<byte, ObjectBankDataList> kvp = (KeyValuePair<byte, ObjectBankDataList>)nObdList.Tag;
            ObjectBankData obd = (ObjectBankData)nObd.Tag;

            // Remove list
            kvp.Value.Remove(obd);

            // Remove node
            BeginTreeUpdate();
            nObdList.Nodes.Remove(nObd);
            EndTreeUpdate();

            // Raise event
            RemovedObjectBankData?.Invoke(obd);
        }

        private void AddObj(Node nObjs)
        {
            var input = new ValueInputDialog();
            input.ValueTextBox.Text = "New Object";
            if (input.ShowDialog() == DialogResult.OK)
            {
                ObjectBankData obd = (ObjectBankData)nObjs.Tag;
                string name = input.ValueTextBox.Text.Trim();
                int index = obd.Objects.Count;
                var nObj = GetNodeFromObj(name, index, obd);

                // Add object
                obd.Objects.Add(name);

                // Add node
                BeginTreeUpdate();
                nObjs.Nodes.Add(nObj);
                nObjs.Expand();
                EndTreeUpdate();
            }
        }

        private void RemoveObj(Node nObj)
        {
            var nObjs = nObj.Parent;
            object[] arr = nObj.Tag as object[];
            ObjectBankData obd = (ObjectBankData)arr[0];
            var list = obd.Objects;
            int index = Conversions.ToInteger(arr[1]);

            // Remove from list
            list.RemoveAt(index);

            // Re-add object nodes
            BeginTreeUpdate();
            nObjs.Nodes.Clear();
            AddObjsToNode(nObjs, obd);
            EndTreeUpdate();
        }

        private void AddCmd(Node nCmds)
        {
            var bytesStartCount = default(int);
            bool allowOpenHexEditor = true;

            // Set start bytes count
            if (General.GetCurrentHexEditMode() == HexEditModes.BuildInHexEditor)
            {
                var valueInputDialog = new ValueInputDialog();
                valueInputDialog.InfoLabel.Text = "Count of Bytes";
                valueInputDialog.ValueTextBox.Text = Conversions.ToString(8);
                if (valueInputDialog.ShowDialog() == DialogResult.OK)
                {
                    bytesStartCount = TextValueConverter.ValueFromText(valueInputDialog.ValueTextBox.Text);
                }

                allowOpenHexEditor = bytesStartCount > 0;
            }
            else
            {
                bytesStartCount = 0;
            }

            // Create Buffer
            var cmdBuf = new byte[bytesStartCount];

            // Create new
            if (allowOpenHexEditor)
            {
                General.OpenHexEditor(ref cmdBuf);
            }

            if (cmdBuf?.Any() == true)
            {
                ObjectBankData obd = (ObjectBankData)nCmds.Tag;
                var cmd = new ObjectBankDataCommand(cmdBuf);
                var nCmd = GetNodeFromCmd(cmd);

                // Add cmd
                obd.Commands.Add(cmd);

                // Add node
                BeginTreeUpdate();
                nCmds.Nodes.Add(nCmd);
                nCmds.Expand();
                EndTreeUpdate();

                // Raise event
                ChangedObjectBankDataCommand?.Invoke(obd);
            }
        }

        private void EditCmd(Node nCmd)
        {
            var nCmds = nCmd.Parent;
            ObjectBankData obd = (ObjectBankData)nCmds.Tag;
            ObjectBankDataCommand cmd = (ObjectBankDataCommand)nCmd.Tag;

            // Edit cmd
            var argbuffer = cmd.Command;
            General.OpenHexEditor(ref argbuffer);
            cmd.Command = argbuffer;

            // Update ObdTree
            nCmd.Text = $"<font face=\"Consolas\">{SM64Lib.General.CommandByteArrayToString(cmd.Command)}</font>";
            ObdTree.Refresh();

            // Raise event
            ChangedObjectBankDataCommand?.Invoke(obd);
        }

        private void RemoveCmd(Node nCmd)
        {
            var nCmds = nCmd.Parent;
            ObjectBankData obd = (ObjectBankData)nCmds.Tag;
            ObjectBankDataCommand cmd = (ObjectBankDataCommand)nCmd.Tag;

            // Remove Cmd
            obd.Commands.Remove(cmd);

            // Remove Node
            BeginTreeUpdate();
            nCmds.Nodes.Remove(nCmd);
            EndTreeUpdate();

            // Raise event
            ChangedObjectBankDataCommand?.Invoke(obd);
        }

        private void ObjectBankDataEditor_Shown(object sender, EventArgs e)
        {
            ListEverything();
        }

        private void ObdTree_BeforeCellEdit(object sender, CellEditEventArgs e)
        {
            var tag = e.Cell.Tag;
            if (tag is null || tag is ObjectBankDataCommand || tag is KeyValuePair<byte, ObjectBankDataList> || new[] { "nObjs", "nCmds" }.Contains(e.Cell.Name))
            {
                e.Cancel = true;
            }
        }

        private void ObdTree_AfterCellEdit(object sender, CellEditEventArgs e)
        {
            var tag = e.Cell.Tag;
            if (tag is object[])
            {
                object[] arr = (object[])tag;
                if (arr.Length == 2 && arr[0] is ObjectBankData && arr[1] is int)
                {
                    ObjectBankData obd = (ObjectBankData)arr[0];
                    int index = Conversions.ToInteger(arr[1]);
                    obd.Objects[index] = e.NewText.Trim();
                }
            }
            else if (tag is ObjectBankData)
            {
                ObjectBankData obd = (ObjectBankData)tag;
                obd.Name = e.NewText.Trim();
            }
        }

        private void CmdNodeDoubleClick(object sender, EventArgs e)
        {
            EditCmd((Node)sender);
        }

        private void ButtonItem_RemoveObj_Click(object sender, EventArgs e)
        {
            RemoveObj(GetSelectedNode());
        }

        private void ButtonItem_RemoveCmd_Click(object sender, EventArgs e)
        {
            RemoveCmd(GetSelectedNode());
        }

        private void ButtonItem_RemoveObd_Click(object sender, EventArgs e)
        {
            RemoveObd(GetSelectedNode());
        }

        private void ButtonItem_RemoveObdList_Click(object sender, EventArgs e)
        {
            RemoveObdList(GetSelectedNode());
        }

        private void ButtonItem_AddObj_Click(object sender, EventArgs e)
        {
            AddObj(GetSelectedNode());
        }

        private void ButtonItem_AddCmd_Click(object sender, EventArgs e)
        {
            AddCmd(GetSelectedNode());
        }

        private void ButtonItem_AddObd_Click(object sender, EventArgs e)
        {
            AddObd(GetSelectedNode());
        }
    }
}