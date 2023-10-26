using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ProductObject
    {
        public ProductObject()
        {
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; } = 0;
        public string Weight { get; set; }
        public SqlMoney UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public ProductObject(int productId, string productName, int categoryId, string weight, SqlMoney unitPrice, int unitsInStock)
        {
            ProductId = productId;
            ProductName = productName;
            CategoryId = categoryId;
            Weight = weight;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

        
    }
}
