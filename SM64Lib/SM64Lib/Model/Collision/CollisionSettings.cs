using System;
using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64Lib.Model.Collision
{
    public class CollisionSettings
    {
        public List<Entry> Entries { get; private set; } = new List<Entry>();

        public async Task Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                var sr = new StreamReader(fs);
                Entries.Clear();
                while (!sr.EndOfStream)
                {
                    var e = new Entry();
                    e.FromString(await sr.ReadLineAsync());
                    Entries.Add(e);
                }

                fs.Close();
            }
        }

        public async Task Save(string fileName)
        {
            var fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            var sw = new StreamWriter(fs);
            foreach (Entry e in Entries)
                await sw.WriteLineAsync(e.ToString());
            await sw.FlushAsync();
            fs.Close();
        }

        public Entry GetEntry(string matName)
        {
            foreach (Entry e in Entries)
            {
                if ((e.MaterialName ?? "") == (matName ?? ""))
                {
                    return e;
                }
            }

            var ne = new Entry();
            ne.MaterialName = matName;
            Entries.Add(ne);
            return ne;
        }

        public class Entry
        {
            public string MaterialName { get; set; } = "";
            public byte CollisionType { get; set; } = 0;
            public byte CollisionParam1 { get; set; } = 0;
            public byte CollisionParam2 { get; set; } = 0;
            public bool IsNonSolid { get; set; } = false;

            public new string ToString()
            {
                return $"{MaterialName};{CollisionType};{CollisionParam1};{CollisionParam2};{IsNonSolid.ToString()}";
            }

            public void FromString(string str)
            {
                var parts = str.Split(';');
                MaterialName = parts[0];
                CollisionType = Conversions.ToByte(parts[1]);
                CollisionParam1 = Conversions.ToByte(parts[2]);
                CollisionParam2 = Conversions.ToByte(parts[3]);
                if (parts.Count() > 4)
                    IsNonSolid = Convert.ToBoolean(parts[4]);
            }
        }
    }
}