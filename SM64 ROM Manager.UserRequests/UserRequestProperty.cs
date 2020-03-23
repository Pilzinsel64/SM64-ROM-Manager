
namespace SM64_ROM_Manager.UserRequests
{
    public class UserRequestProperty
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public UserRequestPropertyType Type { get; set; } = UserRequestPropertyType.Files;
        public bool AllowEmptyState { get; set; }
    }
}