using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Assignment.Models
{/// <summary>
/// Kod definira javnu klasu "GymMember" s atributima za ID, ime, prezime, broj telefona, e-mail, adresa i status članstva.
/// </summary>
    public class GymMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string MembershipStatus { get; set; }

    }
}
