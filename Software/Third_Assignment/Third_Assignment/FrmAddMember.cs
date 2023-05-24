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



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=IPS23_tradic21;User ID=tradic21;Password=wLJ!1*sP;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into AddMember (Id,Name,Surname,Gender,BirthDate,Phone,Email,JoinDate,Adress,MembershipStatus) values ('" + id + "','" + name + "', '" + surname + "', '" + gender + "', '" + birthDate + "', '" + phone + "', '" + email + "', '" + joinDate + "', '" + adress + "', '" + membershipStatus + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Podaci spremljeni.");


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
