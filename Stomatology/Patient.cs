using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Patient : Person
    {
        public DateTime Birthday { get; set; }
        public string Address { get;set; }

        public Patient(string lastName, string firstName, string middleName, 
            DateTime birthday, string address) : 
           base(lastName, firstName, middleName)
        {
            this.Birthday = birthday;
            this.Address = address;
        }
    }
}
