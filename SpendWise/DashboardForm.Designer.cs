namespace SpendWise
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.lblIncome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTotalExpense = new System.Windows.Forms.Panel();
            this.lblExpense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHealth = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHealthStatus = new System.Windows.Forms.Label();
            this.lblHealthScore = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnInsights = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pbGoal = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGoalPercent = new System.Windows.Forms.Label();
            this.btnPrediction = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBalance.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.pnlTotalExpense.SuspendLayout();
            this.pnlHealth.SuspendLayout();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.lblAppName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1078, 84);
            this.pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpendWise.Properties.Resources.BellIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(900, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(656, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(208, 30);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Today: 22 May 2026";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(959, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 46);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(408, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(110, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(12, 16);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(233, 45);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "💰 SpendWise";
            this.lblAppName.Click += new System.EventHandler(this.lblAppName_Click);
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Controls.Add(this.label1);
            this.pnlBalance.Location = new System.Drawing.Point(10, 117);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(220, 120);
            this.pnlBalance.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(21, 56);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(101, 48);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Rs. 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Balance";
            // 
            // pnlIncome
            // 
            this.pnlIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.pnlIncome.Controls.Add(this.lblIncome);
            this.pnlIncome.Controls.Add(this.label2);
            this.pnlIncome.Location = new System.Drawing.Point(298, 117);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(220, 120);
            this.pnlIncome.TabIndex = 2;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.White;
            this.lblIncome.Location = new System.Drawing.Point(22, 55);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(101, 48);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "Rs. 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Income";
            // 
            // pnlTotalExpense
            // 
            this.pnlTotalExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.pnlTotalExpense.Controls.Add(this.lblExpense);
            this.pnlTotalExpense.Controls.Add(this.label3);
            this.pnlTotalExpense.Location = new System.Drawing.Point(576, 117);
            this.pnlTotalExpense.Name = "pnlTotalExpense";
            this.pnlTotalExpense.Size = new System.Drawing.Size(220, 120);
            this.pnlTotalExpense.TabIndex = 3;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.White;
            this.lblExpense.Location = new System.Drawing.Point(20, 55);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(101, 48);
            this.lblExpense.TabIndex = 1;
            this.lblExpense.Text = "Rs. 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Expense";
            // 
            // pnlHealth
            // 
            this.pnlHealth.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlHealth.Controls.Add(this.label4);
            this.pnlHealth.Controls.Add(this.lblHealthStatus);
            this.pnlHealth.Controls.Add(this.lblHealthScore);
            this.pnlHealth.Location = new System.Drawing.Point(846, 117);
            this.pnlHealth.Name = "pnlHealth";
            this.pnlHealth.Size = new System.Drawing.Size(220, 120);
            this.pnlHealth.TabIndex = 4;
            this.pnlHealth.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHealth_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "HealthScore";
            // 
            // lblHealthStatus
            // 
            this.lblHealthStatus.AutoSize = true;
            this.lblHealthStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHealthStatus.ForeColor = System.Drawing.Color.White;
            this.lblHealthStatus.Location = new System.Drawing.Point(35, 40);
            this.lblHealthStatus.Name = "lblHealthStatus";
            this.lblHealthStatus.Size = new System.Drawing.Size(77, 30);
            this.lblHealthStatus.TabIndex = 1;
            this.lblHealthStatus.Text = "Status";
            this.lblHealthStatus.Click += new System.EventHandler(this.lblHealthStatus_Click);
            // 
            // lblHealthScore
            // 
            this.lblHealthScore.AutoSize = true;
            this.lblHealthScore.BackColor = System.Drawing.Color.DarkOrange;
            this.lblHealthScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHealthScore.ForeColor = System.Drawing.Color.White;
            this.lblHealthScore.Location = new System.Drawing.Point(32, 70);
            this.lblHealthScore.Name = "lblHealthScore";
            this.lblHealthScore.Size = new System.Drawing.Size(120, 48);
            this.lblHealthScore.TabIndex = 0;
            this.lblHealthScore.Text = "0/100";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Controls.Add(this.btnPrediction);
            this.pnlNav.Controls.Add(this.btnInsights);
            this.pnlNav.Controls.Add(this.btnViewAll);
            this.pnlNav.Controls.Add(this.btnGoals);
            this.pnlNav.Controls.Add(this.btnReports);
            this.pnlNav.Controls.Add(this.btnBudget);
            this.pnlNav.Controls.Add(this.btnAddIncome);
            this.pnlNav.Controls.Add(this.btnAddExpense);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNav.Location = new System.Drawing.Point(0, 502);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1078, 142);
            this.pnlNav.TabIndex = 6;
            // 
            // btnInsights
            // 
            this.btnInsights.BackColor = System.Drawing.Color.Teal;
            this.btnInsights.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsights.ForeColor = System.Drawing.Color.White;
            this.btnInsights.Location = new System.Drawing.Point(581, 77);
            this.btnInsights.Name = "btnInsights";
            this.btnInsights.Size = new System.Drawing.Size(235, 53);
            this.btnInsights.TabIndex = 13;
            this.btnInsights.Text = "💡 Insights";
            this.btnInsights.UseVisualStyleBackColor = false;
            this.btnInsights.Click += new System.EventHandler(this.btnInsights_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Blue;
            this.btnViewAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(860, 13);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(206, 54);
            this.btnViewAll.TabIndex = 12;
            this.btnViewAll.Text = " 🔍 View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnGoals
            // 
            this.btnGoals.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGoals.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoals.ForeColor = System.Drawing.Color.White;
            this.btnGoals.Location = new System.Drawing.Point(10, 77);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(206, 53);
            this.btnGoals.TabIndex = 4;
            this.btnGoals.Text = "🎯 Goals";
            this.btnGoals.UseVisualStyleBackColor = false;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.MediumPurple;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(279, 77);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(239, 53);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "📊 Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBudget.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudget.ForeColor = System.Drawing.Color.White;
            this.btnBudget.Location = new System.Drawing.Point(10, 12);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(206, 54);
            this.btnBudget.TabIndex = 2;
            this.btnBudget.Text = "💵 Budget";
            this.btnBudget.UseVisualStyleBackColor = false;
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.btnAddIncome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIncome.ForeColor = System.Drawing.Color.White;
            this.btnAddIncome.Location = new System.Drawing.Point(279, 12);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(239, 55);
            this.btnAddIncome.TabIndex = 1;
            this.btnAddIncome.Text = "💰 Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = false;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnAddExpense.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(576, 10);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(240, 56);
            this.btnAddExpense.TabIndex = 0;
            this.btnAddExpense.Text = "📉 Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(20, 296);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowTemplate.Height = 28;
            this.dgvRecords.Size = new System.Drawing.Size(543, 190);
            this.dgvRecords.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Recent Transactions";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pbGoal
            // 
            this.pbGoal.Location = new System.Drawing.Point(576, 335);
            this.pbGoal.Name = "pbGoal";
            this.pbGoal.Size = new System.Drawing.Size(490, 151);
            this.pbGoal.TabIndex = 10;
            this.pbGoal.Click += new System.EventHandler(this.pbGoal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Savings Goal Progress";
            // 
            // lblGoalPercent
            // 
            this.lblGoalPercent.AutoSize = true;
            this.lblGoalPercent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalPercent.Location = new System.Drawing.Point(576, 296);
            this.lblGoalPercent.Name = "lblGoalPercent";
            this.lblGoalPercent.Size = new System.Drawing.Size(165, 30);
            this.lblGoalPercent.TabIndex = 12;
            this.lblGoalPercent.Text = "0% Completed";
            // 
            // btnPrediction
            // 
            this.btnPrediction.BackColor = System.Drawing.Color.Indigo;
            this.btnPrediction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrediction.ForeColor = System.Drawing.Color.White;
            this.btnPrediction.Location = new System.Drawing.Point(860, 77);
            this.btnPrediction.Name = "btnPrediction";
            this.btnPrediction.Size = new System.Drawing.Size(206, 53);
            this.btnPrediction.TabIndex = 14;
            this.btnPrediction.Text = "🔮 Prediction";
            this.btnPrediction.UseVisualStyleBackColor = false;
            this.btnPrediction.Click += new System.EventHandler(this.btnPrediction_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.lblGoalPercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbGoal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHealth);
            this.Controls.Add(this.pnlTotalExpense);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpendWise_Dashboard";
            this.Activated += new System.EventHandler(this.DashboardForm_Activated);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.pnlTotalExpense.ResumeLayout(false);
            this.pnlTotalExpense.PerformLayout();
            this.pnlHealth.ResumeLayout(false);
            this.pnlHealth.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTotalExpense;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHealth;
        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.Label lblHealthScore;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbGoal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGoalPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsights;
        private System.Windows.Forms.Button btnPrediction;
    }
}