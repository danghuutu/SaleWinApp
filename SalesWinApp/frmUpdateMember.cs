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
    public partial class frmUpdateMember : Form
    {
        MemberObject updatedMember;
        public frmUpdateMember(MemberObject updatedMember)
        {
            this.updatedMember = updatedMember;
            InitializeComponent();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            txtMemberId.Text = updatedMember.MemberId.ToString();
            txtMemberId.Enabled = false;
            txtEmail.Text = updatedMember.Email;
            txtCompany.Text = updatedMember.CompanyName;
            txtCountry.Text = updatedMember.Country;
            txtCity.Text = updatedMember.City;
            txtPassword.Text = updatedMember.Password;

            this.ActiveControl = txtEmail;
            txtEmail.TabIndex = 0;
            txtCompany.TabIndex = 1;
            txtCity.TabIndex = 2;
            txtCountry.TabIndex = 3;
            txtPassword.TabIndex = 4;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length == 0 || txtPassword.Text.Length == 0 || txtCompany.Text.Length == 0 ||
                txtCountry.Text.Length == 0 || txtCity.Text.Length == 0)
            {
                MessageBox.Show("Cannot leave any field empty!");
            }
            else
            {
                IMemberRepository memberRepository = new MemberRepository();
                if (updatedMember.Email != txtEmail.Text && memberRepository.GetMemberByEmail(txtEmail.Text) != null)
                {
                    MessageBox.Show("Email has been used!");
                    this.ActiveControl = txtEmail;

                }
                else
                {
                    MemberObject member = new MemberObject(Convert.ToInt32(txtMemberId.Text.ToString()),
                                                         txtEmail.Text,
                                                         txtCompany.Text,
                                                         txtCity.Text,
                                                         txtCountry.Text,
                                                         txtPassword.Text
                                                 );
                    memberRepository.UpdateMember(member);
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();
    }
}
