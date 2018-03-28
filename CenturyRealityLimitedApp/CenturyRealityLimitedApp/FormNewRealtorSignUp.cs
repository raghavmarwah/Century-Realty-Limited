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
    public partial class FormNewRealtorSignUp : Form
    {
        //List to store realtors from the DB.
        List<Realtor> userList = null;
        //Color converter object
        ColorConverter colorConverter = new ColorConverter();

        public FormNewRealtorSignUp()
        {
            InitializeComponent();
            FetchUserList();
            textBoxRealtorUsername.TextChanged += CheckValidUsername;
        }

        private void CheckValidUsername(object sender, EventArgs e)
        {
            if (UsernameExists(textBoxRealtorUsername.Text))
            {
                
                Color colorRed = (Color)colorConverter.ConvertFromString("#fcbdbd");
                textBoxRealtorUsername.BackColor = colorRed;
                labelInfoDisplay.Visible = true;
            }
            else
            {
                Color colorGreen = (Color)colorConverter.ConvertFromString("#c0fcbd");
                textBoxRealtorUsername.BackColor = colorGreen;
                labelInfoDisplay.Visible = false;
            }
        }

        /// <summary>
        /// Checks if the username already exists in the userList
        /// </summary>
        /// <param name="username"></param>
        /// <returns>bool value</returns>
        public bool UsernameExists(String username)
        {
            bool usernameExists = false;
            
            //This needs to be fixed.
            var checkQuery = userList.Where(r => r.Username.Trim().Equals(username, StringComparison.InvariantCultureIgnoreCase)).Select(r => r);
            if (checkQuery.Count() > 0)
                usernameExists = true;

            return usernameExists;
        }

        /// <summary>
        /// Fetches the list of realtors from the DB
        /// </summary>
        public void FetchUserList()
        {
            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            userList = access.GetRealtors();
            access.CloseConnection();
        }

        private void FormNewRealtorSignUp_Load(object sender, EventArgs e)
        {
            //setting width and height of the form
            this.Width = 850;
            this.Height = 560;

            //additionl design specs
            buttonCloseForm.FlatAppearance.BorderSize = 0;
            buttonCreateAccount.FlatAppearance.BorderSize = 0;
            buttonClearForm.FlatAppearance.BorderSize = 0;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
            //re-open FormUserLogin
            FormUserLogin userLogin = new FormUserLogin();
            userLogin.Show();
        }

        /// <summary>
        /// Clears the form when user clicks buttonClearForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxRealtorUsername.Text = "";
            textBoxRealtorPassword.Text = "";
        }

        /// <summary>
        /// Creates a connection to the database and saves a new user profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            //access.TruncateData("Realtors");
            try
            {
                if (textBoxFirstName.TextLength == 0 || textBoxLastName.TextLength == 0 || textBoxRealtorUsername.TextLength == 0 || textBoxRealtorPassword.TextLength == 0)
                    throw new Exception();

                access.InsertRealtor(new Realtor(textBoxFirstName.Text, textBoxLastName.Text, textBoxRealtorUsername.Text, textBoxRealtorPassword.Text));
                MessageBox.Show("Profile created successfully!!");
                this.Close();
                FormUserLogin userLogin = new FormUserLogin();
                userLogin.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Input data is not in correct format");
            }
            access.CloseConnection();
            
        }
    }
}
