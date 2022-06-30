namespace SaleManagementWinApp
{
    partial class frmMemberForm
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
            this.lbMemberID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSearchCity = new System.Windows.Forms.ComboBox();
            this.cbSearchCountry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterSearchBy = new System.Windows.Forms.ComboBox();
            this.txtFilterSearchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dvgData = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(507, 288);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(73, 20);
            this.lbCountry.TabIndex = 19;
            this.lbCountry.Text = "Search By";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(507, 251);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(82, 20);
            this.lbCity.TabIndex = 18;
            this.lbCity.Text = "Search box";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(36, 217);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 17;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(36, 178);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(36, 143);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(116, 20);
            this.lbMemberName.TabIndex = 15;
            this.lbMemberName.Text = "Company Name";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(36, 106);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 14;
            this.lbMemberID.Text = "Member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(93, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Member Information";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(167, 103);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(274, 27);
            this.txtMemberID.TabIndex = 24;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(167, 136);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(274, 27);
            this.txtCompanyName.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 171);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 27);
            this.txtEmail.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(274, 27);
            this.txtPassword.TabIndex = 27;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(167, 246);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(274, 28);
            this.cbCity.TabIndex = 28;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(167, 280);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(274, 28);
            this.cbCountry.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(559, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Member Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(497, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(497, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search";
            // 
            // cbSearchCity
            // 
            this.cbSearchCity.FormattingEnabled = true;
            this.cbSearchCity.Location = new System.Drawing.Point(615, 140);
            this.cbSearchCity.Name = "cbSearchCity";
            this.cbSearchCity.Size = new System.Drawing.Size(288, 28);
            this.cbSearchCity.TabIndex = 30;
            this.cbSearchCity.SelectedIndexChanged += new System.EventHandler(this.cbSearchCity_SelectedIndexChanged);
            // 
            // cbSearchCountry
            // 
            this.cbSearchCountry.FormattingEnabled = true;
            this.cbSearchCountry.Location = new System.Drawing.Point(615, 175);
            this.cbSearchCountry.Name = "cbSearchCountry";
            this.cbSearchCountry.Size = new System.Drawing.Size(288, 28);
            this.cbSearchCountry.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Country";
            // 
            // cbFilterSearchBy
            // 
            this.cbFilterSearchBy.FormattingEnabled = true;
            this.cbFilterSearchBy.Location = new System.Drawing.Point(615, 282);
            this.cbFilterSearchBy.Name = "cbFilterSearchBy";
            this.cbFilterSearchBy.Size = new System.Drawing.Size(288, 28);
            this.cbFilterSearchBy.TabIndex = 32;
            // 
            // txtFilterSearchBox
            // 
            this.txtFilterSearchBox.Location = new System.Drawing.Point(615, 243);
            this.txtFilterSearchBox.Name = "txtFilterSearchBox";
            this.txtFilterSearchBox.Size = new System.Drawing.Size(288, 27);
            this.txtFilterSearchBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Country";
            // 
            // dvgData
            // 
            this.dvgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgData.Location = new System.Drawing.Point(3, 23);
            this.dvgData.Name = "dvgData";
            this.dvgData.ReadOnly = true;
            this.dvgData.RowHeadersWidth = 51;
            this.dvgData.RowTemplate.Height = 29;
            this.dvgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgData.Size = new System.Drawing.Size(939, 212);
            this.dvgData.TabIndex = 34;
            this.dvgData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgData_CellDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Cyan;
            this.btnLoad.Location = new System.Drawing.Point(36, 337);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 35;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Cyan;
            this.btnInsert.Location = new System.Drawing.Point(136, 337);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 36;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Cyan;
            this.btnDelete.Location = new System.Drawing.Point(247, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(347, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgData);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 238);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member box:";
            // 
            // frmMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtFilterSearchBox);
            this.Controls.Add(this.cbFilterSearchBy);
            this.Controls.Add(this.cbSearchCountry);
            this.Controls.Add(this.cbSearchCity);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMemberID);
            this.Name = "frmMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCountry;
        private Label lbCity;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbMemberName;
        private Label lbMemberID;
        private Label label1;
        private TextBox txtMemberID;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cbCity;
        private ComboBox cbCountry;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbSearchCity;
        private ComboBox cbSearchCountry;
        private Label label5;
        private Label label6;
        private ComboBox cbFilterSearchBy;
        private TextBox txtFilterSearchBox;
        private Label label7;
        private Label label8;
        private DataGridView dvgData;
        private Button btnLoad;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnClose;
        private GroupBox groupBox1;
    }
}