using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject.Models;
using DataAccess.Reponsity;

namespace SaleManagementWinApp
{

    public partial class OrderDetailsForm : Form
    {
        public IOrderDetailsReponsity orderDetailsReponsity = new OrderDetailsReponsity();

        public OrderDetail OrderDetailInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        BindingSource source;

        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public void Cleartext()
        {
            txtOrderId.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
        }

        public void LoadLisOrderDetails(IEnumerable<OrderDetail> orderDetailsList)
        {
            txtOrderId.Text = null;
            txtProductId.Text = null;
            txtDiscount.Text = null;
            txtQuantity.Text = null;
            txtUnitPrice.Text = null;

            source = new BindingSource();
            source.DataSource = orderDetailsList.ToList();

            txtOrderId.DataBindings.Clear();
            txtProductId.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();

            txtOrderId.DataBindings.Add("Text", source, "OrderId");
            txtProductId.DataBindings.Add("Text", source, "ProductId");
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            txtDiscount.DataBindings.Add("Text", source, "Discount");
            txtQuantity.DataBindings.Add("Text", source, "Quantity");

            dvgDataOrderDetails.DataSource = source;

            if (orderDetailsList.Count() == 0)
            {
                Cleartext();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }

            //Hide column not use
            if (dvgDataOrderDetails.Columns["Order"] != null)
            {
                dvgDataOrderDetails.Columns["Order"].Visible = false;
            }
            if (dvgDataOrderDetails.Columns["Product"] != null)
            {
                dvgDataOrderDetails.Columns["Product"].Visible = false;
            }

        }

        public OrderDetail GetOrderDetailsObject()
        {
            OrderDetail orderDetail = null;
            try
            {
                orderDetail = new OrderDetail()
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = int.Parse(txtProductId.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Discount = float.Parse(txtQuantity.Text)
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderDetailsObject();
                orderDetailsReponsity.Delete(order);
                LoadLisOrderDetails(orderDetailsReponsity.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadLisOrderDetails(orderDetailsReponsity.GetAll());
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InsertOrderDetailForm insertOrderForm = new InsertOrderDetailForm
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                orderDetailsReponsity = orderDetailsReponsity
            };

            if (insertOrderForm.ShowDialog() == DialogResult.OK)
            {
                LoadLisOrderDetails(orderDetailsReponsity.GetAll());
                source.Position = source.Count - 1;
            }
        }
    }
}
