using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;

namespace PatientManager.Forms
{
    public partial class MonthEndReportForm : Form
    {
        public MonthEndReportForm(DateTime dateStart, DateTime dateEnd, int docID)
        {
            InitializeComponent();

            ReportBindingSource.DataSource = m_paymentMgr.getMonthlyReportView(dateStart, dateEnd, docID);
            AccountingSummaryReport1.SetDataSource(ReportBindingSource);
        }

        private Database.PaymentMgr m_paymentMgr = new Database.PaymentMgr();
    }
}
