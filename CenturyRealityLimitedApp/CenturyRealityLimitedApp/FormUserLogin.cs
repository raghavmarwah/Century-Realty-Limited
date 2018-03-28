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
        public FormUserLogin()
        {
            InitializeComponent();
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
    }
}
