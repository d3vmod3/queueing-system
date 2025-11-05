using queue_system.Data;
using queue_system.Models;

namespace queue_system.Queueing
{
    public partial class GenerateQueueNumber : Form
    {
        public GenerateQueueNumber()
        {
            InitializeComponent();
        }

        private void GenerateQueueNumber_Load(object sender, EventArgs e)
        {
            LoadServiceTypes();
            LoadPriorities();
        }

        private void LoadServiceTypes()
        {
            using (var db = new AppDbContext())
            {
                var serviceTypes = db.ServiceTypes
                                     .OrderBy(s => s.service_name)
                                     .ToList();

                cmbServiceTypes.Items.Clear();

                // Optional: insert a default placeholder
                cmbServiceTypes.Items.Insert(0, "-- Select Service --");

                foreach (var service in serviceTypes)
                {
                    cmbServiceTypes.Items.Add(service.service_name);
                }

                cmbServiceTypes.SelectedIndex = 0; // show placeholder by default
            }
        }

        private void LoadPriorities()
        {
            using (var db = new AppDbContext())
            {
                var priorities = db.Priorities
                                   .OrderBy(p => p.priority_level)
                                   .ToList();

                cmbPriorities.Items.Clear();

                // Optional: insert default placeholder
                cmbPriorities.Items.Insert(0, "-- Select Priority --");

                foreach (var priority in priorities)
                {
                    cmbPriorities.Items.Add(priority.priority_name);
                }

                cmbPriorities.SelectedIndex = 0; // show placeholder
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbServiceTypes.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a service type.");
                return;
            }

            if (cmbPriorities.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a priority.");
                return;
            }

            using (var db = new AppDbContext())
            {
                // Get selected service type and priority
                string selectedService = cmbServiceTypes.SelectedItem.ToString();
                string selectedPriority = cmbPriorities.SelectedItem.ToString();

                // Get the corresponding Priority object
                var priority = db.Priorities.FirstOrDefault(p => p.priority_name == selectedPriority);
                if (priority == null)
                {
                    MessageBox.Show("Invalid priority selected.");
                    return;
                }

                // Get today’s date (ignore time)
                DateTime today = DateTime.UtcNow.Date;

                // Get the last queue number generated today
                var lastQueue = db.Queues
                                  .Where(q => q.created_at.Date == today)
                                  .OrderByDescending(q => q.id)
                                  .FirstOrDefault();

                int nextNumber = 1;

                if (lastQueue != null)
                {
                    // Extract numeric part of the last queue number
                    string lastNumStr = lastQueue.queue_number;
                    if (lastNumStr.Contains("-")) // e.g., "P-000001"
                        lastNumStr = lastNumStr.Split('-')[1];

                    if (int.TryParse(lastNumStr, out int lastNum))
                    {
                        nextNumber = lastNum + 1;
                    }
                }

                // Format the number with leading zeros
                string formattedNumber = nextNumber.ToString("D6");

                // Add "P-" prefix if priority level is 1
                string queueNumber = priority.priority_level == 1 ? $"P-{formattedNumber}" : formattedNumber;

                // Create new QueueEntry
                var serviceType = db.ServiceTypes.FirstOrDefault(s => s.service_name == selectedService);

                var newQueue = new QueueEntry
                {
                    queue_number = queueNumber,
                    service_type_id = serviceType.id,
                    priority_id = priority.id,
                    created_at = DateTime.UtcNow
                };

                db.Queues.Add(newQueue);
                db.SaveChanges();

                MessageBox.Show($"Queue number generated: {queueNumber}");
            }
        }

    }
}
