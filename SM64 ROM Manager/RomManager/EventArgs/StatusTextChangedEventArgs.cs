using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib;
using static SM64Lib.General;
using SM64Lib.TextValueConverter;
using static SM64Lib.TextValueConverter.TextValueConverter;
using Z.Collections.Extensions;
using Z.Core.Extensions;
using Z.Data.Extensions;
using Z.Drawing.Extensions;
using Z.IO.Extensions;
using Z.Net.Extensions;
using Z.Window.Forms.Extensions;

namespace SM64_ROM_Manager.EventArguments
{
    public class StatusTextChangedEventArgs : global::System.EventArgs
    {
        public string NewStatus { get; private set; }

        public StatusTextChangedEventArgs(string newStatus)
        {
            this.NewStatus = Conversions.ToString(newStatus);
        }
    }
}