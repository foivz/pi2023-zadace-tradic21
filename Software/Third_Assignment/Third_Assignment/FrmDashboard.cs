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

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmAddGymMember frmAddGymMember = new FrmAddGymMember();
            frmAddGymMember.Show();

        }

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

        private void btnReload_Click(object sender, EventArgs e)
        {
            List<GymMember> gymMembers = GymMemberRepository.GetGymMembers();
            dgvGymMembers.DataSource = gymMembers;
        }
    }
}
