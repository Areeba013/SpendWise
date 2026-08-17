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
    public partial class BudgetForm : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
        public BudgetForm()
        {
            InitializeComponent();
        }
        private void LoadBudgets()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT b.BudgetId, c.CategoryName, b.SpendingLimit, b.StartDate, b.EndDate 
                     FROM Budgets b
                     INNER JOIN Categories c ON b.CategoryId = c.CategoryId
                     WHERE b.UserId = @UserId AND b.IsActive = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBudgets.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading budgets: " + ex.Message);
            }
        }
        private void BudgetForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadBudgets();
        }
        private void LoadCategories()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT CategoryId, CategoryName FROM Categories WHERE Type = 'Expense'";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSetBudget_Click(object sender, EventArgs e)
        {
            string limitText = txtLimit.Text.Trim();
            if (string.IsNullOrEmpty(limitText) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category and enter a spending limit!");
                return;
            }
            double spendingLimit = Convert.ToDouble(limitText);
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            if (endDate < startDate)
            {
                MessageBox.Show("End Date cannot be before the Start Date!");
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO Budgets (UserId, CategoryId, SpendingLimit, StartDate, EndDate, IsActive) VALUES (@UserId, @CategoryId, @SpendingLimit, @StartDate, @EndDate, 1)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd.Parameters.AddWithValue("@SpendingLimit", spendingLimit);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Budget limit set successfully!");
                txtLimit.Clear();
                LoadBudgets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting budget: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category to remove its budget!");
                return;
            }
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the budget limits for this category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string query = "DELETE FROM Budgets WHERE CategoryId = @CategoryId AND UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Budget limits deleted successfully!");
                        LoadBudgets();
                    }
                    else
                    {
                        MessageBox.Show("No active budget found for this category to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting budget: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}