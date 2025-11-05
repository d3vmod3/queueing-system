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

        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auth.Logout(this);
        }
    }
}
