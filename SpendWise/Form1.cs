using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendWise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();
            string passwordInput = txtPassword.Text;
            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter both your email and password!");
                return;
            }
            SpendWise.Services.AuthService authService = new SpendWise.Services.AuthService();
            bool isUserValid = authService.ValidateLogin(emailInput, passwordInput);
            if (isUserValid)
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
                MessageBox.Show("Login successful! Welcome back!");
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}