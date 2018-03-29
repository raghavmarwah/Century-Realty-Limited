using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyRealityLimitedApp
{
    class Property
    {
        public int ListingId { get; set; }
        public String StreetAddress { get; set; }
        public String City { get; set; }
        public String Pincode { get; set; }
        public String Province { get; set; }
        public String HouseType { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public decimal FloorArea { get; set; }
        public String SellerName {get;set;}
        public decimal ListPrice { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime SellDate { get; set; }
        public int RealtorId { get; set; }

        public Property(){}
    }
}
