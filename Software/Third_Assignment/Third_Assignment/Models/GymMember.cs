using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Assignment.Models
{
    public class GymMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public Int64 Phone { get; set; }
        public string Email { get; set; }
        public string JoinDate { get; set; }
        public string Address { get; set; }
        public string MembershipStatus { get; set; }

    }
}
