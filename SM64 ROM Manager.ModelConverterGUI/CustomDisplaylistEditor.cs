using System;
using System.Collections.Generic;
using System.Data;
using global::System.Drawing;
using System.Linq;
using global::DevComponents.DotNetBar;
using global::SM64Lib.Model.Conversion.Fast3DWriting;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    public partial class CustomDisplaylistEditor
    {

        // C o n s t r c u t o r s

        public CustomDisplaylistEditor(IList<DisplaylistProps> propsList)
        {

            // G U I

            this.Shown += CustomDisplaylistEditor_Shown;
            this.propsList = propsList;
            InitializeComponent();
        }

        // F i e l d s

        private readonly IList<DisplaylistProps> propsList;

        // F e a t u r e s

        private BaseItem GetItem(DisplaylistProps props)
        {
            var editorControl = new CustomDisplaylistEntryEditor(props) { BackColor = Color.Transparent };
            editorControl.RemoveButtonClicked += RemoveProps;
            var containerItem = new ControlContainerItem()
            {
                Control = editorControl,
                Stretch = true
            };
            return containerItem;
        }

        private void LoadAllProps()
        {
            ItemPanel1.BeginUpdate();

            // Clear list
            ItemPanel1.Items.Clear();

            // Add Props
            foreach (DisplaylistProps props in propsList)
                ItemPanel1.Items.Add(GetItem(props));

            // Add 'New' Button
            var btnNew = new ButtonItem()
            {
                Text = "New",
                Image = My.Resources.Resources.Add_16px,
                ButtonStyle = eButtonStyle.ImageAndText
            };
            btnNew.Click += (_, __) => AddNewProps();
            ItemPanel1.Items.Add(btnNew);
            ItemPanel1.EndUpdate();
        }

        private void AddNewProps()
        {
            ItemPanel1.BeginUpdate();

            // Find new ID
            int id = 0;
            bool ende = false;
            while (!ende)
            {
                ende = true;
                foreach (DisplaylistProps props2 in propsList.OrderBy(n => n.ID))
                {
                    if (props2.ID == id)
                    {
                        id = props2.ID + 1;
                        ende = false;
                    }
                }
            }

            // Create Props & Items
            var props = new DisplaylistProps(id);
            var item = GetItem(props);
            propsList.Add(props);
            ItemPanel1.Items.Insert(ItemPanel1.Items.Count - 1, item);
            ItemPanel1.EndUpdate();
        }

        private void RemoveProps(CustomDisplaylistEntryEditor editor)
        {
            ItemPanel1.BeginUpdate();

            // Remove Item
            BaseItem itemToRemove = null;
            foreach (BaseItem item in ItemPanel1.Items)
            {
                if (itemToRemove is null && item is ControlContainerItem && ((ControlContainerItem)item).Control == editor)
                {
                    itemToRemove = item;
                }
            }

            ItemPanel1.Items.Remove(itemToRemove);

            // Remove Props
            propsList.Remove(editor.Props);
            ItemPanel1.EndUpdate();
        }

        private void CustomDisplaylistEditor_Shown(object sender, EventArgs e)
        {
            LoadAllProps();
        }
    }
}