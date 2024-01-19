using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using CustomersAJAX.Models;

namespace CustomersAJAX.Data
{
    public class customerDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;

        public List<Customer> FetchAll ()
        {
            List<Customer> returnList = new List<Customer>();

            // Access the database
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Customers";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.ID = reader.GetInt32(0);
                        customer.Name = reader.GetString(1);
                        customer.Age = reader.GetInt32(0);

                        returnList.Add(customer);
                    }
                }
            }
            return returnList;
        }
    }
}