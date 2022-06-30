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
    public partial class UserForm : Form
    {

        IOrderReponsity orderReponsity = new OrderReponsity();
        IOrderDetailsReponsity orderDetailsReponsity = new OrderDetailsReponsity();
        BindingSource source;
        public Order OrderInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public UserForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clearText()
        {
            txtFreight.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtOrderIdDetail.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            dtpOrderDate.Text = string.Empty;
            dtpRequiredDate.Text = string.Empty;
            dtpShippedDate.Text = string.Empty;
        }

        public void LoadListOrder(IEnumerable<Order> orderList)
        {
            try
            {
                txtFreight.Text = null;
                txtMemberID.Text = null;
                txtOrderID.Text = null;
                dtpOrderDate.Text = null;
                dtpRequiredDate.Text = null;
                dtpShippedDate.Text = null;

                source = new BindingSource();
                source.DataSource = orderList.ToList();

                txtFreight.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtOrderID.DataBindings.Clear();
                dtpOrderDate.DataBindings.Clear();
                dtpRequiredDate.DataBindings.Clear();
                dtpShippedDate.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtFreight.DataBindings.Add("Text", source, "Freight");
                dtpOrderDate.DataBindings.Add("Text", source, "OrderDate");
                dtpRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                dtpShippedDate.DataBindings.Add("Text", source, "ShippedDate");

                dvgdataOrder.DataSource = source;

                //hide column not use
                if (dvgdataOrder.Columns["Member"] != null)
                {
                    dvgdataOrder.Columns["Member"].Visible = false;
                }
                if (dvgdataOrder.Columns["OrderDetails"] != null)
                {
                    dvgdataOrder.Columns["OrderDetails"].Visible = false;
                }
                if (dvgdataOrder.Columns["Order"] != null)
                {
                    dvgdataOrder.Columns["Order"].Visible = false;
                }


                if (orderList.Count() == 0)
                {
                    clearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LoadLisOrderDetails(IEnumerable<OrderDetail> orderDetailsList)
        {
            txtOrderIdDetail.Text = null;
            txtProductId.Text = null;
            txtDiscount.Text = null;
            txtQuantity.Text = null;
            txtUnitPrice.Text = null;

            source = new BindingSource();
            source.DataSource = orderDetailsList.ToList();

            txtOrderIdDetail.DataBindings.Clear();
            txtProductId.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();

            txtOrderIdDetail.DataBindings.Add("Text", source, "OrderId");
            txtProductId.DataBindings.Add("Text", source, "ProductId");
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            txtDiscount.DataBindings.Add("Text", source, "Discount");
            txtQuantity.DataBindings.Add("Text", source, "Quantity");

            dvgDataOrderDetails.DataSource = source;

            if (orderDetailsList.Count() == 0)
            {
                clearText();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListOrder(orderReponsity.GetAll());
        }

        private void btnLoadOrderDetail_Click(object sender, EventArgs e)
        {
            LoadLisOrderDetails(orderDetailsReponsity.GetAll());
        }

        public Order GetOrderObject()
        {
            Order order = null;
            try
            {
                order = new Order()
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDate = DateTime.Parse(dtpOrderDate.Text),
                    RequiredDate = DateTime.Parse(dtpRequiredDate.Text),
                    ShippedDate = DateTime.Parse(dtpShippedDate.Text),
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderReponsity.Delete(order);
                LoadListOrder(orderReponsity.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure logout with role USER !", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {


            InsertOrderForm insertOrderForm = new InsertOrderForm
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                orderReponsity = orderReponsity
            };

            if (insertOrderForm.ShowDialog() == DialogResult.OK)
            {
                LoadListOrder(orderReponsity.GetAll());
                source.Position = source.Count - 1;
            }
        }

        private void btnNewOrderDetail_Click(object sender, EventArgs e)
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

        private void dvgdataOrder_DoubleClick(object sender, EventArgs e)
        {
            InsertOrderForm insertOrderForm = new InsertOrderForm
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                orderReponsity = orderReponsity
            };

            if (insertOrderForm.ShowDialog() == DialogResult.OK)
            {
                LoadListOrder(orderReponsity.GetAll());
                source.Position = source.Count - 1;
            }
        }
    }
}
