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
    public partial class ReportFrom : Form
    {
        IOrderDetailsReponsity orderDetailsReponsity = new OrderDetailsReponsity();
        IOrderReponsity orderReponsity = new OrderReponsity();

        BindingSource source;
        public ReportFrom()
        {
            InitializeComponent();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startdate = DateTime.Parse(dtpStartDate.Text);
                DateTime endDate = DateTime.Parse(dtpEndStart.Text);

                List<ReportList> reportList = new List<ReportList>();

                List<Order> orderList = orderReponsity.GetReport(startdate, endDate).ToList();

                foreach (var order in orderList)
                {
                    ReportList reportLists = new ReportList();

                    reportList.Add(new ReportList()
                    {
                        orderID = order.OrderId,
                        total = orderDetailsReponsity.TotalOfOrderDetail(order.OrderId)
                    });

                }

                source = new BindingSource();
                source.DataSource = reportList;
                dvgDataReport.DataSource = source;


            }
            catch (Exception ex)
            {

                throw new Exception("Get report .. " + ex.Message);
            }
        }
    }

}

public class ReportList
{
    public int orderID { get; set; }
    public decimal total { get; set; }
}
