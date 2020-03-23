using System.Collections.Generic;

namespace SM64_ROM_Manager.UserRequests
{
    public class UserRequest
    {

        // F i e l d s

        private readonly List<UserRequestProperty> props = new List<UserRequestProperty>();

        // P r o p e r t i e s

        public string RequestName { get; private set; }
        internal UserRequestUploadSettings UploadSettings { get; private set; }

        public IReadOnlyList<UserRequestProperty> Properties
        {
            get
            {
                return props;
            }
        }

        // C o n s t r u c t o r

        public UserRequest(UserRequestLayout style)
        {
            props.AddRange(style.Properties);
            UploadSettings = style.UploadSettings;
            RequestName = style.Name;
        }
    }
}