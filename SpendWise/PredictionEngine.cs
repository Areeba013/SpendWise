using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SpendWise
{
    class PredictionEngine
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
        private int userId;
        public PredictionEngine()
        {
            userId = Session.UserId;
        }
        public double PredictMonthlyExpense()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT ISNULL(SUM(Amount), 0) 
                            FROM FinancialRecords 
                            WHERE Type = 'Expense' 
                            AND UserId = @UserId
                            AND MONTH(Date) = MONTH(GETDATE())
                            AND YEAR(Date) = YEAR(GETDATE())";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);
            try
            {
                conn.Open();
                double spentSoFar = Convert.ToDouble(cmd.ExecuteScalar());
                conn.Close();
                int today = DateTime.Now.Day;
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                if (today == 0) return 0;
                double dailyAverage = spentSoFar / today;
                double predictedTotal = dailyAverage * daysInMonth;
                return Math.Round(predictedTotal, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prediction Error: " + ex.Message);
                return 0;
            }
        }
        public double GetDailyLimit()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            
            string incomeQuery = @"SELECT ISNULL(SUM(Amount), 0) 
                                  FROM FinancialRecords 
                                  WHERE Type = 'Income' 
                                  AND UserId = @UserId
                                  AND MONTH(Date) = MONTH(GETDATE())
                                  AND YEAR(Date) = YEAR(GETDATE())";
            
            string expenseQuery = @"SELECT ISNULL(SUM(Amount), 0) 
                                   FROM FinancialRecords 
                                   WHERE Type = 'Expense' 
                                   AND UserId = @UserId
                                   AND MONTH(Date) = MONTH(GETDATE())
                                   AND YEAR(Date) = YEAR(GETDATE())";

            SqlCommand cmdIncome = new SqlCommand(incomeQuery, conn);
            cmdIncome.Parameters.AddWithValue("@UserId", userId);

            SqlCommand cmdExpense = new SqlCommand(expenseQuery, conn);
            cmdExpense.Parameters.AddWithValue("@UserId", userId);
            try
            {
                conn.Open();
                double totalIncome = Convert.ToDouble(cmdIncome.ExecuteScalar());
                double totalExpense = Convert.ToDouble(cmdExpense.ExecuteScalar());
                conn.Close();
                double remaining = totalIncome - totalExpense;
                int daysLeft = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day;
                if (remaining <= 0) return 0;
                if (daysLeft == 0) return 0;
                return Math.Round(remaining / daysLeft, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prediction Error: " + ex.Message);
                return 0;
            }
        }
        public string GeneratePrediction()
        {
            double predicted = PredictMonthlyExpense();
            double dailyLimit = GetDailyLimit();
            string result = "Predicted total expense this month: Rs." + predicted.ToString("0.00");
            if (dailyLimit > 0)
                result += "\nYou can spend Rs." + dailyLimit.ToString("0.00") + " per day for rest of month.";
            else
                result += "\nNo remaining budget for this month!";
            return result;
        }
    }
}