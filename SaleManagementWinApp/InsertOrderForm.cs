using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Reponsity;
using BussinessObject.Models;

namespace SaleManagementWinApp
{
    public partial class InsertOrderForm : Form
    {

        public IOrderReponsity orderReponsity { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order orderInfo { get; set; }
        public InsertOrderForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order()
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderId = int.Parse(txtOrderID.Text),
                    OrderDate = DateTime.Parse(dtpOrderDate.Text),
                    RequiredDate = DateTime.Parse(dtpRequiredDate.Text),
                    ShippedDate = DateTime.Parse(dtpShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
                if (InsertOrUpdate == false)
                {
                    orderReponsity.Add(order);
                    MessageBox.Show("Add new order successfully !!");
                }
                else
                {
                    orderReponsity.Update(order);
                    MessageBox.Show("Update information successfully !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Order!" : "Update a order!");
            }
        }

        private void InsertOrderForm_Load(object sender, EventArgs e)
        {
            
            txtOrderID.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                txtOrderID.Text = orderInfo.OrderId.ToString();
                txtMemberID.Text = orderInfo.MemberId.ToString();
                txtFreight.Text = orderInfo.Freight.ToString();
                dtpOrderDate.Text = orderInfo.OrderDate.ToString();
                dtpRequiredDate.Text = orderInfo.RequiredDate.ToString();
                dtpShippedDate.Text = orderInfo.ShippedDate.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
