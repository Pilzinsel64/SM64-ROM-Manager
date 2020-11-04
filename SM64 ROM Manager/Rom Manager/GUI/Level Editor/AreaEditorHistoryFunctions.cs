using System.Collections.Generic;
using System.Data;
using System.Linq;
using global::System.Reflection;
using System.Windows.Forms;
using global::SM64Lib.Levels;
using global::SM64Lib.Levels.Script;
using global::SM64Lib.Model.Collision;
using DevComponents.AdvTree;

namespace SM64_ROM_Manager.LevelEditor
{
    public class AreaEditorHistoryFunctions
    {
        private static Dictionary<string, MethodInfo> _Methodes = null;

        public static Dictionary<string, MethodInfo> Methodes
        {
            get
            {
                if (_Methodes is null)
                {
                    _Methodes = new Dictionary<string, MethodInfo>();
                    foreach (MethodInfo mi in typeof(AreaEditorHistoryFunctions).GetMethods())
                        _Methodes.Add(mi.Name, mi);
                }

                return _Methodes;
            }
        }

        public static void AddObjects(LevelArea area, List<Managed3DObject> objList, IEnumerable<Managed3DObject> objs, NodeCollection lvic, IEnumerable<Node> lvis)
        {
            for (int i = 0, loopTo = objs.Count() - 1; i <= loopTo; i++)
            {
                area.Objects.Add(objs.ElementAtOrDefault(i).Command);
                objList.Add(objs.ElementAtOrDefault(i));
                lvic.Add(lvis.ElementAtOrDefault(i));
            }
        }

        public static void RemoveObjects(LevelArea area, List<Managed3DObject> objList, IEnumerable<Managed3DObject> objs, NodeCollection lvic, IEnumerable<Node> lvis)
        {
            for (int i = 0, loopTo = objs.Count() - 1; i <= loopTo; i++)
            {
                area.Objects.Remove(objs.ElementAtOrDefault(i).Command);
                objList.Remove(objs.ElementAtOrDefault(i));
                lvic.Remove(lvis.ElementAtOrDefault(i));
            }
        }

        public static void InsertObjects(LevelArea area, List<Managed3DObject> objList, NodeCollection lvic, Dictionary<int, Managed3DObject> removedObjs, Dictionary<int, Node> removedlvis, Dictionary<int, LevelscriptCommand> removedCmds)
        {
            foreach (KeyValuePair<int, Managed3DObject> kvp in removedObjs.OrderBy(n => n.Key))
                objList.Insert(kvp.Key, kvp.Value);
            foreach (KeyValuePair<int, LevelscriptCommand> kvp in removedCmds.OrderBy(n => n.Key))
                area.Objects.Insert(kvp.Key, kvp.Value);
            foreach (KeyValuePair<int, Node> kvp in removedlvis.OrderBy(n => n.Key))
                lvic.Insert(kvp.Key, kvp.Value);
        }

        public static void RemoveAtObjects(LevelArea area, List<Managed3DObject> objList, NodeCollection lvic, Dictionary<int, Managed3DObject> removedObjs, Dictionary<int, Node> removedlvis, Dictionary<int, LevelscriptCommand> removedCmds)
        {
            foreach (KeyValuePair<int, Node> kvp in removedlvis.OrderByDescending(n => n.Key))
                lvic.RemoveAt(kvp.Key);
            foreach (KeyValuePair<int, Managed3DObject> kvp in removedObjs.OrderByDescending(n => n.Key))
                objList.RemoveAt(kvp.Key);
            foreach (KeyValuePair<int, LevelscriptCommand> kvp in removedCmds.OrderByDescending(n => n.Key))
                area.Objects.RemoveAt(kvp.Key);
        }

        public static void AddWarps(LevelArea area, List<IManagedLevelscriptCommand> objList, IEnumerable<IManagedLevelscriptCommand> objs, NodeCollection lvic, IEnumerable<Node> lvis, Dictionary<Node, ListViewGroup> lviGroups)
        {
            for (int i = 0, loopTo = objs.Count() - 1; i <= loopTo; i++)
            {
                area.Objects.Add(objs.ElementAtOrDefault(i).Command);
                objList.Add(objs.ElementAtOrDefault(i));
                var lvi = lvis.ElementAtOrDefault(i);
                //lvi.Group = lviGroups[lvi];
                lvic.Add(lvi);
            }
        }

        public static void RemoveWarps(LevelArea area, List<IManagedLevelscriptCommand> objList, IEnumerable<IManagedLevelscriptCommand> objs, NodeCollection lvic, IEnumerable<Node> lvis, Dictionary<Node, Node> lviGroups)
        {
            for (int i = 0, loopTo = objs.Count() - 1; i <= loopTo; i++)
            {
                area.Objects.Remove(objs.ElementAtOrDefault(i).Command);
                objList.Remove(objs.ElementAtOrDefault(i));
                lvic.Remove(lvis.ElementAtOrDefault(i));
            }
        }

        public static void InsertWarps(LevelArea area, List<IManagedLevelscriptCommand> objList, NodeCollection lvic, Dictionary<int, IManagedLevelscriptCommand> removedObjs, Dictionary<int, Node> removedlvis, Dictionary<int, LevelscriptCommand> removedCmds, Dictionary<Node, Node> lviGroups)
        {
            foreach (KeyValuePair<int, IManagedLevelscriptCommand> kvp in removedObjs.OrderBy(n => n.Key))
                objList.Insert(kvp.Key, kvp.Value);
            foreach (KeyValuePair<int, LevelscriptCommand> kvp in removedCmds.OrderBy(n => n.Key))
                area.Warps.Insert(kvp.Key, kvp.Value);
            foreach (KeyValuePair<int, Node> kvp in removedlvis.OrderBy(n => n.Key))
            {
                //kvp.Value.Group = lviGroups[kvp.Value];
                lvic.Insert(kvp.Key, kvp.Value);
            }
        }

        public static void RemoveAtWarps(LevelArea area, List<IManagedLevelscriptCommand> objList, NodeCollection lvic, Dictionary<int, IManagedLevelscriptCommand> removedObjs, Dictionary<int, Node> removedlvis, Dictionary<int, LevelscriptCommand> removedCmds, Dictionary<Node, Node> lviGroups)
        {
            foreach (KeyValuePair<int, Node> kvp in removedlvis.OrderByDescending(n => n.Key))
                lvic.RemoveAt(kvp.Key);
            foreach (KeyValuePair<int, IManagedLevelscriptCommand> kvp in removedObjs.OrderByDescending(n => n.Key))
                objList.RemoveAt(kvp.Key);
            foreach (KeyValuePair<int, LevelscriptCommand> kvp in removedCmds.OrderByDescending(n => n.Key))
                area.Warps.RemoveAt(kvp.Key);
        }

        public static void RevertObjects(LevelArea area, List<Managed3DObject> objList, IEnumerable<int> indicies, IEnumerable<Managed3DObject> objs)
        {
            for (int i = 0, loopTo = objs.Count() - 1; i <= loopTo; i++)
            {
                int index = indicies.ElementAtOrDefault(i);
                var newobj = objs.ElementAtOrDefault(i);
                objList[index] = newobj;
                area.Objects[index] = newobj.Command;
            }
        }

        public static void RemoveFromCollision(Form_AreaEditor @base, VertexList vlist, Vertex[] vs, TriangleList tlist, Triangle[] ts)
        {
            foreach (Triangle t in ts)
                tlist.Remove(t);
            foreach (Vertex v in vs)
                vlist.Remove(v);
            @base.maps.ReloadCollisionInOpenGL();
        }

        public static void AddToCollision(Form_AreaEditor @base, VertexList vlist, Vertex[] vs, TriangleList tlist, Triangle[] ts)
        {
            foreach (Vertex v in vs)
                vlist.Add(v);
            foreach (Triangle t in ts)
                tlist.Add(t);
            @base.maps.ReloadCollisionInOpenGL();
        }
    }
}