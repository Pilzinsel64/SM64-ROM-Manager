using System.Collections.Generic;
using global::System.IO;
using System.Linq;
using global::Newtonsoft.Json.Linq;
using static SM64Lib.TextValueConverter.TextValueConverter;

namespace SM64Lib.Levels
{
    public class LevelInfoDataTabelList : List<LevelInfoDataTabelList.Level>
    {
        public void ReadFromFile(string FileName)
        {
            var jobj = JObject.Parse(File.ReadAllText(FileName));
            if (jobj["Levels"] is object)
            {
                foreach (JObject entry in (JArray)jobj["Levels"])
                {
                    Add(new Level
                    {
                        Name = entry?["Name"].ToString(),
                        Number = entry?["Number"].ToString(),
                        TypeString = entry?["Type"].ToString(),
                        ID = (ushort)ValueFromText(entry?["ID"].ToString()),
                        Pointer = (uint)ValueFromText(entry?["Pointer"].ToString()),
                        Index = entry["Index"].Value<int>()
                    });
                }
            }
        }

        public Level GetByLevelID(ushort ID)
        {
            return this.FirstOrDefault(n => n.ID == ID);
        }

        public class Level
        {
            public ushort ID { get; set; } = 0;
            public uint Pointer { get; set; } = 0;
            public string Name { get; set; } = "";
            public string Number { get; set; } = "";
            public LevelTypes Type { get; set; } = LevelTypes.Level;
            public int Index { get; set; } = -1;

            public string TypeString
            {
                get
                {
                    var switchExpr = Type;
                    switch (switchExpr)
                    {
                        case LevelTypes.Level:
                            {
                                return "Level";
                            }

                        case LevelTypes.Sidelevel:
                            {
                                return "Side";
                            }

                        case LevelTypes.Overworld:
                            {
                                return "OW";
                            }

                        case LevelTypes.Bowsercourse:
                            {
                                return "BC";
                            }

                        case LevelTypes.Bowserbattle:
                            {
                                return "BB";
                            }

                        case LevelTypes.Switchpalace:
                            {
                                return "Switch";
                            }

                        default:
                            {
                                return "";
                            }
                    }
                }

                set
                {
                    switch (value)
                    {
                        case "Level":
                            {
                                Type = LevelTypes.Level;
                                break;
                            }

                        case "Side":
                            {
                                Type = LevelTypes.Sidelevel;
                                break;
                            }

                        case "OW":
                            {
                                Type = LevelTypes.Overworld;
                                break;
                            }

                        case "BC":
                            {
                                Type = LevelTypes.Bowsercourse;
                                break;
                            }

                        case "BB":
                            {
                                Type = LevelTypes.Bowserbattle;
                                break;
                            }

                        case "Switch":
                            {
                                Type = LevelTypes.Switchpalace;
                                break;
                            }
                    }
                }
            }
        }

        public enum LevelTypes
        {
            Level,
            Sidelevel,
            Overworld,
            Switchpalace,
            Bowsercourse,
            Bowserbattle
        }
    }
}