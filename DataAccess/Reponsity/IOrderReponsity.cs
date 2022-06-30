using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess.Reponsity
{
    public interface IOrderReponsity
    {
        IEnumerable<Order> GetAll(); 
        IEnumerable<Order> GetReport(DateTime startDate, DateTime endDate);
        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);


    }
}
