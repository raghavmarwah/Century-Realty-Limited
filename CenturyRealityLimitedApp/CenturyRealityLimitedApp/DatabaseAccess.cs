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
            string sql = "Insert Into Realtors (FirstName, LastName, UserName, Password) Values" +
                $"('{r.FirstName}', '{r.LastName}', '{r.Username}', '{r.Password}')";

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
    }
}
