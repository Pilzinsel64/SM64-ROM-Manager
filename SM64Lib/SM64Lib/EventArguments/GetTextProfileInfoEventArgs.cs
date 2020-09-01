using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64Lib.EventArguments
{
    public class GetTextProfileInfoEventArgs : EventArgs
    {
        public Text.Profiles.TextProfileInfo ProfileInfo { get; set; }
    }
}
