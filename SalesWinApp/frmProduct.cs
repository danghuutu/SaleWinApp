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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            IProductRepository productRepository = new ProductRepository();
            List<ProductObject> products = productRepository.GetProducts();
            dgvProduct.DataSource = products;
            dgvProduct.ClearSelection();
            this.btnUpdate.Enabled = false;
            this.rdById.Checked = true;
            this.btnSearch.Enabled = false;
            this.txtSearch.Text = "";
            btnLoad.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                btnSearch.Enabled = true;
            }
        }

        private void rdById_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdByName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IProductRepository productRepository = new ProductRepository();

            if (rdById.Checked)
            {
                try
                {
                    int productId = Convert.ToInt32(txtSearch.Text.Trim());
                    List<ProductObject> validProducts = new List<ProductObject>();
                    validProducts.Add(productRepository.GetProductById(productId));
                    dgvProduct.DataSource = validProducts;
                    dgvProduct.ClearSelection();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("ID must be a number!");
                    this.ActiveControl = txtSearch;
                }
            }
            else
            {
                List<ProductObject> products = productRepository.GetProducts();
                List<ProductObject> validProducts = new List<ProductObject>();
                foreach (ProductObject product in products)
                {
                    if (product.ProductName.Contains(txtSearch.Text))
                    {
                        validProducts.Add(product);
                    }
                }
                dgvProduct.DataSource = validProducts;
                dgvProduct.ClearSelection();

            }
            btnLoad.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateProduct frmCreateProduct = new frmCreateProduct();
            frmCreateProduct.ShowDialog();
            frmProduct_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int index = dgvProduct.SelectedRows[0].Index;
                int productId = Convert.ToInt32(dgvProduct.Rows[index].Cells["ProductId"].Value);
                IProductRepository productRepository = new ProductRepository();
                ProductObject updatedProduct = productRepository.GetProductById(productId);
                frmUpdateProduct frmUpdateProduct = new frmUpdateProduct(updatedProduct);
                frmUpdateProduct.ShowDialog();
                frmProduct_Load(sender, e);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmProduct_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                this.btnUpdate.Enabled = true;

            }
        }
    }
}
