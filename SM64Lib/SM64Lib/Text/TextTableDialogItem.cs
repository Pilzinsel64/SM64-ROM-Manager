using global::SM64Lib.Text.Profiles;

namespace SM64Lib.Text
{
    public class TextTableDialogItem : TextTableItem
    {
        public int LinesPerSite { get; set; } = 4;
        public DialogVerticalPosition VerticalPosition { get; set; } = DialogVerticalPosition.Centred;
        public DialogHorizontalPosition HorizontalPosition { get; set; } = DialogHorizontalPosition.Middle;
        public DialogSoundEffect SoundEffect { get; set; } = DialogSoundEffect.Sign;
        public byte UnknownValue { get; set; } = 0;

        public TextTableDialogItem(byte[] bytes, TextTableGroupInfo info) : base(bytes, info)
        {
        }
    }
}