using System.Collections.Generic;

namespace queue_system.Models
{
    public class Counter
    {
        public int id { get; set; }
        public string counter_name { get; set; } = string.Empty;

        // Foreign Key
        public int? service_type_id { get; set; }

    }
}
