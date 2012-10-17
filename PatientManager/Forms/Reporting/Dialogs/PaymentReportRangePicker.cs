using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms.Reporting
{
    public class PaymentReportRangePicker : IntervalPickerDialog
    {
        private int m_nPatID;

        public PaymentReportRangePicker(int patID) : base(MainParent.MainMDIParent)
        {
            m_nPatID = patID;
        }

        protected override void btnGenerate_Click(object sender, EventArgs e) 
        {
            if (dtStart.Value < dtEnd.Value)
            {
                PaymentReportForm pRprt = new PaymentReportForm(m_nPatID, dtStart.Value, dtEnd.Value);
                pRprt.MdiParent = mdi;
                pRprt.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Bad values for date range");
            }
        }
    }
}
