using queue_system.Data;
using queue_system.Models;

namespace queue_system.Admin.Counters
{
    public partial class Counters : Form
    {
        public Counters()
        {
            InitializeComponent();
        }

        private void Counters_Load(object sender, EventArgs e)
        {
            LoadCounters();
        }

        private void LoadCounters()
        {
            using (var db = new AppDbContext())
            {
                // Get counters with their related service type
                var counters = db.Counters
                                 .Join(db.ServiceTypes,
                                       counter => counter.service_type_id,
                                       service => service.id,
                                       (counter, service) => new
                                       {
                                           counter.id,
                                           counter.counter_name,
                                           service_type = service.service_name,
                                           counter.created_at
                                       })
                                 .OrderBy(c => c.id)
                                 .ToList();

                // Bind to DataGridView
                dgvCounters.DataSource = counters;
                
            }
        }
    }
}
