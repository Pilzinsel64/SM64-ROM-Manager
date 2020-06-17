
using Newtonsoft.Json;

namespace SM64_ROM_Manager.Updating
{
    public class UpdatePackageInfo
    {
        public string Name { get; set; }
        public ApplicationVersion Version { get; set; }
        public UpdateNotes Notes { get; } = new UpdateNotes();
        public string Packagelink { get; set; }

        [JsonProperty]
        private string Changelog
        {
            set
            {
                Notes.Content = value;
                Notes.ContentType = UpdateNotesContentType.PlainText;
            }
        }
    }
}