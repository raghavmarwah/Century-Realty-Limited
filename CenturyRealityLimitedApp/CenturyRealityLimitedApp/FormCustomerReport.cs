using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenturyRealityLimitedApp
{
    public partial class FormCustomerReport : Form
    {

        Property currentProperty;
        Realtor currentRealtor;
        DateTime sellTime;

        public FormCustomerReport(int realtorId, int listingId, DateTime time)
        {
            InitializeComponent();

            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            currentProperty = access.GetProperty(listingId);
            currentRealtor = access.GetRealtor(realtorId);
            access.CloseConnection();

            sellTime = time;
        }
        private void GenerateCustomerReport()
        {
            decimal agentCommission = 0;
            decimal tax = 0;
            decimal totalWithGST = 0;
            customerReport.ReadOnly = true;

            String saleReport = $"Century Reality Limited\nDate:\t{sellTime}\n\n" +
                                $"Realtor Name:\t{currentRealtor.FirstName} {currentRealtor.LastName}\n" +
                                $"Bill To:\t\t{currentProperty.SellerName}\n\n" +
                                $"Street Address:\t{currentProperty.StreetAddress}\n" +
                                $"City:\t\t\t{currentProperty.City}\nProvince: \t\t{currentProperty.Province}\n" +
                                $"Pincode:\t\t{currentProperty.Pincode}\n\n";

            if (currentProperty.ListPrice <= 100000)
            {
                agentCommission = 0.08m * currentProperty.ListPrice;
            }
            else
            {
                agentCommission = (decimal)(((double)currentProperty.ListPrice - 100000) * 0.03 + 100000 * 0.08);
            }
            tax = 0.05m * agentCommission;
            totalWithGST = agentCommission + tax;
            saleReport += $"Evaluated property cost:\t{currentProperty.ListPrice.ToString("c2")}\n" +
                          $"Total commission:\t\t\t{agentCommission.ToString("c2")}\n" +
                          $"GST (5%):\t\t\t\t{tax.ToString("c2")}\n\n" +
                          $"Total Payable:\t\t\t{totalWithGST.ToString("c2")}";

            customerReport.Text = saleReport;
        }

        private void FormCustomerReport_Load(object sender, EventArgs e)
        {
            GenerateCustomerReport();
        }
    }
}
