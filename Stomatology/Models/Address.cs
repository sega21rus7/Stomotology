using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Address
    {
        public static string ClassName = "Address";
        public static string TableName = "Адреса пациентов";
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }

        public Address(string streetName, int houseNumber, int flatNumber)
        {
            this.StreetName = streetName;
            this.HouseNumber = houseNumber;
            this.FlatNumber = flatNumber;
        }
    }
}
