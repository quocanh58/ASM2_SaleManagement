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
    public partial class InsertOrderDetailForm : Form
    {
        public IOrderDetailsReponsity orderDetailsReponsity { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderDetail orderDetail { get; set; }
        public InsertOrderDetailForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = new OrderDetail()
                {
                    OrderId = int.Parse(txtOrderIdDeatail.Text),
                    ProductId = int.Parse(txtProductIdDeatail.Text),
                    UnitPrice = decimal.Parse(txtUnitPriceDeatail.Text),
                    Quantity = int.Parse(txtQuantityDeatail.Text),
                    Discount = float.Parse(txtDiscountDeatail.Text),

                };
                if (InsertOrUpdate == false)
                {
                    orderDetailsReponsity.Add(orderDetail);
                    MessageBox.Show("Add new order successfully !!");
                }
                else
                {

                    orderDetailsReponsity.Update(orderDetail);
                    MessageBox.Show("Update information successfully !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Order detail!" : "Update a order details!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
