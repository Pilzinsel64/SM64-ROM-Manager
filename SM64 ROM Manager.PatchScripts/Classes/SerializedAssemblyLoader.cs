using System.Collections;
using System.Collections.Generic;
using global::System.IO;
using global::System.Reflection;
using System.Xml.Linq;
using global::Newtonsoft.Json;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.PatchScripts
{
    internal static class SerializedAssemblyLoader
    {
        public static IEnumerable<SerializedAssemblyMember> LoadAsmXml(Assembly asm)
        {
            string xmlpath = Path.ChangeExtension(asm.Location, ".xml");
            var members = new List<SerializedAssemblyMember>();
            if (File.Exists(xmlpath))
            {
                var doc = XDocument.Load(xmlpath);
                JArray objMembers = (JArray)JObject.Parse(JsonConvert.SerializeXNode(doc))["doc"]["members"]["member"];
                foreach (JObject objMember in objMembers)
                {
                    if (true || (string)objMember["@name"] == "member")
                    {
                        string objMemberName = (string)objMember["@name"];
                        var @params = new List<SerializedAssemblyMemberParam>();
                        string summery = (string)objMember["summary"];
                        string returns = (string)objMember["returns"];
                        char mTypeChar = objMemberName[0];
                        SerializedAssemblyMemberType mType = (SerializedAssemblyMemberType)(-1);
                        string name = objMemberName.Substring(2);
                        string path = "";
                        var paramTypes = new List<string>();
                        switch (mTypeChar)
                        {
                            case 'M':
                                {
                                    mType = SerializedAssemblyMemberType.Methode;
                                    break;
                                }

                            case 'T':
                                {
                                    mType = SerializedAssemblyMemberType.Type;
                                    break;
                                }

                            case 'F':
                                {
                                    mType = SerializedAssemblyMemberType.Field;
                                    break;
                                }

                            case 'P':
                                {
                                    mType = SerializedAssemblyMemberType.Property;
                                    break;
                                }
                        }

                        int iok = name.IndexOf('(');
                        if (iok > -1)
                        {
                            name = name.Remove(iok);
                        }

                        int liop = name.LastIndexOf('.');
                        if (liop > -1)
                        {
                            path = name.Remove(liop);
                            name = name.Substring(liop + 1);
                        }

                        if (objMember.ContainsKey("param"))
                        {
                            // MsgBox(objMember.ToString)
                            var objParams = objMember["param"];
                            object objParamsList = new object[] { };
                            if (objParams is JArray)
                            {
                                objParamsList = objParams;
                            }
                            else if (objParams is JProperty)
                            {
                                objParamsList = new[] { objParams };
                            }

                            foreach (JObject objParam in (IEnumerable)objParamsList)
                            {
                                string paramType = "";
                                @params.Add(new SerializedAssemblyMemberParam((string)objParam["@name"], (string)objParam["#text"], paramType));
                            }
                        }

                        members.Add(new SerializedAssemblyMember(name, path, summery, mType, @params.ToArray()));
                    }
                }
            }

            return members.ToArray();
        }
    }
}