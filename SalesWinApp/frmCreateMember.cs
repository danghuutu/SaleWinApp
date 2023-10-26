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
    public partial class frmCreateMember : Form
    {
        public frmCreateMember()
        {
            InitializeComponent();
        }

        private void frmCreateMember_Load(object sender, EventArgs e)
        {
            txtEmail.TabIndex = 0;
            txtPassword.TabIndex = 1;
            txtCompany.TabIndex = 2;
            txtCity.TabIndex = 3;
            txtCountry.TabIndex = 4;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length == 0 || txtPassword.Text.Length == 0 || txtCompany.Text.Length == 0 ||
                 txtCountry.Text.Length == 0 || txtCity.Text.Length == 0)
            {
                MessageBox.Show("Cannot leave any field empty!");
            }
            else
            {
                IMemberRepository memberRepository = new MemberRepository();
                if (memberRepository.GetMemberByEmail(txtEmail.Text) != null)
                {
                    MessageBox.Show("Email has been used!");
                    this.ActiveControl = txtEmail;

                }
                else
                {
                    MemberObject member = new MemberObject(-1,
                                                         txtEmail.Text,
                                                         txtCompany.Text,
                                                         txtCity.Text,
                                                         txtCountry.Text,
                                                         txtPassword.Text
                                                 );
                    memberRepository.InsertMember(member);
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();
    }
}
