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
    public partial class frmCreateProduct : Form
    {
        public frmCreateProduct()
        {
            InitializeComponent();
        }
        private void frmCreateProduct_Load(object sender, EventArgs e)
        {
            txtProductName.TabIndex = 0;
            txtCategory.TabIndex = 1;
            txtWeight.TabIndex = 2;
            txtUnitPrice.TabIndex = 3;
            txtUnitsInStock.TabIndex = 4;
        }
        private void btnCreate_Click(object sender, EventArgs e)
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
                    ProductObject product = new ProductObject();
                    IProductRepository productRepository = new ProductRepository();
                    product.UnitPrice = SqlMoney.Parse(txtUnitPrice.Text);
                    product.UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text);
                    product.CategoryId = Convert.ToInt32(txtCategory.Text);
                    product.ProductName = txtProductName.Text;
                    product.Weight = txtWeight.Text;
                    productRepository.InsertNewProduct(product);
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
