using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SpendWise
{
    class InsightEngine
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
        private int userId;
        public InsightEngine()
        {
            userId = Session.UserId;
        }
        public string GetHighestSpendingCategory()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT TOP 1 c.CategoryName 
                            FROM FinancialRecords f
                            INNER JOIN Categories c ON f.CategoryId = c.CategoryId
                            WHERE f.Type = 'Expense' AND f.UserId = @UserId
                            GROUP BY c.CategoryName
                            ORDER BY SUM(f.Amount) DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                if (result != null)
                    return result.ToString();
                else
                    return "No expenses yet";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insight Error: " + ex.Message);
                return "Error";
            }
        }
        public string CompareMonthlyExpenses()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT 
                ISNULL(SUM(CASE WHEN MONTH(Date) = MONTH(GETDATE()) 
                               AND YEAR(Date) = YEAR(GETDATE()) 
                               THEN Amount ELSE 0 END), 0) AS ThisMonth,
                ISNULL(SUM(CASE WHEN MONTH(Date) = MONTH(DATEADD(MONTH,-1,GETDATE())) 
                               AND YEAR(Date) = YEAR(DATEADD(MONTH,-1,GETDATE())) 
                               THEN Amount ELSE 0 END), 0) AS LastMonth
                FROM FinancialRecords 
                WHERE Type = 'Expense' AND UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    double thisMonth = Convert.ToDouble(reader["ThisMonth"]);
                    double lastMonth = Convert.ToDouble(reader["LastMonth"]);
                    conn.Close();
                    if (lastMonth == 0)
                        return "No data from last month to compare.";
                    else if (thisMonth > lastMonth)
                    {
                        double diff = thisMonth - lastMonth;
                        return "You spent Rs." + diff.ToString("0.00") + " MORE than last month!";
                    }
                    else if (thisMonth < lastMonth)
                    {
                        double diff = lastMonth - thisMonth;
                        return " You spent Rs." + diff.ToString("0.00") + " LESS than last month!";
                    }
                    else
                        return "Your spending is the same as last month.";
                }
                conn.Close();
                return "No data available.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insight Error: " + ex.Message);
                return "Error";
            }
        }
        public string GenerateInsight()
        {
            string category = GetHighestSpendingCategory();
            string comparison = CompareMonthlyExpenses();
            return "Highest spending category: " + category + "\n\n" + comparison;
        }
    }
}
