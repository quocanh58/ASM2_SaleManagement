using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess.Reponsity
{
    public interface IOrderDetailsReponsity
    {
        IEnumerable<OrderDetail> GetAll();
        void Add(OrderDetail detail);
        void Update(OrderDetail detail);
        void Delete(OrderDetail detail);
    }
}
