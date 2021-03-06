using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ITrade; integrated security=true");
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products",connection);
            SqlDataReader reader=command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id=Convert.ToInt32(reader["Id"]) ,
                    StockAmount=Convert.ToInt32(reader["StockAmount"]) ,
                    UnitPrice=Convert.ToDecimal(reader["StockAmount"]) ,
                    Name = reader["Name"].ToString(),


                };
                products.Add(product);
            }
            reader.Close();
            connection.Close();
            return products;
        }
        public DataTable GetAll2()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ITrade; integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    }
}
