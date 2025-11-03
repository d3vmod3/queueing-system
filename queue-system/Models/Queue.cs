using System;

namespace queue_system.Models
{
    public class QueueEntry
    {
        public int id { get; set; }
        public string queue_number { get; set; } = string.Empty;
        public string? status { get; set; } = "waiting";
        public DateTime created_at { get; set; } = DateTime.Now;
        public int? service_type_id { get; set; }
        public int? priority_id { get; set; }
        public int? counter_id { get; set; }

        public DateTime? called_time { get; set; }
        public DateTime? served_time { get; set; }
        public DateTime? finished_time { get; set; }
    }
}
