using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database.Reporting
{
    public class PatientAccountHistoryModel
    {

        private DateTime m_startDate;

        public DateTime StartDate
        {
            get { return m_startDate; }
            set { m_startDate = value; }
        }
        private DateTime m_endDate;

        public DateTime EndDate
        {
            get { return m_endDate; }
            set { m_endDate = value; }
        }

        private DateTime m_date;

        public DateTime Date
        {
            get { return m_date; }
            set { m_date = value; }
        }
        private String m_type;

        public String Type
        {
            get { return m_type; }
            set { m_type = value; }
        }
        private String m_description;

        public String Description
        {
            get { return m_description; }
            set { m_description = value; }
        }
        private int m_qty;

        public int Qty
        {
            get { return m_qty; }
            set { m_qty = value; }
        }
        private decimal m_amount;

        public decimal Amount
        {
            get { return (m_amount * Qty) - Discount; }
            set { m_amount = value; }
        }

        private decimal m_discount;

        public decimal Discount 
        { 
            set
            {
                m_discount = value;
            }
            get
            {
                return m_discount;
            }
        }


        public patient Patient { set { m_patient = value; } get { return m_patient; } }

        public String PatientName { get { return m_patient.FullName; } }
        public String PatientAddress { get { return m_patient.patAddress; } }
        public String PatientPCode { get { return m_patient.patPCode; } }
        public String PatientProv { get { return m_patient.patProv; } }
        public String PatientCity { get { return m_patient.patCity; } }
        public String PatientPhone { get { return m_patient.patPhoneNumber;  } }

        private patient m_patient;

        private doctor m_doctor;
        // Different from above doctor, doctor who is doing the billing for idividual item
        private doctor m_billingDoctor; 

        public doctor Doctor { set { m_doctor = value; } get { return m_doctor; } }
        public doctor BillingDoctor { set { m_billingDoctor = value; } get { return m_billingDoctor; } }

        public string BillingDoctorName { get { return m_billingDoctor.docFullName; } }
        public String DoctorName { get { return m_doctor.docFullName; } }
        public String DoctorAddress { get { return m_doctor.docAddress; } }
        public String DoctorPCode { get { return m_doctor.docPCode; } }
        public String DoctorCity { get { return m_doctor.docCity; } }
        public String DoctorLicense { get { return m_doctor.docLicence; } }
        public String DoctorLicense2 { get { return m_doctor.docLicence2; } }

        public static List<PatientAccountHistoryModel> getPatientHistoryModel(int patID, DateTime startDate, DateTime endDate)
        {
            var context = new PatientManagerEntities();
            var query = (from patHist in context.PatientAccountHistoryViews
                   where patHist.patID == patID && patHist.Date >= startDate.Date && patHist.Date <= endDate.Date
                   select new PatientAccountHistoryModel
                   {
                       Date = (DateTime)patHist.Date,
                       Patient = patHist.patient,
                       Doctor = patHist.patient.doctor,
                       BillingDoctor = patHist.doctor,
                       Type = patHist.Type,
                       Description = patHist.Description,
                       Qty = (patHist.itryQty != null) ? (int)patHist.itryQty : 1,
                       //Amount = (decimal)patHist.Amount - (decimal)patHist.line_discount
                       Amount = (decimal)patHist.Amount,
                       Discount = patHist.line_discount
                   }).ToList();
            // From what I'm assuming is a bug in mysql connector 4.6.5, I can't set the objects date fields while querying
            // for the data. So here is an extra stupid just to get the data in.
            foreach (var item in query)
            {
                item.StartDate = startDate;
                item.EndDate = endDate;
            }

            return query;
        }

        public static IQueryable<PatientAccountHistoryModel> getPatientHistoryModel(int patID)
        {
            var context = new PatientManagerEntities();
            return from patHist in context.PatientAccountHistoryViews
                   where patHist.patID == patID
                   select new PatientAccountHistoryModel
                   {
                       Date = (DateTime)patHist.Date,
                       Patient = patHist.patient,
                       Doctor = patHist.patient.doctor,
                       Type = patHist.Type,
                       Description = patHist.Description,
                       Qty = (patHist.itryQty != null) ? (int)patHist.itryQty : 1,
                       Amount = (decimal)patHist.Amount
                   };
        }

        internal static decimal getPatientPrevBalance(int patID, DateTime startDate)
        {
            decimal prevBalance = 0;

            PatientMgr patMgr = new PatientMgr();
            patient p = patMgr.getPatient(patID);
            if (p != null)
            {
                prevBalance = p.prevAccountBalance(startDate);
            }

            return prevBalance;
        }
    }
}
