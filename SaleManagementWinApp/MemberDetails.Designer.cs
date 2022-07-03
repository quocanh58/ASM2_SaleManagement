namespace SaleManagementWinApp
{
    partial class MemberDetails
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
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(44, 296);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(71, 23);
            this.lbCountry.TabIndex = 21;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(44, 246);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(39, 23);
            this.lbCity.TabIndex = 20;
            this.lbCity.Text = "City";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(44, 207);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(80, 23);
            this.lbPassword.TabIndex = 19;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(44, 159);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 23);
            this.lbEmail.TabIndex = 18;
            this.lbEmail.Text = "Email";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(44, 118);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(134, 23);
            this.lbMemberName.TabIndex = 17;
            this.lbMemberName.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Member Details";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(44, 72);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(96, 23);
            this.lbMemberID.TabIndex = 16;
            this.lbMemberID.Text = "Member ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(199, 72);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(256, 30);
            this.txtMemberId.TabIndex = 22;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(199, 110);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(256, 30);
            this.txtCompanyName.TabIndex = 23;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(199, 155);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(256, 30);
            this.txtmail.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(199, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(256, 30);
            this.txtPassword.TabIndex = 25;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(199, 237);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(256, 31);
            this.cboCity.TabIndex = 26;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(199, 286);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(256, 31);
            this.cboCountry.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(199, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 33);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(350, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 33);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(510, 403);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMemberID);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "MemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.MemberDetails_Load);
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
        private TextBox txtMemberId;
        private TextBox txtCompanyName;
        private TextBox txtmail;
        private TextBox txtPassword;
        private ComboBox cboCity;
        private ComboBox cboCountry;
        private Button btnSave;
        private Button btnClose;
    }
}