using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        public string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", true, true)
                            .Build();
            string strConnection = config["ConnectionStrings:eStoreDB"];
            return strConnection;
        }
        public SqlConnection GetConnection()
        {
            string strConnection = GetConnectionString();
            SqlConnection connection = new SqlConnection();
            if (connection == null)
            {
                System.Diagnostics.Debug.WriteLine("connection = null");
                return null;
            }
            connection.ConnectionString = strConnection;
            return connection;
        }
        public List<OrderDetailObject> GetOrderDetails()
        {
            List<OrderDetailObject> orderDetails = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT OrderId, ProductId, UnitPrice, Quantity, Discount " +
                "FROM OrderDetail ";
            command.Connection = connection;
            connection.Open();
            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                OrderDetailObject orderDetail = new OrderDetailObject(
                    Convert.ToInt32(dbDataReader["OrderId"].ToString()),
                    Convert.ToInt32(dbDataReader["ProductId"].ToString()),
                    SqlMoney.Parse(dbDataReader["UnitPrice"].ToString()),
                    Convert.ToInt32(dbDataReader["Quantity"].ToString()),
                    float.Parse(dbDataReader["Discount"].ToString())
                    );
                if (orderDetails == null)
                {
                    orderDetails = new List<OrderDetailObject>();
                }
                orderDetails.Add(orderDetail);
            }
            connection.Close();
            return orderDetails;
        }
        public List<OrderDetailObject> GetOrderDetailByOrderId(int orderId)
        {
            List<OrderDetailObject> orderDetails = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT OrderId, ProductId, UnitPrice, Quantity, Discount " +
                "FROM OrderDetail WHERE OrderId = @orderId";
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Connection = connection;
            connection.Open();
            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                OrderDetailObject orderDetail = new OrderDetailObject(
                    Convert.ToInt32(dbDataReader["OrderId"].ToString()),
                    Convert.ToInt32(dbDataReader["ProductId"].ToString()),
                    SqlMoney.Parse(dbDataReader["UnitPrice"].ToString()),
                    Convert.ToInt32(dbDataReader["Quantity"].ToString()),
                    float.Parse(dbDataReader["Discount"].ToString())
                    );
                if (orderDetails == null)
                {
                    orderDetails = new List<OrderDetailObject>();
                }
                orderDetails.Add(orderDetail);
            }
            connection.Close();
            return orderDetails;


        }
        public OrderDetailObject GetOrderDetailByOrderIdAndProductId(int orderId, int productId)
        {
            OrderDetailObject orderDetail = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT OrderId, ProductId, UnitPrice, Quantity, Discount " +
                "FROM OrderDetail " +
                "WHERE OrderId = @orderId AND ProductId = @productId";
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Parameters.AddWithValue("@productId", productId);
            command.Connection = connection;
            connection.Open();
            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                orderDetail = new OrderDetailObject(
                    Convert.ToInt32(dbDataReader["OrderId"].ToString()),
                    Convert.ToInt32(dbDataReader["ProductId"].ToString()),
                    SqlMoney.Parse(dbDataReader["UnitPrice"].ToString()),
                    Convert.ToInt32(dbDataReader["Quantity"].ToString()),
                    float.Parse(dbDataReader["Discount"].ToString())
                    );
            }
            connection.Close();
            return orderDetail;
        }
        public void InsertNewOrderDetail(OrderDetailObject orderDetail)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO OrderDetail (OrderId, ProductId, UnitPrice, Quantity, Discount) " +
                "VALUES(@orderId, @productId, @unitPrice, @quantity, @discount )";
            command.Parameters.AddWithValue("@orderId", orderDetail.OrderId);
            command.Parameters.AddWithValue("@productId", orderDetail.ProductId);
            command.Parameters.AddWithValue("@unitPrice", orderDetail.UnitPrice);
            command.Parameters.AddWithValue("@quantity", orderDetail.Quantity);
            command.Parameters.AddWithValue("@discount", orderDetail.Discount);

            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateOrderDetail(OrderDetailObject orderDetail)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update OrderDetail SET UnitPrice = @unitPrice, Quantity = @quantity, Discount = @discount " +
                "WHERE OrderId = @orderId AND ProductId = @productId ";
            command.Parameters.AddWithValue("@orderId", orderDetail.OrderId);
            command.Parameters.AddWithValue("@productId", orderDetail.ProductId);
            command.Parameters.AddWithValue("@unitPrice", orderDetail.UnitPrice);
            command.Parameters.AddWithValue("@quantity", orderDetail.Quantity);
            command.Parameters.AddWithValue("@discount", orderDetail.Discount);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteOrderDetail(int orderId, int productId)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM OrderDetail " +
                "WHERE OrderId = @orderId AND ProductId = @productId";
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Parameters.AddWithValue("@productId", productId);

            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteOrderDetails(int orderId)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM OrderDetail " +
                "WHERE OrderId = @orderId ";
            command.Parameters.AddWithValue("@orderId", orderId);

            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
