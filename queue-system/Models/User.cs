using System.Collections.Generic;

namespace queue_system.Models
{
    public class User
    {
        public int id { get; set; }
        public int user_role_id { get; set; }  // FK

        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public bool is_reset { get; set; } = true;

        public string first_name { get; set; } = string.Empty;
        public string? middle_name { get; set; }
        public string last_name { get; set; } = string.Empty;
        public string? suffix { get; set; }
        public string gender { get; set; } = string.Empty;
        public DateTime created_at { get; set; }
        public bool is_active { get; set; } = true;
    }
}
