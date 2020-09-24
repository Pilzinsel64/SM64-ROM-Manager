using System.Collections.Generic;
using global::System.IO;
using global::System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using global::Newtonsoft.Json.Linq;
using Z.Collections.Extensions;
using SM64_ROM_Manager.Updating.UpdateInstaller;

namespace SM64_ROM_Manager.Updating.Administration.Packaging
{
    internal class UpdatePackageManager
    {

        // F i e l d s

        private UpdatePackageTemplate template;

        // P r o p e r t i e s

        public string FilesToCopyPath
        {
            get
            {
                return template.FilesToCopyPath;
            }

            set
            {
                template.FilesToCopyPath = value;
            }
        }

        // C o n s t r u c o t r s

        public UpdatePackageManager()
        {
            NewTemplate();
        }

        // F e a t u r e s

        public void LoadTemplate(string filePath)
        {
            template = JObject.Parse(File.ReadAllText(filePath)).ToObject<UpdatePackageTemplate>();
        }

        public void SaveTemplate(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(template).ToString());
        }

        public void NewTemplate()
        {
            template = new UpdatePackageTemplate();
        }

        public void ExportPackage(string path)
        {
            var exporter = new UpdatePackagePackager(template);
            exporter.Export(path);
        }

        private bool CheckUpdateInstallerAddOn(string path)
        {
            var asm = Assembly.ReflectionOnlyLoadFrom(path);
            var t = asm.GetType($"{UpdateInstallerAddOnNameDefinitions.UPDATE_INSTALLER_ADDON_NAMESPACE}.{UpdateInstallerAddOnNameDefinitions.UPDATE_INSTALLER_ADDON_TYPE}", false);
            bool isSupported = false;
            if (t is object)
            {
                var mi = t.GetMethod(UpdateInstallerAddOnNameDefinitions.UPDATE_INSTALLER_ADDON_METHOD, BindingFlags.Static | BindingFlags.Public);
                if (mi is object)
                {
                    var @params = mi.GetParameters();
                    if (@params.Length == 1 && @params.GetType() == typeof(Dictionary<string, object>))
                    {
                        isSupported = true;
                    }
                }
            }

            return isSupported;
        }

        public bool AddUpdateInstallerAddOn(string path)
        {
            if (Conversions.ToBoolean(!template.UpdateInstallerAddOns.Contains(path) && CheckUpdateInstallerAddOn(path)))
            {
                template.UpdateInstallerAddOns.Add(path);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<string> GetAllUpdateInstallerÁddOn()
        {
            return template.UpdateInstallerAddOns;
        }

        public void RemoveUpdateInstallerAddOn(string path)
        {
            template.UpdateInstallerAddOns.RemoveIfContains(path);
        }
    }
}