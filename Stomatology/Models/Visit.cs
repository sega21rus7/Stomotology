using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stomatology.Models;

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
        public DoctorAssistent Assistent { get; set; }

        public Visit(Doctor doctor, DoctorAssistent assistent, Patient patient, 
            Service service, DateTime startDate, DateTime endDate)
        {
            AssignPk();
            this.Doctor = doctor;
            this.Service = service;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Patient = patient;
            this.Assistent = assistent;
        }

        public void AssignPk()
        {
            pk = count++;
        }
    }
}
