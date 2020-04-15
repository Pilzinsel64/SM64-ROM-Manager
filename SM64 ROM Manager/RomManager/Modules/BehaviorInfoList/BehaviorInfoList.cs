using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using global::SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager.LevelEditor
{
    public class BehaviorInfoList : List<BehaviorInfo>
    {
        public void ReadFromFile(string fileName)
        {
            Clear();
            var jarr = JArray.Parse(File.ReadAllText(fileName));
            if (jarr is object)
            {
                foreach (JObject entry in jarr)
                {
                    var info = new BehaviorInfo();
                    info.Name = entry["Name"].Value<string>();
                    info.BehaviorAddress = Conversions.ToUInteger(TextValueConverter.ValueFromText(entry["Behavior"].Value<string>(), useIVM: 0));
                    for (int i = 1; i <= 4; i++)
                    {
                        if (entry.ContainsKey($"BP{i} Name"))
                        {
                            info.GetValue<BehaviorInfo.BParam>($"BParam{i}").Name = entry[$"BP{i} Name"].Value<string>();
                        }

                        if (entry.ContainsKey($"BP{i} Entries"))
                        {
                            BehaviorInfo.BParam param = (BehaviorInfo.BParam)info.GetValue($"BParam{i}");
                            foreach (JObject kvp in entry[$"BP{i} Entries"])
                                param.Values.Add(new BehaviorInfo.BParamValue()
                                {
                                    Name = kvp["Name"].Value<string>(),
                                    Value = Conversions.ToByte(kvp["Value"].Value<string>())
                                });
                        }
                    }

                    Add(info);
                }
            }
        }

        public void WriteToFile(string fileName)
        {
            var jarr = new JArray();
            foreach (BehaviorInfo info in this)
            {
                var entry = new JObject();
                entry["Name"] = info.Name;
                entry["Behavior"] = info.BehaviorAddress;
                for (int i = 1; i <= 4; i++)
                {
                    var param = info.GetValue<BehaviorInfo.BParam>($"BParam{i}");
                    if (param is object)
                    {
                        entry[$"BP{i} Name"] = param.Name;
                        if (param.Values.Any())
                        {
                            var parr = new JArray();
                            foreach (BehaviorInfo.BParamValue value in param.Values)
                            {
                                var vobj = new JObject();
                                vobj["Value"] = TextValueConverter.TextFromValue(value.Value);
                                vobj["Name"] = value.Name;
                                parr.Add(vobj);
                            }

                            entry[$"BP{i} Entries"] = parr;
                        }
                    }
                }

                jarr.Add(entry);
            }

            File.WriteAllText(fileName, jarr.ToString());
        }

        public BehaviorInfo GetByBehaviorAddress(uint addr)
        {
            return this.FirstOrDefault(n => n.BehaviorAddress == addr);
        }
    }
}