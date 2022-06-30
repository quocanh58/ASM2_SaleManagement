using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess.Reponsity
{
    public interface IProductReponsity
    {
        IEnumerable<Product> GetAll();

        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        int GetMaxID();

        IEnumerable<Product> FilterProductById(int producID);
        IEnumerable<Product> FilterProductByName(string producName);
        IEnumerable<Product> FilterProductByUnitPrice(decimal UniPrice);
        IEnumerable<Product> FilterProductByUnitInStock(int UnitInStock);

    }
}
