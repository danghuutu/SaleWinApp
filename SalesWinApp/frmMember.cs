using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        MemberObject loggedInMember = null;
        public frmMember(MemberObject loggedInMember)
        {
            this.loggedInMember = loggedInMember;
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            txtEmail.Enabled = false;
            txtCompany.Enabled = false;
            txtCity.Enabled = false;
            txtCountry.Enabled = false;

            if (loggedInMember.Email == ("admin@fstore.com"))
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnViewOrder.Visible = false;

                txtMemberId.Text = "";
                txtEmail.Text = "";
                txtCompany.Text = "";
                txtCity.Text = "";
                txtCountry.Text = "";
                IMemberRepository memberRepository = new MemberRepository();
                List<MemberObject> members = memberRepository.GetMembers();
                foreach (MemberObject member in members)
                {
                    if (member.Email == "admin@fstore.com")
                    {
                        members.Remove(member);
                        break;
                    }
                }
                dgvMember.DataSource = members;
                dgvMember.ClearSelection();

            }
            else
            {
                btnCreate.Visible = false;
                btnDelete.Visible = false;
                btnOrder.Visible = false;
                btnProduct.Visible = false;
                dgvMember.Visible = false;
                txtMemberId.Text = loggedInMember.MemberId.ToString();
                txtEmail.Text = loggedInMember.Email.ToString();
                txtCompany.Text = loggedInMember.CompanyName.ToString();
                txtCity.Text = loggedInMember.City.ToString();
                txtCountry.Text = loggedInMember.Country.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateMember frmCreateMember = new frmCreateMember();
            frmCreateMember.ShowDialog();
            frmMember_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(txtMemberId.Text);
            IMemberRepository memberRepository = new MemberRepository();
            MemberObject member = memberRepository.GetMemberById(memberId);
            frmUpdateMember frmUpdateMember = new frmUpdateMember(member);
            frmUpdateMember.ShowDialog();
            if (loggedInMember.Email != ("admin@fstore.com"))
            {
                loggedInMember = memberRepository.GetMemberById(memberId);
            }
            frmMember_Load(sender, e);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMember.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvMember.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvMember.Rows[selectedRowIndex];

                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int memberId = Convert.ToInt32(selectedRow.Cells["MemberId"].Value);
                    IMemberRepository memberRepository = new MemberRepository();
                    memberRepository.DeleteMember(memberId);
                    frmMember_Load(sender, e);

                }
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder(loggedInMember);
            frmOrder.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder(loggedInMember);
            frmOrder.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            if (dgvMember.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvMember.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvMember.Rows[selectedRowIndex];

                txtMemberId.Text = Convert.ToString(selectedRow.Cells["MemberId"].Value);
                txtEmail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                txtCompany.Text = Convert.ToString(selectedRow.Cells["CompanyName"].Value);
                txtCity.Text = Convert.ToString(selectedRow.Cells["City"].Value);
                txtCountry.Text = Convert.ToString(selectedRow.Cells["Country"].Value);
            }
        }
    }
}
