﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Doctor : Person
    {
        public string Post { get; set; }
        public int RoomNumber { get; set; }

        public Doctor(string lastName, string firstName, string middleName, string post, int roomNumber) : 
           base(lastName, firstName, middleName)
        {
            this.Post = post;
            this.RoomNumber = roomNumber;
        }
    }
}
