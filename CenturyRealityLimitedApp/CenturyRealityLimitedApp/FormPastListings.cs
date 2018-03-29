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
    public partial class FormPastListings : Form
    {
        List<Property> listingsList;

        public FormPastListings()
        {
            InitializeComponent();
            comboBoxMonth.SelectedIndexChanged += ComboBoxMonth_SelectedIndexChanged;
        }

        private void ComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            FeedDataToDataGridView();
        }

        /// <summary>
        /// This method initializes the dataGridViewPastListings
        /// </summary>
        private void InitializeDataGridView()
        {
            //setting attributes
            dataGridViewPastListings.ReadOnly = true;
            dataGridViewPastListings.AllowUserToAddRows = false;
            dataGridViewPastListings.AllowUserToDeleteRows = false;
            dataGridViewPastListings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPastListings.RowHeadersWidth = 40;
            dataGridViewPastListings.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPastListings.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

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
                new DataGridViewTextBoxColumn() { Name = "Sell Date" },
                };

            dataGridViewPastListings.Columns.Clear();
            dataGridViewPastListings.Columns.AddRange(columns);

        }

        /// <summary>
        /// Adds the data to dataGridViewActiveListings from listingsList
        /// </summary>
        private void FeedDataToDataGridView()
        {
            List<Property> sortedDataList = null;

            if (comboBoxMonth.SelectedIndex == 0)
            {
                sortedDataList = listingsList
                .Where(p => p.IsAvailable == false)
                .OrderBy(p => p.SellDate)
                .Select(p => p)
                .ToList<Property>();
            }
            else
            {
                sortedDataList = listingsList
                    .Where(p => p.IsAvailable == false)
                    .Where(p => p.SellDate.Month == comboBoxMonth.SelectedIndex)
                    .OrderBy(p => p.SellDate)
                    .Select(p => p)
                    .ToList<Property>();
            }

            dataGridViewPastListings.Rows.Clear();
            foreach (Property p in sortedDataList)
            {
                dataGridViewPastListings.Rows.Add(p.StreetAddress, p.City, p.Pincode, p.HouseType, p.NumberOfBedrooms, p.NumberOfBathrooms, p.FloorArea, p.ListPrice, p.SellDate);
            }

            labelListingsSold.Text = sortedDataList.Count().ToString();
            labelCompanyRevenue.Text = (sortedDataList.Count() * 300).ToString("c2");
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

        private void FormPastListings_Load(object sender, EventArgs e)
        {
            UpdateListings();
            InitializeDataGridView();
            comboBoxMonth.SelectedIndex = 0;
            FeedDataToDataGridView();
        }
    }
}
