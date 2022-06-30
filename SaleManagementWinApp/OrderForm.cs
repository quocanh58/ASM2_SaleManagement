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
    public partial class OrderForm : Form
    {
        IOrderReponsity orderReponsity = new OrderReponsity();
        BindingSource source;

        public IOrderReponsity orderReponsiti { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfo { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        public void clearText()
        {
            txtFreight.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderID.Text = string.Empty;

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListOrder(orderReponsity.GetAll());
        }



        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
