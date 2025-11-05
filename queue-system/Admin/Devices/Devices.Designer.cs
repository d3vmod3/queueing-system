namespace queue_system.Admin.Devices
{
    partial class Devices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvDevices = new DataGridView();
            deviceBindingSource = new BindingSource(components);
            id = new DataGridViewTextBoxColumn();
            device_name = new DataGridViewTextBoxColumn();
            device_identifier = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            preview_device = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deviceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvDevices
            // 
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.AutoGenerateColumns = false;
            dgvDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevices.Columns.AddRange(new DataGridViewColumn[] { id, device_name, device_identifier, created_at, preview_device });
            dgvDevices.DataSource = deviceBindingSource;
            dgvDevices.Location = new Point(12, 12);
            dgvDevices.Name = "dgvDevices";
            dgvDevices.ReadOnly = true;
            dgvDevices.RowHeadersVisible = false;
            dgvDevices.Size = new Size(948, 599);
            dgvDevices.TabIndex = 0;
            dgvDevices.CellContentClick += dgvDevices_CellContentClick;
            // 
            // deviceBindingSource
            // 
            deviceBindingSource.DataSource = typeof(Models.Device);
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // device_name
            // 
            device_name.DataPropertyName = "device_name";
            device_name.HeaderText = "Device Name";
            device_name.Name = "device_name";
            device_name.ReadOnly = true;
            // 
            // device_identifier
            // 
            device_identifier.DataPropertyName = "device_identifier";
            device_identifier.HeaderText = "Identifier";
            device_identifier.Name = "device_identifier";
            device_identifier.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Date Created";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // preview_device
            // 
            preview_device.HeaderText = "";
            preview_device.Name = "preview_device";
            preview_device.ReadOnly = true;
            preview_device.Text = "Preview";
            preview_device.UseColumnTextForButtonValue = true;
            // 
            // Devices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 623);
            Controls.Add(dgvDevices);
            Name = "Devices";
            Text = "Devices";
            Load += Devices_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            ((System.ComponentModel.ISupportInitialize)deviceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDevices;
        private BindingSource deviceBindingSource;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn device_name;
        private DataGridViewTextBoxColumn device_identifier;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewButtonColumn preview_device;
    }
}