using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class ServiceType : IPrimaryKey
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ServiceType(string name)
        {
            this.Name = name;
        }
    }
}
