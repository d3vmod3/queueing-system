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

namespace queue_system.Queueing
{
    public partial class AvailableCounters : Form
    {
        public string SelectedCounter { get; private set; } = null; // stores user's choice

        public AvailableCounters()
        {
            InitializeComponent();
        }

        private void AvailableCounters_Load(object sender, EventArgs e)
        {
            LoadAvailableCounters();
        }

        public void LoadAvailableCounters()
        {
            //load the available counters from database in the combobox "cmbAvailableCounters"
            try
            {
                using (var db = new AppDbContext())
                {
                    // Get all counters that are NOT assigned to any slot
                    var assignedCounterIds = db.Slots
                                               .Where(s => s.counter_id != null)
                                               .Select(s => s.counter_id.Value)
                                               .ToList();

                    var availableCounters = db.Counters
                                              .Where(c => !assignedCounterIds.Contains(c.id))
                                              .OrderBy(c => c.id)
                                              .Select(c => c.counter_name)
                                              .ToList();

                    cmbAvailableCounters.Items.Clear();
                    cmbAvailableCounters.Items.AddRange(availableCounters.ToArray());
                    cmbAvailableCounters.Items.Insert(0,"-- Select a Counter --");
                    cmbAvailableCounters.SelectedIndex = 0; // default select first
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load available counters: " + ex.Message);
            }
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbAvailableCounters.SelectedIndex != 0)
            {
                SelectedCounter = cmbAvailableCounters.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK; // close the form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a counter.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
