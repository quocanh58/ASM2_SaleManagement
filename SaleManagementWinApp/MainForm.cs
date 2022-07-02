using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMemberForm().Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
            this.Hide();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrderForm().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dr =  MessageBox.Show("Are you sure logout with role ADMIN ?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                this.Hide();
                new frmLogin().Show();
            }

        }

        private void orderDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrderDetailsForm().Show();
            this.Hide();
        }

        private void getReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportFrom().Show();
        }
    }
}
