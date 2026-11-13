using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {
        private readonly int loggedInUserId;
        public frmChangePassword(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string retypePassword = txtRetypePassword.Text;

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(retypePassword))
            {
                MessageBox.Show("All password fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Verify Current Password Check
            if (!VerifyCurrentPassword(currentPassword))
            {
                MessageBox.Show("Current password is incorrect.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Password Match Check
            if (newPassword != retypePassword)
            {
                MessageBox.Show("New Password and Retype Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Password Complexity Check
            string complexityError = ValidatePasswordComplexity(newPassword);
            if (!string.IsNullOrEmpty(complexityError))
            {
                MessageBox.Show(complexityError, "Password Complexity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Final Save Condition
            if (UpdatePasswordInDatabase(newPassword))
            {
                AuditLogger.Log("CHANGE_PASSWORD", $"Password changed for user ID {loggedInUserId}.");
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

            private bool VerifyCurrentPassword(string inputPassword)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password;";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
                        cmd.Parameters.AddWithValue("@Password", inputPassword);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying current password:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string ValidatePasswordComplexity(string password)
        {
            if (password.Length < 8)
                return "New password must be at least 8 characters long.";

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return "New password must contain at least one uppercase letter (A-Z).";

            if (!Regex.IsMatch(password, @"[a-z]"))
                return "New password must contain at least one lowercase letter (a-z).";

            if (!Regex.IsMatch(password, @"[0-9]"))
                return "New password must contain at least one numeric digit (0-9).";

            if (!Regex.IsMatch(password, @"[!@#$%^&*(),.? ""{}|<>]"))
                return "New password must contain at least one special character (e.g. !@#$%^&*).";

            return string.Empty;
        }

        private bool UpdatePasswordInDatabase(string newPassword)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID;";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
