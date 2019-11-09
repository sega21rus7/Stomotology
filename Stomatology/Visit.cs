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
        public DateTime StartDate;
        public DateTime EndDate;
        public Service Service { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; } 

        public Visit(Doctor doctor, Patient patient, Service service, DateTime startDate, DateTime endDate)
        {
            AssignPk();
            this.Doctor = doctor;
            this.Service = service;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Patient = patient;
        }

        public void AssignPk()
        {
            pk = count++;
        }
    }
}
