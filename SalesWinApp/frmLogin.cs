using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository;
        public frmLogin()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtEmail;
            txtEmail.TabIndex = 0;
            txtPassword.TabIndex = 1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            MemberObject member = memberRepository.GetMemberByEmail(email);
            if (member == null || member.Password != password)
            {
                MessageBox.Show("Email or password is incorrect!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                frmMember frmMember = new frmMember(member);
                frmMember.Show();
                this.Hide();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}