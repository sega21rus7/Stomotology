using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class PatientInsurancePolicy : PatientDocument
    {
        public static string ClassName = "PatientInsurancePolicy";
        public static string TableName = "Страховые полисы пациентов";

        public PatientInsurancePolicy(int series, int number) 
            : base(series, number)
        {
        }
    }
}
