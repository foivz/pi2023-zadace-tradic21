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

        /// <summary>
        /// Metoda "Dashboard_Load" je metoda koja se poziva prilikom učitavanja FrmDashboard forme i koristi metodu "ShowGymMembersInDataGridView" kako bi prikazala članove teretane u DataGridView kontrolu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Dashboard_Load(object sender, EventArgs e)
        {
            ShowGymMembersInDataGridView();
        }

        /// <summary>
        /// Metoda "ShowGymMembersInDataGridView" koristi metodu "ShowGymMembers" iz GymMemberRepository klase kako bi prikazala članove teretane u DataGridView kontrolu "dgvGymMembers".
        /// </summary>
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

        /// <summary>
        /// Metoda "btnSearch_Click_1" je metoda koja se poziva prilikom klika na gumb "Pretraži" i provjerava uneseni identifikacijski broj člana teretane, nakon čega dohvaća podatke o članu ako postoji te ih prikazuje u DataGridView kontrolu "dgvGymMembers", u suprotnom prikazuje odgovarajuću poruku o rezultatu pretrage ili o neispravnom unosu identifikacijskog broja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEnterId.Text))
            {
                int memberId;
            
                if (int.TryParse(txtEnterId.Text, out memberId))
                {
                    GymMember gymMember = GymMemberRepository.GetGymMember(memberId);

                    if (gymMember != null)
                    {
                        List<GymMember> singleMemberList = new List<GymMember> { gymMember };

                        dgvGymMembers.DataSource = singleMemberList;
                    }
                    else
                    {
                        MessageBox.Show("Član teretane s tim identifikacijskim brojem nije pronađen.");
                    }
                }
                else
                {
                    MessageBox.Show("Uneseni identifikacijski broj nije valjan.");
                }
            }
            else
            {
                MessageBox.Show("Unesite identifikacijski broj za pretraživanje.");
            }
        }


        /// <summary>
        /// Metoda "btnAddMember_Click" je metoda koja se poziva prilikom klika na gumb "Dodaj člana" i otvara FrmAddGymMember formu za dodavanje novog člana teretane.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmAddGymMember frmAddGymMember = new FrmAddGymMember();
            frmAddGymMember.Show();

        }

        /// <summary>
        /// Metoda "btnDeleteMember_Click" je događajna metoda koja se poziva prilikom klika na gumb "Izbriši člana" i provjerava uneseni identifikacijski broj člana teretane, nakon čega pokušava izbrisati člana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEnterId.Text))
            {
                int memberId;

                if (int.TryParse(txtEnterId.Text, out memberId))
                {
                    try
                    {
                        GymMemberRepository.DeleteGymMember(memberId);

                        ShowGymMembersInDataGridView();

                        MessageBox.Show("Član teretane uspješno izbrisan.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Uneseni identifikacijski broj nije valjan.");
                }
            }
            else
            {
                MessageBox.Show("Unesite identifikacijski broj člana za brisanje.");
            }
        }

        /// <summary>
        /// Metoda "btnUpdateMember_Click" je metoda koja se poziva prilikom klika na gumb "Ažuriraj člana" i provjerava uneseni identifikacijski broj člana teretane, nakon čega dohvaća podatke o članu ako postoji te otvara FrmUpdateGymMember formu za ažuriranje podataka tog člana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEnterId.Text))
            {
                int memberId;
              
                if (int.TryParse(txtEnterId.Text, out memberId))
                {
                    GymMember gymMember = GymMemberRepository.GetGymMember(memberId);

                    if (gymMember != null)
                    {
                        FrmUpdateGymMember frmUpdateGymMember = new FrmUpdateGymMember(memberId);
                        frmUpdateGymMember.Show();
                    }
                    else
                    {
                        MessageBox.Show("Član teretane s tim identifikacijskim brojem nije pronađen.");
                    }
                }
                else
                {
                    MessageBox.Show("Uneseni identifikacijski broj nije valjan.");
                }
            }
            else
            {
                MessageBox.Show("Unesite identifikacijski broj za pretraživanje.");
            }
        }

        /// <summary>
        /// Metoda "btnReload_Click" je metoda koja se poziva prilikom klika na gumb "Osvježi" i dohvaća sve članove teretane.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            List<GymMember> gymMembers = GymMemberRepository.GetGymMembers();
            dgvGymMembers.DataSource = gymMembers;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
