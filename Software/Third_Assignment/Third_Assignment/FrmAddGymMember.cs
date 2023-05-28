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
    public partial class FrmAddGymMember : Form
    {
        public FrmAddGymMember()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda "btnSave_Click" je metoda koja se poziva prilikom klika na gumb "Spremi", stvara novi objekt "GymMember" na temelju unesenih podataka iz tekstualnih polja i dodaje novog člana teretane.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            GymMember newMember = new GymMember
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = int.Parse(txtPhone.Text),
                Email = txtEmail.Text,
                Adress = txtAdress.Text,
                MembershipStatus = txtMembershipStatus.Text
            };

            
            GymMemberRepository.AddGymMember(newMember);

           
            MessageBox.Show("Član teretane uspješno dodan.");

           
            FrmDashboard dashboard = Application.OpenForms.OfType<FrmDashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.ShowGymMembersInDataGridView();
            }

           
            this.Close();
        }

        private void FrmAddGymMember_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metoda "btnReset_Click" je metoda koja se poziva prilikom klika na gumb "Resetiraj" i služi za brisanje unesenih vrijednosti iz tekstualnih polja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAdress.Clear();
            txtMembershipStatus.Clear();
        }
    }
}
