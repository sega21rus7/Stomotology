using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class PatientPassport : PatientDocument
    {
        public PatientPassport(int series, int number)
            : base(series, number)
        {
        }
    }
}
