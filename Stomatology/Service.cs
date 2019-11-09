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
        public ServiceType Type { get; set; }

        internal ServiceType ServiceType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Service(string name, string price, ServiceType type)
        {
            AssignPk();
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public void AssignPk()
        {
            pk = count++;
        }
    }
}
