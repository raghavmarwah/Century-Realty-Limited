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
    public partial class FormEditProfile : Form
    {
        int realtorId;
        Realtor currentRealtor;
        public FormEditProfile(int id)
        {
            InitializeComponent();
            realtorId = id;

            DatabaseAccess access = new DatabaseAccess();
            access.OpenConnection();
            currentRealtor = access.GetRealtor(realtorId);
            access.CloseConnection();
            labelRealtorUsername.Text = currentRealtor.Username;
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseAccess access = new DatabaseAccess();
                access.OpenConnection();
                access.UpdateRealtorPassword(realtorId, textBoxNewPassword.Text);
                access.CloseConnection();
                MessageBox.Show("Password updated successfuly!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
