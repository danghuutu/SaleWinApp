using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetailObject> GetOrderDetails();
        public List<OrderDetailObject> GetOrderDetailByOrderId(int orderId);
        public OrderDetailObject GetOrderDetailByOrderIdAndProductId(int orderId, int productId);
        public void InsertNewOrderDetail(OrderDetailObject orderDetail);
        public void UpdateOrderDetail(OrderDetailObject orderDetail);
        public void DeleteOrderDetail(int orderId, int productId);
        public void DeleteOrderDetails(int orderId);
    }
}
