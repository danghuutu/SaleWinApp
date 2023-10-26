using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetailObject
    {
        public OrderDetailObject()
        {
        }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public SqlMoney UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        public OrderDetailObject(int orderId, int productId, SqlMoney unitPrice, int quantity, float discount)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }

        
    }
}
