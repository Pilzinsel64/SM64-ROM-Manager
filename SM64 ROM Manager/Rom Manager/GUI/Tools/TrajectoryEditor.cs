using System;
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

namespace SM64_ROM_Manager
{
    public partial class TrajectoryEditor
    {
        public TrajectoryEditor(RomManager rommgr)
        {
            base.Shown += TrajectoryEditor_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
            foreach (ColumnHeader c in ListViewEx1.Columns)
                c.TextAlign = HorizontalAlignment.Center;
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

        private void LoadTrajectoriesList()
        {
            ComboBoxEx1.SuspendLayout();
            ButtonX8.SuspendLayout();
            ComboBoxEx1.Items.Clear();
            ButtonX8.SubItems.Clear();
            var namesWeHad = new List<TrajectoryName>() { TrajectoryName.None };
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

            if (ComboBoxEx1.Items.Count > 0)
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
            LoadTrajectoriesList();
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
            ListViewEx1.SuspendLayout();
            ListViewEx1.Items.Clear();
            foreach (Vector3 v in trac.Points)
            {
                var lvi = new ListViewItem(new string[] { "", v.X.ToString(), v.Y.ToString(), v.Z.ToString() });
                lvi.Tag = v;
                ListViewEx1.Items.Add(lvi);
            }

            if (ListViewEx1.Items.Count > 0)
            {
                ListViewEx1.Items[0].Selected = true;
            }

            ListViewEx1.ResumeLayout();
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
                foreach (ListViewItem item in ListViewEx1.SelectedItems)
                {
                    SelectedTrajectory.Points[item.Index] = v;
                    item.Tag = v;
                    item.SubItems[1].Text = Conversions.ToString(v.X);
                    item.SubItems[2].Text = Conversions.ToString(v.Y);
                    item.SubItems[3].Text = Conversions.ToString(v.Z);
                }
            }
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            if (SelectedTrajectory is object)
            {
                var v = Vector3.Zero;
                SelectedTrajectory.Points.Add(v);
                var lvi = new ListViewItem(new string[] { "", v.X.ToString(), v.Y.ToString(), v.Z.ToString() });
                lvi.Tag = v;
                ListViewEx1.Items.Add(lvi);
                lvi.EnsureVisible();
                lvi.Selected = true;
            }
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            if (SelectedTrajectory is object)
            {
                var indicies = new int[ListViewEx1.SelectedItems.Count];
                ListViewEx1.SelectedIndices.CopyTo(indicies, 0);
                foreach (int index in indicies.OrderByDescending(n => n))
                {
                    SelectedTrajectory.Points.RemoveAt(index);
                    ListViewEx1.Items.RemoveAt(index);
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
                ListViewEx1.SuspendLayout();
                var indicies = new int[ListViewEx1.SelectedIndices.Count];
                ListViewEx1.SelectedIndices.CopyTo(indicies, 0);
                foreach (int index in additor < 0 ? indicies.OrderByDescending(n => n) : indicies.OrderBy(n => n))
                {
                    int newIndex = index + additor;
                    if (newIndex >= 0 && newIndex < ListViewEx1.Items.Count)
                    {
                        var item = ListViewEx1.Items[index];
                        ListViewEx1.Items.RemoveAt(index);
                        SelectedTrajectory.Points.RemoveAt(index);
                        ListViewEx1.Items.Insert(newIndex, item);
                        SelectedTrajectory.Points.Insert(newIndex, (Vector3)item.Tag);
                    }
                }

                ListViewEx1.ResumeLayout();
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

        private void ListViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewEx1.SelectedIndices.Count > 0)
            {
                LoadNodeData((Vector3)ListViewEx1.SelectedItems[0].Tag);
            }
        }
    }
}