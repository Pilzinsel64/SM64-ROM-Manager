using DevComponents.DotNetBar;
using Pilz.UI;
using SM64Lib.HUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM64_ROM_Manager
{
    public partial class HUDEditorForm : OfficeForm
    {

        // C o n s t r u c t o r

        public HUDEditorForm()
        {
            InitializeComponent();
        }

        // F e a t u r e s



        // P a i n t i n g O b j e c t s

        private void LoadPaintingObjects(HUDGroup rootGroup)
        {
            var objects = new List<PaintingObject>();
            var curPath = new Stack<string>();

            void checkGroups(IEnumerable<HUDGroup> groups)
            {
                foreach (var group in groups)
                    checkGroup(group);
            }
            void checkGroup(HUDGroup group)
            {
                curPath.Push(group.Name);
                checkItems(group.Items);
                checkGroups(group.Groups);
                curPath.Pop();
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
                curPath.Pop();
            }

            paintingControl1.SuspendDrawing();
            paintingControl1.PaintingObjects.Clear();
            paintingControl1.PaintingObjects.AddRange(objects);
            paintingControl1.ResumeDrawing();
        }

        private PaintingObject GetPaintingObject(HUDItem item)
        {
            var po = new PaintingObject
            {
                Tag = item,
                HardcodedSize = !item.DataInfo.CanSetLocation,
                Type = PaintingObjectType.Rectangle,
                EnableFill = false,
                EnableOutline = true,
                OutlineColor = Color.Blue,
                OutlineThicknes = 1,
                Location = item.Location.Value,
                Size = new Size(16, 16)
            };

            // Check for text and set text
            if (item.DataInfo.CanSetText || !string.IsNullOrEmpty(item.Text))
            {
                po.Text = item.Text;
                po.Type |= PaintingObjectType.Text;
            }

            // Check for symbol and set image
            if (false)
            {
                // ...
                po.Type |= PaintingObjectType.Picture;
            }

            return po;
        }

        // G U I

    }
}
