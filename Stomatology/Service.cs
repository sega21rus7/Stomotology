using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Service : IPrimaryKey
    {
        int pk;
        int count;
        public string Name { get; set; }
        public string Price { get; set; }
        //public string Type { get; set; }

        public Service(string name, string price)
        {
            AssignPk();
            this.Name = name;
            this.Price = price;
        }

        public void AssignPk()
        {
            pk = count++;
        }
    }
}
