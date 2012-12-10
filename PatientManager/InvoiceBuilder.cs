using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager
{
    public class InvoiceBuilder
    {
        private LinkedList<Database.inv_line> m_lstInvLine = new LinkedList<Database.inv_line>();
        private Database.invoice m_invoice;
        private bool m_bIsSaved;
        private Database.InvoiceMgr m_invMgr;
        private Database.InventoryMgr m_itryMgr = new Database.InventoryMgr();

        public InvoiceBuilder(int invID)
        {
            m_invMgr = Database.InvoiceMgr.Instance;
            m_invoice = Database.InvoiceMgr.Instance.getInvoiceByID(invID);
            foreach (Database.inv_line line in m_invoice.inv_line)
            {
                m_lstInvLine.AddLast(line);
            }
            m_bIsSaved = true;
        }

        public InvoiceBuilder()
        {
            m_invoice = new Database.invoice();
            m_bIsSaved = false;
        }

        /// <summary>
        /// Add a new item to an invoice, this version is used when the invoice ID is known
        /// </summary>
        /// <param name="invID"></param>
        /// <param name="itryID"></param>
        /// <param name="qty"></param>
        /// <param name="price"></param>
        public Database.inventory addNewItem(int invID, int itryID, int qty, decimal? price = null, decimal discount = 0)
        {
            Database.inventory item = m_itryMgr.getItemByID(itryID);
            price = (price == null) ? item.itrySellingPrive : price;
            Database.inv_line inv_line = new Database.inv_line();
            inv_line.invID = invID;
            inv_line.itryQty = qty;
            inv_line.itryID = itryID;
            inv_line.linePrice = price;
            inv_line.line_discount = discount;
            m_lstInvLine.AddLast(inv_line);
            return item;
        }

        public void modifyItemPrice(int row, decimal newPrice)
        {
            m_lstInvLine.ElementAt(row).linePrice = newPrice;
        }

        public void modifyItemQuanity(int row, int qty)
        {
            m_lstInvLine.ElementAt(row).itryQty = qty;
        }

        public void modifyItemDiscount(int row, decimal discount)
        {
            m_lstInvLine.ElementAt(row).line_discount = discount;
        }

        /// <summary>
        /// Add a new item to an invoice, this version is used when the invoice ID is not know
        /// </summary>
        /// <param name="itryID"></param>
        /// <param name="qty"></param>
        public Database.inventory addNewItem(int itryID, int qty)
        {
            return addNewItem(-1, itryID, qty, m_itryMgr.getItemByID(itryID).itrySellingPrive);
        }

        public bool removeLine(int lineID)
        {
            if (m_lstInvLine.Count > 0)
            {
                try
                {
                    m_lstInvLine.Remove(m_lstInvLine.ElementAt(lineID));
                }
                catch (Exception) { return false; }
            }
            return true;
        }

        public int saveInvoice(int patID, int statusID, int docID, DateTime date)
        {
            int invID = -1;
            try
            {
                if(m_bIsSaved)
                {
                    if (m_bIsSaved)
                    {
                        Database.InvoiceMgr.Instance.clearLinesFromInvoice(m_invoice.invID);
                    }
                }
                m_invoice.patID = patID;
                m_invoice.invDate = date;
                m_invoice.invStatus = statusID;

                m_invoice.docID = docID;
                m_invoice.invCommitted = true;
                foreach (var line in m_lstInvLine)
                {
                    m_invoice.inv_line.Add(line);
                }
                if (!m_bIsSaved)
                {
                    invID = Database.InvoiceMgr.Instance.addNewInvoice(m_invoice);
                }
                else
                {
                    Database.InvoiceMgr.Instance.saveChanges();
                    // give it the invID to appease the error checker thats really only used for new invoices
                    invID = m_invoice.invID; 
                }
            }
            catch(Exception ex)
            {
            }
            return invID;
        }

        public void changeStatus(int statusID)
        {
            if (m_bIsSaved)
            {
                m_invMgr.changeStatus(statusID, m_invoice);
            }
        }

        public Database.invoice Invoice
        {
            get
            {
                return m_invoice;
            }
        }

        public bool IsSaved
        {
            get
            {
                return m_bIsSaved;
            }
            set
            {
                m_bIsSaved = value;
            }
        }

        public bool itemAlreadyOnInvoice(int itryID)
        {
            foreach (var item in m_lstInvLine)
            {
                if (item.itryID == itryID)
                {
                    return true;
                }
            }
            return false;
        }

        public void deleteInvoice(Database.invoice inv)
        {
            Database.InvoiceMgr.Instance.deleteInvoice(inv);
        }

        /// <summary>
        /// Sets the status field in the database to 1 or 0. Right now 
        /// this filed is only used to determine if an  invoice has been written 
        /// off or not.
        /// A written off invoice does not show up in any quries and does not
        /// affect a patients account or any accounting summary reports.
        /// </summary>
        /// <param name="writeOff"></param>
        public void writeOffInvoice(bool writeOff)
        {
            m_invoice.invStatus = (writeOff) ? 1 : 0;
        }
    }
}
