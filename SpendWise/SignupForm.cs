using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpendWise.Services;
using System.Data.SqlClient;
namespace SpendWise
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)){
                MessageBox.Show("Please fill in all field!");
                return;
            }
            if (!email.Contains("@gmail") || !email.Contains(".com"))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }
            AuthService authService = new AuthService();
            bool isRegistered = authService.Register(fullName, email, password, "PKR");
            if (isRegistered)
            {
                MessageBox.Show("Account created successfully! Please login");
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email Already exists. Please try another.");
            }
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
