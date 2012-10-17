using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientManager.Forms.Reporting
{
    public partial class InvoiceReportForm : Form
    {
        public InvoiceReportForm(int invID, int patID, DateTime startRange, DateTime endRange)
        {
            InitializeComponent();

            report = new InvoiceReport();
            InvoiceViewModelBindingSource.DataSource = Database.InvoiceRepository.GetInvoices(invID);
            report.SetDataSource(InvoiceViewModelBindingSource);

            crystalReportViewer1.ReportSource = report;
        }

        private CrystalDecisions.CrystalReports.Engine.ReportClass report;
    }
}
