using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using SM64Lib.Behaviors;

namespace SM64_ROM_Manager
{
    public partial class BehaviorParameterInfoEditor : OfficeForm
    {
        public BehaviorParameterInfoEditor(BehaviorParamsInfo info)
        {
            // Components
            InitializeComponent();
            UpdateAmbientColors();

            // Make B. Params expandable
            for (int i = 1; i <= 4; i++)
            {
                var propset = new PropertySettings();
                propset.DisplayName = "Param " + Conversions.ToString(i);
                propset.PropertyName = "Param" + Conversions.ToString(i);
                propset.TypeConverter = new ExpandableObjectConverter();
                advPropertyGrid1.PropertySettings.Add(propset);
            }

            // Add handler for Node created
            advPropertyGrid1.PropertyTree.NodeMouseUp += (_, __) => SetBParamValueText();
            advPropertyGrid1.PropertyTree.AfterNodeSelect += (_, __) => SetBParamValueText();
            advPropertyGrid1.PropertiesLoaded += (_, __) => SetBParamValueText();

            // Set Object
            advPropertyGrid1.SelectedObject = info;

            // Expand everything
            advPropertyGrid1.PropertyTree.ExpandAll();
        }

        private void SetBParamValueText()
        {
            for (int i = 1; i <= 4; i++)
            {
                var n = advPropertyGrid1.GetPropertyNode("Param" + Conversions.ToString(i));
                if (n is object)
                {
                    if (n.Cells.Count >= 2)
                    {
                        n.Cells[1].TextMarkupEnabled = true;
                        n.Cells[1].Text = string.Empty; //"<i>(Expand...)</i>"
                    }
                }
            }
        }
    }
}