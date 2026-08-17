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
    public partial class AddExpenseForm : Form
    {
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string amount = txtAmount.Text.Trim();
            string paymentMethod = cmbPayment.Text;
            string note = txtNote.Text.Trim();
            DateTime date = dtpDate.Value;
            int isEssential = chkEssential.Checked ? 1 : 0;
            if (string.IsNullOrEmpty(amount) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please fill in Amount and Category!");
                return;
            }
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO FinancialRecords (UserId, CategoryId, Type, Amount, Date, Note, PaymentMethod, IsEssential) VALUES (@UserId, @CategoryId, @Type, @Amount, @Date, @Note, @PaymentMethod, @IsEssential)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd.Parameters.AddWithValue("@Type", "Expense");
            cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(amount));
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Note", note);
            cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("@IsEssential", isEssential);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                string budgetQuery = "SELECT TOP 1 SpendingLimit FROM Budgets WHERE CategoryId = @CategoryId AND UserId = @UserId ORDER BY BudgetId DESC";
                SqlCommand cmdBudget = new SqlCommand(budgetQuery, conn);
                cmdBudget.Parameters.AddWithValue("@CategoryId", categoryId);
                cmdBudget.Parameters.AddWithValue("@UserId", Session.UserId);
                object budgetResult = cmdBudget.ExecuteScalar();

                if (budgetResult != null && budgetResult != DBNull.Value)
                {
                    double budgetLimit = Convert.ToDouble(budgetResult);
                    string expenseSumQuery = "SELECT ISNULL(SUM(Amount), 0) FROM FinancialRecords WHERE CategoryId = @CategoryId AND Type = 'Expense' AND UserId = @UserId";
                    SqlCommand cmdSum = new SqlCommand(expenseSumQuery, conn);
                    cmdSum.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmdSum.Parameters.AddWithValue("@UserId", Session.UserId);
                    double totalSpent = Convert.ToDouble(cmdSum.ExecuteScalar());
                    if (totalSpent > budgetLimit)
                    {
                        string alertMsg = "Warning: You have exceeded your " + cmbCategory.Text + " budget!";
                        string notifyQuery = "INSERT INTO Notifications (UserId, Message, IsRead, NotificationDate, Type, SourceId, SourceType) VALUES (@UserId, @Msg, 0, GETDATE(), @Type, @SourceId, @SourceType)";

                        SqlCommand cmdNotify = new SqlCommand(notifyQuery, conn);
                        cmdNotify.Parameters.AddWithValue("@UserId", Session.UserId);
                        cmdNotify.Parameters.AddWithValue("@Msg", alertMsg);
                        cmdNotify.Parameters.AddWithValue("@Type", "Warning");
                        cmdNotify.Parameters.AddWithValue("@SourceId", categoryId);
                        cmdNotify.Parameters.AddWithValue("@SourceType", "Budget");
                        cmdNotify.ExecuteNonQuery();
                        MessageBox.Show(alertMsg, "Budget Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                MessageBox.Show("Expense saved successfully!");
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

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}