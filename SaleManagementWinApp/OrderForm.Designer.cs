namespace SaleManagementWinApp
{
    partial class OrderForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.dvgdataOrder = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdataOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(307, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Required Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Shipped Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Freight";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(140, 90);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(281, 30);
            this.txtOrderID.TabIndex = 3;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(140, 139);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(281, 30);
            this.txtMemberID.TabIndex = 4;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(599, 183);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(281, 30);
            this.dtpOrderDate.TabIndex = 5;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(599, 89);
            this.dtpRequiredDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(281, 30);
            this.dtpRequiredDate.TabIndex = 6;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(599, 136);
            this.dtpShippedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(281, 30);
            this.dtpShippedDate.TabIndex = 7;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(141, 187);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(4);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(281, 30);
            this.txtFreight.TabIndex = 8;
            // 
            // dvgdataOrder
            // 
            this.dvgdataOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgdataOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dvgdataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdataOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgdataOrder.Location = new System.Drawing.Point(3, 26);
            this.dvgdataOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dvgdataOrder.Name = "dvgdataOrder";
            this.dvgdataOrder.ReadOnly = true;
            this.dvgdataOrder.RowHeadersWidth = 51;
            this.dvgdataOrder.RowTemplate.Height = 29;
            this.dvgdataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgdataOrder.Size = new System.Drawing.Size(910, 258);
            this.dvgdataOrder.TabIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoad.Location = new System.Drawing.Point(160, 268);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 33);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.Location = new System.Drawing.Point(316, 268);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 33);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(483, 268);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(649, 268);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "MemberID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgdataOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 287);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Box:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(916, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdataOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtOrderID;
        private TextBox txtMemberID;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private TextBox txtFreight;
        private DataGridView dvgdataOrder;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private Label label7;
        private GroupBox groupBox1;
    }
}