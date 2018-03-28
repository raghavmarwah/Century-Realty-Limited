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
    public partial class FormUserLogin : Form
    {
        //List to store realtors from the DB.
        List<Realtor> userList = null;

        public FormUserLogin()
        {
            InitializeComponent();
            FetchUserList();
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

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            //setting width and height of the form
            this.Width = 850;
            this.Height = 560;
            
            //additionl design specs
            buttonCloseForm.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatAppearance.BorderSize = 0;

            //additional startup code
            textBoxRealtorUsername.Text = "";
            textBoxRealtorPassword.Text = "";
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
            //close the application
            Application.Exit();
        }
        
        /// <summary>
        /// Hides the current form and displays FormNewRealtorSignUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewRealtorSignUp signUpForm = new FormNewRealtorSignUp();
            signUpForm.Show();
        }

        /// <summary>
        /// Resets the text inputs on the form
        /// </summary>
        private void ClearFields()
        {
            textBoxRealtorUsername.Text = "";
            textBoxRealtorPassword.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var queryLoginCheck = userList
                .Where(r => r.Username.Trim().Equals(textBoxRealtorUsername.Text) && r.Password.Trim().Equals(textBoxRealtorPassword.Text))
                .Select(r => r);

            if (queryLoginCheck.Count() > 0)
            {
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                ClearFields();
            }
                        
        }
    }
}
