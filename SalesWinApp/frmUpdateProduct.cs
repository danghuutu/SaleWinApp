using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmUpdateProduct : Form
    {
        public ProductObject updatedProduct;
        public frmUpdateProduct(ProductObject updatedProduct)
        {
            InitializeComponent();
            this.updatedProduct = updatedProduct;
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = false;
            txtProductId.Text = updatedProduct.ProductId.ToString();
            txtProductName.Text = updatedProduct.ProductName.ToString();
            txtCategory.Text = updatedProduct.CategoryId.ToString();
            txtUnitPrice.Text = updatedProduct.UnitPrice.ToString();
            txtWeight.Text = updatedProduct.Weight.ToString();
            txtUnitsInStock.Text = updatedProduct.UnitsInStock.ToString();

            txtProductName.TabIndex = 0;
            txtCategory.TabIndex = 1;
            txtWeight.TabIndex = 2;
            txtUnitPrice.TabIndex = 3;
            txtUnitsInStock.TabIndex = 4;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtUnitPrice.Text.Length == 0 ||
                txtUnitsInStock.Text.Length == 0 ||
                txtCategory.Text.Length == 0 ||
                txtProductName.Text.Length == 0 ||
                txtWeight.Text.Length == 0)
            {
                MessageBox.Show("All field must be filled!", "Error");
            }
            else
            {
                try
                {
                    IProductRepository productRepository = new ProductRepository();
                    updatedProduct.UnitPrice = SqlMoney.Parse(txtUnitPrice.Text);
                    updatedProduct.UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text);
                    updatedProduct.CategoryId = Convert.ToInt32(txtCategory.Text);
                    updatedProduct.ProductName = txtProductName.Text;
                    updatedProduct.Weight = txtWeight.Text;
                    productRepository.UpdateProduct(updatedProduct);
                    this.Close();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Check input format again!", "Error");
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e) => this.Close();

    }
}
