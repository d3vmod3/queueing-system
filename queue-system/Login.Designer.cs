namespace queue_system
{
    partial class Login
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Cambria", 18F);
            txtUsername.Location = new Point(12, 65);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 36);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Cambria", 18F);
            txtPassword.Location = new Point(12, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(201, 36);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textBox2_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Cambria", 18F);
            btnLogin.Location = new Point(12, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(201, 38);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F);
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 256);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
    }
}