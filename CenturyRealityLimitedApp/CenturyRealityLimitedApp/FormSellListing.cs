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
    public partial class FormSellListing : Form
    {
        int realtorId = 0;
        int listingId = 0;
        Property currentProperty;
        Realtor currentRealtor;

        public FormSellListing(int rId, int lId)
        {
            InitializeComponent();
            realtorId = rId;
            listingId = lId;

            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            currentProperty = access.GetProperty(listingId);
            currentRealtor = access.GetRealtor(realtorId);
            access.CloseConnection();
        }

        private void buttonSellListing_Click(object sender, EventArgs e)
        {
            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            access.SellListing(realtorId, listingId, dateTimePicker.Value);

            decimal agentCommission = 0;
            if (currentProperty.ListPrice <= 100000)
                agentCommission = 0.08m * currentProperty.ListPrice;
            else
                agentCommission = (decimal)(((double)currentProperty.ListPrice - 100000) * 0.03 + 100000 * 0.08);

            decimal updatedCommissionEarned = currentRealtor.CommissionEarned + (agentCommission/2) - 300;
            decimal updatedCompanyEarnings = currentRealtor.CompanyEarnings + 300;

            access.UpdateRealtorIncome(realtorId, updatedCommissionEarned, updatedCompanyEarnings);
            access.CloseConnection();
            MessageBox.Show("The listing has been successfully sold!");
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            decimal agentCommission = 0;
            realtorReport.ReadOnly = true;

            String saleReport = $"Century Reality Limited\nDate:\t{dateTimePicker.Value}\n" +
                                $"Realtor Name:\t{currentRealtor.FirstName} {currentRealtor.LastName}\n" +
                                $"Buying Party:\t{textBoxBuyingParty.Text}\n\n" +
                                $"Selling Party:\t{currentProperty.SellerName}\n" +
                                $"Street Address:\t{currentProperty.StreetAddress}\n" +
                                $"City:\t\t\t{currentProperty.City}\nProvince: \t\t{currentProperty.Province}\n" +
                                $"Pincode:\t\t{currentProperty.Pincode}\n\n";
                                
            if (currentProperty.ListPrice <= 100000)
            {
                agentCommission = 0.08m * currentProperty.ListPrice;
                saleReport += $"Evaluated property cost:\t\t\t\t{currentProperty.ListPrice.ToString("c2")}\n\n" +
                              $"Agent commission (8%):\t{agentCommission.ToString("c2")}\n" +
                              $"My commission (1/2 for buyer's agent):\t\t{(agentCommission / 2).ToString("c2")}\n\n" +
                              $"Total commission (-$300 company fee):\t\t{((agentCommission / 2) - 300).ToString("c2")}";
            }
            else
            {
                agentCommission = (decimal)(((double)currentProperty.ListPrice - 100000) * 0.03 + 100000 * 0.08);
                saleReport += $"Evaluated property cost:\t\t\t\t\t{currentProperty.ListPrice.ToString("c2")}\n\n"+
                              $"Agent commission (8% upto 100k, 3% on additional):\t{agentCommission.ToString("c2")}\n"+
                              $"My commission (1/2 for buyer's agent):\t\t\t{(agentCommission / 2).ToString("c2")}\n\n" +
                              $"Total commission (-$300 company fee):\t\t\t{((agentCommission / 2) - 300).ToString("c2")}";
            }
                    
            realtorReport.Text = saleReport;
            buttonSellListing.Enabled = true;
        }
    }
}
