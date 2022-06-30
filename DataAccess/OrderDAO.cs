using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Reponsity;
using BussinessObject.Models;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();

        public OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetAllOrder()
        {
            FStoreManagementDBContext FStoreManagementDBContext = new FStoreManagementDBContext();
            var orderList = from order in FStoreManagementDBContext.Orders select order;
            return orderList.ToList();
        }

        public IEnumerable<Order> GetOrderByName(string orderName)
        {
            FStoreManagementDBContext FStoreManagementDBContext = new FStoreManagementDBContext();
            var orderList = from order in FStoreManagementDBContext.Orders where order.OrderId.Equals(orderName) select order;
            return orderList.ToList();
        }

        public void Insert(Order order)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext.Orders.Add(order);
                    FStoreManagementDBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error new a product \n" + ex.Message);
            }
        }

        public void Update(Order order)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext.Orders.Update(order);
                    FStoreManagementDBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error update a product" + ex.Message);
            }
        }

        public void Delete(Order orders)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    var order = FStoreManagementDBContext.Orders.SingleOrDefault(order => order.OrderId == orders.OrderId);
                    FStoreManagementDBContext.Orders.Remove(orders);
                    FStoreManagementDBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error delete a product" + ex.Message);
            }
        }

        public int GetMaxOrderId()
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    FStoreManagementDBContext fptEduStoreContext = new FStoreManagementDBContext();
                    var MaxOrderId = (from order in FStoreManagementDBContext.Orders
                                      orderby order.OrderId descending
                                      select order.OrderId).FirstOrDefault();
                    return MaxOrderId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Order> GetReport(DateTime start, DateTime end)
        {
            try
            {
                FStoreManagementDBContext fStoreDBContext = new FStoreManagementDBContext();
                var list = fStoreDBContext.Orders.Where(order => order.OrderDate >= start && order.OrderDate <= end);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
