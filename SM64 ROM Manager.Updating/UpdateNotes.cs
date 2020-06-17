using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM64_ROM_Manager.Updating
{
    public class UpdateNotes
    {
        public string Content { get; set; }
        public UpdateNotesContentType ContentType { get; set; } = UpdateNotesContentType.PlainText;
    }
}
