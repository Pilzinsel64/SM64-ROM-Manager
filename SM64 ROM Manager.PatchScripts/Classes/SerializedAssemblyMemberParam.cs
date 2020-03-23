
namespace SM64_ROM_Manager.PatchScripts
{
    internal class SerializedAssemblyMemberParam
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string TypeString { get; private set; }

        public SerializedAssemblyMemberParam(string name, string description, string typeString)
        {
            Name = name;
            Description = description;
            TypeString = typeString;
        }
    }
}