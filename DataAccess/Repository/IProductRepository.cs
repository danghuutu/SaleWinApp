using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public List<ProductObject> GetProducts();
        public ProductObject GetProductById(int id);
        public void DeleteProduct(int id);
        public void UpdateProduct(ProductObject product);
        public void InsertNewProduct(ProductObject product);
    }
}
