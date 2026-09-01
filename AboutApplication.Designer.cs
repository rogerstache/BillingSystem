namespace BillingSystem
{
    partial class AboutApplication_Lupo
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
            lblAbout = new Label();
            lblAboutInfo = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblAbout.Location = new Point(151, 57);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(80, 29);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "About";
            lblAbout.Click += label1_Click;
            // 
            // lblAboutInfo
            // 
            lblAboutInfo.AutoSize = true;
            lblAboutInfo.Location = new Point(60, 101);
            lblAboutInfo.Name = "lblAboutInfo";
            lblAboutInfo.RightToLeft = RightToLeft.No;
            lblAboutInfo.Size = new Size(262, 40);
            lblAboutInfo.TabIndex = 1;
            lblAboutInfo.Text = "This Billing System is a project for\r\nour Application Development Subject.\r\n";
            lblAboutInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(144, 180);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AboutApplication_Lupo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(btnBack);
            Controls.Add(lblAboutInfo);
            Controls.Add(lblAbout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutApplication_Lupo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About - Billing System";
            Load += AboutApplication_Lupo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAbout;
        private Label lblAboutInfo;
        private Button btnBack;
    }
}