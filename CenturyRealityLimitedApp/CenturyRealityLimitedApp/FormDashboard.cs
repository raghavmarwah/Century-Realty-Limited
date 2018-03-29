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

        public FormDashboard()
        {
            InitializeComponent();
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
        /// Adds the data to dataGridViewActiveListins from listingsList
        /// </summary>
        private void FeedDataToDataGridView()
        {
            var dataOrderQuery = listingsList
                .OrderBy(p => p.FloorArea)
                .Select(p => p);

            foreach(Property p in dataOrderQuery)
            {
                dataGridViewActiveListings.Rows.Add(p.StreetAddress, p.City, p.Pincode, p.HouseType, p.NumberOfBedrooms, p.NumberOfBathrooms, p.FloorArea, p.ListPrice);
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
    }
}
