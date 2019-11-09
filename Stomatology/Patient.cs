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
        public PatientInsurancePolicy Policy { get; set; }

        internal Address Address1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal PatientPassport PatientPassport
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal PatientInsurancePolicy PatientInsurancePolicy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

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
