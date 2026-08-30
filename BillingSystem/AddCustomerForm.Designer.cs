namespace BillingSystem
{
    partial class AddCustomerForm
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
            lblFullName = new Label();
            lblAddress = new Label();
            lblContact = new Label();
            lblBalance = new Label();
            lblEmail = new Label();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(106, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Customer";
            lblTitle.Click += label1_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Microsoft Sans Serif", 9F);
            lblFullName.Location = new Point(41, 97);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 18);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            lblFullName.Click += lblFullName_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Microsoft Sans Serif", 9F);
            lblAddress.Location = new Point(41, 137);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 18);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Microsoft Sans Serif", 9F);
            lblContact.Location = new Point(41, 177);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(121, 18);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact Number:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Microsoft Sans Serif", 9F);
            lblBalance.Location = new Point(41, 257);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(101, 18);
            lblBalance.TabIndex = 4;
            lblBalance.Text = "Initial Balance:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9F);
            lblEmail.Location = new Point(41, 217);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 18);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFullName.Location = new Point(191, 94);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(205, 24);
            txtFullName.TabIndex = 6;
            txtFullName.Text = "Jian Paolo F. Navea";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 9F);
            txtAddress.Location = new Point(191, 134);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(205, 24);
            txtAddress.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Microsoft Sans Serif", 9F);
            txtContact.Location = new Point(191, 177);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(205, 24);
            txtContact.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.Location = new Point(191, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 24);
            txtEmail.TabIndex = 9;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Microsoft Sans Serif", 9F);
            txtBalance.Location = new Point(191, 254);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(205, 24);
            txtBalance.TabIndex = 10;
            txtBalance.Text = "0.00";
            txtBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 9F);
            btnSave.Location = new Point(57, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 9F);
            btnClear.Location = new Point(169, 308);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 9F);
            btnBack.Location = new Point(281, 308);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 373);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBalance);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblEmail);
            Controls.Add(lblBalance);
            Controls.Add(lblContact);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblContact;
        private Label lblBalance;
        private Label lblEmail;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}