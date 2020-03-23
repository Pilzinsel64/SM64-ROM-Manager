
namespace SM64_ROM_Manager.PatchScripts
{
    internal class SerializedAssemblyMember
    {
        public string Name { get; private set; }
        public string Path { get; private set; }
        public string Description { get; private set; }
        public SerializedAssemblyMemberType Type { get; private set; }
        public SerializedAssemblyMemberParam[] Params { get; private set; }

        public SerializedAssemblyMember(string name, string path, string description, SerializedAssemblyMemberType type, SerializedAssemblyMemberParam[] @params)
        {
            Name = name;
            Path = path;
            Description = description;
            Type = type;
            Params = @params;
        }
    }
}