namespace queue_system.Admin.ServiceTypes
{
    partial class ServiceTypes
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
            dgvServiceTypes = new DataGridView();
            serviceTypeBindingSource = new BindingSource(components);
            counterBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            service_type = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            assign_counters = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvServiceTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvServiceTypes
            // 
            dgvServiceTypes.AllowUserToAddRows = false;
            dgvServiceTypes.AllowUserToDeleteRows = false;
            dgvServiceTypes.AutoGenerateColumns = false;
            dgvServiceTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceTypes.Columns.AddRange(new DataGridViewColumn[] { id, service_type, created_at, edit, assign_counters });
            dgvServiceTypes.DataSource = serviceTypeBindingSource;
            dgvServiceTypes.Location = new Point(12, 56);
            dgvServiceTypes.Name = "dgvServiceTypes";
            dgvServiceTypes.ReadOnly = true;
            dgvServiceTypes.RowHeadersVisible = false;
            dgvServiceTypes.Size = new Size(776, 385);
            dgvServiceTypes.TabIndex = 3;
            dgvServiceTypes.CellContentClick += dgvServiceTypes_CellContentClick;
            // 
            // serviceTypeBindingSource
            // 
            serviceTypeBindingSource.DataSource = typeof(Models.ServiceType);
            // 
            // counterBindingSource
            // 
            counterBindingSource.DataSource = typeof(Models.Counter);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(682, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Search Counter";
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // service_type
            // 
            service_type.DataPropertyName = "service_name";
            service_type.HeaderText = "Service Type";
            service_type.Name = "service_type";
            service_type.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Date Created";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // edit
            // 
            edit.HeaderText = "";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // assign_counters
            // 
            assign_counters.HeaderText = "";
            assign_counters.Name = "assign_counters";
            assign_counters.ReadOnly = true;
            assign_counters.Text = "Assign Counters";
            assign_counters.UseColumnTextForButtonValue = true;
            // 
            // ServiceTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvServiceTypes);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ServiceTypes";
            Text = "ServiceTypes";
            Load += ServiceTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServiceTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)counterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServiceTypes;
        private BindingSource serviceTypeBindingSource;
        private BindingSource counterBindingSource;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn service_type;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn assign_counters;
    }
}