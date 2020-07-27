using System;
using System.Collections.Generic;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.S3DFileParser;
using global::SM64Lib;
using SM64Lib.TextValueConverter;
using Z.Collections.Extensions;
using SM64Lib.Objects.ModelBanks;

namespace SM64_ROM_Manager
{
    public partial class ModelBankManager
    {

        // C o n s t r u c t o r s

        public ModelBankManager(RomManager rommgr, CustomModelBank objBank)
        {
            this.Shown += CustomBankManager_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
            LayoutGroups_Enabled = false;
            this.rommgr = rommgr;
            this.objBank = objBank;
        }

        // E v e n t s

        public event EventHandler ObjectAdded;
        public event EventHandler ObjectRemoved;

        // P r i v a t e   M e m b e r s

        private RomManager rommgr;
        private CustomModelBank objBank;
        private CustomModel curObj = null;
        private readonly Dictionary<SM64Lib.Model.Fast3D.Fast3DBuffer, object> knownVisualMaps = new Dictionary<SM64Lib.Model.Fast3D.Fast3DBuffer, object>();
        private readonly Dictionary<SM64Lib.Model.Collision.CollisionMap, object> knownCollisionMaps = new Dictionary<SM64Lib.Model.Collision.CollisionMap, object>();

        // P r i v a t e   P r o p e r t i e s

        private bool LayoutGroups_Enabled
        {
            set
            {
                TextBoxX_ModelID.Enabled = value;
                TextBoxX_Name.Enabled = value;
                LabelX_CollisionPointerDestinationsCount.Enabled = value;
                ButtonX_EditCollisionPointerDestinations.Enabled = value;
                ButtonX_ImportModel.Enabled = value;
                ButtonX_RemoveObject.Enabled = value;
            }
        }

        // F e a t u r e s

        private void LoadList()
        {
            ItemListBox1.SuspendLayout();
            ItemListBox1.Items.Clear();
            foreach (CustomModel obj in objBank.Models)
                AddItemToList(obj);
            ItemListBox1.ResumeLayout();
            ItemListBox1.Refresh();
        }

        private string TextForButtonItem(CustomModel obj)
        {
            string txt = $"Model-ID: {TextValueConverter.TextFromValue(obj.ModelID, charCount: 3)}";
            if (!string.IsNullOrEmpty(obj.Config.Name))
            {
                txt += $" - {obj.Config.Name}";
            }

            return txt;
        }

        private ButtonItem AddItemToList(CustomModel obj)
        {
            var item = new ButtonItem()
            {
                Text = TextForButtonItem(obj),
                Tag = obj
            };
            item.CheckedChanged += (sender, e) => { if (((ButtonItem)sender).Checked) LoadCustomObject((CustomModel)((ButtonItem)sender).Tag); };
            item.MouseUp += (sender, e) => { if (e.Button == MouseButtons.Right) { bool hasCollision = obj.Model.Collision is object; ButtonItem_ImportCollision.Enabled = hasCollision; ButtonItem_RemoveCollision.Enabled = hasCollision; ButtonItem_ShowCollision.Enabled = hasCollision; ButtonItem_CopyCollisionPointer.Enabled = hasCollision; CM_Object.Popup(Cursor.Position); } };
            ItemListBox1.Items.Add(item);
            return item;
        }

        private void LoadCustomObject(CustomModel obj)
        {
            curObj = obj;
            LayoutGroups_Enabled = true;
            TextBoxX_ModelID.Text = TextValueConverter.TextFromValue(obj.ModelID);
            TextBoxX_Name.Text = obj.Config.Name;
            LabelX_CollisionPointerDestinationsCount.Text = Conversions.ToString(obj.Config.CollisionPointerDestinations.Count);
        }

        private void CreateCustomObject()
        {
            var obj = new CustomModel();
            obj.Config.ID.Generate();
            obj.GenerateNewGeolayout();
            ButtonItem item;
            if (ImportNewModel(obj))
            {
                objBank.Models.Add(obj);
                item = AddItemToList(obj);
                item.RaiseClick();
                ObjectAdded?.Invoke(this, new EventArgs());
            }
        }

        private bool ImportNewModel(CustomModel obj, bool checkVisualMap = true, bool checkCollision = true)
        {
            if (obj is object)
            {
                var resMdl = ModelConverterGUI.PublicFunctions.GetModelViaModelConverter(obj.Model is object, true, checkVisualMap || obj.Model is null, checkCollision);
                if (resMdl is object)
                {
                    if (obj.Model is null || resMdl.Value.hasCollision && resMdl.Value.hasVisualMap)
                    {
                        obj.Model = resMdl?.mdl;
                        RemoveKnownMaps(obj);
                    }
                    else if (resMdl.Value.hasCollision)
                    {
                        RemoveKnownCollisionMap(obj);
                        obj.Model.Collision = resMdl?.mdl.Collision;
                    }
                    else if (resMdl.Value.hasVisualMap)
                    {
                        RemoveKnownVisualMap(obj);
                        obj.Model.Fast3DBuffer = resMdl?.mdl.Fast3DBuffer;
                    }

                    return true;
                }
            }

            return false;
        }

        private void RemoveCollision(CustomModel curObj)
        {
            curObj.Model.Collision = null;
        }

        private void RemoveKnownVisualMap(CustomModel curObj)
        {
            knownVisualMaps.RemoveIfContainsKey(curObj.Model.Fast3DBuffer);
        }

        private void RemoveKnownCollisionMap(CustomModel curObj)
        {
            if (curObj.Model.Collision is object)
            {
                knownCollisionMaps.RemoveIfContainsKey(curObj.Model.Collision);
            }
        }

        private void RemoveKnownMaps(CustomModel curObj)
        {
            RemoveKnownVisualMap(curObj);
            RemoveKnownCollisionMap(curObj);
        }

        private void RemoveCurObject()
        {
            RemoveKnownMaps(curObj);
            objBank.Models.Remove(curObj);
            var itr = new List<BaseItem>();
            foreach (ButtonItem item in ItemListBox1.Items)
            {
                if (item.Tag == curObj)
                {
                    itr.Add(item);
                }
            }

            foreach (var item in itr)
                ItemListBox1.Items.Remove(item);
            LayoutGroups_Enabled = false;
            curObj = null;
            ObjectRemoved?.Invoke(this, new EventArgs());
        }

        private void UpdateButtonItems()
        {
            ButtonItem selItem = (ButtonItem)ItemListBox1.SelectedItem;
            void updateItem(ButtonItem btn) { if (btn is object) { btn.Text = TextForButtonItem((CustomModel)btn.Tag); } };
            if (selItem is object)
            {
                updateItem(selItem);
            }
            else
            {
                foreach (ButtonItem btn in ItemListBox1.Items)
                    updateItem(btn);
            }

            ItemListBox1.Refresh();
        }

        private void ShowModel(Object3D obj)
        {
            var preview = new ModelConverterGUI.ModelPreviewOfficeForm(obj, 1);
            preview.Show();
        }

        private void ShowVisualMap(CustomModel customObj)
        {
            Object3D obj;
            var key = customObj.Model.Fast3DBuffer;
            if (knownVisualMaps.ContainsKey(key))
            {
                obj = (Object3D)knownVisualMaps[key];
            }
            else
            {
                obj = General.LoadVisualMapAsObject3D(rommgr, curObj.Model.Fast3DBuffer);
                knownVisualMaps.Add(key, obj);
            }

            ShowModel(obj);
        }

        private void ShowCollision(CustomModel customObj)
        {
            Object3D obj;
            var key = customObj.Model.Collision;
            if (knownCollisionMaps.ContainsKey(key))
            {
                obj = (Object3D)knownCollisionMaps[key];
            }
            else
            {
                obj = curObj.Model.Collision.ToObject3D();
                knownCollisionMaps.Add(key, obj);
            }

            ShowModel(obj);
        }

        private void CopyCollisionPointer(CustomModel customObj)
        {
            Clipboard.SetText(TextValueConverter.TextFromValue(customObj.CollisionPointer));
        }

        private void CustomBankManager_Shown(object sender, EventArgs e)
        {
            LoadList();
        }

        private void EditObjectShadow()
        {
            var editor = new ObjectShadowEditor(curObj.Geolayout.ObjectShadow);
            if (editor.ShowDialog(this) == DialogResult.OK)
                curObj.Geolayout.ObjectShadow.Enabled = true;
        }

        private void RemoveObjectShadow()
        {
            curObj.Geolayout.ObjectShadow.Enabled = false;
        }

        // G U I

        private void TextBoxX_ModelID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                curObj.ModelID = Conversions.ToByte(TextValueConverter.ValueFromText(TextBoxX_ModelID.Text));
                UpdateButtonItems();
            }
            catch (Exception ex)
            {
            }
        }

        private void TextBoxX_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                curObj.Config.Name = TextBoxX_Name.Text.Trim();
                UpdateButtonItems();
            }
            catch (Exception ex)
            {
            }
        }

        private void ButtonX_EditCollisionPointerDestinations_Click(object sender, EventArgs e)
        {
            var editor = new AddressListEditor() { AddressList = curObj.Config.CollisionPointerDestinations };
            editor.ShowDialog();
            LoadCustomObject(curObj);
        }

        private void ButtonItem_RemoveObject_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Do you realy want to remove this custom object? You will not be able to restore it.", "Remove Custom Object", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RemoveCurObject();
            }
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            CreateCustomObject();
        }

        private void ButtonItem_ShowVisualMap_Click(object sender, EventArgs e)
        {
            ShowVisualMap(curObj);
        }

        private void ButtonItem_ShowCollision_Click(object sender, EventArgs e)
        {
            ShowCollision(curObj);
        }

        private void ButtonItem_ImportModell_Click(object sender, EventArgs e)
        {
            ImportNewModel(curObj);
        }

        private void ButtonItem_ImportVisualMap_Click(object sender, EventArgs e)
        {
            ImportNewModel(curObj, checkCollision: false);
        }

        private void ButtonItem_ImportCollision_Click(object sender, EventArgs e)
        {
            ImportNewModel(curObj, false);
        }

        private void ButtonItem_RemoveCollision_Click(object sender, EventArgs e)
        {
            RemoveCollision(curObj);
        }

        private void ButtonItem_CopyCollisionPointer_Click(object sender, EventArgs e)
        {
            CopyCollisionPointer(curObj);
        }

        private void ButtonItem_EditObjectShadow_Click(object sender, EventArgs e)
        {
            EditObjectShadow();
        }

        private void ButtonItem_RemoveObjectShadow_Click(object sender, EventArgs e)
        {
            RemoveObjectShadow();
        }

        private void CM_Object_PopupOpen(object sender, PopupOpenEventArgs e)
        {
            ButtonItem_RemoveObjectShadow.Enabled = curObj.Geolayout.ObjectShadow.Enabled;
        }
    }
}