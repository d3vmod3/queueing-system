using System.Collections.Generic;

namespace queue_system.Models
{

    public class Slot
    {
        public int id { get; set; }
        public int? counter_id { get; set; }
        public int slot_number { get; set; }
        public int device_id { get; set; }
        public DateTime created_at { get; set; }
    }

}
