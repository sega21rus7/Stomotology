using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology.Models
{
    class DoctorAssistent : Person
    {
        public DoctorAssistentPost Post { get; set; }

        public DoctorAssistent(string lastName, string firstName, string middleName, DoctorAssistent post) : 
           base(lastName, firstName, middleName)
        {
        }

        
    }
}
