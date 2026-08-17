namespace SpendWise
{
    partial class GoalsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.dtpTargetDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            this.progressGoal = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.spendWiseDBDataSet = new SpendWise.SpendWiseDBDataSet();
            this.savingsGoalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.savingsGoalsTableAdapter = new SpendWise.SpendWiseDBDataSetTableAdapters.SavingsGoalsTableAdapter();
            this.btnDeleteGoal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendWiseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingsGoalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "SavingsGoal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Goal Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target Amount(Rs.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Target Date";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(327, 79);
            this.txtGoalName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(344, 34);
            this.txtGoalName.TabIndex = 4;
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.Location = new System.Drawing.Point(327, 130);
            this.txtTargetAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(344, 34);
            this.txtTargetAmount.TabIndex = 5;
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.Location = new System.Drawing.Point(327, 181);
            this.dtpTargetDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new System.Drawing.Size(344, 34);
            this.dtpTargetDate.TabIndex = 6;
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddGoal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoal.ForeColor = System.Drawing.Color.White;
            this.btnAddGoal.Location = new System.Drawing.Point(327, 234);
            this.btnAddGoal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(220, 63);
            this.btnAddGoal.TabIndex = 7;
            this.btnAddGoal.Text = "+ Add Goal";
            this.btnAddGoal.UseVisualStyleBackColor = false;
            this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
            // 
            // dgvGoals
            // 
            this.dgvGoals.AllowUserToAddRows = false;
            this.dgvGoals.BackgroundColor = System.Drawing.Color.White;
            this.dgvGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoals.Location = new System.Drawing.Point(138, 305);
            this.dgvGoals.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGoals.Name = "dgvGoals";
            this.dgvGoals.ReadOnly = true;
            this.dgvGoals.RowTemplate.Height = 28;
            this.dgvGoals.Size = new System.Drawing.Size(596, 234);
            this.dgvGoals.TabIndex = 8;
            // 
            // progressGoal
            // 
            this.progressGoal.Location = new System.Drawing.Point(13, 564);
            this.progressGoal.Margin = new System.Windows.Forms.Padding(4);
            this.progressGoal.Name = "progressGoal";
            this.progressGoal.Size = new System.Drawing.Size(850, 77);
            this.progressGoal.TabIndex = 9;
            this.progressGoal.Click += new System.EventHandler(this.progressGoal_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(485, 574);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 56);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // spendWiseDBDataSet
            // 
            this.spendWiseDBDataSet.DataSetName = "SpendWiseDBDataSet";
            this.spendWiseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // savingsGoalsBindingSource
            // 
            this.savingsGoalsBindingSource.DataMember = "SavingsGoals";
            this.savingsGoalsBindingSource.DataSource = this.spendWiseDBDataSet;
            // 
            // savingsGoalsTableAdapter
            // 
            this.savingsGoalsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteGoal
            // 
            this.btnDeleteGoal.BackColor = System.Drawing.Color.Red;
            this.btnDeleteGoal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGoal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteGoal.Location = new System.Drawing.Point(197, 574);
            this.btnDeleteGoal.Name = "btnDeleteGoal";
            this.btnDeleteGoal.Size = new System.Drawing.Size(208, 56);
            this.btnDeleteGoal.TabIndex = 11;
            this.btnDeleteGoal.Text = "Delete Selected";
            this.btnDeleteGoal.UseVisualStyleBackColor = false;
            this.btnDeleteGoal.Click += new System.EventHandler(this.btnDeleteGoal_Click);
            // 
            // GoalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 660);
            this.Controls.Add(this.btnDeleteGoal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.progressGoal);
            this.Controls.Add(this.dgvGoals);
            this.Controls.Add(this.btnAddGoal);
            this.Controls.Add(this.dtpTargetDate);
            this.Controls.Add(this.txtTargetAmount);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpendWise-GoalsForm";
            this.Load += new System.EventHandler(this.GoalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendWiseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingsGoalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.TextBox txtTargetAmount;
        private System.Windows.Forms.DateTimePicker dtpTargetDate;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.ProgressBar progressGoal;
        private System.Windows.Forms.Button btnClose;
        private SpendWiseDBDataSet spendWiseDBDataSet;
        private System.Windows.Forms.BindingSource savingsGoalsBindingSource;
        private SpendWiseDBDataSetTableAdapters.SavingsGoalsTableAdapter savingsGoalsTableAdapter;
        private System.Windows.Forms.Button btnDeleteGoal;
    }
}