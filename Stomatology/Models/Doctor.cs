using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Doctor : Person
    {
        public static string ClassName = "Doctor";
        public static string TableName = "Врачи";
        public DoctorPost Post { get; set; }

        public Doctor(string lastName, string firstName, string middleName, DoctorPost post) : 
           base(lastName, firstName, middleName)
        {
            this.Post = post;
        }
    }
}
