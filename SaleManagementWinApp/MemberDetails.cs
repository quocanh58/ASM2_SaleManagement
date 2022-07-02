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
using SaleManagementWinApp;

namespace SaleManagementWinApp
{
    public partial class MemberDetails : Form
    {
        public IMemberReponsity MemberReponsity { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfo { get; set; }

        public MemberDetails()
        {
            InitializeComponent();
        }

        private void MemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                txtMemberId.Text = MemberInfo.MemberId.ToString();
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                cboCity.Text = MemberInfo.City;
                cboCountry.Text = MemberInfo.Country;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = new Member()
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberReponsity.Add(mem);
                    MessageBox.Show("Add new member successfully !!");
                }
                else
                {

                    MemberReponsity.Update(mem);
                    MessageBox.Show("Update information successfully !!");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member!" : "Update a member!");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
