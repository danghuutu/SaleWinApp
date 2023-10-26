using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
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
        public MemberObject GetMemberByEmail(string email)
        {
            MemberObject member = null;
            SqlConnection connection = GetConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT MemberId, Email, CompanyName, City, Country, Password " +
                "FROM Member WHERE Email = @email ";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Connection = connection;
            using DbDataReader dbDataReader = sqlCommand.ExecuteReader();
            while (dbDataReader.Read())
            {
                member = new MemberObject(
                    Convert.ToInt32(
                        dbDataReader["MemberId"]), 
                        dbDataReader["Email"].ToString(),
                        dbDataReader["CompanyName"].ToString(), 
                        dbDataReader["City"].ToString(), 
                        dbDataReader["Country"].ToString(), 
                        dbDataReader["Password"].ToString());
            }
            connection.Close();
            return member;
        }
        public void InsertNewMember(MemberObject member)
        {
            SqlConnection connection = GetConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO Member(Email, CompanyName, City, " +
                "Country, [Password]) VALUES(@email, @company, @city, @country, @password)";

            sqlCommand.Parameters.AddWithValue("@email", member.Email);
            sqlCommand.Parameters.AddWithValue("@company", member.CompanyName);
            sqlCommand.Parameters.AddWithValue("@city", member.City);
            sqlCommand.Parameters.AddWithValue("@country", member.Country);
            sqlCommand.Parameters.AddWithValue("@password", member.Password);

            sqlCommand.Connection = connection;
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateMember(MemberObject member)
        {
            SqlConnection connection = GetConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "Update Member " +
                "SET Email =  @email, CompanyName = @company, City = @city, " +
                "Country = @country, [Password] = @password WHERE MemberId = @MemberId";

            sqlCommand.Parameters.AddWithValue("@memberId", member.MemberId);
            sqlCommand.Parameters.AddWithValue("@email", member.Email);
            sqlCommand.Parameters.AddWithValue("@company", member.CompanyName);
            sqlCommand.Parameters.AddWithValue("@city", member.City);
            sqlCommand.Parameters.AddWithValue("@country", member.Country);
            sqlCommand.Parameters.AddWithValue("@password", member.Password);

            sqlCommand.Connection = connection;
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteMemberById(int id)
        {
            SqlConnection connection = GetConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM Member WHERE MemberId = @memberId";
            sqlCommand.Parameters.AddWithValue("@memberId", id);
            sqlCommand.Connection = connection;
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
        public List<MemberObject> GetAllMembers()
        {
            List<MemberObject> members = null;
            SqlConnection connection = GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT MemberId, Email, CompanyName, City, Country, Password " +
                "FROM Member ";
            command.Connection = connection;
            DbDataReader dbDataReader = command.ExecuteReader();

            while (dbDataReader.Read())
            {
                MemberObject member = new MemberObject(Convert.ToInt32(dbDataReader["MemberId"]), dbDataReader["Email"].ToString(),
                   dbDataReader["CompanyName"].ToString(), dbDataReader["City"].ToString(), dbDataReader["Country"].ToString(), dbDataReader["Password"].ToString());
                if (members == null)
                {
                    members = new List<MemberObject>();

                }
                members.Add(member);
            }
            connection.Close();
            return members;
        }
        public MemberObject GetMemberById(int id)
        {
            SqlConnection connection = GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT MemberId, Email, CompanyName, City, Country, Password " +
                "FROM Member WHERE MemberId = @memberId ";
            command.Parameters.AddWithValue("@memberId", id);
            command.Connection = connection;
            DbDataReader dbDataReader = command.ExecuteReader();
            MemberObject member = null;
            while (dbDataReader.Read())
            {
                member = new MemberObject(Convert.ToInt32(
                    dbDataReader["MemberId"]), 
                    dbDataReader["Email"].ToString(),
                    dbDataReader["CompanyName"].ToString(), 
                    dbDataReader["City"].ToString(), 
                    dbDataReader["Country"].ToString(), 
                    dbDataReader["Password"].ToString());

            }
            connection.Close();
            return member;
        }
    }
}
