using System.Collections.Generic;
using global::System.IO;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.LevelEditor
{
    public class ObjectComboList : List<ObjectCombo>
    {
        public static ObjectCombo UnknownCombo { get; private set; } = new ObjectCombo() { Name = "Unknown Combo" };


        public void ReadFromFile(string fileName)
        {
            ReadFromString(File.ReadAllText(fileName));
        }

        public void ReadFromString(string content)
        {
            Clear();
            var jobj = JObject.Parse(content);

            if (jobj?["ObjectCombos"] != null)
            {
                foreach (var entry in (JArray)jobj["ObjectCombos"])
                {
                    Add(new ObjectCombo
                    {
                        Name = entry["Name"]?.ToString(),
                        ModelID = entry["ModelID"].Value<byte>(),
                        ModelAddress = entry["ModelAddress"].Value<int>(),
                        BehaviorAddress = entry["Behavior"].Value<uint>(),
                        BParam1 = new ObjectCombo.BParam {Name = entry?["BP1_NAME"]?.ToString(), Description = entry?["BP1_DESCRIPTION"]?.ToString()},
                        BParam2 = new ObjectCombo.BParam {Name = entry?["BP2_NAME"]?.ToString(), Description = entry?["BP2_DESCRIPTION"]?.ToString()},
                        BParam3 = new ObjectCombo.BParam {Name = entry?["BP3_NAME"]?.ToString(), Description = entry?["BP3_DESCRIPTION"]?.ToString()},
                        BParam4 = new ObjectCombo.BParam {Name = entry?["BP4_NAME"]?.ToString(), Description = entry?["BP4_DESCRIPTION"]?.ToString()}
                    });
                }
            }
        }

        public void WriteToFile(string fileName)
        {
            File.WriteAllText(fileName, WriteToString());
        }

        public string WriteToString()
        {
            var jobj = new JObject();
            var jarr = new JArray();
            jobj.Add("ObjectCombos", jarr);

            foreach (ObjectCombo cb in this)
            {
                var entry = new JObject();
                entry["Name"] = cb.Name;
                entry["ModelID"] = cb.ModelID;
                entry["ModelAddress"] = cb.ModelAddress;
                entry["Behavior"] = cb.BehaviorAddress;
                if (cb.BParam1 is object)
                {
                    entry["BP1_NAME"] = cb.BParam1.Name;
                    entry["BP1_DESCRIPTION"] = cb.BParam1.Description;
                }

                if (cb.BParam2 is object)
                {
                    entry["BP2_NAME"] = cb.BParam2.Name;
                    entry["BP2_DESCRIPTION"] = cb.BParam2.Description;
                }

                if (cb.BParam3 is object)
                {
                    entry["BP3_NAME"] = cb.BParam3.Name;
                    entry["BP3_DESCRIPTION"] = cb.BParam3.Description;
                }

                if (cb.BParam4 is object)
                {
                    entry["BP4_NAME"] = cb.BParam4.Name;
                    entry["BP4_DESCRIPTION"] = cb.BParam4.Description;
                }

                jarr.Add(entry);
            }

            return jobj.ToString();
        }

        public ObjectCombo GetObjectComboOfObject(Managed3DObject obj)
        {
            foreach (var objcombo in this)
            {
                if (objcombo.ID == obj.ObjectCombo.ID)
                    return objcombo;
            }

            return UnknownCombo;
        }

        public ObjectCombo GetObjectComboOfObject(byte modelID, uint behavID)
        {
            foreach (var objcombo in this)
            {
                if (objcombo.ModelID == modelID && objcombo.BehaviorAddress == behavID)
                    return objcombo;
            }

            return UnknownCombo;
        }
    }
}