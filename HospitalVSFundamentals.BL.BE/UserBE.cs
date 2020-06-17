using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalVSFundamentals.BL.BE
{
    public class UserBE
    {

        public String IdUser { get; set; }

        public int User_Role { get; set; }

        public string username { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string DNI { get; set; }

        public DateTime? Birthday { get; set; }

        public string Status { get; set; }

        public string Gener { get; set; }

        public DateTime Date_create { get; set; }

        public DateTime Date_update { get; set; }


    }

    public class UserLoginBE
    {

        public String IdUser { get; set; }

        public String Role { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string DNI { get; set; }
        public string Password { get; set; }

    }


}
