using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess.Reponsity
{
    public class OrderDetailsReponsity : IOrderDetailsReponsity
    {
        void IOrderDetailsReponsity.Add(OrderDetail detail) => OrderDetailsDAO.Instance.Insert(detail);

        void IOrderDetailsReponsity.Delete(OrderDetail detail) => OrderDetailsDAO.Instance.Delete(detail);

        IEnumerable<OrderDetail> IOrderDetailsReponsity.GetAll() => OrderDetailsDAO.Instance.GetAllOrderDetails();

        decimal IOrderDetailsReponsity.TotalOfOrderDetail(int orderId) => OrderDetailsDAO.Instance.TotalOfOrderDetail(orderId);

        void IOrderDetailsReponsity.Update(OrderDetail detail) => OrderDetailsDAO.Instance.Update(detail);
    }
}
