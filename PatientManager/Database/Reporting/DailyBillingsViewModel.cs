using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace PatientManager.Database.Reporting
{
    public class DailyBillingsViewModel
    {
        private static PaymentMgr m_payMgr = new PaymentMgr();

        private patient m_patient;

        public patient Patient
        {
            get { return m_patient; }
            set { m_patient = value; }
        }

        private doctor m_doctor;

        public doctor Doctor
        {
            get { return m_doctor; }
            set { m_doctor = value; }
        }

        public String DocName { get { return m_doctor.docFullName; } }
        public String PatName { get { return m_patient.FullName; } }

        private decimal billed = 0;
        public decimal Billed 
        {
            set
            {
                billed += value;
            }

            get 
            { 
                return billed; 
            } 
        }


        private decimal paymentTotal = 0;
        public decimal Payment 
        { 
            get
            {
                return paymentTotal;
            }
            set
            {
                paymentTotal += value;
            }
        }

        public decimal PatAcctBalance
        {
            get
            {
                return m_patient.AccountBalance;
            }
        }

        public static List<DailyBillingsViewModel> getDailyBillingsViewModel(DateTime date, int docID)
        {
            var context = ADatabaseInteractor.Context;

            date = date.Date;
            DateTime nextDay = date.AddDays(1);

            // Get all the invoices for the day
            var query = from item in context.invoices
                        where item.invDate >= date && item.invDate < nextDay && item.invStatus != 1
                        select new
                        {
                            Patient = item.patient,
                            Invoice = item,
                            Doctor = item.doctor,
                        };
            // Restrict the daily invoices to specific doctor
            // to docotor if docID given
            if(docID != 0)
            {
                query = from item in query
                        where item.Doctor.docID == docID
                        select item;
            }

            // Keep a temp hashtable total of each invidual patients invoice
            // totals and payment totals for this day
            Hashtable totals = new Hashtable();

            // Add up all the invoice totals for the patients
            foreach(var invoice in query.ToList())
            {
                if (invoice.Patient != null)
                {
                    if (totals[invoice.Patient.patID] == null)
                    {
                        DailyBillingsViewModel record = new DailyBillingsViewModel();
                        record.Doctor = invoice.Doctor;
                        record.Patient = invoice.Patient;

                        totals[invoice.Patient.patID] = record;
                    }
                    ((DailyBillingsViewModel)totals[invoice.Patient.patID]).Billed = InvoiceMgr.Instance.getInvoiceTotal(invoice.Invoice);
                }
            }

            // Now do pretty much the same thing but for the payments
            var paymentQuery = from pay in context.payments
                               where pay.payDate >= date && pay.payDate < nextDay
                               select new
                               {
                                   Patient = pay.patient,
                                   Payment = pay,
                                   Doctor = pay.doctor
                               };
            if(docID != 0)
            {
                paymentQuery = from pay in paymentQuery
                               where pay.Doctor.docID == docID
                               select pay;
            }

            foreach (var pay in paymentQuery)
            {
                if (pay.Patient != null)
                {
                    if (totals[pay.Patient.patID] == null)
                    {
                        DailyBillingsViewModel record = new DailyBillingsViewModel();
                        record.Doctor = pay.Doctor;
                        record.Patient = pay.Patient;

                        totals[pay.Patient.patID] = record;
                    }
                    ((DailyBillingsViewModel)totals[pay.Patient.patID]).Payment = pay.Payment.payAmount;
                }
            }
           
            return new List<DailyBillingsViewModel>(totals.Values.Cast<DailyBillingsViewModel>());
        }
    }
}
