﻿using System;
using System.Collections.Generic;
using System.Data;
using global::System.IO;
using System.Linq;
using global::System.Numerics;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib;
using global::SM64Lib.Trajectorys;
using Z.Collections.Extensions;
using Z.Core.Extensions;
using DevComponents.AdvTree;
using ColumnHeader = DevComponents.AdvTree.ColumnHeader;

namespace SM64_ROM_Manager
{
    public partial class TrajectoryEditor
    {
        public TrajectoryEditor(RomManager rommgr)
        {
            base.Shown += TrajectoryEditor_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
            this.rommgr = rommgr;
        }

        private RomManager rommgr = null;
        private Trajectories trajectories = new Trajectories();
        private bool loadingNodeData = false;

        public Trajectory SelectedTrajectory
        {
            get
            {
                ComboItem ci = (ComboItem)ComboBoxEx1.SelectedItem;
                if (ci is object)
                {
                    return (Trajectory)ci.Tag;
                }
                else
                {
                    return null;
                }
            }
        }

        private void TrajectoryEditor_Shown(object sender, EventArgs e)
        {
            var data = rommgr.GetBinaryRom(FileAccess.Read);
            trajectories.ReadTrajectories(data);
            data.Close();
            LoadTrajectoriesList();
        }

        private void ButtonX5_Click(object sender, EventArgs e)
        {
            var data = rommgr.GetBinaryRom(FileAccess.ReadWrite);
            trajectories.WriteTrajectories(data);
            data.Close();
            General.PatchClass.UpdateChecksum(rommgr.RomFile);
        }

        private void LoadTrajectoriesList(Trajectory tracToSelect = null)
        {
            ComboBoxEx1.SuspendLayout();
            ButtonX8.SuspendLayout();
            ComboBoxEx1.Items.Clear();
            ButtonX8.SubItems.Clear();

            var namesWeHad = new List<TrajectoryName>() { TrajectoryName.None };
            ComboItem itemToSelect = null;

            foreach (Trajectory trac in trajectories)
            {
                var ci = new ComboItem();
                ci.Tag = trac;
                ci.Text = GetTextOfTrajectoryName(trac.Name);
                if (string.IsNullOrEmpty(ci.Text))
                    ci.Text = $"Trajectory with {trac.Points.Count} Nodes";
                ComboBoxEx1.Items.Add(ci);
                if (!namesWeHad.Contains(trac.Name))
                    namesWeHad.Add(trac.Name);
                if (itemToSelect == null && trac == tracToSelect)
                    itemToSelect = ci;
            }

            foreach (TrajectoryName name in Enum.GetValues(typeof(TrajectoryName)))
            {
                if (!namesWeHad.Contains(name))
                {
                    var bi = new ButtonItem();
                    bi.Text = GetTextOfTrajectoryName(name);
                    bi.Tag = name;
                    bi.Click += ButtonItem_AddNewTrajectory_Click;
                    ButtonX8.SubItems.Add(bi);
                }
            }

            if (itemToSelect != null)
                ComboBoxEx1.SelectedItem = itemToSelect;
            else if (ComboBoxEx1.Items.Count > 0)
                ComboBoxEx1.SelectedIndex = 0;

            ButtonX8.Enabled = ButtonX8.SubItems.Count > 0;

            ComboBoxEx1.ResumeLayout();
            ButtonX8.ResumeLayout();
        }

        private string GetTextOfTrajectoryName(TrajectoryName name)
        {
            switch (name)
            {
                case TrajectoryName.KoopaTheQuick1:
                    return "Koopa The Quick 1";
                case TrajectoryName.KoopaTheQuick2:
                    return "Koopa The Quick 2";
                case TrajectoryName.RacingPenguin:
                    return "Racing Penguin";
                case TrajectoryName.SnowmansBottom:
                    return "Snowmans Bottom";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_00:
                    return "Plattform On Tracks Behavior (B. Param 00)";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_01:
                    return "Plattform On Tracks Behavior (B. Param 01)";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_02:
                    return "Plattform On Tracks Behavior (B. Param 02)";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_03:
                    return "Plattform On Tracks Behavior (B. Param 03)";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_04:
                    return "Plattform On Tracks Behavior (B. Param 04)";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_05:
                    return "Plattform On Tracks Behavior (B. Param 05)";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_06:
                    return "Plattform On Tracks Behavior (B. Param 06)";
                case TrajectoryName.PlatformOnTracksBehavior_BParam2_07:
                    return "Plattform On Tracks Behavior (B. Param 07)";
                case TrajectoryName.MetalBallsGenerators_BParam2_00:
                    return "Metal Ball Generator (B. Param 00)";
                case TrajectoryName.MetalBallsGenerators_BParam2_01:
                    return "Metal Ball Generator (B. Param 01)";
                case TrajectoryName.MetalBallsGenerators_BParam2_02:
                    return "Metal Ball Generator (B. Param 02)";
                case TrajectoryName.MiniMetalBallGenerator_BParam2_03:
                    return "Mini Metal Ball Generator (B. Param 03)";
                case TrajectoryName.MiniMetalBallGenerator_BParam2_04:
                    return "Mini Metal Ball Generator (B. Param 04)";
                case TrajectoryName.MipsTheRabbit:
                    return "Mips The Rabbit";
                default:
                    return "";
            }
        }

        private void ButtonItem_AddNewTrajectory_Click(object sender, EventArgs e)
        {
            var name = (TrajectoryName)((ButtonItem)sender).Tag;
            var trac = new Trajectory();
            trac.Name = name;
            trajectories.Add(trac);
            LoadTrajectoriesList(trac);
        }

        private void ComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxEx1.SelectedIndex > -1)
            {
                LoadTrajectory(SelectedTrajectory);
            }
        }

        private void LoadTrajectory(Trajectory trac)
        {
            advTree1.BeginUpdate();
            advTree1.Nodes.Clear();

            foreach (Vector3 v in trac.Points)
            {
                var lvi = new Node(string.Empty);
                lvi.Cells.Add(new Cell(v.X.ToString()));
                lvi.Cells.Add(new Cell(v.Y.ToString()));
                lvi.Cells.Add(new Cell(v.Z.ToString()));
                lvi.Tag = v;
                advTree1.Nodes.Add(lvi);
            }

            if (advTree1.Nodes.Count > 0)
                advTree1.SelectedNode = advTree1.Nodes[0];

            advTree1.EndUpdate();
        }

        private void LoadNodeData(Vector3 v)
        {
            loadingNodeData = true;
            IntegerInput1.Value = Conversions.ToInteger(v.X);
            IntegerInput2.Value = Conversions.ToInteger(v.Y);
            IntegerInput3.Value = Conversions.ToInteger(v.Z);
            loadingNodeData = false;
        }

        private void IntegerInput1_ValueChanged(object sender, EventArgs e)
        {
            if (!loadingNodeData)
            {
                var v = new Vector3(IntegerInput1.Value, IntegerInput2.Value, IntegerInput3.Value);
                foreach (Node n in advTree1.SelectedNodes)
                {
                    SelectedTrajectory.Points[n.Index] = v;
                    n.Tag = v;
                    n.Cells[1].Text = Conversions.ToString(v.X);
                    n.Cells[2].Text = Conversions.ToString(v.Y);
                    n.Cells[3].Text = Conversions.ToString(v.Z);
                }
            }
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            if (SelectedTrajectory is object)
            {
                var v = Vector3.Zero;
                SelectedTrajectory.Points.Add(v);
                var lvi = new Node(string.Empty);
                lvi.Cells.Add(new Cell(v.X.ToString()));
                lvi.Cells.Add(new Cell(v.Y.ToString()));
                lvi.Cells.Add(new Cell(v.Z.ToString()));
                lvi.Tag = v;
                advTree1.Nodes.Add(lvi);
                lvi.EnsureVisible();
                advTree1.SelectedNode = lvi;
            }
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            if (SelectedTrajectory is object)
            {
                foreach (Node n in advTree1.SelectedNodes.ToArray())
                {
                    SelectedTrajectory.Points.RemoveAt(n.Index);
                    n.Remove();
                }
            }
        }

        private void ButtonX6_Click(object sender, EventArgs e)
        {
            MoveNode(-1);
        }

        private void ButtonX7_Click(object sender, EventArgs e)
        {
            MoveNode(1);
        }

        private void MoveNode(int additor)
        {
            if (additor != 0 && SelectedTrajectory is object)
            {
                advTree1.BeginUpdate();
                foreach (Node n in advTree1.SelectedNodes.ToArray())
                {
                    int nodeIndex = n.Index;
                    int newIndex = nodeIndex + additor;
                    if (newIndex >= 0 && newIndex < SelectedTrajectory.Points.Count)
                    {
                        SelectedTrajectory.Points.RemoveAt(nodeIndex);
                        SelectedTrajectory.Points.Insert(newIndex, (Vector3)n.Tag);
                        n.Remove();
                        advTree1.Nodes.Insert(newIndex, n);
                        advTree1.SelectedNode = n;
                    }
                }

                advTree1.EndUpdate();
            }
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            if (SelectedTrajectory is object)
            {
                var sfd = new SaveFileDialog()
                {
                    Filter = "Textfile (*.txt)|*.txt",
                    FileName = SelectedTrajectory.Name.ToString() + ".txt"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sw = new StreamWriter(sfd.FileName);
                    foreach (Vector3 v in SelectedTrajectory.Points)
                        sw.WriteLine($"{v.X.ToString()}, {v.Y.ToString()}, {v.Z.ToString()}");
                    sw.Close();
                }
            }
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            if (SelectedTrajectory is object)
            {
                var ofd = new OpenFileDialog() { Filter = "Textfile (*.txt)|*.txt" };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(ofd.FileName);
                    SelectedTrajectory.Points.Clear();
                    while (!sr.EndOfStream)
                    {
                        string curLine = sr.ReadLine().Trim();
                        if (curLine is object)
                        {
                            var parts = curLine.Split(",");
                            if (parts.Length >= 3)
                            {
                                var v = new Vector3(Convert.ToSingle(parts[0].Trim()), Convert.ToSingle(parts[1].Trim()), Convert.ToSingle(parts[2].Trim()));
                                SelectedTrajectory.Points.Add(v);
                            }
                        }
                    }

                    sr.Close();
                    LoadTrajectory(SelectedTrajectory);
                }
            }
        }

        private void advTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            if (advTree1.SelectedNode is object)
                LoadNodeData((Vector3)advTree1.SelectedNode.Tag);
        }
    }
}