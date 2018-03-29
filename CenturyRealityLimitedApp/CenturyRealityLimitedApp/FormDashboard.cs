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
    public partial class FormDashboard : Form
    {
        List<Property> listingsList = null;
        int realtorId = 0;

        public FormDashboard(int id)
        {
            InitializeComponent();
            realtorId = id;
        }

        private void buttonAddListing_Click(object sender, EventArgs e)
        {
            FormAddListing addListing = new FormAddListing();
            addListing.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            UpdateListings();
            InitializeDataGridView();
            FeedDataToDataGridView();

            this.Width = 1100;
            this.Height = 600;

            buttonViewAgents.FlatAppearance.BorderSize = 0;
            buttonPastListings.FlatAppearance.BorderSize = 0;
            buttonEditProfile.FlatAppearance.BorderSize = 0;
            buttonCloseForm.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// This method initializes the dataGridViewActiveListings
        /// </summary>
        private void InitializeDataGridView()
        {
            //setting attributes
            dataGridViewActiveListings.ReadOnly = true;
            dataGridViewActiveListings.AllowUserToAddRows = false;
            dataGridViewActiveListings.AllowUserToDeleteRows = false;
            dataGridViewActiveListings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewActiveListings.RowHeadersWidth = 40;
            dataGridViewActiveListings.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewActiveListings.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Defining columns to add to the DataGridView
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() {Name = "Listing Id" },
                new DataGridViewTextBoxColumn() { Name = "Street Address" },
                new DataGridViewTextBoxColumn() { Name = "City" },
                new DataGridViewTextBoxColumn() { Name = "Pincode" },
                new DataGridViewTextBoxColumn() { Name = "House Type" },
                new DataGridViewTextBoxColumn() { Name = "Bedrooms" },
                new DataGridViewTextBoxColumn() { Name = "Bathrooms" },
                new DataGridViewTextBoxColumn() { Name = "Floor Area (sqft)" },
                new DataGridViewTextBoxColumn() { Name = "List Price" },
                };

            dataGridViewActiveListings.Columns.Clear();
            dataGridViewActiveListings.Columns.AddRange(columns);

        }
        /// <summary>
        /// Adds the data to dataGridViewActiveListings from listingsList
        /// </summary>
        private void FeedDataToDataGridView()
        {
            var dataOrderQuery = listingsList
                .Where(p => p.IsAvailable == true)
                .OrderBy(p => p.ListingId)
                .Select(p => p);

            foreach(Property p in dataOrderQuery)
            {
                dataGridViewActiveListings.Rows.Add(p.ListingId, p.StreetAddress, p.City, p.Pincode, p.HouseType, p.NumberOfBedrooms, p.NumberOfBathrooms, p.FloorArea, p.ListPrice);
            }
        }

        /// <summary>
        /// Updates the listingsList from the DB.
        /// </summary>
        private void UpdateListings()
        {
            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            listingsList = access.GetListings();
            access.CloseConnection();
        }

        /// <summary>
        /// Updates the dataGridViewActiveListigs with fresh data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateListings();
            InitializeDataGridView();
            FeedDataToDataGridView();
        }

        private void buttonSellListing_Click(object sender, EventArgs e)
        {
            int listingId = int.Parse(dataGridViewActiveListings.CurrentRow.Cells[0].Value.ToString());
            FormSellListing sellListing = new FormSellListing(realtorId, listingId);
            sellListing.Show();
        }

        private void buttonViewAgents_Click(object sender, EventArgs e)
        {
            FormViewAgents viewAgents = new FormViewAgents();
            viewAgents.Show();
        }

        private void buttonPastListings_Click(object sender, EventArgs e)
        {
            FormPastListings pastListings = new FormPastListings();
            pastListings.Show();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            FormEditProfile editProfile = new FormEditProfile(realtorId);
            editProfile.Show();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
