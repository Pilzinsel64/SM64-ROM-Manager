using System.Collections.Generic;
using System.Linq;
using global::Newtonsoft.Json;

namespace SM64Lib.Text.Profiles
{
    public class TextProfileInfo
    {
        public string Name { get; set; }
        public List<TextTableGroupInfo> TextTableGroups { get; set; } = new List<TextTableGroupInfo>();
        public List<TextArrayGroupInfo> TextArrayGroups { get; set; } = new List<TextArrayGroupInfo>();

        public TextGroupInfo GetGroup(string name)
        {
            return AllGroups.FirstOrDefault(n => (n.Name ?? "") == (name ?? ""));
        }

        [JsonIgnore]
        public IEnumerable<TextGroupInfo> AllGroups
        {
            get
            {
                var list = new List<TextGroupInfo>();
                list.AddRange(TextTableGroups.ToArray());
                list.AddRange(TextArrayGroups.ToArray());
                return list;
            }
        }
    }
}