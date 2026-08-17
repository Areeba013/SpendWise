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
    public partial class SpendWise_AddIncome : Form
    {
        public SpendWise_AddIncome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string amount = txtAmount.Text.Trim();
            string source = txtSource.Text.Trim();
            string paymentMethod = cmbPayment.Text;
            string note = txtNote.Text.Trim();
            DateTime date = dtpDate.Value;
            int isRecurring = chkRecurring.Checked ? 1 : 0;

            if (string.IsNullOrEmpty(amount) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please fill in Amount and Category!");
                return;
            }
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO FinancialRecords (UserId, CategoryId, Type, Amount, Date, Note, PaymentMethod, Source, IsRecurring) VALUES (@UserId, @CategoryId, @Type, @Amount, @Date, @Note, @PaymentMethod, @Source, @IsRecurring)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd.Parameters.AddWithValue("@Type", "Income");
            cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(amount));
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Note", note);
            cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("@Source", source);
            cmd.Parameters.AddWithValue("@IsRecurring", isRecurring);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Income saved successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpendWise_AddIncome_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT CategoryId, CategoryName FROM Categories WHERE Type = 'Income'";
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
    }
}
