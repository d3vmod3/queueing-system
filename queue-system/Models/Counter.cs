using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace queue_system.Models
{
    public class Counter
    {
        public int id { get; set; }
        public string counter_name { get; set; } = string.Empty;
        public DateTime created_at { get; set; }
        // Foreign Key
        public int? service_type_id { get; set; }

        public bool? is_active { get; set; } = true;
        [NotMapped]
        public bool set_counter { get; set; }
        public int? user_id { get; set; } // assigned user
    }
}
