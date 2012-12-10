using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public class PaymentMgr : ADatabaseInteractor
    {
        public IQueryable<payment> getPayments()
        {
            return Context.payments;
        }

        public IQueryable<payment> getTodaysPayments()
        {
            DateTime yesterday = DateTime.Today.AddDays(-1);
            return from p in Context.payments
                   where p.payDate > yesterday
                   select p;
        }

        public IQueryable<payment> getPaymentsForDay(DateTime day)
        {
            DateTime dayAfter = day.AddDays(1);
            return from p in Context.payments
                   where p.payDate >= day && p.payDate < dayAfter
                   select p;
        }

        public payment getPayment(int payID)
        {
            payment pay = null;
            var query = from p in Context.payments
                        where p.payID == payID
                        select p;
            if (query.Count() > 0)
            {
                pay = query.First();
            }
            return pay;
        }

        public IQueryable<payment> getPaymentsForPatient(int patID)
        {
            return from p in Context.payments
                   where p.patID == patID
                   select p;
        }

        public IQueryable<payment> getPaymentsForPatient(int patID, DateTime upTo)
        {
            return from p in Context.payments
                   where p.patID == patID && p.payDate < upTo
                   select p;
        }

        public IQueryable<payment> getPaymentsForPatient(int patID, DateTime startDate, DateTime endDate)
        {
            return from p in Context.payments
                   where p.patID == patID && p.payDate >= startDate && p.payDate <= endDate
                   select p;
        }

        public decimal getPatientTotalPayments(int patID)
        {
            decimal total = 0;
            IQueryable<payment> pay = getPaymentsForPatient(patID);
            foreach(var p in pay)
            {
                total += p.payAmount;
            }
            return total;
        }


        public decimal getPatientTotalPayments(int patID, DateTime upTo)
        {
            decimal total = 0;
            IQueryable<payment> pay = getPaymentsForPatient(patID, upTo.Date);
            foreach (var p in pay)
            {
                total += p.payAmount;
            }
            return total;
        }

        public decimal getPatientTotalPayments(int patID, DateTime startDate, DateTime endDate)
        {
            decimal total = 0;
            IQueryable<payment> pay = getPaymentsForPatient(patID, startDate.Date, endDate.Date);
            foreach (var p in pay)
            {
                total += p.payAmount;
            }
            return total;
        }

        public int insertPayment(decimal amount, int paymentType, int patID, int docID, DateTime date)
        {
            payment p = new payment();

            p.payAmount = amount;
            p.payVoid = false;
            p.payDate = date;
            p.ptID = paymentType;
            p.patID = patID;
            p.docID = docID;

            Context.AddTopayments(p);
            saveChanges();

            return p.payID;
        }

        public void voidPayment(int payID)
        {
            getPayment(payID).payVoid = true;
            saveChanges();
        }

        public void deVoidPayment(int payID)
        {
            getPayment(payID).payVoid = false;
            saveChanges();
        }

        public IQueryable<payment_type> getPaymentTypes()
        {
            return Context.payment_type;
        }

        public IQueryable<PaymentsViewModel> getPaymentViewModelForToday()
        {
            DateTime today = DateTime.Today.Date;
            return (from p in Context.payments
                   where p.payDate >= today
                   select new PaymentsViewModel
                   {
                       PayAmount = p.payAmount,
                       PayDate = p.payDate,
                       PayID = p.payID,
                       PatientName = p.patient.patFirstName + " " + p.patient.patLastName,
                       PayType = p.payment_type.ptName,
                       DoctorName = p.doctor.docFirstName + " " + p.doctor.docLastName
                   }).OrderByDescending(pvm => pvm.PayID);
        }

        public IQueryable<PaymentsViewModel> getPaymentViewModelForDay(DateTime day)
        {
            day = day.Date;
            DateTime nextDay = day.AddDays(1);
            return (from p in Context.payments
                   where p.payDate >= day && p.payDate < nextDay
                   select new PaymentsViewModel
                   {
                       PayAmount = p.payAmount,
                       PayDate = p.payDate,
                       PayID = p.payID,
                       PatientName = p.patient.patFirstName + " " + p.patient.patLastName,
                       PayType = p.payment_type.ptName,
                       DoctorName = p.doctor.docFirstName + " " + p.doctor.docLastName
                   }).OrderByDescending(pvm => pvm.PayID);
        }

        public IQueryable<AccountsReportingView> getMonthlyReportView(DateTime dateStart, DateTime dateEnd, int docID)
        {
            return from at in Context.AccountingTotals
                   where at.date >= dateStart.Date && at.date <= dateEnd.Date && at.docID == docID
                   select new AccountsReportingView
                   {
                       Date = (DateTime)at.date,
                       DocName = "Dr. " + at.doctor.docFirstName + " " + at.doctor.docLastName,
                       Total = (decimal)at.total,
                       Type = at.TYPE
                   };
        }

        public void assocPaymentWithInvoice(int payID, int invID)
        {
            payment p = getPayment(payID);
            if (p != null)
            {
                p.invID = invID;
                saveChanges();
            }
        }

        /// <summary>
        /// Change a payment.
        /// </summary>
        /// <param name="pay"></param>
        /// <param name="amount"></param>
        /// <param name="docID"></param>
        /// <param name="ptID"></param>
        /// <param name="date">Optional, null to ignore</param>
        public void changePayment(payment pay, decimal amount, int docID, int ptID, DateTime date)
        {
            pay.payAmount = amount;
            pay.docID = docID;
            pay.ptID = ptID;
            if (date != null)
            {
                pay.payDate = date;
            }

            saveChanges();
        }

        public void deletePayment(int payID)
        {
            Context.payments.DeleteObject(getPayment(payID));
            saveChanges();
        }

    }

    public class PaymentsViewModel
    {
        public int PayID
        {
            get { return payID; }
            set { payID = value; }
        }
       
        public decimal PayAmount
        {
            get { return payAmount; }
            set { payAmount = value; }
        }        

        public DateTime PayDate
        {
            get { return payDate; }
            set { payDate = value; }
        }    

        public String PayType
        {
            get { return payType; }
            set { payType = value; }
        }     

        public String PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        public String doctorName;
        public String DoctorName
        {
            get { return this.doctorName; }
            set { this.doctorName = value; }
        }

        private String patientName;
        private String payType;
        private DateTime payDate;
        private decimal payAmount;
        private int payID;
    }

    public class AccountsReportingView
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date.Date; } // Just want the date portion, the time will screw up report grouping
            set { date = value; }
        }
        private String docName;

        public String DocName
        {
            get { return docName; }
            set { docName = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        private String type;

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
