namespace SaleManagementWinApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuSaleManagement = new System.Windows.Forms.MenuStrip();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaleManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSaleManagement
            // 
            this.menuSaleManagement.BackColor = System.Drawing.Color.LightCyan;
            this.menuSaleManagement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuSaleManagement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSaleManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.productToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.orderDetailToolStripMenuItem,
            this.getReportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuSaleManagement.Location = new System.Drawing.Point(0, 0);
            this.menuSaleManagement.Name = "menuSaleManagement";
            this.menuSaleManagement.Size = new System.Drawing.Size(991, 33);
            this.menuSaleManagement.TabIndex = 0;
            this.menuSaleManagement.Text = "menuStrip1";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.memberToolStripMenuItem.Text = "&Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.productToolStripMenuItem.Text = "&Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.orderToolStripMenuItem.Text = "&Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // orderDetailToolStripMenuItem
            // 
            this.orderDetailToolStripMenuItem.Name = "orderDetailToolStripMenuItem";
            this.orderDetailToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.orderDetailToolStripMenuItem.Text = "&OrderDetail";
            this.orderDetailToolStripMenuItem.Click += new System.EventHandler(this.orderDetailToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // getReportToolStripMenuItem
            // 
            this.getReportToolStripMenuItem.Name = "getReportToolStripMenuItem";
            this.getReportToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.getReportToolStripMenuItem.Text = "&Get Report";
            this.getReportToolStripMenuItem.Click += new System.EventHandler(this.getReportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuSaleManagement);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuSaleManagement;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleManagement";
            this.menuSaleManagement.ResumeLayout(false);
            this.menuSaleManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuSaleManagement;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem orderDetailToolStripMenuItem;
        private ToolStripMenuItem getReportToolStripMenuItem;
    }
}