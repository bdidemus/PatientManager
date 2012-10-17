using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public partial class patient
    {
        public String FullName
        {
            get
            {
                return patFirstName + " " + patLastName;
            }
        }

        public decimal AccountBalance
        {
            get
            {
                Database.InvoiceMgr invMgr = InvoiceMgr.Instance;
                Database.PaymentMgr payMgr = new Database.PaymentMgr();

                return payMgr.getPatientTotalPayments(this.patID) - invMgr.getPatientsTotalBilling(this.patID);
            }
        }

        public decimal prevAccountBalance(DateTime upTo)
        {
            Database.InvoiceMgr invMgr = InvoiceMgr.Instance;
            Database.PaymentMgr payMgr = new Database.PaymentMgr();

            return payMgr.getPatientTotalPayments(this.patID, upTo) - invMgr.getPatientsTotalBilling(this.patID, upTo);
        }
    }
}
