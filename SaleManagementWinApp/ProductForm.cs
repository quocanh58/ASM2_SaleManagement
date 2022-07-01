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
    public partial class ProductForm : Form
    {
        IProductReponsity productReponsity = new ProductReponsity();

        BindingSource source;
        public Product ProductInfo { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dvgDataProduct.CellDoubleClick += dvgDataProduct_CellDoubleClick;
        }


        private void dvgDataProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductDetails product = new ProductDetails()
            {
                Text = "Update product",
                InsertOrUpdate = true,
                productInfo = GetProductObject(),
                productReponsity = productReponsity
            };
            if (product.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(productReponsity.GetAll());
                source.Position = source.Position - 1;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        public void ClearText()
        {

            txtCategoryID.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtWeight.Text = string.Empty;


        }

        public IEnumerable<Object> getAllProduct => productReponsity.GetAll();



        public void LoadProductList(IEnumerable<Product> products)
        {
            //var product = productReponsity.GetAll();
            try
            {
                txtProductID.Text = null;
                txtProductName.Text = null;
                txtCategoryID.Text = null;
                txtUnitInStock.Text = null;
                txtUnitPrice.Text = null;
                txtWeight.Text = null;

                source = new BindingSource();
                source.DataSource = products.ToList();

                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtWeight.DataBindings.Add("Text", source, "Weight");

                dvgDataProduct.DataSource = null;
                dvgDataProduct.DataSource = source;

                //hide column not use
                if (dvgDataProduct.Columns["Discontinued"] != null)
                {
                    dvgDataProduct.Columns["Discontinued"].Visible = false;
                }
                if (dvgDataProduct.Columns["ReorderLevel"] != null)
                {
                    dvgDataProduct.Columns["ReorderLevel"].Visible = false;
                }
                if (dvgDataProduct.Columns["SupplierId"] != null)
                {
                    dvgDataProduct.Columns["SupplierId"].Visible = false;
                }
                if (dvgDataProduct.Columns["UnitsOnOrder"] != null)
                {
                    dvgDataProduct.Columns["UnitsOnOrder"].Visible = false;
                }
                if (dvgDataProduct.Columns["Category"] != null)
                {
                    dvgDataProduct.Columns["Category"].Visible = false;
                }
                if (dvgDataProduct.Columns["Supplier"] != null)
                {
                    dvgDataProduct.Columns["Supplier"].Visible = false;
                }
                if (dvgDataProduct.Columns["OrderDetails"] != null)
                {
                    dvgDataProduct.Columns["OrderDetails"].Visible = false;
                }

                if (products.Count() == 0)
                {
                    ClearText();
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
            LoadProductList(productReponsity.GetAll());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            ProductDetails productDetails = new ProductDetails()
            {

                Text = "Add new product ",
                InsertOrUpdate = false,
                productReponsity = productReponsity
            };

            if (productDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(productReponsity.GetAll());
                source.Position = source.Position - 1;
            }
        }

        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product()
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    Weight = txtWeight.Text,
                    UnitsInStock = int.Parse(txtUnitInStock.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text) 
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return product;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productReponsity.Delete(product);
                LoadProductList(productReponsity.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtFilterProductID.Text);

            try
            {
                if (productId != 0)
                {
                    productReponsity.FilterProductById(productId);
                    LoadProductList(productReponsity.FilterProductById(productId));
                }
                else
                {
                    MessageBox.Show("Input string was not in a correct format", "Wrong input string", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error search by product id " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtFilterProductID.Text);

            try
            {
                if (productId != 0)
                {
                    MessageBox.Show(productId.ToString());
                    productReponsity.FilterProductById(productId);
                    LoadProductList(productReponsity.FilterProductById(productId));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error search by product id " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int productId = int.Parse(txtFilterProductID.Text);

            try
            {
                if (productId != 0)
                {
                    productReponsity.FilterProductById(productId);
                    LoadProductList(productReponsity.FilterProductById(productId));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error search by product id " + ex.Message);
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string proName = txtFilterProductName.Text.Trim();
            try
            {
                if (proName.Length != 0)
                {
                    productReponsity.FilterProductByName(proName);
                    LoadProductList(productReponsity.FilterProductByName(proName).ToList());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error search by product name " + ex.Message);
            }
        }

        private void btnSearchUniPrice_Click(object sender, EventArgs e)
        {
            decimal unitPrice = decimal.Parse(txtFilterUnitPrice.Text);
            try
            {
                if (unitPrice != 0)
                {
                    LoadProductList(productReponsity.FilterProductByUnitPrice(unitPrice).ToList());
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnSearchUnitInStock_Click(object sender, EventArgs e)
        {
            int unitStocl = int.Parse(txtFilterUnitInStock.Text);
            try
            {
                if (unitStocl != 0)
                {
                    LoadProductList(productReponsity.FilterProductByUnitInStock(unitStocl));
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductDetails product = new ProductDetails()
            {
                Text = "Update product",
                InsertOrUpdate = true,
                productInfo = GetProductObject(),
                productReponsity = productReponsity
            };
            if (product.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(productReponsity.GetAll());
                source.Position = source.Position - 1;
            }
        }
    }
}
