using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reponsity
{
    public class OrderReponsity : IOrderReponsity
    {
        void IOrderReponsity.Add(Order order) => OrderDAO.Instance.Insert(order);

        void IOrderReponsity.Delete(Order order) => OrderDAO.Instance.Delete(order);

        IEnumerable<Order> IOrderReponsity.GetAll() => OrderDAO.Instance.GetAllOrder();

        IEnumerable<Order> IOrderReponsity.GetReport(DateTime startDate, DateTime endDate) => OrderDAO.Instance.GetReport(startDate, endDate);

        void IOrderReponsity.Update(Order order) => OrderDAO.Instance.Update(order);
    }
}
