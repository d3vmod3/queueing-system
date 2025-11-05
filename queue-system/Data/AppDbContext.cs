using Microsoft.EntityFrameworkCore;
using queue_system.Helpers;
using queue_system.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Slot> Slots { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Program.ConnString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- ServiceTypes ---
            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType { id = 1, service_name = "Customer Service", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)},
                new ServiceType { id = 2, service_name = "Cashier", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)},
                new ServiceType { id = 3, service_name = "Technical Support", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)},
                new ServiceType { id = 4, service_name = "Billing", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)},
                new ServiceType { id = 5, service_name = "HR", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)},
                new ServiceType { id = 6, service_name = "IT Helpdesk", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)},
                new ServiceType { id = 7, service_name = "Maintenance", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)},
                new ServiceType { id = 8, service_name = "Reception", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc)}
            );

            // --- Counters ---
            modelBuilder.Entity<Counter>().HasData(
                new Counter { id = 1, counter_name = "Counter 1", service_type_id = 1, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 2, counter_name = "Counter 2", service_type_id = 1, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 3, counter_name = "Counter 3", service_type_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 4, counter_name = "Counter 4", service_type_id = 2, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 5, counter_name = "Counter 5", service_type_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 6, counter_name = "Counter 6", service_type_id = 4, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 7, counter_name = "Counter 7", service_type_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 8, counter_name = "Counter 8", service_type_id = 6, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 9, counter_name = "Counter 9", service_type_id = 7, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 10, counter_name = "Counter 10", service_type_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 11, counter_name = "Counter 11", service_type_id = 1, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 12, counter_name = "Counter 12", service_type_id = 2, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 13, counter_name = "Counter 13", service_type_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 14, counter_name = "Counter 14", service_type_id = 4, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 15, counter_name = "Counter 15", service_type_id = 5, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 16, counter_name = "Counter 16", service_type_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 17, counter_name = "Counter 17", service_type_id = 7, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 18, counter_name = "Counter 18", service_type_id = 8, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 19, counter_name = "Counter 19", service_type_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Counter { id = 20, counter_name = "Counter 20", service_type_id = 2, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) }
            );


            modelBuilder.Entity<Device>().HasData(
                new Device { id = 1, device_name = "Device 1", device_identifier = "A1F3B7C9", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Device { id = 2, device_name = "Device 2", device_identifier = "B2E4C8D0", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Device { id = 3, device_name = "Device 3", device_identifier = "C3D5E9F1", created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) }
            );


            // --- Priorities ---
            modelBuilder.Entity<Priority>().HasData(
                new Priority { id = 1, priority_name = "Senior Citizen", priority_level = 1 },
                new Priority { id = 2, priority_name = "PWD", priority_level = 1 },
                new Priority { id = 3, priority_name = "Regular", priority_level = 2 }
            );

            

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { id = 1, role_name = "Super Admin" },
                new UserRole { id = 2, role_name = "Admin" },
                new UserRole { id = 3, role_name = "User" }
            );

            // --- Users (example 10 users) ---
            modelBuilder.Entity<User>().HasData(
                new User { id = 1, username = "superadmin", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 1, first_name = "John", last_name = "Doe", gender = "M", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 2, username = "admin", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 2, first_name = "Jane", last_name = "Smith", gender = "F", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 3, username = "user", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "Alice", last_name = "Brown", gender = "F", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 4, username = "user2", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "Bob", last_name = "White", gender = "M", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 5, username = "user3", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "Charlie", last_name = "Green", gender = "M", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 6, username = "user4", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "Diana", last_name = "Blue", gender = "F", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 7, username = "user5", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "Ethan", last_name = "Black", gender = "M", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 8, username = "user6", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "Fiona", last_name = "Gray", gender = "F", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 9, username = "user7", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "George", last_name = "Yellow", gender = "M", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new User { id = 10, username = "user8", password = "ju3R7lu9bJTW7tWN4qygK7KqqvHX2m8XjYaI3kcfRQLha+xgpYEhriE3tfz3Olka", user_role_id = 3, first_name = "Hannah", last_name = "Red", gender = "F", is_active = true, is_reset = true, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) }
            );

            // --- Permissions (blank for now) ---
            modelBuilder.Entity<Permission>().HasData(
                new Permission { id = 1, module = "Module1", can_view = false, can_edit = false, can_delete = false, user_role_id = 1 },
                new Permission { id = 2, module = "Module2", can_view = false, can_edit = false, can_delete = false, user_role_id = 2 },
                new Permission { id = 3, module = "Module3", can_view = false, can_edit = false, can_delete = false, user_role_id = 3 }
            );

            modelBuilder.Entity<Slot>().HasData(
                // Device 1 — Counters 1–4
                new Slot { id = 1, device_id = 1, slot_number = 1, counter_id = 1, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 2, device_id = 1, slot_number = 2, counter_id = 2, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 3, device_id = 1, slot_number = 3, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 4, device_id = 1, slot_number = 4, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 5, device_id = 1, slot_number = 5, counter_id = 3, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 6, device_id = 1, slot_number = 6, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 7, device_id = 1, slot_number = 7, counter_id = 4, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 8, device_id = 1, slot_number = 8, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 9, device_id = 1, slot_number = 9, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 10, device_id = 1, slot_number = 10, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },

                // Device 2 — Counters 5–7
                new Slot { id = 11, device_id = 2, slot_number = 1, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 12, device_id = 2, slot_number = 2, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 13, device_id = 2, slot_number = 3, counter_id = 5, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 14, device_id = 2, slot_number = 4, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 15, device_id = 2, slot_number = 5, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 16, device_id = 2, slot_number = 6, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 17, device_id = 2, slot_number = 7, counter_id = 6, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 18, device_id = 2, slot_number = 8, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 19, device_id = 2, slot_number = 9, counter_id = 7, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 20, device_id = 2, slot_number = 10, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },

                // Device 3 — Counters 8–10
                new Slot { id = 21, device_id = 3, slot_number = 1, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 22, device_id = 3, slot_number = 2, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 23, device_id = 3, slot_number = 3, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 24, device_id = 3, slot_number = 4, counter_id = 8, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 25, device_id = 3, slot_number = 5, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 26, device_id = 3, slot_number = 6, counter_id = 9, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 27, device_id = 3, slot_number = 7, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 28, device_id = 3, slot_number = 8, counter_id = 10, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 29, device_id = 3, slot_number = 9, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) },
                new Slot { id = 30, device_id = 3, slot_number = 10, counter_id = null, created_at = new DateTime(2025, 11, 3, 8, 0, 0, DateTimeKind.Utc) }
            );

        }
    }
}
