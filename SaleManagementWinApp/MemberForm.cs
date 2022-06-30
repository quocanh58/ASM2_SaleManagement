using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject.Models;
using DataAccess.Reponsity;

namespace SaleManagementWinApp
{
    public partial class frmMemberForm : Form
    {
        IMemberReponsity memberReponsity = new MemberReponsity();
        BindingSource source;
        public Member memberInfo { get; set; }

        public frmMemberForm()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            txtEmail.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbCity.SelectedIndex = -1;
            cbCountry.SelectedIndex = -1;
        }

        public IEnumerable<Member> getAllMemberList => memberReponsity.GetAllMember();

        public void LoadMemberList()
        {
            var mem = memberReponsity.GetAllMember().OrderByDescending(x => x.MemberId);
            try
            {

                source = new BindingSource();
                source.DataSource = mem;

                txtMemberID.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                cbCity.DataBindings.Clear();
                cbCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                cbCity.DataBindings.Add("Text", source, "City");
                cbCountry.DataBindings.Add("Text", source, "Country");

                dvgData.DataSource = source;

                //hide column Order
                if (dvgData.Columns["Orders"] != null)
                {
                    dvgData.Columns["Orders"].Visible = false;
                }


                if (mem.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void frmMemberForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dvgData.CellDoubleClick += dvgData_CellDoubleClick;
        }

        private void dvgData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberDetails memberDetails = new MemberDetails()
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberReponsity = memberReponsity
            };
            if (memberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {   
            MemberDetails memberDetails = new MemberDetails
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MemberReponsity = memberReponsity
            };

            if (memberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberReponsity.Detele(member);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member()
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cbCity.Text,
                    Country = cbCountry.Text,
                };
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "Get member");
            }
            return member;
        }

        public void LoadMemberListSearch()
        {

        }

        private void cbSearchCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
