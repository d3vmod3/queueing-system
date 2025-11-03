using queue_system.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace queue_system.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { } // parameterless for runtime

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<QueueEntry> Queues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Program.ConnString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType { id = 1, service_name = "Customer Service" },
                new ServiceType { id = 2, service_name = "Cashier" },
                new ServiceType { id = 3, service_name = "Technical Support" },
                new ServiceType { id = 4, service_name = "Billing" },
                new ServiceType { id = 5, service_name = "HR" },
                new ServiceType { id = 6, service_name = "IT Helpdesk" },
                new ServiceType { id = 7, service_name = "Maintenance" },
                new ServiceType { id = 8, service_name = "Reception" }
            );

            // --- Priorities ---
            modelBuilder.Entity<Priority>().HasData(
                new Priority { id = 1, priority_name = "Senior Citizen", priority_level = 1 },
                new Priority { id = 2, priority_name = "PWD", priority_level = 1 },
                new Priority { id = 3, priority_name = "Regular", priority_level = 2 }
            );

            // --- Counters ---
            modelBuilder.Entity<Counter>().HasData(
                new Counter { id = 1, counter_name = "Counter 1", service_type_id = 1 },
                new Counter { id = 2, counter_name = "Counter 2", service_type_id = 1 },
                new Counter { id = 3, counter_name = "Counter 3", service_type_id = 1 },
                new Counter { id = 4, counter_name = "Counter 4", service_type_id = 2 },
                new Counter { id = 5, counter_name = "Counter 5", service_type_id = 3 },
                new Counter { id = 6, counter_name = "Counter 6", service_type_id = 4 },
                new Counter { id = 7, counter_name = "Counter 7", service_type_id = 5 },
                new Counter { id = 8, counter_name = "Counter 8", service_type_id = 6 },
                new Counter { id = 9, counter_name = "Counter 9", service_type_id = 7 },
                new Counter { id = 10, counter_name = "Counter 10", service_type_id = 8 }
            );
        }
    }
}
