namespace queue_system.Queueing
{
    partial class Counter
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnNext = new Button();
            lblOngoing = new Label();
            lblNext = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            takeABreakToolStripMenuItem = new ToolStripMenuItem();
            takeABreakToolStripMenuItem1 = new ToolStripMenuItem();
            lToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(383, 163);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 229);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Ongoing:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 229);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Next:";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(295, 289);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 23);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next Queue";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // lblOngoing
            // 
            lblOngoing.AutoSize = true;
            lblOngoing.Location = new Point(79, 229);
            lblOngoing.Name = "lblOngoing";
            lblOngoing.Size = new Size(37, 15);
            lblOngoing.TabIndex = 4;
            lblOngoing.Text = "00000";
            // 
            // lblNext
            // 
            lblNext.AutoSize = true;
            lblNext.Location = new Point(359, 229);
            lblNext.Name = "lblNext";
            lblNext.Size = new Size(37, 15);
            lblNext.TabIndex = 5;
            lblNext.Text = "00001";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 45);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Priorities";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { takeABreakToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(408, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // takeABreakToolStripMenuItem
            // 
            takeABreakToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { takeABreakToolStripMenuItem1, lToolStripMenuItem });
            takeABreakToolStripMenuItem.Name = "takeABreakToolStripMenuItem";
            takeABreakToolStripMenuItem.Size = new Size(54, 20);
            takeABreakToolStripMenuItem.Text = "Action";
            // 
            // takeABreakToolStripMenuItem1
            // 
            takeABreakToolStripMenuItem1.Name = "takeABreakToolStripMenuItem1";
            takeABreakToolStripMenuItem1.Size = new Size(180, 22);
            takeABreakToolStripMenuItem1.Text = "Take a break";
            // 
            // lToolStripMenuItem
            // 
            lToolStripMenuItem.Name = "lToolStripMenuItem";
            lToolStripMenuItem.Size = new Size(180, 22);
            lToolStripMenuItem.Text = "Logout";
            // 
            // Counter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 329);
            Controls.Add(label3);
            Controls.Add(lblNext);
            Controls.Add(lblOngoing);
            Controls.Add(btnNext);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Counter";
            Text = "Counter";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button btnNext;
        private Label lblOngoing;
        private Label lblNext;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem takeABreakToolStripMenuItem;
        private ToolStripMenuItem takeABreakToolStripMenuItem1;
        private ToolStripMenuItem lToolStripMenuItem;
    }
}