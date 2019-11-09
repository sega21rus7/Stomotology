using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Patient : Person
    {
        public DateTime Birthday { get; set; }
        public Address Address { get;set; }
        public PatientPassport Passport { get; set; }

        public Patient(string lastName, string firstName, string middleName, 
            DateTime birthday, Address address, PatientPassport passport) : 
           base(lastName, firstName, middleName)
        {
            this.Birthday = birthday;
            this.Address = address;
            this.Passport = passport;
        }
    }
}
