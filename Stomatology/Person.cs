using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    abstract class Person
    {
        public int id;
        public int count;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Person(string lastName, string firstName, string middleName)
        {
            this.id = this.count++;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
        }
    }
}
