using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyRealityLimitedApp
{
    /// <summary>
    /// Class to store the Realtor object
    /// </summary>
    class Realtor
    {
        public int RealtorId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public decimal CommissionEarned { get; set; }
        public decimal CompanyEarnings { get; set; }

        public Realtor(String fName, String lName, String uName, String pass, decimal commission, decimal company)
        {
            FirstName = fName;
            LastName = lName;
            Username = uName;
            Password = pass;
            CommissionEarned = commission;
            CompanyEarnings = company;
        }
        public Realtor() { }

        public override string ToString()
        {
            return ($"{FirstName}, {LastName}, {Username.Trim()}, {Password}, {CommissionEarned.ToString("c2")}, {CompanyEarnings.ToString("c2")}");
        }
    }
}
