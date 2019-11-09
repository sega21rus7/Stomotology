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
        public Patient Patient;

        public Visit(Doctor doctor, Patient patient, Service service, DateTime startDate, DateTime endDate)
        {
            AssignPk();
            this.Doctor = doctor;
            this.Service = service;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Patient = patient;
        }

        internal Service Service1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Doctor Doctor1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Patient Patient1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void AssignPk()
        {
            pk = count++;
        }
    }
}
