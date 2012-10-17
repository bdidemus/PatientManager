using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database.Reporting
{
    class PaymentReportViewModel
    {
        public patient Patient { get { return m_patient; } set { m_patient = value; } }
        public String patName { get { return m_patient.FullName; } }
        public String patAddress { get { return m_patient.patAddress; } }
        public String patAddress2 { get { return m_patient.patAddress2; } }
        public String patPhone { get { return m_patient.patPhoneNumber; } }
        public String patPCode { get { return m_patient.patPCode; } }
        public String patCity { get { return m_patient.patCity; } }
        public decimal AccountBalance { get { return m_patient.AccountBalance; } }

        public doctor Doctor { set { m_doctor = value; } get { return m_doctor; } }
        public String DoctorName { get { return m_doctor.docFullName; } }
        public String DocAddress { get { return m_doctor.docAddress; } }
        public String DocCity { get { return m_doctor.docCity; } }
        public String DocPhone { get { return m_doctor.docOfficeNumber; } }
        public String DocPCode { get { return m_doctor.docPCode; } }
        public String DocLic { get { return m_doctor.docLicence; } }
        public String DocLic2 { get { return m_doctor.docLicence2; } }

        public DateTime StartDate { get { return m_startDate.Date; } set { m_startDate = value; } }
        public DateTime EndDate { get { return m_endDate.Date; } set { m_endDate = value; } }

        // Patient
        private patient m_patient;

        // Doctor
        private doctor m_doctor;

        //  Payment
        private payment m_payment;

        public payment Payment { get { return m_payment; } set { m_payment = value; } }

        private DateTime m_startDate = DateTime.Today;
        private DateTime m_endDate = DateTime.Today;

        public String payType
        {
            get
            {
                String ret = String.Empty;
                if (m_payment != null)
                    ret = m_payment.payment_type.ptName;
                return ret;

            }
        }

        public decimal payAmount
        {
            get
            {
                Decimal ret = new Decimal();
                if (m_payment != null)
                    ret = m_payment.payAmount;
                return ret;
            }
        }

        public DateTime payDate { get { return m_payment.payDate; } }

        public static List<PaymentReportViewModel> getPaymentsReportViewModel(int patID,
            DateTime startRange, DateTime endRange)
        {
            var context = new PatientManagerEntities();
            List<PaymentReportViewModel> payments = (from prvm in context.payments
                   where prvm.patID == patID && prvm.payDate >= startRange.Date && prvm.payDate <= endRange.Date
                   select new PaymentReportViewModel
                   {
                       Patient = prvm.patient,
                       Doctor = prvm.doctor,
                       Payment = prvm,

                   }).ToList();

            /* For some retarded reason I cant set these date range values in the linq query.
             * It throws a string value execption. So i have to reinterate the list and manually set it. So stupid*/
            foreach (var p in payments)
            {
                p.StartDate = startRange;
                p.EndDate = endRange;
            }

            return payments;
        }

        public static List<PaymentReportViewModel> getPaymentsReportViewModel(int patID, int invID)
        {
            var context = new PatientManagerEntities();
            List<PaymentReportViewModel> payments = (from prvm in context.payments
                                                     where prvm.patID == patID && prvm.invID == invID
                                                     select new PaymentReportViewModel
                                                     {
                                                         Patient = prvm.patient,
                                                         Doctor = prvm.doctor,
                                                         Payment = prvm,

                                                     }).ToList();
            return payments;
        }
    }
}
