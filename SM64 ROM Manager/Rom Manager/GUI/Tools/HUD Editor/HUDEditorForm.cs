using DevComponents.DotNetBar;
using Pilz.UI;
using SM64_ROM_Manager.Publics.My.Resources;
using SM64Lib;
using SM64Lib.HUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class HUDEditorForm : OfficeForm
    {
        // F i e l d s

        private readonly RomManager romManager;
        private bool simplyfiedMode = false;
        private HUDProfile curProfile = null;
        private HUDElement curElement = null;
        private readonly List<HUDProfile> predefinedProfiles = new();
        private bool finishedInit = false;
        private bool loadingItemData = false;

        // C o n s t r u c t o r

        public HUDEditorForm(RomManager romManager)
        {
            this.romManager = romManager;
            InitializeComponent();
            UpdateAmbientColors();
            finishedInit = true;
        }

        // F e a t u r e s

        private void LoadPredefinedProfilesList()
        {
            predefinedProfiles.Clear();

            foreach (var filePath in Directory.GetFiles(Publics.General.MyHUDProfilesPath))
            {
                var profile = HUDProfile.LoadFrom(filePath);
                predefinedProfiles.Add(profile);
            }

            LoadPredefinedProfilesListToGUI();
        }

        private void LoadPredefinedProfilesListToGUI()
        {
            ButtonItem_PredefinedProfiles.SubItems.Clear();

            foreach (var profile in predefinedProfiles)
            {
                var item = new ButtonItem
                {
                    Text = profile.ProfileName,
                    Tag = profile
                };

                item.Click += ButtonItem_PredefinedProfile_Click;

                ButtonItem_PredefinedProfiles.SubItems.Add(item);
            }
        }

        private void LoadProfile(HUDProfile profile)
        {
            curProfile = profile;
            LoadData(profile);
            LoadPaintingObjects(profile);
        }

        private void LoadProfileFromFile()
        {
            var ofd_LoadHUDProfileFromFile = new OpenFileDialog
            {
                Filter = FileDialogFilters.JsonFiles
            };
            if (ofd_LoadHUDProfileFromFile.ShowDialog(this) == DialogResult.OK)
            {
                var profile = HUDProfile.LoadFrom(ofd_LoadHUDProfileFromFile.FileName);
                LoadProfile(profile);
            }
        }

        private void UnloadCurrentProfile()
        {
            curProfile = null;
            paintingControl1.PaintingObjects.Clear();
        }

        private void LoadData(HUDProfile profile)
        {
            var data = romManager.GetBinaryRom(FileAccess.Read);
            profile.LoadData(data);
            data.Close();
        }

        private void SaveData(HUDProfile profile)
        {
            var data = romManager.GetBinaryRom(FileAccess.ReadWrite);
            profile.SaveData(data);
            data.Close();

            // Update checksum
            SM64Lib.General.PatchClass.UpdateChecksum(romManager.RomFile);
        }

        private void ShowItemData(HUDItem item)
        {
            var isNotNull = item is object;
            layoutControl1.Enabled = isNotNull;

            if (isNotNull)
            {
                var hasLocation = item.Location.HasValue;
                var hasVisible = item.Visible.HasValue;
                loadingItemData = true;

                if (hasLocation)
                {
                    IntegerInput_LocationX.Value = item.Location.Value.X;
                    IntegerInput_LocationY.Value = item.Location.Value.Y;
                    IntegerInput_LocationX.Enabled = item.DataInfo.CanSetLocation;
                    IntegerInput_LocationY.Enabled = item.DataInfo.CanSetLocation;
                }

                if (hasVisible)
                {
                    CheckBoxX_Visible.Checked = item.Visible.Value;
                    CheckBoxX_Visible.Enabled = item.DataInfo.CanSetVisible;
                }

                layoutControlItem_LocationX.Visible = hasLocation;
                layoutControlItem_LocationY.Visible = hasLocation;
                layoutControlItem_Visible.Visible = hasVisible;
                layoutControlItem_SnapToGrid.Visible = item.DataInfo.CanSetLocation;
                layoutControl1.Refresh();

                loadingItemData = false;
            }
        }

        private void TakeoverItemLocation(HUDElement item, Point location)
        {
            if (item is HUDItem hudItem && hudItem.DataInfo.CanSetLocation)
                hudItem.Location = location;
            else if (item is HUDGroup hudGroup)
                hudGroup.Location = location;
        }

        private void TakeoverItemVisible(HUDElement item, bool value)
        {
            if (item.DataInfo.CanSetVisible)
                item.Visible = value;
        }

        private void ResetItemLocation(HUDItem item)
        {
            if (item.DataInfo.CanSetLocation && item.DataInfo.LocationDefaultValue.HasValue)
                item.Location = item.DataInfo.LocationDefaultValue;
        }

        // P a i n t i n g O b j e c t s

        private void LoadPaintingObjects(HUDProfile profile)
        {
            var objects = new List<PaintingObject>();
            var curPath = new Stack<string>();
            var groupsStack = new Stack<HUDGroup>();
            var knownGroups = new Dictionary<HUDGroup, PaintingObject>();

            void checkGroups(IEnumerable<HUDGroup> groups)
            {
                foreach (var group in groups)
                    checkGroup(group);
            }
            void checkGroup(HUDGroup group)
            {
                groupsStack.Push(group);
                curPath.Push(group.Name);

                var obj = GetPaintingObject(group);
                objects.Add(obj);
                knownGroups.Add(group, obj);

                checkItems(group.Items);

                curPath.Pop();
                groupsStack.Pop();
            }
            void checkItems(IEnumerable<HUDItem> items)
            {
                foreach (var item in items)
                    checkItem(item);
            }
            void checkItem(HUDItem item)
            {
                curPath.Push(item.Name);
                
                var obj = GetPaintingObject(item);
                obj.Name = string.Join(".", curPath.ToArray());
                objects.Add(obj);

                var curGroup = groupsStack.Peek();
                knownGroups[curGroup].PinnedObjects.Add(obj);

                curPath.Pop();
            }

            // Create PaintingObjects
            checkGroups(profile.Groups);

            // Prepair for simplyfied mode
            PrepairPaintingControlsForSimplyfiedMode(objects, simplyfiedMode);

            // Add objects to GUI
            paintingControl1.SuspendDrawing();
            paintingControl1.PaintingObjects.Clear();
            paintingControl1.PaintingObjects.AddRange(objects);
            paintingControl1.ResumeDrawing();
        }

        private PaintingObject FindPaintingObject(HUDElement item)
        {
            PaintingObject found = null;

            foreach (var po in paintingControl1.PaintingObjects)
            {
                if (found == null && po.Tag == item)
                    found = po;
            }

            return found;
        }

        private PaintingObject GetBasePaintingObject(object obj)
        {
            var po = new PaintingObject
            {
                Tag = obj,
                Type = PaintingObjectType.Rectangle,
                EnableFill = false,
                EnableOutline = true,
                OutlineColor = Color.Blue,
                OutlineThicknes = 1,
                HardcodedSize = true,
                EnableResize = false
            };
            
            return po;
        }

        private void FindAndUpdatePaintingObject(HUDElement element)
        {
            var po = FindPaintingObject(curElement);
            UpdatePaintingObject(po, element);
        }

        private void UpdatePaintingObject(PaintingObject po)
        {
            if (po.Tag is HUDItem)
                UpdatePaintingObject(po, (HUDItem)po.Tag);
            if (po.Tag is HUDGroup)
                UpdatePaintingObject(po, (HUDGroup)po.Tag);
        }

        private PaintingObject GetPaintingObject(HUDItem item)
        {
            var po = GetBasePaintingObject(item);
            UpdatePaintingObject(po, item);
            return po;
        }

        private void UpdatePaintingObject(PaintingObject po, HUDElement item)
        {
            if (item is HUDItem hudItem)
            {
                po.Location = hudItem.Location.Value;
                po.HardcodedLocation = hudItem.DataInfo.CanSetLocation;
                po.Size = hudItem.DataInfo.ItemSize.Value;

                // Check for symbol and set image
                //if ()
                //{
                //    // ...
                //    po.Type |= PaintingObjectType.Picture;
                //}
            }

            if (item.Visible ?? true)
                po.OutlineDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else
                po.OutlineDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        private PaintingObject GetPaintingObject(HUDGroup group)
        {
            var po = GetBasePaintingObject(group);
            UpdatePaintingObject(po, group);
            return po;
        }

        private void UpdatePaintingObject(PaintingObject po, HUDGroup group)
        {
            po.Location = group.Location;
            po.HardcodedLocation = group.CanSetLocation;
            po.Size = group.Size;
        }

        private void UpdateSelectedPaintingObjects()
        {
            foreach (var po in paintingControl1.SelectedObjects)
                UpdatePaintingObject(po);
            paintingControl1.Refresh();
        }

        private void PrepairPaintingControlsForSimplyfiedMode(IEnumerable<PaintingObject> pos, bool simplyfiedMode)
        {
            foreach (var po in pos)
            {
                if (po.Tag is HUDItem)
                    po.EnableSelection = !simplyfiedMode;
                else if (po.Tag is HUDGroup)
                    po.EnableSelection = simplyfiedMode;
            }
        }

        private void SnapToGrid(PaintingObject po)
        {
            po.ArrangeToGrid();

            if (po.Tag is HUDItem)
                TakeoverItemLocation((HUDItem)po.Tag, new Point((int)po.X, (int)po.Y));
        }

        // G U I   -   F o r m

        private void HUDEditorForm_Shown(object sender, EventArgs e)
        {
            LoadPredefinedProfilesList();
        }

        // G U I   -   M e n u

        private void ButtonItem_PredefinedProfile_Click(object sender, EventArgs e)
        {
            var item = sender as ButtonItem;
            if (item?.Tag is HUDProfile)
                LoadProfile((HUDProfile)item.Tag);
        }

        private void ButtonItem_SaveProfile_Click(object sender, EventArgs e)
        {
            if (curProfile is object)
                SaveData(curProfile);
        }

        private void ButtonItem_LoadFromFile_Click(object sender, EventArgs e)
        {
            LoadProfileFromFile();
        }

        private void ButtonItem_ShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            paintingControl1.GridVisible = ButtonItem_ShowGrid.Checked;
        }

        private void ButtonItem_AutoSnapToGrid_CheckedChanged(object sender, EventArgs e)
        {
            paintingControl1.GridEnabled = ButtonItem_AutoSnapToGrid.Checked;
        }

        private void ButtonItem_SimplyfiedMode_CheckedChanged(object sender, EventArgs e)
        {
            simplyfiedMode = ButtonItem_SimplyfiedMode.Checked;
            if (finishedInit && curProfile is object)
                LoadPaintingObjects(curProfile);
        }

        // G U I   -   E d i t o r s

        private bool CanTakeoverItemData()
        {
            return !loadingItemData && curElement is object;
        }

        private void IntegerInput_Location_ValueChanged(object sender, EventArgs e)
        {
            if (CanTakeoverItemData())
            {
                TakeoverItemLocation(curElement, new Point(IntegerInput_LocationX.Value, IntegerInput_LocationY.Value));
                FindAndUpdatePaintingObject(curElement);
            }
        }

        private void CheckBoxX_Visible_CheckedChanged(object sender, EventArgs e)
        {
            if (CanTakeoverItemData())
            {
                TakeoverItemVisible(curElement, CheckBoxX_Visible.Checked);
                FindAndUpdatePaintingObject(curElement);
            }
        }

        private void ButtonX_SnapToGrid_Click(object sender, EventArgs e)
        {
            foreach (var po in paintingControl1.SelectedObjects)
                SnapToGrid(po);
        }

        // G U I   -   P a i n t i n g C o n t r o l

        private void PaintingControl1_SelectionChanged(object sender, PaintingObjectEventArgs e)
        {
            var po = paintingControl1.SelectedObjects?.FirstOrDefault();
            var item = po?.Tag as HUDItem;
            ShowItemData(item);
        }
    }
}
