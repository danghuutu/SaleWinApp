using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetailObject> GetOrderDetails()
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            return orderDetailDAO.GetOrderDetails();
        }
        public List<OrderDetailObject> GetOrderDetailByOrderId(int orderId)
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            return orderDetailDAO.GetOrderDetailByOrderId(orderId);
        }
        public OrderDetailObject GetOrderDetailByOrderIdAndProductId(int orderId, int productId)
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            return orderDetailDAO.GetOrderDetailByOrderIdAndProductId(orderId, productId);
        }
        public void InsertNewOrderDetail(OrderDetailObject orderDetail)
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            orderDetailDAO.InsertNewOrderDetail(orderDetail);

        }
        public void UpdateOrderDetail(OrderDetailObject orderDetail)
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            orderDetailDAO.UpdateOrderDetail(orderDetail);
        }
        public void DeleteOrderDetail(int orderId, int productId)
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            orderDetailDAO.DeleteOrderDetail(orderId, productId);

        }
        public void DeleteOrderDetails(int orderId)
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            orderDetailDAO.DeleteOrderDetails(orderId);

        }

    }
}
