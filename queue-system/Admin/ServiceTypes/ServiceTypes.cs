using queue_system.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue_system.Admin.ServiceTypes
{
    public partial class ServiceTypes : Form
    {
        public ServiceTypes()
        {
            InitializeComponent();
        }

        private void ServiceTypes_Load(object sender, EventArgs e)
        {
            LoadServiceTypes();
        }

        private void LoadServiceTypes()
        {
            using (var db = new AppDbContext())
            {
                var serviceTypes = db.ServiceTypes
                                     .Select(s => new
                                     {
                                         s.id,
                                         s.service_name,
                                         s.created_at
                                     })
                                     .OrderBy(s => s.id)
                                     .ToList();

                dgvServiceTypes.DataSource = serviceTypes;
            }
        }

        private void dgvServiceTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvServiceTypes.Columns["assign_counters"].Index)
            {
                // Get the device_id from the clicked row
                int service_type_id = Convert.ToInt32(dgvServiceTypes.Rows[e.RowIndex].Cells["id"].Value);

                // Pass it to the QueueDisplay form
                Admin.ServiceTypes.AssignCounters assignCounters = new AssignCounters(service_type_id);
                assignCounters.ShowDialog();
            }
        }
    }
}
