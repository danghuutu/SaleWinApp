using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public List<OrderObject> GetOrders();
        public List<OrderObject> GetOrdersByMemberId(int memberId);
        public OrderObject GetOrderById(int orderId);
        public void DeleteOrder(int orderId);
        public void InsertNewOrder(OrderObject order);
        public void UpdateOrder(OrderObject order);
    }
}
