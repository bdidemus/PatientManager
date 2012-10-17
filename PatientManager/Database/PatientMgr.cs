using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public class PatientMgr : ADatabaseInteractor
    {
        public patient getPatient(int patID)
        {
            patient p = null;
            var query = from pat in Context.patients
                        where pat.patID == patID && pat.patActive
                        select pat;
            if (query.Count() == 1)
            {
                p = query.First();
            }
            return p;
        }

        public IQueryable<patient> findPatientsByFirstNameLike(String name)
        {
            IQueryable<patient> query = null;
            if (name != null)
            {
                query = from pat in Context.patients
                        where pat.patFirstName.StartsWith(name) && pat.patActive
                        select pat;
            }
            return query;
        }

        public IQueryable<patient> findPatientsByLastNameLike(String name)
        {
            IQueryable<patient> query = null;
            if (name != null)
            {
                query = from pat in Context.patients
                        where pat.patLastName.StartsWith(name) && pat.patActive
                        select pat;
            }
            return query;
        }

        public IQueryable<patient> findPatientByPhoneNumber(String phoneNumber)
        {
            IQueryable<patient> query = null;
            if (phoneNumber != null)
            {
                query = from pat in Context.patients
                        where pat.patPhoneNumber.Contains(phoneNumber) && pat.patActive
                        select pat;
            }
            return query;
        }

        public IQueryable<patient> getPatients()
        {
            return from pats in Context.patients
                   where pats.patActive
                   orderby pats.patLastName
                   select pats;
        }

        /// <summary>
        /// Best not to use this function unless the patient is brand new and won't
        /// trip any of the foreign key constraints. Best case is to use deactivePatient 
        /// for the soothing ease of soft delete
        /// </summary>
        /// <param name="patID"></param>
        public void deletePatient(int patID)
        {
            Context.patients.DeleteObject(getPatient(patID));
        }

        public void deactiveatePatient(int patID)
        {
            patient pat = getPatient(patID);
            pat.patActive = false;
            saveChanges();
        }

        public IQueryable<PastAppointmentsModel> getPastAppointments(int patID)
        {
            return from app in Context.appointments
                   where app.patID == patID
                   select new PastAppointmentsModel
                   {
                       DoctorName = app.doctor.docFirstName + " " + app.doctor.docLastName,
                       AppDate = app.appDate,
                       AppDateCreated = app.appDateCreate
                   };
        }
    }

    public class PastAppointmentsModel
    {
        private String doctorName;

        public String DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }
        private DateTime appDate;

        public DateTime AppDate
        {
            get { return appDate; }
            set { appDate = value; }
        }
        private DateTime appDateCreated;

        public DateTime AppDateCreated
        {
            get { return appDateCreated; }
            set { appDateCreated = value; }
        }
    }

    public class PatientAccountViewModel
    {
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private String type;

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
