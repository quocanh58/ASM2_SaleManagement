using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Reponsity;
using BussinessObject.Models;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();

        private ProductDAO() { }

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> GetAllProduct()
        {
            FStoreManagementDBContext fptEduStoreContext = new FStoreManagementDBContext();
            var productList = from product in fptEduStoreContext.Products select product;
            return productList.ToList();
        }

        internal IEnumerable<Product> FilterProductByUnitPrice(string uniPrice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByName(string productName)
        {
            FStoreManagementDBContext fptEduStoreContext = new FStoreManagementDBContext();
            var productList = from product in fptEduStoreContext.Products where product.ProductName.Equals(productName) select product;
            return productList.ToList();
        }

        public void Insert(Product product)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {

                    FStoreManagementDBContext.Products.Add(product);
                    FStoreManagementDBContext.SaveChanges();

                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error new a product \n" + ex);
            }
        }

        public void Update(Product product)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext.Products.Update(product);
                    FStoreManagementDBContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error update a product" + ex.Message);
            }
        }

        public void Delete(Product product)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    var products = FStoreManagementDBContext.Products.SingleOrDefault(pro => pro.ProductId == product.ProductId);
                    FStoreManagementDBContext.Products.Remove(products);
                    FStoreManagementDBContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error delete member " + ex.Message);
            }
        }

        public int GetMaxID()
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext fptEduStoreContext = new FStoreManagementDBContext();
                    var MaxId = (from product in FStoreManagementDBContext.Products
                                 orderby product.ProductId descending
                                 select product.ProductId).FirstOrDefault();
                    return MaxId;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Product> FilterProductById(int id)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {

                    FStoreManagementDBContext fs = new FStoreManagementDBContext();
                    var pro = fs.Products.Where(x => x.ProductId <= id);
                    return pro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public IEnumerable<Product> FilterProductByName(string proName)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext fs = new FStoreManagementDBContext();
                    var pro = fs.Products.Where(x => x.ProductName.Contains(proName));
                    return pro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Product> FilterProductByUnitPrice(decimal UnitPrice)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext fs = new FStoreManagementDBContext();
                    var pro = fs.Products.Where(x => x.UnitPrice <= UnitPrice);
                    return pro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Product> FilterProductByUnitInStock(int UnitInStock)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext fs = new FStoreManagementDBContext();
                    var pro = fs.Products.Where(x => x.UnitsInStock <= UnitInStock);
                    return pro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
