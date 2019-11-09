using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Visit : IPrimaryKey
    {
        int pk;
        int count;
        public Doctor Doctor;
        public Service Service;
        public DateTime StartDate;
        public DateTime EndDate;

        public Visit(Doctor doctor, Service service, DateTime startDate, DateTime endDate)
        {
            AssignPk();
            this.Doctor = doctor;
            this.Service = service;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public void AssignPk()
        {
            pk = count++;
        }
    }
}
