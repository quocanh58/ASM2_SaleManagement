using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Reponsity;
using BussinessObject.Models;

namespace DataAccess
{
    public class OrderDetailsDAO
    {
        private static OrderDetailsDAO instance = null;
        private static readonly object instanceLock = new object();
        public bool InsertOrUpdate { get; set; }

        private OrderDetailsDAO() { }

        public static OrderDetailsDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailsDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            FStoreManagementDBContext fptEduStoreContext = new FStoreManagementDBContext();
            var orderDetails = from orderdetail in fptEduStoreContext.OrderDetails select orderdetail;
            return orderDetails;
        }

        public void Insert(OrderDetail orderDetail)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {

                    FStoreManagementDBContext.OrderDetails.Add(orderDetail);
                    FStoreManagementDBContext.SaveChanges();

                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error new a order detail \n" + ex);
            }
        }

        public void Update(OrderDetail orderDetail)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {

                    FStoreManagementDBContext.OrderDetails.Update(orderDetail);
                    FStoreManagementDBContext.SaveChanges();

                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error new a order detail \n" + ex);
            }
        }

        public void Delete(OrderDetail orderDetail)
        {
            try
            {
                using (var FStoreManagementDBContext = new FStoreManagementDBContext())
                {
                    var orderDetails = FStoreManagementDBContext.OrderDetails.SingleOrDefault(pro => pro.OrderId == orderDetail.OrderId);
                    FStoreManagementDBContext.OrderDetails.Remove(orderDetails);
                    FStoreManagementDBContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error delete member " + ex.Message);
            }
        }
    }
}
