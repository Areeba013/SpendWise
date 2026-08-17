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
    public partial class NotificationForm : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SpendWiseDB;Integrated Security=True;";

        public NotificationForm()
        {
            InitializeComponent();
        }
        private void NotificationForm_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }
        private void btnMarkRead_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.CurrentRow == null)
            {
                MessageBox.Show("Please select a notification from the list first!");
                return;
            }

            try
            {
                DataRowView currentRow = dgvNotifications.CurrentRow.DataBoundItem as DataRowView;
                int notificationId = Convert.ToInt32(currentRow["NotificationId"]);

                SqlConnection conn = new SqlConnection(connectionString);
                string query = "UPDATE Notifications SET IsRead = 1 WHERE NotificationId = @NotificationId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NotificationId", notificationId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadNotifications();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating notification: " + ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadNotifications()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = @"SELECT 
                                NotificationId, 
                                Message, 
                                NotificationDate AS [Date], 
                                CASE WHEN IsRead = 1 THEN 'Read' ELSE 'Unread' END AS [Status] 
                             FROM Notifications 
                             WHERE UserId = @UserId 
                             ORDER BY NotificationDate DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNotifications.DataSource = dt;
                if (dgvNotifications.Columns.Contains("NotificationId"))
                {
                    dgvNotifications.Columns["NotificationId"].Visible = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}