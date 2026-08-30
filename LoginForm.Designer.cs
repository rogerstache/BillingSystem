namespace BillingSystem
{
    partial class LoginForm_Conflictnabapls
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
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(76, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BILLING SYSTEM";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 9F);
            lblUsername.Location = new Point(49, 91);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 18);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9F);
            lblPassword.Location = new Point(54, 139);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 18);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Location = new Point(76, 185);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 9F);
            btnCancel.Location = new Point(205, 185);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 9F);
            txtUsername.Location = new Point(159, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(161, 24);
            txtUsername.TabIndex = 6;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F);
            txtPassword.Location = new Point(159, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(161, 24);
            txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(171, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += lblTitle_Click;
            // 
            // LoginForm_Conflictnabapls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(382, 253);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm_Conflictnabapls";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox txtPassword;
        private Label label1;
    }
}