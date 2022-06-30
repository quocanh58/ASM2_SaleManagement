namespace SaleManagementWinApp
{
    partial class UserForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgdataOrder = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgDataOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrderDetails = new System.Windows.Forms.Button();
            this.btnNewOrderDetail = new System.Windows.Forms.Button();
            this.btnLoadOrderDetail = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtOrderIdDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdataOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(552, 291);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 37);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(321, 295);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 33);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.Location = new System.Drawing.Point(185, 295);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 33);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoad.Location = new System.Drawing.Point(46, 295);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 33);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Load Order";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(159, 149);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(4);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(281, 27);
            this.txtFreight.TabIndex = 25;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Location = new System.Drawing.Point(159, 219);
            this.dtpShippedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(281, 27);
            this.dtpShippedDate.TabIndex = 24;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(159, 184);
            this.dtpRequiredDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(281, 27);
            this.dtpRequiredDate.TabIndex = 23;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(159, 254);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(281, 27);
            this.dtpOrderDate.TabIndex = 22;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(158, 114);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(281, 27);
            this.txtMemberID.TabIndex = 21;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(158, 79);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(281, 27);
            this.txtOrderID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Freight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Order Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Shipped Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Required Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "MemberID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "OrderID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(401, 495);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(188, 125);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 30;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(0, 374);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1224, 261);
            this.splitContainer2.SplitterDistance = 602;
            this.splitContainer2.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgdataOrder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order List";
            // 
            // dvgdataOrder
            // 
            this.dvgdataOrder.BackgroundColor = System.Drawing.Color.Silver;
            this.dvgdataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdataOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgdataOrder.Location = new System.Drawing.Point(3, 23);
            this.dvgdataOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dvgdataOrder.Name = "dvgdataOrder";
            this.dvgdataOrder.ReadOnly = true;
            this.dvgdataOrder.RowHeadersWidth = 51;
            this.dvgdataOrder.RowTemplate.Height = 29;
            this.dvgdataOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgdataOrder.Size = new System.Drawing.Size(596, 235);
            this.dvgdataOrder.TabIndex = 10;
            this.dvgdataOrder.DoubleClick += new System.EventHandler(this.dvgdataOrder_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvgDataOrderDetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 261);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order detail:";
            // 
            // dvgDataOrderDetails
            // 
            this.dvgDataOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDataOrderDetails.BackgroundColor = System.Drawing.Color.Silver;
            this.dvgDataOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDataOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDataOrderDetails.Location = new System.Drawing.Point(3, 23);
            this.dvgDataOrderDetails.Name = "dvgDataOrderDetails";
            this.dvgDataOrderDetails.RowHeadersWidth = 51;
            this.dvgDataOrderDetails.RowTemplate.Height = 29;
            this.dvgDataOrderDetails.Size = new System.Drawing.Size(612, 235);
            this.dvgDataOrderDetails.TabIndex = 1;
            // 
            // btnDeleteOrderDetails
            // 
            this.btnDeleteOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteOrderDetails.Location = new System.Drawing.Point(1017, 293);
            this.btnDeleteOrderDetails.Name = "btnDeleteOrderDetails";
            this.btnDeleteOrderDetails.Size = new System.Drawing.Size(117, 33);
            this.btnDeleteOrderDetails.TabIndex = 43;
            this.btnDeleteOrderDetails.Text = "Delete";
            this.btnDeleteOrderDetails.UseVisualStyleBackColor = false;
            // 
            // btnNewOrderDetail
            // 
            this.btnNewOrderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewOrderDetail.Location = new System.Drawing.Point(894, 293);
            this.btnNewOrderDetail.Name = "btnNewOrderDetail";
            this.btnNewOrderDetail.Size = new System.Drawing.Size(117, 33);
            this.btnNewOrderDetail.TabIndex = 44;
            this.btnNewOrderDetail.Text = "New";
            this.btnNewOrderDetail.UseVisualStyleBackColor = false;
            this.btnNewOrderDetail.Click += new System.EventHandler(this.btnNewOrderDetail_Click);
            // 
            // btnLoadOrderDetail
            // 
            this.btnLoadOrderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadOrderDetail.Location = new System.Drawing.Point(750, 293);
            this.btnLoadOrderDetail.Name = "btnLoadOrderDetail";
            this.btnLoadOrderDetail.Size = new System.Drawing.Size(138, 33);
            this.btnLoadOrderDetail.TabIndex = 45;
            this.btnLoadOrderDetail.Text = "Load OrderDetail";
            this.btnLoadOrderDetail.UseVisualStyleBackColor = false;
            this.btnLoadOrderDetail.Click += new System.EventHandler(this.btnLoadOrderDetail_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(848, 150);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(286, 27);
            this.txtUnitPrice.TabIndex = 37;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(848, 224);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(286, 27);
            this.txtDiscount.TabIndex = 38;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(848, 114);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(286, 27);
            this.txtProductId.TabIndex = 39;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(848, 189);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(286, 27);
            this.txtQuantity.TabIndex = 40;
            // 
            // txtOrderIdDetail
            // 
            this.txtOrderIdDetail.Location = new System.Drawing.Point(848, 79);
            this.txtOrderIdDetail.Name = "txtOrderIdDetail";
            this.txtOrderIdDetail.Size = new System.Drawing.Size(286, 27);
            this.txtOrderIdDetail.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(742, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "UnitPrice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(742, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "ProductID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(742, 83);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "OrderID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(80, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 40);
            this.label12.TabIndex = 46;
            this.label12.Text = "Order Management";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(828, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 40);
            this.label13.TabIndex = 46;
            this.label13.Text = "Order Detail ";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 635);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDeleteOrderDetails);
            this.Controls.Add(this.btnNewOrderDetail);
            this.Controls.Add(this.btnLoadOrderDetail);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOrderIdDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdataOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txtFreight;
        private DateTimePicker dtpShippedDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpOrderDate;
        private TextBox txtMemberID;
        private TextBox txtOrderID;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button btnDeleteOrderDetails;
        private Button btnNewOrderDetail;
        private Button btnLoadOrderDetail;
        private TextBox txtUnitPrice;
        private TextBox txtDiscount;
        private TextBox txtProductId;
        private TextBox txtQuantity;
        private TextBox txtOrderIdDetail;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox1;
        private DataGridView dvgdataOrder;
        private GroupBox groupBox2;
        private DataGridView dvgDataOrderDetails;
        private Label label12;
        private Label label13;
    }
}