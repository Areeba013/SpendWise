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
    public partial class GoalsForm : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
        public GoalsForm()
        {
            InitializeComponent();
        }
        private void LoadGoals()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT GoalId, GoalName, TargetAmount, Deadline, DATEDIFF(day, GETDATE(), Deadline) AS DaysRemaining FROM SavingsGoals WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvGoals.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading goals: " + ex.Message);
            }
        }
        private void GoalsForm_Load(object sender, EventArgs e)
        {
            this.savingsGoalsTableAdapter.Fill(this.spendWiseDBDataSet.SavingsGoals);
            LoadGoals();
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGoalName.Text.Trim()) || string.IsNullOrEmpty(txtTargetAmount.Text.Trim()))
            {
                MessageBox.Show("Please fill in both the Goal Name and Target Amount!");
                return;
            }
            if (dtpTargetDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("The Target Date cannot be in the past!");
                return;
            }
            string goalName = txtGoalName.Text.Trim();
            double targetAmount = Convert.ToDouble(txtTargetAmount.Text.Trim());
            DateTime deadline = dtpTargetDate.Value;
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO SavingsGoals (UserId, GoalName, TargetAmount, Deadline, CreatedAt) VALUES (@UserId, @GoalName, @TargetAmount, @Deadline, GETDATE())";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId); 
            cmd.Parameters.AddWithValue("@GoalName", goalName);
            cmd.Parameters.AddWithValue("@TargetAmount", targetAmount);
            cmd.Parameters.AddWithValue("@Deadline", deadline);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Savings Goal added successfully!");
                txtGoalName.Clear();
                txtTargetAmount.Clear();
                dtpTargetDate.Value = DateTime.Today;
                LoadGoals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding goal: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressGoal_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteGoal_Click(object sender, EventArgs e)
        {
            if (dgvGoals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a goal to delete!");
                return;
            }

            int goalId = Convert.ToInt32(dgvGoals.SelectedRows[0].Cells["GoalId"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this goal?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                string query = "DELETE FROM SavingsGoals WHERE GoalId = @GoalId AND UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GoalId", goalId);
                cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Goal deleted successfully!");
                    LoadGoals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
