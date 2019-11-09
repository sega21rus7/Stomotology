using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class ServiceType : IPrimaryKey
    {
        int pk;
        int count;

        public string Name { get; set; }

        public ServiceType(string name)
        {
            this.Name = name;
        }

        public void AssignPk()
        {
            pk = count++;
        }

    }
}
