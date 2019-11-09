using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class PatientInsurancePolicy : IPrimaryKey
    {
        int pk;
        int count;
        int series;
        int number;

        public PatientInsurancePolicy(int series, int number)
        {
            this.series = series;
            this.number = number;
        }

        public void AssignPk()
        {
            pk = count++;
        }
    }
}
