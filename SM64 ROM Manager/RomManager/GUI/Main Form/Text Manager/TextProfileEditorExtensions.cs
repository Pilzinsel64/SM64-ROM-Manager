using global::SM64Lib.Text.Profiles;

namespace SM64_ROM_Manager
{
    internal static class TextProfileEditorExtensions
    {
        public static bool IsTextTableGroupInfo(this TextGroupInfo tg)
        {
            return tg is TextTableGroupInfo;
        }

        public static bool IsTextArrayGroupInfo(this TextGroupInfo tg)
        {
            return tg is TextArrayGroupInfo;
        }
    }
}