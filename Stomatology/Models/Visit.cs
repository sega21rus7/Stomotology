using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stomatology
{
    class Visit : IPrimaryKey
    {
        public static string ClassName = "Visit";
        public static string TableName = "Приемы";
        public int Id { get; set; }
        public DateTime StartDate;
        public DateTime EndDate;
        public Service Service { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; } 
        public DoctorAssistent Assistent { get; set; }

        public Visit(Doctor doctor, DoctorAssistent assistent, Patient patient, 
            Service service, DateTime startDate, DateTime endDate)
        {
            this.Doctor = doctor;
            this.Service = service;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Patient = patient;
            this.Assistent = assistent;
        }
    }
}
