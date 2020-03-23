using System;
using System.Collections.Generic;
using global::DevComponents.DotNetBar;

namespace SM64_ROM_Manager.Publics.Controls
{
    public class ItemListBox : ItemPanel
    {
        public ItemListBox() : base()
        {
            this.MouseClick += (_, __) => UpdateCheckState();
        }

        public event SelectedItemChangedEventHandler SelectedItemChanged;

        public delegate void SelectedItemChangedEventHandler(object sender, EventArgs e);

        private void UpdateCheckState()
        {
            var toUncheck = new List<ButtonItem>();
            var toCheck = new List<ButtonItem>();
            foreach (BaseItem item in Items)
            {
                ButtonItem bi = item as ButtonItem;
                if (bi is object)
                {
                    if (bi.IsMouseOver)
                    {
                        if (!bi.Checked)
                        {
                            toCheck.Add(bi);
                        }
                    }
                    else if (bi.Checked)
                    {
                        toUncheck.Add(bi);
                    }
                }
            }

            if (toCheck.Count > 0)
            {
                foreach (ButtonItem item in toUncheck)
                    item.Checked = false;
                foreach (ButtonItem item in toCheck)
                    item.Checked = true;
            }

            if (toCheck.Count > 0 || toUncheck.Count > 0)
            {
                SelectedItemChanged?.Invoke(this, new EventArgs());
            }
        }

        public new BaseItem SelectedItem
        {
            get
            {
                for (int i = 0, loopTo = Items.Count - 1; i <= loopTo; i++)
                {
                    ButtonItem bi = Items[i] as ButtonItem;
                    if (bi is object)
                    {
                        if (bi.Checked)
                            return bi;
                    }
                }

                return null;
            }

            set
            {
                foreach (BaseItem item in Items)
                {
                    ButtonItem bi = item as ButtonItem;
                    if (bi is object)
                    {
                        bi.Checked = bi == value;
                    }
                }

                SelectedItemChanged?.Invoke(this, new EventArgs());
            }
        }

        public new int SelectedIndex
        {
            get
            {
                return base.SelectedIndex;
            }

            set
            {
                bool wasNotDifferent = base.SelectedIndex == value;
                base.SelectedIndex = value;
                for (int i = 0, loopTo = Items.Count - 1; i <= loopTo; i++)
                {
                    ButtonItem bi = Items[i] as ButtonItem;
                    if (bi is object)
                    {
                        if (i == value)
                        {
                            if (!bi.Checked)
                                bi.Checked = true;
                        }
                        else if (bi.Checked)
                            bi.Checked = false;
                    }
                }

                if (wasNotDifferent)
                {
                    SelectedItemChanged?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}