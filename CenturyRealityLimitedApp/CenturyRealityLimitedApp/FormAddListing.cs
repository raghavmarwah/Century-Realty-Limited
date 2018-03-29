using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenturyRealityLimitedApp
{
    public partial class FormAddListing : Form
    {
        public FormAddListing()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new listing and adds it to the Listings table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddListing_Click(object sender, EventArgs e)
        {
            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();

            try
            {
                access.InsertListing(new Property
                {
                    StreetAddress = textBoxStreetAddress.Text,
                    City = textBoxCity.Text,
                    Pincode = textBoxPincode.Text,
                    Province = textBoxProvince.Text,
                    HouseType = listBoxHouseType.GetItemText(listBoxHouseType.SelectedItem),
                    NumberOfBedrooms = int.Parse(textBoxBedrooms.Text),
                    NumberOfBathrooms = int.Parse(textBoxBathrooms.Text),
                    FloorArea = decimal.Parse(textBoxFloorArea.Text),
                    SellerName = textBoxSellerName.Text,
                    ListPrice = decimal.Parse(textBoxListPrice.Text),
                    IsAvailable = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the entered details!");
            }

            access.CloseConnection();
            MessageBox.Show("Listing added successfully!");
            this.Close();
        }
    }
}
