namespace SaleManagementWinApp
{
    partial class ProductDetails
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
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(63, 296);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(90, 20);
            this.lbCountry.TabIndex = 28;
            this.lbCountry.Text = "UnitsInStock";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(63, 253);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(68, 20);
            this.lbCity.TabIndex = 27;
            this.lbCity.Text = "UnitPrice";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(63, 207);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 20);
            this.lbPassword.TabIndex = 26;
            this.lbPassword.Text = "Weight";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(63, 159);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(84, 20);
            this.lbEmail.TabIndex = 25;
            this.lbEmail.Text = "CategoryID";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(63, 114);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(104, 20);
            this.lbMemberName.TabIndex = 24;
            this.lbMemberName.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product Details";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(63, 72);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(79, 20);
            this.lbMemberID.TabIndex = 23;
            this.lbMemberID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(184, 69);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(282, 27);
            this.txtProductID.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(184, 111);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(282, 27);
            this.txtProductName.TabIndex = 1;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(184, 156);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(282, 27);
            this.txtCategoryId.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(184, 204);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(282, 27);
            this.txtWeight.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(184, 246);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(282, 27);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(184, 289);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(282, 27);
            this.txtUnitInStock.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(184, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(372, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(529, 421);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMemberID);
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCountry;
        private Label lbCity;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbMemberName;
        private Label label1;
        private Label lbMemberID;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtCategoryId;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitInStock;
        private Button btnSave;
        private Button btnClose;
    }
}