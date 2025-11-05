namespace queue_system.Admin.ServiceTypes
{
    partial class AssignCounters
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
            id = new DataGridViewTextBoxColumn();
            set_counter = new DataGridViewCheckBoxColumn();
            counter_name = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            servicetypeidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            counterBindingSource = new BindingSource(components);
            label1 = new Label();
            textBox1 = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCounters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)counterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCounters
            // 
            dgvCounters.AllowUserToAddRows = false;
            dgvCounters.AllowUserToDeleteRows = false;
            dgvCounters.AutoGenerateColumns = false;
            dgvCounters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCounters.Columns.AddRange(new DataGridViewColumn[] { id, set_counter, counter_name, created_at, servicetypeidDataGridViewTextBoxColumn });
            dgvCounters.DataSource = counterBindingSource;
            dgvCounters.Location = new Point(12, 51);
            dgvCounters.Name = "dgvCounters";
            dgvCounters.Size = new Size(776, 387);
            dgvCounters.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // set_counter
            // 
            set_counter.DataPropertyName = "set_counter";
            set_counter.FalseValue = "False";
            set_counter.HeaderText = "Select Counters";
            set_counter.Name = "set_counter";
            set_counter.TrueValue = "True";
            // 
            // counter_name
            // 
            counter_name.DataPropertyName = "counter_name";
            counter_name.HeaderText = "Counter Name";
            counter_name.Name = "counter_name";
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "created_at";
            created_at.Name = "created_at";
            // 
            // servicetypeidDataGridViewTextBoxColumn
            // 
            servicetypeidDataGridViewTextBoxColumn.DataPropertyName = "service_type_id";
            servicetypeidDataGridViewTextBoxColumn.HeaderText = "service_type_id";
            servicetypeidDataGridViewTextBoxColumn.Name = "servicetypeidDataGridViewTextBoxColumn";
            servicetypeidDataGridViewTextBoxColumn.Visible = false;
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
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Counter:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(679, 23);
            textBox1.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(632, 447);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(713, 447);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AssignCounters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dgvCounters);
            Name = "AssignCounters";
            Text = "Assign Counters";
            Load += AssignCounters_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCounters).EndInit();
            ((System.ComponentModel.ISupportInitialize)counterBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCounters;
        private Label label1;
        private TextBox textBox1;
        private BindingSource counterBindingSource;
        private Button btnSave;
        private Button btnClose;
        private DataGridViewTextBoxColumn id;
        private DataGridViewCheckBoxColumn set_counter;
        private DataGridViewTextBoxColumn counter_name;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn servicetypeidDataGridViewTextBoxColumn;
    }
}