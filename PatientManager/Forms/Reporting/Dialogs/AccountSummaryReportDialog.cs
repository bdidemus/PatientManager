using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms
{
    public partial class AccountSummaryReportDialog : Form
    {
        public AccountSummaryReportDialog(Form mdiParent)
        {
            InitializeComponent();
            dtStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            doctorBindingSource.DataSource = m_docMgr.getDoctors();
            cbDoctors.DisplayMember = "docFullName";

            m_mdiParent = mdiParent;
        }

        private Database.DoctorMgr m_docMgr = new Database.DoctorMgr();
        private Form m_mdiParent;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dtStart.Value > dtEnd.Value)
            {
                MessageBox.Show("Start date cannot be past the end date");
            }
            if (cbDoctors.SelectedValue == null)
            {
                return;
            }
            else
            {
                MonthEndReportForm frmMonthEnd = new MonthEndReportForm(dtStart.Value, dtEnd.Value, (int)cbDoctors.SelectedValue);
                frmMonthEnd.MdiParent = m_mdiParent;
                frmMonthEnd.Show();
                Close();
            }
        }
    }
}
