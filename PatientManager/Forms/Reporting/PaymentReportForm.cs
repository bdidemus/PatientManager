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
    public partial class PaymentReportForm : Form
    {
        public PaymentReportForm(int patID, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            List<Database.Reporting.PaymentReportViewModel> paymentData = Database.Reporting.PaymentReportViewModel.getPaymentsReportViewModel(patID, startDate, endDate);
            paymentBindingSource.DataSource = paymentData;
            PaymentReport1.SetDataSource(paymentBindingSource);
        }
    }
}
