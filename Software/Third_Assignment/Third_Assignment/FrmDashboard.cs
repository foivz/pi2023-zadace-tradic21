using Third_Assignment.Models;
using Third_Assignment.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Third_Assignment
{
    public partial class FrmDashboard : Form
    {
        

        public FrmDashboard()
        {
            InitializeComponent();
        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
            ShowGymMembersInDataGridView();
        }

        public void ShowGymMembersInDataGridView()
        {
            GymMemberRepository.ShowGymMembers(dgvGymMembers);
        }

        private void dgvGymMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEnterId.Text))
            {
                int memberId;
                // Pokušajte pretvoriti uneseni tekst u identifikacijski broj
                if (int.TryParse(txtEnterId.Text, out memberId))
                {
                    // Dohvati samo jednog člana teretane na temelju identifikacijskog broja
                    GymMember gymMember = GymMemberRepository.GetGymMember(memberId);

                    // Provjerite je li pronađen član teretane s tim identifikacijskim brojem
                    if (gymMember != null)
                    {
                        // Kreirajte novu listu s samo jednim članom teretane
                        List<GymMember> singleMemberList = new List<GymMember> { gymMember };

                        // Postavite izvor podataka za DataGridView na novu listu s jednim članom teretane
                        dgvGymMembers.DataSource = singleMemberList;
                    }
                    else
                    {
                        // Član teretane nije pronađen s unesenim identifikacijskim brojem
                        MessageBox.Show("Član teretane s tim identifikacijskim brojem nije pronađen.");
                    }
                }
                else
                {
                    // Neispravan format identifikacijskog broja
                    MessageBox.Show("Uneseni identifikacijski broj nije valjan.");
                }
            }
            else
            {
                // Tekstualno polje za pretraživanje je prazno
                MessageBox.Show("Unesite identifikacijski broj za pretraživanje.");
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmAddGymMember frmAddGymMember = new FrmAddGymMember();
            frmAddGymMember.Show();

        }
    }
}
