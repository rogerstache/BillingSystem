namespace BillingSystem
{
    partial class frmChangePassword
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
            lblChangePassword = new Label();
            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            lblRetypePassword = new Label();
            btnCancel = new Button();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtRetypePassword = new TextBox();
            btnSavePassword = new Button();
            SuspendLayout();
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.Location = new Point(131, 43);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(177, 28);
            lblChangePassword.TabIndex = 0;
            lblChangePassword.Text = "Change Password";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(36, 119);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(125, 20);
            lblCurrentPassword.TabIndex = 1;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(54, 172);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(107, 20);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password:";
            lblNewPassword.Click += lblNewPassword_Click;
            // 
            // lblRetypePassword
            // 
            lblRetypePassword.AutoSize = true;
            lblRetypePassword.Location = new Point(38, 223);
            lblRetypePassword.Name = "lblRetypePassword";
            lblRetypePassword.Size = new Size(123, 20);
            lblRetypePassword.TabIndex = 3;
            lblRetypePassword.Text = "Retype Password:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(268, 272);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 32);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(183, 112);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(236, 27);
            txtCurrentPassword.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(183, 165);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(236, 27);
            txtNewPassword.TabIndex = 7;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Location = new Point(183, 220);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.Size = new Size(236, 27);
            txtRetypePassword.TabIndex = 8;
            // 
            // btnSavePassword
            // 
            btnSavePassword.Location = new Point(54, 272);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(172, 32);
            btnSavePassword.TabIndex = 9;
            btnSavePassword.Text = "Save Password";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 341);
            Controls.Add(btnSavePassword);
            Controls.Add(txtRetypePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(btnCancel);
            Controls.Add(lblRetypePassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Controls.Add(lblChangePassword);
            Name = "frmChangePassword";
            Text = "Change Password";
            Load += frmChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChangePassword;
        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private Label lblRetypePassword;
        private Button btnCancel;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtRetypePassword;
        private Button btnSavePassword;
    }
}