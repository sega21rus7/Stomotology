using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class PatientInsurancePolicy : PatientDocument
    {
        public PatientInsurancePolicy(int series, int number) 
            : base(series, number)
        {
        }
    }
}
