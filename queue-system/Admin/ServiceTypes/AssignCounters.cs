using queue_system.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue_system.Admin.ServiceTypes
{
    public partial class AssignCounters : Form
    {
        private int service_type_id;
        public AssignCounters(int? serviceTypeId)
        {
            if (serviceTypeId != null)
            {
                service_type_id = (int)serviceTypeId;

            }
            InitializeComponent();
        }

        private void AssignCounters_Load(object sender, EventArgs e)
        {
            LoadCountersWithoutServiceTypesYet();
        }

        private void LoadCountersWithoutServiceTypesYet()
        {
            using (var db = new AppDbContext())
            {
                var counters = db.Counters
                                 .Where(c => c.service_type_id == null || c.service_type_id == service_type_id)
                                 .OrderBy(c => c.id)
                                 .ToList();

                foreach (var c in counters)
                {
                    c.set_counter = c.service_type_id == service_type_id;
                }

                dgvCounters.DataSource = new BindingList<Models.Counter>(counters);

                // Make the checkbox column editable
                if (dgvCounters.Columns["set_counter"] != null)
                {
                    dgvCounters.Columns["set_counter"].ReadOnly = false;
                    dgvCounters.Columns["set_counter"].HeaderText = "Select";
                }
            }
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                foreach (DataGridViewRow row in dgvCounters.Rows)
                {
                    // Make sure the row is not a new row
                    if (row.IsNewRow) continue;

                    // Get the checkbox value
                    bool isSelected = Convert.ToBoolean(row.Cells["set_counter"].Value);

                    // Get the counter ID
                    int counterId = Convert.ToInt32(row.Cells["id"].Value);

                    if (isSelected)
                    {
                        // Assign this counter to the current service type
                        var counter = db.Counters.FirstOrDefault(c => c.id == counterId);
                        if (counter != null)
                        {
                            counter.service_type_id = service_type_id;
                        }
                    }
                    else
                    {
                        var counter = db.Counters.FirstOrDefault(c => c.id == counterId);
                        if (counter != null)
                        {
                            counter.service_type_id = null;
                        }
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Selected counters have been assigned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
