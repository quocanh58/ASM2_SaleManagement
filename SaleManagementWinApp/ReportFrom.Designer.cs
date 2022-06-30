namespace SaleManagementWinApp
{
    partial class ReportFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndStart = new System.Windows.Forms.DateTimePicker();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgDataReport = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(302, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(113, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(278, 89);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(321, 30);
            this.dtpStartDate.TabIndex = 3;
            // 
            // dtpEndStart
            // 
            this.dtpEndStart.Location = new System.Drawing.Point(278, 140);
            this.dtpEndStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndStart.Name = "dtpEndStart";
            this.dtpEndStart.Size = new System.Drawing.Size(321, 30);
            this.dtpEndStart.TabIndex = 3;
            // 
            // btnGetReport
            // 
            this.btnGetReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGetReport.Location = new System.Drawing.Point(330, 198);
            this.btnGetReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(139, 39);
            this.btnGetReport.TabIndex = 4;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = false;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgDataReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 343);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report List:";
            // 
            // dvgDataReport
            // 
            this.dvgDataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDataReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDataReport.Location = new System.Drawing.Point(3, 26);
            this.dvgDataReport.Name = "dvgDataReport";
            this.dvgDataReport.RowHeadersWidth = 51;
            this.dvgDataReport.RowTemplate.Height = 29;
            this.dvgDataReport.Size = new System.Drawing.Size(776, 314);
            this.dvgDataReport.TabIndex = 0;
            // 
            // ReportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.dtpEndStart);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportFrom";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndStart;
        private Button btnGetReport;
        private GroupBox groupBox1;
        private DataGridView dvgDataReport;
    }
}