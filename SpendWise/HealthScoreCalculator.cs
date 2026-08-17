using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SpendWise
{
    class HealthScoreCalculator
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
        private int userId;
        public HealthScoreCalculator()
        {
            userId = Session.UserId;
        }
        public int CalculateHealthScore()
        {
            double totalIncome = 0;
            double totalExpense = 0;
            int budgetsExceeded = 0;
            int totalBudgets = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmdIncome = new SqlCommand(
                    "SELECT ISNULL(SUM(Amount), 0) FROM FinancialRecords WHERE Type = 'Income' AND UserId = @UserId", conn);
                cmdIncome.Parameters.AddWithValue("@UserId", userId);
                totalIncome = Convert.ToDouble(cmdIncome.ExecuteScalar());
                
                SqlCommand cmdExpense = new SqlCommand(
                    "SELECT ISNULL(SUM(Amount), 0) FROM FinancialRecords WHERE Type = 'Expense' AND UserId = @UserId", conn);
                cmdExpense.Parameters.AddWithValue("@UserId", userId);
                totalExpense = Convert.ToDouble(cmdExpense.ExecuteScalar());

                SqlCommand cmdBudgets = new SqlCommand(
                    "SELECT COUNT(*) FROM Budgets WHERE UserId = @UserId AND IsActive = 1", conn);
                cmdBudgets.Parameters.AddWithValue("@UserId", userId);
                totalBudgets = Convert.ToInt32(cmdBudgets.ExecuteScalar());

                SqlCommand cmdExceeded = new SqlCommand(@"
                    SELECT COUNT(*) FROM Budgets b
                    WHERE b.UserId = @UserId AND b.IsActive = 1
                    AND (SELECT ISNULL(SUM(f.Amount), 0) 
                         FROM FinancialRecords f 
                         WHERE f.CategoryId = b.CategoryId 
                         AND f.Type = 'Expense' 
                         AND f.UserId = @UserId) > b.SpendingLimit", conn);
                cmdExceeded.Parameters.AddWithValue("@UserId", userId);
                budgetsExceeded = Convert.ToInt32(cmdExceeded.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Health Score Error: " + ex.Message);
                return 0;
            }
            int score = 0;
            if (totalIncome > 0)
            {
                double savingsRatio = (totalIncome - totalExpense) / totalIncome * 100;
                if (savingsRatio >= 30) score += 50;
                else if (savingsRatio >= 20) score += 40;
                else if (savingsRatio >= 10) score += 30;
                else if (savingsRatio >= 0) score += 15;
                else score += 0;
            }
            if (totalBudgets == 0)
            {
                score += 25;
            }
            else
            {
                double budgetScore = ((double)(totalBudgets - budgetsExceeded) / totalBudgets) * 50;
                score += Convert.ToInt32(budgetScore);
            }
            if (score < 0) score = 0;
            if (score > 100) score = 100;
            return score;
        }
        public string GetFinancialStatus(int score)
        {
            if (score >= 80) return "Excellent";
            else if (score >= 60) return "Good";
            else if (score >= 40) return "Average ";
            else return "Poor";
        }
        public bool HasData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM FinancialRecords WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);
            try
            {
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public void SaveHealthScore(int score, string status)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string checkQuery = @"SELECT COUNT(1) FROM HealthScores 
                          WHERE UserId = @UserId 
                          AND MONTH(ScoreMonth) = MONTH(GETDATE())
                          AND YEAR(ScoreMonth) = YEAR(GETDATE())";
            SqlCommand cmdCheck = new SqlCommand(checkQuery, conn);
            cmdCheck.Parameters.AddWithValue("@UserId", userId);
            try
            {
                conn.Open();
                int exists = Convert.ToInt32(cmdCheck.ExecuteScalar());
                if (exists == 0)
                {
                    string insertQuery = @"INSERT INTO HealthScores (UserId, HealthScore, FinancialStatus, ScoreMonth, CalculatedAt) 
                                   VALUES (@UserId, @Score, @Status, @Month, GETDATE())";
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, conn);
                    cmdInsert.Parameters.AddWithValue("@UserId", userId);
                    cmdInsert.Parameters.AddWithValue("@Score", score);
                    cmdInsert.Parameters.AddWithValue("@Status", status);
                    cmdInsert.Parameters.AddWithValue("@Month", new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
                    cmdInsert.ExecuteNonQuery();
                }
                else
                {
                    string updateQuery = @"UPDATE HealthScores 
                                   SET HealthScore = @Score, FinancialStatus = @Status, CalculatedAt = GETDATE()
                                   WHERE UserId = @UserId
                                   AND MONTH(ScoreMonth) = MONTH(GETDATE())
                                   AND YEAR(ScoreMonth) = YEAR(GETDATE())";
                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn);
                    cmdUpdate.Parameters.AddWithValue("@Score", score);
                    cmdUpdate.Parameters.AddWithValue("@Status", status);
                    cmdUpdate.Parameters.AddWithValue("@UserId", userId);
                    cmdUpdate.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving health score: " + ex.Message);
            }
        }
    }
}
