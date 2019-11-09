using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Doctor : Person
    {
        public int RoomNumber { get; set; }
        public Post Post { get; set; }

        public Doctor(string lastName, string firstName, string middleName, Post post, int roomNumber) : 
           base(lastName, firstName, middleName)
        {
            this.Post = post;
            this.RoomNumber = roomNumber;
        }
    }
}
