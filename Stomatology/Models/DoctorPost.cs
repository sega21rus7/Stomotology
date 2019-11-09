﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class DoctorPost : IPrimaryKey
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DoctorPost(string name)
        {
            this.Name = name;
        }
    }
}
