namespace SpendWise
{
    partial class ReportsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.lblIncome = new System.Windows.Forms.Label();
            this.pnlExpense = new System.Windows.Forms.Panel();
            this.lblExpense = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.dgvMonthly = new System.Windows.Forms.DataGridView();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.chartSpending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlIncome.SuspendLayout();
            this.pnlExpense.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).BeginInit();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpending)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // pnlIncome
            // 
            this.pnlIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.pnlIncome.Controls.Add(this.lblIncome);
            this.pnlIncome.Location = new System.Drawing.Point(40, 105);
            this.pnlIncome.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(269, 112);
            this.pnlIncome.TabIndex = 1;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.White;
            this.lblIncome.Location = new System.Drawing.Point(28, 40);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(201, 30);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "Total Income: Rs.0";
            // 
            // pnlExpense
            // 
            this.pnlExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlExpense.Controls.Add(this.lblExpense);
            this.pnlExpense.Location = new System.Drawing.Point(390, 105);
            this.pnlExpense.Margin = new System.Windows.Forms.Padding(4);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(269, 112);
            this.pnlExpense.TabIndex = 2;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.White;
            this.lblExpense.Location = new System.Drawing.Point(31, 40);
            this.lblExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(210, 30);
            this.lblExpense.TabIndex = 1;
            this.lblExpense.Text = "Total Expense: Rs.0";
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Location = new System.Drawing.Point(749, 105);
            this.pnlBalance.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(269, 112);
            this.pnlBalance.TabIndex = 3;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.MediumBlue;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(70, 40);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(142, 30);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance:Rs.0";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // dgvMonthly
            // 
            this.dgvMonthly.AllowUserToAddRows = false;
            this.dgvMonthly.AllowUserToDeleteRows = false;
            this.dgvMonthly.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthly.Location = new System.Drawing.Point(28, 248);
            this.dgvMonthly.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMonthly.Name = "dgvMonthly";
            this.dgvMonthly.ReadOnly = true;
            this.dgvMonthly.RowHeadersWidth = 100;
            this.dgvMonthly.RowTemplate.Height = 28;
            this.dgvMonthly.Size = new System.Drawing.Size(489, 308);
            this.dgvMonthly.TabIndex = 5;
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChart.Controls.Add(this.chartSpending);
            this.pnlChart.Location = new System.Drawing.Point(554, 248);
            this.pnlChart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(464, 391);
            this.pnlChart.TabIndex = 6;
            // 
            // chartSpending
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSpending.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSpending.Legends.Add(legend2);
            this.chartSpending.Location = new System.Drawing.Point(13, 18);
            this.chartSpending.Margin = new System.Windows.Forms.Padding(4);
            this.chartSpending.Name = "chartSpending";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSpending.Series.Add(series2);
            this.chartSpending.Size = new System.Drawing.Size(436, 349);
            this.chartSpending.TabIndex = 0;
            this.chartSpending.Text = "chart1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(28, 583);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 56);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 660);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.dgvMonthly);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlExpense);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpendWise-ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.pnlExpense.ResumeLayout(false);
            this.pnlExpense.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).EndInit();
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Panel pnlExpense;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView dgvMonthly;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpending;
        private System.Windows.Forms.Button btnClose;
    }
}