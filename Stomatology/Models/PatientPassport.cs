using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class PatientPassport : PatientDocument
    {
        public static string ClassName = "PatientPassport";
        public static string TableName = "Паспортные данные пациентов";

        public PatientPassport(int series, int number)
            : base(series, number)
        {
        }
    }
}
