using System.Collections.Generic;

namespace queue_system.Models
{
    public class Permission
    {
        public int id { get; set; }
        public string module { get; set; } = string.Empty;
        public bool can_view { get; set; } = false;
        public bool can_edit { get; set; } = false;
        public bool can_delete { get; set; } = false;
        public int user_role_id { get; set; }  // FK
    }
}
