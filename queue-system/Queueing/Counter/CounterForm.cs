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
    public partial class CounterForm : Form
    {
        public CounterForm()
        {
            InitializeComponent();
        }

        private void CounterForm_Load(object sender, EventArgs e)
        {
            LoadMyDetailsAsCounter();
            LoadMyQueues();
        }
        public void LoadMyDetailsAsCounter()
        {
            //lblUser.Text = Auth.FullName;
            //lblRole.Text = Auth.CurrentUserRoleName;

            LoadMyQueues();

            // Optional: auto-refresh every 5 seconds
            //var timer = new Timer();
            //timer.Interval = 5000;
            //timer.Tick += (s, args) => LoadMyQueues();
            //timer.Start();
            LoadMyQueues();
        }
        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auth.Logout(this);
        }

        private void LoadMyQueues()
        {
            //using (var db = new AppDbContext())
            //{
            //    // Get counter assigned to this logged-in user
            //    var counter = db.Counters.FirstOrDefault(c => c.user_id == Auth.CurrentUserId);

            //    if (counter == null)
            //    {
            //        lblOngoing.Text = "No counter assigned";
            //        lblNext.Text = "-";
            //        return;
            //    }

            //    // Find ongoing queue for this counter
            //    var ongoing = db.Queues
            //        .Where(q => q.counter_id == counter.id && q.status == "ongoing")
            //        .OrderByDescending(q => q.created_at)
            //        .FirstOrDefault();

            //    lblOngoing.Text = ongoing != null ? ongoing.queue_number : "None";

            //    // Find next queue for this counter's service type (first waiting)
            //    var next = db.Queues
            //        .Where(q => q.service_type_id == counter.service_type_id && q.status == "waiting")
            //        .OrderBy(q => q.created_at)
            //        .FirstOrDefault();

            //    lblNext.Text = next != null ? next.queue_number : "None";
            //}
        }
    }
}
