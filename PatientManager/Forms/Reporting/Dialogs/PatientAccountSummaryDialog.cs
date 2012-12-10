using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms.Reporting
{
    public class PatientAccountSummaryDialog : IntervalPickerDialog
    {
        public PatientAccountSummaryDialog(int patID, bool asDialog) : base(MainParent.MainMDIParent)
        {
            m_nPatID = patID;
        }

        protected override void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dtStart.Value < dtEnd.Value)
            {
                PatientItemizedStatementReport reprt = new PatientItemizedStatementReport(m_nPatID, dtStart.Value, dtEnd.Value);
                if(m_asDialog)
                {
                    reprt.ShowDialog();
                }
                else
                {
                    reprt.MdiParent = mdi;
                    reprt.Show();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Bad date selection");
            }
        }

        private int m_nPatID;
        private int p;
        private bool m_asDialog;
    }
}
