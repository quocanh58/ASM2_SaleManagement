namespace SaleManagementWinApp
{
    partial class InsertOrderDetailForm
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
            this.txtUnitPriceDeatail = new System.Windows.Forms.TextBox();
            this.txtDiscountDeatail = new System.Windows.Forms.TextBox();
            this.txtProductIdDeatail = new System.Windows.Forms.TextBox();
            this.txtQuantityDeatail = new System.Windows.Forms.TextBox();
            this.txtOrderIdDeatail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnitPriceDeatail
            // 
            this.txtUnitPriceDeatail.Location = new System.Drawing.Point(173, 175);
            this.txtUnitPriceDeatail.Name = "txtUnitPriceDeatail";
            this.txtUnitPriceDeatail.Size = new System.Drawing.Size(268, 27);
            this.txtUnitPriceDeatail.TabIndex = 14;
            // 
            // txtDiscountDeatail
            // 
            this.txtDiscountDeatail.Location = new System.Drawing.Point(173, 279);
            this.txtDiscountDeatail.Name = "txtDiscountDeatail";
            this.txtDiscountDeatail.Size = new System.Drawing.Size(268, 27);
            this.txtDiscountDeatail.TabIndex = 15;
            // 
            // txtProductIdDeatail
            // 
            this.txtProductIdDeatail.Location = new System.Drawing.Point(173, 125);
            this.txtProductIdDeatail.Name = "txtProductIdDeatail";
            this.txtProductIdDeatail.Size = new System.Drawing.Size(268, 27);
            this.txtProductIdDeatail.TabIndex = 16;
            // 
            // txtQuantityDeatail
            // 
            this.txtQuantityDeatail.Location = new System.Drawing.Point(173, 227);
            this.txtQuantityDeatail.Name = "txtQuantityDeatail";
            this.txtQuantityDeatail.Size = new System.Drawing.Size(268, 27);
            this.txtQuantityDeatail.TabIndex = 17;
            // 
            // txtOrderIdDeatail
            // 
            this.txtOrderIdDeatail.Location = new System.Drawing.Point(173, 73);
            this.txtOrderIdDeatail.Name = "txtOrderIdDeatail";
            this.txtOrderIdDeatail.Size = new System.Drawing.Size(268, 27);
            this.txtOrderIdDeatail.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Order Detail Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "UnitPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "ProductID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "OrderID";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(347, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(173, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InsertOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 394);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitPriceDeatail);
            this.Controls.Add(this.txtDiscountDeatail);
            this.Controls.Add(this.txtProductIdDeatail);
            this.Controls.Add(this.txtQuantityDeatail);
            this.Controls.Add(this.txtOrderIdDeatail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "InsertOrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertOrderDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUnitPriceDeatail;
        private TextBox txtDiscountDeatail;
        private TextBox txtProductIdDeatail;
        private TextBox txtQuantityDeatail;
        private TextBox txtOrderIdDeatail;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label1;
        private Button btnClose;
        private Button btnSave;
    }
}