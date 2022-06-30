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
    public partial class ProductDetails : Form
    {
        public IProductReponsity productReponsity = new ProductReponsity();
        public Product productInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public ProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            txtProductName.Enabled = !InsertOrUpdate;
            
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = productInfo.ProductId.ToString();
                txtProductName.Text = productInfo.ProductName;
                txtCategoryId.Text = productInfo.CategoryId.ToString();
                txtUnitInStock.Text = productInfo.UnitsInStock.ToString();
                txtUnitPrice.Text = productInfo.UnitPrice.ToString();
                txtWeight.Text = productInfo.Weight;

            } else
            {
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product()
                {
                    //ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryId.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = short.Parse(txtUnitInStock.Text),
                    Weight = txtWeight.Text,
                    
                };
                if (InsertOrUpdate == false)
                {
                    productReponsity.Add(product);
                    MessageBox.Show("Add new product successfully !!");
                }
                else
                {
                    productReponsity.Update(product);
                    MessageBox.Show("Update information successfully !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member!" : "Update a member!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
