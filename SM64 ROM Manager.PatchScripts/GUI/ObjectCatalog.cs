using System;
using System.Collections;
using System.Collections.Generic;
using global::System.Globalization;
using global::System.Reflection;
using System.Threading.Tasks;
using global::DevComponents.AdvTree;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.PatchScripts.My.Resources;
using System.Drawing;

namespace SM64_ROM_Manager.PatchScripts
{
    public partial class ObjectCatalog
    {
        public ObjectCatalog()
        {
            base.Shown += ObjectCatalog_Shown;
            InitializeComponent();
            base.UpdateAmbientColors();
            CreateImageList();
        }

        private readonly BindingFlags myBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
        private readonly string[] blackMethodNameStarts = new[] { "get_", "set_", "add_", "remove_" };
        private readonly List<SerializedAssemblyMember> AsmXmls = new List<SerializedAssemblyMember>();

        private Dictionary<string, Node> searchTypes_knownNamespaces = new Dictionary<string, Node>();
        private Dictionary<Type, Node> searchTypes_knownTypes = new Dictionary<Type, Node>();

        private void CreateImageList()
        {
            ImageList_RefSymbols.Images.Clear();
            try
            {
                foreach (DictionaryEntry kvp in ReflectionSymbols.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true))
                    ImageList_RefSymbols.Images.Add((string)kvp.Key, (Image)kvp.Value);
            }
            catch (Exception) { }
        }

        private void LoadCatalog()
        {
            var asms = new List<Assembly>();
            var nodes = new List<Node>();
            asms.Add(typeof(SM64Lib.RomManager).Assembly);
            foreach (Assembly asm in asms)
            {
                // Create Node
                var nasm = GetNode(asm.FullName, asm);
                nodes.Add(nasm);

                // Search Types
                SearchTypes(asm.GetTypes(), nasm);

                // Search XML Serialations
                AsmXmls.AddRange(SerializedAssemblyLoader.LoadAsmXml(typeof(SM64Lib.RomManager).Assembly));
            }

            foreach (Node n in nodes)
                n.Expand();
            Invoke(new Action(() =>
            {
                AdvTree1.SuspendLayout();
                AdvTree1.Nodes.Clear();
                AdvTree1.Nodes.AddRange(nodes.ToArray());
                AdvTree1.ResumeLayout();
            }));
        }

        private string GetMemberInfo(MemberInfo mi)
        {
            string fullPath = string.Empty;
            string text = string.Empty;
            var switchExpr = mi?.MemberType;
            switch (switchExpr)
            {
                case MemberTypes.TypeInfo:
                case MemberTypes.NestedType:
                    {
                        Type t = (Type)mi;
                        fullPath = t.FullName;
                        break;
                    }

                case MemberTypes.Method:
                case MemberTypes.Constructor:
                case MemberTypes.Property:
                case MemberTypes.Field:
                case MemberTypes.Event:
                    {
                        fullPath = mi.DeclaringType.FullName + "." + mi.Name;
                        break;
                    }
            }

            if (!string.IsNullOrEmpty(fullPath) && fullPath.Contains(Conversions.ToString('.')))
            {
                string path = fullPath.Remove(fullPath.LastIndexOf('.'));
                string name = fullPath.Substring(fullPath.LastIndexOf('.') + 1);
                SerializedAssemblyMember foundSam = null;
                foreach (SerializedAssemblyMember sam in AsmXmls)
                {
                    if (foundSam is null && (sam.Name ?? "") == (name ?? "") && (sam.Path ?? "") == (path ?? ""))
                    {
                        foundSam = sam;
                    }
                }

                if (foundSam is object)
                {
                    text = $@"{name} : {foundSam.Type}
in {path}

{foundSam.Description}";
                }
                else
                {
                    text = $@"{name}
in {path}";
                }
            }

            return text;
        }

        private Node GetNode(string text, object tag)
        {
            var n = new Node()
            {
                Text = text,
                Tag = tag
            };
            if (tag is MethodInfo)
            {
                n.ImageKey = nameof(ReflectionSymbols.Methode);
            }
            else if (tag is Type)
            {
                Type t = (Type)tag;
                switch (true)
                {
                    case object _ when t.IsEnum:
                        {
                            n.ImageKey = nameof(ReflectionSymbols._Enum);
                            break;
                        }

                    case object _ when t.IsClass:
                        {
                            n.ImageKey = nameof(ReflectionSymbols._Class);
                            break;
                        }

                    case object _ when t.IsInterface:
                        {
                            n.ImageKey = nameof(ReflectionSymbols._Interface);
                            break;
                        }
                }
            }
            else if (tag is PropertyInfo)
            {
                n.ImageKey = nameof(ReflectionSymbols._Property);
            }
            else if (tag is FieldInfo)
            {
                n.ImageKey = nameof(ReflectionSymbols.Field);
            }
            else if (tag is EventInfo)
            {
                n.ImageKey = nameof(ReflectionSymbols._Event);
            }
            else if (tag is null)
            {
                n.ImageKey = nameof(ReflectionSymbols._Namespace);
            }

            return n;
        }

        private void SearchTypes(IEnumerable<Type> types, Node parent)
        {
            foreach (Type t in types)
            {
                if ((t.IsPublic || t.IsNestedPublic) && !searchTypes_knownTypes.ContainsKey(t))
                {
                    Node nns;
                    if (string.IsNullOrEmpty(t.Namespace) || t.IsNested && t.ReflectedType is object && t.ReflectedType == (Type)parent.Tag)
                    {
                        nns = parent;
                    }
                    else if (searchTypes_knownNamespaces.ContainsKey(t.Namespace))
                    {
                        nns = searchTypes_knownNamespaces[t.Namespace];
                    }
                    else
                    {
                        nns = GetNode(t.Namespace, null);
                        parent.Nodes.Add(nns);
                        searchTypes_knownNamespaces.Add(t.Namespace, nns);
                    }

                    var nt = GetNode(t.Name, t);
                    nns.Nodes.Add(nt);
                    searchTypes_knownTypes.Add(t, nt);
                    SearchTypes(t.GetNestedTypes(), nt);
                    foreach (FieldInfo f in t.GetFields(myBindingFlags))
                    {
                        var np = GetNode(f.Name + " : " + f.FieldType.ToString(), f);
                        nt.Nodes.Add(np);
                    }

                    foreach (PropertyInfo p in t.GetProperties(myBindingFlags))
                    {
                        var np = GetNode(p.Name + " : " + p.PropertyType.ToString(), p);
                        nt.Nodes.Add(np);
                    }

                    foreach (MethodInfo m in t.GetMethods(myBindingFlags))
                    {
                        if (IsMethodeValue(m.Name))
                        {
                            string @params = "";
                            Array.ForEach(m.GetParameters(), n => @params += n.ParameterType.ToString() + ", ");
                            var nm = GetNode(m.Name + "(" + @params.TrimEnd(',', ' ') + ") : " + m.ReturnType.ToString(), m);
                            nt.Nodes.Add(nm);
                        }
                    }

                    foreach (EventInfo e in t.GetEvents(myBindingFlags))
                    {
                        var np = GetNode(e.ToString(), e);
                        nt.Nodes.Add(np);
                    }
                }
            }
        }

        private bool IsMethodeValue(string methodName)
        {
            foreach (string blackName in blackMethodNameStarts)
            {
                if (methodName.StartsWith(blackName))
                {
                    return false;
                }
            }

            return true;
        }

        private async void ObjectCatalog_Shown(object sender, EventArgs e)
        {
            CircularProgress1.Start();
            await Task.Run(LoadCatalog);
            CircularProgress1.Stop();
            TableLayoutPanel_1.Visible = true;
        }

        private void AdvTree1_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            if (e.Node?.Tag is object)
            {
                LabelX_MemberInfo.Text = GetMemberInfo(e.Node.Tag as MemberInfo);
            }
            else
            {
                LabelX_MemberInfo.Text = string.Empty;
            }
        }
    }
}