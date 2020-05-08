using global::System.ComponentModel;
using global::System.ComponentModel.Design;
using global::System.Drawing.Design;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SM64Lib.Text.Profiles
{
    public class TextTableGroupInfo : TextGroupInfo
    {
        public TextTableSegmentedInfo Segmented { get; set; } = new TextTableSegmentedInfo();
        public TextTableDataInfo Data { get; set; } = new TextTableDataInfo();
        public TextTableDialogDataInfo DialogData { get; set; } = new TextTableDialogDataInfo();
        [JsonIgnore] [Browsable(false)]
        public List<string> ItemDescriptionsList { get; } = new List<string>();

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string ItemDescriptions
        {
            get
            {
                if (!ItemDescriptionsList.Any())
                    return string.Empty;
                else
                {
                    var sw = new StringWriter();
                    foreach (var str in ItemDescriptionsList)
                        sw.WriteLine(str);
                    return sw.ToString().Trim();
                }
            }
            set
            {
                ItemDescriptionsList.Clear();
                if (!string.IsNullOrEmpty(value))
                {
                    var sr = new StringReader(value);
                    while (sr.Peek() != -1)
                    {
                        string line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                            ItemDescriptionsList.Add(line);
                    }
                }
            }
        }

        public TextTableType TableType
        {
            get
            {
                return DialogData.TableRomOffset == 0 ? TextTableType.Default : TextTableType.Dialogs;
            }
        }
    }
}