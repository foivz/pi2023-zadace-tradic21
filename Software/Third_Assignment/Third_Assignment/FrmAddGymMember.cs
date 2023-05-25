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

            // Poziv metode za dodavanje novog člana teretane
            GymMemberRepository.AddGymMember(newMember);

            // Obavijest o uspješnom unosu
            MessageBox.Show("Član teretane uspješno dodan.");

            // Ponovno učitavanje popisa članova teretane u FrmDashboard
            FrmDashboard dashboard = Application.OpenForms.OfType<FrmDashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.ShowGymMembersInDataGridView();
            }

            // Zatvaranje trenutne forme
            this.Close();
        }
    }
}
