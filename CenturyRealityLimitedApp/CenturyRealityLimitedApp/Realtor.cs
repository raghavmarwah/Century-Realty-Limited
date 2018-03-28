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
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public Realtor(String fName, String lName, String uName, String pass)
        {
            FirstName = fName;
            LastName = lName;
            Username = uName;
            Password = pass;
        }
    }
}
