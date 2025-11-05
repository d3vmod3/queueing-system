namespace queue_system.Queueing
{
    partial class GenerateQueueNumber
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
            cmbServiceTypes = new ComboBox();
            cmbPriorities = new ComboBox();
            label2 = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose Service Type:";
            // 
            // cmbServiceTypes
            // 
            cmbServiceTypes.FormattingEnabled = true;
            cmbServiceTypes.Location = new Point(136, 6);
            cmbServiceTypes.Name = "cmbServiceTypes";
            cmbServiceTypes.Size = new Size(212, 23);
            cmbServiceTypes.TabIndex = 1;
            // 
            // cmbPriorities
            // 
            cmbPriorities.FormattingEnabled = true;
            cmbPriorities.Location = new Point(136, 55);
            cmbPriorities.Name = "cmbPriorities";
            cmbPriorities.Size = new Size(212, 23);
            cmbPriorities.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 58);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Priority Type:";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(266, 120);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(82, 30);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // GenerateQueueNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 159);
            Controls.Add(btnGenerate);
            Controls.Add(cmbPriorities);
            Controls.Add(label2);
            Controls.Add(cmbServiceTypes);
            Controls.Add(label1);
            Name = "GenerateQueueNumber";
            Text = "Generate Queue Number";
            Load += GenerateQueueNumber_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbServiceTypes;
        private ComboBox cmbPriorities;
        private Label label2;
        private Button btnGenerate;
    }
}