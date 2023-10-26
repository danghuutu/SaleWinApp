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
    public class ProductDAO
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
        public List<ProductObject> GetAllProducts()
        {
            List<ProductObject> products = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ProductId, ProductName, CategoryId, [Weight], UnitPrice, UnitsInStock " +
                "FROM Product";
            command.Connection = connection;
            connection.Open();

            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                ProductObject product = new ProductObject(
                    Convert.ToInt32(
                        dbDataReader["ProductId"].ToString()),
                        dbDataReader["ProductName"].ToString(),
                    Convert.ToInt32(
                        dbDataReader["CategoryId"]),
                        dbDataReader["Weight"].ToString(),
                   SqlMoney.Parse(
                       dbDataReader["UnitPrice"].ToString()),
                   Convert.ToInt32(
                       dbDataReader["UnitsInStock"].ToString()));
                if (products == null)
                {
                    products = new List<ProductObject>();
                }
                products.Add(product);
            }
            connection.Close();
            return products;
        }
        public ProductObject GetProductById(int id)
        {
            ProductObject product = null;
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ProductId, ProductName, CategoryId, [Weight], UnitPrice, UnitsInStock " +
                "FROM Product " +
                "WHERE ProductId = @productId";
            command.Parameters.AddWithValue("@productId", id);
            command.Connection = connection;
            connection.Open();
            DbDataReader dbDataReader = command.ExecuteReader();
            while (dbDataReader.Read())
            {
                product = new ProductObject(
                   Convert.ToInt32(
                       dbDataReader["ProductId"].ToString()),
                       dbDataReader["ProductName"].ToString(),
                   Convert.ToInt32(
                       dbDataReader["CategoryId"]),
                       dbDataReader["Weight"].ToString(),
                   SqlMoney.Parse(
                       dbDataReader["UnitPrice"].ToString()),
                   Convert.ToInt32(
                       dbDataReader["UnitsInStock"].ToString()));

            }
            connection.Close();
            return product;

        }
        public void DeleteProduct(int id)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Product WHERE ProductId = @productId";
            command.Parameters.AddWithValue("@productId", id);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void UpdateProduct(ProductObject product)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Product " +
                "SET ProductName = @productName , CategoryId = @categoryId, [Weight] = @weight, " +
                "UnitPrice = @unitPrice, UnitsInStock = @unitsInStock WHERE ProductId = @productId";
            command.Parameters.AddWithValue("@productName", product.ProductName);
            command.Parameters.AddWithValue("@categoryId", product.CategoryId);
            command.Parameters.AddWithValue("@weight", product.Weight);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
            command.Parameters.AddWithValue("@productId", product.ProductId);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void InsertNewProduct(ProductObject product)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Product(ProductName, CategoryId, [Weight], UnitPrice, UnitsInStock ) " +
                "VALUES(@productName, @categoryId, @weight, @unitPrice, @unitsInStock)";
            command.Parameters.AddWithValue("@productName", product.ProductName);
            command.Parameters.AddWithValue("@categoryId", product.CategoryId);
            command.Parameters.AddWithValue("@weight", product.Weight);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
