using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_amonic.MainCSFiles
{
    public class User
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OfficeID { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Active { get; set; }
        public string age { get; set; }
        public string Office { get; set; }
        public String Role { get; set; }

    }
}
