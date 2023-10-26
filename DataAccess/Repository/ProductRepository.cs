using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<ProductObject> GetProducts()
        {
            ProductDAO productDAO = new ProductDAO();
            return productDAO.GetAllProducts();
        }
        public ProductObject GetProductById(int id)
        {
            ProductDAO productDAO = new ProductDAO();
            return productDAO.GetProductById(id);
        }
        public void DeleteProduct(int id)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.DeleteProduct(id);
        }
        public void UpdateProduct(ProductObject product)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.UpdateProduct(product);

        }
        public void InsertNewProduct(ProductObject product)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.InsertNewProduct(product);
        }
    }
}
