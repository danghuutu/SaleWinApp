using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<OrderObject> GetOrders()
        {
            OrderDAO orderDAO = new OrderDAO();
            return orderDAO.GetOrders();
        }
        public List<OrderObject> GetOrdersByMemberId(int memberId)
        {
            OrderDAO orderDAO = new OrderDAO();
            return orderDAO.GetOrdersByMemberId(memberId);

        }
        public OrderObject GetOrderById(int orderId)
        {
            OrderDAO orderDAO = new OrderDAO();
            return orderDAO.GetOrderById(orderId);

        }
        public void DeleteOrder(int orderId)
        {
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.DeleteOrder(orderId);
        }
        public void InsertNewOrder(OrderObject order)
        {
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.InsertNewOrder(order);

        }
        public void UpdateOrder(OrderObject order)
        {
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.UpdateOrder(order);

        }
    }
}
