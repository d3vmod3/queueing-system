using System.Collections.Generic;

namespace queue_system.Models
{

    public class Device
    {
        public int id { get; set; }
        public string device_name { get; set; } = string.Empty;
        public string? device_identifier { get; set; } = string.Empty;
        public DateTime created_at { get; set; }

    }
    
}
