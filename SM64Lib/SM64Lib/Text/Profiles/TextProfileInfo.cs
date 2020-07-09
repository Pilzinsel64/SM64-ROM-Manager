using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using global::Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public TextProfileInfo Clone()
        {
            return JObject.FromObject(this).ToObject<TextProfileInfo>();
        }

        public string WriteToString()
        {
            return JObject.FromObject(this).ToString();
        }

        public void WriteToFile(string filePath)
        {
            File.WriteAllText(filePath, WriteToString());
        }

        public static TextProfileInfo ReadFromString(string content)
        {
            return JObject.Parse(content).ToObject<TextProfileInfo>();
        }

        public static TextProfileInfo ReadFromFile(string filePath)
        {
            return ReadFromString(File.ReadAllText(filePath));
        }
    }
}