using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reponsity
{
    public class ProductReponsity : IProductReponsity
    {
        void IProductReponsity.Add(Product product) => ProductDAO.Instance.Insert(product);

        void IProductReponsity.Delete(Product product) => ProductDAO.Instance.Delete(product);

        IEnumerable<Product> IProductReponsity.FilterProductById(int producID) => ProductDAO.Instance.FilterProductById(producID);

        IEnumerable<Product> IProductReponsity.FilterProductByName(string productName) => ProductDAO.Instance.FilterProductByName(productName);

        IEnumerable<Product> IProductReponsity.FilterProductByUnitInStock(int UnitInStock) => ProductDAO.Instance.FilterProductByUnitInStock(UnitInStock);

        IEnumerable<Product> IProductReponsity.FilterProductByUnitPrice(decimal UniPrice) => ProductDAO.Instance.FilterProductByUnitPrice(UniPrice);

        IEnumerable<Product> IProductReponsity.GetAll() => ProductDAO.Instance.GetAllProduct();

        int IProductReponsity.GetMaxID() => ProductDAO.Instance.GetMaxID();

        void IProductReponsity.Update(Product product) => ProductDAO.Instance.Update(product);

    }
}
