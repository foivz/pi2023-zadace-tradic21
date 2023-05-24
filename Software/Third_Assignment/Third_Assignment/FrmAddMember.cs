using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third_Assignment
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbMembershipStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string surname = txtSurname.Text;

            string gender = "";

            bool isChecked = rdoMale.Checked;

            if(isChecked)
            {
                gender = rdoMale.Text;
            }
            else
            {
                gender = rdoFemale.Text;
            }

            string birthDate = dtpBirthDate.Text;
            Int64 phone = Int64.Parse(txtPhone.Text);
            string email = txtEmail.Text;
            string joinDate = dtpJoinDate.Text;
            string adress = txtAdress.Text;
            string membershipStatus = cmbMembershipStatus.Text;


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
