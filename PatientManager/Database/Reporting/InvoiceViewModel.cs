using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public partial class InvoiceViewModel
    {
        public int invID { get { return m_invID; } set { m_invID = value; } }
        public String itryName { get { return m_itryName; } set { m_itryName = value; } }
        public decimal ItryQty
        {
            get { return m_itryQty; }
            set { m_itryQty = value; }
        }
        public decimal LinePrice
        {
            get { return m_linePrice; }
            set { m_linePrice = value; }
        }
        public String ItryDesc
        {
            get { return m_itryDesc; }
            set { m_itryDesc = value; }
        }
        public decimal Line_Discount
        {
            get
            {
                return m_line_discount;
            }
            set
            {
                m_line_discount = value;
            }
        }
        public DateTime invDate { get { return m_invDate; } set { m_invDate = value; } }

        public patient Patient { get { return m_patient; } set { m_patient = value; } }
        public String patName { get { return m_patient.FullName; } }
        public String patAddress { get { return m_patient.patAddress; } }
        public String patAddress2 { get { return m_patient.patAddress2; } }
        public String patPhone { get { return m_patient.patPhoneNumber; } }
        public String patPCode { get { return m_patient.patPCode; } }
        public String patCity { get { return m_patient.patCity; } }

        public doctor Doctor { set { m_doctor = value; } get { return m_doctor; } }
        public String DoctorName { get { return m_doctor.docFullName; } }
        public String DocAddress { get { return m_doctor.docAddress; } }
        public String DocCity { get { return m_doctor.docCity; } }
        public String DocPhone { get { return m_doctor.docOfficeNumber; } }
        public String DocPCode { get { return m_doctor.docPCode; } }
        public String DocLic { get { return m_doctor.docLicence; } }
        public String DocLic2 { get { return m_doctor.docLicence2; } }

        // Invoice
        private int m_invID;
        private String m_itryName;
        private decimal m_itryQty;
        private decimal m_linePrice;
        private String m_itryDesc;
        private DateTime m_invDate;
        private decimal m_line_discount;

        // Patient
        private patient m_patient;

        // Doctor
        private doctor m_doctor;

        public static IQueryable<InvoiceViewModel> GetInvoices(int? invID)
        {
            var context = new PatientManagerEntities();
            var query = from inv in context.inv_line
                        where inv.invID == invID
                        select new InvoiceViewModel
                        {
                            invID = inv.invoice.invID,
                            itryName = inv.inventory.itryName,
                            ItryDesc = inv.inventory.itryDesc,
                            ItryQty = inv.itryQty,
                            LinePrice = (decimal)inv.linePrice,
                            Line_Discount = (decimal)inv.line_discount,
                            invDate = inv.invoice.invDate,
                            Patient = inv.invoice.patient,
                            Doctor = inv.invoice.doctor
                        };
            return query;
        }
    }
}
