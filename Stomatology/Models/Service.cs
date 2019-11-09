using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Service : IPrimaryKey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public ServiceType Type  { get; set; }

        public Service(string name, string price, ServiceType type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
    }
}
