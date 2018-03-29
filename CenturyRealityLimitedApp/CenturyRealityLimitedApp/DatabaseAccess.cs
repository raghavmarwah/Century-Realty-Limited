﻿using System;
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
        /// Inserts a new lisitng to the database
        /// </summary>
        /// <param name="p">Property Object</param>
        public void InsertListing(Property p)
        {
            string sql = "Insert Into Listings (StreetAddress, City, Pincode, Province, HouseType, Bedrooms, Bathrooms, FloorArea, SellerName, ListPrice, Available, SellDate, RealtorId) Values" +
                $"('{p.StreetAddress}', '{p.City}', '{p.Pincode}', '{p.Province}', '{p.HouseType}', '{p.NumberOfBedrooms}', '{p.NumberOfBathrooms}', '{p.FloorArea}', '{p.SellerName}', '{p.ListPrice}', '{p.IsAvailable}', '{null}', '{null}')";

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
                        RealtorId = (int)dataReader["RealtorId"],
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

        /// <summary>
        /// Using SQL Select, return a List of all listings in the database
        /// </summary>
        /// <returns>List of listings</returns>
        public List<Property> GetListings()
        {
            List<Property> listingsList = new List<Property>();
            string sql = "Select * From Listings";
            using (SqlCommand command = new SqlCommand(sql, dbConnection))
            {
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    listingsList.Add(new Property
                    {
                        ListingId = (int)dataReader["ListingId"],
                        StreetAddress = (String)dataReader["StreetAddress"],
                        City = (String)dataReader["City"],
                        Pincode = (String)dataReader["Pincode"],
                        Province = (String)dataReader["Province"],
                        HouseType = (String)dataReader["HouseType"],
                        NumberOfBedrooms = (int)dataReader["Bedrooms"],
                        NumberOfBathrooms = (int)dataReader["Bathrooms"],
                        FloorArea = (decimal)dataReader["FloorArea"],
                        SellerName = (String)dataReader["SellerName"],
                        ListPrice = (decimal)dataReader["ListPrice"],
                        IsAvailable = (bool)dataReader["Available"],
                        SellDate = (DateTime)dataReader["SellDate"],
                        RealtorId = (int)dataReader["RealtorId"],
                    });
                }
                dataReader.Close();
            }
            return listingsList;
        }

        /// <summary>
        /// return a Property object with the given ListingId.
        /// </summary>
        /// <param name="listingId"></param>
        /// <returns>Property Object</returns>
        public Property GetProperty(int listingId)
        {
            List<Property> tempList = GetListings();
            return tempList.Where(p => p.ListingId == listingId).Select(p => p).ToArray()[0];
        }

        /// <summary>
        /// return a Realtor object with the given  RealtorId.
        /// </summary>
        /// <param name="realtorId"></param>
        /// <returns>Realtor object</returns>
        public Realtor GetRealtor(int realtorId)
        {
            List<Realtor> tempList = GetRealtors();
            return tempList.Where(r => r.RealtorId == realtorId).Select(r => r).ToArray()[0];
        }

        /// <summary>
        /// Updates listing in the tabel when it's is sold.
        /// </summary>
        /// <param name="realtorId"></param>
        /// <param name="listingId"></param>
        /// <param name="sellDate"></param>
        public void SellListing(int realtorId, int listingId, DateTime sellDate)
        {
            string sql = $"UPDATE Listings SET RealtorId = '{realtorId}', SellDate = '{sellDate}', Available = 'false'" + 
                $"WHERE ListingId = {listingId}";

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
        /// Updates the earning stats for the realtor
        /// </summary>
        /// <param name="realtorId">Realtor Id</param>
        /// <param name="selfAmount">Commission Earned</param>
        /// <param name="companyAmount">CompanyEarnings</param>
        public void UpdateRealtorIncome(int realtorId, decimal selfAmount, decimal companyAmount)
        {
            string sql = $"UPDATE Realtors SET  CommissionEarned = '{selfAmount}', CompanyEarnings = '{companyAmount}' WHERE RealtorId = {realtorId}";

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
    }
}
