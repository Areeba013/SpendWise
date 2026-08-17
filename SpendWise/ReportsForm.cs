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
using System.Windows.Forms.DataVisualization.Charting;

namespace SpendWise
{
    public partial class ReportsForm : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
        private void LoadTopSummaryCards()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT Type, SUM(Amount) AS Total FROM FinancialRecords WHERE UserId = @UserId GROUP BY Type";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            double totalIncome = 0;
            double totalExpense = 0;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string type = reader["Type"].ToString();
                    double total = Convert.ToDouble(reader["Total"]);

                    if (type == "Income") totalIncome = total;
                    else if (type == "Expense") totalExpense = total;
                }
                conn.Close();
                lblIncome.Text = "Total Income: Rs." + totalIncome.ToString("N2");
                lblExpense.Text = "Total Expense: Rs." + totalExpense.ToString("N2");
                double balance = totalIncome - totalExpense;
                lblBalance.Text = "Balance: Rs." + balance.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading summary cards: " + ex.Message);
            }
        }
        private void LoadMonthlyGrid()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT 
                        FORMAT(Date, 'MMMM yyyy') AS [Month],
                        SUM(CASE WHEN Type = 'Income' THEN Amount ELSE 0 END) AS [Total Income],
                        SUM(CASE WHEN Type = 'Expense' THEN Amount ELSE 0 END) AS [Total Expense]
                     FROM FinancialRecords
                     WHERE UserId = @UserId
                     GROUP BY FORMAT(Date, 'MMMM yyyy'), YEAR(Date), MONTH(Date)
                     ORDER BY YEAR(Date) DESC, MONTH(Date) DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMonthly.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid data: " + ex.Message);
            }
        }
        private void LoadExpensePieChart()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT c.CategoryName, SUM(f.Amount) AS TotalAmount 
                     FROM FinancialRecords f
                     INNER JOIN Categories c ON f.CategoryId = c.CategoryId
                     WHERE f.Type = 'Expense' AND f.UserId = @UserId
                     GROUP BY c.CategoryName";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                chartSpending.Series.Clear();
                chartSpending.Titles.Clear();
                chartSpending.Titles.Add("Expense Distribution By Category");

                Series series = new Series("Expenses")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true
                };
                foreach (DataRow row in dt.Rows)
                {
                    string category = row["CategoryName"].ToString();
                    double amount = Convert.ToDouble(row["TotalAmount"]);
                    series.Points.AddXY(category, amount);
                }

                chartSpending.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rendering pie chart: " + ex.Message);
            }
        }
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadTopSummaryCards();
            LoadMonthlyGrid();
            LoadExpensePieChart();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
