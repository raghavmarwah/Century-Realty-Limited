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
    public partial class FormViewAgents : Form
    {
        public FormViewAgents()
        {
            InitializeComponent();
        }

        private void FormViewAgents_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            FeedDataToDataGridView();
        }

        /// <summary>
        /// This method initializes the dataGridViewAgents
        /// </summary>
        private void InitializeDataGridView()
        {
            //setting attributes
            dataGridViewAgents.ReadOnly = true;
            dataGridViewAgents.AllowUserToAddRows = false;
            dataGridViewAgents.AllowUserToDeleteRows = false;
            dataGridViewAgents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAgents.RowHeadersWidth = 40;
            dataGridViewAgents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewAgents.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Defining columns to add to the DataGridView
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() {Name = "First Name" },
                new DataGridViewTextBoxColumn() { Name = "Last Name" },
                new DataGridViewTextBoxColumn() { Name = "Commission Earned" },
                new DataGridViewTextBoxColumn() { Name = "Company Revenue Generated" },
                };

            dataGridViewAgents.Columns.Clear();
            dataGridViewAgents.Columns.AddRange(columns);

        }

        /// <summary>
        /// Adds the data to dataGridViewAgents
        /// </summary>
        private void FeedDataToDataGridView()
        {
            List<Realtor> tempList;
            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            tempList = access.GetRealtors();
            access.CloseConnection();

            var dataQuery = tempList
                .OrderBy(r => r.CommissionEarned)
                .Select(r => r);

            dataGridViewAgents.Rows.Clear();
            foreach (Realtor r in dataQuery)
            {
                dataGridViewAgents.Rows.Add(r.FirstName, r.LastName, r.CommissionEarned, r.CompanyEarnings);
            }
        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            FeedDataToDataGridView();
        }
    }
}
