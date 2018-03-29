using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyRealityLimitedApp
{
    class DatabaseAccess
    {
        private SqlConnection dbConnection = null;

        /// <summary>
        /// Open a connection to the CenturyRealityDatabase.
        /// Uses a private SqlConnection object.
        /// </summary>
        public void OpenConnection()
        {
            dbConnection = new SqlConnection()
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CenturyRealityDatabase;" +
                "Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;" +
                "Connect Timeout=60;Encrypt=False;TrustServerCertificate=True"
            };
            dbConnection.Open();
        }

        /// <summary>
        /// Close the SqlConnection
        /// </summary>
        public void CloseConnection()
        {
            dbConnection.Close();
        }

        /// <summary>
        /// Inserts a new realtor profile to the database
        /// </summary>
        /// <param name="r">Realtor Object</param>
        public void InsertRealtor(Realtor r)
        {
            string sql = "Insert Into Realtors (FirstName, LastName, UserName, Password, CommissionEarned, CompanyEarnings) Values" +
                $"('{r.FirstName}', '{r.LastName}', '{r.Username}', '{r.Password}', '{r.CommissionEarned}', '{r.CompanyEarnings}')";

            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }catch(SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Truncate a table, but this does not reseed identity
        /// </summary>
        /// <param name="table"></param>

        public void TruncateData(string table)
        {
            string sql = "TRUNCATE TABLE " + table;

            // Execute using our connection.
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Using SQL Select, return a List of all realtors in the database
        /// </summary>
        /// <returns>List of realtors</returns>
        public List<Realtor> GetRealtors()
        {
            List<Realtor> realtorsList = new List<Realtor>();
            string sql = "Select * From Realtors";
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    realtorsList.Add(new Realtor
                    {
                        FirstName = (String)dataReader["FirstName"],
                        LastName = (String)dataReader["LastName"],
                        Username = (String)dataReader["UserName"],
                        Password = (String)dataReader["Password"],
                        CommissionEarned = (decimal)dataReader["CommissionEarned"],
                        CompanyEarnings = (decimal)dataReader["CompanyEarnings"],
                    });
                }
                dataReader.Close();
            }
            return realtorsList;
        }
    }
}
