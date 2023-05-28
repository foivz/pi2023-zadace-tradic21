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

        /// <summary>
        /// Metoda "FrmUpdateGymMember_Load" je metoda koja se poziva prilikom učitavanja FrmUpdateGymMember forme i dohvaća podatke o određenom članu teretane koristeći.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Metoda "btnSave_Click" je metoda koja se poziva prilikom klika na gumb "Spremi" i dohvaća unesene podatke o članu teretane, stvara ažurirani objekt GymMember s tim podacima.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
