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
    public class OrderDAO
    {
        public string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", true, true)
                            .Build();
            string strConnection = config["ConnectionStrings:FStoreDB"];
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
        public List<OrderObject> GetOrders()
        {
            List<OrderObject> orders = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight " +
                "FROM [Order]";
            connection.Open();
            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                OrderObject order = new OrderObject(
                   Convert.ToInt32(dbDataReader["OrderId"].ToString()),
                    Convert.ToInt32(dbDataReader["MemberId"].ToString()),
                    DateTime.Parse(dbDataReader["OrderDate"].ToString().ToString()),
                    DateTime.Parse(dbDataReader["RequiredDate"].ToString()),
                    DateTime.Parse(dbDataReader["ShippedDate"].ToString()),
                    SqlMoney.Parse(dbDataReader["Freight"].ToString())
                    );
                if (orders == null)
                {
                    orders = new List<OrderObject>();
                }
                orders.Add(order);
            }


            connection.Close();
            return orders;
        }
        public List<OrderObject> GetOrdersByMemberId(int memberId)
        {
            List<OrderObject> orders = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight " +
                "FROM [Order] " +
                "WHERE MemberId = @memberId";
            command.Parameters.AddWithValue("@memberId", memberId);
            command.Connection = connection;
            connection.Open();
            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                OrderObject order = new OrderObject(
                   Convert.ToInt32(dbDataReader["OrderId"].ToString()),
                    Convert.ToInt32(dbDataReader["MemberId"].ToString()),
                    DateTime.Parse(dbDataReader["OrderDate"].ToString().ToString()),
                    DateTime.Parse(dbDataReader["RequiredDate"].ToString()),
                    DateTime.Parse(dbDataReader["ShippedDate"].ToString()),
                    SqlMoney.Parse(dbDataReader["Freight"].ToString())
                    );
                if (orders == null)
                {
                    orders = new List<OrderObject>();
                }
                orders.Add(order);
            }
            connection.Close();
            return orders;
        }
        public OrderObject GetOrderById(int orderId)
        {
            OrderObject order = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight " +
                "FROM [Order] " +
                "WHERE OrderId = @orderId";
            command.Parameters.AddWithValue("@orderId", orderId);

            command.Connection = connection;
            connection.Open();
            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                order = new OrderObject(
                   Convert.ToInt32(dbDataReader["OrderId"].ToString()),
                    Convert.ToInt32(dbDataReader["MemberId"].ToString()),
                    DateTime.Parse(dbDataReader["OrderDate"].ToString().ToString()),
                    DateTime.Parse(dbDataReader["RequiredDate"].ToString()),
                    DateTime.Parse(dbDataReader["ShippedDate"].ToString()),
                    SqlMoney.Parse(dbDataReader["Freight"].ToString())
                    );

            }
            connection.Close();
            return order;
        }
        public void DeleteOrder(int orderId)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM [Order] WHERE OrderId = @orderId";
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertNewOrder(OrderObject order)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO [Order] (MemberId, OrderDate, RequiredDate, ShippedDate, Freight) " +
                "VALUES(@memberId, @orderDate, @requiredDate, @shippedDate, @freight)";
            command.Parameters.AddWithValue("@memberId", order.MemberId);
            command.Parameters.AddWithValue("@orderDate", order.OrderDate);
            command.Parameters.AddWithValue("@requiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@shippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@freight", order.RequiredDate);

            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateOrder(OrderObject order)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [Order] SET MemberId = @memberId, " +
                "OrderDate = @orderDate, RequiredDate = @requiredDate, ShippedDate = @shippedDate, Freight = @freight " +
                "WHERE OrderId = @orderId";
            command.Parameters.AddWithValue("@memberId", order.MemberId);
            command.Parameters.AddWithValue("@orderDate", order.OrderDate);
            command.Parameters.AddWithValue("@requiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@shippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@freight", order.RequiredDate);
            command.Parameters.AddWithValue("@orderId", order.OrderId);

            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
