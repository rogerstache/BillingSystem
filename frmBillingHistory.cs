using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        private readonly int customerId;
        public frmBillingHistory(int id)
        {
            InitializeComponent();
            customerId = id;
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();
            LoadBillingRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomerInfo()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Requirement 3.4: Verify Customer Name directly from the database
                    string query = "SELECT FullName FROM Customers WHERE CustomerID = @CustomerID;";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string fullName = result.ToString();
                            lblTitle.Text = $"Billing History - {fullName}";
                            this.Text = $"Billing History - {fullName}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer info:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBillingRecords()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Requirement 3.3 & 3.6: Query Billing table using a parameterized query
                    string query = @"SELECT 
                                        BillingMonth AS 'Billing Month',
                                        PreviousReading AS 'Previous Reading',
                                        PresentReading AS 'Present Reading',
                                        Consumption AS 'Consumption',
                                        RatePerCubic AS 'Rate Per Cubic',
                                        TotalAmount AS 'Total Amount',
                                        Status AS 'Status'
                                     FROM Billing 
                                     WHERE CustomerID = @CustomerID 
                                     ORDER BY BillingID ASC;";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvBillingHistory.DataSource = table;

                            // Requirement 3.5 (Popup 2): Zero Billing Records Found
                            if (table.Rows.Count == 0)
                            {
                                MessageBox.Show("No billing records found for this customer.",
                                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading billing records:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
