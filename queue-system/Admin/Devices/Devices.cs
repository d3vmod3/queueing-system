using Npgsql;
using queue_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace queue_system.Admin.Devices
{
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
        }

        private void dgvDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDevices.Columns["preview_device"].Index)
            {
                // Get the device_id from the clicked row
                int deviceId = Convert.ToInt32(dgvDevices.Rows[e.RowIndex].Cells["id"].Value);

                // Pass it to the QueueDisplay form
                QueueDisplay previewQueue = new QueueDisplay(deviceId);
                previewQueue.ShowDialog();
            }
        }

        private void Devices_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void LoadDevices()
        {
            string connString = Program.ConnString;
            using (var conn = new NpgsqlConnection(connString))
            {
                var devices = conn.Query<Device>("SELECT * FROM \"Devices\"").ToList();
                dgvDevices.DataSource = devices;
            }
        }

    }
}
