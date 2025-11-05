namespace queue_system.Queueing
{
    partial class AvailableCounters
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
            label1 = new Label();
            cmbAvailableCounters = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose Counter:";
            // 
            // cmbAvailableCounters
            // 
            cmbAvailableCounters.FormattingEnabled = true;
            cmbAvailableCounters.Location = new Point(114, 6);
            cmbAvailableCounters.Name = "cmbAvailableCounters";
            cmbAvailableCounters.Size = new Size(322, 23);
            cmbAvailableCounters.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(282, 75);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(363, 75);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AvailableCounters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 110);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cmbAvailableCounters);
            Controls.Add(label1);
            Name = "AvailableCounters";
            Text = "AvailableCounters";
            Load += AvailableCounters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbAvailableCounters;
        private Button btnOk;
        private Button btnCancel;
    }
}