using System.Collections.Generic;

namespace queue_system.Models
{
    public class Priority
    {
        public int id { get; set; }
        public string priority_name { get; set; } = string.Empty;
        public int priority_level { get; set; } = 2; // 1 = high (SC/PWD), 2 = regular
    }
}