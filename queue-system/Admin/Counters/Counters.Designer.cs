namespace queue_system.Admin.Counters
{
    partial class Counters
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
            dgvCounters = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            counter_name = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            service_type_id = new DataGridViewTextBoxColumn();
            service_type = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            counterBindingSource = new BindingSource(components);
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCounters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCounters
            // 
            dgvCounters.AllowUserToAddRows = false;
            dgvCounters.AllowUserToDeleteRows = false;
            dgvCounters.AutoGenerateColumns = false;
            dgvCounters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCounters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCounters.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, counter_name, created_at, service_type_id, service_type, edit });
            dgvCounters.DataSource = counterBindingSource;
            dgvCounters.Location = new Point(12, 53);
            dgvCounters.Name = "dgvCounters";
            dgvCounters.ReadOnly = true;
            dgvCounters.RowHeadersVisible = false;
            dgvCounters.Size = new Size(776, 385);
            dgvCounters.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // counter_name
            // 
            counter_name.DataPropertyName = "counter_name";
            counter_name.HeaderText = "Counter Name";
            counter_name.Name = "counter_name";
            counter_name.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Date Created";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // service_type_id
            // 
            service_type_id.DataPropertyName = "service_type_id";
            service_type_id.HeaderText = "service_type_id";
            service_type_id.Name = "service_type_id";
            service_type_id.ReadOnly = true;
            service_type_id.Visible = false;
            // 
            // service_type
            // 
            service_type.DataPropertyName = "service_type";
            service_type.HeaderText = "Service Type";
            service_type.Name = "service_type";
            service_type.ReadOnly = true;
            // 
            // edit
            // 
            edit.HeaderText = "";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // counterBindingSource
            // 
            counterBindingSource.DataSource = typeof(Models.Counter);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Counter";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(682, 23);
            textBox1.TabIndex = 2;
            // 
            // Counters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dgvCounters);
            Name = "Counters";
            Text = "Counters";
            Load += Counters_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCounters).EndInit();
            ((System.ComponentModel.ISupportInitialize)counterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCounters;
        private BindingSource counterBindingSource;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn counter_name;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn service_type_id;
        private DataGridViewTextBoxColumn service_type;
        private DataGridViewButtonColumn edit;
        private TextBox textBox1;
    }
}