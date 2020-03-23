using global::System.IO;
using global::Newtonsoft.Json.Linq;

namespace SM64_ROM_Manager.Updating
{
    public class UpdateInfoManager
    {
        public UpdateInfo UpdateInfo { get; private set; }

        public UpdateInfoManager()
        {
            NewInfo();
        }

        public void Load(string filePath)
        {
            UpdateInfo = JObject.Parse(File.ReadAllText(filePath)).ToObject<UpdateInfo>();
        }

        public void Save(string filePath)
        {
            File.WriteAllText(filePath, JObject.FromObject(UpdateInfo).ToString());
        }

        public void NewInfo()
        {
            UpdateInfo = new UpdateInfo();
        }
    }
}