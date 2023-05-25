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

namespace Third_Assignment
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ShowGymMembers();
        }
        private void ShowGymMembers()
        {
            List<GymMember> gymMembers = GymMemberRepository.GetGymMembers();
            dgvGymMembers.DataSource = gymMembers;

        }

        private void dgvGymMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
