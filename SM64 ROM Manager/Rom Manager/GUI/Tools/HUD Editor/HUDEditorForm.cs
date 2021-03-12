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
        private readonly List<HUDProfile> predefinedProfiles = new();

        // C o n s t r u c t o r

        public HUDEditorForm(RomManager romManager)
        {
            this.romManager = romManager;
            InitializeComponent();
            UpdateAmbientColors();
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

        private void UpdatePaintingObject(PaintingObject po, HUDItem item)
        {
            po.Location = item.Location.Value;
            po.HardcodedLocation = item.DataInfo.CanSetLocation;
            po.Size = item.DataInfo.ItemSize.Value;

            // Check for symbol and set image
            //if ()
            //{
            //    // ...
            //    po.Type |= PaintingObjectType.Picture;
            //}
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

        // G U I

    }
}
