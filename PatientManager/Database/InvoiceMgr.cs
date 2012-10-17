using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace PatientManager.Database
{
    public class InvoiceMgr : ADatabaseInteractor
    {
        private static InvoiceMgr m_singleton;

        private InvoiceMgr()
        {
            m_singleton = this;
        }

        public static InvoiceMgr Instance
        {
            get
            {
                if (m_singleton == null)
                {
                    m_singleton = new InvoiceMgr();
                }
                return m_singleton;
            }
        }

        public invoice getInvoiceByID(int invoiceID)
        {
            invoice inv = null;
            var query = from i in Context.invoices
                        where i.invID == invoiceID
                        select i;
            if (query != null)
            {
                inv = query.First();
            }
            return inv;
        }

        public IQueryable<invoice> getInvoicesByPatientID(int patID)
        {
            return from inv in Context.invoices
                   where inv.patID == patID
                   select inv;
        }

        public IQueryable<invoice> getInvoicesByPatientID(int patID, DateTime upTo)
        {
            return from inv in Context.invoices
                   where inv.patID == patID && inv.invDate < upTo
                   select inv;
        }

        public inv_line getLine(int invID, int itryID)
        {
            inv_line line = null;
            var query = from i in Context.inv_line
                        where i.invID == invID && i.itryID == itryID
                        select i;
            if (query != null)
            {
                line = query.First();
            }
            return line;
        }

        public IQueryable<inv_line> getLines(int invID)
        {
            return from line in Context.inv_line
                   where line.invID == invID
                   select line;
        }

        public void clearLinesFromInvoice(int invID)
        {
            var lines = getLines(invID);
            foreach (var line in lines)
            {
                Context.DeleteObject(line);
            }
            saveChanges();
        }


        //public IQueryable<CustomInvoiceObj> getInvoicesForGrid()
        //{
        //    return from inv in Context.invoices
        //           select new CustomInvoiceObj
        //           {
        //               PatientName = inv.patient.patFirstName + " " + inv.patient.patLastName,
        //               invID = inv.invID,
        //               Date = inv.invDate
        //           };
        //}

        public IQueryable<CustomInvoiceObj> getInvoicesForGridWithDateRange(DateTime startDate, DateTime endDate)
        {
            if (startDate != null && endDate != null)
            {
                startDate = startDate.Date;
                endDate = endDate.Date.AddDays(1);
            }
            else
            {
                return null;
            }

            return from inv in Context.invoices
                   where inv.invDate >= startDate && inv.invDate < endDate
                   select new CustomInvoiceObj
                   {
                       PatientName = inv.patient.patFirstName + " " + inv.patient.patLastName,
                       invID = inv.invID,
                       Date = inv.invDate
                   };
        }

        public IQueryable<CustomInvoiceObj> getInvoicesForGridWithDateRange(DateTime startDate, DateTime endDate, String name)
        {
            if (startDate != null && endDate != null)
            {
                startDate = startDate.Date;
                endDate = endDate.Date.AddDays(1);
            }
            else
            {
                return null;
            }

            return from inv in Context.invoices
                   where inv.invDate >= startDate && inv.invDate <= endDate &&
                   (inv.patient.patFirstName.StartsWith(name) || inv.patient.patLastName.StartsWith(name) || inv.patient.patPhoneNumber.StartsWith(name))
                   select new CustomInvoiceObj
                   {
                       PatientName = inv.patient.patFirstName + " " + inv.patient.patLastName,
                       invID = inv.invID,
                       Date = inv.invDate
                   };
        }

        public IQueryable<CustomInvoiceObj> getInvoicesForGridForPatient(int patID)
        {
            return from inv in Context.invoices
                   where inv.patient.patID == patID
                   select new CustomInvoiceObj
                   {
                       PatientName = inv.patient.patFirstName + " " + inv.patient.patLastName,
                       invID = inv.invID,
                       Date = inv.invDate
                   };
        }

        public IQueryable<CustomInvoiceObj> getInvoicesForGridWithLikeFirstName(String patFirstName, DateTime startDate, DateTime endDate)
        {
            DateTime newEndDate;
            startDate = startDate.Date;
            if (endDate != DateTime.MaxValue)
            {
                newEndDate = endDate.AddDays(1);
            }
            else
            {
                newEndDate = endDate;
            }
            return from inv in Context.invoices
                   where inv.invDate >= startDate && inv.invDate <= newEndDate &&
                   inv.patient.patFirstName.StartsWith(patFirstName)
                   select new CustomInvoiceObj
                   {
                       PatientName = inv.patient.patFirstName + " " + inv.patient.patLastName,
                       invID = inv.invID,
                       Date = inv.invDate
                   };
        }

        public IQueryable<CustomInvoiceObj> getInvoicesForGridWithLikeLastName(String patLastName, DateTime startDate, DateTime endDate)
        {
            DateTime newEndDate;
            startDate = startDate.Date;
            if (endDate != DateTime.MaxValue)
            {
                newEndDate = endDate.AddDays(1);
            }
            else
            {
                newEndDate = endDate;
            }
            return from inv in Context.invoices
                   where inv.invDate >= startDate && inv.invDate <= newEndDate &&
                   inv.patient.patLastName.StartsWith(patLastName)
                   select new CustomInvoiceObj
                   {
                       PatientName = inv.patient.patFirstName + " " + inv.patient.patLastName,
                       invID = inv.invID,
                       Date = inv.invDate
                   };
        }

        public IQueryable<invoice> getInovices(int? invID)
        {
            var query = from inv in Context.invoices
                        select inv;
            return query;

        }

        public IQueryable<invoice> getInvoices()
        {
            return Context.invoices;
        }



        public int addNewInvoice(invoice inv)
        {
            Context.AddToinvoices(inv);
            saveChanges();
            return inv.invID;
        }

        /// <summary>
        /// Add a new line to an existing invoice
        /// </summary>
        /// <param name="invID">ID of the invoice to add a new line to</param>
        /// <param name="itryID">If of the inventory item to add</param>
        /// <param name="qty">Quantity of inventory item to add</param>
        public void addLineToInvoice(int invID, int itryID, int qty, decimal? price)
        {
            inv_line line = new inv_line();
            line.invID = invID;
            line.itryQty = qty;
            line.itryID = itryID;
            line.linePrice = price;
            Context.AddToinv_line(line);
            saveChanges();
        }

        /// <summary>
        /// Add new line to invoice from pre defined object
        /// </summary>
        /// <param name="lineobj"></param>
        public void addLineToInvoice(inv_line lineobj)
        {
            Context.AddToinv_line(lineobj);
            saveChanges();
        }

        /// <summary>
        /// Remove a line from an invoice. Needs a composite key consisting of
        /// invoiceID and inventoryID
        /// </summary>
        /// <param name="invID">invoice id</param>
        /// <param name="itryID">inventory id</param>
        /// <returns></returns>
        public bool removeLineFromInvoice(int invID, int itryID)
        {
            try
            {
                Context.DeleteObject(getLine(invID, itryID));
            }
            catch (NullReferenceException)
            {
                return false; // object doesn't exist
            }
            return true;
        }

        public void changeStatus(int statusID, invoice inv)
        {
            inv.invStatus = statusID;
            saveChanges();
        }

        public decimal getInvoiceTotal(int invID)
        {
            return getInvoiceTotal(getInvoiceByID(invID));
        }

        public decimal getInvoiceTotal(invoice inv)
        {
            decimal total = 0;
            if (inv != null)
            {
                foreach (inv_line invLine in inv.inv_line)
                {
                    if (invLine.linePrice != null)
                    {
                        total += (decimal)invLine.linePrice * invLine.itryQty;
                    }
                }
            }

            return total;
        }

        public decimal getPatientsTotalBilling(int patID)
        {
            decimal total = 0;
            List<invoice> invoices = getInvoicesByPatientID(patID).ToList();
            foreach (var inv in invoices)
            {
                total += getInvoiceTotal(inv.invID);
            }

            return total;
        }

        public decimal getPatientsTotalBilling(int patID, DateTime upTo)
        {
            decimal total = 0;
            List<invoice> invoices = getInvoicesByPatientID(patID, upTo).ToList();
            foreach (var inv in invoices)
            {
                total += getInvoiceTotal(inv.invID);
            }

            return total;
        }

        public void deleteInvoice(invoice inv)
        {
            clearLinesFromInvoice(inv.invID);
            Context.DeleteObject(getInvoiceByID(inv.invID));
            saveChanges();
        }

        public List<int> getOutstandingInvoices(int patID)
        {
            List<int> invList = new List<int>();

            var query = getInvoicesByPatientID(patID).ToList();
            foreach (invoice inv in query)
            {
                decimal oweing = getInvoiceAmountOweing(inv);
                if (oweing > 0)
                {
                    invList.Add(inv.invID);
                }
            }

            return invList;
        }

        public decimal getInvoiceAmountOweing(int invID)
        {
            return getInvoiceAmountOweing(getInvoiceByID(invID));
        }

        public decimal getInvoiceAmountOweing(invoice inv)
        {
            decimal total = getInvoiceTotal(inv);
            foreach (payment p in inv.payments)
            {
                total -= p.payAmount;
            }
            return total;
        }
    }

    public partial class CustomInvoiceObj
    {
        public int invID
        {
            get
            {
                return m_invID;
            }
            set
            {
                m_invID = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return m_date;
            }
            set
            {
                m_date = value;
            }
        }

        public String PatientName
        {
            get
            {
                return m_patientName;
            }
            set
            {
                m_patientName = value;
            }
        }

        public decimal Total
        {
            get
            {
                return imgr.getInvoiceTotal(invID);
            }
        }

        private static InvoiceMgr imgr = InvoiceMgr.Instance;
        private int m_invID;
        private DateTime m_date;
        private String m_patientName;
    }
}
