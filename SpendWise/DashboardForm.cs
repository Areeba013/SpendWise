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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void pnlHealth_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Today: " + DateTime.Now.ToString("dd MMMM yyyy");
            lblWelcome.Text = "Welcome, " + Session.FullName + "!";
            LoadDashboardData();
            LoadGoalProgress();

        }
        private void DashboardForm_Activated(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadGoalProgress();
        }
        private void LoadDashboardData()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmdIncome = new SqlCommand(
                    "SELECT ISNULL(SUM(Amount), 0) FROM FinancialRecords WHERE Type = 'Income' AND UserId = @UserId", conn);
                cmdIncome.Parameters.AddWithValue("@UserId", Session.UserId);
                double totalIncome = Convert.ToDouble(cmdIncome.ExecuteScalar());
                lblIncome.Text = "Rs. " + totalIncome.ToString("0.00");
                SqlCommand cmdExpense = new SqlCommand(
                    "SELECT ISNULL(SUM(Amount), 0) FROM FinancialRecords WHERE Type = 'Expense' AND UserId = @UserId", conn);
                cmdExpense.Parameters.AddWithValue("@UserId", Session.UserId);
                double totalExpense = Convert.ToDouble(cmdExpense.ExecuteScalar());
                lblExpense.Text = "Rs. " + totalExpense.ToString("0.00");
                double balance = totalIncome - totalExpense;
                lblBalance.Text = "Rs. " + balance.ToString("0.00");
                SqlCommand cmdRecords = new SqlCommand(
                    "SELECT TOP 10 Date, Type, Amount, Note FROM FinancialRecords WHERE UserId = @UserId ORDER BY Date DESC", conn);
                cmdRecords.Parameters.AddWithValue("@UserId", Session.UserId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdRecords);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvRecords.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            HealthScoreCalculator hsc = new HealthScoreCalculator();
            if (!hsc.HasData())
            {
                lblHealthScore.Text = "N/A";
                lblHealthStatus.Text = "No Data Yet";
            }
            else
            {
                int score = hsc.CalculateHealthScore();
                lblHealthScore.Text = score + "/100";
                lblHealthStatus.Text = hsc.GetFinancialStatus(score);
                hsc.SaveHealthScore(score, hsc.GetFinancialStatus(score));
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.UserId = 0;
            Session.FullName = "";
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            AddExpenseForm addExpense = new AddExpenseForm();
            addExpense.Show();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            SpendWise_AddIncome addIncome = new SpendWise_AddIncome();
            addIncome.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewRecordsForm viewRecords = new ViewRecordsForm();
            viewRecords.Show();
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            BudgetForm budget = new BudgetForm();
            budget.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            GoalsForm goals = new GoalsForm();
            goals.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NotificationForm notification = new NotificationForm();
            notification.Show();
        }

        private void pbGoal_Click(object sender, EventArgs e)
        {

        }
        private void LoadGoalProgress()
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;");

            string balanceQuery = "SELECT SUM(CASE WHEN Type = 'Income' THEN Amount ELSE -Amount END) FROM FinancialRecords WHERE UserId = @UserId";
            string goalQuery = "SELECT TOP 1 TargetAmount FROM SavingsGoals WHERE UserId = @UserId ORDER BY GoalId DESC";

            double currentBalance = 0;
            double targetAmount = 0;

            try
            {
                conn.Open();
                SqlCommand cmdBalance = new SqlCommand(balanceQuery, conn);
                cmdBalance.Parameters.AddWithValue("@UserId", Session.UserId);
                object balanceResult = cmdBalance.ExecuteScalar();
                if (balanceResult != DBNull.Value && balanceResult != null)
                {
                    currentBalance = Convert.ToDouble(balanceResult);
                }
                SqlCommand cmdGoal = new SqlCommand(goalQuery, conn);
                cmdGoal.Parameters.AddWithValue("@UserId", Session.UserId);
                object goalResult = cmdGoal.ExecuteScalar();
                if (goalResult != DBNull.Value && goalResult != null)
                {
                    targetAmount = Convert.ToDouble(goalResult);
                }
                conn.Close();
                if (targetAmount > 0)
                {
                    double percentage = (currentBalance / targetAmount) * 100;
                    if (percentage < 0) percentage = 0;
                    if (percentage > 100) percentage = 100;
                    int finalPercentage = Convert.ToInt32(percentage);
                    pbGoal.Value = finalPercentage;
                    lblGoalPercent.Text = finalPercentage + "% Completed";
                }
                else
                {
                    pbGoal.Value = 0;
                    lblGoalPercent.Text = "No active goal set";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating progress bar: " + ex.Message);
            }
        }

        private void lblHealthStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnInsights_Click(object sender, EventArgs e)
        {
            InsightEngine insight = new InsightEngine();
            MessageBox.Show(insight.GenerateInsight(), "Smart Insights", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            PredictionEngine prediction = new PredictionEngine();
            MessageBox.Show(prediction.GeneratePrediction(), "Spending Prediction",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
