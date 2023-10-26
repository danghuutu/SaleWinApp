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
    public partial class frmOrder : Form
    {
        public MemberObject member;
        public frmOrder(MemberObject member)
        {
            this.member = member;
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            if (member.Email == "admin@fstore.com")
            {
                IOrderRepository orderRepository = new OrderRepository();
                List<OrderObject> orders = orderRepository.GetOrders();
                dgvOrder.DataSource = orders;

            }
            else
            {
                IOrderRepository orderRepository = new OrderRepository();
                List<OrderObject> orders = orderRepository.GetOrdersByMemberId(member.MemberId);
                dgvOrder.DataSource = orders;
            }
            btnViewDetail.Enabled = false;
            dgvOrder.ClearSelection();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvOrder.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvOrder.Rows[selectedIndex];
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value.ToString());
                frmOrderDetail frmOrderDetail = new frmOrderDetail(orderId);
                frmOrderDetail.ShowDialog();

            }
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnViewDetail.Enabled = true;
        }
    }
}
