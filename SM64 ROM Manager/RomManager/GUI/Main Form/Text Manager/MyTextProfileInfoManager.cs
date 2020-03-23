using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64Lib.Text.Profiles;
using Z.Collections.Extensions;
using Z.Core.Extensions;

namespace SM64_ROM_Manager
{
    public class MyTextProfileInfoManager
    {
        public SM64Lib.Text.TextProfileInfoManager Manager { get; private set; } = new SM64Lib.Text.TextProfileInfoManager();

        private readonly Dictionary<TextProfileInfo, string> filePaths = new Dictionary<TextProfileInfo, string>();
        private readonly Dictionary<TextProfileInfo, string> ids = new Dictionary<TextProfileInfo, string>();
        private readonly Random rnd = new Random();

        public MyTextProfileInfoManager()
        {
            LoadAllTextProfilesIfNotLoaded();
        }

        private static string MyTextEditorPath
        {
            get
            {
                return Path.Combine(Publics.General.MyDataPath, "Text Manager");
            }
        }

        public void SaveAllTextProfile()
        {
            foreach (TextProfileInfo info in Manager.GetTextProfiles())
                SaveTextProfile(info);
        }

        public void SaveTextProfile(TextProfileInfo info)
        {
            string myPath;
            if (info != Manager.DefaultTextProfileInfo)
            {
                if (filePaths.ContainsKey(info))
                {
                    myPath = filePaths[info];
                }
                else
                {
                    myPath = Path.Combine(MyTextEditorPath, GetID(info) + ".json");
                    filePaths.Add(info, myPath);
                }

                Manager.SaveToFile(info, myPath);
            }
        }

        private string GetID(TextProfileInfo info)
        {
            if (ids.ContainsKey(info))
            {
                return ids[info];
            }
            else
            {
                bool ende = false;
                var id = default(int);
                while (!ende)
                {
                    id = rnd.Next();
                    if (!ids.Values.Contains(Conversions.ToString(id)))
                    {
                        ende = true;
                    }
                }

                ids.Add(info, Conversions.ToString(id));
                return Conversions.ToString(id);
            }
        }

        public void LoadAllTextProfilesIfNotLoaded()
        {
            if (!Manager.GetTextProfiles().Any())
            {
                LoadAllTextProfiles();
            }
        }

        public void LoadAllTextProfiles()
        {
            Manager.ClearProfleList();
            filePaths.Clear();
            ids.Clear();
            foreach (string f in Directory.GetFiles(MyTextEditorPath, "*.json"))
            {
                var info = Manager.LoadFromFile(f);
                filePaths.Add(info, f);
                ids.Add(info, Path.GetFileNameWithoutExtension(f));
            }
        }

        public void RemoveTextProfile(TextProfileInfo p)
        {
            if (filePaths.ContainsKey(p))
            {
                File.Delete(filePaths[p]);
                filePaths.Remove(p);
            }

            Manager.RemoveTextProfile(p);
            ids.RemoveIfContainsKey(p);
        }

        public void Export(TextProfileInfo info, string outputFile)
        {
            Manager.SaveToFile(info, outputFile);
        }

        public TextProfileInfo Import(string inputFile)
        {
            return Manager.LoadFromFile(inputFile);
        }
    }
}