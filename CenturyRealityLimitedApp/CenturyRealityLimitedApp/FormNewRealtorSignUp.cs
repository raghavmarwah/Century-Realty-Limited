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
        public FormNewRealtorSignUp()
        {
            InitializeComponent();
        }

        private void FormNewRealtorSignUp_Load(object sender, EventArgs e)
        {
            //setting width and height of the form
            this.Width = 850;
            this.Height = 560;

            //additionl design specs
            buttonCloseForm.FlatAppearance.BorderSize = 0;
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
            try
            {
                access.InsertRealtor(new Realtor(textBoxFirstName.Text, textBoxLastName.Text, textBoxRealtorUsername.Text, textBoxRealtorPassword.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Input data is not in correct format");
            }
            access.CloseConnection();
            MessageBox.Show("Profile created successfully!!");
            this.Close();
            FormUserLogin userLogin = new FormUserLogin();
            userLogin.Show();
        }
    }
}
