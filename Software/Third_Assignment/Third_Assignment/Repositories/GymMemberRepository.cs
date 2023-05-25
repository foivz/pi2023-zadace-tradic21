using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using Third_Assignment.Models;

namespace Third_Assignment.Repositories
{
    public class GymMemberRepository
    {
        public static GymMember GetGymMember(int id)
        {
            GymMember gymMember = null;
            string sql = $"SELECT * FROM GymMembers WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                gymMember = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return gymMember;
        }

        public static List<GymMember> GetGymMembers()
        {
            List<GymMember> gymMembers = new List<GymMember>();
            string sql = "SELECT * FROM GymMembers";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                GymMember gymMember = CreateObject(reader);
                gymMembers.Add(gymMember);
            }
            reader.Close();
            DB.CloseConnection();
            return gymMembers;
        }

        private static GymMember CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string surname = reader["Surname"].ToString();
            int phone = int.Parse(reader["Phone"].ToString());
            string email = reader["Email"].ToString();
            string adress = reader["Adress"].ToString();
            string membershipStatus = reader["MembershipStatus"].ToString();

            var gymMember = new GymMember
            {
                Id = id,
                Name = name,
                Surname = surname,
                Phone = phone,
                Email = email,
                Adress = adress,
                MembershipStatus = membershipStatus
            };
            return gymMember;


        }

        public static void AddGymMember(GymMember gymMember)
        {
            string sql = $"INSERT INTO GymMembers (Id, Name, Surname, Phone, Email, Adress, MembershipStatus) " 
                + $"VALUES ('{gymMember.Id}','{gymMember.Name}', '{gymMember.Surname}', '{gymMember.Phone}', " 
                + $"'{gymMember.Email}', '{gymMember.Adress}', '{gymMember.MembershipStatus}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        
        public static void ShowGymMembers(DataGridView dataGridView)
        {
            List<GymMember> gymMembers = GetGymMembers();
            dataGridView.DataSource = gymMembers;
        }

        public static void DeleteGymMember(int id)
        {
            if (GetGymMember(id) != null)
            {
                string sql = $"DELETE FROM GymMembers WHERE Id = {id}";

                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            }
            else
            {
                throw new Exception("Član teretane s unesenim ID-om ne postoji.");
            }
            
        }


        public static void UpdateGymMember(GymMember gymMember)
        {
            string sql = $"UPDATE GymMembers SET " +
                         $"Name = '{gymMember.Name}', " +
                         $"Surname = '{gymMember.Surname}', " +
                         $"Phone = {gymMember.Phone}, " +
                         $"Email = '{gymMember.Email}', " +
                         $"Adress = '{gymMember.Adress}', " +
                         $"MembershipStatus = '{gymMember.MembershipStatus}' " +
                         $"WHERE Id = {gymMember.Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }



    }
}
