using queue_system.Data;
using queue_system.Models;
using queue_system.Queueing;
using System.Drawing;

namespace queue_system
{
    public partial class QueueDisplay : Form
    {
        private int device_id;
        public QueueDisplay(int? deviceId)
        {
            if (deviceId != null)
            {
                device_id = (int)deviceId;
            }

            InitializeComponent();
        }

        private void Queue_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.SetRowSpan(panel1, 2);
            panel1.Height = 200;

            tableLayoutPanel1.SetRowSpan(panel2, 6);
            panel2.Height = 800;
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\3k's Photobooth\Documents\alexie\sample-loop-video.mp4";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);


            if (device_id != 0)
                loadSlots();
        }


        public void loadSlots()
        {
            using (var context = new AppDbContext())
            {
                // Include related Counter entity for each Slot
                var slots = context.Slots
                    .Where(s => s.device_id == device_id)
                    .Join(context.Counters,
                          slot => slot.counter_id,
                          counter => counter.id,
                          (slot, counter) => new
                          {
                              slot.slot_number,
                              slot.counter_id,
                              counter.counter_name
                          })
                    .ToList();

                // We'll also get slots without counter_id (LEFT JOIN equivalent)
                var allSlots = context.Slots
                    .Where(s => s.device_id == device_id)
                    .ToList();

                foreach (var slot in allSlots)
                {
                    string labelName = $"lblSlot{slot.slot_number}";
                    var label = tableLayoutPanel1.Controls.Find(labelName, true).FirstOrDefault() as Label;

                    if (label != null)
                    {
                        if (slot.counter_id == null)
                        {
                            label.Text = "This slot is open";
                            label.ForeColor = Color.Gray;
                        }
                        else
                        {
                            // get the counter name for this slot
                            var counter = context.Counters.FirstOrDefault(c => c.id == slot.counter_id);
                            label.Text = counter != null ? counter.counter_name : "Unknown Counter";
                            label.ForeColor = Color.Black;
                        }
                    }
                }
            }
            setLabelsClickEvent();
        }

        public void setLabelsClickEvent()
        {
            lblSlot1.Tag = 1;
            lblSlot2.Tag = 2;
            lblSlot3.Tag = 3;
            lblSlot4.Tag = 4;
            lblSlot5.Tag = 5;
            lblSlot6.Tag = 6;
            lblSlot7.Tag = 7;
            lblSlot8.Tag = 8;
            lblSlot10.Tag = 10;

            // Assign the same click handler to all labels
            lblSlot1.MouseClick += AssignCounter_Click;
            lblSlot2.MouseClick += AssignCounter_Click;
            lblSlot3.MouseClick += AssignCounter_Click;
            lblSlot4.MouseClick += AssignCounter_Click;
            lblSlot5.MouseClick += AssignCounter_Click;
            lblSlot6.MouseClick += AssignCounter_Click;
            lblSlot7.MouseClick += AssignCounter_Click;
            lblSlot8.MouseClick += AssignCounter_Click;
            lblSlot9.MouseClick += AssignCounter_Click;
            lblSlot10.MouseClick += AssignCounter_Click;

            lblSlot1.MouseDown += SlotLabel_MouseDown;
            lblSlot2.MouseDown += SlotLabel_MouseDown;
            lblSlot3.MouseDown += SlotLabel_MouseDown;
            lblSlot4.MouseDown += SlotLabel_MouseDown;
            lblSlot5.MouseDown += SlotLabel_MouseDown;
            lblSlot6.MouseDown += SlotLabel_MouseDown;
            lblSlot7.MouseDown += SlotLabel_MouseDown;
            lblSlot8.MouseDown += SlotLabel_MouseDown;
            lblSlot9.MouseDown += SlotLabel_MouseDown;
            lblSlot10.MouseDown += SlotLabel_MouseDown;

            menuItemClearSlot.Click += MenuItemClearSlot_Click;
        }
        private void AssignCounter_Click(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null) return;

            using (AvailableCounters countersForm = new AvailableCounters())
            {
                if (countersForm.ShowDialog() == DialogResult.OK)
                {
                    string selectedCounter = countersForm.SelectedCounter;

                    using (var db = new AppDbContext())
                    {
                        // Check if the counter is already assigned to any slot
                        bool isAssigned = db.Slots
                            .Where(s => s.counter_id != null)
                            .Join(db.Counters,
                                  s => s.counter_id,
                                  c => c.id,
                                  (s, c) => c.counter_name)
                            .Any(name => name == selectedCounter);

                        if (isAssigned)
                        {
                            MessageBox.Show($"'{selectedCounter}' is already assigned to another slot.", "Counter Assigned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // exit without assigning
                        }

                        // Update the label text to show the selected counter
                        clickedLabel.Text = selectedCounter;
                        clickedLabel.ForeColor = Color.Black;

                        int slotNumber = (int)clickedLabel.Tag;

                        // Assign the counter to the slot in DB
                        var slot = db.Slots.Find(slotNumber);
                        if (slot != null)
                        {
                            var counter = db.Counters.FirstOrDefault(c => c.counter_name == selectedCounter);
                            if (counter != null)
                            {
                                slot.counter_id = counter.id;
                                db.SaveChanges();
                            }
                        }

                        // Optional: also store in memory if needed
                        AssignCounterToSlot(slotNumber, selectedCounter);
                    }
                }
            }
        }

        private void SlotLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel == null) return;

            // Only show context menu if right-click AND the slot has a counter assigned
            if (e.Button == MouseButtons.Right)
            {
                if (clickedLabel.Text != "This slot is open")
                {
                    clickedLabel.ContextMenuStrip = cmsCounterAction;
                }
                else
                {
                    clickedLabel.ContextMenuStrip = null; // hide menu
                }
            }
        }

        private void MenuItemClearSlot_Click(object sender, EventArgs e)
        {
            Label clickedLabel = cmsCounterAction.SourceControl as Label;
            if (clickedLabel.Text == "This slot is open")
            {
                return;
            }
            if (clickedLabel == null) return;

            // Reset the label text and color
            clickedLabel.Text = "This slot is open";
            clickedLabel.ForeColor = Color.Gray;

            // Get slot number from label Tag
            int slotNumber = (int)clickedLabel.Tag;

            // Remove the counter assignment in the database
            using (var db = new AppDbContext())
            {
                var slot = db.Slots.Find(slotNumber);
                if (slot != null)
                {
                    slot.counter_id = null;
                    db.SaveChanges();
                }
            }

            // Optional: update in-memory or UI logic
            AssignCounterToSlot(slotNumber, null);
        }


        private void AssignCounterToSlot(int slotNumber, string counterName)
        {
            // TODO: save the selected counter for the slot
            // Example: update database or in-memory object
            MessageBox.Show($"Slot {slotNumber} assigned to {counterName}");
        }
    }
}
