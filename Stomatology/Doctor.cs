﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Doctor : Person
    {
        public string Post { get; set; }

        public Doctor(string lastName, string firstName, string middleName, string post) : 
           base(lastName, firstName, middleName)
        {
            this.Post = post;
        }
    }
}
