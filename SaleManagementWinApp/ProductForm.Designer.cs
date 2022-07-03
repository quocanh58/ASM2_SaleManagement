namespace SaleManagementWinApp
{
    partial class ProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.dvgDataProduct = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lebela = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterProductName = new System.Windows.Forms.TextBox();
            this.txtFilterUnitPrice = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearchUniPrice = new System.Windows.Forms.Button();
            this.btnSearchUnitInStock = new System.Windows.Forms.Button();
            this.txtFilterProductID = new System.Windows.Forms.TextBox();
            this.txtFilterUnitInStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(68, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "CategoryID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ProductID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "UnitPrice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "UnitInStock";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(161, 95);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(264, 27);
            this.txtProductID.TabIndex = 6;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Enabled = false;
            this.txtCategoryID.Location = new System.Drawing.Point(161, 128);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(264, 27);
            this.txtCategoryID.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(161, 161);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(264, 27);
            this.txtProductName.TabIndex = 8;
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(161, 194);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(264, 27);
            this.txtWeight.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(161, 227);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(264, 27);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Enabled = false;
            this.txtUnitInStock.Location = new System.Drawing.Point(161, 260);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(264, 27);
            this.txtUnitInStock.TabIndex = 11;
            // 
            // dvgDataProduct
            // 
            this.dvgDataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDataProduct.Location = new System.Drawing.Point(33, 379);
            this.dvgDataProduct.Name = "dvgDataProduct";
            this.dvgDataProduct.RowHeadersWidth = 51;
            this.dvgDataProduct.RowTemplate.Height = 29;
            this.dvgDataProduct.Size = new System.Drawing.Size(859, 218);
            this.dvgDataProduct.TabIndex = 12;
            this.dvgDataProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDataProduct_CellDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoad.Location = new System.Drawing.Point(42, 321);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.Location = new System.Drawing.Point(229, 321);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(441, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(798, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(629, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "ProductID";
            // 
            // lebela
            // 
            this.lebela.AutoSize = true;
            this.lebela.Location = new System.Drawing.Point(460, 158);
            this.lebela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lebela.Name = "lebela";
            this.lebela.Size = new System.Drawing.Size(104, 20);
            this.lebela.TabIndex = 5;
            this.lebela.Text = "Product Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(533, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 40);
            this.label12.TabIndex = 2;
            this.label12.Text = "Filter Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "UnitPrice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "UnitInStock";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFilterProductName
            // 
            this.txtFilterProductName.Location = new System.Drawing.Point(581, 151);
            this.txtFilterProductName.Name = "txtFilterProductName";
            this.txtFilterProductName.Size = new System.Drawing.Size(199, 27);
            this.txtFilterProductName.TabIndex = 19;
            // 
            // txtFilterUnitPrice
            // 
            this.txtFilterUnitPrice.Location = new System.Drawing.Point(581, 204);
            this.txtFilterUnitPrice.Name = "txtFilterUnitPrice";
            this.txtFilterUnitPrice.Size = new System.Drawing.Size(199, 27);
            this.txtFilterUnitPrice.TabIndex = 19;
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackColor = System.Drawing.Color.Silver;
            this.btnSearchID.Location = new System.Drawing.Point(798, 95);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(94, 29);
            this.btnSearchID.TabIndex = 20;
            this.btnSearchID.Text = "&Search";
            this.btnSearchID.UseVisualStyleBackColor = false;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.Silver;
            this.btnSearchName.Location = new System.Drawing.Point(798, 150);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(94, 29);
            this.btnSearchName.TabIndex = 20;
            this.btnSearchName.Text = "&Search";
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSearchUniPrice
            // 
            this.btnSearchUniPrice.BackColor = System.Drawing.Color.Silver;
            this.btnSearchUniPrice.Location = new System.Drawing.Point(798, 204);
            this.btnSearchUniPrice.Name = "btnSearchUniPrice";
            this.btnSearchUniPrice.Size = new System.Drawing.Size(94, 29);
            this.btnSearchUniPrice.TabIndex = 20;
            this.btnSearchUniPrice.Text = "&Search";
            this.btnSearchUniPrice.UseVisualStyleBackColor = false;
            this.btnSearchUniPrice.Click += new System.EventHandler(this.btnSearchUniPrice_Click);
            // 
            // btnSearchUnitInStock
            // 
            this.btnSearchUnitInStock.BackColor = System.Drawing.Color.Silver;
            this.btnSearchUnitInStock.Location = new System.Drawing.Point(798, 258);
            this.btnSearchUnitInStock.Name = "btnSearchUnitInStock";
            this.btnSearchUnitInStock.Size = new System.Drawing.Size(94, 29);
            this.btnSearchUnitInStock.TabIndex = 20;
            this.btnSearchUnitInStock.Text = "&Search";
            this.btnSearchUnitInStock.UseVisualStyleBackColor = false;
            this.btnSearchUnitInStock.Click += new System.EventHandler(this.btnSearchUnitInStock_Click);
            // 
            // txtFilterProductID
            // 
            this.txtFilterProductID.Location = new System.Drawing.Point(581, 99);
            this.txtFilterProductID.Name = "txtFilterProductID";
            this.txtFilterProductID.Size = new System.Drawing.Size(199, 27);
            this.txtFilterProductID.TabIndex = 21;
            // 
            // txtFilterUnitInStock
            // 
            this.txtFilterUnitInStock.Location = new System.Drawing.Point(581, 263);
            this.txtFilterUnitInStock.Name = "txtFilterUnitInStock";
            this.txtFilterUnitInStock.Size = new System.Drawing.Size(199, 27);
            this.txtFilterUnitInStock.TabIndex = 21;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 618);
            this.Controls.Add(this.txtFilterUnitInStock);
            this.Controls.Add(this.txtFilterProductID);
            this.Controls.Add(this.btnSearchUnitInStock);
            this.Controls.Add(this.btnSearchUniPrice);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.txtFilterUnitPrice);
            this.Controls.Add(this.txtFilterProductName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dvgDataProduct);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lebela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label7;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtProductID;
        private TextBox txtCategoryID;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitInStock;
        private DataGridView dvgDataProduct;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private Button btnUpdate;
        private Label label8;
        private Label lebela;
        private Label label12;
        private Label label9;
        private Label label10;
        private TextBox txtFilterProductName;
        private TextBox txtFilterUnitPrice;
        private Button btnSearchID;
        private Button btnSearchName;
        private Button btnSearchUniPrice;
        private Button btnSearchUnitInStock;
        private TextBox txtFilterProductID;
        private TextBox txtFilterUnitInStock;
    }
}