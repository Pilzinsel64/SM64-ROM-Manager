using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using global::Newtonsoft.Json.Linq;

namespace SM64Lib.Objects.ObjectBanks.Data
{
    public class ObjectBankDataListCollection : Dictionary<byte, ObjectBankDataList>
    {
        public ObjectBankDataList this[int index]
        {
            get
            {
                return this.ElementAt(index).Value;
            }
        }
        public new ObjectBankDataList this[byte bankID]
        {
            get
            {
                return base[bankID];
            }
        }

        public void Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                string strContent = File.ReadAllText(filePath);
                var tempDic = JToken.Parse(strContent).ToObject<Dictionary<byte, ObjectBankDataList>>();
                Clear();
                foreach (var kvp in tempDic)
                    Add(kvp.Key, kvp.Value);
            }
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(this).ToString());
        }
    }
}