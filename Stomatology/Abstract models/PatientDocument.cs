using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    abstract class PatientDocument
    {
        protected int series;
        protected int number;

        public PatientDocument(int series, int number)
        {
            this.series = series;
            this.number = number;
        }
    }
}
