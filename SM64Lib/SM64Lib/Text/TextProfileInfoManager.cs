using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using global::SM64Lib.Text.Profiles;
using Z.Collections.Extensions;

namespace SM64Lib.Text
{
    public class TextProfileInfoManager
    {
        private readonly List<TextProfileInfo> textProfiles = new List<TextProfileInfo>();

        public TextProfileInfo DefaultTextProfileInfo
        {
            get
            {
                return textProfiles.FirstOrDefault(n => (n.Name.ToLower() ?? "") == "default");
            }
        }

        private TextProfileInfo Clone(TextProfileInfo info)
        {
            return JObject.FromObject(info).ToObject<TextProfileInfo>();
        }

        public void SaveToFile(TextProfileInfo info, string outputFile)
        {
            File.WriteAllText(Path.Combine(outputFile), JObject.FromObject(info).ToString());
        }

        public TextProfileInfo LoadFromFile(string inputFile)
        {
            var info = JObject.Parse(File.ReadAllText(inputFile)).ToObject<TextProfileInfo>();
            textProfiles.Add(info);
            return info;
        }

        public void RemoveTextProfile(TextProfileInfo p)
        {
            textProfiles.RemoveIfContains(p);
        }

        public IEnumerable<TextProfileInfo> GetTextProfiles()
        {
            return textProfiles;
        }

        public TextProfileInfo CreateTextProfile()
        {
            var definfo = DefaultTextProfileInfo;
            var p = Clone(definfo);
            p.Name = definfo.Name + Conversions.ToString(textProfiles.Count);
            textProfiles.Add(p);
            return p;
        }

        public void ClearProfleList()
        {
            textProfiles.Clear();
        }
    }
}