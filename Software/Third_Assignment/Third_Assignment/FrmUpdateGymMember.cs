using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Third_Assignment.Models;
using Third_Assignment.Repositories;

namespace Third_Assignment
{
    public partial class FrmUpdateGymMember : Form
    {
        private int memberId;
        public FrmUpdateGymMember(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void FrmUpdateGymMember_Load(object sender, EventArgs e)
        {
            GymMember gymMember = GymMemberRepository.GetGymMember(memberId);
            txtName.Text = gymMember.Name;
            txtSurname.Text = gymMember.Surname;
            txtPhone.Text = gymMember.Phone.ToString();
            txtEmail.Text = gymMember.Email;
            txtAdress.Text = gymMember.Adress;
            txtMembershipStatus.Text = gymMember.MembershipStatus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int phone = int.Parse(txtPhone.Text);
            string email = txtEmail.Text;
            string address = txtAdress.Text;
            string membershipStatus = txtMembershipStatus.Text;

            GymMember updatedGymMember = new GymMember
            {
                Id = memberId, 
                Name = name,
                Surname = surname,
                Phone = phone,
                Email = email,
                Adress = address,
                MembershipStatus = membershipStatus
            };

            GymMemberRepository.UpdateGymMember(updatedGymMember);

            MessageBox.Show("Član teretane je uspješno ažuriran.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
