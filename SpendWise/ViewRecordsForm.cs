using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SpendWise
{
    public partial class ViewRecordsForm : Form
    {
        public ViewRecordsForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewRecordsForm_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void LoadRecords()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT f.RecordId, f.Date, f.Type, f.Amount, c.CategoryName, f.Source, f.PaymentMethod, f.Note 
                     FROM FinancialRecords f
                     LEFT JOIN Categories c ON f.CategoryId = c.CategoryId 
                     WHERE f.UserId = @UserId
                     ORDER BY f.Date DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("UserId", Session.UserId);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvRecords.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string filter = cmbFilter.Text;
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "";
            bool hasKeyword = !string.IsNullOrEmpty(keyword);
            bool hasFilter = (filter != "All" && !string.IsNullOrEmpty(filter));
            string baseSelect = @"SELECT f.RecordId, f.Date, f.Type, f.Amount, c.CategoryName, f.Source, f.PaymentMethod, f.Note 
                          FROM FinancialRecords f
                          LEFT JOIN Categories c ON f.CategoryId = c.CategoryId ";
            string searchCondition = @"(ISNULL(c.CategoryName, '') LIKE @Keyword 
                                OR ISNULL(f.Note, '') LIKE @Keyword 
                                OR ISNULL(f.Source, '') LIKE @Keyword 
                                OR ISNULL(f.PaymentMethod, '') LIKE @Keyword)";

            if (hasKeyword && hasFilter)
            {
                query = baseSelect + " WHERE f.UserId = @UserId AND f.Type = @Filter AND " + searchCondition + " ORDER BY f.Date DESC";
            }
            else if (hasKeyword)
            {
                query = baseSelect + " WHERE f.UserId = @UserId AND " + searchCondition + " ORDER BY f.Date DESC";
            }
            else if (hasFilter)
            {
                query = baseSelect + " WHERE f.UserId = @UserId AND f.Type = @Filter ORDER BY f.Date DESC";
            }
            else
            {
                query = baseSelect + " WHERE f.UserId = @UserId ORDER BY f.Date DESC";
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            if (hasKeyword)
            {
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
            }
            if (hasFilter)
            {
                cmd.Parameters.AddWithValue("@Filter", filter);
            }

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvRecords.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching records: " + ex.Message);
            }
        }
            

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete!");
                return;
            }

            int recordId = Convert.ToInt32(dgvRecords.SelectedRows[0].Cells["RecordId"].Value);
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                string query = "DELETE FROM FinancialRecords WHERE RecordId = @RecordId AND UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecordId", recordId);
                cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record deleted successfully!");
                    LoadRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
