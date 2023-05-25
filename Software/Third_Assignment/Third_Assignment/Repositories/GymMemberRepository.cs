using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
