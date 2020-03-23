using global::System.ComponentModel;
using global::System.ComponentModel.Design;
using global::System.Drawing.Design;

namespace SM64Lib.Text.Profiles
{
    public class TextTableGroupInfo : TextGroupInfo
    {
        public TextTableSegmentedInfo Segmented { get; set; } = new TextTableSegmentedInfo();
        public TextTableDataInfo Data { get; set; } = new TextTableDataInfo();
        public TextTableDialogDataInfo DialogData { get; set; } = new TextTableDialogDataInfo();
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string ItemDescriptions { get; set; } = string.Empty;

        public TextTableType TableType
        {
            get
            {
                return DialogData.TableRomOffset == 0 ? TextTableType.Default : TextTableType.Dialogs;
            }
        }
    }
}